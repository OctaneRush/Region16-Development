using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using domain.SessionAggregate;

namespace domain.SpeakerAggregate;


public interface ISpeakerHelper
{
    bool ValidateFirstName(Speaker speaker);
    bool ValidateLastName(Speaker speaker);
    bool ValidateMailAddress(Speaker speaker);
    bool ValidatePrimaryPhoneNumber(Speaker speaker);
    bool ValidateEmailAddress(Speaker speaker);
    bool ValidateJobTitle(Speaker speaker);
    bool ValidateSpeaker(Speaker speaker);
}
public class SpeakerHelper : ISpeakerHelper
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

    public bool ValidateSpeaker(Speaker speaker)
    {
        var fname = ValidateFirstName(speaker);
        var lname = ValidateLastName(speaker);
        var address = ValidateMailAddress(speaker);
        var phone = ValidatePrimaryPhoneNumber(speaker);
        var email = ValidateEmailAddress(speaker);
        var title = ValidateJobTitle(speaker);

        if (fname && lname && address && phone && email && title == true)
        {
           return true;
        }
        else
        {
            return false;
        }
    }
}