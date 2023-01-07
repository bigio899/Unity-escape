using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsGameObject : MonoBehaviour
{
    //declaration of the varfiable where is allocated the date of level's avancement.
    private int levelAvancement=1;
    //declaration gameobjects's variables 
    [SerializeField] GameObject optionsMenu;
    [SerializeField] GameObject mainMenu;
    //function that is performed when the player click the Option button. 
    public void OnClickOptionButton()
    {
        mainMenu.gameObject.SetActive(false);
        optionsMenu.gameObject.SetActive(true);
    }
    //function that is performed when the player click the Back To Menu button from the option setting.
    public void OnClickBackToMenu()
    {
        mainMenu.gameObject.SetActive(true);
        optionsMenu.gameObject.SetActive(false);
    }
    //function that is performed then the player click the Play button.
    public void ChangeSceneFromMenuToLevel()
    {
        SceneManager.LoadScene(levelAvancement);
    }
}
