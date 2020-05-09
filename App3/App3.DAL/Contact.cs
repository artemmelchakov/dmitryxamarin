using System;
using System.Text;
using SQLite;

namespace App3.DAL
{
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Date { get; set; }
        public string Offer { get; set; }
        public string NameDevice { get; set; }
        public string Address { get; set; }
        public string Message { get; set; }
    }
}
