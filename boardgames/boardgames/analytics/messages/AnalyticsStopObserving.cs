using System;
using analytics;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.analytics.messages
{
	// Token: 0x0200017F RID: 383
	public class AnalyticsStopObserving : ClientAnalyticsMessage
	{
		// Token: 0x06001303 RID: 4867 RVA: 0x0004BB9C File Offset: 0x00049D9C
		// Note: this type is marked as 'beforefieldinit'.
		static AnalyticsStopObserving()
		{
			Il2CppClassPointerStore<AnalyticsStopObserving>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.analytics.messages", "AnalyticsStopObserving");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsStopObserving>.NativeClassPtr);
			AnalyticsStopObserving.NativeFieldInfoPtr_observerAccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsStopObserving>.NativeClassPtr, "observerAccountID");
			AnalyticsStopObserving.NativeFieldInfoPtr_gameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsStopObserving>.NativeClassPtr, "gameID");
			AnalyticsStopObserving.NativeFieldInfoPtr_reason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsStopObserving>.NativeClassPtr, "reason");
			AnalyticsStopObserving.NativeMethodInfoPtr__ctor_Public_Void_AccountID_GameID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsStopObserving>.NativeClassPtr, 100666089);
			AnalyticsStopObserving.NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsStopObserving>.NativeClassPtr, 100666090);
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x0004BC30 File Offset: 0x00049E30
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1001607, RefRangeEnd = 1001612, XrefRangeStart = 1001595, XrefRangeEnd = 1001607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnalyticsStopObserving(AccountID observerAccountID, GameID gameID, string reason)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsStopObserving>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(observerAccountID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(reason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsStopObserving.NativeMethodInfoPtr__ctor_Public_Void_AccountID_GameID_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x0004BCA0 File Offset: 0x00049EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001612, XrefRangeEnd = 1001627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string body(IAnalyticsManager mgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnalyticsStopObserving.NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x0000ADCA File Offset: 0x00008FCA
		public AnalyticsStopObserving(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06001307 RID: 4871 RVA: 0x0004BCF4 File Offset: 0x00049EF4
		// (set) Token: 0x06001308 RID: 4872 RVA: 0x0000ADD3 File Offset: 0x00008FD3
		public unsafe AccountID observerAccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsStopObserving.NativeFieldInfoPtr_observerAccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsStopObserving.NativeFieldInfoPtr_observerAccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06001309 RID: 4873 RVA: 0x0004BD24 File Offset: 0x00049F24
		// (set) Token: 0x0600130A RID: 4874 RVA: 0x0000ADF2 File Offset: 0x00008FF2
		public unsafe GameID gameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsStopObserving.NativeFieldInfoPtr_gameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsStopObserving.NativeFieldInfoPtr_gameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x0600130B RID: 4875 RVA: 0x0004BD54 File Offset: 0x00049F54
		// (set) Token: 0x0600130C RID: 4876 RVA: 0x0000AE11 File Offset: 0x00009011
		public unsafe string reason
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsStopObserving.NativeFieldInfoPtr_reason);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsStopObserving.NativeFieldInfoPtr_reason), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000B8B RID: 2955
		private static readonly IntPtr NativeFieldInfoPtr_observerAccountID;

		// Token: 0x04000B8C RID: 2956
		private static readonly IntPtr NativeFieldInfoPtr_gameID;

		// Token: 0x04000B8D RID: 2957
		private static readonly IntPtr NativeFieldInfoPtr_reason;

		// Token: 0x04000B8E RID: 2958
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AccountID_GameID_String_0;

		// Token: 0x04000B8F RID: 2959
		private static readonly IntPtr NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0;
	}
}
