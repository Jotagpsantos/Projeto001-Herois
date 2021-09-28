using System.Collections.Generic;

namespace DIO_Herois
{
    public class HeroiController : IHeroi
    {
        public List<Heroi> listaHeroi = new List<Heroi>();

        public string AtualizarHeroi(Heroi atualizarHeroi, int id)
        {
            throw new System.NotImplementedException();
        }

        public string CadastrarHeroi(Heroi heroi)
        {
            listaHeroi.Add(heroi);

            return "Heroi cadastrado com sucesso.";
        }

        public string ExcluirHeroi(int id)
        {
            listaHeroi.RemoveAt(id);

            return "Heroi removido com sucesso"; 
        }

        public List<Heroi> ListarHeroi()
        {
            return listaHeroi;
        }
    }
}
   