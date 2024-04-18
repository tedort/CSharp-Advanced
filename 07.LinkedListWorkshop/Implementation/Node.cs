﻿namespace Implementation
{
    public class Node<T>
    {
        public Node(T value)
        {
            Value = value;
        }
        
        public T Value { get; set; }

        public Node<T> Next { get; set; }

        public Node<T> Previous { get; set; }

        public override string ToString()
        {
            return $"{Previous.Value}<-{Value}->{Next.Value}";
        }
    }
}
