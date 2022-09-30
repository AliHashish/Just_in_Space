using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public PlayerVars playerHealth;
    public Image fillImage;
    private Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value <= slider.minValue)    // byetfy el fill image lama el health yewsal 0
        {
            fillImage.enabled = false;
        }
        else
        {
            fillImage.enabled = true;
        }
        float fillValue = playerHealth.health / playerHealth.maxHealth;
        slider.value = fillValue;
    }
}
