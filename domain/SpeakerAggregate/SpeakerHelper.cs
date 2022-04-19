<<<<<<< HEAD
using System;

namespace domain.SpeakerAggregate;
=======
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace domain.SpeakerAggregate;

public class SpeakerHelper
{
    public bool ValidateFirstName(string fname)
    {
        if (fname == null)
        {
            return false;
        }
        return true;
    }

    public bool ValidateLastName(string lname)
    {
        if (lname == null)
        {
            return false;
        }
        return true;
    }

    public bool ValidateMailAddress(string address)
    {
        if (address == null)
        {
            return false;
        }
        return true;
    }

    public bool ValidatePrimaryPhoneNumber(string phone)
    {
        if (phone.Length != 10)
        {
            return false;
        }
        return true;
    }

    public bool ValidateEmailAddress(string email)
    {
        if (email.Contains("@"))
        {
            return true;
        }
        return false;
    }

    public bool ValidateJobTitle(string title)
    {
        if (title == null)
        {
            return false;
        }
        return true;
    }

    public bool ValidateSessionTitle(string sessionTitle)
    {
        if (sessionTitle == null)
        {
            return false;
        }
        return true;
    }

    public bool ValidateSessionDescription(string sessionDescr)
    {
        if (sessionDescr == null)
        {
            return false;
        }
        return true;
    }
}
>>>>>>> 39874875da3ca9e65e6cc4048905cb3923e1af8f
