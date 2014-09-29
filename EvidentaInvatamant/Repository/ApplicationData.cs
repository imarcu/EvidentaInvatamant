using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EvidentaInvatamant
{
    [Serializable]
    public class ApplicationData:ISerializable

    {
        IUserRepository users;
        ICareerRepository careers;
        ISubjectRepository subjects;
        ISkillRepository skills;
        IUserInterface view;

        public IUserInterface UserInterface
        {
            get { return view; }
            set { this.view = value;  }
        }
        public IUserRepository UserRepository
        {
            get{return users;}
            set {this.users = value;}
        }
        public ICareerRepository CareerRepository
        {
            get {return careers;}
            set {this.careers = value;}
        }
        public ISubjectRepository SubjectRepository
        {
            get {return subjects;}
            set {this.subjects = value;}
        }
        public ISkillRepository SkillRepository
        {
            get {return skills;}
            set {this.skills = value;}
        }
        public ApplicationData()
        {

        }
        public void EnableUsers()
        {
            users.SetView(view);
        }
        protected ApplicationData(SerializationInfo info, StreamingContext ctxt)
        {
            this.users = (IUserRepository)info.GetValue("usersrepository", typeof(IUserRepository));
            this.careers = (ICareerRepository)info.GetValue("careersrepository", typeof(ICareerRepository));
            this.subjects = (ISubjectRepository)info.GetValue("subjectrepository", typeof(ISubjectRepository));
            this.skills = (ISkillRepository)info.GetValue("skillrepository", typeof(ISkillRepository));
        }


        public void SaveData()
        {
            IFormatter formatter;
            Stream stream;
            stream = File.Open("ApplicationData.txt", FileMode.Create);
            formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Close();
        }
        public ApplicationData LoadData()
        {
            ApplicationData aux;
            IFormatter formatter;
            Stream stream;
            stream = File.Open("ApplicationData.txt", FileMode.Open);
            formatter = new BinaryFormatter();

            aux = (ApplicationData)formatter.Deserialize(stream);
            stream.Close();
            return aux;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("usersrepository", users);
            info.AddValue("careersrepository", careers);
            info.AddValue("subjectrepository", subjects);
            info.AddValue("skillrepository", skills);
        }
    }
}
