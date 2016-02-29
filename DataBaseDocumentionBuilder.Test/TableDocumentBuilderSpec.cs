using System.Linq;
using Xunit;

namespace DataBaseDocumentionBuilder.Test
{
    public class TableDocumentBuilderSpec
    {
        private readonly TableDocumentBuilder _tableDocumentBuilder;

        public TableDocumentBuilderSpec()
        {
            _tableDocumentBuilder = new TableDocumentBuilder("data source=172.23.23.52;integrated security=true;initial catalog=dataportsap;");
        }

        [Fact]
        public void GetTables()
        {
            Assert.True(_tableDocumentBuilder.Tables.Any());
        }

        [Fact]
        public void CreateTableDocument()
        {  
            var html = _tableDocumentBuilder.CreateTableDocument("ACCNT_GRPV", "BASE_UOM");
            Assert.NotEqual(string.Empty, html);
         }
    }
}
