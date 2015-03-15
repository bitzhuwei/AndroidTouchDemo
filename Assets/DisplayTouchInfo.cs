using UnityEngine;
using System.Collections;

public class DisplayTouchInfo : MonoBehaviour {

    private UnityEngine.UI.Text lblInfo;

	// Use this for initialization
	void Start () {
        this.lblInfo = this.GetComponent<UnityEngine.UI.Text>();
	}
	
	// Update is called once per frame
	void Update () {
        var builder = new System.Text.StringBuilder();
        builder.AppendLine("touch info:");
        builder.AppendLine(string.Format("deltaTime:{0}", Time.deltaTime));
        builder.AppendLine(string.Format("touchCount:{0}", Input.touchCount));
        builder.AppendLine("i, fingerId, position, rawPosition, deltaPosition, deltaTime, phase, tapCount");
        for (int i = 0; i < Input.touches.Length; i++)
        {
            var touch = Input.touches[i];
            builder.AppendFormat("[{0}]:{1},{2},{3},{4},{5},{6},{7}", i, touch.fingerId, touch.position, touch.rawPosition, touch.deltaPosition, touch.deltaTime, touch.phase, touch.tapCount);
            builder.AppendLine();
        }
        this.lblInfo.text = builder.ToString();
	}
}
