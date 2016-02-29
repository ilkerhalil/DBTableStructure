using System;

namespace DataBaseDocumentionBuilder.Model
{
    [Serializable]
    public class TableDetail
    {

        public string ColumnName { get; set; }

        public string ColumnType { get; set; }

        public int ColumnLength { get; set; }

        public bool IsIdentity { get; set; }

        public bool IsNullable { get; set; }

        public bool IsComputed { get; set; }

        public string Description { get; set; }

        public int? PrimaryKeyRefId { get; set; }

        public int? ForeignKeyRefId { get; set; }

        public int? ForeignKeyTableId { get; set; }

        public string ForeignKeyColumn { get; set; }

        public int? DefaultRefId { get; set; }

        public string DefaultValue { get; set; }

        public override string ToString()
        {
            return $"ColumnName: {ColumnName}, ColumnType: {ColumnType}, ColumnLength: {ColumnLength}, IsIdentity: {IsIdentity}, IsNullable: {IsNullable}, IsComputed: {IsComputed}, Description: {Description}, PrimaryKeyRefId: {PrimaryKeyRefId}, ForeignKeyRefId: {ForeignKeyRefId}, ForeignKeyTableId: {ForeignKeyTableId}, ForeignKeyColumn: {ForeignKeyColumn}, DefaultRefId: {DefaultRefId}, DefaultValue: {DefaultValue}";
        }
    }
}