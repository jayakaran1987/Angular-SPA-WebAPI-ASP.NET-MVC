#Single Page Application (SPA) with ASP.NET Web API and Angular.js (Partial Views)

This single page web application that will perform a simple mortgage repayment calculation. The Application uses the following technologies

 1. AngularJS for the front end, making use of partials and AJAX calls.
 2. Server side should use ASP.Net MVC and Web Api
 3. The calculations on server side and returned to the front end.
 4. AJAX must be used to call the server
 5. Making use of the normal MVC layers


On loading the page in a browser it should only display 4 fields and a button (a bonus would be to have these fields contained in an AngularJS partial). The fields will accept entry of a loan amount, the term of the mortgage in years and months and the annual interest rate.
Client side validation:
Entry of all fields is mandatory
The months fields should only allow entry of a value between 0 and 11.
Loan amount must be > 0
Interest rate must be > 0
Loan term years must be >= 0
 
On clicking a button below the form the page should then display a new section at the bottom (of the same page) with fields containing the monthly repayment and the total amount that would be paid over the lifetime of the mortgage, both shown to 2 decimal places.
 
 
Acceptance Testing criteria
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



