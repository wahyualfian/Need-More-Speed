#pragma strict
 var pause : boolean = false;
 function OnGUI()
 
  {
  if (GUI.Button (Rect(Screen.width-55,0,50,50),"Pause"))
 
 
 {
 
 
 if (pause == false)
 { 
 pause = true ;
 Time.timeScale = 1 ;
 
 return;
 }
 
 if (pause == true)
 {
 pause = false;
 Time.timeScale = 0 ;
 return;
 
 }
 }
 }