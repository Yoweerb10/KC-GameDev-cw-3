using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class day3 : MonoBehaviour
{   // Hero info
    string HeroName = " Akira Kurusu ";
    string HeroPower = " Persona: Arsene ";
    int HeroPL = 9000;

    // Villain info
    string VillainName = " Kamoshida ";
    string VillainPower = " Castle Owner ";
    int VillainPL = 8000;

    // speed, etc. 
    float playerSpeed;
    



    // Start is called before the first frame update
    void Start()
    {
        if (HeroPL > VillainPL)
        {

            print(HeroName + " is awakening his persona!!! ");

            print(" I am thou, thou art I! Thou hast acquired a new vow! PERSONA!! ");

            print(HeroName + " USES HIS POWER " + HeroPower + " TO DEFEAT THE " + VillainPower + VillainName);

            print(HeroPower + "'s power exceeds that of " + VillainPower);

            print(HeroName + "OVERWHELMS " + VillainName + " AND HAS ACHIEVED VICTORY! ");

        }



        else if (HeroPL == VillainPL)
        {

            print(" ONLY ONE MUST BECOME VICTORIOUS , FIGHT WITH ALL YOUR MIGHT!! ");

        }



         else
         {

            print(" You are too weak to fight the Castle Owner, Kamoshida. Come back when your PL is over 9000. ");


         }

        SetSpeed(2.5f);
        CompareSpeed(3.5f);
    }

    void SetSpeed(float Speed)
    {
        print(playerSpeed);

        playerSpeed = Speed;

        print(playerSpeed);

    }

    void CompareSpeed(float newspeed)
    {
        if (playerSpeed > newspeed)
        {
            print(" Player is faster before setting speed. ");
        }

        else if (playerSpeed == newspeed)
        {
            print(" Speed remains constant and unchanged. ");
        }

        else
        {
            print(" Player is +2.5 faster after setting speed. ");
        }

        
    }
}
