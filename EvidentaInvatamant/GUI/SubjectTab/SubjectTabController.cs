using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    class SubjectTabController:ISubjectTabController
    {
        ISubjectTabView subjectTabView;
        ISubjectRepository subjectRepository;
        ISubjectsDetailsView subjectDetailsView;
        ISubject subject;

        public SubjectTabController(ISubjectTabView subjectTabView, ISubjectRepository subjectRepository, ISubjectsDetailsView subjectDetailsView)
        {
            this.subjectTabView = subjectTabView;
            this.subjectRepository = subjectRepository;
            this.subjectDetailsView = subjectDetailsView;
            PopulateSubjectGrid();
        }

        private void PopulateSubjectGrid()
        {
            this.subjectTabView.ClearDataGrid();
            for (int i = 0; i < subjectRepository.GetSize(); i++)
            {
                subjectTabView.AddSubjectToTable(subjectRepository.GetAt(i));
            }
           
        }
        public void AddNewSubject_Click()
        {
            this.subject = new Subject();
            
            subjectDetailsView.Show(this.subject);
            this.subjectRepository.Add(this.subject);
            this.subjectTabView.RefreshDataGrid();
        }


        public void RebuildDataGrid()
        {
            PopulateSubjectGrid();
        }


        public void RemoveSubjectButton_Click()
        {
            subjectRepository.Remove(subjectTabView.GetSelectedSubject());
            PopulateSubjectGrid();

        }


        public void EditButton_Click()
        {
            subjectDetailsView.EditSubject(this.subjectTabView.GetSelectedSubject());
        }
    }
}
