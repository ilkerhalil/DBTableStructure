using System.Collections.Generic;
using DataBaseDocumentionBuilder.Web.Models;

namespace DataBaseDocumentionBuilder.Web.Services
{
    public interface IDataBaseInfoService
    {
        void AddDatabase(string connectionString);

        IEnumerable<DatabaseTable> GetDatabaseTables(string databaseName);

        void AddDocument(string databaseName, string tableName, string columnName, string description);


    }

    //Bunun içini sen doldur
}