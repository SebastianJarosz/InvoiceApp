namespace DPSBuisnessLogicLibrary.BuisnessLogic.InvoiceMenagment.InvoiceMappers
{
    /// <summary>
    /// Interface for objects mapping
    /// </summary>
    /// <typeparam name="T">Object 1</typeparam>
    /// <typeparam name="O">Object 2</typeparam>
    public interface IMapper<T, O> where T : class where O : class
    {
        public O Map(T mapFromObject);
        public T Map(O mapFromObject);
    }
}
