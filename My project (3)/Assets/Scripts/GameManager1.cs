using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    private bool isCoroutineEnded = false;
    [SerializeField] GameObject loadingSubScene;
    [SerializeField] GameObject gameButtons;
    // Start is called before the first frame update
    void Start()
    {
        loadingSubScene.gameObject.SetActive(true);
        StartCoroutine(LoadingCoroutine());
    }
    private void Update()
    {
        if(isCoroutineEnded==true)
        {
            loadingSubScene.gameObject.SetActive(false);
            gameButtons.gameObject.SetActive(true);
        }
        
    }

    public IEnumerator LoadingCoroutine()
    {
        Debug.Log("Inizio Coroutine");
        yield return new WaitForSeconds(3);
        isCoroutineEnded = true;
        Debug.Log("Fine Coroutine");
    }

}
