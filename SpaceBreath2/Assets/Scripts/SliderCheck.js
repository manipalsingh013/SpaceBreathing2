#pragma strict

var player:GameObject;
var breathRate:int;

var slider:UnityEngine.UI.Slider;

function Start () 
{
    //var measureBreath = player.GetComponent(MeasureBreath);
}

function Awake () 
{
    slider.value=12;
  //  var measureBreath = player.GetComponent(MeasureBreath);
//    breathCount = measureBreath.breathCount;
    //Debug.Log(breathCount);
}

function Update () 
{
    var measureBreath = player.GetComponent(MeasureBreath);
    breathRate = measureBreath.breathRate;

 //   breathRate = breathRate * 12.0;

    if(slider.value<=24.5 && breathRate>13)
    {
        slider.value += 0.2;
    }
    else if(breathRate<11 && slider.value>0)
    {
        slider.value -= 0.2;
    }
    else
    {
        slider.value = breathRate;
    }
 
}