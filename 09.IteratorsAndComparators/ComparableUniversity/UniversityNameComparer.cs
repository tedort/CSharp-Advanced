namespace ComparableUniversity
{
    public class UniversityNameComparer : IComparer<University>
    {
        public int Compare(University? x, University? y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
