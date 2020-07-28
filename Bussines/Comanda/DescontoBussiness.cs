using System.Linq;
using APIBarDG.Util.Enum;
using APIBarDG.Service.ComandaService;

namespace APIBarDG.Bussines.Comanda
{
    public class DescontoBussines : IDesconto
    {

        public Model.Comanda.Comanda DescontoAplicado(Model.Comanda.Comanda comanda)
        {
            if (comanda.Itens.Count() == 0)
            {
                return null;
            }

            comanda = CalculaDescontoCerveja(comanda);
            
            return comanda;
        }

    

        #region [Desconto Cerveja]

        private Model.Comanda.Comanda CalculaDescontoCerveja(Model.Comanda.Comanda comanda)
        {
            int countCerveja = 0;
            int countSuco = 0;

            foreach (var item in comanda.Itens)
            {
                if (item.Nome.ToUpper() == EnumItens.Cerveja.ToString().ToUpper())
                {
                    countCerveja++;
                }
                if (item.Nome.ToUpper() == EnumItens.Suco.ToString().ToUpper())
                {
                    countSuco++;
                }
            }

            if (countCerveja == 0 || countSuco == 0)
                return comanda;

            if (countCerveja == countSuco)
            {
                comanda = AplicaDescontoCerveja(comanda, countCerveja);
            }
            else if (countCerveja > countSuco)
            {
                comanda = AplicaDescontoCerveja(comanda, countSuco);
            }
            else
            {
                comanda = AplicaDescontoCerveja(comanda, countCerveja);
            }

            return comanda;
        }

        private Model.Comanda.Comanda AplicaDescontoCerveja(Model.Comanda.Comanda comanda, int countDesconto)
        {
            foreach (var item in comanda.Itens)
            {
                if (countDesconto > 0)
                {
                    if (item.Nome.ToUpper() == EnumItens.Cerveja.ToString().ToUpper())
                    {
                        item.Preco = 3.00;
                    }
                    countDesconto = countDesconto - 1;
                }
            }
            return comanda;
        }

        public int VerificaQuantidadeDesconto(Model.Comanda.Comanda comanda)
        {
            int desconto = 0;

            foreach (var item in comanda.Itens)
            {
                if (item.Nome.ToUpper() == EnumItens.Cerveja.ToString().ToUpper())
                {
                    if (item.Preco == 3.00)
                        desconto++;
                }           
            }

            return desconto;
        }
        #endregion

    }
}
