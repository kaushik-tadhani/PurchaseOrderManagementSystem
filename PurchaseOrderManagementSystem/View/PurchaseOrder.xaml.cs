using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PurchaseOrderManagementSystem.View
{
    /// <summary>
    /// Interaction logic for PurchaseOrder.xaml
    /// </summary>
    public partial class PurchaseOrder : UserControl
    {
        public PurchaseOrder()
        {
            InitializeComponent();
        }

        private void Submit(object sender, RoutedEventArgs e)
        {
            string prodid = pid.Text;
            string prodname = pname1.Text;
            string proddesc = pdesc.Text;
            string prodvendor = pvendor.Text;
            string prodquant = quantity.Text;
            string prodprice = uprice.Text;
            string prodcost = pcost.Text;

            string prodtype = "";

            if ((bool)_1.IsChecked)
            {
                prodtype = prodtype + " " + _1.Content;
            }

            if ((bool)_2.IsChecked)
            {
                prodtype = prodtype + " " + _2.Content;
            }

            if ((bool)_3.IsChecked)
            {
                prodtype = prodtype + " " + _3.Content;
            }

            if ((bool)_4.IsChecked)
            {
                prodtype = prodtype + " " + _4.Content;
            }

            if ((bool)_5.IsChecked)
            {
                prodtype = prodtype + " " + _5.Content;
            }

            if ((bool)_6.IsChecked)
            {
                prodtype = prodtype + " " + _6.Content;
            }


            string finalmsg = $"Product ID: {prodid} \n Product Name: {prodname} \n Product Type: {prodtype} \n Product Desc: {proddesc} \n Product Vendor: {prodvendor} \n Quantity: {prodquant} \n Unit Price: {prodprice} \n Product Cost: {prodcost}";

            MessageBox.Show(finalmsg);

        }

        private void pdesc_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Handle text changed event for product description
            // Add any logic you want to execute when the text in the "pdesc" TextBox changes
        }

        private void pcost_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Handle text changed event for total cost
            // Add any logic you want to execute when the text in the "pcost" TextBox changes
        }

    }
}



