﻿using DBManager.Core.Presenters;
using DBManager.Core.Views.Engines;
using DBManager.Core.Views.Helpers;
using DBManager.Presenters;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager.Views
{
    public partial class DBManagerView : Form
    {
        private readonly IDBManagerPresenter _presenter;
        private readonly ConnectorMethods _connectorMethods;
        private readonly MessageHelper _messageHelper = new("DBManager");

        public DBManagerView(IDBManagerPresenter presenter)
        {
            _presenter = presenter;

            _connectorMethods = new ConnectorMethods
            {
                AddConnection = presenter.AddConnection,
                GetConnectionSettings = presenter.GetConnectionSettings,
                UpdateConnection = presenter.UpdateConnection
            };

            InitializeComponent();

            ConnectionTree_ConnectionTreeView.OnNodeSelected += ConnectionTree_ConnectionTreeView_OnNodeSelected;
            ConnectionTree_ConnectionTreeView.OnNodeBeforeExpanding += ConnectionTree_ConnectionTreeView_OnNodeBeforeExpanding;

            LoadConnections();
        }

        private async void ConnectionTree_ConnectionTreeView_OnNodeBeforeExpanding(object sender, TreeNodeElements e)
        {
            switch (e.Mode)
            {
                case TreeNodeMode.ConnectionSelected:
                    await LoadDatabases(e.Connection.Text);
                    break;
                case TreeNodeMode.DatabaseSelected:
                    await LoadTables(e.Connection.Name, e.Database.Text);
                    break;
                case TreeNodeMode.TableSelected:
                    break;
                default:
                    _messageHelper.ShowError("Unable to create view - incorrect engine type.");
                    return;
            }
        }

        private async void ConnectionTree_ConnectionTreeView_OnNodeSelected(object sender, TreeNodeElements e)
        {
            await Content_ContentManagerView.ChangeContent(e);

            RemoveConnection_Button.Enabled = true;
            UpdateConnection_Button.Enabled = true;

            Status_ConnectionStatusStrip.UpdateNodeStatus(e);
        }

        private void AddConnection_Button_Click(object sender, EventArgs e)
        {
            using var form = new ConnectorSelectorView(_presenter);
            form.ShowDialog();

            LoadConnections();
        }

        private void RemoveConnection_Button_Click(object sender, EventArgs e)
        {
            var nodes = ConnectionTree_ConnectionTreeView.LastSelectedNode;

            if (nodes == null)
                return;

            if (nodes.Mode == TreeNodeMode.NotSupported)
                return;

            var connectionName = nodes.Connection.Text;
            var status = _messageHelper.ShowQuestion($"Are you sure you want to delete the {connectionName} connection?");

            if (status == DialogResult.No)
                return;

            var response = _presenter.RemoveConnection(connectionName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError($"Unable to remove {connectionName} connection.", response.ErrorMessage);
                return;
            }

            if (Content_ContentManagerView.ClearViewIfNeeded(connectionName))
                Status_ConnectionStatusStrip.ClearNodeStatus();

            LoadConnections();
        }

        private void UpdateConnection_Button_Click(object sender, EventArgs e)
        {
            var nodes = ConnectionTree_ConnectionTreeView.LastSelectedNode;

            if (nodes == null)
                return;

            if (nodes.Mode == TreeNodeMode.NotSupported)
                return;

            string connectionName = nodes.Connection.Text;

            var connectionSettingsResponse = _presenter.GetConnectionSettings(connectionName);
            if (connectionSettingsResponse.Type == ResponseType.Error)
            {
                _messageHelper.ShowError($"Unable to get {nodes.Connection.Text} connection settings.", connectionSettingsResponse.ErrorMessage);
                return;
            }

            var engineType = connectionSettingsResponse.Payload.EngineType;

            var connectorViewTypeResponse = _presenter.GetConnectorViewType(engineType);
            if (connectorViewTypeResponse.Type == ResponseType.Error)
            {
                _messageHelper.ShowError($"Unable to get connector view type for {engineType} engine type.", connectorViewTypeResponse.ErrorMessage);
                return;
            }

            var connectorViewType = connectorViewTypeResponse.Payload.ConnectorViewType;

            var form = (Form)Activator.CreateInstance(
                connectorViewType,
                _connectorMethods,
                connectionName);

            var result = form.ShowDialog();

            if (result == DialogResult.OK)
                LoadConnections();
        }

        private void LoadConnections()
        {
            var response = _presenter.GetConnectionNames();
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to load connection list.", response.ErrorMessage);
                return;
            }

            var payload = response.Payload;

            ConnectionTree_ConnectionTreeView.LoadConnections(payload.Names);

            Status_ConnectionStatusStrip.UpdateNumberOfConnectionsStatus(payload.Names.Count);
        }

        private async Task LoadDatabases(string connectionName)
        {
            var response = await _presenter.GetDatabaseNames(connectionName);
            if (response.Type == ResponseType.Error)
            {
                ConnectionTree_ConnectionTreeView.CollapseNode(connectionName);
                _messageHelper.ShowError($"Unable to load database list for {connectionName} connection.", response.ErrorMessage);
                return;
            }

            var payload = response.Payload;

            ConnectionTree_ConnectionTreeView.LoadDatabases(connectionName, payload.Names);
        }

        private async Task LoadTables(string connectionName, string databaseName)
        {
            var response = await _presenter.GetTableNames(connectionName, databaseName);
            if (response.Type == ResponseType.Error)
            {
                ConnectionTree_ConnectionTreeView.CollapseNode(connectionName, databaseName);
                _messageHelper.ShowError($"Unable to load table list for {connectionName} connection and {databaseName} database.", response.ErrorMessage);
                return;
            }

            var payload = response.Payload;

            ConnectionTree_ConnectionTreeView.LoadTables(connectionName, databaseName, payload.Names);
        }
    }
}
