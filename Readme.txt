Este proyecto fue diseñado por Bryan Rivera como reto de postulacion para el puesto de desarrollador .Net de la empresa WebControl Systems

Distribucion de proyectos
1.- Contamos con el proyecto llamado API que implementa un Rest Service para el mantenimiento de usuarios, en este proyecto registramos los distintos servicios
	utilizados dentro de la aplicacion.
	Nota: Antes de ejecutar el proyecto debemos de cambiar la cadena de conexion en el archivo appsettings.json de la siguiente manera
	"Integrated Security=SSPI;Persist Security Info=True;Initial Catalog=WCUsers;Data Source=[Ingresar aqui el parametro de conexion a su base de datos]"

2.- Proyecto Data, en este proyecto guardamos los archivos de migracion, asi como el db Context que utiliza entity frameowkr para los commands y querys, ademas contamos 
	con las carpetas de Interfaces y Persistencia, donde se guardan las interfaces de los repositorios y servicios como tambien sus implementaciones.

3.- Proyecto Front ASP, en este proyecto implementamos una Web en ASP.Net version 6 utilizando HTML, CSS, JS , Jquery y Bootstrap, las informacion sera manejada
	a traves de clientes nombrados configurados en HTTP Client Factory, es una web clasica, las validaciones se realizan en el cliente apoyandonos en los Data Anotations.

4.- Proyecto Front Blazor, al igual que en el proyecto anterior este proyecto implementa una web pero esta vez sera una web de tipo SPA, con componentes reactivos, ademas
	que a diferencia del proyecto anterior donde trabajamos todo con HTML y Bootstrap, aqui utilizaremos una libreria de componentes para variar, en este caso utilizamos
	la libreria de radzen y las validaciones la hacemos a traves de componentes.

5.- HTTPClienteData este proyecto es una biblioteca de clases compartida entre los proyectos FrontASP y FrontBlazor que con tiene los clientes para la conexion con el API,
	hacemos uso de HTTPClientFactory para un manejo correcto de las peticiones HTTP ademas de utilizar clientes nombrados a traves de interfaces.

6.- Shared es una biblioteca de clases compartida donde almacenamos los DTO's utilizados en la aplicacion.


Notas:
	- Contamos con seeds para migrar la informacion de los Departamentos y Provincias a la base de datos, estos se guardan en Data/Seed
	- Es Necesario configurar la cadena de conexion antes de iniciar el proyecto para que se puedan ejecutar todas las migraciones.