using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using System;
using UnityEngine.TestTools;
using Point;
public class NewTestScript
{
    #region CalculatePoints
    // A Test behaves as an ordinary method
    [Test]
    [TestCase(3,0,1,300)]
    [TestCase(5,0,1,500)]
    [TestCase(5,0,2,1000)]
    [TestCase(5,1,2,800)]
    [TestCase(10,0,1,1000+500)]
    [TestCase(21,0,2,6200)]
    [TestCase(11,3,1,1300)]
    [TestCase(10,10,5,500)]
    [TestCase(0,0,1,0)]   
    [TestCase(0,0,1,0)]      
    public void CalculatePoints_PositiveValues_ReturnsCorrectPoints(int killedEnemies,int killedVillagers, int multiplicator,int expectedPoints)
    {
        var pointCalculator = new PointCalculator();
        var points = pointCalculator.CalculatePoints(killedEnemies,killedVillagers,multiplicator);
        Assert.That(points, Is.EqualTo(expectedPoints));
       // Use the Assert class to test conditions
    }
    
    [Test]
    public void CalculatePoints_NegativeKilledEnemies_ThrowsExceptions(){
        Assert.Throws<ArgumentOutOfRangeException>(() => new PointCalculator().CalculatePoints(-1,0,1));
    }
    [Test]
    public void CalculatePoints_NegativeKilledVillagers_ThrowsExceptions(){
        Assert.Throws<ArgumentOutOfRangeException>(() => new PointCalculator().CalculatePoints(0,-1,1));
    }
    public void CalculatePoints_NegativeOrNull0Multiplicator_ThrowsExceptions([Values(0,-1)] int multiplicator){
        Assert.Throws<ArgumentOutOfRangeException>(() => new PointCalculator().CalculatePoints(0,0,multiplicator));
    }
    #endregion
}
