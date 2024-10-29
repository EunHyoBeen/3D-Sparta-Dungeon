using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerController Controller;

    // Start is called before the first frame update
    void Start()
    {
        CharacterManager.Instance.Player = this;
        Controller = GetComponent<PlayerController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
