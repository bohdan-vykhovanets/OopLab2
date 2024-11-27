namespace XmlManager.Publication;
public struct Filters
{
    public Filters() { }

    public string Role { get; set; } = "";

    public string Client { get; set; } = "";

    public string FullName { get; set; } = "";

    public string Department { get; set; } = "";

    public string Laboratory { get; set; } = "";

    public string Title { get; set; } = "";

    public readonly bool ValidatePublication(Publication publication)
    {
        var authorRole = $"{publication.AuthorRole.BeginDate} {publication.AuthorRole.EndDate}";
        var publicationClient = $"{publication.PublicationClient.Address} {publication.PublicationClient.Company} {publication.PublicationClient.Sphere}";

        var role = authorRole.Contains(Role, StringComparison.OrdinalIgnoreCase);
        var client = publicationClient.Contains(Client, StringComparison.OrdinalIgnoreCase);
        var fullName = publication.FullName.Contains(FullName, StringComparison.OrdinalIgnoreCase);
        var department = publication.Department.Contains(Department, StringComparison.OrdinalIgnoreCase);
        var laboratory = publication.Laboratory.Contains(Laboratory, StringComparison.OrdinalIgnoreCase);
        var title = publication.Title.Contains(Title, StringComparison.OrdinalIgnoreCase);

        return role && client && fullName && department && laboratory && title;
    }
}
