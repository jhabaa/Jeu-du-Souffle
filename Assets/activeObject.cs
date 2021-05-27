using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.Extras;

public class activeObject : SteamVR_LaserPointer
{
    public ballanimation animation;
    public override void OnPointerClick(PointerEventArgs e)
    {
        base.OnPointerClick(e);
        if (e.target.gameObject.tag =="box")
        {
            animation.enabled = true;
            e.target.gameObject.SetActive(true);
        }
    }
}
