namespace AltSU.Task_1
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + "\r\n" + "Surname: " + Surname + "\r\n" + "Patronymic: " + Patronymic + "\r\n";
        }
    }
}
