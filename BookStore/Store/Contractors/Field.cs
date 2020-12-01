using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Contractors
{
    public abstract class Field
    {
        public string Lable { get; }

        public string Name { get; }

        public string Value { get; }
        
        protected Field (string lable, string name, string value)
        {
            Lable = lable;
            Name = name;
            Value = value;
        }
    }

    public class HiddenField : Field
    {
        public HiddenField(string lable, string name, string value) : base(lable,name,value)
        {

        }
    }

    public class SelectionField : Field
    {
        public IReadOnlyDictionary<string, string> Items { get; } 

        public SelectionField(string lable, string name, string value, IReadOnlyDictionary<string,string> items) 
            : base(lable, name, value)
        {
            Items = items;
        }
    }
}
