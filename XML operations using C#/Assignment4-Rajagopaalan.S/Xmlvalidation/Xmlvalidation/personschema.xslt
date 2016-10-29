<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:template match="/">
    <html>
      <body>
        <h1>Persons list</h1>
        <table border="1">
          <tr bgcolor="yellow">
            <th colspan="2">
              <b>Name </b>
            </th>
            <th colspan="2">
              <b>Credential</b>
            </th>
            <th colspan="2">
              <b>Phone</b>
            </th>
            <th rowspan="2">
              <b>Category</b>
            </th>
          </tr>
          <tr bgcolor="yellow">
            <th >
              <b>First Name </b>
            </th>
            <th >
              <b>Second Name </b>
            </th>
            <th >
              <b>Id</b>
            </th>
            <th >
              <b>Password</b>
            </th>
            <th >
              <b>Cell</b>
            </th>
            <th >
              <b>Work</b>
            </th>

          </tr>
          <xsl:for-each select="Persons/Person">
            <xsl:sort select="Name" />
            <tr style="font-size: 10pt; font-family: verdana">
              <td>
                <xsl:value-of select="Name/First"/>
              </td>
              <td>
                <xsl:value-of select="Name/Last"/>
              </td>
              <td>
                <xsl:value-of select="Credential/Id"/>
              </td>
              <td>
                <xsl:value-of select="Credential/Password"/>
              </td>
              <td>
                <xsl:value-of select="Phone/Cell"/>
              </td>

              <td>
                <xsl:value-of select="Phone/Work"/>
              </td>
              <td>
                <xsl:value-of select="Category"/>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>


