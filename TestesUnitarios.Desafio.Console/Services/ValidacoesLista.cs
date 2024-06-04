
namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesLista
    {
        public List<int> RemoverNumerosNegativos(List<int> lista)
        {
            var listaSemNegativos = lista.Where(x => x > 0);
            return listaSemNegativos.ToList();
        }

        public bool ListaContemDeterminadoNumero(List<int> lista, int numero)
        {
            var contem = lista.Contains(numero);
            return contem;
        }

        public List<int> MultiplicarNumerosLista(List<int> lista, int numero)
        {
            var listaMultiplicada = lista.Select(x => x * numero).ToList();
            return listaMultiplicada;
        }

        public int RetornarMaiorNumeroLista(List<int> lista)
        {
            return lista.Max();
        }

        public int RetornarMenorNumeroLista(List<int> lista)
        {
            return lista.Min();
        }

        public IEnumerable<int> MultiplicarElementosListaPor2(List<int> lista)
        {
            var resultado = new List<int>();
            foreach (var item in lista)
            {
                resultado.Add(item * 2);
            }
            return resultado;
        }
    }
}
