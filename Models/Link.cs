using LinkExchange.Models;
using System;

namespace LinkExchange.Models
{
    public class Link
    {
        public Guid Id { get; set; } //Уникальный идентификатор ссылки.
        public string Url { get; set; } //URL - адрес ссылки.
        public string Description { get; set; } //Описание ссылки.
        public decimal Price { get; set; } //Цена ссылки.
        public DateTime CreatedDate { get; set; } //Дата создания ссылки.
        public Guid UserId { get; set; } //Идентификатор пользователя, который создал ссылку (внешний ключ).
        public User User { get; set; } //Навигационное свойство для связи с пользователем.
    }
}


