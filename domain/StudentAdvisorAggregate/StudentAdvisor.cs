using System.ComponentModel.DataAnnotations;

namespace domain.StudentAdvisorAggregate;

public class StudentAdvisor
{
    [Key]
    public int StudentAdvisorId {get; set;}
}