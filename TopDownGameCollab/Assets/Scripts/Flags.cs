using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flags : MonoBehaviour
{
    [System.Serializable]
    public enum Ability { None, FlipSwitches, StandOnSwitches, Jump, DestroyObjects };
    public Ability ability;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
