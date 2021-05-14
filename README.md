# Conseguidor-de-Classroom-v1
Se trata de un programa en C# que se conecta a tu cuenta de Classroom y te permite descargar todos los adjuntos de una tarea determinada en tu ordenador local siguiendo una serie de directivas. Más explicación en el fichero readme

El programa fue ideado para reducir el tiempo invertido en lograr descargar los archivos adjuntos a las actividades de clase remitidas mediante la plataforma Classroom que a través de su interfaz web puede ser muy lento cuando el número de alumnos es numeroso y no se pueden corregir directamente online y es obligatoria y necesaria la descarga. Algo que suele ocurrir habitualmente cuando el documento adjunto no está en formato PDF, ya que el visualizador que trae el propio Classroom para el resto de ficheros suele ser entre malo (modificando significativamente la visualización de los ficheros de los estudiantes incluso llegando al punto de que puede ser penalizado por ello) y terrible (no pudiéndose ver en absoluto una interpretación del fichero remitido por el alumno.

Para crear el programa se utiliza Classroom y  Drive como fuentes de datos, Visual Studio 2019 como Framework de trabajo y las interfaces API de las plataformas de Google como el medio de comunicación.

Importante señalar que para que esta aplicación funcione es obligatorio que se incorporen dos ficheros json con las credenciales proporcionadas para cada plataforma de Google para el profesor.
