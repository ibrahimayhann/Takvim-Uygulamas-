using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Takvim_Uygulaması.dao;
using Takvim_Uygulaması.enumaration;
using Takvim_Uygulaması.model;

namespace Takvim_Uygulaması.controller
{
    public class Controller
    {
        Repository repository;
        public Controller() 
        {
            repository = new Repository();
        }
        public user login(string username, string password)
        {
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                user result = repository.login(username, password);
                return result;

            }
            else
            {
                user user = new user();
                user.status = LoginStatus.eksikparametre;
                return user;
            }
        }
        public string checkmailaddres(string username)
        {
            return repository.checkmailaddres(username);
        }
        public LoginStatus changepassword(string username, string password)
        {
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                return repository.changepassword(username, password);
            }
            else
            {
                return LoginStatus.eksikparametre;
            }
        }
        public LoginStatus insertuser(user user) 
        {
            if(!string.IsNullOrEmpty(user.username)&& !string.IsNullOrEmpty(user.password) && !string.IsNullOrEmpty(user.tc) && !string.IsNullOrEmpty(user.name) && !string.IsNullOrEmpty(user.surname) )
            {
                LoginStatus sonuc = repository.insertuser(user);
                return sonuc;
            }
            else 
            {
                return LoginStatus.eksikparametre;
            }
            
        }
        public List<user> getallusers() 
        {
            return repository.getallusers();
        }
        public LoginStatus assignadmin(string tc) 
        {
            return repository.assignadmin(tc);
           
        }
        public LoginStatus removeusers(string tc) 
        {
          return repository.removeusers(tc);
             
        }
       
        public LoginStatus updateusers(user user) 
        {
            if (!string.IsNullOrEmpty(user.username) && !string.IsNullOrEmpty(user.password) && !string.IsNullOrEmpty(user.telefon) && !string.IsNullOrEmpty(user.email) && !string.IsNullOrEmpty(user.tc))
                return repository.updateusers(user);
            else
                return LoginStatus.eksikparametre;
        }
        public List<events> getevent(string username) 
        {
            return repository.getevent(username);
        }
        public LoginStatus updatevent(events events) 
        {
            if (!string.IsNullOrEmpty(events.username) && !string.IsNullOrEmpty(events.olay) )
                return repository.updatevent(events);
            else
                return LoginStatus.eksikparametre;
        }
        public LoginStatus removevent(int id,string username) 
        {
            
            return repository.removevent(id,username);
        }
        public LoginStatus insertevent(events events) 
        {
            if (!string.IsNullOrEmpty(events.username) && !string.IsNullOrEmpty(events.olay) )
            
                 return repository.insertevent(events);
                
            
            else
            
                return LoginStatus.eksikparametre;
            
        }


    }
    
}
