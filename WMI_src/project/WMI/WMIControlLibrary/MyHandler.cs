using System;
using System.Management;

namespace completionHandler
{
	/// <summary>
	/// MyHandler class handle notification when InvokeMethod call is complete
	/// </summary>
	public class MyHandler
	{
		private bool isComplete = false;
		private ManagementBaseObject returnObject;
             
		/// <summary>
		/// Trigger Done event when InvokeMethod is complete
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void Done(object sender, ObjectReadyEventArgs e)
		{ 
			isComplete = true;
			returnObject = e.NewObject;
		}


        /// <summary>
        /// Get property IsComplete
        /// </summary>
    	public bool IsComplete 
		{
			get 
			{
				return isComplete;
			}
		}

		/// <summary>
		/// Property allows accessing the result object in the main function
		/// </summary>
		public ManagementBaseObject ReturnObject 
		{
			get 
			{
				return returnObject;
			}
		}


	}
}

        