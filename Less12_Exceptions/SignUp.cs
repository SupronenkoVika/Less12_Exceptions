namespace Less12_Exceptions
{
    public class SignUp
    {
        public static bool Sign(string Login, string Password, string ConfirmPassword)
        {
            bool log = false;
            bool passw = false;
            bool confpass = false;
            try
            {
                log = CheckLogin(Login);
                passw = CheckPassword(Password);
                confpass = CheckPasswordConfirmation(Password, ConfirmPassword);
            }
            catch (WrongLoginException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }

            catch (WrongPasswordException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }

            if (log == true && passw == true && confpass == true)
            {
                return true;
            }
            return false;

        }
        private static bool CheckLogin(string login)
        {
            if (login.Length > 20 || login.Contains(' '))
            {
                throw new WrongLoginException("Login is too long or contains spaces");
            }
            else
            {
                return true;
            }
        }

        private static bool CheckPassword(string password)
        {
            if (password.Length > 20 || password.Contains(' '))
            {
                throw new WrongPasswordException("Password is too long or contains spaces");
            }
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    return true;
                }
                else throw new WrongPasswordException("Password must contain numbers");
            }
            return true;
        }

        private static bool CheckPasswordConfirmation(string passw, string confirmPassword)
        {
            if (passw.Length != confirmPassword.Length)
            {
                throw new WrongPasswordException("Password does not match. Different length");
            }

            for (int i = 0; i < passw.Length; i++)
            {
                if (passw[i] != confirmPassword[i])
                {
                    throw new WrongPasswordException("Password does not match");
                }
            }

            return true;
        }
    }
}
