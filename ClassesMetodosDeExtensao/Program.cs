using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassesMetodosDeExtensao
{
    //herdando uma classe inteira para adicionar um metodo na classe derivada
    //ira herdar todos os outros metodos

    public class JsonDataSet : DataSet
    {
        public void WriteJson(string filename)
        {
              //....
        }
    }


    //Cria uma classe que com um construtur que recebe a classe
    //e contem o metodo a ser adicionado
    public class JsonDataSet2
    {
        DataSet _ds;

        public JsonDataSet2(DataSet ds)
        {
            this._ds = ds;
        }

        public void WriteJson(string filename)
        {
            //......
        }
    }

    //inserindo o metodo diretamente na classe do .net
    //sem necessida de herença e criação de nova classe
    public static class Extensions
    {
        //metodo static injetado diretamente na classe
        //palavra reservada this informa a classe onde o metodo será injetado
        // e mais parametros para usados pelo metodo
        public static void WriteJson(this DataSet ds, string filename)
        {
            //...
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var ds = new JsonDataSet();
            ds.WriteJson("filename"); //metodo inserido via herança

            var ds2 = new JsonDataSet2(ds);
            ds2.WriteJson("filename");//classe com metodo inserido

            var ds3 = new DataSet();
            ds3.WriteJson("filename");//metodo injetado diretamente na classe

        }
    }
}
