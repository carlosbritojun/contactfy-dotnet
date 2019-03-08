namespace Contactfy.Domain.Entities
{
    public class Phone
    {
        public Phone(string prefix, string number)
        {
            Prefix = prefix;
            Number = number;
        }

        public string Prefix { get; set; }
        public string Number { get; set; }

        public override string ToString()
        {
            return $"({Prefix}) {Number}";
        }
    }
}
