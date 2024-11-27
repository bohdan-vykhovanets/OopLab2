using System.Xml;
using XmlManager.Publication;

namespace XmlManager.Parser;

public interface IParser
{
    public bool Load(Stream inputStream, XmlReaderSettings settings);

    public IList<Publication.Publication> Find(Filters filters);
}
