using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsGameObject : MonoBehaviour
{
    [SerializeField] GameObject menuoptions;
    [SerializeField] GameObject buttons;
    public void OnClickOptionButton()
    {
        buttons.gameObject.SetActive(false);
        menuoptions.gameObject.SetActive(true);
    }
}
