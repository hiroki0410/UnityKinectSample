using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kinect = Windows.Kinect;

public class HandsPosition : MonoBehaviour
{

    public GameObject hand_right;
    public GameObject hand_left;
    [SerializeField]
    private GameObject hand_unity_right;
    [SerializeField]
    private GameObject hand_unity_left;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hand_right.transform.position = hand_unity_right.transform.position;
        hand_left.transform.position = hand_unity_left.transform.position;
    }
}
