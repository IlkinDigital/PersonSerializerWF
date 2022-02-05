using System.Text.Json.Serialization;

namespace PersonSerializerWF.Backend
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string PhotoFilepath { get; set; }

        [JsonConstructor] public Person(string name, string surname, int age, string photoFilepath)
        {
            Name = name;
            Surname = surname;
            Age = age;
            PhotoFilepath = photoFilepath;
        }
    }
}
