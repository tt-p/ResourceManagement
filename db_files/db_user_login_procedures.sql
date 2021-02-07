DELIMITER //

CREATE PROCEDURE UserLogin (
_UserName VARCHAR(30),
_UserPass VARCHAR(20))
BEGIN
SELECT
		User_Type,
		User_Name,
        User_Pass
	FROM
		users
	WHERE
		User_Name = _UserName
        AND
        User_Pass = _UserPass
	;
END//