using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    [Serializable]
    class ProffesionAdmin:IProffesion,ISerializable

    {
        IUserInterface mainMenuView;

        public ProffesionAdmin(IUserInterface view)
        {
            mainMenuView = view;
        }
        public void DisplayInterface()
        {
            mainMenuView.DisplayAdminInterface();
        }
        public override string ToString()
        {
            return "Admin/Tester";
        }
         protected ProffesionAdmin(SerializationInfo info, StreamingContext context)
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
