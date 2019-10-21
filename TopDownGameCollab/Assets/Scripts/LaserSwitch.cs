using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSwitch : MonoBehaviour
{
    [Tooltip("Drag the laser object from the hierarchy that this switch will destroy")]
    public GameObject lasers;
    float lastAxis;
    [Tooltip("What sprite do you want this to have when the lasers are active?")]
    public Sprite activeSprite;
    [Tooltip("What sprite do you want this to have when the lasers are deactivated?")]
    public Sprite deactivatedSprite;
    [Tooltip("Is this a switch you stand on?")]
    public bool standSwitch = false;
    private void Start()
    {
        GetComponent<SpriteRenderer>().sprite = activeSprite;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Flags>() != null)
        {
            if (!standSwitch && CheckAbility(collision.gameObject, "FlipSwitches") && Input.GetAxis("Ability").Equals(1) && lastAxis.Equals(0))
            {
                lasers.SetActive(!lasers.activeSelf);
                if(GetComponent<SpriteRenderer>().sprite == activeSprite)
                {
                    GetComponent<SpriteRenderer>().sprite = deactivatedSprite;
                }
                else
                {
                    GetComponent<SpriteRenderer>().sprite = activeSprite;
                }
            }
            if(standSwitch && CheckAbility(collision.gameObject, "StandOnSwitches"))
            {
                lasers.SetActive(false);
                GetComponent<SpriteRenderer>().sprite = deactivatedSprite;
            }
        }
        lastAxis = Input.GetAxis("Ability");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Flags>() != null)
        {
            if (standSwitch && CheckAbility(collision.gameObject, "StandOnSwitches"))
            {
                lasers.SetActive(true);
                GetComponent<SpriteRenderer>().sprite = activeSprite;
            }
        }
    }
    public bool CheckAbility(GameObject obj, string ability)
    {
        
        for(int i = 0; i < obj.GetComponent<Flags>().abilities.Length; i++)
        {
            if (obj.GetComponent<Flags>().abilities[i].ToString().Equals(ability))
            {
                return true;
            }
        }
        return false;
    }
    
}
