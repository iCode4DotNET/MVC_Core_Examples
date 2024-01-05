using Entities;

namespace SampleData
{
    public static class Personel
    {
        public static List<Person> GetPeople()
        {
            var person1 = new Person(1, "Soroush", "Sadr");
            var person2 = new Person(2, "Ali", "Amiri");
            var person3 = new Person(3, "Reza", "Alavi");

            var people = new List<Person>
            {
                person1,
                person2,
                person3,
            };

            return people;
        }
    }
}
