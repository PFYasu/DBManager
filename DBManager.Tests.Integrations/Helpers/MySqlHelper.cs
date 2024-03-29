﻿using DBManager.Core.Models;
using DBManager.Core.Utils;
using DBManager.EngineModule.MySql;
using MySqlConnector;

namespace DBManager.Tests.Integrations.Helpers;

public class MySqlHelper : IDisposable
{
    public readonly List<ConnectionStructure> _connectionStructures = new();
    private readonly string _connectionString;
    public readonly Dictionary<string, string> ConnectionParameters = new();

    public MySqlHelper()
    {
        var connectionString = Environment.GetEnvironmentVariable(ConnectionStringEnvironmentVariable);

        _connectionString = connectionString;
        ConnectionParameters = ConnectorHelper.CombineToDictionary(connectionString);
    }

    public const string ConnectionStringEnvironmentVariable = "DBM_MYSQL_CS";

    public MySqlPresenter CreatePresenter()
    {
        var connection = new Connection
        {
            Name = NamesGenerator.Generate(),
            EngineType = "MySql",
            ConnectionParameters = ConnectionParameters,
            TrackedQueries = new List<TrackedQuery>()
        };

        var model = new MySqlModel(connection);
        var presenter = new MySqlPresenter(model);

        return presenter;
    }

    public MySqlConnection CreateConnection()
    {
        var connection = new MySqlConnection(_connectionString);

        var connectionStructure = new ConnectionStructure { Connection = connection };

        _connectionStructures.Add(connectionStructure);

        return connection;
    }

    public async Task<string> CreateDatabase(MySqlConnection connection)
    {
        var databaseName = NamesGenerator.Generate();

        var connectionStructure = _connectionStructures
            .Where(x => x.Connection == connection)
            .Single();

        using (var command = connection.CreateCommand())
        {
            await connection.OpenAsync();

            command.CommandText = $"CREATE DATABASE IF NOT EXISTS `{databaseName}`;";
            await command.ExecuteNonQueryAsync();

            await connection.CloseAsync();
        }

        connectionStructure.DatabaseNames.Add(databaseName);

        return databaseName;
    }

    public void Dispose()
    {
        foreach (var connectionStructure in _connectionStructures)
        {
            var connection = connectionStructure.Connection;

            foreach (var databaseName in connectionStructure.DatabaseNames)
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = $"DROP DATABASE IF EXISTS `{databaseName}`;";
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }

    public class ConnectionStructure
    {
        public MySqlConnection Connection { get; set; }
        public List<string> DatabaseNames { get; set; } = new List<string>();
    }
}
