using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asg2_nxk161830
{
    public partial class frmRebate : Form
    {
        // Instance of the Customer Service class
        CustomerService customerService;

        // Error Messages to show to the User
        String lblErrorEmpty = "";
        String lblErrorFirstName = "Please Enter the \nFirst Name";
        String lblErrorLastName = "Please Enter the \nLast Name";
        String lblErrorAddress1 = "Please Enter the \nAddress in Address \nin Line1";
        String lblErrorCity = "Please Enter the \nCity";
        String lblErrorState = "Please Enter the \nState";
        String lblErrorZipCode = "Please Enter the \n5 digit ZipCode";
        String lblErrorGender = "Please Select the \nGender";
        String lblErrorPhoneNumber = "Please Enter the \nPhone Number";
        String lblErrorEmailAddress = "Please Enter the \nEmail Address as \nxxx@xx.xxx format";
        String lblErrorProofPurchase = "Please Select \nwhether the \nProof of Purchase \nis attached";
        String lblErrorDateReceived = "Please Enter the \nDate Received as \nmm/dd/yyyy format, \nwithout future date";
        String lblErrorDuplicateEntry = "Duplicate Entry \nPlease check the \nFirst Name, \nLast Name, \nPhone Number";


        public frmRebate()
        {
            InitializeComponent();
            customerService = new CustomerService();
        }

        /**
         * This method saveCustomerData() -
         * save the customer data to the file
         * applying the constarint that no two entry
         * can have the same (First name , Last name, Phone Number)
         * And returns a boolean value true for success
         * or false for failure.
         * It also checks if the user missed any REQUIRED field
         * and shows respective ERROR messages to the USER
         **/

        private Boolean saveCustomerData()
        {
            txtBxTimeSaved.Text = getCurrentDate() + " " + getCurrentTime();

            // Whether Success or Failed to save the new entry
            Boolean success = true;

            /**
             * txtBxEditUniqueId - has the data (uniqueId) for the customer 
             * we will edit the entry
             **/
            String editUniqueId = txtBxEditUniqueId.Text;

            String firstName = txtBxFirstName.Text.Trim();
            String lastName = txtBxLastName.Text.Trim();
            String middleInitial = txtBxMiddleInitial.Text.Trim();
            String addressLine1 = txtBxAddressLine1.Text.Trim();
            String addressLine2 = txtBxAddressLine2.Text.Trim();
            String city = txtBxCity.Text.Trim();
            String state = txtBxState.Text.Trim();
            String zipcode = maskedTxtBxZipCode.Text.Trim();
            String gender = "";
            String phoneNumber = maskedTxtBxPhoneNumber.Text.Trim();
            String email = txtBxEmail.Text.Trim();
            String proofOfPurchased = "";
            String dateReceived = maskedTxtBxDate.Text.Trim();

            String dateStarted = txtBxTimeStarted.Text;
            String dateSaved = txtBxTimeSaved.Text;
            String countBackSpaceKey = txtBxCountBackSpaceKey.Text;
            
            /**
             * Checking -
             * To see if the user has entered all the
             * mandatory fields.
             **/
            if (firstName == "") 
            {
                txtBxFirstName.Focus();
                labelErrorHeader.Text = lblErrorFirstName;
                success = false;
                return false;
            }

            if (lastName == "")
            {
                txtBxLastName.Focus();
                labelErrorHeader.Text = lblErrorLastName;
                success = false;
                return false;
            }

            if (addressLine1 == "")
            {
                txtBxAddressLine1.Focus();
                labelErrorHeader.Text = lblErrorAddress1;
                success = false;
                return false;
            }

            if (city == "")
            {
                txtBxCity.Focus();
                labelErrorHeader.Text = lblErrorCity;
                success = false;
                return false;
            }

            if (state == "")
            {
                txtBxState.Focus();
                labelErrorHeader.Text = lblErrorState;
                success = false;
                return false;
            }


            zipcode = zipcode.Replace(" ", "");
            if (zipcode.Length !=5)
            {
                labelErrorHeader.Text = lblErrorZipCode;
                maskedTxtBxZipCode.Focus();
                success = false;
                return false;
            }

            if (radioBtnGenderMale.Checked)
            {
                gender = "M";
            }
            else if(radioBtnGenderFemale.Checked)
            {
                gender = "F";
            }
            else
            {
                groupBoxGender.Focus();
                labelErrorHeader.Text = lblErrorGender;
                success = false;
                return success;
            }

            phoneNumber = phoneNumber.Replace("(", "");
            phoneNumber = phoneNumber.Replace(")", "");
            phoneNumber = phoneNumber.Replace("-", "");
            phoneNumber = phoneNumber.Replace(" ", "");
            if (phoneNumber == "" || phoneNumber.Length != 10)
            {
                maskedTxtBxPhoneNumber.Focus();
                labelErrorHeader.Text = lblErrorPhoneNumber;
                success = false;
                return success;
            }

            if(email == "" || email.IndexOf("@") < 0 || email.IndexOf(".") < 0)
            {
                txtBxEmail.Focus();
                labelErrorHeader.Text = lblErrorEmailAddress;
                success = false;
                return false;
            }

            if(radioBtnProofYes.Checked)
            {
                proofOfPurchased = "Y";
            }
            else if(radioBtnProofNo.Checked)
            {
                proofOfPurchased = "N";
            }
            else
            {
                groupBoxProofPurchase.Focus();
                labelErrorHeader.Text = lblErrorProofPurchase;
                success = false;
                return success;
            }

            if(dateReceived == "" || dateReceived.Length != 10)
            {
                maskedTxtBxDate.Focus();
                labelErrorHeader.Text = lblErrorDateReceived;
                success = false;
                return success;
            }
            else
            {
                String[] arrDateReceived = dateReceived.Split('/');
                if( ((Convert.ToInt32(arrDateReceived[0]) <= 0) || (Convert.ToInt32(arrDateReceived[0]) > 12)) ||
                    ((Convert.ToInt32(arrDateReceived[1]) <= 0) || (Convert.ToInt32(arrDateReceived[1]) > 31)) ||
                    ((Convert.ToInt32(arrDateReceived[2]) <= 0)))
                {
                    maskedTxtBxDate.Focus();
                    labelErrorHeader.Text = lblErrorDateReceived;
                    success = false;
                    return success;
                }

                DateTime dtDateReceived = Convert.ToDateTime(dateReceived);
                DateTime currentDay = DateTime.Today;
               
                if(dtDateReceived.Date.CompareTo(currentDay.Date) > 0 )
                {
                    maskedTxtBxDate.Focus();
                    labelErrorHeader.Text = lblErrorDateReceived;
                    success = false;
                    return success;
                }
            }
            

            /**
             * Creatimg Customer Object
             * from the entered data
             **/
            Customer objCustomer = new Customer();
            objCustomer.FirstName = firstName;
            objCustomer.LastName = lastName;
            objCustomer.MiddleInitial = (middleInitial == "") ? "-" : middleInitial;
            objCustomer.AddressLine1 = addressLine1;
            objCustomer.AddressLine2 = (addressLine2 == "") ? "-" : addressLine2;
            objCustomer.City = city;
            objCustomer.State = state;
            objCustomer.Zipcode = zipcode;
            objCustomer.Gender = gender;
            objCustomer.PhoneNumber = phoneNumber;
            objCustomer.Email = email;
            objCustomer.ProofOfPurchased = proofOfPurchased;
            objCustomer.DateReceived = dateReceived;

            objCustomer.DateStarted = dateStarted;
            objCustomer.DateSaved = dateSaved;
            countBackSpaceKey = (countBackSpaceKey == "") ? "0" : countBackSpaceKey;
            objCustomer.CountBackSpaceKey = Convert.ToInt32(countBackSpaceKey);


            /**
             * To save data based on if the Current entry is
             * NEW or EDIT entry
             * and get the boolean success
             **/
            if(success)
            {
                if (editUniqueId.Length > 0)
                {
                    success = customerService.SaveEditedCustomer(objCustomer, editUniqueId);
                }
                else
                {
                    success = customerService.SaveCustomer(objCustomer);
                }
            }

            if(success)
            {
                customerService.writeCustomerDataToFile();
            }
            else
            {
                labelErrorHeader.Text = lblErrorDuplicateEntry;
            }

            return success;
        }

        /**
         * This method reset the form to
         * start re-entry of new Record
         **/
        private void resetForm()
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Clear();
                }

                if(x is MaskedTextBox)
                {
                    ((MaskedTextBox)x).Clear();
                }
            }

            radioBtnGenderMale.Checked = false;
            radioBtnGenderFemale.Checked = false;
            radioBtnProofYes.Checked = false;
            radioBtnProofNo.Checked = false;

            labelErrorHeader.Text = lblErrorEmpty;

            // Default Date of DateReceived set to current Date
            this.setDateReceivedToCurrentDate();

        }

        /**
         * This method Saves the Current Record and start 
         * a new Form for re-entry as the current form succeds in saving
         **/
        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            Boolean successSave = this.saveCustomerData();
            if (successSave)
            {
                resetForm();
                disableInput(false);
                toggleBtn(false);

                updateDataGrid();
            }
        }

        /**
         * This method Saves the Current Record and Exit 
         * the application as the current form succeds in saving
         **/
        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            Boolean successSave = saveCustomerData();

            if (successSave)
            {
                Application.Exit();
            }

        }

        /**
         * Resets the form to start entering a new form by the user
         **/
        private void btnNew_Click(object sender, EventArgs e)
        {
            resetForm();
            disableInput(false);
            toggleBtn(false);
        }

        /**
         * This methods deletes the current selected entry
         * and updates that in the file also 
         * and returns success boolean variable
         **/
        private void btnDelete_Click(object sender, EventArgs e)
        {
            String editUniqueId = txtBxEditUniqueId.Text;
            Boolean success = customerService.deleteCustomer(editUniqueId);

            if (success || (editUniqueId == ""))
            {
                resetForm();
                disableInput(false);
                toggleBtn(false);

                updateDataGrid();
            }

            customerService.writeCustomerDataToFile();
        }

        /**
         * This methods 
         * performs when the forms loads for the first time
         * reading the old saved text file and bring it to the memory
         * also putting the old saved records in the datagrid
         * to be accessible by the user
         **/
        private void frmRebate_Load(object sender, EventArgs e)
        {
            //Console.WriteLine(System.Environment.CurrentDirectory);
            //Console.WriteLine(System.IO.Path.GetFullPath(@"..\..\"));

            labelErrorHeader.Text = lblErrorEmpty;
            labelInsLeft.Text = "VIEW - Click the Row Header or any Cell \non the Row, to View the Record Details";
            labelInsMiddle.Text = "Save && New - Save current and New \nSave && Exit - Save current and Exit";
            labelInsRight.Text = "EDIT - Edit the Current Viewed Record \nDELETE - Delete the Current Viewed Record \nNEW - To Start Entering a New Record";

            // Default Date of DateReceived set to current Date
            this.setDateReceivedToCurrentDate();

            // Read the Customer Data in file for the First Time
            customerService.readCustomerDataFromFile();

            // Update the DataGrid on form load
            this.updateDataGrid();
   
        }

        /**
         * This method sets the Date Received field in the form
         * to the current Date so as help the user reduce key press
         **/
        private void setDateReceivedToCurrentDate()
        {

            String currentDate = getCurrentDate();
            maskedTxtBxDate.Text = currentDate;
        }

        /**
         * Everytime a Data is Entered / Saved / Edited / Deleted
         * This method updates the datagrid on the left
         **/
        private void updateDataGrid()
        {
            dataGridViewCustomer.Rows.Clear();
            List<string[]> datagridRows = customerService.generateDataGridCustomerData();
            foreach (var row in datagridRows)
            {
                dataGridViewCustomer.Rows.Add(row);
            }

            dataGridViewCustomer.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        /**
         * This method based on the datagrid selection
         * shows the Customer Data and also allows to EDIT or DELETE the data 
         **/
        private void viewCustomerData(object sender, DataGridViewCellMouseEventArgs e)
        {
            viewCustomerData();
        }

        /**
        * This method based on the datagrid selection
        * shows the Customer Data and also allows to EDIT or DELETE the data 
        **/
        private void viewCustomerData()
        {
            int datagridIndex = dataGridViewCustomer.SelectedRows[0].Index;
            Customer objCustomer = customerService.getCustomer(datagridIndex);

            if (objCustomer == null)
            {
                return;
            }

            resetForm();
            disableInput(true);

            txtBxFirstName.Text = objCustomer.FirstName;
            txtBxLastName.Text = objCustomer.LastName;
            txtBxMiddleInitial.Text = objCustomer.MiddleInitial;
            txtBxAddressLine1.Text = objCustomer.AddressLine1;
            txtBxAddressLine2.Text = objCustomer.AddressLine2;
            txtBxCity.Text = objCustomer.City;
            txtBxState.Text = objCustomer.State;
            maskedTxtBxZipCode.Text = objCustomer.Zipcode;

            if (objCustomer.Gender == "M")
            {
                radioBtnGenderMale.Checked = true;
            }
            else if (objCustomer.Gender == "F")
            {
                radioBtnGenderFemale.Checked = true;
            }

            maskedTxtBxPhoneNumber.Text = objCustomer.getFormattedPhoneNumber();
            txtBxEmail.Text = objCustomer.Email;

            if (objCustomer.ProofOfPurchased == "Y")
            {
                radioBtnProofYes.Checked = true;
            }
            else if (objCustomer.ProofOfPurchased == "N")
            {
                radioBtnProofNo.Checked = true;
            }

            maskedTxtBxDate.Text = objCustomer.DateReceived;

            txtBxTimeStarted.Text = objCustomer.DateStarted;
            txtBxTimeSaved.Text = objCustomer.DateSaved;
            txtBxCountBackSpaceKey.Text = Convert.ToString(objCustomer.CountBackSpaceKey);
            txtBxEditUniqueId.Text = objCustomer.FirstName + " " + objCustomer.LastName + "#" + objCustomer.PhoneNumber;

            toggleBtn(true);
        }

        /**
        * This method based on the datagrid selection
        * allows to EDIT the Customer Data data 
        **/
        private void btnEdit_Click(object sender, EventArgs e)
        {
            toggleBtn(false);
            disableInput(false);
        }

        /**
        * This method based on the datagrid selection
        * Toggle how the buttons at the bottom behave
        **/
        private void toggleBtn(Boolean isEdit)
        {

            btnEdit.Enabled = isEdit;
            btnSaveNew.Enabled = !isEdit;
            btnSaveExit.Enabled = !isEdit;
        }

        /**
        * This method based on the datagrid selection
        * disables all the fields in the form to make it
        * only Read-able to the user
        **/
        private void disableInput(Boolean isDisable)
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Enabled = !isDisable;
                }

                if (x is MaskedTextBox)
                {
                    ((MaskedTextBox)x).Enabled = !isDisable;
                }
            }

            radioBtnGenderMale.Enabled = !isDisable;
            radioBtnGenderFemale.Enabled = !isDisable;
            radioBtnProofYes.Enabled = !isDisable;
            radioBtnProofNo.Enabled = !isDisable;

        }

        /**
         * This method gets the current Date
         **/
        public String getCurrentDate()
        {
            DateTime currentDay = DateTime.Today;
            String currentDate = currentDay.ToString("MM/dd/yyyy");
            getCurrentTime();
            return currentDate;
        }

        /**
         * This method gets the current Time
         **/
        public String getCurrentTime()
        {
            DateTime currentDay = DateTime.Now;
            String currentTime = currentDay.ToString("HH:mm:ss");
            
            return currentTime;
        }

        /**
         * This method update the Time when the user started filling up the form
         **/
        private void startFormFillUp(object sender, KeyPressEventArgs e)
        {
            if (txtBxTimeStarted.Text.Length == 0)
            {
                txtBxTimeStarted.Text = getCurrentDate() + " " + getCurrentTime();
            }

            if (e.KeyChar == (char) Keys.Back)
            {
                int count = (txtBxCountBackSpaceKey.Text == "") ? 0 : Convert.ToInt32(txtBxCountBackSpaceKey.Text);
                txtBxCountBackSpaceKey.Text = Convert.ToString(count + 1);
            }
        }

        /**
         * This method based on the datagrid selection
         * shows the Customer Data and also allows to EDIT or DELETE the data 
         **/
        private void viewCustomerData(object sender, DataGridViewCellEventArgs e)
        {
            viewCustomerData();
        }
    }
}
