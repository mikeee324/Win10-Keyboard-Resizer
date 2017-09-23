using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows.Forms;

namespace Win10_Keyboard_Resizer
{
    class Registry
    {
        /// <summary>
        /// Fetchs the value out of the registry value
        /// </summary>
        /// <param name="keyPath">The path to the key in the registry</param>
        /// <param name="valueName">Name of the registry value</param>
        /// <param name="defaultValue">The default value to return if the value doesn't exist</param>
        /// <returns>The value from the registry or the default value if it doesn't exist</returns>
        public static string GetValue(string keyPath, string valueName, string defaultValue = "")
        {
            using (RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(keyPath, true))
            {
                try
                {
                    defaultValue = key.GetValue(valueName, defaultValue).ToString();
                }
                catch (Exception e)
                {
                    MessageBox.Show("There was an error fetching the value from the registry!\r\n" + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    key.Close();
                }
            }
            return defaultValue;
        }

        /// <summary>
        /// Sets a value in the registry
        /// </summary>
        /// <param name="keyPath">Path to the key in the registry</param>
        /// <param name="valueName">Name of the value to update</param>
        /// <param name="newValue">The new value</param>
        public static void SetValue(string keyPath, string valueName, string newValue)
        {
            using (RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(keyPath, true))
            {
                try
                {
                    key.SetValue(valueName, newValue);
                }
                catch (Exception e)
                {
                    MessageBox.Show("There was an error setting the value in the registry!\r\n" + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    key.Close();
                }
            }
        }

        /// <summary>
        /// Delete a value from the registry
        /// </summary>
        /// <param name="keyPath">Path to the key in the registry</param>
        /// <param name="value">Name of the value to delete</param>
        public static void DeleteValue(string keyPath, string value)
        {
            using (RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(keyPath, true))
            {
                if (key != null)
                {
                    try
                    {
                        key.DeleteValue(value);
                    }
                    catch (Exception e)
                    {
                        if (!e.ToString().Contains("No value exists"))
                            MessageBox.Show("There was an error deleting the value from the registry!\r\n" + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        key.Close();
                    }
                }
            }
        }
    }
}
