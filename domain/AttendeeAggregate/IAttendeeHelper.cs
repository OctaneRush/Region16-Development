using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace domain.AttendeeAggregate;

    public class MyAttendeeHelper
    {
        public string GetFirstName(string fname)
    {
        // TODO: validation steps
        if(fname.Length == 0){
            throw new ArgumentException();
        }
        return fname;
    }
    public string GetLastName(string lname)
    {
        // TODO: validation steps
        if(lname.Length == 0){
            throw new ArgumentException();
        }
        return lname;
    }

    public string GetEmailAddress(string email)
    {
        // TODO: validation steps
        if(email.Length == 0){
            throw new ArgumentException();
        }
        return email;
    }
}