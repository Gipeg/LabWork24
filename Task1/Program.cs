namespace Task1
{
    internal class Program
    {
        private static string _login;
        private static string _password;

        public static bool IsCorrectUserData(string login, string password, string confirmPassword)
        {
            bool isLoginCorrect = !string.IsNullOrEmpty(login);
            bool isPasswordCorrect = !string.IsNullOrEmpty(password);
            bool isConfirmCorrect = password == confirmPassword;


            return isLoginCorrect && isPasswordCorrect && isConfirmCorrect;
        }

        static void Main(string[] args)
        {
            Program user = new Program();

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
