using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    [SerializeField] Stat current;
    [SerializeField] Stat max;
    [SerializeField] Image bar;

    // Update is called once per frame
    void Update()
    {
        bar.fillAmount = (float)current.amount/(float)max.amount;
    }
}
