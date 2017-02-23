//assemblie2 contendo namespace igual ao assemblie1
//ocorre a divisao mas nao lógica entre namespace de nomes iguais 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junior.form.button
{
    public static class Data
    {
        public static string GeraData()
        {
            return DateTime.Now.ToLongDateString() + " - " + DateTime.Now.ToLongTimeString();
        }
    }
}
