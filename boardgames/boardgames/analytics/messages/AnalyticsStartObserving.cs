using System;
using analytics;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.analytics.messages
{
	// Token: 0x0200017E RID: 382
	public class AnalyticsStartObserving : ClientAnalyticsMessage
	{
		// Token: 0x060012F7 RID: 4855 RVA: 0x0004B95C File Offset: 0x00049B5C
		// Note: this type is marked as 'beforefieldinit'.
		static AnalyticsStartObserving()
		{
			Il2CppClassPointerStore<AnalyticsStartObserving>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.analytics.messages", "AnalyticsStartObserving");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsStartObserving>.NativeClassPtr);
			AnalyticsStartObserving.NativeFieldInfoPtr_observerAccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsStartObserving>.NativeClassPtr, "observerAccountID");
			AnalyticsStartObserving.NativeFieldInfoPtr_gameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsStartObserving>.NativeClassPtr, "gameID");
			AnalyticsStartObserving.NativeFieldInfoPtr_observableAccountIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsStartObserving>.NativeClassPtr, "observableAccountIDs");
			AnalyticsStartObserving.NativeFieldInfoPtr_observedAccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsStartObserving>.NativeClassPtr, "observedAccountID");
			AnalyticsStartObserving.NativeMethodInfoPtr__ctor_Public_Void_AccountID_GameID_List_1_String_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsStartObserving>.NativeClassPtr, 100666087);
			AnalyticsStartObserving.NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsStartObserving>.NativeClassPtr, 100666088);
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x0004BA04 File Offset: 0x00049C04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1001575, RefRangeEnd = 1001576, XrefRangeStart = 1001562, XrefRangeEnd = 1001575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnalyticsStartObserving(AccountID observerAccountID, GameID gameID, List<string> observableAccountIDs, AccountID observedAccountID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsStartObserving>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(observerAccountID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(observableAccountIDs);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(observedAccountID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsStartObserving.NativeMethodInfoPtr__ctor_Public_Void_AccountID_GameID_List_1_String_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x0004BA88 File Offset: 0x00049C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001576, XrefRangeEnd = 1001595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string body(IAnalyticsManager mgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnalyticsStartObserving.NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x0000AD45 File Offset: 0x00008F45
		public AnalyticsStartObserving(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x060012FB RID: 4859 RVA: 0x0004BADC File Offset: 0x00049CDC
		// (set) Token: 0x060012FC RID: 4860 RVA: 0x0000AD4E File Offset: 0x00008F4E
		public unsafe AccountID observerAccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsStartObserving.NativeFieldInfoPtr_observerAccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsStartObserving.NativeFieldInfoPtr_observerAccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x060012FD RID: 4861 RVA: 0x0004BB0C File Offset: 0x00049D0C
		// (set) Token: 0x060012FE RID: 4862 RVA: 0x0000AD6D File Offset: 0x00008F6D
		public unsafe GameID gameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsStartObserving.NativeFieldInfoPtr_gameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsStartObserving.NativeFieldInfoPtr_gameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x060012FF RID: 4863 RVA: 0x0004BB3C File Offset: 0x00049D3C
		// (set) Token: 0x06001300 RID: 4864 RVA: 0x0000AD8C File Offset: 0x00008F8C
		public unsafe List<string> observableAccountIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsStartObserving.NativeFieldInfoPtr_observableAccountIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsStartObserving.NativeFieldInfoPtr_observableAccountIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001301 RID: 4865 RVA: 0x0004BB6C File Offset: 0x00049D6C
		// (set) Token: 0x06001302 RID: 4866 RVA: 0x0000ADAB File Offset: 0x00008FAB
		public unsafe AccountID observedAccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsStartObserving.NativeFieldInfoPtr_observedAccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsStartObserving.NativeFieldInfoPtr_observedAccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B85 RID: 2949
		private static readonly IntPtr NativeFieldInfoPtr_observerAccountID;

		// Token: 0x04000B86 RID: 2950
		private static readonly IntPtr NativeFieldInfoPtr_gameID;

		// Token: 0x04000B87 RID: 2951
		private static readonly IntPtr NativeFieldInfoPtr_observableAccountIDs;

		// Token: 0x04000B88 RID: 2952
		private static readonly IntPtr NativeFieldInfoPtr_observedAccountID;

		// Token: 0x04000B89 RID: 2953
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AccountID_GameID_List_1_String_AccountID_0;

		// Token: 0x04000B8A RID: 2954
		private static readonly IntPtr NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0;
	}
}
