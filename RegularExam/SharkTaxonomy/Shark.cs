using System.Text;

namespace SharkTaxonomy
{
    public class Shark
    {
        private string kind;
        private int length;
        private string food;
        private string habitat;

        public Shark(string kind, int length, string food, string habitat)
        {
            Kind = kind;
            Length = length;
            Food = food;
            Habitat = habitat;
        }

        public string Kind { get => kind; set => kind = value; }
        public int Length { get => length; set => length = value; }
        public string Food { get => food; set => food = value; }
        public string Habitat { get => habitat; set => habitat = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Kind} shark: {Length}m long.\n");
            sb.Append($"Could be spotted in the {Habitat}, typical menu: {Food}");
            return sb.ToString().TrimEnd();
        }
    }
}
