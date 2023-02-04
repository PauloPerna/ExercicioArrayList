using System;
using System.Collections;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Cadastro
            var nomes = new ArrayList(){
                "Paulo","Eduardo"
            };
            var senhas = new ArrayList(){
                "senha","password"
            };
            string senha = "";
            string input = "";
            while(input.ToLower() != "n")
            {
                System.Console.WriteLine("Digite o nome do usuário");
                nomes.Add(Console.ReadLine());
                System.Console.WriteLine("Digite a senha do usuário");
                senha = Console.ReadLine();
                while(senha.Length < 4 || senha.Length > 8)
                {
                    System.Console.WriteLine("A senha deve ter entre 4 e 8 caracteres. Digite outra senha");
                    senha = Console.ReadLine();
                }
                senhas.Add(senha);
                System.Console.WriteLine("Deseja inserir outro usuário? <s/n>");
                input = Console.ReadLine();
            }

            // Entrar no sistema
            string usuario;
            int tentativas = 0;
            bool loginAutorizado = false;
            while(tentativas < 3 && !loginAutorizado)
            {
                System.Console.WriteLine("Digite o usuário");
                usuario = Console.ReadLine();
                if(!nomes.Contains(usuario)){
                    System.Console.WriteLine("Usuário não encontrado");
                    tentativas++;
                    continue;
                }
                System.Console.WriteLine("Digite a senha");
                senha = Console.ReadLine();
                loginAutorizado = senhas.IndexOf(senha) == nomes.IndexOf(usuario);
                if(!loginAutorizado)
                {
                    System.Console.WriteLine("Senha incorreta!");
                    tentativas++;
                    continue;
                }
                System.Console.WriteLine("Acesso Liberado!");
            }
        }
    }
}