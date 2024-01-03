create database EmpDeptDb
use EmpDeptDb

create table Department
(DepCode int primary key,
DepName nvarchar(50) not null,
)

insert into Department (DepCode, DepName)
values
    (1, 'Delivery'),
    (2, 'Advertise'),
    (3, 'Auditor'),
    (4, 'IT')
create table  Employee 
(
    EmpCode int primary key,
    EmpName nvarchar(50) NOT NULL,
    Email nvarchar(100) NOT NULL,
    DateOfBirth datetime NOT NULL,
    Department_Code int,
)

insert into Employee(EmpCode, EmpName, Email, DateOfBirth, Department_Code)
values
(1, 'Sudhakar', 'sudhakar@gmail.com', '05-05-2000', 1),
(2, 'Ram', 'Ram@gmail.com', '09-11-2000', 2),
(3, 'luffy', 'luffy@Duckgo.com', '05-09-1993', 3),
(4, 'randy orton', 'randy@outlook.com', '07-03-1990', 4) 



select * from Department
select * from Employee