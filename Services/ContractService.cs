using System;
using ProjectPayment.Entities;
namespace ProjectPayment.Services
{
    class ContractService
    {
        private OnlinePaymenttService _onlinePaymenttService;

        public ContractService(OnlinePaymenttService onlinePaymenttService)
        {
            _onlinePaymenttService = onlinePaymenttService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double pagamentobasic = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime data = contract.StartContrato.AddMonths(i);

                double UpdateCota = pagamentobasic + _onlinePaymenttService.Interest(pagamentobasic, i);

                double FullCota = UpdateCota + _onlinePaymenttService.Juros(UpdateCota);
                contract.AddParcelas(new Parcelas(data, FullCota));
            }
        }

    }
}
