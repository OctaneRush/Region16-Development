using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace webapp.Models;

public class Session
{
    [Key]
    public int SessionId {get; set;}
    public string? SessionTitle {get; set;}
    public string? SessionDescription {get; set;}
    public List<Speaker>? Speakers {get; set;}
    //public List<Attendee>? Attendees {get; set;}
}