using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DataBaseDocumentionBuilder.Model
{
    [Serializable]
    public class Table
    {
        public Table()
        {
            TableDetails = new List<TableDetail>();
        }
        public string TableName { get; set; }
        
        [XmlArray]
        public List<TableDetail> TableDetails { get; private set; }

        public override string ToString()
        {
            return $"TableName: {TableName}";
        }
    }
}
