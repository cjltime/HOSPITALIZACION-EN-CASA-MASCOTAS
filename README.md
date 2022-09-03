# HOSPITALIZACION-EN-CASA-MASCOTAS

Antes de iniciar el proyecto realizar esta instalacion del dotnet 

dotnet tool install --global dotnet-ef --version 5.0.9

Dentro de la carpeta PetCare.App.Persistencia realizar la integracion con la base de datos:

dotnet ef database update --startup-project ..\PetCare.App.Consola\
