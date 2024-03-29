﻿using DBManager.Core.Dto.Engines;
using DBManager.Core.Presenters;
using DBManager.EngineModule.PostgreSQL;
using DBManager.Tests.Integrations.Helpers;
using Xunit;

namespace DBManager.Tests.Integrations.PostgreSQLPresenterTests;

public class GetConnectionDetailsTests : IDisposable
{
    private readonly PostgreSQLHelper _postgreSQLHelper = new();

    [IntegrationTestFact]
    public async Task ForSpecificConnection_GetConnectionDetails()
    {
        var presenter = _postgreSQLHelper.CreatePresenter();
        var connection = _postgreSQLHelper.CreateConnection();

        var databaseName = await _postgreSQLHelper.CreateDatabase(connection);

        const string tableName = "employees";
        const string engineType = "PostgreSQL";

        using (var command = connection.CreateCommand())
        {
            await connection.OpenAsync();

            await connection.ChangeDatabaseAsync(databaseName);

            command.CommandText =
                $"CREATE TABLE {tableName} (" +
                    $"id INT," +
                    $"name VARCHAR(20));";
            await command.ExecuteNonQueryAsync();

            await connection.CloseAsync();
        }

        var result = await Act(presenter);

        Assert.Equal(ResponseType.Ok, result.Type);

        var payload = result.Payload;
        Assert.NotNull(payload);

        Assert.Equal(presenter.ConnectionName, payload.Name);
        Assert.Equal(engineType, payload.EngineType);
        Assert.Equal(_postgreSQLHelper.ConnectionParameters["Uid"], payload.Uid);
        Assert.Equal(_postgreSQLHelper.ConnectionParameters["Server"], payload.Server);
        Assert.Equal(_postgreSQLHelper.ConnectionParameters["Port"], payload.Port.ToString());
    }

    public static Task<Response<ConnectionDetailsResponseDto>> Act(PostgreSQLPresenter presenter) 
        => presenter.GetConnectionDetails();

    public void Dispose() => _postgreSQLHelper.Dispose();
}
