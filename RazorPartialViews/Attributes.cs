using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorPartialViews
{
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public  class HelpText : Attribute
    {
        // See the attribute guidelines at 
        //  http://go.microsoft.com/fwlink/?LinkId=85236
        readonly string positionalString;

        // This is a positional argument
        public HelpText(string positionalString)
        {
            this.positionalString = positionalString;


        }

        public string PositionalString
        {
            get { return positionalString; }
        }

         
    }

    class Attributes
    {
    }
}
