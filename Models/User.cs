namespace LinkExchange.Models
{
    public class User
    {
        public Guid Id { get; set; } //id пользователя.
        public string Username { get; set; } //Имя пользователя для регистрации/аутентификации.
        public string PasswordHash { get; set; } //Хеш пароля для безопасности.
        public DateTime CreatedDate { get; set; } //Дата создания аккаунта пользователем.
        public ICollection<Link> Links { get; set; } //Коллекция ссылок, связанных с пользователем.
    }
}
