using System;

   class Artist{
  
     string firstname { get; set; }
     string lastname { get; set; }
     string email { get; set; }
    
    public Artist()
    {
      firstname = "uknown";
      lastname = "unknown";
      email = "unknown";
     
    }
    public Artist(string name1, string name2, string mail)
    {
     firstname = name1;
     lastname = name2;
     email = mail;
    }  
    public void Intro()
    {
      Console.WriteLine("My name is " + firstname + " " + lastname + " and my email is " + email);
    }
  }

 