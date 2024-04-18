namespace SharkTaxonomy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Initialize new repository (Classifier)
            Classifier classifier = new(3);

            //Initialize entities (Shark)
            Shark greatWhite = new("Great White", 5, "Seals", "Open Ocean");
            Shark hammerhead = new("Hammerhead", 4, "Fish", "Tropical Waters");
            Shark tiger = new("Tiger", 4, "Turtles", "Coral Reefs");

            classifier.AddShark(greatWhite);
            classifier.AddShark(hammerhead);
            classifier.AddShark(tiger);

            Console.WriteLine(classifier.Report());
        }
    }
}

