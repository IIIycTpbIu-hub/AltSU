namespace AltSU.Task_1
{
    public class Employee : Person
    {
        public string Position { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, string surname, string patronymic, string position, string department, decimal salary)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Position = position;
            Department = department;
            Salary = salary;
        }

        public override string ToString()
        {
            var personProp = base.ToString();
            var emplProp = "Position: " + Position + "\r\n" + "Department: " + Department + "\r\n" + "Salary: " + Salary + "\r\n";
            return "Person \r\n" + personProp + emplProp;
        }
    }
}
