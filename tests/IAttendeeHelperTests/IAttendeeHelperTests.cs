using System.Reflection;
using Xunit;
using Xunit.Abstractions;
using domain;
using domain.AttendeeAggregate;
using webapp;
using Microsoft.EntityFrameworkCore;

namespace tests.IAttendeeHelperTests;

public class IAttendeeHelperTests 
{
    public static MyAttendeeHelper myAttendeeHelper = new MyAttendeeHelper();

    [Fact]
    public void TestAttendeeFirstNameIsValid()
    {

        //Arrange
        Attendee a = new Attendee();
        
        //Act
        a.FirstName = myAttendeeHelper.GetFirstName("Dude");

        //Assert
        Assert.Equal(a.FirstName, "Dude");

    }

    [Fact]
    public void TestAttendeeLastNameIsvalid()
    {
        //Arrange
        Attendee flattire = new Attendee();

        //Act
        flattire.LastName = myAttendeeHelper.GetLastName("Dude");

        //Assert
        Assert.Equal(flattire.LastName, "Barek");
    }

    [Fact]
    public void PrimaryPhoneNumberIsValid()
    {
        Attendee a = new Attendee();

        a.PrimaryPhoneNumber = myAttendeeHelper.GetPrimaryPhoneNumber("1111111111");

        Assert.Throws<Exception>(() =>
        {
            var phone = ("1111111111", a.PrimaryPhoneNumber);
        });
    }

    [Fact]
    public void EmailAddressIsValid()
    {
        Attendee a = new Attendee();

        a.EmailAddress = myAttendeeHelper.GetEmailAddress("h@gmail.com");

        Assert.Contains("@", a.EmailAddress);
    }

    [Fact]
    public void MailAddressIsValid()
    {
        Attendee a = new Attendee();

        a.MailAddress = myAttendeeHelper.GetMailAddress("200 Narrow St");

        Assert.Contains("St", a.MailAddress);
    }

    [Fact]
    public void GenderIsValid()
    {
        Attendee a = new Attendee();

        a.Gender = myAttendeeHelper.GetGender("Female");

        Assert.Equal(a.Gender, "Female");
    }
}