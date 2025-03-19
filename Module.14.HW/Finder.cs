namespace Module._14.HW;

/// <summary>
/// Класс для сортировки и вывода списка, по заданному номеру страницы
/// </summary>
static class Finder
{
    public static void FindContact(this List<Contact> contacts)
    {
        var sortedContacts = contacts.OrderBy(c => c.Name).ThenBy(c => c.LastName) // Сортируем список по возрастанию, сначала по имени, затем по фамилии
            .Skip((TakeNumber() - 1) * 2).Take(2).ToList(); // Выбираем контакты согласно запрашиваемой странице

        foreach (var contact in sortedContacts)
        {
            Console.WriteLine(string.Join(" ", contact.Name, contact.LastName, contact.PhoneNumber, contact.Email)); // Выводим отсортированные и выбранные контакты
        }
        Console.WriteLine();
    }

    private static int TakeNumber()
    {
        Console.WriteLine("Введите номер страницы:");

        var parsed = Int32.TryParse(Console.ReadKey().KeyChar.ToString(), out int pageNumber);  // Читаем введенный с консоли символ, проверяем, число ли это

        Console.Clear();

        // если не соответствует критериям - показываем ошибку
        if (!parsed || pageNumber < 1 || pageNumber > 3)
        {
            Console.WriteLine("Страницы не существует!");
            Console.WriteLine();

            return TakeNumber(); // Вызываем метод повторно, для получение корректных данных
        }
        else
        {
            return pageNumber; // Возвращаем номер страницы
        }
    }
}
