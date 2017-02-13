//em Properties -> AssemblyInfo
//podemos ver informações do assemblie e sua versão

//para versionamento é preciso gerar uma strongKey na aba Assing da propertie do assemblie
//podemos tbm copiar uma versao do assemblie para o gac(global cache assemblie)
//evitando de copiar em cada diretorio dos projetos uma dll

using System;

namespace AssemblieClassLibrary.Calculo
{
    public static class Class1
    {
        public static int Somar(int x, int y)
        {
            return x + y;
        }
    }
}
