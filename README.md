
# RepeatCounter

#### _Week 2 solo project C#, 06.02.2017_

#### By _**Pete Lazuran**_

## Description

RepeatCounter asks the user to enter a sentence and then a word to be found in that sentence. The program will count the number of times the chosen word appears in the user's sentence.

## Specs
<!-- * Check if the word chosen by the user is contained in the sentence entered by the user and return true. This will make sure that the program is finding the correct word in the sentence.
* Create a counter that will count the one instance of the chosen word specified in the previous spec. In this case it should count from 0 to 1. This will establish a method that can later be displayed to the user as per the objectives of the project.
* Have a foreach loop that will go through the entire sentence entered by the user and for each instance of the chosen word it will add 1 to the counter. This will create the final number that will be displayed to the user. -->

|Behavior|User Input|Expected Output|
|---------|----------|-----------|
|User enters a _sentence_ and a **word** to be found in that sentence|"_All in all is all we are_", "**all**"|Number of times "all" appears in "All in all is all we are"|
|The user's selected word is found in their sentence and for each instance of the word the **count** is increased by one|"All in all is all we are", "all"|"Your word is used **3** times in your sentence"|

## Setup/Installation Requirements

* Open Terminal.
* Enter the command "git clone https://github.com/NaruzaL/RepeatCounter.git".
* Navigate to the file directory in terminal (..\Desktop\RepeatCounter>).
* Open in a text editor if you wish to view the code.
* To view the site in your local server enter the command "dnu restore" follwed by "dnx kestrel" in your Terminal.


## Known Bugs

If the sentence entered by the user contains punctuation the program will fail to find the chosen word in the sentence. A method to remove punctuation is needed.

## Support and contact details

Direct all questions and comments to pdlazuran@gmail.com

## Technologies Used

C#, HTML, Nancy, Razor, Xunit

### License

*MIT*

Copyright (c) 2017 **_Pete Lazuran_**
