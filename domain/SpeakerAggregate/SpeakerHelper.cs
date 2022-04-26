using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using domain.SessionAggregate;

namespace domain.SpeakerAggregate;

public class SpeakerHelper
{
    public bool ValidateFirstName(Speaker speaker)
    {
        if (speaker.FirstName == null)
        {
            return false;
        }
        return true;
    }

    public bool ValidateLastName(Speaker speaker)
    {
        if (speaker.LastName == null)
        {
            return false;
        }
        return true;
    }

    public bool ValidateMailAddress(Speaker speaker)
    {
        if (speaker.MailAddress == null)
        {
            return false;
        }
        return true;
    }

    public bool ValidatePrimaryPhoneNumber(Speaker speaker)
    {
        if (speaker.PrimaryPhoneNumber.Length != 10)
        {
            return false;
        }
        return true;
    }

    public bool ValidateEmailAddress(Speaker speaker)
    {
        if (speaker.EmailAddress.Contains("@"))
        {
            return true;
        }
        return false;
    }

    public bool ValidateJobTitle(Speaker speaker)
    {
        if (speaker.JobTitle == null)
        {
            return false;
        }
        return true;
    }

    public bool ValidateSessionTitle(Session session)
    {
        if (session.SessionTitle == null)
        {
            return false;
        }
        return true;
    }

    public bool ValidateSessionDescription(Session session)
    {
        if (session.SessionDescription == null)
        {
            return false;
        }
        return true;
    }
}