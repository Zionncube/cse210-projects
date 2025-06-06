# cse210-ww-student-template
This is the starter code for students in the worldwide content version of CSE 210.

This repository contains the starter code for many different projects. They are arranged folders by week. There is also an an empty sandbox project that can be used to play around with any concept you would like.


on the resumae code this is the code below is a mordern simpler way.
//job.cs

public class Job
{
    pulic string jobTitle {get;set;}
    pulic string companyName {get;set;}
    pulic string location {get;set;}
    pulic string jobDescription {get;set;}
    pulic string salary {get;set;}

    // constructor

    public Job(string jobTitle, string companyName, string location, string jobDescription, string salary)
    {
        _jobTitle = jobTitle;
        _companyName = companyName;
        _location = location;
        _jobDescription = jobDescription;
        _salary = salary;
    }
}

_jobTitle = _jobTitle; this on the constructor is reporting a fix which is asigning to the same variable 
this  can be fixed by adding (this.) or giving it a different name
eg. 
this._jobTitle = _jobTitle;
the giving of the different name shoud start from the public Job( string title,etc)


**Understanding Inheritance with the Father–Mother Principle**
*By Happiness Nonkululeko Ncube*

---

### 🌟 



Inheritance in Programming – My Way of Understanding

Sometimes learning about programming can feel a little technical, but I’ve found that connecting it to real life makes things *click*. One way that really helped me understand **inheritance** is what I call the **Father–Mother Principle** — and I’d love to explain it in my own way.

---

### 👨‍👩‍👧 Real Life: We Inherit from Our Parents

Just like in real life, a child inherits things from both their father and mother — maybe your smile comes from your mom or your voice from your dad. But even though you inherit from them, you also become your own person, right? You develop your own talents, likes, and ways of doing things.

Well, in **object-oriented programming**, we do the same thing with **classes**.

---

### 💻 Programming Side: Base and Derived Classes

In programming, the **parent class** (also called the **base class**) is like the father or mother — it contains shared features, or what I call "family traits": methods (actions) and properties (information). Then we create **child classes** (also called **derived classes**) that inherit those traits, but they can also add their own special abilities!

---

### 💻 Simple Example in C\#

```csharp
public class Parent
{
    public void Speak()
    {
        Console.WriteLine("Hello! I can speak.");
    }
}

public class Child : Parent
{
    public void Play()
    {
        Console.WriteLine("I can play too!");
    }
}
```

So here, the child gets the `Speak()` method from the parent — but also has its own `Play()` method.

---

### ▶️ What Happens When We Run It?

```csharp
Child myChild = new Child();
myChild.Speak();  // This comes from Parent
myChild.Play();   // This is unique to Child
```

**Output:**

```
Hello! I can speak.
I can play too!
```

See? Just like how we inherit from our parents but still have our own gifts — programming lets classes do the same.

---

### 💡 Why This Is Beautiful

Here’s why inheritance is powerful:

* ✅ **No need to repeat yourself.** Shared things live in one place — the base class.
* 🛠️ **Fix it once, fix it everywhere.** If I fix something in the parent, all the children benefit.
* 🧹 **Tidy and organized.** It keeps your code clean and manageable.
* 💖 **It just makes sense.** Because that’s how real life works too.

---

### 📝 Summary – The Happiness Way

| Real Life        | Programming                  |
| ---------------- | ---------------------------- |
| Father/Mother    | Base class                   |
| Child            | Derived class                |
| Inherited traits | Inherited methods/properties |
| Unique talents   | New or overridden methods    |

---

This way of learning makes me smile — because programming really isn’t so different from how life works. And when I look at code this way, it just feels *right*. I hope it helps someone else too. 🌼
