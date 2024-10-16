using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField] private Image totalhealthBar;
    [SerializeField] private Image currenthealthBar;

    // Start is called before the first frame update
    void Start()
    {
        totalhealthBar.fillAmount =  3;
    }

    // Update is called once per frame
    void Update()
    {
        currenthealthBar.fillAmount = playerHealth.currentHealth / 3;
    }
}
