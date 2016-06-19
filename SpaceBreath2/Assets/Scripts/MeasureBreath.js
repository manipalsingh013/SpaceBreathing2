#pragma strict

var micController:GameObject;
public var breathCount=0;
var exhale;
var count;
public var breathRate:float;

var currentTime:float;
var previousTime:float;


var damageImage : UnityEngine.UI.Image;  
var flashSpeed : float= 5f;
var flashColour : Color = new Color(1f, 0f, 0f, 0.1f);

function Start () 
{
        micController.GetComponent(MicControl).StartMicrophone();
}
function Awake()
{
    previousTime = 0.0;
    count=1;
    breathRate = 1; //rate each 5 seconds
    exhale = false;
    breathCount=0;
    micController.GetComponent(MicControl).StartMicrophone();
}
function Update () 
{
    var getLoudness=micController.GetComponent(MicControl).loudness;
    var speed = 200*getLoudness;
    if(getLoudness > 0.01 && exhale==true)
    {
      //  Debug.Log(getLoudness);
        breathCount +=1;
        currentTime = Time.time;
        exhale=false;
        if(currentTime - previousTime > 0.2)
            breathRate = 60/(currentTime - previousTime);
      //  Debug.Log("CurrentTime");
       // Debug.Log(currentTime);
      //  Debug.Log("PreviousTime");
       // Debug.Log(previousTime);
        previousTime = currentTime;
    }
    if(getLoudness < 0.01)
    {
        exhale = true;
      //  if(breathCount>=1)
       // {
        //    
        //}
    }
    if(getLoudness>0.01)//breath rate is not b/w 11 and 13
    {
        damageImage.color = flashColour;
    }
    else
    {
        damageImage.color = Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
    }

 //   if(exhale==false)
   // {
  
  //  }
//    Debug.Log()
        
    
  //  Debug.Log(breathRate);
    /*
    if(Time.time >= awakeTime + 5.0)
    {
        awakeTime = Time.time;
//        count +=1;
        breathRate = breathCount;
        breathCount=0;
        //  Debug.Log(Time.time);50 to 70
    }*/
}