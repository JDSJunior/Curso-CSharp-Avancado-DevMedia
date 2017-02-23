//assemblie 1 contendo namespace igual ao assemblie2
//ocorre a divisao mas nao lógica entre namespace de nomes iguais
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junior.form.button
{
    public static class GUID
    {
        public static string GeraGuid()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
