using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecommitChecklist
{
    public class ChecklistItemModel
    {
        string question;
        bool answer;

        public string Question { get => question; set => question = value; }
        public bool Answer { get => answer; set => answer = value; }

        public ChecklistItemModel(string question, bool answer)
        {
            this.question = question;
            this.answer = answer;
        }
    }
}
