drop database if exists management;
create database management;
use management;

create table employees (
	id INT NOT NULL auto_increment,
	firstName VARCHAR(50),
	lastName VARCHAR(50),
    deleted bool default false,
    PRIMARY KEY (id)
);

create table tasks (
	id int NOT NULL auto_increment,
    name VARCHAR(50),
    time int,
    deleted bool default false,
    PRIMARY KEY (id)
);

create table employee_task (
	id int NOT NULL auto_increment,
    employeeId int,
    taskId int,
    deleted bool default false,
    PRIMARY KEY (id)
);


insert into employees (id, firstName, lastName, deleted) values (1, 'Arturo', 'Dunnet', true);
insert into employees (id, firstName, lastName, deleted) values (2, 'Cazzie', 'Gaskall', true);
insert into employees (id, firstName, lastName, deleted) values (3, 'Sibylla', 'Harwin', true);
insert into employees (id, firstName, lastName, deleted) values (4, 'Gardy', 'Artis', false);
insert into employees (id, firstName, lastName, deleted) values (5, 'Henry', 'Palffrey', false);
insert into employees (id, firstName, lastName, deleted) values (6, 'Dorthea', 'Kenny', true);
insert into employees (id, firstName, lastName, deleted) values (7, 'Rod', 'Sutty', true);
insert into employees (id, firstName, lastName, deleted) values (8, 'Elia', 'Held', false);

insert into tasks (id, name, time, deleted) values (1, 'UK Law', 5, true);
insert into tasks (id, name, time, deleted) values (2, 'Customer Support', 5, false);
insert into tasks (id, name, time, deleted) values (3, 'ATM Networks', 4, true);
insert into tasks (id, name, time, deleted) values (4, 'Teeth Whitening', 3, true);
insert into tasks (id, name, time, deleted) values (5, 'Marketing', 2, true);
insert into tasks (id, name, time, deleted) values (6, 'iWork', 4, false);
insert into tasks (id, name, time, deleted) values (7, 'CEO/CFO Certification', 5, true);
insert into tasks (id, name, time, deleted) values (8, 'Waste', 3, true);
insert into tasks (id, name, time, deleted) values (9, 'Hydraulic Fracturing', 1, false);
insert into tasks (id, name, time, deleted) values (10, 'Gmail', 5, false);
insert into tasks (id, name, time, deleted) values (11, 'CFOs', 1, true);
insert into tasks (id, name, time, deleted) values (12, 'SAP MDM', 1, true);
insert into tasks (id, name, time, deleted) values (13, 'CNS disorders', 1, true);
insert into tasks (id, name, time, deleted) values (14, 'Strategy', 1, false);
insert into tasks (id, name, time, deleted) values (15, 'Trading', 3, false);
insert into tasks (id, name, time, deleted) values (16, 'PgSQL', 3, true);
insert into tasks (id, name, time, deleted) values (17, 'BPF', 1, false);
insert into tasks (id, name, time, deleted) values (18, 'eHealth', 4, true);
insert into tasks (id, name, time, deleted) values (19, 'Alternative Energy', 2, false);
insert into tasks (id, name, time, deleted) values (20, 'Creative Non-fiction', 4, true);
insert into tasks (id, name, time, deleted) values (21, 'HBDI', 2, false);
insert into tasks (id, name, time, deleted) values (22, '10 Key', 2, true);
insert into tasks (id, name, time, deleted) values (23, 'Otology', 4, false);
insert into tasks (id, name, time, deleted) values (24, 'ODM', 5, false);
insert into tasks (id, name, time, deleted) values (25, 'YMS', 4, false);
insert into tasks (id, name, time, deleted) values (26, 'Tourism Management', 4, true);
insert into tasks (id, name, time, deleted) values (27, 'DNA Extraction', 1, true);
insert into tasks (id, name, time, deleted) values (28, 'GNMA', 3, false);
insert into tasks (id, name, time, deleted) values (29, 'QPS', 1, false);
insert into tasks (id, name, time, deleted) values (30, 'Two-factor Authentication', 4, false);
insert into tasks (id, name, time, deleted) values (31, 'Urdu', 4, false);
insert into tasks (id, name, time, deleted) values (32, 'OLTP', 4, true);
insert into tasks (id, name, time, deleted) values (33, 'Interviewing Skills', 2, true);
insert into tasks (id, name, time, deleted) values (34, 'SAP Business ByDesign', 2, true);
insert into tasks (id, name, time, deleted) values (35, 'Flooring', 3, false);
insert into tasks (id, name, time, deleted) values (36, 'Working Capital Management', 2, true);
insert into tasks (id, name, time, deleted) values (37, 'EBSD', 5, false);
insert into tasks (id, name, time, deleted) values (38, 'FI-AA', 1, false);
insert into tasks (id, name, time, deleted) values (39, 'IT Management', 2, true);
insert into tasks (id, name, time, deleted) values (40, 'eGaming', 4, false);
insert into tasks (id, name, time, deleted) values (41, 'GGY Axis', 4, true);
insert into tasks (id, name, time, deleted) values (42, 'Life Insurance', 3, true);
insert into tasks (id, name, time, deleted) values (43, 'Mythology', 1, false);
insert into tasks (id, name, time, deleted) values (44, 'CBP', 4, true);
insert into tasks (id, name, time, deleted) values (45, 'Start-up Consulting', 3, true);
insert into tasks (id, name, time, deleted) values (46, 'Ultrafiltration', 5, true);
insert into tasks (id, name, time, deleted) values (47, 'Aquaculture', 3, true);
insert into tasks (id, name, time, deleted) values (48, 'QSE', 3, false);
insert into tasks (id, name, time, deleted) values (49, 'FQL', 5, true);
insert into tasks (id, name, time, deleted) values (50, 'Hatha Yoga', 2, false);

INSERT INTO employee_task (id, taskId, employeeId) VALUES (NULL, 1, 1);
INSERT INTO employee_task (id, taskId, employeeId) VALUES (NULL, 2, 1);
INSERT INTO employee_task (id, taskId, employeeId) VALUES (NULL, 3, 2);
INSERT INTO employee_task (id, taskId, employeeId) VALUES (NULL, 4, 2);
INSERT INTO employee_task (id, taskId, employeeId) VALUES (NULL, 3, 2);
INSERT INTO employee_task (id, taskId, employeeId) VALUES (NULL, 5, 3);
INSERT INTO employee_task (id, taskId, employeeId) VALUES (NULL, 6, 5);