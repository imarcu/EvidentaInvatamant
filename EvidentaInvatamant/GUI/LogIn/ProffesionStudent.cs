using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    [Serializable]
    class ProffesionStudent:IProffesion,ISerializable
    {
        IUserInterface mainMenuView;

        public ProffesionStudent(IUserInterface view)
        {
            mainMenuView = view;
        }
        public void DisplayInterface()
        {
            mainMenuView.DisplayStudentInterface();
        }
        public override string ToString()
        {
            return "Student";
        }
        protected ProffesionStudent(SerializationInfo info, StreamingContext ctxt)
        {
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            
        }


        public void SetView(IUserInterface userInterface)
        {
            mainMenuView = userInterface;
        }
    }
}
