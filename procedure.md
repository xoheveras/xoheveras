## Генерируем линейный массив

procedure gen_line_mas(params1: array of integer; params2:integer);
var t:integer;
begin
    for t:= 1 to params2 do
    begin
        params1[t]:= random(100)-50;
        write(params1[t]:4);
    end;
end;
