
# 📘 **README.md**

````markdown
# HotelsAPI – Upgraded and Deployed!

This project is a simple ASP.NET Core Web API for managing hotel data. Today, I upgraded the project, added Docker support, implemented unit testing, and successfully deployed it.

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
````

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

```

---

# ✍️ **Medium Post Draft** (Plain Text)

---

# 🚀 Upgrading My .NET Web API to .NET 9 with Docker and xUnit  

Today, I took my simple Hotels API project and gave it a massive upgrade! Here’s a quick summary of what I did:

---

## 1️⃣ Upgraded from .NET 5 to .NET 9  
Using the official **.NET Upgrade Assistant**, I migrated my project from .NET 5 to .NET 9. This process involved running upgrade commands, resolving dependency and NuGet issues, and verifying that everything was compatible with the new C# features.

---

## 2️⃣ Added Docker Support  
Next, I decided to containerize my API for easier deployment. I wrote a **Dockerfile** that builds and runs the project, successfully built the Docker image, and ran it locally. I was able to access my API at `http://localhost:5000`.

---

## 3️⃣ Implemented Unit Testing with xUnit  
To ensure my logic was solid, I created a new **xUnit test project** within the solution, wrote basic unit tests to cover key functionality, and ran the tests. I made sure everything passed before moving forward.

---

## 4️⃣ Deployed to the Cloud  
Finally, I deployed my Dockerized API to the cloud (using **Render/Railway/Azure**). I configured the cloud service to build from my GitHub repository, verified that the deployment was successful, and got a live endpoint to test with Postman.

---

## 🏆 Key Takeaways  
- The **.NET Upgrade Assistant** made migrating between versions smooth and easy.
- **Docker** is essential for containerization and deployment.
- **xUnit** is perfect for unit testing in .NET projects.
- Cloud platforms like **Render**, **Railway**, or **Azure** make deployment a breeze.

---

💬 Have you tried upgrading your .NET projects? Or adding Docker support? Let me know in the comments!

---

