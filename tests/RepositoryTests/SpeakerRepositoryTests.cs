using Xunit;
using domain;
using domain.SpeakerAggregate;
using repository;
using webapp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
using Xunit.Abstractions;
using Moq;

namespace tests.SpeakerRepositoryTests;

public class SpeakerRepositoryTests
{
    private DbContextOptions<ApplicationDbContext> dbContextOptions;

    public SpeakerRepositoryTests()
    {
        
    }
    [Fact]
    public async void GetSpeakers_ReturnsAllSpeakersInDatabase()
    {
        // Arrange

        // Act

        // Assert
    }
}