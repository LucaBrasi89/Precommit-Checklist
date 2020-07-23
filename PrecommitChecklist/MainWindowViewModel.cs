using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecommitChecklist
{
    public class MainWindowViewModel
    {
         public List<ChecklistItemModel> ChecklistItems
        {
            get
            {
                return new List<ChecklistItemModel>
                {
                    new ChecklistItemModel("Does all project in solution compile?", true),
                    new ChecklistItemModel("Does UI run?", true),
                    new ChecklistItemModel("Does App work correct?", true),
                    new ChecklistItemModel("Have you double checked that only relevant files were added?", true),
                    new ChecklistItemModel("Does commit comments include TFS task ID?", true),
                    new ChecklistItemModel("Have you added \"Build X.Y.Z\" text in commit in the case" +
                    "of exteranl release?", true),
                    new ChecklistItemModel("Does header have right version number?", true)
                };
            }
        }
    }



}
