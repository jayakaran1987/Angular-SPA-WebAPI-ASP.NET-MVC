MortgageRepaymentCalculator
single page web application that will perform a simple mortgage repayment calculation

The Application
Create a single page web application that will perform a simple mortgage repayment calculation.
On loading the page in a browser it should only display 4 fields and a button (a bonus would be to have these fields contained in an AngularJS partial). The fields will accept entry of a loan amount, the term of the mortgage in years and months and the annual interest rate.
Client side validation:
Entry of all fields is mandatory
The months fields should only allow entry of a value between 0 and 11.
Loan amount must be > 0
Interest rate must be > 0
Loan term years must be >= 0
 
On clicking a button below the form the page should then display a new section at the bottom (of the same page) with fields containing the monthly repayment and the total amount that would be paid over the lifetime of the mortgage, both shown to 2 decimal places.
 
Notes
The application should use the following technologies:
AngularJS for the front end, making use of partials and AJAX calls.
Server side should use ASP.Net MVC and Web Api
The repayment and total amount to be paid should be calculated on the server and returned to the page.
The page should not refresh, AJAX must be used to call the server.
The repayment calculation should use the simplest formula which is identical to the PMT function available in Microsoft Excel
The purpose of this test is to see that the candidate is familiar with the above technologies so proper architecture is required, making use of the normal MVC layers (given that we are using AngularJS for the view and AJAX from the client).
 
Acceptance criteria
1) Given the following inputs:
Loan amount = 145000
Annual Interest rate = 4.5 (note this is the annual interest rate and we require a monthly repayment figure)
Term years = 23
Term months = 7
The resulting monthly repayment = 832.33
Total to be repaid = 235549.39
 
2) Given the following inputs:
Loan amount =  290000
Annual Interest rate = 7.5 (note this is the annual interest rate and we require a monthly repayment figure)
Term years = 15
Term months = 6
The resulting monthly repayment = 2641.50
Total to be repaid = 491319.00
 
3) Given the following inputs:
Loan amount =  290000
Annual Interest rate = 7.5 (note this is the annual interest rate and we require a monthly repayment figure)
Term years = 0
Term months = 0
This should cause an error to occur in the calculation which must be trapped and displayed to the user in a friendly manner
