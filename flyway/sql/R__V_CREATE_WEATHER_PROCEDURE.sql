CREATE OR REPLACE PROCEDURE change_temperature(
   i int,
   temp int
)
language plpgsql    
as $$
begin
    update weather_forecasts 
    set temperature = temp
    where id = i;
end;$$