<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adivina.aspx.cs" Inherits="Adivina.Adivina" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<link href="Estilos.css" rel="stylesheet" />
<head runat="server">
 <title>Adivina el Número</title>
   
</head>

<body>
  <form id="form1" runat="server">
    <h1>¡Adivina el Número!</h1>
    <p>Estoy pensando en un número entre 1 y 10. ¿Puedes adivinar cuál es?</p>
    <asp:TextBox ID="guessInput" runat="server"></asp:TextBox>
    <asp:Button ID="guessButton" runat="server" Text="Adivinar" OnClick="GuessNumber" />
    <asp:Button ID="newNumberButton" runat="server" Text="Nuevo Número" OnClick="NewNumber" />
    <div id="result" runat="server"></div>
</form>
    <script>
        // JavaScript para la lógica del juego en el lado del cliente
        function guessNumber() {
            var guess = document.getElementById("guessInput").Text;
            // Lógica de comunicación con el servidor para verificar la suposición
            // Aquí podrías utilizar AJAX para enviar la suposición al servidor y obtener la respuesta
        }

        function newNumber() {
            // Generar un nuevo número aleatorio entre 1 y 10
            var randomNumber = Math.floor(Math.random() * 10) + 1;

            // Limpiar el campo de entrada
            document.getElementById("guessInput").value = "";

            // Limpiar el área de resultado
            document.getElementById("result").innerText = "";

            // Habilitar el botón "Adivinar" si estaba deshabilitado
            document.getElementById("btnGuess").disabled = false;

            // Actualizar el número objetivo guardado en la sesión (puede ser útil si se manejan las sesiones en el servidor)
            // En este caso, simplemente actualizaremos el número mostrado en el mensaje de pista
            document.getElementById("targetNumber").innerText = randomNumber;
        }

    </script>
</body>
</html>

