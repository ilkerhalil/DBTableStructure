using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Xsl;

namespace DBTableStructure
{



    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection c = new SqlConnection();
            c.ConnectionString = "Server=172.23.23.52;Database=DataPortSAP;Integrated Security=True;";
            c.Open();

            SqlDataAdapter da = new SqlDataAdapter(SqlQueryDefinitions.GetColumns, c);
            DataTable dt = new DataTable();
            dt.TableName = "Object";
            da.Fill(dt);
   
            dt.WriteXml("result.xml");
            XslCompiledTransform xsl = new XslCompiledTransform();
            xsl.Load("template.xslt");
            xsl.Transform("result.xml", "output.html");
            Process.Start("output.html");
        }
    }
}
