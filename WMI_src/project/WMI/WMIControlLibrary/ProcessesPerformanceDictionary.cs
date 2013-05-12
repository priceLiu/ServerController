using System;
using System.Collections.Specialized;

namespace ProcessesPerformanceDictionary
{
	/// <summary>
	/// Process performance data structure
	/// </summary>
	public struct structPerformance 
	{
		public string stringPercentProcessorTime;
		public string stringVirtualBytes;
	}

	public class ProcessPerf
	{
		private structPerformance _value;

		/// <summary>
		/// Property
		/// </summary>
		public structPerformance Value
		{
			get {return _value;}
			set {_value = value;}
		}
	}
	
	/// <summary>
	/// This Dictionary contains process performance data.
	/// </summary>
	public class Dictionary : NameObjectCollectionBase
	{
		/// <summary>
		/// Clear dictionary
		/// </summary>
		public void Clear()
		{
			BaseClear();
		}

		/// <summary>
		/// Add item to dictionary
		/// </summary>
		/// <param name="name"></param>
		/// <param name="processPerformance"></param>
		public void Add(string name, ProcessPerf processPerformance)
		{
			BaseAdd(name, processPerformance);
		}

		/// <summary>
		/// Remove item from dictionary by key
		/// </summary>
		/// <param name="name"></param>
		public void Remove(string name)
		{
			BaseRemove(name);
		}

		/// <summary>
		/// Remove item from dictionary by index
		/// </summary>
		/// <param name="index"></param>
		public void RemoveAt(int index)
		{
			BaseRemoveAt(index);
		}

		/// <summary>
		/// Access ProcessPerf item by index
		/// </summary>
		public ProcessPerf this[int index]
		{
			get {return (ProcessPerf)BaseGet(index);}
			set {BaseSet(index, value);}
		}

		/// <summary>
		/// Access ProcessPerf item by key
		/// </summary>
		public ProcessPerf this[string name]
		{
			get {return (ProcessPerf)BaseGet(name);}
			set {BaseSet(name, value);}
		}
	}

}
