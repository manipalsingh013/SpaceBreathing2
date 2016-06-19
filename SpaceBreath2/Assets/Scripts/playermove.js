#pragma strict

var micController:GameObject;
var player:GameObject;
var moon:GameObject;

function Start () {

}

function Awake()
{
    //player.transform.position.y = moon.transform.position.y + 1.7;    
    micController.GetComponent(MicControl).StartMicrophone();
}

function Update () 
{
 //   player.transform.position.x = moon.transform.position.x;
   // player.transform.position.z = moon.transform.position.z;

    var getLoudness = micController.GetComponent(MicControl).loudness;
   
        
    //Debug.Log(player.transform.position.y);
    if(getLoudness > 0.01) //player exhales
    {
        if(player.transform.position.y +70<30.0)
//            player.transform.Translate (0,10.01,0);
            player.transform.position.y +=0.01;
        
    }
    if(getLoudness < 0.01 && player.transform.position.y + 71 >0.0)//player inhales
    {
        player.transform.position.y -=0.01;
       // player.transform.Translate (0,0,-0.01);
    }
}