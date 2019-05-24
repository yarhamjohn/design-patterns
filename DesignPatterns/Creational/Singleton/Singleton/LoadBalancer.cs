namespace Singleton.Singleton
{
    /// <summary>
    /// The Singleton class
    /// </summary>
    internal class LoadBalancer
    {
        private static LoadBalancer _instance;

        // Constructor is private so new instances of the class cannot be created.
        private LoadBalancer()
        {
        }

        public static LoadBalancer GetLoadBalancer()
        {
            // Creates a new instance only if there isn't an existing one, otherwise returns the existing instance
            // This is not safe for multi-threaded applications. Could instead initialise the LoadBalancer in the static property directly
            // as this should allow the compiler to guarantee thread safety as it will be initialised when the class is first loaded.
            return _instance ?? (_instance = new LoadBalancer());
        }
    }
}
