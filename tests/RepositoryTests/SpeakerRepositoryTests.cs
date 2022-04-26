using Xunit;
using domain;
using domain.SpeakerAggregate;
using webapp;
using webapp.repository;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
using Xunit.Abstractions;
using Moq;

namespace tests.SpeakerRepositoryTests;

// public class SpeakerRepositoryTests : SpeakerRepository
// {
//     protected readonly ApplicationDbContext _context;
//     public SpeakerRepositoryTests(ApplicationDbContext context)
//     : base(context)
//     {
//         _context = context;
//     }

//     [Fact]
//     public async Task TestCanAddSpeakerToDatabase()
//     {
//         var options = new DbContextOptionsBuilder<ApplicationDbContext>()
//         .UseInMemoryDatabase(databaseName: "SpeakerDatabase")
//         .Options;

//         using (var context = new ApplicationDbContext(options))
//         {
//             context.Speakers.Add(new Speaker
//             {
//                 FirstName = "Michael",
//                 LastName = "Scott",
//                 MailAddress = "1234 That Dr",
//                 PrimaryPhoneNumber = "1234567890",
//                 EmailAddress = "thatperson@gmail.com",
//                 JobTitle = "Manager"
//             });

//             SpeakerRepository repo = new SpeakerRepository(context);
//             var speaker = await repo.GetSpeakerByEmail("thatperson@gmail.com");

//             Assert.Equal("thatperson@gmail.com", speaker.EmailAddress);
//         }
        // Arrange
    
        // Act
        
        // Assert
//     }
// }