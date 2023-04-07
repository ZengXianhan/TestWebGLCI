using System.Collections;
using System.Collections.Generic;
using HyperCasual.Runner;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class DemoTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void DemoTestSimplePasses()
    {
        Gate gate = new Gate();
        Assert.Pass();
        // Use the Assert class to test conditions
    }
}
