using System.ComponentModel.DataAnnotations;

namespace domain;

public class Speaker
{
    [Key]
    public int SpeakerId {get; set;}
    public string? FirstName {get; set;}
    public string? LastName {get; set;}
    public string? MailAddress {get; set;}
    public string? PrimaryPhoneNumber {get; set;}
    public string? EmailAddress {get; set;}
    public string? JobTitle {get; set;}
    public Session? Session {get; set;}
}