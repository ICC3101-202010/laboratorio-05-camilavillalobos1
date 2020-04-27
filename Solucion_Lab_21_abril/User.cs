using System;
namespace Solucion_Lab_21_abril
{
    public class User
    {
        public User()
        {
        }

        // Paso 1: Creamos el delegate para el evento del registro

        public delegate void EmailVerifiedEventHandler(object source, EventArgs args);

        // Paso 2: Creamos el evento que se engatilla cuando el usuario se registra

        public event EmailVerifiedEventHandler EmailVerified;

        // Paso 3: Publicamos el evento. Notar que cuando se quiere engatillar el evento, se llama OnRegistered().

        protected virtual void OnEmailVerified()
        {
            EmailVerified?.Invoke(this, EventArgs.Empty);
        }

        public void OnEmailSent(object source, EventArgs e)
        {
            // Preguntar si el usuario quiere verificar su correo

            Console.WriteLine("Verificar correo\n [1] Si\n [2] No");
            int v = Convert.ToInt32(Console.ReadLine());

            if (v == 1)
            {
                OnEmailVerified();
            }
        }


    }
}
