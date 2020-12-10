using System;
 
 class Song
 {
   
   string title { get; set; }
   string artistinfo { get; set; }
   private int id = 10;

   public Song()
   {
     id = 10;
     title = "unknown";
   }
   public Song(string songtitle)
   {
     songtitle = title;
     
   }
   public void Introtwo()
   {
     Console.WriteLine("The new song " + title + " is out now by Taylor swift");
   }
   
 }
