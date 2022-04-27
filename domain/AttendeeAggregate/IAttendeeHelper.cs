using System.ComponentModel.DataAnnotations;
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

    public string GetPrimaryPhoneNumber(string phone)
    {
        if(phone.Length < 10){
            throw new ArgumentException();
        }
        return phone;
    }

    public string GetMailAddress(string address)
    {
        // TODO Validation
        if(address.Length == 0){
            throw new ArgumentException();
        }
        return address;
    }

    public string GetGrade(string grade)
    {
        //Not all attendees have grade so grade optional
        if(grade.Length == 0){
            return grade;
        }
        return grade;
    }

    public string GetGender(string gender)
    {
        if(gender.Length == 0){
            throw new ArgumentException();
        }
        return gender;
    }

    public string Ethnicity(string ethnicity)
    {
        if(ethnicity.Length == 0){
            throw new ArgumentException();
        }
        return ethnicity;
    }
}