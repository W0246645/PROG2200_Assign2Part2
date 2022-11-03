PROG2200 – Advanced OOP

Student Name: ___________________ Date:________________
Assignment2-Part2


Assignment Value: 9% of overall course mark.

Due Date: See due date designated on the Assignment 2-Part2 dropbox on Brightspace. On Thursday Nov 10th @ 11:59pm. Try to enjoy your 4 days weekend by submitting this assignment before the due date.

Late submissions will receive the standard late submission penalty as stated in the course outline. 5% overall deduction per day late, until 60%, and 0% after assignment handed back to the class.)

Assignment Instructions:
(Piggy Bank)
Copy the zipped folder (Assignment2-Part2) From Brightspace. and enhance it as follows:

Move the PiggyBank, BalanceLogger and BalanceWatcher classes into their own separate .cs files with the same file name as the class. (1 pt ) _____

Provide validation for the deposit entry (It shouldn’t accept string value to the deposited amount and keep prompting the user to input a valid numerical value, on the same time keep the do-while loop’s exit condition as is (i.e., don’t change [while(!theStr.Equals("exit"));].(3 pts ) _____

You want to alert the user when there is nothing left in the Piggy Bank and decide to use the .NET standard for events. Consult the ChainedEvents solution for hints. To accomplish:

Add a BalanceArgs class that extends EventArgs which will have a public property of balance. (2 pts ) _____

Add a new event of type System.EventHandler to PiggyBank called negBalanceChanged. It should be declared with the generic <BalanceArgs>. (2 pts ) _____

Add a call to negBalanceChanged every time theBalance property on PiggyBank is set. Remember to use the correct method signature and pass in a BalanceArgs with the prop set to the new value. (2 pts ) _____

In Program.cs. Add an anonymous delegate to the PiggyBank instance that will log to the console if the balance goes below zero. (2 pts ) _____

Explain the logical flow of your program by either using a recorded session for 10 minutes maximum or using a written report in a word document file. In your explanation, point out the following:

The events, their types, and their implementations. (1 pt) _____

The new codes added by you and why did use those codes. Assume that I don’t have any idea about coding. (3 pts) _____

Final Score (Out of 16) _______
