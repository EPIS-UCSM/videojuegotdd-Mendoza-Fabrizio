using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class NewTestScript
{
    // A Test behaves as an ordinary method
    /*[Test]
    public void NewTestScriptSimplePasses()
    {
        var pointCalculator = new PointCalculator();
        var expectedPoints = 3*100*1;
        var points = pointCalculator.CalculatePoints(3,0,1);
        Assert.That(points, Is.EqualTo(expectedPoints));
        // Use the Assert class to test conditions
    }*/

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator NewTestScriptWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
    /*[Test]
    public void recoger_Diamantes(){
        var diamantes = 3;
        var puntaje = 0;
        for(int i= 0;i<diamantes;i++){
            puntaje = puntaje + 5;
        }
        Assert.areEqual(15,puntaje);
    }*/
}