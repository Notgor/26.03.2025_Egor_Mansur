using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_Egor_Mansur_26
{
    class ResourceHolder : IDisposable
    {
        private bool disposed = false;

        public ResourceHolder()
        {
            Console.WriteLine("Ресурс выделен.");
        }

        public void UseResource()
        {
            if (disposed)
                throw new ObjectDisposedException("ResourceHolder");
            Console.WriteLine("Использование ресурса.");
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Console.WriteLine("Освобождение управляемых ресурсов.");
                }
                Console.WriteLine("Освобождение неуправляемых ресурсов.");
                disposed = true;
            }
        }

        ~ResourceHolder()
        {
            Dispose(false);
        }
    }

    class Task13
    {
        public static void Execute()
        {
            using (var resource = new ResourceHolder())
            {
                resource.UseResource();
            }
            Console.WriteLine("Ресурс освобождён корректно.");
        }
    }
}
