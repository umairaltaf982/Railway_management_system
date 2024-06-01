-- Creating Admin Table
CREATE TABLE ADMINISTRATOR(
  a_email_id VARCHAR(255) PRIMARY KEY NOT NULL,
  a_password VARCHAR(255) NOT NULL
);


INSERT INTO ADMINISTRATOR 
Values ('umair@rmsdb.com', 'umairadmin');

INSERT INTO ADMINISTRATOR 
Values ('anas@rmsdb.com', 'anasadmin');

