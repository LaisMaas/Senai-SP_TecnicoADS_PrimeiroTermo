using System.Collections.Generic;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories

HamburguerRepository HamburguerRepository = new HamburguerRepository
{
    public class HamburguerRepository
    {
        private const string PATH = "Database/Hamburguer";

        if(!File.Exists(PATH))
        {
            File.Create(PATH).Close();
        }
        
    }

    public List<Hamburguer> ObterTodos()


    {

       string[] linhas = File.ReadAllLines(PATH);
       foreach(var linha in linhas)
       {
           Hamburguer h = new Hamburguer();
           string [] dados = linha.Split(";");
           h.Home = dados[0];
           h.Preco = double.Parse(dados[1]);

           hamburgures.Add(h);




       }
    }
}