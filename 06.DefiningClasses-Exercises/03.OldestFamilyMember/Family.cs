namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people;
        public List<Person> People 
        {
            get => people;
            set => people = value;
        }

        public void AddMember(Person member)
        {
            People.Add(member);
        }

        public Person GetOldestMember()
        {
            Person person = people[0];
            foreach (Person currentPerson in People)
            {
                if (currentPerson.Age > person.Age)
                {
                    person = currentPerson;
                }
            }
            return person;
        }
    }
}
