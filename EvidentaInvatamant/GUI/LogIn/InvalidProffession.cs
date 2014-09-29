using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    [Serializable]
    class InvalidProffession:IProffesion,ISerializable
    {
        IUserInterface mainMenuView;

        public InvalidProffession(IUserInterface mainMenuView)
        {
            this.mainMenuView = mainMenuView;
        }


        public void DisplayInterface()
        {
            mainMenuView.InvalidUserInterface();
        }
        protected InvalidProffession(SerializationInfo info, StreamingContext context)
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
