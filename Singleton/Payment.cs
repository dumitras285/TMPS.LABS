using System;

namespace Singleton
{
    class Payment
    {
        private static Payment instance = null;
        private static object syncRoot = new Object();
        public string Id { get; private set; }

        protected Payment(int id)
        {
            this.Id = Convert.ToString(id);
        }

        public static Payment GetInstance(int name)
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                        instance = new Payment(name);
                }
            }
            return instance;
        }
    }
}
