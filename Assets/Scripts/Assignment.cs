using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Assignment : MonoBehaviour
{

    public int playerTotal;
    public float objectAngle;
    public string playerName;
    
    void Start()
    {
        _logPlayerTotal(playerTotal);
        _logDirection(objectAngle);
        _logStringReverse(playerName);
    }

    private void _logPlayerTotal(int total)
    {
        if(total > 21)
        {

            Debug.Log("Kaybettiniz.");

        }
        else if(total <= 21 && total > 16)
        {

            Debug.Log("Artık kart çekemezsiniz.");

        }
        else if(total > 0)//Hem toplamın 0 dan büyük olup olmadığını hem de 16'dan küçük olduğunun kontrolü yapılır.
        {

            Debug.Log("Kart çekebilirsiniz.");

        }
        else
        {

            Debug.LogError("Kart toplamı negatif olamaz!");

        }

    }

    private void _logDirection(float angle) {

        switch (angle)
        {
            
            case(0f):
                Debug.Log("Forward");
                break;

            case(90f):
                Debug.Log("Right");
                break;

            case(180f):
                Debug.Log("Back");
                break;

            case(270f):
                Debug.Log("Left");
                break;

            default:
                Debug.Log("No Direction");
                break;
        }

    }

    private void _logStringReverse(string str)
    {
        char[] strArr = str.ToCharArray();
        int i = strArr.Length - 1;

        while(i >= 0)
        {
            
            Debug.Log(strArr[i]);
            i--;

        }

    }

}
