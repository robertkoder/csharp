namespace csharp
{
    public class Person {
        public string? Name { get; set; }
        public int? Age { get; set; }

        // constructor
        public Person(string? name, int? age) {
            Name = name;
            Age = age;
        }

    }
}