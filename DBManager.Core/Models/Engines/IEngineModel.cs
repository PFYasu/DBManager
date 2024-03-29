﻿using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace DBManager.Core.Models.Engines
{
    public interface IEngineModel
    {
        string Name { get; }
        string EngineType { get; }
        Dictionary<string, string> ConnectionParameters { get; }
        Task<DataTable> ExecuteQuery(string query, string databaseName = null);
        Task<int> ExecuteNonQuery(string query, string databaseName = null);
    }
}
