# BBScraper
* This application's purpose is to fetch data from a Banco do Brasil account and display to the user.
* Inspired by @pschlusen 's code

## Features
* Account Balance
* Display client data

## Usage
Enter your branch and account number, the password and hit submit to access the data.

##How it works
The application consists of 4 projects. The main projects is where the MVC pattern is implemented.
The .App project is where the User class that contains the AccessData method which takes the arguments from the users and connects them with the Domain through the User and Bankservice class.
The .Domain project is where the "magic" scraping is happening. In here is the interface is implemented as well as the URL library code.
The .Context project is where the DB is implemented through a DBBuilder method.

## Development process
This project was made for the selection process of the Warren company. 
This is my first time building an app with Razor and ASP.Net technology, so I chose to fork an existing project and start building upon it, that way I was able to learn more about how the development process work in this technology.
Honestly I wasn't able to create a perfect solution for the case simply because I'm still very new to this. I think the further I advance in coding and data structure I'll be able to solve this way more easily.

