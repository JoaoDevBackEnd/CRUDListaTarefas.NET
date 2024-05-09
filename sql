create table USERS(
	id SERIAL primary key,
	name varchar(40)not null,
	password varchar(255) not null
);
drop table users
drop table Task;
SELECT * FROM users;

create  table Task(
	id SERIAL primary key,
	userId SERIAL not null references USERS(id),
	title varchar(255) not null,
	status varchar(1) NOT NULL
);
create  table Datas(
	id SERIAL primary key,
	taskId SERIAL not null references Task(id),
	dataTask DATE not null,
	horaTask Time not null
);
create  table ListTask(
	id SERIAL primary key,
	taskId SERIAL not null references Task(id),
	status varchar(1) not null,
	descriptionTask varchar(255) not null
); 

select * from users;
