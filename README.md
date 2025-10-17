📲 Daily Reflection SMS Sender

This service sends out daily reflection messages via SMS to subscribed users. It is intended to deliver short inspirational or thought-provoking content each day to a list of recipients.

✨ Features

Retrieves a new message daily from the reflection source (e.g. AA Denmark)

Sends SMS messages using a provider like Twilio

Configurable list of recipients (can be stored in code, file, or database)

Designed to run on a schedule (e.g., via cron or background task)

🔧 Requirements

.NET 9

Twilio account (or compatible SMS API)

Environment variables or config file for SMS API credentials

📤 Message Format

Each SMS contains the daily reflection in plain text, trimmed to fit within the SMS character limit.

Let me know if you want to add code usage examples, .env setup, or Docker info as part of the README too.
