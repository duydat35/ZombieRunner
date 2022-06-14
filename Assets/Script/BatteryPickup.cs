using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float restoreAngle = 90f;
    [SerializeField] float addIntensity = 5f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.GetComponentInChildren<FlashLight>().RestoreLightAnlge(restoreAngle);
            other.GetComponentInChildren<FlashLight>().AddLightIntensity(addIntensity);
            Destroy(gameObject);
        }
    }
}
