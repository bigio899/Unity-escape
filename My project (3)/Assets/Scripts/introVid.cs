using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class introVid : MonoBehaviour
{
    //declaration variables.
    private bool isCoroutineEnded = false;
    //declaration gameobjects's variables 
    [SerializeField] GameObject loadingIntro;
    [SerializeField] GameObject gameButtons;

    // Start is called before the first frame update.
    void Start()
    {
        //set the loading subscene to active
        loadingIntro.gameObject.SetActive(true);
        //start the 3 seconds of coroutine, where there's the loading subscene sected to active. 
        StartCoroutine(LoadingCoroutine());
    }
    private void Update()
    {
        //condition that verify if the coroutine is ended.If the value is true,all the GameButtons of the menu will back active, and the loading sub-scene will disabilited.
        if (isCoroutineEnded == true)
        {
            loadingIntro.gameObject.SetActive(false);
            gameButtons.gameObject.SetActive(true);
        }

    }
    //function that return 3 seconds of waiting for the coroutine.
    public IEnumerator LoadingCoroutine()
    {
        Debug.Log("Inizio Coroutine");
        yield return new WaitForSeconds(4);
        isCoroutineEnded = true;
        Debug.Log("Fine Coroutine");
    }
}