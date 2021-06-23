CREATE OR REPLACE PROCEDURE change_temperature(
   id int,
   temperature int
)
language plpgsql    
as $$
begin
    update weather_forecasts 
    set temperature = temperature
    where id = id;

    commit;
end;$$