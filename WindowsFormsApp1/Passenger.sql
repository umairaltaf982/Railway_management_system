CREATE TABLE Passenger (
  p_email_id VARCHAR(255) PRIMARY KEY,
  p_name VARCHAR(255) NOT NULL, 
  p_phone_number VARCHAR(20) NOT NULL, 
  p_password VARCHAR(255) NOT NULL, 
  p_cnic CHAR(13) UNIQUE NOT NULL, 
  p_picture BLOB 
);


INSERT INTO PASSENGER
Values ('umair@rmsdb.com','Umair Altaf','03001234567', 'umairpass','3310134823729','');

INSERT INTO PASSENGER
Values ('anas@rmsdb.com','Anas Altaf','03011234567', 'anaspass','3320134823721','');