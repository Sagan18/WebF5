He editado el web.config para poner como página de inicio la sgte:http://localhost:63038/Imagenes/Create. 
Como tabla he ejecutado el sgte script:
USE master
CREATE TABLE [dbo].Imagenes (
    id INT  PRIMARY KEY,
    imagen VARCHAR(255),
    titulo VARCHAR(255)
);
Perdón por no habrlo incluido
