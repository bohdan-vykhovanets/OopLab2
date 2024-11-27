using System.Xml;
using XmlManager.Publication;

namespace XmlManager.Parser;

public abstract class FilterableParser : IParser
{
    protected IList<Publication.Publication> Publications = new List<Publication.Publication>();

    public IList<Publication.Publication> Find(Filters filters)
    {
        return Publications.Where(filters.ValidatePublication).ToList();
    }

    public abstract bool Load(Stream inputstream, XmlReaderSettings settings);
}