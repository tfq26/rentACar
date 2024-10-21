using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentACar2
{
    public class Customer
    {
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNum;
        private int age;
        private long idNum;
        private string password;
        private int rentalNums; // Keeps track of the number of rentals by a specific customer
        private Boolean rentalState;
        private Guid id;
        private List<string> customerDetails;
        private Image customerImage;


        public Customer()
        {
            this.firstName = string.Empty;
            this.lastName = string.Empty;
            this.email = string.Empty;
            this.phoneNum = string.Empty;
            this.age = 0;
            this.idNum = 0;
            customerDetails = new List<string>();
            this.rentalState = false;
            this.id = Guid.Empty;
            this.customerImage = rentACar2.Properties.Resources.defaultPFP;
    }

    public Customer(string firstName, string lastName, int age, long DOLNum, string email, string phoneNum, Guid userId)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phoneNum = phoneNum;
            this.age = age;
            this.idNum = DOLNum;
            this.rentalState = false;
            this.id = userId;
            customerDetails = new List<string>();
            this.customerImage = rentACar2.Properties.Resources.defaultPFP;
        }

        public Customer(string[] customerInfo)
        {
            customerDetails = new List<string>();
            this.id = Guid.Parse(customerInfo[0]);
            this.lastName = customerInfo[1];
            this.firstName = customerInfo[2];
            this.age = Int32.Parse(customerInfo[3]);
            this.email= customerInfo[4];
            this.phoneNum = customerInfo[5];
            this.password = customerInfo[6];
            this.customerImage = null;
        }

        public Customer(string[] customerInfo, Image customerPfp)
        {
            customerDetails = new List<string>();
            this.id = Guid.Parse(customerInfo[0]);
            this.firstName = customerInfo[1];
            this.lastName = customerInfo[2];
            this.age = Int32.Parse(customerInfo[3]);
            this.email = customerInfo[4];
            this.phoneNum = customerInfo[5];
            this.customerImage = customerPfp;
        }

        public String getFirstName() => firstName;
        public String getLastName() => lastName;
        public String getEmail() => email;
        public String getPassword() => password;
        public String getPhone() => phoneNum;
        public Boolean getRentalState() => this.rentalState;
        public String getId() => id.ToString().Trim().ToUpper();
        public int getAge() => age;
        public long getIdNum() => idNum;

        public void setFirstName(String newFirstName)
        {
            firstName = newFirstName;
        }

        public void setLastName(String newLastName)
        {
            lastName = newLastName;
        }

        public void setGUID(Guid id)
        {
            this.id = id;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public void setAge(int a)
        {
            age = a;
        }

        public void setEmail(String newEmail)
        {
            this.email = newEmail;
        }

        public void setPhoneNum(string newPhoneNum)
        {
            this.phoneNum = newPhoneNum;
        }

        public void setIdNum(int newIdNum)
        {
            this.idNum = newIdNum;
        }

        public void setRentalState(bool newRentalState)
        {
            this.rentalState = newRentalState;
        }

        public string[] getCustomerDetails()
        {
           

            String[] temp = customerDetails.ToArray();

            return temp;
        }

        private void updateRentalNum()
        {
            this.rentalNums++;
        }

        public void setCustomerImage(string path)
        {

            try
            {
                customerImage = Image.FromFile(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error With setting new Image from path\n" + ex.ToString(), "Error in Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void setCustomerImage(Image userImage)
        {
            try
            {
                customerImage = userImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error With setting new Image from image\n" + ex.Message, "Error in Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Image getCustomerImage()
        {
            return customerImage;
        }

    }
}
