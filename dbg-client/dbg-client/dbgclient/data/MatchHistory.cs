using System;
using canis.Networking.game.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dbgclient.data
{
	// Token: 0x020000D0 RID: 208
	public class MatchHistory : Object
	{
		// Token: 0x060008D5 RID: 2261 RVA: 0x00039444 File Offset: 0x00037644
		// Note: this type is marked as 'beforefieldinit'.
		static MatchHistory()
		{
			Il2CppClassPointerStore<MatchHistory>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.data", "MatchHistory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchHistory>.NativeClassPtr);
			MatchHistory.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistory>.NativeClassPtr, "AccountID");
			MatchHistory.NativeFieldInfoPtr_Client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistory>.NativeClassPtr, "Client");
			MatchHistory.NativeFieldInfoPtr_History = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistory>.NativeClassPtr, "History");
			MatchHistory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchHistory>.NativeClassPtr, 100664572);
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x000394C4 File Offset: 0x000376C4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchHistory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchHistory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchHistory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x0000622D File Offset: 0x0000442D
		public MatchHistory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x00039500 File Offset: 0x00037700
		// (set) Token: 0x060008D9 RID: 2265 RVA: 0x00006236 File Offset: 0x00004436
		public unsafe AccountID AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistory.NativeFieldInfoPtr_AccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistory.NativeFieldInfoPtr_AccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x00039530 File Offset: 0x00037730
		// (set) Token: 0x060008DB RID: 2267 RVA: 0x00006255 File Offset: 0x00004455
		public unsafe string Client
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistory.NativeFieldInfoPtr_Client);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistory.NativeFieldInfoPtr_Client), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060008DC RID: 2268 RVA: 0x00039558 File Offset: 0x00037758
		// (set) Token: 0x060008DD RID: 2269 RVA: 0x00006274 File Offset: 0x00004474
		public unsafe List<MatchHistoryEntry> History
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistory.NativeFieldInfoPtr_History);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MatchHistoryEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistory.NativeFieldInfoPtr_History), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeFieldInfoPtr_Client;

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeFieldInfoPtr_History;

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
