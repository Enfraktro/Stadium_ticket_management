CREATE TABLE events
(
id INT PRIMARY KEY IDENTITY(1,1),
event_id VARCHAR(MAX) NULL,
event_name VARCHAR(MAX) NULL,
type_event VARCHAR(MAX) NULL,
price float null,
capacity INT NULL,
event_image VARCHAR(MAX) NULL,
event_status VARCHAR(MAX) NULL,
created_at DATETIME NULL,
update_date DATE NULL,
delete_date DATE NULL
)
DROP TABLE events

SELECT * FROM events
SELECT *FROM users
SELECT * FROM events WHERE event_status  = 'Available' AND delete_date IS NULL



CREATE TABLE customers
(
id INT PRIMARY KEY IDENTITY(1,1),
event_id VARCHAR(MAX) NULL,
 seat_type VARCHAR(MAX) NULL,
 available_seat INT NULL, 
 totalPrice FLOAT NULL, 
foods VARCHAR(MAX) NULL,
 drinks VARCHAR(MAX) NULL,
 amount FLOAT NULL,
change FLOAT NULL,
status VARCHAR(MAX) NULL,
 date_buy DATETIME NULL
)

SELECT * FROM customers

CREATE TABLE buy_tickets
(
id INT PRIMARY KEY IDENTITY(1,1),
event_id VARCHAR(MAX) NULL,
seat_number INT NULL,
status VARCHAR(MAX) NULL,
created_at DATETIME
)

SELECT * FROM buy_tickets

SELECT*FROM events LEFT JOIN buy_tickets ON buy_tickets.event_id != events.id
SELECT capacity FROM events WHERE delete_date IS NULL and event_status != 'Deleted'
SELECT seat_number FROM buy_tickets
SELECT capacity FROM events WHERE delete_date IS NULL AND event_status != 'Deleted' AND event_id = '" + event_id + "'