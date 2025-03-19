namespace Module._14.HW;

internal class Program
{
    static void Main(string[] args)
    {
        //  Создаём пустой список с типом данных Contact
        var phoneBook = new List<Contact>();

        // Добавляем контакты
        phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
        phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
        phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
        phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
        phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
        phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

        while (true) // Запускаем бесконечный цикл для телефонной книги
        {
            phoneBook.FindContact(); // Вызываем метод расширения для выборки страниц
        }
    }
}
