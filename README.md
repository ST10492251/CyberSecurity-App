# CyberSecurity Console Chatbot (C# .NET Framework)

* Overview

This project is a simple C# console application chatbot. It interacts with the user and provides basic cybersecurity awareness tips.

The chatbot responds to user input using keyword detection. It covers topics like passwords, phishing, malware, viruses, and worms.

* Features

* User name input at startup
* Interactive chat loop
* Keyword-based responses
* Cybersecurity awareness tips
* Clean exit command

* Technologies Used

* C#
* .NET Framework Console Application

* Project Structure

* Program.cs
  Controls the main flow of the application

* greet_user.cs
  Handles user input and stores the user's name

* get_response.cs
  Contains chatbot logic and responses

* voice_logo.cs
   class for voice greeting and logo setup

* How It Works
1. Will play voice greeting and shoe the logo
2. The program starts and asks for the user’s name
3. The chatbot waits for user input
4. It checks input for keywords
5. It returns a relevant response
6. The loop continues until the user types "exit"

* Example Inputs

* hello
* how are you
* password tips
* what is phishing
* malware
* virus
* worm
* exit

* Example Output

You: password tips
Bot: Use strong passwords. Mix uppercase, lowercase, numbers, and symbols. Do not reuse passwords.

* Exit Command

Type "exit" to end the session.
The bot will display a closing message before shutting down.

* How to Run

1. Open the project in Visual Studio
2. Build the solution
3. Run the application
4. Interact using the console

* Future Improvements

* Improve response intelligence
* Add more cybersecurity topics
* Create a graphical interface



