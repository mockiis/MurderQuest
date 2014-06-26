using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextDataXML
{
    public class PeopleTextData
    {
        //make this into a list alter of possible works that work with this type of dialog
        public string Work;

        //the requirements for this type of dialog to be pasted into an npc
        public int Age;
        public int Intelligence;
        public int Strenght;
        public int Sanity;

        public List<DialogData> Dialogs= new List<DialogData>();


        public PeopleTextData() { }
        public PeopleTextData(string _work, int _age, int _int, int _str, int _san)
        {
            Work = _work;
            Age = _age;
            Intelligence = _int;
            Strenght = _str;
            Sanity = _san;
        }
    }
}
