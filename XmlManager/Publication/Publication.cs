namespace XmlManager.Publication;
public class Publication
{
    public class Role
    {
        public string BeginDate { get; set; } = "";
        public string EndDate { get; set; } = "";
    }

    public class Client
    {
        public string Address { get; set; } = "";
        public string Company { get; set; } = "";
        public string Sphere { get; set; } = "";
    }

    public Role AuthorRole { get; set; } = new();
    public Client PublicationClient { get; set; } = new();

    public string FullName { get; set; } = "";

    public string Department { get; set; } = "";

    public string Laboratory { get; set; } = "";

    public string Title { get; set; } = "";

}
