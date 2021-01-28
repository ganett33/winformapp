using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win5215Assign2
{ 
    /* COMP.5212-Programming 
     * Assignment2 Windows Form application     
     * Developed by Jongbo Lee*/

    public partial class form : Form
    {
        private int index = -1;  //Instance variable. set the index to -1, if it doesn’t change, no item is selected
        private static List<Customer> CustomerDB = new List<Customer>();  //Add List<t>
        private static Customer customer1 = new Customer("Thom", "Browne", "687-1234"); //Create a Customer object with 3 variables

        public form()
        {
            InitializeComponent();
        }

        private void LoadDB() 
        {
            CustomerDB.Add(new Customer("Thom", "Browne", "687-1234")); //Create object
            CustomerDB.Add(new Customer("Jongbo", "Lee", "326-8681"));
            CustomerDB.Add(new Customer("YJ", "Kim", "053-0853"));
            CustomerDB.Add(new Customer("DS", "Lee", "567-6182"));
        }

        private void form_Load(object sender, EventArgs e)
        {
            LoadDB();  //When form load, form get data from this method and poplulating list on the listbox
        }

        private void ClearBoxes() //Method for clear 3 boxes(firstname/lastname/phone)
        {
            txtbFNam.Clear();
            txtbLNam.Clear();
            txtbPhone.Clear();
        }

        private void ClearDisplay()  //Method for clear the listbox
        {
            lstbList.Items.Clear(); 
        }

        private void DisplayCustomers()  //Method for display on listbox with GetCustomer format
        {            
            foreach (var customer in CustomerDB)  //Loop to add items on the listbox
            {
                lstbList.Items.Add(customer.GetCustomer());
            }
        }

        private void btnListCust_Click(object sender, EventArgs e)  //When click ListCustomer,
        {
            ClearDisplay();  //clear the listbox
            DisplayCustomers();  //display on listbox
        }

        private void btnClearList_Click(object sender, EventArgs e)  //When click Clearlist,
        {
            ClearDisplay();  //clear the listbox
            txtbCusNam.Focus();  //put cursor on search textbox
        }

        private void btnUpdate_Click(object sender, EventArgs e)  //When click update
        {
            if (index >= 0) //When click item on the listbox,
            {
                if (((txtbFNam.Text == string.Empty) || (txtbLNam.Text == string.Empty) || (txtbPhone.Text == string.Empty)))  //3(firstname/lastname/phone) text boxes are empty
                {
                    MessageBox.Show("All textboxes must be filled to continue");  //show validation msg
                }
                else
                {                    
                    CustomerDB[index].FName = txtbFNam.Text;  //1 big string slpit to 3 strings through listbox object, and display firstname/lastname/phone textboxs
                    CustomerDB[index].LName = txtbLNam.Text;
                    CustomerDB[index].Phone = txtbPhone.Text;

                    ClearBoxes();  //clear 3 boxes(firstname/lastname/phone)
                    ClearDisplay();  //clear the listbox
                    DisplayCustomers();  //display on listbox
                    MessageBox.Show("Customer details updated");  //show validation msg
                    btnADD.Enabled = true;  //Addbtn has been active  
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to update");  //When not click item on the listbox, show validation msg
                ClearDisplay();  //clear the listbox
                DisplayCustomers();  //display on listbox
            }
        }

        private void btnADD_Click(object sender, EventArgs e)  //When click Add 
        {
            if ((txtbFNam.Text == string.Empty) || (txtbLNam.Text == string.Empty) || (txtbPhone.Text == string.Empty))  //3(firstname/lastname/phone) text boxes are empty
            {
                MessageBox.Show("All textboxes must be filled to continue");  //show validation msg
            }
            else
            {
                MessageBox.Show("New customer has been added");  //show validation msg     

                customer1.FName = txtbFNam.Text;
                customer1.LName = txtbLNam.Text;
                customer1.Phone = txtbPhone.Text;

                CustomerDB.Add(new Customer($"{txtbFNam.Text}", $"{txtbLNam.Text}", $"{txtbPhone.Text}"));  //Add new data to listbox

                lstbList.Items.Add(customer1.GetCustomer());  //Add new item on the listbox

                ClearBoxes();  //clear 3 boxes(firstname/lastname/phone)
                txtbCusNam.Clear();  //clear search txtbox 
            }
        }

        private void btnDel_Click(object sender, EventArgs e)  //When click Delete
        {
            string message = "Are you sure you want to delete this customer?";  //Set the message;
            string caption = "WARNING";  //Set the caption

            if (index >=0)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;  //Set Msgbox with button yes or no
                DialogResult result;  //Set the variable for result from Msgboxbutton

                result = MessageBox.Show(message, caption, buttons);  //Creat a messagebox
                if (result == DialogResult.Yes)  //If state for when click Yes,
                {
                    MessageBox.Show("The customer has been deleted");  //show validation msg
                    CustomerDB.RemoveAt(index);  //remove from listbox
                    ClearBoxes();  //clear 3 boxes(firstname/lastname/phone)
                    ClearDisplay();  //clear the listbox
                    DisplayCustomers();  //display on listbox
                    btnADD.Enabled = true; //When click Delete btn, Add btn has been active  
                }
                else
                {
                    MessageBox.Show("Operation cancelled");  //show validation msg
                }
            }
            else  //When click No
            {
                MessageBox.Show("Please select a customer to delete!");  //show validation msg
            }
        }

        private void lstbList_SelectedIndexChanged(object sender, EventArgs e)  //When listbox send string to texbox
        {
            btnADD.Enabled = false;  //After select a item from listbox that data displays to 3 txtboxs(firstname/lastname/phone), it will be deactivating the Add btn

            string[] spArray = lstbList.SelectedItem.ToString().Split('\t');  //String array to Split the string by '\t' and distribute to each txtbox(firstname/lastname/phone)
            string firstname = spArray[0].ToString();
            txtbFNam.Text = firstname;
            index = CustomerDB.FindIndex((cust => cust.FName.Contains(firstname)));  //Set the variable and use List<T>.FindIndex for matching string array
            txtbLNam.Text = spArray[1].ToString();
            txtbPhone.Text = spArray[2].ToString();
                      
        }
              

        private void btnSearch_Click(object sender, EventArgs e)  //When click Search
        {
            //When click btnSearch, 
            if (txtbCusNam.Text == string.Empty)  //search txtbox is empty
            {
                MessageBox.Show("You must enter a customer name");  //show validation msg
                txtbCusNam.Focus();  //cursor search txtbox  
            }
            else
            {
                string name = txtbCusNam.Text;  //Set variable as search txtbox

                txtbCusNam.Clear();  //clear search txtbox 
                ClearDisplay();  //clear the listbox

                if (CustomerDB.Exists((cust => cust.FName == name)))  //Use List<T>.Exists method to search for the CustomerDB list
                {
                    int search = CustomerDB.FindIndex((cust => cust.FName.Contains(name)));  //Set the variable, Use List<T>.FindIndex/Contains for matching name variable
                    
                    if (search >= 0)
                    {
                        lstbList.Items.Add((CustomerDB[search].FName  + "\t" +  //Display matched data on the listbox 
                            CustomerDB[search].LName + "\t" +
                            CustomerDB[search].Phone));
                    }                    
                }
                else
                {
                    MessageBox.Show("Customer not found, please try agin");  //show validation msg
                    txtbCusNam.Focus();  //cursor search txtbox 
                }
            }

        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            //When click Clear, firstname/lastname/phone textbox clear and cursor on the firstname txtbox
            ClearBoxes();  //clear 3 boxes(firstname/lastname/phone)
            txtbFNam.Focus();  //cursor on search txtbox 
            btnADD.Enabled = true;  //When click clearbtn, Addbtn has been active  
        }

    }
    
    
}
