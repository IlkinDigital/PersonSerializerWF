using System.Text.Json;
using System;

namespace PersonSerializerWF.Backend
{
    public class PeopleHandler
    {
        private string _filepath = "";
        public string Filepath { 
            get => _filepath;
            set
            {
                _filepath = value;
                using FileStream fs = new(_filepath, FileMode.OpenOrCreate);
            }
        }
        
        public PeopleHandler(string filepath)
        {
            Filepath = filepath;
        }

        public List<Person> GetAsList()
        {
            using FileStream fs = new(Filepath, FileMode.Open, FileAccess.Read);

            List<Person>? list = new();

            try
            {
                list = JsonSerializer.Deserialize<List<Person>>(fs);
            }
            catch(JsonException) { } // Ignore Json Exception

            if (list != null)
                return list;

            return new();
        }

        public void Add(Person person)
        {
            var peopleList = GetAsList();
            peopleList.Add(person);

            using (FileStream fs = new(Filepath, FileMode.Create, FileAccess.Write))
            {
                JsonSerializer.Serialize(fs, peopleList);
            }
        }

    }
}
