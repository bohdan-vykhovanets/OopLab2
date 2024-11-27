<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
	<xsl:output method="html" indent="yes" />

	<!-- Root Template -->
	<xsl:template match="/">
		<html>
			<head>
				<title>Publications</title>
				<style>
					body {
					font-family: Arial, sans-serif;
					}
					table {
					border-collapse: collapse;
					width: 100%;
					}
					th, td {
					border: 1px solid #ddd;
					padding: 8px;
					text-align: left;
					}
					th {
					background-color: #f2f2f2;
					}
				</style>
			</head>
			<body>
				<h1>Publications</h1>
				<xsl:apply-templates select="Publications/Publication" />
			</body>
		</html>
	</xsl:template>

	<!-- Template for Publication -->
	<xsl:template match="Publication">
		<table>
			<tr>
				<th colspan="2">Publication Details</th>
			</tr>
			<tr>
				<td>Author Role - Begin Date</td>
				<td>
					<xsl:value-of select="AuthorRole/BeginDate" />
				</td>
			</tr>
			<tr>
				<td>Author Role - End Date</td>
				<td>
					<xsl:value-of select="AuthorRole/EndDate" />
				</td>
			</tr>
			<tr>
				<th colspan="2">Publication Client</th>
			</tr>
			<tr>
				<td>Address</td>
				<td>
					<xsl:value-of select="PublicationClient/Address" />
				</td>
			</tr>
			<tr>
				<td>Company</td>
				<td>
					<xsl:value-of select="PublicationClient/Company" />
				</td>
			</tr>
			<tr>
				<td>Sphere</td>
				<td>
					<xsl:value-of select="PublicationClient/Sphere" />
				</td>
			</tr>
			<tr>
				<th colspan="2">General Information</th>
			</tr>
			<tr>
				<td>Full Name</td>
				<td>
					<xsl:value-of select="FullName" />
				</td>
			</tr>
			<tr>
				<td>Department</td>
				<td>
					<xsl:value-of select="Department" />
				</td>
			</tr>
			<tr>
				<td>Laboratory</td>
				<td>
					<xsl:value-of select="Laboratory" />
				</td>
			</tr>
			<tr>
				<td>Title</td>
				<td>
					<xsl:value-of select="Title" />
				</td>
			</tr>
		</table>
		<br />
	</xsl:template>
</xsl:stylesheet>