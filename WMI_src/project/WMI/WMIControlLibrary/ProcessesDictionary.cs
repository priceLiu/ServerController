using System;
using System.Collections.Specialized;

namespace ProcessesDictionary
{
	/// <summary>
	/// 
	/// </summary>
	public struct structProcessInfo
	{
		public string stringName;
		public string stringProcessID;
		public string stringParentProcessID;
		public string stringUserName;
	}

	public class ProcessesInfo
	{
		private structProcessInfo _value;

		/// <summary>
		/// property Value
		/// </summary>
		public structProcessInfo Value
		{
			get {return _value;}
			set {_value = value;}
		}
	}
	
	/// <summary>
	/// Summary description for Dictionary.
	/// </summary>
	public class ProcessesDictionary : NameObjectCollectionBase
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
		/// <param name="processObj"></param>
		public void Add(string name, ProcessesInfo processObj)
		{
			BaseAdd(name, processObj);
		}

		/// <summary>
		/// Remove item from dictionary
		/// </summary>
		/// <param name="name"></param>
		public void Remove(string name)
		{
			BaseRemove(name);
		}

		/// <summary>
		/// Index remove item from dictionary
		/// </summary>
		/// <param name="index"></param>
		public void RemoveAt(int index)
		{
			BaseRemoveAt(index);
		}

		/// <summary>
		/// ProcessesInfo property by index
		/// </summary>
		public ProcessesInfo this[int index]
		{
			get {return (ProcessesInfo)BaseGet(index);}
			set {BaseSet(index, value);}
		}

		/// <summary>
		/// processInfo property by key
		/// </summary>
		public ProcessesInfo this[string name]
		{
			get {return (ProcessesInfo)BaseGet(name);}
			set {BaseSet(name, value);}
		}
	}

}
