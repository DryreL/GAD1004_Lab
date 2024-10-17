using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventSystemChecker : MonoBehaviour
{
    // Use this for initialization
    void Awake()
    {
        // Use the new API: FindFirstObjectByType or FindAnyObjectByType
        if (UnityEngine.Object.FindAnyObjectByType<EventSystem>() == null)  // Faster check for any EventSystem
        {
            // If no EventSystem exists, create a new one
            GameObject obj = new GameObject("EventSystem");
            obj.AddComponent<EventSystem>();
            obj.AddComponent<StandaloneInputModule>();  // No need to set forceModuleActive anymore
        }
    }
}