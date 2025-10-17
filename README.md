# 📲 Daily Reflection SMS Sender

This service sends out daily reflection messages via SMS to subscribed users. It is intended to deliver short inspirational or thought-provoking content each day to a list of recipients.

## ✨ Features

- Retrieves a new message daily from the reflection source (e.g. AA Denmark)
- Sends SMS messages using a provider like Twilio
- Configurable list of recipients (can be stored in code, file, or database)
- Designed to run on a schedule (e.g., via cron or background task)

## 🔧 Requirements

- .NET 9
- Twilio account (or compatible SMS API)
- Environment variables or config file for SMS API credentials

---

## 🚀 Getting Started: Run the Console App (For Beginners)

Follow these steps to check out and run the DailyReflection console app. No prior experience needed!

### 1. Install Prerequisites

- **.NET SDK**: Download and install the latest [.NET SDK](https://dotnet.microsoft.com/download) (version 9 or newer).
- **Git**: Download and install [Git](https://git-scm.com/downloads).

### 2. Clone the Project

Open **Command Prompt** (Windows) or **Terminal** (Mac/Linux), then run:

```sh
git clone https://github.com/nicklasjepsen/daglig-eftertanke.git
cd daglig-eftertanke/DailyReflection
```

### 3. Build the Project

Run this command to check and prepare the code:

```sh
dotnet build
```

### 4. Run the Console App

Start the app with:

```sh
dotnet run --project DailyReflection.CLI
```

You should see a message printed in the terminal.

---

**Tip:** If you see errors, make sure you installed the .NET SDK and are in the correct folder.

You’re now running your first C# console app!

---

Let me know if you want to add code usage examples, .env setup, or Docker info as part of the README too.
