using UnityEngine;

public class SwitchGrabbable : OVRGrabbable
{
    public SwitchControl switchControl;

    public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
    {
        base.GrabBegin(hand, grabPoint);

        // Active la logique du switch
        if (switchControl != null)
            switchControl.Toggle();

        // On relâche immédiatement pour éviter que le switch parte dans la main
        if (grabbedBy != null)
            grabbedBy.ForceRelease(this);
    }
}
