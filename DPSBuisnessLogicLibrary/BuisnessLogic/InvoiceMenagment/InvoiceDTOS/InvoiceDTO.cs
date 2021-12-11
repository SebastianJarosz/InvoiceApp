using System;
using System.Collections.Generic;

namespace DPSBuisnessLogicLibrary.BuisnessLogic.InvoiceMenagment.InvoiceDTOS
{
    /// <summary>
    /// Data transfer object for Invoice class 
    /// </summary>
    public class InvoiceDTO
    {
        public string InvoiceNumber { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime ModyficationTime { get; set; }
        public string BuyerNIP { get; set; }
        public string BuyerName { get; set; }
        public string BuyerStreet { get; set; }
        public string BuyerStreetNumber { get; set; }
        public Nullable<int> BuyerFlatNumber { get; set; }
        public string SellerNIP { get; set; }
        public string SellerName { get; set; }
        public string SellerStreet { get; set; }
        public string SellerStreetNumber { get; set; }
        public Nullable<int> SellerFlatNumber { get; set; }
        public List<ProductsOnInvoiceDTO> ProductsList { get; set; }
    }
}
