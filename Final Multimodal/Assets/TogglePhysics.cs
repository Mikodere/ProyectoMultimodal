using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TogglePhysics : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour trackableBehaviour;

    // Start is called before the first frame update
    void Start()
    {
        trackableBehaviour = GetComponent<TrackableBehaviour>();
        if (trackableBehaviour)
            trackableBehaviour.RegisterTrackableEventHandler(this);
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus,
                                        TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            Physics.autoSimulation = true;
        }
        else
        {
            Physics.autoSimulation = false;
        }
    }
}
