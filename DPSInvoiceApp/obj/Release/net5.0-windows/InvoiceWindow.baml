   M S B A M L   `   `   `  ���� H  DDPSInvoiceApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:DPSInvoiceAppDPSInvoiceApp  !    DPSInvoiceApp.InvoiceWindow   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:DPSInvoiceApp       � Title$  InvoiceWindow��$	��450��$
��1080��.��� .+��� 
�������.@��� $��Lista��.��� ���	#FFE5E5E5.+�&   System.Windows.Controls.DataGrid  -   $��
InvoicesDG��   AutoGenerateColumns$ False��$	��437��$	��Top=�$��0,-3,0,0q�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Numer faktury��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *InvoiceNumber+  $ Czas dodania�� �� *CreationTime+  $ NIP Nabywcy�� �� *
BuyerNIP+  $ Nabywca�� �� *	BuyerName+  $ Ulica�� �� *BuyerStreet+  $ Numer ulicy�� �� *BuyerStreetNumber+  $ Lokal�� �� *BuyerFlatNumber+  $ NIP sprzedawcy�� �� *	SellerNIP+  $ 
Sprzedawca�� �� *
SellerName+  $ Ulica�� �� *SellerStreet+  $ Numer ulicy�� �� *SellerStreetNumber+  $ Lokal�� �� *SellerFlatNumber+�� $��Dodaj nową fakturę��.��� -   $��ContainerCanvas�����	#FFE5E5E5$��-2,0,2,0q�.+��� -   $��Dodaj��$��Right=�$��12,12q�$��Bottom=�$��24��$��72�����	#FF41A955$��12(��� $��Sprzedajacy��$
��Left=�$��	24,12,0,0q�$	��Top=��� -    ��Name$ SellerNameForm��$
��Left=�$��
104,18,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��120���� $��Nabywca��$
��Left=�$��
469,16,0,0q�$	��Top=��� -   $ BuyerNameForm��$
��Left=�$��
549,22,0,0q�$
 Wrap=�$	��Top=�$	��120���� $	��NIP��$
��Left=�$��	26,40,0,0q�$	��Top=��� -   $ SellerNIPForm��$
��Left=�$��
106,46,0,0q�$
 Wrap=�$	��Top=�$	��120���� $	��NIP��$
��Left=�$��
471,42,0,0q�$	��Top=��� -   $ BuyerNIPForm��$
��Left=�$��
551,48,0,0q�$
 Wrap=�$	��Top=�$	��120���� $��Ulica��$
��Left=�$��	26,71,0,0q�$	��Top=��� -   $ SellerStreetForm��$
��Left=�$��
106,77,0,0q�$
 Wrap=�$	��Top=�$	��152���� $��Ulica��$
��Left=�$��
473,77,0,0q�$	��Top=��� -	   $ BuyerStreetForm��$
��Left=�$��
553,83,0,0q�$
 Wrap=�$	��Top=�$	��136���� $��Nr��$
��Left=�$��
265,74,0,0q�$	��Top=� J� RenderTransformOrigin$ 1.187,0.558&�$��27���� -
   $ SellerStreetNumberForm��$
��Left=�$��
297,79,0,0q�$
 Wrap=�$	��Top=�$��53���� $��Nr��$
��Left=�$��
701,77,0,0q�$	��Top=�$ 1.187,0.558&�$��27���� -   $ BuyerStreetNumberForm��$
��Left=�$��
733,82,0,0q�$
 Wrap=�$	��Top=�$��53���� $��	Nr lokalu��$
��Left=�$��
27,102,0,0q�$	��Top=�$ 1.187,0.558&�$��27���� -   $ SellerFlatNumberForm��$
��Left=�$��110,110,0,0q�$
 Wrap=�$	��Top=�$��53���� $��	Nr lokalu��$
��Left=�$��473,104,0,0q�$	��Top=�$ 1.187,0.558&�$��27���� -   $ BuyerFlatNumberForm��$
��Left=�$��556,112,0,0q�$
 Wrap=�$	��Top=�$��53���� $��Numer faktury��$
��Left=�$��
28,147,0,0q�$	��Top=��� -   $ InvoiceNumberForm��$
��Left=�$��118,152,0,0q�$
 Wrap=�$	��Top=�$	��120���� $
��Data��$
��Left=�$��255,147,0,0q�$	��Top=�(  "System.Windows.Controls.DatePicker  -     Name$ InvoiceCreationDateForm��$
��Left=�$��300,148,0,0q�$	��Top=�  -   $��
ProductsDG��$ False��$	��136��$��Bottom=�$��0,0,0,64q�   $ Produkt�� �� *ProductName+  $	 Kod�� �� *ProductCode+  $ Ilość�� �� *QuantityOfProduct+  $ 	Jednostka�� �� *ProductMeasureUnit+�� $��Kod produktu��$
��Left=�$��474,150,0,0q�$	��Top=��� -   $ ProductCodeForm��$
��Left=�$��568,156,0,0q�$
 Wrap=�$	��Top=�$��59���� $��Ilość��$
��Left=�$��632,152,0,0q�$	��Top=��� -   $ QuantityOfProductForm��$
��Left=�$��672,157,0,0q�$
 Wrap=�$	��Top=�$��37���� -   $��Dodaj produkt��$
��Left=�$��723,155,0,0q�$	��Top=�$��90��