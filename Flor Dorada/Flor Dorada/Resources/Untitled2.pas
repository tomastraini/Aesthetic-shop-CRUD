program empresas;

var
empresa: Array[1..200] of string;

psw1: string;
con1: integer;
menuop: integer;

procedure visoremp();
  begin
  empresa[1] := ('Numero de empresa  Empresa  Domicilio  Telefono');
  writeln(empresa[1]);
  end;
  

  procedure menu();
  Begin

    Writeln();
    writeln('Bienvenido al menú principal!');
    writeln;
    writeln('1- Cargar empresas');
    writeln('2- Visualizar empresas cargadas');
    readln(menuop);
    while (menuop < 1) and (menuop > 2) do
     Begin

     writeln('Esa opción no existe!');
     writeln;
     writeln('Bienvenido al menú principal!');
     writeln;
     writeln('1- Cargar empresas');
     writeln('2- Visualizar empresas cargadas');
     readln(menuop);
     end;
    case menuop of
    1:
      begin

      end;
    2:
      begin
        visoremp();
      end;
     end;
  end;
  procedure login();
  begin
  writeln('Ingrese una contraseña: ');
  readln(psw1);
  con1 := 1;
  while(con1 < 3) and (psw1 <> '123') do
    Begin
      writeln('Ingrese una contraseña: ');
      readln(psw1);
      con1 := con1 + 1;
    end;
  if (psw1 <> '123') and (con1 >=3) then
    begin
      writeln('Mal!');
      halt;
    end
  else
    menu()
  end;
begin
  login();

end.
