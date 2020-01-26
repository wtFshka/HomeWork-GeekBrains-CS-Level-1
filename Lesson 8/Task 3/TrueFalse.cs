using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Task_3
{
    [Serializable]
    public class TrueFalse
    {
        public List<Question> Questions { get; private set; }
        public int Count { get => Questions.Count; }
        public Question this[int index]
        {
            get => Questions[index];
        }
        public TrueFalse()
        {
            Questions = new List<Question>();
        }
        public TrueFalse(string fileName)
        {
            Load(fileName);
        }

        private void Load(string fileName)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Question>));
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            Questions = (List<Question>)xml.Deserialize(fs);
            fs.Close();
        }
        public void Save(string fileName)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Question>));
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
            xml.Serialize(fs, Questions);
            fs.Close();
        }
        public void Add(string text, bool trueFalse)
        {
            Questions.Add(new Question(text, trueFalse));
        }
        public void Change(int index, string text, bool trueFalse)
        {
            Questions.RemoveAt(index);
            Questions.Insert(index, new Question(text, trueFalse));
        }
        public void Remove(int index)
        {
            if (Questions != null && index < Questions.Count && index>=0)
            {
                Questions.RemoveAt(index);
            }
        }
    }
}
