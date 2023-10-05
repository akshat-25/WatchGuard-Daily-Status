using System;

//public class Person
//{
//    private DateTime _birthdate;

//    public void setBirthDate(DateTime birthdate)
//    {
//        _birthdate = birthdate;
//    }

//    public DateTime getBirthdate() {
//    return _birthdate;  
//    }


//}


public class Person
{

    public Person(DateTime birthDate)
    {
        Birthdate = birthDate;   
    }
    public DateTime Birthdate { get; private set; }

   
    public int Age
    {
        get
        {
            var timeSpan = DateTime.Today - Birthdate;
            var years = timeSpan.Days / 365;

            return years;   
        }
    }
}