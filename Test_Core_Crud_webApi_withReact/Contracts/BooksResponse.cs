namespace Test_Core_Crud_webApi_withReact.Contracts
{
    public record BooksResponse(
        Guid Id,
        string Title,
        string Description,
        decimal Price);
}
