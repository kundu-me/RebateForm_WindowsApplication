using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asg2_nxk161830
{
    /**
     * This is the Model Class called Customer
     * Which has all the field that are in the forms
     * and are needed to be saved in the text file.
     **/

    class Customer
    {
        // UniqueId Combination of (FirstName + " " + LastName + "#" + Phone Number)
        private String uniqueId;

        private String firstName;
        private String lastName;
        private String middleInitial;
        private String addressLine1;
        private String addressLine2;
        private String city;
        private String state;
        private String zipcode;
        private String gender;
        private String phoneNumber;
        private String email;
        private String proofOfPurchased;
        private String dateReceived;

        private String dateStarted;
        private String dateSaved;
        private int countBackSpaceKey;

        public Customer()
        {

        }

        /**
         * To Format the Phone Number to be represented as US format
         * 
         **/
        public String getFormattedPhoneNumber()
        {
            String formattedPhoneNumber = "(" + phoneNumber.Substring(0, 3) + ") " + phoneNumber.Substring(3, 3) 
                                            + "-" + phoneNumber.Substring(6, 4);
            return formattedPhoneNumber;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string MiddleInitial
        {
            get
            {
                return middleInitial;
            }

            set
            {
                middleInitial = value;
            }
        }

        public string AddressLine1
        {
            get
            {
                return addressLine1;
            }

            set
            {
                addressLine1 = value;
            }
        }

        public string AddressLine2
        {
            get
            {
                return addressLine2;
            }

            set
            {
                addressLine2 = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }

        public string Zipcode
        {
            get
            {
                return zipcode;
            }

            set
            {
                zipcode = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string ProofOfPurchased
        {
            get
            {
                return proofOfPurchased;
            }

            set
            {
                proofOfPurchased = value;
            }
        }

        public string DateReceived
        {
            get
            {
                return dateReceived;
            }

            set
            {
                dateReceived = value;
            }
        }

        public string UniqueId
        {
            get
            {
                return uniqueId;
            }

            set
            {
                uniqueId = value;
            }
        }

        public string DateStarted
        {
            get
            {
                return dateStarted;
            }

            set
            {
                dateStarted = value;
            }
        }

        public string DateSaved
        {
            get
            {
                return dateSaved;
            }

            set
            {
                dateSaved = value;
            }
        }

        public int CountBackSpaceKey
        {
            get
            {
                return countBackSpaceKey;
            }

            set
            {
                countBackSpaceKey = value;
            }
        }
    }
}
