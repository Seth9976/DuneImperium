using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020002F9 RID: 761
	public sealed class Ping
	{
		// Token: 0x06002D8E RID: 11662 RVA: 0x000B3B68 File Offset: 0x000B1D68
		public ~Ping()
		{
			this.DestroyPing();
		}

		// Token: 0x06002D8F RID: 11663 RVA: 0x00012193 File Offset: 0x00010393
		public void DestroyPing()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002D90 RID: 11664 RVA: 0x000121A0 File Offset: 0x000103A0
		public static void Internal_Destroy(IntPtr ptr)
		{
			Ping.Internal_DestroyDelegateField(ptr);
		}

		// Token: 0x06002D91 RID: 11665 RVA: 0x000121AD File Offset: 0x000103AD
		public static IntPtr Internal_Create(string address)
		{
			return Ping.Internal_CreateDelegateField(IL2CPP.ManagedStringToIl2Cpp(address));
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06002D92 RID: 11666 RVA: 0x000121BF File Offset: 0x000103BF
		public bool isDone
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06002D93 RID: 11667 RVA: 0x000121CC File Offset: 0x000103CC
		public bool Internal_IsDone()
		{
			return Ping.Internal_IsDoneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06002D94 RID: 11668 RVA: 0x000121DE File Offset: 0x000103DE
		public int time
		{
			get
			{
				return Ping.get_timeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06002D95 RID: 11669 RVA: 0x000B3B98 File Offset: 0x000B1D98
		public string ip
		{
			get
			{
				IntPtr intPtr = Ping.get_ipDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x04002928 RID: 10536
		private static readonly Ping.Internal_DestroyDelegate Internal_DestroyDelegateField = IL2CPP.ResolveICall<Ping.Internal_DestroyDelegate>("UnityEngine.Ping::Internal_Destroy");

		// Token: 0x04002929 RID: 10537
		private static readonly Ping.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<Ping.Internal_CreateDelegate>("UnityEngine.Ping::Internal_Create");

		// Token: 0x0400292A RID: 10538
		private static readonly Ping.Internal_IsDoneDelegate Internal_IsDoneDelegateField = IL2CPP.ResolveICall<Ping.Internal_IsDoneDelegate>("UnityEngine.Ping::Internal_IsDone");

		// Token: 0x0400292B RID: 10539
		private static readonly Ping.get_timeDelegate get_timeDelegateField = IL2CPP.ResolveICall<Ping.get_timeDelegate>("UnityEngine.Ping::get_time");

		// Token: 0x0400292C RID: 10540
		private static readonly Ping.get_ipDelegate get_ipDelegateField = IL2CPP.ResolveICall<Ping.get_ipDelegate>("UnityEngine.Ping::get_ip");

		// Token: 0x02000B59 RID: 2905
		// (Invoke) Token: 0x06003FA7 RID: 16295
		private delegate void Internal_DestroyDelegate(IntPtr ptr);

		// Token: 0x02000B5A RID: 2906
		// (Invoke) Token: 0x06003FA9 RID: 16297
		private delegate IntPtr Internal_CreateDelegate(IntPtr address);

		// Token: 0x02000B5B RID: 2907
		// (Invoke) Token: 0x06003FAB RID: 16299
		private delegate bool Internal_IsDoneDelegate(IntPtr @this);

		// Token: 0x02000B5C RID: 2908
		// (Invoke) Token: 0x06003FAD RID: 16301
		private delegate int get_timeDelegate(IntPtr @this);

		// Token: 0x02000B5D RID: 2909
		// (Invoke) Token: 0x06003FAF RID: 16303
		private delegate IntPtr get_ipDelegate(IntPtr @this);
	}
}
