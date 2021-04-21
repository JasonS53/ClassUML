using System;
using System.Collections.Generic;
using System.Text;

namespace Class_UML
{
    class Student : Person
    {
        //fields
        private string _program;
        private int _year;
        private double _fee;

        //properties
        private string Program
        {
            get { return this._program; }
            set { this._program = value; }
        }
        private int Year
        {
            get { return this._year; }
            set { this._year = value; }
        }
        private double Fee
        {
            get { return this._fee; }
            set { this._fee = value; }
        }

        //Constructor
        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            this._program = program;
            this._year = year;
            this._fee = fee;
        }

        //Methods
        //Override
        //override toString
        public override string ToString()
        {
            return $"Student [name= {this._name} , address= {this._address} , program= {this._program} , year= {this._year} , fee=${this._fee}]";
        }
    }
}
