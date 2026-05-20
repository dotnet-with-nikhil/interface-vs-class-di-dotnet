# Dependency Injection in .NET — Interface vs Class

A simple and beginner-friendly .NET Console Application to understand:

- Why Interfaces are used in Dependency Injection
- Tight Coupling vs Loose Coupling
- Constructor Injection
- Runtime Polymorphism
- Interface vs Concrete Class
- Real-world Dependency Injection concepts

This project explains the core concept behind:

> "Why do we use Interface instead of Class in Dependency Injection?"

---

# Tech Stack

- C#
- .NET Console Application
- Object-Oriented Programming (OOP)

---

# Project Structure

```text
DependencyInjectionDemo
│
├── IMessageService.cs
├── EmailService.cs
├── SMSService.cs
├── NotificationManager.cs
└── Program.cs
```

---

# Scenario

We want to send notifications using different services like:

- Email
- SMS
- WhatsApp
- Push Notification

This project demonstrates:

- The problem with directly using classes
- How interfaces solve the issue using loose coupling

---

# 1. WITHOUT INTERFACE (Tightly Coupled)

## EmailService.cs

```csharp
public class EmailService
{
    public void Send()
    {
        Console.WriteLine("Email Sent");
    }
}
```

---

## NotificationManager.cs

```csharp
public class NotificationManager
{
    private readonly EmailService _emailService;

    public NotificationManager(EmailService emailService)
    {
        _emailService = emailService;
    }

    public void Notify()
    {
        _emailService.Send();
    }
}
```

---

## Program.cs

```csharp
class Program
{
    static void Main(string[] args)
    {
        EmailService service =
            new EmailService();

        NotificationManager manager =
            new NotificationManager(service);

        manager.Notify();
    }
}
```

---

# Problem With Using Class Directly

`NotificationManager` directly depends on `EmailService`.

If requirement changes from:

- Email → SMS
- SMS → WhatsApp

then we must modify `NotificationManager` again and again.

This is called:

# Tight Coupling

---

# 2. WITH INTERFACE (Loose Coupling)

---

## IMessageService.cs

```csharp
public interface IMessageService
{
    void Send();
}
```

---

## EmailService.cs

```csharp
public class EmailService : IMessageService
{
    public void Send()
    {
        Console.WriteLine("Email Sent");
    }
}
```

---

## SMSService.cs

```csharp
public class SMSService : IMessageService
{
    public void Send()
    {
        Console.WriteLine("SMS Sent");
    }
}
```

---

## NotificationManager.cs

```csharp
public class NotificationManager
{
    private readonly IMessageService _messageService;

    public NotificationManager(IMessageService messageService)
    {
        _messageService = messageService;
    }

    public void Notify()
    {
        _messageService.Send();
    }
}
```

---

# Program.cs — Using EmailService

```csharp
class Program
{
    static void Main(string[] args)
    {
        IMessageService service =
            new EmailService();

        NotificationManager manager =
            new NotificationManager(service);

        manager.Notify();
    }
}
```

---

# Output

```text
Email Sent
```

---

# Program.cs — Using SMSService

```csharp
class Program
{
    static void Main(string[] args)
    {
        IMessageService service =
            new SMSService();

        NotificationManager manager =
            new NotificationManager(service);

        manager.Notify();
    }
}
```

---

# Output

```text
SMS Sent
```

---

# Key Understanding

## This Line

```csharp
IMessageService service = new EmailService();
```

means:

- `new EmailService()` creates actual object
- `IMessageService` stores reference of object

The consumer class depends on:

- Interface (abstraction)

instead of:

- Concrete class implementation

---

# Why Interface Is Used?

## Benefits

✅ Loose Coupling  
✅ Better Maintainability  
✅ Easy Unit Testing  
✅ Flexible Architecture  
✅ Easy to Replace Implementations  
✅ Follows SOLID Principles  
✅ Better Scalability  

---

# Real-World Usage

Interfaces are heavily used in:

- ASP.NET Core
- Clean Architecture
- Microservices
- Repository Pattern
- Service Layer
- Unit Testing
- Enterprise Applications

---

# Key Concept

Dependency Injection does NOT remove dependency.

It changes dependency from:

```text
Specific Class Dependency
```

to:

```text
Abstraction / Contract Dependency
```

This is called:

# Loose Coupling

---

# How to Run the Project

## Clone Repository

```bash
git clone <your-repository-url>
```

---

## Open in Visual Studio

- Open Solution
- Build Project
- Run Application

---

# Expected Output

## Using EmailService

```text
Email Sent
```

## Using SMSService

```text
SMS Sent
```

---

# Learning Outcomes

After completing this project, you will understand:

- What is Dependency Injection
- Why Interfaces are used in DI
- Difference between Tight Coupling and Loose Coupling
- Runtime Polymorphism
- Constructor Injection
- Why enterprise applications prefer interfaces

---

# Author

Created for learning, interview preparation, and understanding Dependency Injection concepts in .NET.
