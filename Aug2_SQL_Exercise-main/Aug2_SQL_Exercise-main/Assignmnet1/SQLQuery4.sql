use HMS2
go
 -- table creation for doctor
CREATE TABLE DOCTOR_MASTER (
    doctor_id VARCHAR(15) PRIMARY KEY,
    doctor_name VARCHAR(15) NOT NULL,
    dept VARCHAR(15) NOT NULL
)
go

-- data insertion for doctor master
INSERT INTO DOCTOR_MASTER (doctor_id, doctor_name, dept) VALUES
('D0001', 'Ram',    'ENT'),
('D0002', 'Rajan',  'ENT'),
('D0003', 'Smita',  'Eye'),
('D0004', 'Bhavan', 'Surgery'),
('D0005', 'Sheela', 'Surgery'),
('D0006', 'Nethra', 'Surgery');

go


-- creation of table for room master

CREATE TABLE ROOM_MASTER (
    room_no VARCHAR(15) PRIMARY KEY,
    room_type VARCHAR(15) NOT NULL,
    status VARCHAR(15) NOT NULL
)
go


-- insertion of data into room master
INSERT INTO ROOM_MASTER (room_no, room_type, status) VALUES
('R0001', 'AC',    'occupied'),
('R0002', 'Suite', 'vacant'),
('R0003', 'NonAC', 'vacant'),
('R0004', 'NonAC', 'occupied'),
('R0005', 'AC',    'vacant'),
('R0006', 'AC',    'occupied')
go

-- creation of table for patient 

CREATE TABLE PATIENT_MASTER (
    pid VARCHAR(15) PRIMARY KEY,
    name VARCHAR(15) NOT NULL,
    age NUMERIC(15) NOT NULL,
    weight NUMERIC(15) NOT NULL,
    gender VARCHAR(10) NOT NULL,
    address VARCHAR(50) NOT NULL,
    phoneno VARCHAR(10) NOT NULL,
    disease VARCHAR(50) NOT NULL,
    doctor_id VARCHAR(15) NOT NULL,
    FOREIGN KEY (doctor_id) REFERENCES DOCTOR_MASTER(doctor_id)
)
go


-- insertion of values into patient table

INSERT INTO PATIENT_MASTER (pid, name, age, weight, gender, address, phoneno, disease, doctor_id) VALUES
('P0001', 'Gita',    35, 65, 'F', 'Chennai',   '9867145678', 'Eye Infection',   'D0003'),
('P0002', 'Ashish',  40, 70, 'M', 'Delhi',     '9845675678', 'Asthma',          'D0003'),
('P0003', 'Radha',   25, 60, 'F', 'Chennai',   '9867166678', 'Pain in heart',   'D0005'),
('P0004', 'Chandra', 28, 55, 'F', 'Bangalore', '9978675677', 'Asthma',          'D0001'),
('P0005', 'Goyal',   42, 65, 'M', 'Delhi',     '8967533223', 'Pain in Stomach', 'D0004')

go


-- creation of table for room allocation

CREATE TABLE ROOM_ALLOCATION (
    room_no VARCHAR(15) NOT NULL,
    pid VARCHAR(15) NOT NULL,
    admission_date DATE NOT NULL,
    release_date DATE,
    PRIMARY KEY (room_no, pid, admission_date), -- composite key allows multiple allocations per patient-room-date
    FOREIGN KEY (room_no) REFERENCES ROOM_MASTER(room_no),
    FOREIGN KEY (pid) REFERENCES PATIENT_MASTER(pid)
)
go

-- insertion of data into room allocation 
INSERT INTO ROOM_ALLOCATION (room_no, pid, admission_date, release_date) VALUES
('R0001', 'P0001', '15-oct-16', '26-oct-16'),
('R0002', 'P0002', '15-nov-16', '26-nov-16'),
('R0002', 'P0003', '01-dec-16', '30-dec-16'),
('R0004', 'P0001', '01-jan-17', '30-jan-17')

go