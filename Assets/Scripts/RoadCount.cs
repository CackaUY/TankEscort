using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoadCount : MonoBehaviour
{
    private Slider _slider;
    private void Start()
    {
        _slider = GetComponent<Slider>();
    }
    void Update()
    {
        _slider.value += 0.01f * Time.deltaTime;  
    }
}
