namespace Task2
{
    internal class Program:User
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите логин: ");
            string login = Console.ReadLine();

            Console.WriteLine("Введите пароль: ");
            string password = Console.ReadLine();

            Console.WriteLine("Подтвердите пароль: ");
            string confirmPassword = Console.ReadLine();

            if (IsCorrectUserData(login, password, confirmPassword))
            {
                Console.WriteLine("Регистрация прошла успешно! Пользователь зарегистрирован.");
                _login = login;
                _password = password;
            }
            else
            {
                Console.WriteLine("Не удалось зарегистрировать! Проверьт введённые данные.");
            }
        }
    }
}
