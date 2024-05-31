using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;


namespace IFacturaServiceNamespace
{
    [ServiceContract]
    public interface IFacturaService
    {
        [OperationContract]
        Task<IEnumerable<Factura>> GetAllFacturasAsync();

        [OperationContract]
        Task<Factura> GetFacturaByIdAsync(int id);

        [OperationContract]
        Task<Factura> CreateFacturaAsync(Factura factura);

        [OperationContract]
        Task<Factura> UpdateFacturaAsync(Factura factura);

        [OperationContract]
        Task<bool> DeleteFacturaAsync(int id);
    }
}
