using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    [Serializable]
    class ProffesionFacultyMember:IProffesion,ISerializable
    {
        IUserInterface mainMenuView;

        public ProffesionFacultyMember(IUserInterface view)
        {
            mainMenuView = view;
        }
        public void DisplayInterface()
        {
            mainMenuView.DisplayFacultyMemberInterface();
        }
        public override string ToString()
        {
            return "Faculty Member";
        }
        protected ProffesionFacultyMember(SerializationInfo info, StreamingContext ctxt)
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
