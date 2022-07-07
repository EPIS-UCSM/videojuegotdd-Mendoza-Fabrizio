using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using Heroes;
using System;
using UnityEngine.TestTools;
namespace Tests{
    public class NewTestScript
{
    [SetUp]
    public void SetUp(){
        Debug.Log("Set Up");
    }
    [TearDown]
    public void TearDown(){
        Debug.Log("Tear Down");
    }
    [TestCase(10,20,30)]
    [TestCase(30,20,50)]
    [TestCase(0,0,0)]
    public void Sum_ParameterArePossitives_ReturnsTheCorrectResult(int value1,int value2,int expected){
        var calculator = new Calculator(); 
        var result = calculator.Sum(10,20);
        Assert.AreEqual(expected,result,"El resultado no es el esperado");
    }
    // A Test behaves as an ordinary method
    [TestCase(-10,20)]
    [TestCase(20,-10)]
    public void Sum_AnyParameterisNegative_ThrowsException(int value1, int value2){
        var calculator = new Calculator();
        var result = calculator.Sum(10,20);
        Assert.Throws<Exception>(() => {
            var result = calculator.Sum(-10,20);
        });
    }
    [Test]
    public void EditModeTestsSimplePasses()
    {
        Debug.Log("1");
        var a = 10;
        var b = 20;
        var result = a+b;
        Assert.AreEqual(30,result);
        Assert.IsTrue(result == 30);
        // Use the Assert class to test conditions
    }
    [Test]
    public void EditModeTestsSimplePasses1()
    {
        Debug.Log("2");
        // Use the Assert class to test conditions
    }
}

}
