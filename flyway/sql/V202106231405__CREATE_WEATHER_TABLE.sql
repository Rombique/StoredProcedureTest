CREATE TABLE IF NOT EXISTS weather_forecasts (
	id serial PRIMARY KEY,
	weather_date TIMESTAMP,
	temperature INT,
	summary VARCHAR (255)
);

INSERT INTO weather_forecasts (weather_date, temperature, summary) VALUES
	(current_timestamp, 35, 'Hot');
	
INSERT INTO weather_forecasts (weather_date, temperature, summary) VALUES
	(current_timestamp + interval '1' day, 32, 'Sweltering');
	
INSERT INTO weather_forecasts (weather_date, temperature, summary) VALUES
	(current_timestamp + interval '2' day, 28, 'Warm');
	
INSERT INTO weather_forecasts (weather_date, temperature, summary) VALUES
	(current_timestamp + interval '3' day, 37, 'Scorching');
	
INSERT INTO weather_forecasts (weather_date, temperature, summary) VALUES
	(current_timestamp + interval '4' day, 36, 'Scorching');


