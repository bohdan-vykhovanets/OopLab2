using System.Xml;

namespace XmlManager.Parser;

public class SaxParser : FilterableParser
{
    public SaxParser()
    {
        Publications = new List<Publication.Publication>();
    }

    public override bool Load(Stream inputStream, XmlReaderSettings settings)
    {
        Publications.Clear();
        try
        {
            var reader = XmlReader.Create(inputStream, settings);
            while (reader.Read())
            {
                if (reader is not { NodeType: XmlNodeType.Element, Name: "Publication" })
                {
                    continue;
                }

                var publication = new Publication.Publication();
                SkipToText(reader);
                publication.AuthorRole.BeginDate = reader.Value;
                SkipToText(reader);
                publication.AuthorRole.EndDate = reader.Value;
                SkipToText(reader);
                publication.PublicationClient.Address = reader.Value;
                SkipToText(reader);
                publication.PublicationClient.Company = reader.Value;
                SkipToText(reader);
                publication.PublicationClient.Sphere = reader.Value;
                SkipToText(reader);
                publication.FullName = reader.Value;
                SkipToText(reader);
                publication.Department = reader.Value;
                SkipToText(reader);
                publication.Laboratory = reader.Value;
                SkipToText(reader);
                publication.Title = reader.Value;

                Publications.Add(publication);
            }
        }
        catch
        {
            return false;
        }

        return true;
    }

    private static void SkipToText(XmlReader reader)
    {
        do
        {
            if (!reader.Read())
            {
                throw new Exception();
            }
        } while (reader.NodeType != XmlNodeType.Text);
    }
}
