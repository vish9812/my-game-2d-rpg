using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaExit : MonoBehaviour
{
    [SerializeField] private string sceneToLoad;
    [SerializeField] private string transitionName;
    [SerializeField] private AreaEnter theAreaEnter;

    // Start is called before the first frame update
    private void Start()
    {
        theAreaEnter.transitionName = transitionName;
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Player.instance.transitionName = transitionName;
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}