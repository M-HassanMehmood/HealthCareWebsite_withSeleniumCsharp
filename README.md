# HealthCareWebsite
# Selenium Automation Project with C#

This project is an automation testing framework built using **Selenium WebDriver** with **C#**. It demonstrates basic to advanced scenarios for testing the **Katalon Healthcare Demo Website**.

---

## Features
- Automated test cases for login functionality (positive and negative scenarios).
- Appointment booking with valid details.
- Validation of error messages for invalid inputs.
- History page navigation and verification.

---

## Prerequisites

Before running the tests, ensure you have the following installed:

1. **Visual Studio** (Community, Professional, or Enterprise Edition).
2. **.NET Framework** or **.NET Core/5+**.
3. **Chrome Browser** (ensure it's up-to-date).
4. **ChromeDriver** (compatible with your Chrome version).

---

## Setup Instructions

### Step 1: Clone the Repository
```bash
git clone <repository-url>
cd <repository-folder>
```

### Step 2: Install NuGet Packages

Install the following NuGet packages for Selenium WebDriver:

1. Open the project in Visual Studio.
2. Right-click on the project and select **Manage NuGet Packages**.
3. Search for and install:
   - `Selenium.WebDriver`
   - `Selenium.Support`

### Step 3: ChromeDriver Path

Ensure the **ChromeDriver** executable is available in your system's PATH, or specify its location explicitly in the code:
```csharp
IWebDriver driver = new ChromeDriver(@"path-to-chromedriver");
```

---

## Project Structure

### Namespace: `HealthCareWebsite`

- **TestExecution.cs**
  - Contains all test cases.
  - Uses MSTest framework for execution.

### Test Cases:

1. **TestCase001:**
   - Validates the "Please login to make an appointment" message on the homepage.

2. **TestCase002:**
   - Tests login functionality with valid credentials.

3. **TestCase003:**
   - Tests login functionality with invalid credentials and verifies error messages.

4. **TestCase004:**
   - Verifies the appointment booking functionality.

5. **TestCase005:** *(Optional)*
   - A negative test case for booking without selecting a date (commented out due to lack of error IDs).

6. **TestCase006:**
   - Validates navigation to the History page after login.

---

## Running the Tests

1. Open the project in Visual Studio.
2. Build the solution (ensure there are no build errors).
3. Open the **Test Explorer** window:
   - Go to **Test** > **Windows** > **Test Explorer**.
4. Run the tests:
   - Select individual tests or all tests and click the **Run** button.

---


## Troubleshooting

1. **ChromeDriver version mismatch:**
   - Ensure the ChromeDriver version matches your Chrome browser version.

2. **Missing NuGet packages:**
   - Reinstall packages using **Manage NuGet Packages** in Visual Studio.

3. **Web elements not found:**
   - Verify if the website's structure (IDs/XPaths) has changed.

---

## Contribution Guidelines

1. Fork the repository.
2. Create a new branch for your feature/bug fix.
3. Submit a pull request with a detailed description of your changes.

---


## Acknowledgements

- [Selenium WebDriver Documentation](https://www.selenium.dev/documentation/)
- [Katalon Demo Healthcare Website](https://katalon-demo-cura.herokuapp.com/)

