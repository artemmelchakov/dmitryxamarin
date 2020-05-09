using System.Collections.Generic;
using SQLite;

namespace App3.DAL
{
    public class ContactRepository
    {
        SQLiteConnection database;
        public ContactRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Contact>();
        }
        public IEnumerable<Contact> GetItems()
        {
            return database.Table<Contact>().ToList();
        }
        public Contact GetItem(int id)
        {
            return database.Get<Contact>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<Contact>(id);
        }
        public int SaveItem(Contact item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
