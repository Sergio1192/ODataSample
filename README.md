# Ejemplo usando OData

Podemos observar dos maneras distintas de usar OData, de una manera distinta a la tracional, pero puede, incluso, mas útil.

1. Obtiendo el objeto para aplicar OData y usandolo directamnete sobre nuestros datos (funciona llamando a una BBDD directamente).
2. Con el atributo: Aplicando OData al terminar de realizar nuestra función.

Tiene gran interes la primera opción por la gran potencia y flexibilidad que ofrece.

Tambien creamos un atributo personalizado para incluir la cabecera *count* si no viene, pero si nos indican un *top* o *skip*
