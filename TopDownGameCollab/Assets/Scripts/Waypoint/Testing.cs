using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    [Space(2, order = 0)]
    [Header("Header with some space around it", order = 1)]
    [Space(10, order = 2)]

    public string playerName = "Unnamed";
}
