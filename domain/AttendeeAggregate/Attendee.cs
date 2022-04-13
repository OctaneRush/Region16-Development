using System.ComponentModel.DataAnnotations;
 
namespace domain.AttendeeAggregate;

public class Attendee
{
    [Key]
    public int AttendeeId {get; set;}
    public string? FirstName {get; set;}
    public string? LastName {get; set;}
    public string? MailAddress {get; set;}
    public string? PrimaryPhoneNumber {get; set;}
    public string? EmailAddress {get; set;}
    public int Grade {get; set;}
    public string? Gender {get; set;}
    public string? Ethnicity {get; set;}
    //public Session? FirstSession {get; set;}
    //public Session? SecondSession {get; set;}
}