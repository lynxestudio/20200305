# Operaciones Bitwise (a nivel de bits) con C#

<p align="justify">Además de los operadores condicionales lógicos y de relación C# cuenta con operadores a nivel de bits (bitwise operators o logical operators) que permiten realizar operaciones con las representaciones binarias de las variables que internamente utiliza la computadora, esto es útil en ciertos casos donde se requiere interactuar directamente con el hardware o utilizar  una variable entera como un arreglo de bits donde por ejemplo un tipo short representaría un arreglo de bits con una longitud de 16 valores y cada bit podría ser utilizado como si fuera un valor booleano 1 igual true y 0 igual a false.
    </p>
    <p align="justify">
    Los tipos de datos donde usualmente aplican estos operadores son: los numéricos y las enumeraciones.
    </p>
    <p align="justify">
    La siguiente tabla muestra los tipos numéricos, su longitud en bytes y su valor en decimal.</p>
    <div>
        <img src="images/tabla1.png" />
</div><br />
    <p align="justify">
        Así por ejemplo si tenemos valores decimales representados en variables byte  (8 bits hasta 255 en decimal)
        <br /><br />byte a = 22;
        <br />byte b = 33;
        <br /><br />
        Internamente su representación en binario es:
        <br /><br />22 = 00010110
        <br />33 = 00100001<br /><br />
        si utilizamos variables de tipo short (16 bits hasta 65,535) <br /><br />
        short c = 54;<br />
        short d = 22;<br /><br />
        su representación en binario es:<br />
        <br />54  = 110110<br />
        22 = 10110<br /><br />
        Así con cada tipo numérico siempre agrupando las cadenas de bits de 8 en 8.<br />La siguiente tabla muestra los operadores bitwise, su significado y su resultado.<br />
    </p>
    <div>
        <img src="images/tabla2.png" />
</div>
<br />
    <div>Al ejecutarlo veremos los siguientes resultados:</div><br />
<div>
		    <img src="images/fig1.png" />
</div><br />
    <div>
<img src="images/fig2.png" />
</div><br />
    <div>
<img src="images/fig3.png" />
</div><br />
    <div>
<img src="images/fig4.png" />
</div><br />
