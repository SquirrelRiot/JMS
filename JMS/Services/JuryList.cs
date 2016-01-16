using JMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JMS.Services
{
    public class JuryList
    {
        private static List<JuryModel> _list; // Static List instance

        static JuryList()
        {
            _list = new List<JuryModel>()
            {
                new JuryModel() {JuryId = 12345, CheckedIn = false, Completed = false, DaysAvailable = 3},
                new JuryModel() {JuryId = 12364, CheckedIn = false, Completed = false, DaysAvailable = 1},
                new JuryModel() {JuryId = 12532, CheckedIn = false, Completed = false, DaysAvailable = 5}
            };
        }

        public static bool CheckedIn(int id)
        {
            for (int i = 0; i < _list.Count(); i++)
            {
                if (_list[i].JuryId == id)
                {
                    _list[i].CheckedIn = true;
                    return true;
                }
            }
            return false;
        }

        public static bool Completed(int id)
        {
            for (int i = 0; i < _list.Count(); i++)
            {
                if (_list[i].JuryId == id)
                {
                    _list[i].Completed = true;
                    return true;
                }
            }
            return false;
        }
    }
}