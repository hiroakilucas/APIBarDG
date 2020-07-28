using APIBarDG.Data.Comanda;
using APIBarDG.Model;
using APIBarDG.Model.NotaFiscal;
using APIBarDG.Service.ComandaService;
using APIBarDG.Util.Enum;
using System;

namespace APIBarDG.Bussines.Comanda
{
    public class ComandaBussines : IControlaComanda
    {

        public Model.Comanda.Comanda RegistraItemComanda(int idComanda, string nomeItem)
        {
            Model.Comanda.Comanda comanda = new Model.Comanda.Comanda();
            
            //sql verifica itens da comanda e ver se existe 3 sucos
            //comanda = comandaDAO.getComanda(idComanda);

            if (!VerificaTresSucos(comanda))
            {
                //3 sucos existentes jogar exception
                return null;
            }

            //sql registra item
            //comanda = comandaDAO.registraItem(idcomanda, nomeItem);

            comanda = PromocaoAgua(comanda);

            return comanda;
        }

        private Model.Comanda.Comanda PromocaoAgua(Model.Comanda.Comanda comanda)
        {
            double promocaoAgua = 0;
            //verifica quantas promocoes de Agua existe 
            promocaoAgua = VerificaPromocaoAgua(comanda);

            //verifica quantas promocoes ja foi pedido 
            promocaoAgua = promocaoAgua - comanda.PromocaoAguaPedidos;

            comanda.PromocaoAguaRestantes = promocaoAgua;

            return comanda;
        }

        private double VerificaPromocaoAgua(Model.Comanda.Comanda comanda)
        {
            int qtdConhaque = 0;
            int qtdCerveja = 0;
            double possivelQtdPromocaoConhaque = 0;
            double possivelQtdPromocaoCerveja = 0;

            foreach (var item in comanda.Itens)
            {
                if (item.Nome.ToUpper() == EnumItens.Conhaque.ToString().ToUpper())
                {
                    qtdConhaque++;
                }
                else if (item.Nome.ToUpper() == EnumItens.Conhaque.ToString().ToUpper())
                {
                    qtdCerveja++;
                }
            }

            if (!(qtdConhaque > 3 && qtdCerveja > 2 ))
            {
                return 0;
            }

            possivelQtdPromocaoConhaque = qtdConhaque / 3;
            possivelQtdPromocaoCerveja = qtdCerveja/ 2;

            if (possivelQtdPromocaoConhaque > possivelQtdPromocaoCerveja)
            {
                return possivelQtdPromocaoCerveja;
            }
            else
            {
                return possivelQtdPromocaoConhaque;
            }
        }

        private bool VerificaTresSucos(Model.Comanda.Comanda comanda)
        {
            int qtdSucos = 0;

            foreach (var item in comanda.Itens)
            {
                if (item.Nome.ToUpper() == EnumItens.Suco.ToString().ToUpper())
                {
                    qtdSucos++;
                }
            }

            if (qtdSucos > 3)
            {
                return false;
            }

            return true;
        }

        public NotaFiscal FechamentoComanda(int idComanda)
        {
            NotaFiscal notaFiscal = new NotaFiscal();
            ComandaDAO comandaDAO = new ComandaDAO();

            Model.Comanda.Comanda comanda = new Model.Comanda.Comanda();

            //setar peços pegando da base e setar na comanda           
            //1.Cerveja: R$ 5,00
            //2.Conhaque: R$ 20,00
            //3.Suco: R$ 50,00
            //4.Água: R$ 70,00
            //sql verifica item da comanda na base e busca os itens
            //comanda = comandaDAO.getComanda(idComanda);

            DescontoBussines descontoBussines = new DescontoBussines();
            NotaFiscalBussines notaFiscalBusiness = new NotaFiscalBussines();

            comanda = descontoBussines.DescontoAplicado(comanda);
            notaFiscal = notaFiscalBusiness.GerarNotaFiscal(comanda);

            return notaFiscal;
        }

        public Model.Comanda.Comanda LimpaComanda(int idComanda)
        {
            Model.Comanda.Comanda comanda = new Model.Comanda.Comanda();

            //sql verifica se a comanda existe;
            //
            //sql delete itens da comanda;
            //comanda = comandaDAO.limpaComanda(idComanda);

            return comanda;
        }
    }
}
