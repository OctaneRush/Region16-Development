using System;

namespace domain.AttendeeAggregate;

public interface IAttendeeHelper
{
    public string ValidateFirstName(string fname);
    public string ValidateLastName(string lname);
    // public string ValidateMailAddress(string maddress);
    // public string ValidatePrimaryPhoneNumber(string primaryphone);
    public string ValidateEmailAddress(string email);
    // public string ValidateGrade(string grade);
    // public string ValidateGender(string gender);
    // public string ValidateEthnicity(string ethnicity);
}

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

    public Attendee CreateAttendee(string fname, string lname, string email)
    {
        Attendee attendee = new Attendee()
        {
            FirstName = GetFirstName(fname),
            LastName = GetLastName(lname),
            EmailAddress = GetEmailAddress(email)
        };
    }
}


