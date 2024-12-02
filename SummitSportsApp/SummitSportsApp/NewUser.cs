using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummitSportsApp
{
    internal class NewUser
    {
        // personal info
        public string title;
        public string fName;
        public string mName;
        public string lName;
        public string suffix;

        public string addy1;
        public string addy2;
        public string addy3;
        public string city;
        public string state;
        public string zip;

        public string email;
        public string phone1;
        public string phone2;

        // credentials
        public string user;
        public string pass;

        // questions
        public int question1;
        public int question2;
        public int question3;

        public string answer1;
        public string answer2;
        public string answer3;

        public override string ToString()
        {
            return title.ToString() + "\n" +
                fName.ToString() + "\n" +
                mName.ToString() + "\n" +
                lName.ToString() + "\n" +
                suffix.ToString() + "\n" +
                addy1.ToString() + "\n" +
                addy2.ToString() + "\n" +
                addy3.ToString() + "\n" +
                city.ToString() + "\n" +
                state.ToString() + "\n" +
                zip.ToString() + "\n" +
                email.ToString() + "\n" +
                phone1.ToString() + "\n" +
                phone2.ToString() + "\n" +
                user.ToString() + "\n" +
                pass.ToString() + "\n" +
                question1.ToString() + "\n" +
                answer1.ToString() + "\n" +
                question2.ToString() + "\n" +
                answer2.ToString() + "\n" +
                question3.ToString() + "\n" +
                answer3.ToString() + "\n";
        }
    }
}
