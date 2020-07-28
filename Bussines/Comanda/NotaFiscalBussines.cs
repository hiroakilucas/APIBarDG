using APIBarDG.Model.NotaFiscal;
using APIBarDG.Service.ComandaService;


namespace APIBarDG.Bussines.Comanda
{
    public class NotaFiscalBussines : INotaFiscal
    {
        public NotaFiscal GerarNotaFiscal(Model.Comanda.Comanda comanda)
        {
            NotaFiscal notaFiscal = new NotaFiscal();
            DescontoBussines descontoBussines = new DescontoBussines();
            int descontoCerveja = 0;

            descontoCerveja = descontoBussines.VerificaQuantidadeDesconto(comanda);

            notaFiscal = MontaNotaFiscal(comanda, descontoCerveja);

            return notaFiscal;
        }

        private NotaFiscal MontaNotaFiscal(Model.Comanda.Comanda comanda, int descontoCerveja)
        {
            NotaFiscal notaFiscal = new NotaFiscal();
            double valorTotal = 0;

            foreach (var item in comanda.Itens)
            {               
                notaFiscal.Item.Add(item);
                valorTotal = item.Preco;
            }

            notaFiscal.ValorTotal = valorTotal;

            if (descontoCerveja != 0)
                notaFiscal.Desconto = descontoCerveja * 2;
            else
                notaFiscal.Desconto = 0;

            return notaFiscal;            
        }
    }
    

}
