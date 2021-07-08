using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqUI.Models;

namespace LinqUI
{
    public static class SampleData
    {
        public static List<ContactModel> GetContactData()
        {
            List<ContactModel> output = new List<ContactModel>
            {
                new ContactModel
                {
                    Id = 1,
                    FirstName = "Donny",
                    LastName = "Brido",
                    Addresses = new List<int>{1,2,3}
                },
                new ContactModel
                {
                    Id = 2,
                    FirstName = "Jean",
                    LastName = "Marc",
                    Addresses = new List<int>{1}
                },
                new ContactModel
                {
                    Id = 3,
                    FirstName = "Joseph",
                    LastName = "Marc",
                    Addresses = new List<int>{2}
                },
                new ContactModel
                {
                    Id = 4,
                    FirstName = "Edith",
                    LastName = "Marcel",
                    Addresses = new List<int>{3}
                },
                new ContactModel
                {
                    Id = 5,
                    FirstName = "Marie",
                    LastName = "Judith",
                    Addresses = new List<int>{2,3}
                },
                
            };
            return output;
        }

        public static List<AddressModel> GetAddressData()
        {
            List<AddressModel> output = new List<AddressModel>
            {
                new AddressModel
                {
                    Id = 1,
                    City = "Paris",
                    State = "France"
                },
                new AddressModel
                {
                    Id = 2,
                    City = "Yekaterinburg",
                    State = "SVO"
                },
                new AddressModel
                {
                    Id = 3,
                    City = "Moscow",
                    State = "MCK"
                },

            };
            return output;
        }
    }
}
