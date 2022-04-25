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
}