## Генерируем линейный массив


```
procedure gen_line_mas(params1: array of integer; params2:integer);
var t:integer;
begin
    for t:= 1 to params2 do
    begin
        params1[t]:= random(100)-50;
        write(params1[t]:4);
    end;
end;
```
## Сортировки
### Сортировка выбором по уменьшению
```procedure vibor(params1:integer);
var i,k,min:integer;
begin
  for i:= 1 to params1-1 do
  begin
    min:=a[i]; p:=i;
    for k:=i+1 to params1 do
      if a[k]>min then begin min:= a[k]; p:= k; end;
      a[p]:=a[i]; a[i]:= min;
  end;
end;
```
### Сортировка выбором по возростанию
```procedure vibor(params1:integer);
var i,k,min:integer;
begin
  for i:= 1 to params1-1 do
  begin
    min:=a[i]; p:=i;
    for k:=i+1 to params1 do
      if a[k]<min then begin min:= a[k]; p:= k; end;
      a[p]:=a[i]; a[i]:= min;
  end;
end;
```
