using System;

class MainClass {
  public static void Main (string[] args) {
    Artist popular = new Artist ("Taylor", "Swift", "unknown");
    popular.Intro();
    Song single = new Song("hit new song");
    single.Introtwo();
   
   }
}