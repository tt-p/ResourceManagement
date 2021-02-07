delimiter //

/* Item */

CREATE PROCEDURE SelectAllItems ()
BEGIN
	SELECT
		Item_Id,
		Item_Name,
        Catagory
	FROM
		item
	WHERE
		IsActive = 1
	;
END//

CREATE PROCEDURE SelectAllItemNames ()
BEGIN
	SELECT
		Item_Id,
		Item_Name
	FROM
		item
	WHERE
		IsActive = 1        
	;
END//

CREATE PROCEDURE ItemViewById (
_ItemId INT
)
BEGIN
	SELECT
		*
	FROM
		item
	WHERE
		Item_Id = _ItemId
	;
END//

CREATE PROCEDURE ItemDeleteById (
_ItemId INT
)
BEGIN
	UPDATE
		item
	SET
		IsActive = 0
	WHERE
		Item_Id = _ItemId
	;
END//

CREATE PROCEDURE ItemInsert (
_ItemId INT,
_ItemName VARCHAR(40),
_Catagory VARCHAR(20)
)
BEGIN
	INSERT INTO item (Item_Id, Item_Name, Catagory)
	VALUES (_ItemId, _ItemName, _Catagory);
END//

CREATE PROCEDURE ItemInsertOrUpdate (
_ItemId INT,
_ItemName VARCHAR(40),
_Catagory VARCHAR(40)
)
BEGIN
	IF _ItemId = 0 THEN
		INSERT INTO item (Item_Name, Catagory)
        VALUES (_ItemName, _Catagory);
	ELSE
		UPDATE
			item
        SET
			Item_Name = _ItemName,
            Catagory = _Catagory
		WHERE
			Item_Id = _ItemId;
	END IF;
END//

CREATE PROCEDURE ItemFilterByNameOrCatagory (
_SearchValue VARCHAR(20)
)
BEGIN
	SELECT
		Item_Id,
		Item_Name,
        Catagory
	FROM
		item
	WHERE 
		IsActive = 1 AND
		(Item_Name LIKE CONCAT("%",_SearchValue,"%")
        OR
        Catagory LIKE CONCAT("%",_SearchValue,"%"))
    ;
END//

/* Item Attribute */

CREATE PROCEDURE SelectItemAttributesByItemId (
_ItemId INT
)
BEGIN
	SELECT
		Attribute,
        Att_Value
	FROM
		item_attribute
	WHERE
		Item_Id = _ItemId
	;
END//

CREATE PROCEDURE InsertItemAttribute (
_ItemId INT,
_Attribute VARCHAR(30),
_AttValue VARCHAR(30)
)
BEGIN
	INSERT INTO item_attribute (Item_Id, Attribute, Att_Value)
    VALUES (_ItemId, _Attribute, _AttValue);
END//

CREATE PROCEDURE ItemAttributesDeleteByItemId (
_ItemId INT
)
BEGIN
	DELETE FROM item_attribute 
    WHERE
		Item_Id = _ItemId
    ;
END//

/* Depot */

CREATE PROCEDURE SelectAllDepots ()
BEGIN
	SELECT
		Depot_Id,
		Depot_Name,
        Size,
        Occupancy,
        Address
	FROM
		depot
	WHERE
		IsActive = 1
	;
END//

CREATE PROCEDURE SelectAllDepotNames ()
BEGIN
	SELECT
		Depot_Id,
		Depot_Name
	FROM
		depot
	WHERE
		IsActive = 1
	;
END//

CREATE PROCEDURE DepotViewById (
_DepotId INT
)
BEGIN
	SELECT
		*
	FROM
		depot
	WHERE
		Depot_Id = _DepotId
	;
END//

CREATE PROCEDURE DepotDeleteById (
_DepotId INT
)
BEGIN
	UPDATE
		depot
	SET
		IsActive = 0
	WHERE
		Depot_Id = _DepotId
	;
END//

CREATE PROCEDURE DepotInsertOrUpdate (
_DepotId INT,
_DepotName VARCHAR(40),
_Size ENUM('SMALL','MEDIUM','LARGE'),
_Occupancy SMALLINT,
_Address TINYTEXT
)
BEGIN
	IF _DepotId = 0 THEN
		INSERT INTO depot (Depot_Name, Size, Occupancy, Address)
        VALUES (_DepotName, _Size, _Occupancy, _Address);
	ELSE
		UPDATE
			depot
        SET
			Depot_Name = _DepotName,
            Size = _Size,
            Occupancy = _Occupancy,
            Address = _Address
		WHERE
			Depot_Id = _DepotId;
	END IF;
END//

CREATE PROCEDURE DepotFilterByName (
_SearchValue VARCHAR(20)
)
BEGIN
	SELECT
		Depot_Id,
		Depot_Name,
        Size,
        Occupancy,
        Address
	FROM
		depot
	WHERE 
		IsActive = 1
        AND
		Depot_Name LIKE CONCAT("%",_SearchValue,"%")
    ;
END//

/* Stock */

CREATE PROCEDURE SelectAllStocks ()
BEGIN
	SELECT
        d.Depot_Name,
        i.Item_Name,
        s.Quantity
	FROM 
		stock s
	JOIN
		item i
			ON s.Item_Id = i.Item_Id
	JOIN
		depot d
			ON s.Depot_Id = d.Depot_Id
	;
END//

CREATE PROCEDURE SelectStocksByDepotId (
_DepotId INT 
)
BEGIN
	SELECT
        d.Depot_Name,
        i.Item_Name,
        s.Quantity
	FROM 
		stock s
	JOIN
		item i
			ON s.Item_Id = i.Item_Id
	JOIN
		depot d
			ON s.Depot_Id = d.Depot_Id
	WHERE
		s.Depot_Id = _DepotId
	;
END//

CREATE PROCEDURE SelectStocksByItemId (
_ItemId INT 
)
BEGIN
	SELECT
        d.Depot_Name,
        i.Item_Name,
        s.Quantity
	FROM 
		stock s
	JOIN
		item i
			ON s.Item_Id = i.Item_Id
	JOIN
		depot d
			ON s.Depot_Id = d.Depot_Id
	WHERE
		s.Item_Id = _ItemId
	;
END//

CREATE PROCEDURE StockInsertOrUpdate (
_DepotId INT,
_ItemId INT,
_Quantity INT UNSIGNED
)
BEGIN
	INSERT INTO stock (Depot_Id, Item_Id, Quantity)
	VALUES (_DepotId, _ItemId, _Quantity)
    ON DUPLICATE KEY UPDATE Quantity = _Quantity;
END//

/* Log */

CREATE PROCEDURE SelectAllDepotLogs ()
BEGIN
	SELECT
		d_l.Log_Id,
        d_l.Depot_Id,
        d_l.Item_Id,
        d.Depot_Name,
        i.Item_Name,
        d_l.Quantity,
        d_l.Log_Type,
        d_l.Log_Date,
        d_l.Log_Desc
	FROM 
		depot_log d_l
	JOIN
		item i
			ON d_l.Item_Id = i.Item_Id
	JOIN
		depot d
			ON d_l.Depot_Id = d.Depot_Id
	;
END//

CREATE PROCEDURE SelectDepotLogsByDepotId (
_DepotId INT 
)
BEGIN
	SELECT
		d_l.Log_Id,
		d_l.Depot_Id,
        d_l.Item_Id,
        d.Depot_Name,
        i.Item_Name,
        d_l.Quantity,
        d_l.Log_Type,
        d_l.Log_Date,
        d_l.Log_Desc
	FROM 
		depot_log d_l
	JOIN
		item i
			ON d_l.Item_Id = i.Item_Id
	JOIN
		depot d
			ON d_l.Depot_Id = d.Depot_Id
	WHERE
		d_l.Depot_Id = _DepotId
	;
END//

CREATE PROCEDURE DepotLogInsert (
_DepotId INT,
_ItemId INT,
_LogType ENUM('ENTRY','EXIT'),
_Quantity INT UNSIGNED
)
BEGIN
	INSERT INTO depot_log
	(Depot_Id, Item_Id, Log_Date, Log_Type, Quantity, Log_Desc) 
	VALUES
	(_DepotId, _ItemId, NOW(), _LogType, _Quantity, "** Auto Description");
END//

CREATE PROCEDURE DepotLogUpdate (
_LogId INT,
_LogDesc TINYTEXT
)
BEGIN
	UPDATE
		depot_log
	SET
		Log_Desc = _LogDesc
	WHERE
		Log_Id = _LogId;
END//

 /* Order */

CREATE PROCEDURE SelectAllItemOrders ()
BEGIN
	SELECT
		i_o.Item_Order_Id,
        ioi.Item_Id,
		iot.Depot_Id,
        iof.Supplier_Id,
		i.Item_Name,
		ioi.Quantity,
		d.Depot_Name,
		s.Supplier_Name,
		i_o.Order_Date,
		i_o.Ship_Date,
		i_o.Order_Status,
		i_o.Price
	FROM 
		item_order i_o
	JOIN 
		item_order_in ioi
			ON i_o.Item_Order_Id = ioi.Item_Order_Id
	JOIN 
		item_order_to iot
			ON i_o.Item_Order_Id = iot.Item_Order_Id
	JOIN 
		item_order_from iof
			ON i_o.Item_Order_Id = iof.Item_Order_Id
	JOIN 
		item i
			ON ioi.Item_Id = i.Item_Id
	JOIN
		depot d
			ON iot.Depot_Id = d.Depot_Id
	JOIN
		supplier s
			ON iof.Supplier_Id = s.Supplier_Id
	;
END//