using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Task_4
{
    [Serializable]
    public class BirthdayDataBase
    {
        private string firstName;
        private string lastName;
        private DateTime birthDay;
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }
        public BirthdayDataBase()
        {

        }
        public BirthdayDataBase(string firstName, string lastName, DateTime birthDay)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDay = birthDay;
        }
        public static List<BirthdayDataBase> Load(string fileName)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<BirthdayDataBase>));
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            var list = (List<BirthdayDataBase>)xml.Deserialize(fs);
            fs.Close();
            return list;
        }
        public static void Save(string fileName, List<BirthdayDataBase> birthdayDataBases)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<BirthdayDataBase>));
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
            xml.Serialize(fs, birthdayDataBases);
            fs.Close();
        }
    }
}
