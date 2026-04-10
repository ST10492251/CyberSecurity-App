using System;
using System.Drawing;
using System.Media;

namespace CyberSecurity_App
{// start of namespace
    public class voice_logo
    {//start of class

        // Auto get the path directory
        private string full_path = AppDomain.CurrentDomain.BaseDirectory;




        public voice_logo()
        {//start of constuctor
         //calling sound method

            greetings();

            //calling the logo method
            asci();

            Console.ReadLine();


        }//end of constuctor

        //method to play the sound
        private void greetings()
        {//start of method

            // check if the path is auto collected
            Console.WriteLine(full_path);

            //then replace the \bin\Debug
            string correct_path = full_path.Replace(@"\bin\Debug\", @"\greeting.wav");

            //check if audio is found
            Console.WriteLine(correct_path);

            //the sound player class to play the audio
            //creating an instance for the soundplay class
            //with an object name greet

            SoundPlayer greet = new SoundPlayer(correct_path);
            //then play the sound using the play method
            greet.Play();





        }//end of greetings method

        //method to turn logo into ascii

        private void asci()
        {
            //path of the logo [ where the logo is ]
            string path = full_path.Replace(@"\bin\Debug\", @"\logo.jpg");
            Console.WriteLine(path);



            Bitmap image = new Bitmap(path);

            // Resize for better console fit
            int width = 150;
            int height = 70; //(image.Height * width) / image.Width;
            Bitmap resized = new Bitmap(image, new Size(width, height));

            // Default color , you can set yours before this line
            string asciiChars = "@#S%?*+;:,. ";

            //start by the height
            for (int y = 0; y < resized.Height; y++)
            {
                //then width
                for (int x = 0; x < resized.Width; x++)
                {
                    //color the pixel on x and y
                    Color pixel = resized.GetPixel(x, y);

                    // Convert to grayscale
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;

                    // Map grayscale to ASCII
                    int index = (gray * (asciiChars.Length - 1)) / 255;

                    Console.Write(asciiChars[index]);
                }
                Console.WriteLine();
            }
        }

    }//end of class




}// end of  namespace