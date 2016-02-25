namespace DBTableStructure
{
    public interface ITableDocumentBuilder
    {
        string CreateTableDocument(params string[] tableNames);
        void Dispose();
    }
}