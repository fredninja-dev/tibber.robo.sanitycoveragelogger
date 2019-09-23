\connect tibberrobo
CREATE TABLE IF NOT EXISTS executions (id serial PRIMARY KEY,timestamp timestamp NOT NULL default CURRENT_DATE
,commmands integer NOT NULL,result integer NOT NULL,duration NUMERIC (8, 6) NOT NULL);