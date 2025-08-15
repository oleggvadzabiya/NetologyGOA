using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTest : MonoBehaviour
{
    [SerializeField] string _testString = "Hello, World!";          
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(_testString);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
