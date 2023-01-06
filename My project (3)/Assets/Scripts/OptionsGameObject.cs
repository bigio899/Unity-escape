using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsGameObject : MonoBehaviour
{
    [SerializeField] GameObject menuoptions;
    [SerializeField] GameObject menumain;
    public void OnClickOptionButton()
    {
        menumain.gameObject.SetActive(false);
        menuoptions.gameObject.SetActive(true);
    }
}
