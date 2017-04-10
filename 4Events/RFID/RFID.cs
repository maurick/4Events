using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phidget21COM;

namespace _4Events.RFID
{
    class RFID
    {
        // The main class that handles all RFID activity.
        PhidgetRFID rf;

        private string lastRFIDTag;
        private string currentRFIDTag;
        private bool isAttached;

        public bool IsAttached
        {
            get { return isAttached; }
            set { isAttached = value; }
        }


        public string CurrentRFIDTag
        {
            get { return currentRFIDTag; }
            set { currentRFIDTag = value; }
        }


        public string LastRFIDTag
        {
            get { return lastRFIDTag; }
            set { lastRFIDTag = value; }
        }


        /// <summary>
        /// Creates the RFID object and attaches the event handlers.
        /// </summary>
        public RFID()
        {
            rf = new PhidgetRFID();

            //Event handlers.
            rf.OnAttach += Rf_OnAttach;
            rf.OnDetach += Rf_OnDetach;
            rf.OnError += Rf_OnError;
            rf.OnTag += Rf_OnTag;
            rf.OnTagLost += Rf_OnTagLost;
        }

        /// <summary>
        /// This method activates everytime an RFID tag leaves the scanning area of the RFID reader
        /// </summary>
        /// <param name="tagNumber">The tagNumber on the RFID tag as string</param>
        private void Rf_OnTagLost(string tagNumber)
        {
            Console.WriteLine("Tag {0} lost", tagNumber);
            lastRFIDTag = tagNumber;
            currentRFIDTag = null;
        }

        /// <summary>
        /// This method activates everytime an RFID tag is scanned by the RFID reader.
        /// </summary>
        /// <param name="tagNumber">The tagnumber on the RFID tag as string</param>
        private void Rf_OnTag(string tagNumber)
        {
            Console.WriteLine("Tag {0} ", tagNumber);
            currentRFIDTag = tagNumber;
        }

        /// <summary>
        /// This method activates everytime an error occurs.
        /// </summary>
        /// <param name="Description">The description of the error as string.</param>
        /// <param name="SCODE">The Code of the error.</param>
        private void Rf_OnError(string Description, [System.Runtime.InteropServices.ComAliasName("Phidget21COM.PhidgetCOM_Error")] PhidgetCOM_Error SCODE)
        {
            Console.WriteLine(Description);
        }

        /// <summary>
        /// This method activates everytime an RFID reader is detached.
        /// </summary>
        private void Rf_OnDetach()
        {
            Console.WriteLine("RFIDReader {0} Detached!", rf.DeviceName.ToString());
        }

        /// <summary>
        /// This method activates everytime a RFID reader is attached.
        /// </summary>
        private void Rf_OnAttach()
        {
            Console.WriteLine("RFIDReader {0} attached!", rf.DeviceName.ToString());
        }

        /// <summary>
        /// Opens the connection with the RFID reader.
        /// </summary>
        public void Open()
        {
            try
            {
                rf.Open();
                Console.WriteLine("Waiting for attachment...");
                rf.WaitForAttachment(1000);
                rf.AntennaOn = true;
                rf.LEDOn = true;
                isAttached = rf.IsAttached;
            }
            catch
            {
                Console.WriteLine("Error with attaching.");
            }
        }

        /// <summary>
        /// Closes the connection with the RFID reader.
        /// </summary>
        public void Close()
        {
            rf.LEDOn = false;
            rf.Close();
        }
    }
}
