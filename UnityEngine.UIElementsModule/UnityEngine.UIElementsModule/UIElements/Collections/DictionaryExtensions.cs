using System;
using System.Runtime.InteropServices;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements.Collections
{
	// Token: 0x020002FA RID: 762
	public static class DictionaryExtensions
	{
		// Token: 0x060034C9 RID: 13513 RVA: 0x000DC998 File Offset: 0x000DAB98
		public static TValue Get<TKey, TValue>(IDictionary<TKey, TValue> dict, TKey key, [Optional] TValue fallbackValue)
		{
			TValue tvalue;
			return dict.TryGetValue(key, out tvalue) ? tvalue : fallbackValue;
		}
	}
}
