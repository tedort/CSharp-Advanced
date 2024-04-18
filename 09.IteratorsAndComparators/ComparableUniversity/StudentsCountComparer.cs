namespace ComparableUniversity
{
    public class StudentsCountComparer : IComparer<University>
    {
        public int Compare(University? x, University? y)
        {
            return x.Students.Count.CompareTo(y.Students.Count);
        }
    }
}
