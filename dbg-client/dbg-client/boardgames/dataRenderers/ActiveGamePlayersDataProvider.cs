using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.datarenderers
{
	// Token: 0x02000166 RID: 358
	public class ActiveGamePlayersDataProvider : VersionedSubscriber<ReconnectableGameData>
	{
		// Token: 0x06001000 RID: 4096 RVA: 0x000503A8 File Offset: 0x0004E5A8
		// Note: this type is marked as 'beforefieldinit'.
		static ActiveGamePlayersDataProvider()
		{
			Il2CppClassPointerStore<ActiveGamePlayersDataProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.datarenderers", "ActiveGamePlayersDataProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveGamePlayersDataProvider>.NativeClassPtr);
			ActiveGamePlayersDataProvider.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveGamePlayersDataProvider>.NativeClassPtr, "entry");
			ActiveGamePlayersDataProvider.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveGamePlayersDataProvider>.NativeClassPtr, "entries");
			ActiveGamePlayersDataProvider.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveGamePlayersDataProvider>.NativeClassPtr, 100665560);
			ActiveGamePlayersDataProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveGamePlayersDataProvider>.NativeClassPtr, 100665561);
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x00050428 File Offset: 0x0004E628
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 513786, RefRangeEnd = 513787, XrefRangeStart = 513749, XrefRangeEnd = 513786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActiveGamePlayersDataProvider.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x00050464 File Offset: 0x0004E664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 513797, RefRangeEnd = 513798, XrefRangeStart = 513787, XrefRangeEnd = 513797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActiveGamePlayersDataProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveGamePlayersDataProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveGamePlayersDataProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x00009BE9 File Offset: 0x00007DE9
		public ActiveGamePlayersDataProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06001004 RID: 4100 RVA: 0x000504A0 File Offset: 0x0004E6A0
		// (set) Token: 0x06001005 RID: 4101 RVA: 0x00009BF2 File Offset: 0x00007DF2
		public unsafe SubscriptionProvider entry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveGamePlayersDataProvider.NativeFieldInfoPtr_entry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveGamePlayersDataProvider.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06001006 RID: 4102 RVA: 0x000504D0 File Offset: 0x0004E6D0
		// (set) Token: 0x06001007 RID: 4103 RVA: 0x00009C11 File Offset: 0x00007E11
		public unsafe List<SubscriptionProvider> entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveGamePlayersDataProvider.NativeFieldInfoPtr_entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SubscriptionProvider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveGamePlayersDataProvider.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009C9 RID: 2505
		private static readonly IntPtr NativeFieldInfoPtr_entry;

		// Token: 0x040009CA RID: 2506
		private static readonly IntPtr NativeFieldInfoPtr_entries;

		// Token: 0x040009CB RID: 2507
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040009CC RID: 2508
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
