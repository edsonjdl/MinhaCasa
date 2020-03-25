using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FunctionTests
{
    class Arquivos
    {
        public static void RecursiveSearch(string path)
        {
            Console.WriteLine(path);
            try
            {
                foreach (string dir in Directory.GetDirectories(path))
                {
                    foreach (string file in Directory.GetFiles(dir))
                    {
                        FileInfo fi = new FileInfo(file);

                        //Application.DoEvents();
                        //lblPfad.Text = fi.FullName;

                        long FileLength = fi.Length;
                        long FileLengthOnHarddisc = GetFileSizeOnDisk(file, fi);


                        if ((FileLength == FileLengthOnHarddisc && FileLength == 4096) || FileLength >= FileLengthOnHarddisc)
                        {
                            //myStreamWriter.WriteLine(file + " - Größe - " + FileLength.ToString() + " - Größe auf Datenträger - " + FileLengthOnHarddisc.ToString());
                            Console.WriteLine(file + " - Größe - " + FileLength.ToString() + " - Größe auf Datenträger - " + FileLengthOnHarddisc.ToString());
                        }

                    }

                    RecursiveSearch(dir);

                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }
        }

        public static long GetFileSizeOnDisk(string file, FileInfo info)
        {
            uint dummy, sectorsPerCluster, bytesPerSector;

            int result = GetDiskFreeSpaceW(info.Directory.Root.FullName, out sectorsPerCluster, out bytesPerSector, out dummy, out dummy);
            if (result == 0) throw new Win32Exception();
            uint clusterSize = sectorsPerCluster * bytesPerSector;

            uint hosize;
            uint losize = GetCompressedFileSizeW(file, out hosize);
            long size;
            size = (long)hosize << 32 | losize;
            return ((size + clusterSize - 1) / clusterSize) * clusterSize;
        }

        [DllImport("kernel32.dll")]
        static extern uint GetCompressedFileSizeW([In, MarshalAs(UnmanagedType.LPWStr)] string lpFileName,
           [Out, MarshalAs(UnmanagedType.U4)] out uint lpFileSizeHigh);

        [DllImport("kernel32.dll", SetLastError = true, PreserveSig = true)]
        static extern int GetDiskFreeSpaceW([In, MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName,
           out uint lpSectorsPerCluster, out uint lpBytesPerSector, out uint lpNumberOfFreeClusters,
           out uint lpTotalNumberOfClusters);


    }
}
