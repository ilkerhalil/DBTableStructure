using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Xsl;

namespace DBTableStructure
{
    public class TableDocumentBuilder : IDisposable, ITableDocumentBuilder
    {
        private readonly SqlConnection _sqlConnection;

        public TableDocumentBuilder(string connectionString)
        {
            _sqlConnection = new SqlConnection(connectionString);
        }
        /// <summary>
        /// Xml oluştur.
        /// </summary>
        /// <returns></returns>
        private string CreateSchemaXml()
        {
            var sqlDataAdapter = new SqlDataAdapter(Properties.Resources.GetTableQuery, _sqlConnection);
            var objectDataTable = new DataTable { TableName = "Object" };
            sqlDataAdapter.Fill(objectDataTable);
            var stringBuilder = new StringBuilder();
            var stringWriter = new StringWriter(stringBuilder);
            objectDataTable.WriteXml(stringWriter);
            return stringBuilder.ToString();
        }

        public string CreateTableDocument(params string[] tableNames)
        {
            var xmlSchema = CreateSchemaXml();
            var xslCompiler = new XslCompiledTransform();
            using (var xmlReader = new XmlTextReader(new StringReader(Properties.Resources.template)))
            {
                xslCompiler.Load(xmlReader);
            }
            var xmlDocument = new XmlDocument();
            xmlDocument.Load(new StringReader(xmlSchema));
            var xmlStringBuilder = new StringBuilder();
            using (var xmlWriter = XmlWriter.Create(xmlStringBuilder))
            {
                xslCompiler.Transform(xmlDocument, xmlWriter);
            }
            return xmlStringBuilder.ToString();
        }
        #region IDisposable
        ~TableDocumentBuilder()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool v)
        {
            if (v) _sqlConnection.Dispose();
        }
        #endregion
    }
}