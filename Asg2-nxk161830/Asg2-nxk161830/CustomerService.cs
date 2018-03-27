using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asg2_nxk161830
{
    class CustomerService
    {
        /** 
         * Dictionary the holds
         * KEY - UniqueId Combination of (FirstName + " " + LastName + "#" + Phone Number)
         * VALUE - the customer object
         **/
        Dictionary<String, Customer> dictCustomerData = new Dictionary<string, Customer>();

        /**
         * List of String rows that 
         * are to be shown on the Form DataGrid
         **/ 
        List<string[]> rows = new List<string[]>();

        /**
         * File Name where the data are stored and read
         **/
        String fileName = "CS6326Asg2.txt";

        public CustomerService()
        {

        }


        /**
         * UniqueId Combination of (FirstName + " " + LastName + "#" + Phone Number)
         **/
        public String generateCustomerUniqueId(Customer objCustomer)
        {
            String uniqueId = objCustomer.FirstName + " " + objCustomer.LastName + "#" + objCustomer.PhoneNumber;
            return uniqueId;
        }

        /**
         * Saves the NEW Entered Customer Data by checking that
         * it does not violates the rule for entry
         * that no two entry should have same FirstName, LastName and PhoneNumber
         **/
        public Boolean SaveCustomer(Customer objCustomer)
        {
            Boolean success = false;

            String uniqueId = this.generateCustomerUniqueId(objCustomer);
            objCustomer.UniqueId = uniqueId;

            if (!dictCustomerData.ContainsKey(uniqueId))
            {
                dictCustomerData.Add(uniqueId, objCustomer);
                success = true;
            }

            return success;
        }

        /**
        * Saves the EDITED Customer Data by checking that
        * it does not violates the rule for entry
        * that no two entry should have same FirstName, LastName and PhoneNumber
        **/
        public Boolean SaveEditedCustomer(Customer objCustomer, String editUniqueId)
        {
            Boolean success = false;

            String uniqueId = this.generateCustomerUniqueId(objCustomer);
            objCustomer.UniqueId = uniqueId;

            if(editUniqueId.Equals(uniqueId))
            {
                dictCustomerData.Remove(editUniqueId);
                dictCustomerData.Add(uniqueId, objCustomer);
                success = true;
            }
            else
            {
                if (!dictCustomerData.ContainsKey(uniqueId))
                {
                    dictCustomerData.Remove(editUniqueId);
                    dictCustomerData.Add(uniqueId, objCustomer);
                    success = true;
                }
            }

            return success;
        }

        /**
        * Deletes the Customer Data
        **/
        public Boolean deleteCustomer(String uniqueId)
        {
            Boolean success = false;

            if(dictCustomerData.ContainsKey(uniqueId))
            {
                dictCustomerData.Remove(uniqueId);
                success = true;
            }
            return success;
        }


        /**
        * Generates the DataGrid Rows
        * Which is refreshed After 
        * Every Save and Edit and Delete Customer
        **/
        public List<string[]> generateDataGridCustomerData()
        {
            rows = new List<string[]>();
            ICollection<String> uniqueIds = dictCustomerData.Keys;
            foreach (var key in uniqueIds)
            {
                Customer objCustomer = dictCustomerData[key];
                string[] row = new string[] { objCustomer.FirstName + " " + objCustomer.LastName, objCustomer.getFormattedPhoneNumber()};
                rows.Add(row);
            }

            return rows;
        }

        /**
        * Returns the Customer object by
        * getting the row Index and uniqueId
        * from which the data is fetched from the dictionary
        **/
        public Customer getCustomer(int datagridIndex)
        {
            string[] currentRow = rows[datagridIndex];

            String fullName = currentRow[0];
            String phoneNumber = currentRow[1];

            phoneNumber = phoneNumber.Replace("(", "");
            phoneNumber = phoneNumber.Replace(")", "");
            phoneNumber = phoneNumber.Replace("-", "");
            phoneNumber = phoneNumber.Replace(" ", "");
            String uniqueId = fullName + "#" + phoneNumber;

            Customer objCustomer = null;
            if(dictCustomerData.ContainsKey(uniqueId))
            {
                objCustomer = dictCustomerData[uniqueId];
            }

            return objCustomer;
        }

        /**
        * Everytime the application is run
        * this method reads the data that is saved in the file into the dictionary
        * so as to access the Customer data - View and Edit it
        **/
        public void readCustomerDataFromFile()
        {
            String line;
            
            if(!System.IO.File.Exists(System.IO.Path.GetFullPath(@"..\..\" + fileName)))
            {
                return;
            }

            System.IO.StreamReader file = new System.IO.StreamReader(System.IO.Path.GetFullPath(@"..\..\" + fileName));
            while ((line = file.ReadLine()) != null)
            {
                String[] word = line.Split('\t');

                int index = 0;
                Customer objCustomer = new Customer();
                objCustomer.FirstName = word[index++];
                objCustomer.LastName = word[index++];
                objCustomer.MiddleInitial = word[index++];
                objCustomer.AddressLine1 = word[index++];
                objCustomer.AddressLine2 = word[index++];
                objCustomer.City = word[index++];
                objCustomer.State = word[index++];
                objCustomer.Zipcode = word[index++];
                objCustomer.Gender = word[index++];
                objCustomer.PhoneNumber = word[index++];
                objCustomer.Email = word[index++];
                objCustomer.ProofOfPurchased = word[index++];
                objCustomer.DateReceived = word[index++];
                objCustomer.DateStarted = word[index++];
                objCustomer.DateSaved = word[index++];
                objCustomer.CountBackSpaceKey = Convert.ToInt32(word[index++]);

                String uniqueId = generateCustomerUniqueId(objCustomer);
                objCustomer.UniqueId = uniqueId;

                dictCustomerData.Add(uniqueId, objCustomer);
            }

            file.Close();
        }

        /**
         * Writes the customer data in the file
         * with file separation as tab
         **/
        public void writeCustomerDataToFile()
        {
            ICollection<String> uniqueIds = dictCustomerData.Keys;

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(System.IO.Path.GetFullPath(@"..\..\" + fileName)))
            {
                foreach (var key in uniqueIds)
                {
                    Customer objCustomer = dictCustomerData[key];

                    String line = "" + objCustomer.FirstName
                                    + "\t" + objCustomer.LastName
                                    + "\t" + objCustomer.MiddleInitial
                                    + "\t" + objCustomer.AddressLine1
                                    + "\t" + objCustomer.AddressLine2
                                    + "\t" + objCustomer.City
                                    + "\t" + objCustomer.State
                                    + "\t" + objCustomer.Zipcode
                                    + "\t" + objCustomer.Gender
                                    + "\t" + objCustomer.PhoneNumber
                                    + "\t" + objCustomer.Email
                                    + "\t" + objCustomer.ProofOfPurchased
                                    + "\t" + objCustomer.DateReceived
                                    + "\t" + objCustomer.DateStarted
                                    + "\t" + objCustomer.DateSaved
                                    + "\t" + objCustomer.CountBackSpaceKey;

                    file.WriteLine(line);
                }
            }
        }
    }
}
