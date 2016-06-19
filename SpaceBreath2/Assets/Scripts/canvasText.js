#pragma strict

var text:UnityEngine.UI.Text;
var player:GameObject;
var breathRate:int;

function Start () 
{
    //var measureBreath = player.GetComponent(MeasureBreath);
}

function Awake () 
{
  //  var measureBreath = player.GetComponent(MeasureBreath);
//    breathCount = measureBreath.breathCount;
    //Debug.Log(breathCount);
}

function Update () 
{
    var measureBreath = player.GetComponent(MeasureBreath);
    breathRate = measureBreath.breathRate;

    if(breathRate>1.0833 || breathRate<0.91667)
    {
        text.text="The stars are mesmerizing! \n Are they not? \n But get back to breathing the right way and enjoy the serene space!";
    }
    else
    {
        text.text="";
    }
 
}