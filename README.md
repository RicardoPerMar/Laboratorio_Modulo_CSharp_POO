# Laboratorio_Modulo_CSharp_POO

1 - Read Books

Crea una funci�n isBookRead que reciba una lista de libros y un t�tulo y devuelva si se ha le�do o no dicho libro. 
Un libro es un objeto con title como string y isRead como booleano. En caso de no existir el libro devolver false.

2 - Slot Machine

El objetivo de este ejercicio es crear una m�quina tragaperras utilizando clases donde cada vez que juguemos insertemos una moneda.
Cada m�quina tragaperras (instancia) tendr� un contador de monedas que autom�ticamente se ir� incrementando conforme vayamos jugando.

Cuando se llame al m�todo play el n�mero de monedas se debe incrementar de forma autom�tica y debe generar tres booleanos aleatorios que representar�n el estado de las 3 ruletas. 
El usuario habr� ganado en caso de que los tres booleanos sean true, y por tanto deber� mostrarse por consola el mensaje:

- "Congratulations!!!. You won "n�mero de monedas" coins!!";

y reiniciar las monedas almacenadas, ya que las hemos conseguido y han salido de la m�quina. En caso contrario deber� mostrar otro mensaje:

- "Good luck next time!!".

Se preguntar� al usuario si quiere jugar o dejar.

- Si el usuario elige jugar. Se llamar� al m�todo play.
- Si usuario elige cualquier otra opci�n se terminar� la ejecuci�n de la aplicaci�n.