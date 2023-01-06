using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsToMain : MonoBehaviour
{
    [SerializeField] GameObject menuoptions;
    [SerializeField] GameObject menumain;
    public void OnClickOptionButton()
    {
        menumain.gameObject.SetActive(true);
        menuoptions.gameObject.SetActive(false);
    }
}
