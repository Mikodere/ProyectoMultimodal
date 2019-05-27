using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TogglePhysics : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour trackableBehaviour;
    public UIManager manager;

    // Start is called before the first frame update
    void Start()
    {
        trackableBehaviour = GetComponent<TrackableBehaviour>();
        if (trackableBehaviour)
            trackableBehaviour.RegisterTrackableEventHandler(this);

        //Time.timeScale = 0;
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus,
                                        TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            Time.timeScale = 1;
            Debug.Log("Se ve!");
            manager.HidePaused();
        }
        else
        {
            Time.timeScale = 0;
            Debug.Log("No se ve!");
            manager.ShowPaused();
        }
    }
}
