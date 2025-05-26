
# 📘 **README.md**

# HotelsAPI – Upgraded and Deployed!

This project is a simple ASP.NET Core Web API for managing hotel data. Today, I upgraded the project, added Docker support, implemented unit testing, and successfully deployed it.

![image](https://drive.google.com/file/d/1afvoKn0NT0HpPl-7ZVfJhhkpX9AQJsjq/view?usp=sharing)


# Web API Architecture (Markdown Diagram)

```plaintext
                     +--------------------------+
                     |      Client (Postman,     |
                     |      Browser, App)        |
                     +------------+-------------+
                                  |
                                  v
                       +----------+----------+
                       |    HotelsAPI (.NET 9) |
                       |     ASP.NET Core      |
                       +----------+----------+
                                  |
                                  |
               +------------------+------------------+
               |                                     |
      +--------+---------+                +----------+---------+
      |     Controllers    |                |       Startup.cs   |
      | (HotelsController) |                |     Configurations |
      +--------+---------+                +----------+---------+
               |                                     |
               |                                     |
   +-----------+------------+           +------------+-----------+
   |       Business Logic     |           |      Middleware          |
   | (Service Layer, if any)  |           |   (Error Handling, etc.) |
   +-----------+------------+           +------------+-----------+
               |                                     |
               v                                     v
        +-------------+                       +--------------+
        |   Data Models  |                       |   Unit Tests   |
        +-------------+                       +--------------+
               |
               v
        +----------------+
        |  Database (Optional) |
        +----------------+



---

## ✅ Upgraded from .NET 5 to .NET 9
- Used **.NET Upgrade Assistant** to migrate the project from .NET 5 to the latest .NET 9.
- Updated NuGet packages to ensure compatibility with .NET 9.

---

## 🐳 Added Docker Support
- Created a **Dockerfile** to containerize the application.
- Built and ran the Docker image locally using:
  ```bash
  docker build -t hotelsapi .
  docker run -d -p 5000:80 hotelsapi


* Access the API at `http://localhost:5000`.

---

## 🧪 Unit Testing with xUnit

* Created a separate **Unit Test project** within the solution.
* Used **xUnit** for writing and running unit tests.
* Verified that the API logic behaves as expected.

---

## 🚀 Deployment

* Deployed the Dockerized .NET 9 Web API to **Render/Railway/Azure** (choose the one you used).
* Ensured successful deployment and tested with Postman.
* Got a live URL (for example: `https://hotels-web-api-service.onrender.com/api/hotels`).

---

## 🔧 How to Run Locally

1. Clone the repository.
2. Build the Docker image:

   ```bash
   docker build -t hotelsapi .
   ```
3. Run the container:

   ```bash
   docker run -d -p 5000:80 hotelsapi
   ```
4. Access the API at `http://localhost:5000`.

---

## 📂 Project Structure

```
/HotelsAPI.sln
  /HotelsAPI
    /Controllers
    /Models
    /Startup.cs
    /Program.cs
  /HotelsAPI.UnitTests
/Dockerfile
/README.md
```

---

## 📖 Technologies

* ASP.NET Core 9 Web API
* xUnit (Unit Testing)
* Docker
* .NET Upgrade Assistant

