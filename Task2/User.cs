namespace Task2
{
    internal class User
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
    }
}
