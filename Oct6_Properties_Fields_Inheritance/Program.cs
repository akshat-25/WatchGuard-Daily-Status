using System;
using System.Data.SqlTypes;

public class Student
{
    private int _id;
    private string _name;
    private int _passMark = 35;
    private string _email;
    private string _city;

    public string Email
    {
        get;set;
    }

    public string City
    {
        get;set;
    }
    public void setName(string Name)
    {
        if (string.IsNullOrEmpty(Name))
        {
            throw new Exception("Name cannot be Null or Empty");
        }
        this._name = Name;
    }

    public string getName()
    {
        return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;   
    }

    //public void SetId(int id)
    //{
    //    if(id  <= 0)
    //    {
    //        throw new Exception("Student Id cannot be negative");
    //    }

    //    this._id = id;

    //}
    public int Id
    {

        set {
            if (value <= 0)
            {
                throw new Exception("Student Id cannot be negative");
        }
            this._id = value; 
    }
        get { 
        return this._id;
        }
    }

    //public int GetId()
    //{
       
    //    return this._id;
    //}

    public int GetPassMark()
    {
        return this._passMark;  
    }
}

/* public class Program
{
    public static void Main()
    {
        Student s1 = new Student();
        //s1.SetId(101);
        //s1.GetId();

        s1.Id = 101;

        s1.setName("Akshat");
        Console.WriteLine(s1.getName());
        Console.WriteLine(s1.GetPassMark());
        Console.WriteLine(s1.Id);
    }
} */


/*
 Properties enable a class to expose a public way of getting and setting values,
 while hiding implementation or verification code.
 
 */