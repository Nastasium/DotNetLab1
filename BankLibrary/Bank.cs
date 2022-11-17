using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class Bank
    {
        private string bankName = "Шикарний банк";
        protected string[,] ATM = { { "Банкомат 1", "вул. Петра 42", "ia1234","100000" }, {"Банкомат 2", "вул. Кропивницького 2", "ia1264","100000"}, 
            { "Банкомат 3", "площа Перемоги 30", "ia9234","100000" }, { "Банкомат 4", "пров. Бородія 5", "is1234","100000" }, 
            { "Банкомат 5", "вул. Щура 12", "ia1284","100000"}, { "Банкомат 6", "вул. Перемоги 1", "ia1934","100000" } };
        private string[,] bankDepartment = { { "Відділення 1", "вул. Щура 12" }, {"Відділення 2", "вул. Кропивницького 2" },
            { "Відділення 3", "вул. Перемоги 1" }, { "Відділення 4", "пров. Бородія 5" } };
    }
}
