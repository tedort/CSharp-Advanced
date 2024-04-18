namespace ComparableUniversity
{
    public class University : IComparable<University>, IComparable<int>
    {
        public string Name { get; set; }
        public List<string> Students { get; set; }
        public double AverageScore { get; set; }

        public int CompareTo(University? other)
        {
            if (AverageScore > other.AverageScore)
            {
                return 1;
            }
            else if (AverageScore < other.AverageScore)
            {
                return -1;
            }
            return 0;
        }

        public int CompareTo(int other)
        {
            return AverageScore.CompareTo(other);
        }
    }
}
