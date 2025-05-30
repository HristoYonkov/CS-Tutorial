﻿namespace MyApp
{
    public class LinkedListItem<T>
    {
        public LinkedListItem(T value)
        {
            Value = value;
        }
        public LinkedListItem<T> Previous { get; set; }
        public LinkedListItem<T> Next { get; set; }
        public T Value { get; set; }
    }
}
