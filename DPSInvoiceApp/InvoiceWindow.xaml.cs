using DPSBuisnessLogicLibrary.BuisnessLogic.InvoiceMenagment;
using DPSBuisnessLogicLibrary.BuisnessLogic.InvoiceMenagment.InvoiceDTOS;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace DPSInvoiceApp
{
    /// <summary>
    /// Logika interakcji dla klasy InvoiceWindow.xaml
    /// </summary>
    public partial class InvoiceWindow : Window
    {
        InvoiceMenager _invoiceMenager;
        List<ProductsOnInvoiceDTO> _productList;
        public InvoiceWindow(InvoiceMenager invoiceMenager)
        {
            _invoiceMenager = invoiceMenager;
            _productList = new List<ProductsOnInvoiceDTO>();
            InitializeComponent();
            InvoicesDG.ItemsSource = _invoiceMenager.GetAllInvoices();
            InvoiceCreationDateForm.SelectedDate = DateTime.Today;
        }

        private void Add_Invoice(object sender, RoutedEventArgs e)
        {
            var result = _invoiceMenager.AddInvoice(CreateInvoiceDTO());
            if (result.Item1)
            {
                MessageBox.Show(result.Item2);
                InvoicesDG.ItemsSource = _invoiceMenager.GetAllInvoices();
                _productList.Clear();
                ProductsDG.ItemsSource = _productList;
                ClearTextBox(ContainerCanvas);
            }
            else
            {
                MessageBox.Show(result.Item2);
            }    
        }

        private void Add_Product_To_Invoice(object sender, RoutedEventArgs e)
        {
            var result = _invoiceMenager.CreateProductOnInvoice(ProductCodeForm.Text, QuantityOfProductForm.Text);
            if (result.Item1)
            {
                ProductsDG.ItemsSource = null;
                _productList.Add(result.Item3);
                ProductsDG.ItemsSource = _productList;
            }
            else
            {
                MessageBox.Show(result.Item2);
            }
        }

        private void ClearTextBox(Grid gridName)
        {
            try
            {
                foreach (Control txtBox in gridName.Children)
                {
                    if (txtBox.GetType() == typeof(TextBox))
                        ((TextBox)txtBox).Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                string test = ex.Message;
            }
        }
        private InvoiceDTO CreateInvoiceDTO()
        {
            Nullable<int> buyerFlatNumber;
            if (int.TryParse(BuyerFlatNumberForm.Text, out int c))
            {
                buyerFlatNumber = c;
            }
            else
            {
                buyerFlatNumber = null;
            }
            Nullable<int> sellerFlatNumber;
            if (int.TryParse(SellerFlatNumberForm.Text, out int s))
            {
                sellerFlatNumber = s;
            }
            else
            {
                sellerFlatNumber = null;
            }

            return new InvoiceDTO()
            {
                InvoiceNumber = InvoiceNumberForm.Text,
                CreationTime = InvoiceCreationDateForm.DisplayDate,
                ModyficationTime = DateTime.Now,
                BuyerNIP = BuyerNIPForm.Text,
                BuyerName = BuyerNameForm.Text,
                BuyerStreet = BuyerStreetForm.Text,
                BuyerStreetNumber = BuyerStreetNumberForm.Text,
                BuyerFlatNumber = buyerFlatNumber,
                SellerNIP = SellerNIPForm.Text,
                SellerName = SellerNameForm.Text,
                SellerStreet = SellerStreetForm.Text,
                SellerStreetNumber = SellerStreetNumberForm.Text,
                SellerFlatNumber = sellerFlatNumber,
                ProductsList = new List<ProductsOnInvoiceDTO>(_productList)
            };
        }
    }
}
