# CashCounter
This Windows desktop application was designed to organize private accounting management for a couple (but the number of users might be easily incresed/descreased, although currently it is hardcoded in MainForm.cs). The main class in this piece of software is Product.cs, it is related to purchases and has the following fields:

  Id:int - product identifier
  CategoryId:int - identifier of the category this product belongs
  Name:string - product name
  Price:double - product price
  Date:DateTime - date of purchase
  Author:string - name of buyer
  
To simplify the division of the products there were designed to levels of grouping:
1) Main division (Division.cs) corresponds to the general division (like 'Food','Clothes','Health' etc)
2) Narrow division (Category.cs) corresponds to a more detailed groups (like 'Milk production','Fruits','Vegetables' etc)

This implies that each "category" belongs to one "division" (unfortunately, the naming is a bit confusing here). All the purchases and two level of groups discussed are stored in a MSSQL database (custom connectionString to be edited in DataAccessLayer/DBHelper.cs).

The application structure:
        
1) "All purchases" tab is correspondingly the main tab of this application. It has the following functions: 
      a) viewing/filtering/editing all the previous purchases
      b) adding/editting one's purchase
2) "Reports" tab allows to view some general aspects of data collected during selected periods of time. One might build either a detailed or general report (including smaller or larger groups of products). 


  
      
