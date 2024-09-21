﻿using System;
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
        private int rentalNums; // Keeps track of the number of rentals by a specific customer
        private Boolean rentalState;
        private Guid id;
        private List<string> customerDetails;


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
            addDetails();
        }

        public Customer(string[] customerInfo)
        {
            customerDetails = new List<string>();
            this.firstName = customerInfo[0];
            this.lastName = customerInfo[1];
            this.age = Int32.Parse(customerInfo[2]);
            this.email= customerInfo[3];
            this.phoneNum = customerInfo[4];
        }

        private void addDetails()
        {
            customerDetails.Add("First Name: " + this.getFirstName());
            customerDetails.Add("Last Name: " + this.getLastName());
            customerDetails.Add("Age: " + this.getAge().ToString());
            customerDetails.Add("Email: " + this.getEmail());
            customerDetails.Add("Phone Number: " + this.getPhone());
            customerDetails.Add("DOL ID Number: " + this.getIdNum().ToString());
        }

        public String getFirstName() => firstName;
        public String getLastName() => lastName;
        public String getEmail() => email;
        public String getPhone() => phoneNum;
        public Boolean getRentalState() => this.rentalState;
        public Guid getId() => id;
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
            addDetails();

            String[] temp = customerDetails.ToArray();

            return temp;
        }

        private void updateRentalNum()
        {
            this.rentalNums++;
        }

    }
}
