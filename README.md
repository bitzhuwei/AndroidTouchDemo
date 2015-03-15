# AndroidTouchDemo
演示Input.touchs的各项字段
<p style="text-align: center;"><span style="font-size: 16pt;"><strong>[Unity3D]做个小Demo学习<span style="color: #2b91af;"><span style="background-color: white;">Input<span style="color: black;">.touches</span></span> </span></strong></span></p>
<p>学不如做，下面用一个简单的Demo展示的<span style="color: #2b91af;"><span style="font-family: Lucida Console; font-size: 12pt; background-color: white;">Input<span style="color: black;">.touches</span></span>各项字段，有图有真相。</span></p>
<p style="text-align: center; background: white;"><a href="C:\Users\DELL\AppData\Local\Temp\WindowsLiveWriter1286139640\supfiles6DCC6E4D\image[2].png"><img src="http://images.cnitblog.com/blog/383191/201503/151850257612439.png" alt="" border="0" /></a></p>
<p>本项目已发布到Github，地址在（<a href="https://github.com/bitzhuwei/AndroidTouchDemo" target="_blank">https://github.com/bitzhuwei/AndroidTouchDemo</a>）。</p>
<h1>制作Demo</h1>
<p>很简单，只需拉一个Text，然后添加一个脚本。</p>
<p style="text-align: center; background: white;"><a href="C:\Users\DELL\AppData\Local\Temp\WindowsLiveWriter1286139640\supfiles6DCC6E4D\image[5].png"><img src="http://images.cnitblog.com/blog/383191/201503/151850305894312.png" alt="" border="0" /></a></p>
<p>脚本如下。</p>
<div>
<div class="cnblogs_code">
<pre><span style="color: #008080;"> 1</span> <span style="color: #0000ff;">using</span><span style="color: #000000;"> UnityEngine;
</span><span style="color: #008080;"> 2</span> <span style="color: #0000ff;">using</span><span style="color: #000000;"> System.Collections;
</span><span style="color: #008080;"> 3</span> 
<span style="color: #008080;"> 4</span> <span style="color: #0000ff;">public</span> <span style="color: #0000ff;">class</span><span style="color: #000000;"> DisplayTouchInfo : MonoBehaviour {
</span><span style="color: #008080;"> 5</span> 
<span style="color: #008080;"> 6</span>     <span style="color: #0000ff;">private</span><span style="color: #000000;"> UnityEngine.UI.Text lblInfo;
</span><span style="color: #008080;"> 7</span> 
<span style="color: #008080;"> 8</span>     <span style="color: #008000;">//</span><span style="color: #008000;"> Use this for initialization</span>
<span style="color: #008080;"> 9</span>     <span style="color: #0000ff;">void</span><span style="color: #000000;"> Start () {
</span><span style="color: #008080;">10</span>         <span style="color: #0000ff;">this</span>.lblInfo = <span style="color: #0000ff;">this</span>.GetComponent&lt;UnityEngine.UI.Text&gt;<span style="color: #000000;">();
</span><span style="color: #008080;">11</span> <span style="color: #000000;">    }
</span><span style="color: #008080;">12</span>     
<span style="color: #008080;">13</span>     <span style="color: #008000;">//</span><span style="color: #008000;"> Update is called once per frame</span>
<span style="color: #008080;">14</span>     <span style="color: #0000ff;">void</span><span style="color: #000000;"> Update () {
</span><span style="color: #008080;">15</span>         <span style="color: #0000ff;">var</span> builder = <span style="color: #0000ff;">new</span><span style="color: #000000;"> System.Text.StringBuilder();
</span><span style="color: #008080;">16</span>         builder.AppendLine(<span style="color: #800000;">"</span><span style="color: #800000;">touch info:</span><span style="color: #800000;">"</span><span style="color: #000000;">);
</span><span style="color: #008080;">17</span>         builder.AppendLine(<span style="color: #0000ff;">string</span>.Format(<span style="color: #800000;">"</span><span style="color: #800000;">deltaTime:{0}</span><span style="color: #800000;">"</span><span style="color: #000000;">, Time.deltaTime));
</span><span style="color: #008080;">18</span>         builder.AppendLine(<span style="color: #0000ff;">string</span>.Format(<span style="color: #800000;">"</span><span style="color: #800000;">touchCount:{0}</span><span style="color: #800000;">"</span><span style="color: #000000;">, Input.touchCount));
</span><span style="color: #008080;">19</span>         builder.AppendLine(<span style="color: #800000;">"</span><span style="color: #800000;">i, fingerId, position, rawPosition, deltaPosition, deltaTime, phase, tapCount</span><span style="color: #800000;">"</span><span style="color: #000000;">);
</span><span style="color: #008080;">20</span>         <span style="color: #0000ff;">for</span> (<span style="color: #0000ff;">int</span> i = <span style="color: #800080;">0</span>; i &lt; Input.touches.Length; i++<span style="color: #000000;">)
</span><span style="color: #008080;">21</span> <span style="color: #000000;">        {
</span><span style="color: #008080;">22</span>             <span style="color: #0000ff;">var</span> touch =<span style="color: #000000;"> Input.touches[i];
</span><span style="color: #008080;">23</span>             builder.AppendFormat(<span style="color: #800000;">"</span><span style="color: #800000;">[{0}]:{1},{2},{3},{4},{5},{6},{7}</span><span style="color: #800000;">"</span><span style="color: #000000;">, i, touch.fingerId, touch.position, touch.rawPosition, touch.deltaPosition, touch.deltaTime, touch.phase, touch.tapCount);
</span><span style="color: #008080;">24</span> <span style="color: #000000;">            builder.AppendLine();
</span><span style="color: #008080;">25</span> <span style="color: #000000;">        }
</span><span style="color: #008080;">26</span>         <span style="color: #0000ff;">this</span>.lblInfo.text =<span style="color: #000000;"> builder.ToString();
</span><span style="color: #008080;">27</span> <span style="color: #000000;">    }
</span><span style="color: #008080;">28</span> }</pre>
</div>
</div>
<h1>使用</h1>
<p>注意，必须发布到Android手机上才有效，PC貌似不搭理Input.touchs。</p>
