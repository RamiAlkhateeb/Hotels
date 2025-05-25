# Hotels

# 📈 Process Flow: App Creation to Documentation

This document outlines the steps involved in creating and developing the application.

## 📝 Steps

1. **App Creation**
   - Initialize the project repository.
   - Set up the core codebase.
   - Configure essential development tools.

2. **Creating a Testing Project**
   - Set up a separate testing environment.
   - Develop test cases for features.
   - Integrate continuous integration (CI) tools if necessary.

3. **Version Upgrading**
   - Upgrade project dependencies and libraries.
   - Refactor code where necessary to support new versions.
   - Perform regression testing to ensure compatibility.

4. **Adding Docker**
   - Create a Dockerfile for containerizing the app.
   - Set up docker-compose if needed.
   - Test the containerized application.

5. **Documentation**
   - Create a README.md file with setup instructions.
   - Write developer and user documentation.
   - Document the API if applicable.

---

## 🔗 Summary
The process covers the complete development cycle from initial app creation to preparing a Dockerized version with detailed documentation.



![alt text](https://github.com/RamiAlkhateeb/Hotels/blob/main/Capture.PNG?raw=true)

This API is made to support the following UI.<br />
it contains
- API for listing/searching for a hotel
- API for viewing details and info about a specific hotel
- API for placing a booking

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


Access the API at http://localhost:5000.

 Unit Testing with xUnit
Created a separate Unit Test project within the solution.

Used xUnit for writing and running unit tests.

Verified that the API logic behaves as expected.

🚀 Deployment
Deployed the Dockerized .NET 9 Web API to Render/Railway/Azure (choose the one you used).

Ensured successful deployment and tested with Postman.

Got a live URL (for example: https://hotels-web-api-service.onrender.com/api/hotels).

🔧 How to Run Locally
1. Clone the repository.
2. Build the Docker image:

docker build -t hotelsapi .

3. Run the container:
docker run -d -p 5000:80 hotelsapi

4. Access the API at http://localhost:5000.

Project Structure

/HotelsAPI.sln
  /HotelsAPI
    /Controllers
    /Models
    /Startup.cs
    /Program.cs
  /HotelsAPI.UnitTests
/Dockerfile
/README.md
