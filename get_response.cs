using System;

namespace CyberSecurity_App
{
    public class get_response
    {
        public string Response(string input, string name)
        {
            // greetings
            if (input == "hello")
                return "Hello " + name;

            if (input == "how are you")
                return "I am fine";

            if (input == "bye")
                return "Goodbye " + name;

            // passwords
            if (input.Contains("password"))
                return "You must use strong passwords. Mix uppercase, lowercase, numbers, and symbols. Do not reuse passwords.";

            // phishing
            if (input.Contains("phishing"))
                return "Phishing is a scam where attackers trick you into giving personal info. Do not click suspicious links. Always verify the sender.";

            // malware
            if (input.Contains("malware"))
                return "Malware is harmful software. Avoid downloading from untrusted sites. Use antivirus protection.";

            // viruses
            if (input.Contains("virus"))
                return "A virus spreads by attaching to files. Keep your system updated and scan files before opening.";

            // worms
            if (input.Contains("worm"))
                return "A worm spreads across networks without user action. Keep your firewall on and update your system.";

            return "I don't understand. Try asking about passwords, phishing, malware, viruses, or worms.";

            //exit
             if (input.Contains ("exit"))
                return "Goodbye " + name;
        }

    }
}