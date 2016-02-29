<?xml version="1.0" encoding="utf-8" ?>
<xsl:stylesheet version="2.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
                xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
    <xsl:template match="DocumentElement">
        <html xmlns:mshelp="http://msdn.microsoft.com/mshelp">
        <head>     
            <title>Database</title>
              <link rel="stylesheet" href="Content/bootstrap.min.css"></link>
  <script src="Scripts/jquery-1.9.1.min.js"></script>
  <script src="Scripts/bootstrap.min.js"></script>
            <meta name="viewport" content="width=device-width, initial-scale=1" />
        </head>
        <body>

          <div class="container">
            <xsl:for-each select="Object">
              <xsl:if test="not(preceding-sibling::table_name/text() = table_name/text())">
                <xsl:variable name="table" select="table_name/text()" />

                <div class="panel panel-default table-responsive">
                  <!-- Default panel contents -->
                  <div class="panel-heading text-center">
                    <xsl:value-of select="table_name/text()" />
                  </div>
                </div>

                <div>
                  <table class="table table-responsive table-bordered table-hover table-striped">
                     <thead>
                       <tr>
                         <td>Field Name</td>
                         <td>Type</td>
                         <td>Length</td>
                         <td>Açıklama</td>
                         <td>Nullable</td>
                         <td>Identity</td>
                     </tr>
                      </thead>
                    <tbody>
                     
                      <xsl:for-each select="//Object[table_name/text() = $table]">
                        <tr>
                          <td>
                            <xsl:value-of select="name/text()" />
                          </td>
                          <td>
                            <xsl:value-of select="type/text()" />
                          </td>
                          <td>
                            <xsl:value-of select="length/text()" />
                          </td>
                          <td>
                            <xsl:value-of select="description/text()" />
                          </td>
                          <td>
                            <xsl:value-of select="nullable/text()" />
                          </td>
                          <td>
                            <xsl:value-of select="identity/text()" />
                          </td>
                        </tr>
                      </xsl:for-each>
                    </tbody>
                  </table>
                </div>

              </xsl:if>
            </xsl:for-each></div>
        </body>
    </html>
</xsl:template>
</xsl:stylesheet>
