using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Course.Classes
{
    public  class RegistredUserRepos
    {
        private static List<RegistredUser> registredUsers = new List<RegistredUser>();
        private static int userId = 1;
   
        public RegistredUser RegistredUser(string name, string surname, string login, string password)
        {
            RegistredUser user = new RegistredUser(name, surname, login, password);
            user.UserId = userId;
            userId++;
            registredUsers.Add(user);
            return user;
        }

        public static List<RegistredUser> ViewUsers()
        {
            return registredUsers;
        }

        public  static void SavingTheUsers(string path)
        {
            string jsonstring = "";
            //if (registredUsers == null)
            //    throw new NullReferenceException();
            foreach (var user in registredUsers)
            {
                jsonstring += JsonSerializer.Serialize(user);
                jsonstring += "\n";
            }
            if (jsonstring != "")
                File.WriteAllText(path, jsonstring);
            else 
                File.WriteAllText(path, jsonstring);

            
        }
        public static void ReadTheUsers(string path)
        {
           
            if (File.ReadLines(path).ToList() == null)
                registredUsers = null;

            List<string> lines = new List<string>();
            registredUsers.Clear();
            lines = File.ReadLines(path).ToList();
            foreach (string line in lines)
            {
                RegistredUser? user;
                user = JsonSerializer.Deserialize<RegistredUser>(line);
                userId = user.UserId+1;
                registredUsers.Add(user);

            }
            


        }
        public  void RemoveRegistredUser(RegistredUser user)
        {
            registredUsers.Remove(user);
        }

        public RegistredUser? GetRegistredUserByUsername(string login)
        {
           
            foreach (RegistredUser user in ViewUsers())
            {
                if (user.Login == login)
                {
                    return user; 
                }
            }

            return null; 
        }

    }
}
