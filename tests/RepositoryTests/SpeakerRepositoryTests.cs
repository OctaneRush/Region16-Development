using Xunit;
using domain;
using domain.SpeakerAggregate;
using webapp;
using webapp.repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
using Xunit.Abstractions;
using Moq;

namespace tests.SpeakerRepositoryTests;

public class SpeakerRepositoryTests
{
    //private DbContextOptions<ApplicationDbContext> dbContextOptions;

    // [Fact]
    // public async void Test_CanAddSpeakerToDatabase()
    // {
        // Arrange
        // var testSpeaker = new Speaker();

        // var context = new Mock<ApplicationDbContext>();
        // var dbSetMock = new Mock<DbSet<Speaker>>();
        // context.Setup(x => x.Set<Speaker>()).Returns(dbSetMock.Object);
        // dbSetMock.Setup(x => x.Add(It.IsAny<Speaker>())).Returns(testSpeaker);

        // Act
        // var repository = new SpeakerRepository(context.Object);
        // repository.AddSpeaker(testSpeaker);

        // Assert
    // }
}