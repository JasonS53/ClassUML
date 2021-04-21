using System;
using System.Collections.Generic;
using System.Text;

namespace Class_UML
{
    class Staff : Person
    {
        //fields
        private string _school;
        private double _pay;

        //properties
        private string School
        {
            get { return this._school; }
            set { this._school = value; }
        }
        private double Pay
        {
            get { return this._pay; }
            set { this._pay = value; }
        }

        //Constructor
        public Staff(string name, string address, string school, double pay) : base (name, address)
        {
            this._school = school;
            this._pay = pay;
        }

        //Method
        //Override
        //override toString
        public override string ToString()
        {
            return $"Staff [name= {this._name} , address= {this._address} , school = {this._school} , pay={this._pay}]";
        }

    }
}
