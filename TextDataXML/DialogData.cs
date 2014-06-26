using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextDataXML
{
    public class DialogData
    {
        public int ID;
        public int NextID;//what text dialog should come next if any.else 0
        public int NPCStatus;//convert this later to an enum, for switching npc images
        public string Dialog;

        public DialogData() { }
        public DialogData(int _id, int _next, int _npc, string _dia)
        {
            ID = _id;
            NextID = _next;
            NPCStatus = _npc;
            Dialog = _dia;
        }
    }
}
