using Xunit;
using Xunit.Abstractions;
using domain;
using domain.SpeakerAggregate;
using webapp;
using Microsoft.EntityFrameworkCore;

namespace tests.SpeakerHelperTests;

public class SpeakerHelperTests
{
    public  static SpeakerHelper speakerHelper = new SpeakerHelper();

    [Fact]
    public void TestSpeakerFirstNameIsValid()
    {
        //Arrange
        string fname = "Michael";

        //Act
        bool IsValid = speakerHelper.ValidateFirstName(fname);

        //Assert
        Assert.True(IsValid);

    }

     [Fact]
    public void TestSpeakerLastNameIsValid()
    {
        //Arrange
        string lname = "Scott";

        //Act
        bool IsValid = speakerHelper.ValidateLastName(lname);

        //Assert
        Assert.True(IsValid);

    }

    [Fact]
    public void TestSpeakerMailAddressIsValid()
    {
        //Arrange
        string address = "1234 This Drive";

        //Act
        bool IsValid = speakerHelper.ValidateMailAddress(address);

        //Assert
        Assert.True(IsValid);

    }

    [Fact]
    public void TestSpeakerPrimaryPhoneNumberIsValid()
    {
        //Arrange
        string phone = "1234567890";

        //Act
        bool IsValid = speakerHelper.ValidatePrimaryPhoneNumber(phone);

        //Assert
        Assert.True(IsValid);

    }

    [Fact]
    public void TestSpeakerEmailAddressIsValid()
    {
        //Arrange
        string email = "thatperson@gmail.com";

        //Act
        bool IsValid = speakerHelper.ValidateEmailAddress(email);

        //Assert
        Assert.True(IsValid);

    }

    [Fact]
    public void TestSpeakerJobTitleIsValid()
    {
        //Arrange
        string title = "Manager";

        //Act
        bool IsValid = speakerHelper.ValidateJobTitle(title);

        //Assert
        Assert.True(IsValid);

    }

    [Fact]
    public void TestSpeakerSessionTitleIsValid()
    {
        //Arrange
        string sessionTitle = "Biology";

        //Act
        bool IsValid = speakerHelper.ValidateJobTitle(sessionTitle);

        //Assert
        Assert.True(IsValid);

    }

    [Fact]
    public void TestSpeakerSessionDescriptionIsValid()
    {
        //Arrange
        string sessionDescr = "In this session, we will talk about biology.";

        //Act
        bool IsValid = speakerHelper.ValidateSessionDescription(sessionDescr);

        //Assert
        Assert.True(IsValid);

    }
}