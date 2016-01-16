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
        private static List<Int32> _groupA;

        static JuryList()
        {
            _list = new List<JuryModel>()
            {
                new JuryModel() {JuryId = 12345, CheckedIn = false, Completed = false, DaysAvailable = 3, Phone = "2134234444", Email = "test@email.com"},
                new JuryModel() {JuryId = 12364, CheckedIn = false, Completed = false, DaysAvailable = 1, Phone = "8888888888", Email = "person@email.com"},
                new JuryModel() {JuryId = 12532, CheckedIn = false, Completed = false, DaysAvailable = 5, Phone = "1111111111", Email = "jury@email.com"}
            };

            _groupA = new List<Int32>()
            {
                12345,
                12364
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

        public static List<Int32> GetGroupA()
        {
            return _groupA;
        }
    }
}