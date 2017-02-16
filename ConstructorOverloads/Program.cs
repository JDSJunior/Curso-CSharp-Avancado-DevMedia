using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloads
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cli = new Cliente();

            //usar caso não fosse iniciado no construtor da classe
            //Contato cont = new Contato();
            //cont.Tipo = "celular";
            //cont.Descricao = "nokia";

            cli.Nome = "joao";
            cli.Id = 123;

            //como o construtor da classe ja inicializa o objeto da classe
            //Contato ele pode ser acessado pela classe cli
            //podendo atribuir valores diretamente
            cli.Contato.Tipo = "celular";
            cli.Contato.Descricao = "email";

            //iniciando com o construtor parametrizado
            Cliente cli2 = new Cliente(456);
            cli2.Nome = "Dariana";

            Console.WriteLine(cli);
            Console.WriteLine(cli2);

            //instancia a classe derivada e chama o construtor
            //sobreescrito da classe base e passando o parametro para
            //o cod
            ClienteVip cli3 = new ClienteVip(35);
            Console.WriteLine(cli3.Tempo);
            Console.WriteLine(cli3.Id);
            Console.WriteLine(cli3.Nome);
            Console.WriteLine(cli3.Contato);
            
            Console.ReadKey();
        }
    }
}
