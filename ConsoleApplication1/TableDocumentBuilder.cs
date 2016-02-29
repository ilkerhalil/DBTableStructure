using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;
using Dapper;
using DBTableStructure.Model;
using DBTableStructure.Properties;

namespace DBTableStructure
{
    public class TableDocumentBuilder : ITableDocumentBuilder, IDisposable
    {
        private SqlConnection _sqlConnection;

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
            var stringBuilder = new StringBuilder();
            using (var stringWriter = new StringWriter(stringBuilder))
            {
                var xmlSerializer = new XmlSerializer(typeof(Table));
                xmlSerializer.Serialize(stringWriter, Tables);
            }
            return stringBuilder.ToString();
        }

        public IEnumerable<Table> Tables
        {
            get
            {
                var tables = _sqlConnection.Query<Table>(Resources.TableListQuery).ToArray();
                foreach (var table in tables)
                {
                    var tableDetail = _sqlConnection.Query<TableDetail>(Resources.GetTableQuery);
                    table.TableDetails.AddRange(tableDetail);
                }
                return tables;
            }
        }

        public string CreateTableDocument(params string[] tableNames)
        {
            var xmlSchema = CreateSchemaXml();
            var xslCompiler = new XslCompiledTransform();
            using (var xmlReader = new XmlTextReader(new StringReader(Resources.template)))
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
            if (v)
            {
                _sqlConnection.Dispose();
                _sqlConnection = null;
            }

        }

        #endregion
    }
}