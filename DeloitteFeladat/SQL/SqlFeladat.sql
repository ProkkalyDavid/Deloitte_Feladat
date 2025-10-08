-- Task1
SELECT 
    A.Login AS Login,
    COALESCE(A.Name, B.Full_name) AS Name,
    CASE 
        WHEN A.Lastlogin >= B.LoginDate THEN A.Lastlogin
        ELSE B.LoginDate
    END AS LastLoginDate
FROM User_A AS A
INNER JOIN User_B AS B
    ON A.Login = B.Login_ID;



-- Task2
SELECT 
    COALESCE(A.Login, B.Login_ID) AS Login,
    COALESCE(A.Name, B.Full_name) AS Name,
    COALESCE(A.Lastlogin, B.LoginDate) AS LastLoginDate
FROM User_A AS A
FULL OUTER JOIN User_B AS B
    ON A.Login = B.Login_ID
WHERE A.Login IS NULL OR B.Login_ID IS NULL;
