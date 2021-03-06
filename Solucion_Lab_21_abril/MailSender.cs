﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Solucion_Lab_21_abril
{
    public class MailSender
    {

        // Paso 1: Creamos el delegate para el evento del registro

        public delegate void EmailSentEventHandler(object source, EventArgs args);

        // Paso 2: Creamos el evento que se engatilla cuando el usuario se registra

        public event EmailSentEventHandler EmailSent;

        // Paso 3: Publicamos el evento. 

        protected virtual void OnEmailSent()
        {
            if (EmailSent != null)
            {
                // Engatilla el evento
                EmailSent(this, EventArgs.Empty);
            }
        }

        public void OnRegistered(object source, RegisterEventArgs e)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"\nCorreo enviado a {e.Email}: \n Gracias por registrarte, {e.Username}!\n Por favor, para poder verificar tu correo, has click en: {e.VerificationLink}\n");
            Thread.Sleep(2000);
            OnEmailSent();
        }

        public void OnPasswordChanged(object source, ChangePasswordEventArgs e)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"\nCorreo enviado a {e.Email}:  \n {e.Username}, te notificamos que la contrasena de tu cuenta PlusCorp ha sido cambiada. \n");
            Thread.Sleep(2000);
        }

        

    }
}
