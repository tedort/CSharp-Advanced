namespace _06.SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", "));
            string command = Console.ReadLine();
            while (songs.Any())
            {
                if (command.Contains("Play"))
                {
                    songs.Dequeue();
                }
                else if (command.Contains("Add"))
                {
                    string newSong = command.Substring(4);
                    bool isContained = false;
                    foreach (string song in songs)
                    {
                        if (song == newSong)
                        {
                            isContained = true;
                        }
                    }
                    if (isContained)
                    {
                        Console.WriteLine($"{newSong} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(newSong);
                    }
                }
                else
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}
