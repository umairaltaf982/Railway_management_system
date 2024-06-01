ALTER TABLE TrainSchedule 
  MODIFY train_id VARCHAR2(255) NOT NULL

Update TrainSchedule 
set train_id = null;

select * from administrator

CREATE TABLE TrainSchedule (
    train_name VARCHAR2(100),
    destination VARCHAR2(100),
    arrival VARCHAR2(100),
    type VARCHAR2(50),
    dest_time VARCHAR2(100),
    arrival_time VARCHAR2(100),
    announcements VARCHAR2(200)
);

INSERT INTO TrainSchedule (train_name, destination, arrival, type, dest_time, arrival_time, announcements) 
VALUES 
('Express 101', 'Lahore', '2024-04-28', 'Express', '08:00 AM', '10:30 AM', 'No announcements at this time');

INSERT INTO TrainSchedule (train_name, destination, arrival, type, dest_time, arrival_time, announcements) 
VALUES 
('Local 202', 'Faisalabad', '2024-04-28', 'Local', '09:15 AM', '11:45 AM', 'Delayed by 15 minutes due to maintenance');

INSERT INTO TrainSchedule (train_name, destination, arrival, type, dest_time, arrival_time, announcements) 


VALUES 
('Superfast 303', 'Islamabad', '2024-04-28', 'Superfast', '10:30 AM', '01:00 PM', 'On schedule');


ALTER TABLE TrainSchedule
ADD (train_id NUMBER);

UPDATE TrainSchedule
SET train_id = 3
WHERE train_name = 'Superfast 303';


ALTER TABLE TrainSchedule
ADD CONSTRAINT pk_TrainSchedule PRIMARY KEY (train_id);

