using System.Collections.Generic;
using desafio_dio_app_cadastro_dotnet.Interfaces;

namespace desafio_dio_app_cadastro_dotnet.Classes
{
    public class SerieRepositorio :IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();

		public void Atualiza(int id, Serie objeto)
		{
			listaSerie[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaSerie[id].Excluir();
		}

		public void Insere(Serie objeto)
		{
			listaSerie.Add(objeto);
		}

		public List<Serie> Lista()
		{
			return listaSerie;
		}

		public int ProximoId()
		{
			return listaSerie.Count;
		}

		public Serie RetornaPorId(int id)
		{
			return listaSerie[id];
		}
	
    }
}
