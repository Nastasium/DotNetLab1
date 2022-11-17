using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace BankLibrary
{
    public class Account:Bank
    {
        private string[,] clients = { {"2356458752145698", "4747", "Svirhun A.", "12090", "ipz211_sav@student.ztu.edu.ua"}, { "4568456214753695", "8585", "Svirhun O.", "543", "	anastsvirg@gmail.com"}, 
            { "7418523698745671", "4567", "Svirhun E.", "23423", "nastyasvirgun@gmail.com"}, { "4862268417933971", "4646", "Svirhun I.", "1000", "e_mail@gmail.com"}, 
            { "7563951484569853", "8547", "Svirhun U.", "2342", "your.e_mail@gmail.com"} };

        public string getCard(int i)
        {
            return clients[i, 0];
        }
        public string getPin(int i)
        {
            return clients[i, 1];
        }
        public string getName(int i)
        {
            return clients[i, 2];
        }
        public string getMoney(int i)
        {
            return clients[i, 3];
        }
        public void setMoney(int i, string cash)
        {
            clients[i, 3] = cash;
        }
    }
}
