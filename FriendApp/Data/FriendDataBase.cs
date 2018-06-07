using FriendApp.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FriendApp.Data
{
   public class FriendDataBase
    {
        #region Atributos
        private readonly SQLiteAsyncConnection database;

        #endregion
        #region Constructor
        public FriendDataBase(string dbPath) {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Friend>().Wait(); // Creamos una tabla que se llama friend wait realiza el proceso hasta que finaliza
        }

        public  Task<List<Friend>> GetFriendsAsync() {
            return  database.Table<Friend>().ToListAsync();
        }

        public  Task<Friend> GetFriendAsync(int id)
        {
            return database.Table<Friend>().Where(f => f.ID == id).FirstOrDefaultAsync();

        }
        public Task<int> SavefriendsAsync(Friend friend) {
            if (friend.ID !=0)
            {
                return database.UpdateAsync(friend);
            }
            else
            {
                return database.DeleteAsync(friend);
            }
        }
        #endregion
    }
}
