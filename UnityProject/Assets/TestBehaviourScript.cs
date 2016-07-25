using UnityEngine;
using System.Collections;

public class TestBehaviourScript : MonoBehaviour 
{
    [Range(0,2)]
    public int timeScale = 1;

    [DisableEdit]
    public float time;

    [SerializeField][DisableEdit][Tooltip("time += Time.deltaTime")]
    private string tip = "<--- Stay with 'Tip' !";

    void Start()
    {
        
    }

    void Update()
    {
        time += Time.deltaTime;

        if (Time.timeScale != timeScale)
        {
            Time.timeScale = timeScale;
        }


    }
}
