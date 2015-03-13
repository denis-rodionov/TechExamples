using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DataGenerator
{
    abstract class BaseGenerator
    {
        Random _random = new Random();
        List<string> _names;
        List<string> _surnames;
        List<string> _thirdnames;

        public BaseGenerator()
        {
            _names = loadStrings("data\\names.txt");
            _surnames = loadStrings("data\\surnames.txt");
            _thirdnames = loadStrings("data\\thirdname.txt"); 
        }

        public abstract int generate();

        protected List<string> loadStrings(string path)
        {
            List<string> res = new List<string>();
            StreamReader reader = new StreamReader(path);
            string line = reader.ReadLine();
            while (line != null)
            {
                res.Add(line);
                line = reader.ReadLine();
            }
            reader.Close();

            return res;
        }

        protected string getRandom(List<string> list)
        {
            int count = list.Count;
            return list[_random.Next(0, count - 1)];
        }

        protected string getName()
        {
            return getRandom(_names);
        }

        protected string getSurname()
        {
            return getRandom(_surnames);
        }

        protected string getThirdname()
        {
            return getRandom(_thirdnames);
        }

        protected string getPassportNumber()
        {
            string serie = _random.Next(1000, 9999).ToString();
            string number = _random.Next(100000, 999999).ToString();
            return serie + number;
        }

        protected int getAge()
        {
            return _random.Next(17, 60);
        }

        protected int getRecentYear()
        {
            return _random.Next(2000, 2011);
        }

        protected string getPhone()
        {
            return _random.Next(1000000, 9999999).ToString();
        }

        protected string getAddress()
        {
            return "Не задан";
        }

        protected int getDegree()
        {
            return _random.Next(1, 22);
        }

        protected int getPost()
        {
            return _random.Next(1, 5);
        }

        protected int getRank()
        {
            return _random.Next(1, 2);
        }
    }
}
