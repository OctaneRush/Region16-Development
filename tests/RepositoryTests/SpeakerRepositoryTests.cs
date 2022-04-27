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

public class SpeakerRepositoryTests
{

//Testing format used from: https://www.thecodebuzz.com/unit-test-mock-entity-framework-core-repository/
    [Fact]
    public async Task TestCanGetAllSpeakersFromDatabase()
    {
        //Arrange
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
        .UseInMemoryDatabase(databaseName: "SpeakerDatabase")
        .Options;

        using (var context = new ApplicationDbContext(options))
        {
            context.Speakers.Add(new Speaker
            {
                FirstName = "Hello",
                LastName = "Hi",
                MailAddress = "1234 That Dr",
                PrimaryPhoneNumber = "1234567890",
                EmailAddress = "aperson@gmail.com",
                JobTitle = "Worker"
            });
            context.SaveChanges();
        }
        //Act
        //Assert
        using (var context = new ApplicationDbContext(options))
        {
                SpeakerRepository repository = new SpeakerRepository(context);
                var speaker = await repository.GetSpeakers();

                Assert.Equal(1, speaker.Count());
                context.Database.EnsureDeleted();
        }
    }

    [Fact]
    public async Task TestCanGetSpeakerByIdFromDatabase()
    {
        //Arrange
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
        .UseInMemoryDatabase(databaseName: "SpeakerDatabase")
        .Options;

        using (var context = new ApplicationDbContext(options))
        {
            context.Speakers.Add(new Speaker
            {
                SpeakerId = 1,
                FirstName = "Michael",
                LastName = "Scott",
                MailAddress = "1234 That Dr",
                PrimaryPhoneNumber = "1234567890",
                EmailAddress = "thatperson@gmail.com",
                JobTitle = "Manager"
            });

            context.Speakers.Add(new Speaker
            {
                SpeakerId = 2,
                FirstName = "Dwight",
                LastName = "Schrute",
                MailAddress = "1234 This Dr",
                PrimaryPhoneNumber = "9876543210",
                EmailAddress = "thisperson@gmail.com",
                JobTitle = "Assistant Manager"
            });
            context.SaveChanges();
        }
        //Act
        //Assert
        using (var context = new ApplicationDbContext(options))
        {
                SpeakerRepository repository = new SpeakerRepository(context);
                var speaker = await repository.GetSpeakerById(1);

                Assert.Equal(1, speaker.SpeakerId);
                context.Database.EnsureDeleted();
        } 
    }

    [Fact]
    public async Task TestCanGetSpeakerByEmailFromDatabase()
    {
        //Arrange
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
        .UseInMemoryDatabase(databaseName: "SpeakerDatabase")
        .Options;

        using (var context = new ApplicationDbContext(options))
        {
            context.Speakers.Add(new Speaker
            {
                SpeakerId = 1,
                FirstName = "Michael",
                LastName = "Scott",
                MailAddress = "1234 That Dr",
                PrimaryPhoneNumber = "1234567890",
                EmailAddress = "thatperson@gmail.com",
                JobTitle = "Manager"
            });

            context.Speakers.Add(new Speaker
            {
                SpeakerId = 2,
                FirstName = "Dwight",
                LastName = "Schrute",
                MailAddress = "1234 This Dr",
                PrimaryPhoneNumber = "9876543210",
                EmailAddress = "thisperson@gmail.com",
                JobTitle = "Assistant Manager"
            });
            context.SaveChanges();
        }
        //Act
        //Assert
        using (var context = new ApplicationDbContext(options))
        {
                SpeakerRepository repository = new SpeakerRepository(context);
                var speaker = await repository.GetSpeakerByEmail("thisperson@gmail.com");

                Assert.Equal("thisperson@gmail.com", speaker.EmailAddress);
                context.Database.EnsureDeleted();
        }   
    }

    [Fact]
    public async Task TestCanAddSpeakerToDatabase()
    {
        //Arrange
        Speaker testSpeaker = new Speaker()
        {
                SpeakerId = 1,
                FirstName = "Michael",
                LastName = "Scott",
                MailAddress = "1234 That Dr",
                PrimaryPhoneNumber = "1234567890",
                EmailAddress = "thatperson@gmail.com",
                JobTitle = "Manager"
        };

        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
        .UseInMemoryDatabase(databaseName: "SpeakerDatabase")
        .Options;

        //Act
        //Assert
        using (var context = new ApplicationDbContext(options))
        {
                SpeakerRepository repository = new SpeakerRepository(context);
                await repository.AddSpeaker(testSpeaker);
                var speaker = await repository.GetSpeakers();

                Assert.Equal(1, speaker.Count());
                context.Database.EnsureDeleted();
        }    
    }

    [Fact]
    public void TestCanDeleteSpeakerFromDatabase()
    {
        //Arrange
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
        .UseInMemoryDatabase(databaseName: "SpeakerDatabase")
        .Options;

        using (var context = new ApplicationDbContext(options))
        {
                Speaker testSpeaker1 = new Speaker()
                {
                        SpeakerId = 1,
                        FirstName = "Michael",
                        LastName = "Scott",
                        MailAddress = "1234 That Dr",
                        PrimaryPhoneNumber = "1234567890",
                        EmailAddress = "thatperson@gmail.com",
                        JobTitle = "Manager"
                };

                Speaker testSpeaker2 = new Speaker()
                {
                        SpeakerId = 2,
                        FirstName = "Dwight",
                        LastName = "Schrute",
                        MailAddress = "1234 This Dr",
                        PrimaryPhoneNumber = "9876543210",
                        EmailAddress = "thisperson@gmail.com",
                        JobTitle = "Assistant Manager"
                };
            context.Add(testSpeaker1);
            context.Add(testSpeaker2);

            //Act
            //Assert
            context.Remove(testSpeaker1);
            context.SaveChanges();

            Assert.Equal(1, context.Speakers.Count());
            context.Database.EnsureDeleted();
        }
    }

    [Fact]
    public void TestCanUpdateSpeakerInDatabase()
    {
        //Arrange
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
        .UseInMemoryDatabase(databaseName: "SpeakerDatabase")
        .Options;

        using (var context = new ApplicationDbContext(options))
        {
                Speaker testSpeaker1 = new Speaker()
                {
                        SpeakerId = 1,
                        FirstName = "Michael",
                        LastName = "Scott",
                        MailAddress = "1234 That Dr",
                        PrimaryPhoneNumber = "1234567890",
                        EmailAddress = "thatperson@gmail.com",
                        JobTitle = "Manager"
                };

                Speaker testSpeaker2 = new Speaker()
                {
                        SpeakerId = 2,
                        FirstName = "Dwight",
                        LastName = "Schrute",
                        MailAddress = "1234 This Dr",
                        PrimaryPhoneNumber = "9876543210",
                        EmailAddress = "thisperson@gmail.com",
                        JobTitle = "Assistant Manager"
                };
            context.Add(testSpeaker1);
            context.Add(testSpeaker2);
            context.SaveChanges();
            testSpeaker1.LastName = "Jordan";
            context.Update(testSpeaker1);

            Assert.Equal("Jordan", testSpeaker1.LastName);
            context.Database.EnsureDeleted();
        }
    }
}