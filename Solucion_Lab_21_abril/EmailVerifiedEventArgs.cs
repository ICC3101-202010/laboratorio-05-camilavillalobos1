using System;

namespace Solucion_Lab_21_abril
{
    internal class EmailVerifiedEventArgs : EventArgs
    {
        public string VerificationLink { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }
}