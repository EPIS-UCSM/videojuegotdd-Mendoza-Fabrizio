using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace Point{
public class PointCalculator 
{
    
    public int CalculatePoints(int killedEnemies,int killedVillagers,int multiplicator){
        if(killedEnemies < 0 ){
            throw new ArgumentOutOfRangeException("killedEnemies must be positive");
        }
        if(killedVillagers < 0 ){
            throw new ArgumentOutOfRangeException("killedVillagers must be positive");
        }
        if(multiplicator <= 0){
            throw new ArgumentOutOfRangeException("multiplicador must be positive");
        }
        var points = 0;
        points += killedEnemies*100;
        points += Mathf.FloorToInt(killedEnemies/10)*500; 
        points -= killedVillagers*100;
        
        if(killedVillagers >=10){
            multiplicator = 1;
        }
        points *= multiplicator;
        return Mathf.Max(points,0);
    }
}
}