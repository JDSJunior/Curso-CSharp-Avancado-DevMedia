using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    public class AutenticacaoException : Exception 
    {
        //sobreescrevendo o construtor da classe base
        //para receber a menssagem da classe derivada
        public AutenticacaoException(string Message)
             : base (Message)
        {

        }
    }

    public class UsuarioException : AutenticacaoException
    {
        public UsuarioException(string Message)
             : base (Message)
        {

        }
    }

    public class SenhaException : AutenticacaoException
    {
       public SenhaException(string Message)
             : base (Message)
        {

        }
    }
    public static class Autentificao
    {
        //metodo estatico que compara se usuario e senha sao validos
        //e chama a exception customizada correspondente
        public static void Autenticar(string usuario, string senha)
        {
            if (usuario != "admin")
            {
                throw new UsuarioException("Usuario Inválido");
            }
            if(senha != "admin")
            {
                throw new SenhaException("Senha Inválida");
            }
        }
    }
}