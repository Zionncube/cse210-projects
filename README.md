cse210-ww-student-template
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


Understanding Inheritance with the Father–Mother Principle
*By Happiness Nonkululeko Ncube*







Inheritance in Programming – My Way of Understanding

Sometimes learning about programming can feel a little technical, but I’ve found that connecting it to real life makes things *click*. One way that really helped me understand **inheritance** is what I call the **Father–Mother Principle** — and I’d love to explain it in my own way.

Real Life: We Inherit from Our Parents

Just like in real life, a child inherits things from both their father and mother — maybe your smile comes from your mom or your voice from your dad. But even though you inherit from them, you also become your own person, right? You develop your own talents, likes, and ways of doing things.

Well, in object-oriented programming, we do the same thing with classes.

---

 Programming Side: Base and Derived Classes

In programming, the parent class (also called the base class) is like the father or mother — it contains shared features, or what I call "family traits": methods (actions) and properties (information). Then we create **child classes** (also called **derived classes**) that inherit those traits, but they can also add their own special abilities!



 Simple Example in C\#

csharp
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


So here, the child gets the `Speak()` method from the parent — but also has its own `Play()` method.


What Happens When We Run It?

csharp
Child myChild = new Child();
myChild.Speak();  // This comes from Parent
myChild.Play();   // This is unique to Child


Output:


Hello! I can speak.
I can play too!

See? Just like how we inherit from our parents but still have our own gifts — programming lets classes do the same.


 Why This Is Beautiful

Here’s why inheritance is powerful:

* No need to repeat yourself. Shared things live in one place — the base class.
* Fix it once, fix it everywhere. If I fix something in the parent, all the children benefit.
* Tidy and organized. It keeps your code clean and manageable.
* It just makes sense. Because that’s how real life works too.


 Summary The Happiness Way

| Real Life        | Programming                  |
| ---------------- | ---------------------------- |
| Father/Mother    | Base class                   |
| Child            | Derived class                |
| Inherited traits | Inherited methods/properties |
| Unique talents   | New or overridden methods    |

---

This way of learning makes me smile — because programming really isn’t so different from how life works. And when I look at code this way, it just feels *right*. I hope it helps someone else too. 🌼




what does the programme do?

The Eternal Quest program allows users to track personal goals and earn points as they complete them. It includes three types of goals:

SimpleGoal (complete once)
EternalGoal (ongoing, repeatable)
ChecklistGoal (complete a goal a set number of times for a bonus)

The program also tracks the user's total score.

---

What user inputs does it have?

* Choice from a menu (e.g., Create Goal, Record Event, Display Goals)
* Goal details: name, description, point value
* Goal type: Simple, Eternal, or Checklist
* Checklist-specific inputs: target number of completions and bonus
* Event recording (select a goal to mark progress)

---

What output does it produce?

* Displays current score
* Shows a list of goals and their statuses
* Confirms event recordings and points awarded
* May include gamified elements like achievements (added later)

---

How does the program end?

* The user selects an "Exit" option from the main menu.

---

Determine the Classes

Good candidates for classes:

* `Goal` (base/abstract class)
* `SimpleGoal` (inherits `Goal`)
* `EternalGoal` (inherits `Goal`)
* `ChecklistGoal` (inherits `Goal`)
* `GoalManager` (handles list of goals and total score)

---

Primary responsibilities of each class:

Goal (abstract)

* Stores common goal information (name, description, points)
* Provides base methods like `GetDetailsString()`, `RecordEvent()`

SimpleGoal

* Tracks if completed
* Awards points once

EternalGoal

* Tracks ongoing efforts
* Awards points infinitely without completion

ChecklistGoal

* Tracks number of completions
* Awards bonus after reaching target

GoalManager

* Holds the list of all goals
* Tracks player score
* Manages menu interactions, save/load, and event recording


Benefits of GoalManager Class

* Encapsulation: keeps program state (score, goals) in one place
* Reusability: clean separation of UI/menu logic from data/model logic
* Flexibility: easy to extend or modify (e.g., add persistence or achievements)

---

Define Class Behaviors (Methods)

Goal

* `virtual GetDetailsString() : string`
* `abstract RecordEvent() : void`
* `GetName(), GetDescription(), GetPoints()`

SimpleGoal

* `override RecordEvent()`
* `override GetDetailsString()`

EternalGoal

* `override RecordEvent()`

ChecklistGoal

* `override RecordEvent()`
* `override GetDetailsString()`

GoalManager

* `DisplayMenu()`
* `CreateGoal()`
* `RecordEvent()`
* `DisplayGoals()`
* `SaveGoals() / LoadGoals()`
* `GetScore()`

Why Make `RecordEvent` Abstract?

* Forces derived classes to define how points are awarded and goals updated
* Prevents the base class from having an incomplete or irrelevant default

Why Override `GetDetailsString()` Only in `ChecklistGoal`?

* `ChecklistGoal` displays unique format: `Completed X/Y times` and includes bonus
* `SimpleGoal` and `EternalGoal` can use the base format

---

Define Class Attributes

| Class      | Attributes                                             |
| --------------- | ------------------------------------------------------------ |
| `Goal`          | `_shortName: string`, `_description: string`, `_points: int` |
| `SimpleGoal`    | `_isComplete: bool`                                          |
| `EternalGoal`   | *No additional attributes*                                   |
| `ChecklistGoal` | `_amountCompleted: int`, `_target: int`, `_bonus: int`       |
| `GoalManager`   | `_goals: List<Goal>`, `_score: int`                          |


Why Keep `EternalGoal` Class Even if It Has No Variables?

* It still has a distinct behavior for point recording
* Supports polymorphism and future extensions


Define Constructors

Goal
csharp
public Goal(string name, string description, int points)

SimpleGoal

csharp
public SimpleGoal(string name, string description, int points)
{
    _isComplete = false;
}


EternalGoal

csharp
public EternalGoal(string name, string description, int points)

ChecklistGoal

csharp
public ChecklistGoal(string name, string description, int points, int target, int bonus)
{
    _amountCompleted = 0;
}


GoalManager

csharp
public GoalManager()
{
    _goals = new List<Goal>();
    _score = 0;
}

Why doesn’t `SimpleGoal` constructor need an `_isComplete` parameter?

 It always starts as `false` (incomplete), so it's set internally during construction.

 Class Diagram Summery
Goal (abstract)
 ├─ string _shortName
 ├─ string _description
 ├─ int _points
 ├─ virtual string GetDetailsString()
 └─ abstract void RecordEvent()

  ↑ (inherits)

SimpleGoal : Goal
 ├─ bool _isComplete
 └─ override void RecordEvent()

EternalGoal : Goal
 └─ override void RecordEvent()

ChecklistGoal : Goal
 ├─ int _amountCompleted
 ├─ int _target
 ├─ int _bonus
 └─ override void RecordEvent()

GoalManager
 ├─ List<Goal> _goals
 ├─ int _score
 ├─ void CreateGoal()
 ├─ void DisplayGoals()
 ├─ void RecordEvent()
 └─ int GetScore()
```

---





Polymorphism is like when you say the word “cook” at home, and Mom, Dad, and the child each do something a little different.

 When Dad cooks, he might braai meat.
 When Mom cooks, she might make a salad.
 And when the child cooks, they might just microwave popcorn.

 Even though you said the same word: "cook()", each person did it in their own way. That’s what polymorphism is in programming—one word, many behaviors depending on who's using it.

Because instead of telling each person exactly what to do every time, you just say "Cook!", and they know what to do in their own special way. In programming, that means we can write cleaner, smarter code by just trusting each class (like Dad, Mom, or Child) to handle their version of the task.

Let’s say you're planning dinner, and you just shout:
"Everyone, go cook!"
Each family member goes to do their version of cooking.

In code, this is what it looks like:


List<FamilyMember> family = new List<FamilyMember>();
family.Add(new Dad());
family.Add(new Mom());
family.Add(new Child());

foreach (FamilyMember member in family)
{
    member.Cook();  // Each one cooks differently!
}

Here, `Cook()` is the same command, but each family member understands it in their own way -just like polymorphism in action!

code?

Polymorphism means "many forms". It lets us use the same method name, but each class can do something different with it. Just like when a father, mother, and child all hear the word “cook”, and each one responds in their own way. This helps programmers write less repeated code and lets each part of the program handle its own job.

So instead of writing a separate cooking instruction for Dad, Mom, and Child, we just write one command—and they know what to do. That’s polymorphism: one method name, different actions, depending on the object using it.

