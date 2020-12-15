<dl>
  <dt>Exercise 3</dt>

  <dt>Project Instructions:</dt>
  <dd>1. Open SQL Server Management Studio and then click new query or Ctrl+N to open up a blank query window.
2. Create a database of your own choosing that consists of two tables.
3. Assign primary keys to each table.
4. Assign a foreign key to one table.
5. Create at least two columns in each table.
6. Add values to your database. Ensure that at least one of these values match up between both databases.
7. Create a statement that queries data from both tables. Ensure this query includes two records (rows) that share an attribute (column) in common.
</dd>

<dt>Code:</dt>
<dd>
Assignment_1

USE [db_zoo]

SELECT *
FROM tbl_habitat

Assignment_2

USE [db_zoo]

SELECT *
FROM tbl_species
WHERE species_order = 3

Assignment_3

USE [db_zoo]

SELECT *
FROM tbl_nutrition
WHERE nutrition_cost < 600.00 

Assignment_4

USE [db_zoo]

SELECT *
FROM tbl_species
WHERE species_nutrition BETWEEN 2202 AND 2206

Assignment_5

USE [db_zoo]

SELECT species_name AS 'Species Name:', species_nutrition AS 'Nutrition Type:'
FROM tbl_species

Assignment_6

SELECT tbl_specialist.specialist_fname, tbl_specialist.specialist_lname, tbl_specialist.specialist_contact, tbl_species.species_name
FROM tbl_specialist
Inner Join tbl_care ON tbl_care.care_specialist = tbl_specialist.specialist_ID
Inner Join tbl_species ON tbl_care.care_id = tbl_species.species_care
WHERE species_name = 'penguin'

Assignment_7

CREATE DATABASE NSD
USE NSD

CREATE TABLE tbl_Exterior_Feature(
		Feature_ID INT PRIMARY KEY NOT NULL IDENTITY (100,1),
		#_Doors VARCHAR(50) NOT NULL,
		Exterior_Color VARCHAR(50) NOT NULL
	);

	INSERT INTO tbl_Exterior_Feature
		(#_Doors, Exterior_Color)
		VALUES	
		(4, 'Red'),
		(2, 'Blue'),
		(4, 'Rust Red'),
		(4, 'Gray'),
		(2, 'Black'),
		(3, 'Red')
	;
	
SELECT * 
FROM tbl_Exterior_Feature

CREATE TABLE tbl_Interior_Feature(
		Feature_ID INT PRIMARY KEY NOT NULL IDENTITY (10,1),
		#_Seats VARCHAR(50) NOT NULL,
		Interior_Color VARCHAR(50) NOT NULL
	);


	INSERT INTO tbl_Interior_Feature
		(#_Seats, Interior_Color)
		VALUES	
		(5, 'Black'),
		(4, 'Gray'),
		(5, 'Black'),
		(6, 'Gray'),
		(2, 'Black'),
		(5, 'Gray')
	;
	
SELECT * 
FROM tbl_Interior_Feature

CREATE TABLE tbl_Cars(
		Vehicle_id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
		Model_type VARCHAR(50) NOT NULL,
		Manufacturer VARCHAR(50) NOT NULL,
		Vehicle_Exterior_Feature_Ref INT NOT NULL CONSTRAINT fk_Exterior_Feature_ID FOREIGN KEY REFERENCES tbl_Exterior_Feature(Feature_ID) ON UPDATE CASCADE ON DELETE CASCADE, 
		Vehicle_Interior_Feature_Ref INT NOT NULL CONSTRAINT fk_Interior_Feature_ID FOREIGN KEY REFERENCES tbl_Interior_Feature(Feature_ID) ON UPDATE CASCADE ON DELETE CASCADE
	);


	INSERT INTO tbl_Cars
		(Model_type, Manufacturer, Vehicle_Exterior_Feature_Ref, Vehicle_Interior_Feature_Ref)
		VALUES	
		('Sierra', 'GMC',100,10),
		('Focus', 'Ford',101,11),
		('Cruz', 'Chevy',102,12),
		('Outback', 'Subaru',103,13),
		('Silverado', 'Chevy',104,14),
		('Country Man', 'Mini',105,15)
	;

SELECT * 
FROM tbl_Cars


SELECT tbl_Cars.*, tbl_Exterior_Feature.*, tbl_Interior_Feature.*
FROM tbl_Cars
Inner Join tbl_Exterior_Feature ON tbl_Exterior_Feature.Feature_ID = tbl_Cars.Vehicle_Exterior_Feature_Ref
Inner Join tbl_Interior_Feature ON tbl_Interior_Feature.Feature_ID = tbl_Cars.Vehicle_Interior_Feature_Ref
WHERE Model_type = 'Sierra'
</dd>
</dl>