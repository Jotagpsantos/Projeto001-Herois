using System.Collections.Generic;

namespace DIO_Herois
{
    public interface IHeroi
    {
        public string CadastrarHeroi(Heroi heroi);
        public string AtualizarHeroi(Heroi atualizarHeroi, int id);
        public string ExcluirHeroi(int id);
        public List<Heroi> ListarHeroi();
    }
}