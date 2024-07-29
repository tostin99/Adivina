using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Adivina
{
    public partial class Adivina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Verificar si es la primera carga de la página
            if (!IsPostBack)
            {
                // Generar un número aleatorio entre 1 y 10 y almacenarlo en la sesión
                int randomNumber = new Random().Next(1, 10);
                Session["targetNumber"] = randomNumber;
                Session["attempts"] = 0;
            }
        }

        protected void GuessNumber(object sender, EventArgs e)
            {
                // Obtener la suposición del jugador desde el cuadro de texto
                int guess;
                if (!int.TryParse(guessInput.Text, out guess))
                {
                    result.InnerHtml = "Por favor, ingresa un número válido.";
                    return;
                }

                // Obtener el número objetivo almacenado en la sesión
                int targetNumber = (int)Session["targetNumber"];

                // Incrementar el contador de intentos
                int attempts = (int)Session["attempts"];
                attempts++;
                Session["attempts"] = attempts;

                // Comprobar si la suposición es correcta
                if (guess == targetNumber)
                {
                    result.InnerHtml = "¡Felicitaciones! Has adivinado el número en " + attempts + " intentos.";
                }
                else
                {
                    // Dar una pista al jugador
                    if (guess < targetNumber)
                    {
                        result.InnerHtml = "El número que buscas es mayor.";
                    }
                    else
                    {
                        result.InnerHtml = "El número que buscas es menor.";
                    }
                }
            }

        protected void NewNumber(object sender, EventArgs e)
        {
            // Generar un nuevo número aleatorio y reiniciar el contador de intentos
            int randomNumber = new Random().Next(1, 11);
            Session["targetNumber"] = randomNumber;
            Session["attempts"] = 0;

            // Limpiar el contenido de la casilla de texto
            guessInput.Text = "";

            // Limpiar el resultado
            result.InnerHtml = "";
        }

    }
}
