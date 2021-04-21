using System;
using System.Collections.Generic;
using System.Text;

namespace Class_UML
{
    class Person
    {
        //fields
        protected string _name;
        protected string _address;

        //properties
       private string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
       private string Address
        { 
            get { return this._address; }
            set { this._address = value; }
        }

        //Constructor
        //Constructor
        public Person(string name, string address)
        {
            this._name = name;
            this._address = address;    
        }

        //Methods
        //Override
        //override toString
        public override string ToString()
        {
            return $"Person [name ={this._name} , address={this._address}]";
        }

    }
}
