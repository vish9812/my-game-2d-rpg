using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEnter : MonoBehaviour
{
    [SerializeField] private string transitionName;

    // Start is called before the first frame update
    private void Start()
    {
        if (Player.instance != null && transitionName == Player.instance.transitionName)
        {
            Player.instance.transform.position = transform.position;
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}