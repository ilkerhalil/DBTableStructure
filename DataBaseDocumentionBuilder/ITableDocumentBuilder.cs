using System.Collections.Generic;
using DataBaseDocumentionBuilder.Model;

namespace DBTableStructure
{
    public interface ITableDocumentBuilder
    {
        IEnumerable<Table> Tables { get; }
        string CreateTableDocument(params string[] tableNames);
        void Dispose();
    }
}