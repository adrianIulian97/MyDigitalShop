using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*  LoginForm  */
            //LoginForm login = LoginForm.Instance;
            //Application.Run(login);
            /*  MainMenuForm  */
            //MainMenuForm mainmenu= MainMenuForm.Instance;
            //Application.Run(mainmenu);
            /*  ClientForm  */
            //MainClientForm mainClient = new MainClientForm();
            //Application.Run(mainClient);
            /*  AddClient  */
            //MainClientAddForm mainClientAdd = new MainClientAddForm();
            //Application.Run(mainClientAdd);
            /*  ClientAddAddressForm  */
            //MainClientAddAddressForm mainClientAddress = new MainClientAddAddressForm();
            //Application.Run(mainClientAddress);
            /*  InvoiceForm  */
            //MainInvoiceForm mainmenu = new MainInvoiceForm();
            //Application.Run(mainmenu);
            /*  AddInvoiceForm  */
            MainInvoiceAddForm mainmenu = new MainInvoiceAddForm();
            Application.Run(mainmenu);
        }
    }
}

//TO DO
//-MainClienEditForm: -comportament: dublu-click pe adresa si sa intru in EditAdresaClient
//-MainMenuClientForm: -comportament:  dublu-click pe adresa si sa intru in EditClient
//-MainClientAddForm: -imbunatatit interfata
//-MainClientAddAddressForm: -buton Judet-->comboBox(DROPDOWN) sa mearga sortarea
//                           -buton Oras-->comboBox(DROPDOWN) sa meargasortarea
//DECIZIE IMPORTANTA!! -->> folosim aceelasi form pentru editarea adresei CLientului sau cream altul.
