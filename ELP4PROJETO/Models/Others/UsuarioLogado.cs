namespace ELP4PROJETO.Models
{
    public static class UsuarioLogado
    {
        public static Funcionarios Funcionario { get; private set; }

        public static void Login(Funcionarios funcionario)
        {
            Funcionario = funcionario;
        }

        public static void Logout()
        {
            Funcionario = null;
        }

        public static bool IsLoggedIn()
        {
            return Funcionario != null;
        }
    }
}
