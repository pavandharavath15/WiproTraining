use HMS2
go

select * from DOCTOR_MASTER
go

select * from PATIENT_MASTER
go

select * from ROOM_ALLOCATION
go

select * from ROOM_MASTER
go


-- query 1 
-- display the patients who were admitted in the month of january 

select pid from ROOM_ALLOCATION
where MONTH(admission_date)=1;
go

--display the female patient who is not suffering from asthma

select pid,name from PATIENT_MASTER
where gender='F' and disease!='Asthma'

go

-- count the number of male and female patients 

select gender, count(*) as patient_count from PATIENT_MASTER
group by gender 
go


--query #5 display the room_no which was never allocated to any patient


select room_no from ROOM_ALLOCATION
where room_no NOT IN(select room_no from ROOM_ALLOCATION where room_no is NOT NULL)
go

