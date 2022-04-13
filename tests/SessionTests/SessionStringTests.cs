using Xunit;
using domain;
using Xunit.Abstractions;

namespace tests.SessionTests;

public class SessionStringTest
{
    //Check whether a string input matches existing string.
    [Fact]
    public void TestStringInputIsEqual()
    {
        //Arrange
        string mockTitle = "Physics";

        //Act
        Session mockSession = new Session();
        mockSession.SessionTitle = "Physics";

        //Assert
        Assert.Equal(mockSession.SessionTitle, mockTitle);
    }
}

public class SessionDescriptionTest1
{
    [Fact]
    public void TestDescriptionEqual()
    {
        string mockDescription = null;

        Session mockSession = new Session();
        mockSession.SessionDescription = null;

        Assert.Equal(mockSession.SessionDescription, mockDescription);
    }
}

public class test3 
{
    [Fact]
    public void test3a()
    {
        //make a new mock session
        //make a new mock speaker
        //get speakerid???

        //I think the ISpeakerHelper is important here for a SpeakerID test
    }
}