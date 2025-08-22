using EmprestimoLivros.Models;
using System.Data;

namespace EmprestimoLivros.Services.EmprestimosService
{
    public interface IEmprestimosInterface 
    {
        Task<ResponseModel<List<EmprestimoModel>>> BuscarEmprestimos();

        Task<ResponseModel<EmprestimoModel>> BuscarEmprestimosPorId(int? id);
        Task<ResponseModel<EmprestimoModel>> CadastrarEmprestimo(EmprestimoModel emprestimosModel);

        Task<ResponseModel<EmprestimoModel>> EditarEmprestimo(EmprestimoModel emprestimosModel);

        Task<ResponseModel<EmprestimoModel>> RemoveEmprestimo(EmprestimoModel emprestimosModel);


        Task<DataTable> BuscarDadosEmprestimoExcel();



    }
}
