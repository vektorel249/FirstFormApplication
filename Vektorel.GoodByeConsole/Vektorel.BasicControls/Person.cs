namespace Vektorel.BasicControls
{
    class Person
    {
        public string FirstName {  get; set; }
        public string LastName {  get; set; }
        public DateTime BirthDate {  get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} - {BirthDate.ToString("dd/MM/yyyy")}";
        }
    }
}
