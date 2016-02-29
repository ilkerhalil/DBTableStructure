using DataBaseDocumentionBuilder.Web.Api.Controllers;

namespace DataBaseDocumentionBuilder.Web.Models
{
    public class DatabaseTable
    {
        public string TableName { get; set; }

        public DatabaseTableDetail DatabaseTableDetails { get; set; }

    }
}