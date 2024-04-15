using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Training : MonoBehaviour
{
    [Header("Segments")]
    public GameObject ShoulderSegment;
    public GameObject ElbowSegment;
    public GameObject WristSegment;

    public GameObject ShoulderVisualisation;
    public GameObject ElbowVisualisation;
    public GameObject WristVisualisation;

    [Header("Materials")]
    public Material hidden;

    // Start is called before the first frame update
    void Start()
    {
        ShoulderSegment.GetComponent<MeshRenderer>().material = hidden;
        ElbowSegment.GetComponent<MeshRenderer>().material = hidden;
        WristSegment.GetComponent<MeshRenderer>().material = hidden;

        OVRPlugin.SetSimultaneousHandsAndControllersEnabled(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
