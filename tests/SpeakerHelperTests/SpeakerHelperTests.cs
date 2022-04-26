using Xunit;
using Xunit.Abstractions;
using domain;
using domain.SpeakerAggregate;
using domain.SessionAggregate;
using webapp;
using Microsoft.EntityFrameworkCore;

namespace tests.SpeakerHelperTests;

public class SpeakerHelperTests
{
    public  static SpeakerHelper speakerHelper = new SpeakerHelper();
    public static Speaker testSpeaker = new Speaker();
    public static Session testSession = new Session();

    [Fact]
    public void TestSpeakerFirstNameIsValid()
    {
        //Arrange
        testSpeaker.FirstName = "Michael";

        //Act
        bool IsValid = speakerHelper.ValidateFirstName(testSpeaker);

        //Assert
        Assert.True(IsValid);

    }

     [Fact]
    public void TestSpeakerLastNameIsValid()
    {
        //Arrange
        testSpeaker.LastName = "Scott";

        //Act
        bool IsValid = speakerHelper.ValidateLastName(testSpeaker);

        //Assert
        Assert.True(IsValid);

    }

    [Fact]
    public void TestSpeakerMailAddressIsValid()
    {
        //Arrange
        testSpeaker.MailAddress = "1234 This Drive";

        //Act
        bool IsValid = speakerHelper.ValidateMailAddress(testSpeaker);

        //Assert
        Assert.True(IsValid);

    }

    [Fact]
    public void TestSpeakerPrimaryPhoneNumberIsValid()
    {
        //Arrange
        testSpeaker.PrimaryPhoneNumber = "1234567890";

        //Act
        bool IsValid = speakerHelper.ValidatePrimaryPhoneNumber(testSpeaker);

        //Assert
        Assert.True(IsValid);

    }

    [Fact]
    public void TestSpeakerEmailAddressIsValid()
    {
        //Arrange
        testSpeaker.EmailAddress = "thatperson@gmail.com";

        //Act
        bool IsValid = speakerHelper.ValidateEmailAddress(testSpeaker);

        //Assert
        Assert.True(IsValid);

    }

    [Fact]
    public void TestSpeakerJobTitleIsValid()
    {
        //Arrange
        testSpeaker.JobTitle = "Manager";

        //Act
        bool IsValid = speakerHelper.ValidateJobTitle(testSpeaker);

        //Assert
        Assert.True(IsValid);

    }

    [Fact]
    public void TestSpeakerSessionTitleIsValid()
    {
        //Arrange
        testSession.SessionTitle = "Biology";

        //Act
        bool IsValid = speakerHelper.ValidateSessionTitle(testSession);

        //Assert
        Assert.True(IsValid);

    }

    [Fact]
    public void TestSpeakerSessionDescriptionIsValid()
    {
        //Arrange
        testSession.SessionDescription = "In this session, we will talk about biology.";

        //Act
        bool IsValid = speakerHelper.ValidateSessionDescription(testSession);

        //Assert
        Assert.True(IsValid);

    }
}