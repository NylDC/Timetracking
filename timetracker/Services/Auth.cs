using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timetracker.Models;
using timetracker.Structs;

namespace timetracker.Services
{
    class AuthEventArgs: EventArgs
    {
        public AuthEventArgs(User user)
        {
            User = user;
        }
        public User User = null;
    }
    class Auth
    {
        public static User CurrentUser { get; private set; } = null;

        public static User Authenticate(string login, string password)
        {
            User tmpUser = null;
            try
            {
                tmpUser = UserModel.FindOne(new WhereGroup
                {
                    new WhereCondition("Login",login),
                    new WhereCondition("Password",password)
                });
                CurrentUser = tmpUser;
                OnChange(new AuthEventArgs(tmpUser));
            }
            catch (Exception ex)
            {
            }
            return CurrentUser;
        }

        public static void Logout()
        {
            CurrentUser = null;
            OnChange(new AuthEventArgs(null));
        }

        /// <summary>
        /// Distinctive event type for the EventHandlerList
        /// </summary>
        static readonly object authEventKey = new object();

        /// <summary>
        /// Container for event handlers
        /// </summary>
        protected static EventHandlerList listEventDelegates = new EventHandlerList();

        /// <summary>
        /// Type for event handler to be used for subscribing to the Timer events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void AuthEventHandler(AuthEventArgs e);

        public static event AuthEventHandler CounterChange
        {
            // Add the input delegate to the collection.
            add
            {
                listEventDelegates.AddHandler(authEventKey, value);
            }
            // Remove the input delegate from the collection.
            remove
            {
                listEventDelegates.RemoveHandler(authEventKey, value);
            }
        }

        /// <summary>
        /// Trigger AuthChange handlers
        /// </summary>
        /// <param name="e"></param>
        private static void OnChange(AuthEventArgs e) => _runDelegateByType(e, authEventKey);

        /// <summary>
        /// Unified handler trigger used by other "On[Event]" functions
        /// </summary>
        /// <param name="e"></param>
        /// <param name="DelegateType"></param>
        private static void _runDelegateByType(AuthEventArgs e, object DelegateType)
        {
            AuthEventHandler eventDelegate =
                (AuthEventHandler)listEventDelegates[DelegateType];
            eventDelegate(e);
        }
    }
}
