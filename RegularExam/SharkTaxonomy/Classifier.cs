using System.Text;

namespace SharkTaxonomy
{
    public class Classifier
    {
        private int capacity;
        private List<Shark> species = new List<Shark>();
        private int getCount;

        public Classifier(int capacity)
        {
            Capacity = capacity;
        }

        public int Capacity { get => capacity; set => capacity = value; }
        public List<Shark> Species { get => species; set => species = value; }
        public int GetCount { get => Species.Count; }

        public void AddShark(Shark shark)
        {
            bool canAdd = true;
            for (int i = 0; i < Species.Count; i++)
            {
                if (Species[i].Kind == shark.Kind)
                {
                    canAdd = false;
                }
            }
            if (Species.Count < capacity && canAdd)
            {
                Species.Add(shark);
            }
        }

        public void RemoveShark(string kind)
        {
            bool exists = false;
            int index = 0;
            for (int i = 0; i < Species.Count; i++)
            {
                if (Species[i].Kind == kind)
                {
                    exists = true;
                    index = i;
                }
            }
            if (exists)
            {
                Species.RemoveAt(index);
            }
        }

        public string GetLargestShark()
        {
            List<Shark> sortedSpecies = Species.OrderByDescending(shark => shark.Length).ToList();
            return sortedSpecies[0].ToString();
        }

        public double GetAverageLength()
        {
            double result = 0.0;
            foreach (Shark shark in Species)
            {
                result += shark.Length;
            }
            return result / GetCount;
        }

        public string Report()
        {
            string result = $"{GetCount} sharks classified: ";
            foreach (Shark shark in Species)
            {
                result += $"\n{shark}";
            }
            return result;
        }

    }
}
