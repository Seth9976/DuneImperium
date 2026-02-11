using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x0200000C RID: 12
	public sealed class Tree : Component
	{
		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00005DBC File Offset: 0x00003FBC
		// (set) Token: 0x06000130 RID: 304 RVA: 0x00002DB4 File Offset: 0x00000FB4
		public ScriptableObject data
		{
			get
			{
				IntPtr intPtr = Tree.get_dataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr2) : null;
			}
			set
			{
				Tree.set_dataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00002DCC File Offset: 0x00000FCC
		public bool hasSpeedTreeWind
		{
			get
			{
				return Tree.get_hasSpeedTreeWindDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x040000EC RID: 236
		private static readonly Tree.get_dataDelegate get_dataDelegateField = IL2CPP.ResolveICall<Tree.get_dataDelegate>("UnityEngine.Tree::get_data");

		// Token: 0x040000ED RID: 237
		private static readonly Tree.set_dataDelegate set_dataDelegateField = IL2CPP.ResolveICall<Tree.set_dataDelegate>("UnityEngine.Tree::set_data");

		// Token: 0x040000EE RID: 238
		private static readonly Tree.get_hasSpeedTreeWindDelegate get_hasSpeedTreeWindDelegateField = IL2CPP.ResolveICall<Tree.get_hasSpeedTreeWindDelegate>("UnityEngine.Tree::get_hasSpeedTreeWind");

		// Token: 0x020000C3 RID: 195
		// (Invoke) Token: 0x06000350 RID: 848
		private delegate IntPtr get_dataDelegate(IntPtr @this);

		// Token: 0x020000C4 RID: 196
		// (Invoke) Token: 0x06000352 RID: 850
		private delegate void set_dataDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000C5 RID: 197
		// (Invoke) Token: 0x06000354 RID: 852
		private delegate bool get_hasSpeedTreeWindDelegate(IntPtr @this);
	}
}
