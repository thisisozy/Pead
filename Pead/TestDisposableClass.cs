using System.Runtime.InteropServices;

namespace Pead
{
    public class TestDisposableClass : System.IDisposable
    {
        private IntPtr unmanagedResource;
        private bool disposed = false;

        public TestDisposableClass()
        {
            unmanagedResource = Marshal.AllocHGlobal(100);
        }
        public TestDisposableClass(byte bytes)
        {
            unmanagedResource = Marshal.AllocHGlobal(bytes);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Clean up managed resources (if any)
                }

                // Clean up unmanaged resources
                if (unmanagedResource != IntPtr.Zero)
                {
                    Marshal.FreeHGlobal(unmanagedResource);
                    unmanagedResource = IntPtr.Zero;
                }

                disposed = true;
            }
        }

        ~TestDisposableClass()
        {
            Dispose(false);
        }
    }
}
