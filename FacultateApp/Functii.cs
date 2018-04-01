using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultateApp
{
    public class Functii
    {
        public bool verificaCont(string user, string passwd) {
            using (var db = new DatabaseEntity())
            {
                if (db.Accounts.Any(s => (s.User == user)&&(s.Password==passwd)))
                    return true;
                else
                    return false;
            }
        }
    }
}
