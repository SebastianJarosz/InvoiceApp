namespace DPSBuisnessLogicLibrary.BuisnessLogic.InvoiceMenagment.InvoiceDTOS
{
    /// <summary>
    /// Data transfer object for Product class that will be display on Invoice 
    /// </summary>
    public class ProductsOnInvoiceDTO
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public float QuantityOfProduct { get; set; }
        public string ProductMeasureUnit { get; set; }
    }
}
