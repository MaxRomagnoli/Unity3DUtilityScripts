using UnityEngine;
using UnityEngine.Events;

public class Triggerator : MonoBehaviour
{
    [SerializeField] UnityEvent eventsOnTriggerEnter;
    [SerializeField] UnityEvent eventsOnTriggerExit;

    private void OnTriggerEnter(Collider collision)
    {
        eventsOnTriggerEnter.Invoke();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        eventsOnTriggerEnter.Invoke();
    }

    private void OnTriggerExit(Collider collision)
    {
        eventsOnTriggerExit.Invoke();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        eventsOnTriggerExit.Invoke();
    }
}
