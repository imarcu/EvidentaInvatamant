﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    [Serializable]
    public class UserRepository:IUserRepository
    {
        List<IUser> users;
        IUser invalidUser;

        public UserRepository(IUser invalidUser)
        {
            users = new List<IUser>();
            this.invalidUser = invalidUser;
            
        }     



        public void Add(IUser user)
        {
            users.Add(user);
        }

        public IUser Search(string name, string password)
        {
            foreach (IUser user in users)
            {
                if (user.MatchesCredentials(name, password))
                {
                    return user;
                }
            }
            return invalidUser;
            
        }


        public void SetView(IUserInterface userinterface)
        {
            foreach (IUser user in users)
            {
                user.SetView(userinterface);
            }
            invalidUser.SetView(userinterface);
        }
    }
}
