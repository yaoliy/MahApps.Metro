using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace MahApps.MetroUI.ListboxItemStylesBug
{
    public static class Helpers
    {
        public static double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }

        public static ObservableCollection<Person> GetData()
        {
            var persons = new ObservableCollection<Person>();
            for (int i = 0; i < 30; i++)
            {
                persons.Add(new Person() 
                { 
                    ID = i,
                    Name = string.Concat("Person ",i),
                    Money = Helpers.GetRandomNumber(10, 100),
                });
            }
            return persons;
        }

    }
}
