﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class JobField
    {
        public int Id { get; }
        public static int nextId = 1;
        public string Value { get; set; }



        public JobField()
        {
            Id = nextId;
            nextId++;
        }
        public JobField(string value) : this()
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }

        public override bool Equals(object obj)
        {
            return obj is JobField type &&
                   Id == type.Id &&
                   Value == type.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Value);
        }
    }
   
}
