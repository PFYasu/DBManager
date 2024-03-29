﻿
namespace DBManager.Views.Engines
{
    partial class TableView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TableView_TabControl = new System.Windows.Forms.TabControl();
            this.Browse = new System.Windows.Forms.TabPage();
            this.UnsupportedColumns_Browse_Button = new System.Windows.Forms.Button();
            this.Name_Browse_Label = new System.Windows.Forms.Label();
            this.Structure_Browse_DataGridView = new System.Windows.Forms.DataGridView();
            this.Elements_Browse_Label = new System.Windows.Forms.Label();
            this.TableData_Browse_Label = new System.Windows.Forms.Label();
            this.Structure = new System.Windows.Forms.TabPage();
            this.CustomInformations_Structure_Label = new System.Windows.Forms.Label();
            this.CustomInformations_Structure_ListView = new System.Windows.Forms.ListView();
            this.Name_Structure_Label = new System.Windows.Forms.Label();
            this.Structure_Structure_DataGridView = new System.Windows.Forms.DataGridView();
            this.Columns_Structure_Label = new System.Windows.Forms.Label();
            this.Records_Structure_Label = new System.Windows.Forms.Label();
            this.Statistics_Structure_Label = new System.Windows.Forms.Label();
            this.TableStructure_Structure_Label = new System.Windows.Forms.Label();
            this.structure_columnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structure_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableView_TabControl.SuspendLayout();
            this.Browse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Structure_Browse_DataGridView)).BeginInit();
            this.Structure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Structure_Structure_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TableView_TabControl
            // 
            this.TableView_TabControl.Controls.Add(this.Browse);
            this.TableView_TabControl.Controls.Add(this.Structure);
            this.TableView_TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableView_TabControl.Location = new System.Drawing.Point(0, 0);
            this.TableView_TabControl.Margin = new System.Windows.Forms.Padding(0);
            this.TableView_TabControl.Name = "TableView_TabControl";
            this.TableView_TabControl.Padding = new System.Drawing.Point(10, 3);
            this.TableView_TabControl.SelectedIndex = 0;
            this.TableView_TabControl.Size = new System.Drawing.Size(800, 450);
            this.TableView_TabControl.TabIndex = 3;
            // 
            // Browse
            // 
            this.Browse.BackColor = System.Drawing.Color.White;
            this.Browse.Controls.Add(this.UnsupportedColumns_Browse_Button);
            this.Browse.Controls.Add(this.Name_Browse_Label);
            this.Browse.Controls.Add(this.Structure_Browse_DataGridView);
            this.Browse.Controls.Add(this.Elements_Browse_Label);
            this.Browse.Controls.Add(this.TableData_Browse_Label);
            this.Browse.Location = new System.Drawing.Point(4, 24);
            this.Browse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Browse.Name = "Browse";
            this.Browse.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Browse.Size = new System.Drawing.Size(792, 422);
            this.Browse.TabIndex = 0;
            this.Browse.Text = "Browse";
            // 
            // UnsupportedColumns_Browse_Button
            // 
            this.UnsupportedColumns_Browse_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UnsupportedColumns_Browse_Button.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnsupportedColumns_Browse_Button.ForeColor = System.Drawing.Color.Black;
            this.UnsupportedColumns_Browse_Button.Location = new System.Drawing.Point(630, 7);
            this.UnsupportedColumns_Browse_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UnsupportedColumns_Browse_Button.Name = "UnsupportedColumns_Browse_Button";
            this.UnsupportedColumns_Browse_Button.Size = new System.Drawing.Size(152, 27);
            this.UnsupportedColumns_Browse_Button.TabIndex = 22;
            this.UnsupportedColumns_Browse_Button.Text = "Unsupported columns";
            this.UnsupportedColumns_Browse_Button.UseVisualStyleBackColor = true;
            this.UnsupportedColumns_Browse_Button.Click += new System.EventHandler(this.UnsupportedColumns_Browse_Button_Click);
            // 
            // Name_Browse_Label
            // 
            this.Name_Browse_Label.AutoSize = true;
            this.Name_Browse_Label.BackColor = System.Drawing.Color.White;
            this.Name_Browse_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name_Browse_Label.ForeColor = System.Drawing.Color.Black;
            this.Name_Browse_Label.Location = new System.Drawing.Point(289, 10);
            this.Name_Browse_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_Browse_Label.Name = "Name_Browse_Label";
            this.Name_Browse_Label.Size = new System.Drawing.Size(64, 21);
            this.Name_Browse_Label.TabIndex = 21;
            this.Name_Browse_Label.Text = "Name: ";
            // 
            // Structure_Browse_DataGridView
            // 
            this.Structure_Browse_DataGridView.AllowUserToAddRows = false;
            this.Structure_Browse_DataGridView.AllowUserToDeleteRows = false;
            this.Structure_Browse_DataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Structure_Browse_DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Structure_Browse_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Structure_Browse_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.Structure_Browse_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Structure_Browse_DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Structure_Browse_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Structure_Browse_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Structure_Browse_DataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.Structure_Browse_DataGridView.EnableHeadersVisualStyles = false;
            this.Structure_Browse_DataGridView.GridColor = System.Drawing.Color.Silver;
            this.Structure_Browse_DataGridView.Location = new System.Drawing.Point(0, 38);
            this.Structure_Browse_DataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.Structure_Browse_DataGridView.Name = "Structure_Browse_DataGridView";
            this.Structure_Browse_DataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Structure_Browse_DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Structure_Browse_DataGridView.RowHeadersVisible = false;
            this.Structure_Browse_DataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.Structure_Browse_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Structure_Browse_DataGridView.Size = new System.Drawing.Size(791, 382);
            this.Structure_Browse_DataGridView.TabIndex = 6;
            this.Structure_Browse_DataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Structure_Browse_DataGridView_DataError);
            // 
            // Elements_Browse_Label
            // 
            this.Elements_Browse_Label.AutoSize = true;
            this.Elements_Browse_Label.BackColor = System.Drawing.Color.White;
            this.Elements_Browse_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Elements_Browse_Label.ForeColor = System.Drawing.Color.Black;
            this.Elements_Browse_Label.Location = new System.Drawing.Point(144, 10);
            this.Elements_Browse_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Elements_Browse_Label.Name = "Elements_Browse_Label";
            this.Elements_Browse_Label.Size = new System.Drawing.Size(88, 21);
            this.Elements_Browse_Label.TabIndex = 5;
            this.Elements_Browse_Label.Text = "Elements: ";
            // 
            // TableData_Browse_Label
            // 
            this.TableData_Browse_Label.AutoSize = true;
            this.TableData_Browse_Label.BackColor = System.Drawing.Color.White;
            this.TableData_Browse_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TableData_Browse_Label.ForeColor = System.Drawing.Color.Black;
            this.TableData_Browse_Label.Location = new System.Drawing.Point(8, 3);
            this.TableData_Browse_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TableData_Browse_Label.Name = "TableData_Browse_Label";
            this.TableData_Browse_Label.Size = new System.Drawing.Size(113, 30);
            this.TableData_Browse_Label.TabIndex = 3;
            this.TableData_Browse_Label.Text = "Table data";
            // 
            // Structure
            // 
            this.Structure.BackColor = System.Drawing.Color.White;
            this.Structure.Controls.Add(this.CustomInformations_Structure_Label);
            this.Structure.Controls.Add(this.CustomInformations_Structure_ListView);
            this.Structure.Controls.Add(this.Name_Structure_Label);
            this.Structure.Controls.Add(this.Structure_Structure_DataGridView);
            this.Structure.Controls.Add(this.Columns_Structure_Label);
            this.Structure.Controls.Add(this.Records_Structure_Label);
            this.Structure.Controls.Add(this.Statistics_Structure_Label);
            this.Structure.Controls.Add(this.TableStructure_Structure_Label);
            this.Structure.Location = new System.Drawing.Point(4, 24);
            this.Structure.Margin = new System.Windows.Forms.Padding(0);
            this.Structure.Name = "Structure";
            this.Structure.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Structure.Size = new System.Drawing.Size(792, 422);
            this.Structure.TabIndex = 1;
            this.Structure.Text = "Structure";
            // 
            // CustomInformations_Structure_Label
            // 
            this.CustomInformations_Structure_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomInformations_Structure_Label.AutoSize = true;
            this.CustomInformations_Structure_Label.BackColor = System.Drawing.Color.White;
            this.CustomInformations_Structure_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustomInformations_Structure_Label.ForeColor = System.Drawing.Color.Black;
            this.CustomInformations_Structure_Label.Location = new System.Drawing.Point(492, 12);
            this.CustomInformations_Structure_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomInformations_Structure_Label.Name = "CustomInformations_Structure_Label";
            this.CustomInformations_Structure_Label.Size = new System.Drawing.Size(175, 21);
            this.CustomInformations_Structure_Label.TabIndex = 23;
            this.CustomInformations_Structure_Label.Text = "Custom informations:";
            // 
            // CustomInformations_Structure_ListView
            // 
            this.CustomInformations_Structure_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomInformations_Structure_ListView.Location = new System.Drawing.Point(497, 38);
            this.CustomInformations_Structure_ListView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CustomInformations_Structure_ListView.Name = "CustomInformations_Structure_ListView";
            this.CustomInformations_Structure_ListView.Size = new System.Drawing.Size(284, 107);
            this.CustomInformations_Structure_ListView.TabIndex = 22;
            this.CustomInformations_Structure_ListView.UseCompatibleStateImageBehavior = false;
            this.CustomInformations_Structure_ListView.View = System.Windows.Forms.View.List;
            // 
            // Name_Structure_Label
            // 
            this.Name_Structure_Label.AutoSize = true;
            this.Name_Structure_Label.BackColor = System.Drawing.Color.White;
            this.Name_Structure_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name_Structure_Label.ForeColor = System.Drawing.Color.Black;
            this.Name_Structure_Label.Location = new System.Drawing.Point(10, 38);
            this.Name_Structure_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_Structure_Label.Name = "Name_Structure_Label";
            this.Name_Structure_Label.Size = new System.Drawing.Size(64, 21);
            this.Name_Structure_Label.TabIndex = 21;
            this.Name_Structure_Label.Text = "Name: ";
            // 
            // Structure_Structure_DataGridView
            // 
            this.Structure_Structure_DataGridView.AllowUserToAddRows = false;
            this.Structure_Structure_DataGridView.AllowUserToDeleteRows = false;
            this.Structure_Structure_DataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.Structure_Structure_DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Structure_Structure_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Structure_Structure_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Structure_Structure_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Structure_Structure_DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Structure_Structure_DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Structure_Structure_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Structure_Structure_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Structure_Structure_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.structure_columnNumber,
            this.structure_Name});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Structure_Structure_DataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.Structure_Structure_DataGridView.EnableHeadersVisualStyles = false;
            this.Structure_Structure_DataGridView.GridColor = System.Drawing.Color.Silver;
            this.Structure_Structure_DataGridView.Location = new System.Drawing.Point(0, 152);
            this.Structure_Structure_DataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Structure_Structure_DataGridView.Name = "Structure_Structure_DataGridView";
            this.Structure_Structure_DataGridView.ReadOnly = true;
            this.Structure_Structure_DataGridView.RowHeadersVisible = false;
            this.Structure_Structure_DataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.Structure_Structure_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Structure_Structure_DataGridView.Size = new System.Drawing.Size(791, 272);
            this.Structure_Structure_DataGridView.TabIndex = 16;
            // 
            // Columns_Structure_Label
            // 
            this.Columns_Structure_Label.AutoSize = true;
            this.Columns_Structure_Label.BackColor = System.Drawing.Color.White;
            this.Columns_Structure_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Columns_Structure_Label.ForeColor = System.Drawing.Color.Black;
            this.Columns_Structure_Label.Location = new System.Drawing.Point(10, 85);
            this.Columns_Structure_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Columns_Structure_Label.Name = "Columns_Structure_Label";
            this.Columns_Structure_Label.Size = new System.Drawing.Size(69, 20);
            this.Columns_Structure_Label.TabIndex = 15;
            this.Columns_Structure_Label.Text = "Columns:";
            // 
            // Records_Structure_Label
            // 
            this.Records_Structure_Label.AutoSize = true;
            this.Records_Structure_Label.BackColor = System.Drawing.Color.White;
            this.Records_Structure_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Records_Structure_Label.ForeColor = System.Drawing.Color.Black;
            this.Records_Structure_Label.Location = new System.Drawing.Point(10, 62);
            this.Records_Structure_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Records_Structure_Label.Name = "Records_Structure_Label";
            this.Records_Structure_Label.Size = new System.Drawing.Size(69, 20);
            this.Records_Structure_Label.TabIndex = 14;
            this.Records_Structure_Label.Text = "Records: ";
            // 
            // Statistics_Structure_Label
            // 
            this.Statistics_Structure_Label.AutoSize = true;
            this.Statistics_Structure_Label.BackColor = System.Drawing.Color.White;
            this.Statistics_Structure_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Statistics_Structure_Label.ForeColor = System.Drawing.Color.Black;
            this.Statistics_Structure_Label.Location = new System.Drawing.Point(9, 3);
            this.Statistics_Structure_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Statistics_Structure_Label.Name = "Statistics_Structure_Label";
            this.Statistics_Structure_Label.Size = new System.Drawing.Size(99, 30);
            this.Statistics_Structure_Label.TabIndex = 10;
            this.Statistics_Structure_Label.Text = "Statistics";
            // 
            // TableStructure_Structure_Label
            // 
            this.TableStructure_Structure_Label.AutoSize = true;
            this.TableStructure_Structure_Label.BackColor = System.Drawing.Color.White;
            this.TableStructure_Structure_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TableStructure_Structure_Label.ForeColor = System.Drawing.Color.Black;
            this.TableStructure_Structure_Label.Location = new System.Drawing.Point(8, 114);
            this.TableStructure_Structure_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TableStructure_Structure_Label.Name = "TableStructure_Structure_Label";
            this.TableStructure_Structure_Label.Size = new System.Drawing.Size(158, 30);
            this.TableStructure_Structure_Label.TabIndex = 2;
            this.TableStructure_Structure_Label.Text = "Table structure";
            // 
            // structure_columnNumber
            // 
            this.structure_columnNumber.HeaderText = "#";
            this.structure_columnNumber.Name = "structure_columnNumber";
            this.structure_columnNumber.ReadOnly = true;
            // 
            // structure_Name
            // 
            this.structure_Name.HeaderText = "Name";
            this.structure_Name.Name = "structure_Name";
            this.structure_Name.ReadOnly = true;
            // 
            // TableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TableView_TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TableView";
            this.Text = "MySqlTableView";
            this.TableView_TabControl.ResumeLayout(false);
            this.Browse.ResumeLayout(false);
            this.Browse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Structure_Browse_DataGridView)).EndInit();
            this.Structure.ResumeLayout(false);
            this.Structure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Structure_Structure_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl TableView_TabControl;
        private System.Windows.Forms.TabPage Browse;
        private System.Windows.Forms.TabPage Structure;
        private System.Windows.Forms.Label TableStructure_Structure_Label;
        private System.Windows.Forms.Label TableData_Browse_Label;
        private System.Windows.Forms.Label Elements_Browse_Label;
        private System.Windows.Forms.Label Columns_Structure_Label;
        private System.Windows.Forms.Label Records_Structure_Label;
        private System.Windows.Forms.Label Statistics_Structure_Label;
        private System.Windows.Forms.DataGridView Structure_Browse_DataGridView;
        private System.Windows.Forms.DataGridView Structure_Structure_DataGridView;
        private System.Windows.Forms.Label Name_Browse_Label;
        private System.Windows.Forms.Label Name_Structure_Label;
        private System.Windows.Forms.Button UnsupportedColumns_Browse_Button;
        private System.Windows.Forms.ListView CustomInformations_Structure_ListView;
        private System.Windows.Forms.Label CustomInformations_Structure_Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_columnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_Name;
    }
}