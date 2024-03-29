﻿using System.Collections.Generic;

namespace DBManager.Core.Dto.Engines
{
    public class DatabaseTableColumnsResponseDto
    {
        public Dictionary<string, List<string>> DatabaseTableColumns { get; set; }

        public DatabaseTableColumnsResponseDto()
        {
            DatabaseTableColumns = new Dictionary<string, List<string>>();
        }
    }
}
