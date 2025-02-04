﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _02.GenericBoxOfInteger
{
    public class Box<T>
    {
        private List<T> items;

        public Box()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in items)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }


            return sb.ToString().TrimEnd();
        }
    }
}
