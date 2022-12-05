using System;
using NUnit.Framework;
using Shared.Model;

namespace TestProject1;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void Test1()
    {
        User user= new User();
        user.Id = 10;
        
    }
}