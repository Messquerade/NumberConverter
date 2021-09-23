# Number Converter

#### This console application will convert a user's integer number into it's written word(s).

#### By Anna Clarke, Erica Marroquin, Scott Hutley

## Technologies Used

* _C#_
* _.Net_
* _MSTest_

## Description

This console app will take a number as an integer and display it as a written word(s).

## Setup/Installation Requirements

* Clone this repository to your desktop
* Open in text editor
* Make sure you have .Net version 5.0 installed
* In your terminal navigate into Scrabble.Solution/Scrabble/
* run commands $ dotnet run
* follow console instructions to use application and have fun!

## Known Bugs

* _No know issues_

## License

_[MIT](https://opensource.org/licenses/MIT)_

Copywrite(c)2021 Anna Clarke, Erica Marroquin, Scott Hutley

## Contact Information

Anna Clarke: anclarkie@gmail.com

Scott Hutley: scotthutley1@comcast.net

Erica Marroquin: ericamarroquin03@gmail.com

# Specs

* method that takes in a integer
* returns a string that is that number wordified
* look at not only what each digit is but where it is placed
* convert number to an array of numbers
* int[] = {1, 9, 6}
* array.length?


* start with just 1-10, then move up to 2 digit numbers, 3 digit etc.
* Dictionary for 1-9 { {1, "one"}, {2, "two"}}


#### Input/Output

1. input = 3
   expected output = "three"

2. input = 13
   expected output = "thirteen"

3. input = 26
   expected output = "twenty six"

4. input = 30
   expected output = "thirty"

5. input = 124
   expected output = "one hundred twenty four"