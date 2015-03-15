# AndroidTouchDemo
演示Input.touchs的各项字段
[Unity3D]做个小Demo学习Input.touches

学不如做，下面用一个简单的Demo展示的Input.touches各项字段，有图有真相。



本项目已发布到Github，地址在（https://github.com/bitzhuwei/AndroidTouchDemo）。

制作Demo

很简单，只需拉一个Text，然后添加一个脚本。



脚本如下。

 1 using UnityEngine;
 2 using System.Collections;
 3 
 4 public class DisplayTouchInfo : MonoBehaviour {
 5 
 6     private UnityEngine.UI.Text lblInfo;
 7 
 8     // Use this for initialization
 9     void Start () {
10         this.lblInfo = this.GetComponent<UnityEngine.UI.Text>();
11     }
12     
13     // Update is called once per frame
14     void Update () {
15         var builder = new System.Text.StringBuilder();
16         builder.AppendLine("touch info:");
17         builder.AppendLine(string.Format("deltaTime:{0}", Time.deltaTime));
18         builder.AppendLine(string.Format("touchCount:{0}", Input.touchCount));
19         builder.AppendLine("i, fingerId, position, rawPosition, deltaPosition, deltaTime, phase, tapCount");
20         for (int i = 0; i < Input.touches.Length; i++)
21         {
22             var touch = Input.touches[i];
23             builder.AppendFormat("[{0}]:{1},{2},{3},{4},{5},{6},{7}", i, touch.fingerId, touch.position, touch.rawPosition, touch.deltaPosition, touch.deltaTime, touch.phase, touch.tapCount);
24             builder.AppendLine();
25         }
26         this.lblInfo.text = builder.ToString();
27     }
28 }
使用

注意，必须发布到Android手机上才有效，PC貌似不搭理Input.touchs。
