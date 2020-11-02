namespace Store
{
    public interface IBookRepository
    {
        Book[] GetAllByIsbn(string isbn);
        Book[] GetAllByTitleOrAuthor(string query);
        Book GetById(int id);
    }
}
