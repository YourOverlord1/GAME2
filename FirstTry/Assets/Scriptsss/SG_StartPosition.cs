using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SG_StartPosition : MonoBehaviour
{
    public GameObject PlayerCharacter;

    void Awake()
    {
        GameObject START_POSTION = GameObject.FindGameObjectWithTag("START_POSITION") as GameObject;
        PlayerCharacter = GameObject.FindGameObjectWithTag("Player") as GameObject;

        if (START_POSTION != null && PlayerCharacter != null){
            PlayerCharacter.transform.position = START_POSTION.transform.position;
            PlayerCharacter.transform.rotation = START_POSTION.transform.rotation;
        }
    } 
}
