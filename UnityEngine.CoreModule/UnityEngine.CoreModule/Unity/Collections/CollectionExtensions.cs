using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Unity.Collections
{
	// Token: 0x020002A3 RID: 675
	public static class CollectionExtensions
	{
		// Token: 0x06002CBF RID: 11455 RVA: 0x000B2BD8 File Offset: 0x000B0DD8
		public static void AddSorted<T>(List<T> list, T item, [Optional] IComparer<T> comparer)
		{
			bool flag = list == null;
			if (flag)
			{
				throw new ArgumentNullException("list must not be null.");
			}
			if (comparer == null)
			{
				comparer = Comparer<T>.Default;
			}
			bool flag2 = list.Count == 0;
			if (flag2)
			{
				list.Add(item);
			}
			else
			{
				bool flag3 = comparer.Compare(list[list.Count - 1], item) <= 0;
				if (flag3)
				{
					list.Add(item);
				}
				else
				{
					bool flag4 = comparer.Compare(list[0], item) >= 0;
					if (flag4)
					{
						list.Insert(0, item);
					}
					else
					{
						int num = list.BinarySearch(item, comparer);
						bool flag5 = num < 0;
						if (flag5)
						{
							num = ~num;
						}
						list.Insert(num, item);
					}
				}
			}
		}

		// Token: 0x06002CC0 RID: 11456 RVA: 0x000B2C8C File Offset: 0x000B0E8C
		public static bool ContainsByEquals<T>(IEnumerable<T> collection, T element)
		{
			bool flag = collection == null;
			if (flag)
			{
				throw new ArgumentNullException("collection must not be null.");
			}
			foreach (T t in collection)
			{
				bool flag2 = t.Equals(element);
				if (flag2)
				{
					return true;
				}
			}
			return false;
		}
	}
}
