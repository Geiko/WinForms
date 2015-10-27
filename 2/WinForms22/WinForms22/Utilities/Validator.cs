using System;
using System.Text.RegularExpressions;
using WinForms22.Entities;

namespace WinForms22.Utilities
{
    /// <summary>
    /// It validates Person's data.
    /// </summary>
    class Validator
    {
        internal void Validate(Person person)
        {
            Regex regex = new Regex(@"^[a-zA-Z][a-zA-Z]*");
            if (regex.IsMatch(person.FirstName) == false)
                throw new Exception("Fist name is not valid.");

            if (regex.IsMatch(person.LastName) == false)
                throw new Exception("Last name is not valid.");

            regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (regex.IsMatch(person.EMail) == false)
                throw new Exception("e-mail is not valid.");

            regex = new Regex(@"^[+0-9(][0-9 ()-]*");
            if (regex.IsMatch(person.Phone) == false)
                throw new Exception("Phone number is not valid.");
        }
    }
}
