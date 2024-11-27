using System.Xml;
using System.Xml.Linq;

namespace XmlManager.Parser;

public class LinqParser : FilterableParser
{
    public override bool Load(Stream inputStream, XmlReaderSettings settings)
    {
        try
        {
            using var reader = XmlReader.Create(inputStream, settings);

            Publications = XDocument.Load(reader)
                .Descendants("Publication")
                .Select(publication => new Publication.Publication
                {
                    AuthorRole = new Publication.Publication.Role
                    {
                        BeginDate = publication.Element("AuthorRole")?.Element("BeginDate")?.Value ?? "",
                        EndDate = publication.Element("AuthorRole")?.Element("EndDate")?.Value ?? ""
                    },
                    PublicationClient = new Publication.Publication.Client
                    {
                        Address = publication.Element("PublicationClient")?.Element("Address")?.Value ?? "",
                        Company = publication.Element("PublicationClient")?.Element("Company")?.Value ?? "",
                        Sphere = publication.Element("PublicationClient")?.Element("Sphere")?.Value ?? "",
                    },
                    FullName = publication.Element("FullName")?.Value ?? "",
                    Department = publication.Element("Department")?.Value ?? "",
                    Laboratory = publication.Element("Laboratory")?.Value ?? "",
                    Title = publication.Element("Title")?.Value ?? ""
                }).ToList();
        }
        catch
        {
            return false;
        }

        return true;
    }
}
