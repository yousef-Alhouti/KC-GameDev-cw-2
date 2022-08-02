using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Hero's Identity
    string HeroName = "Ahmed";
    float HeroAge = 23;
    float HeroHight = 1.7F;
    string HeroPower = "Flight";

    // Villan's Identity
    string VillainName = "Hamad";
    float VillainAge = 25F;
    float VillainHight = 1.9F;
    string VillainPower = "None";

    // Age Difference
    int AgeDifference = 2;

    // Added Hight
    float TrueHeroHight = 2.4F;
    
    void Start()
    {
        // Hero's Short Story
        print ("The hero's name is " + HeroName);
        print (" and his age is " + HeroAge);
        print (" He is a hight of " + HeroHight); 
        print (" and with the added 0.5m he has a hight of " + TrueHeroHight); 
        print (" and he has the power of " + HeroPower);
        print ("                                     ");
        print ("The villain's name is " + VillainName);
        print ("and his age is " + VillainAge);
        print ("he has the hight of " + VillainHight);
        print ("the difference between the villain's age and the hero's age is " + AgeDifference);
        print ("the villain's power is " + VillainPower);

        
    }

   
}
