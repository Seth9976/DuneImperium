using System;
using Canis.messages;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.match.data
{
	// Token: 0x02000277 RID: 631
	public class ObserversListData : VersionedDataComponent
	{
		// Token: 0x06001D84 RID: 7556 RVA: 0x0007FA64 File Offset: 0x0007DC64
		// Note: this type is marked as 'beforefieldinit'.
		static ObserversListData()
		{
			Il2CppClassPointerStore<ObserversListData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.data", "ObserversListData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObserversListData>.NativeClassPtr);
			ObserversListData.NativeFieldInfoPtr__Observers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserversListData>.NativeClassPtr, "<Observers>k__BackingField");
			ObserversListData.NativeFieldInfoPtr_observers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserversListData>.NativeClassPtr, "observers");
			ObserversListData.NativeMethodInfoPtr_get_Observers_Public_get_IReadOnlyList_1_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversListData>.NativeClassPtr, 100668135);
			ObserversListData.NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyList_1_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversListData>.NativeClassPtr, 100668136);
			ObserversListData.NativeMethodInfoPtr_Update_Public_Void_IReadOnlyList_1_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversListData>.NativeClassPtr, 100668137);
			ObserversListData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversListData>.NativeClassPtr, 100668138);
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06001D85 RID: 7557 RVA: 0x0007FB0C File Offset: 0x0007DD0C
		public unsafe IReadOnlyList<AccountIDUsernameMetadata> Observers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserversListData.NativeMethodInfoPtr_get_Observers_Public_get_IReadOnlyList_1_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<AccountIDUsernameMetadata>>(intPtr3) : null;
			}
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x0007FB4C File Offset: 0x0007DD4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 537041, RefRangeEnd = 537042, XrefRangeStart = 537026, XrefRangeEnd = 537041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObserversListData(IReadOnlyList<AccountIDUsernameMetadata> newObservers)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObserversListData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newObservers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserversListData.NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyList_1_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D87 RID: 7559 RVA: 0x0007FB98 File Offset: 0x0007DD98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 537049, RefRangeEnd = 537050, XrefRangeStart = 537042, XrefRangeEnd = 537049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update(IReadOnlyList<AccountIDUsernameMetadata> newObservers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newObservers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserversListData.NativeMethodInfoPtr_Update_Public_Void_IReadOnlyList_1_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x0007FBDC File Offset: 0x0007DDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537050, XrefRangeEnd = 537059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObserversListData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x0000FA81 File Offset: 0x0000DC81
		public ObserversListData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06001D8A RID: 7562 RVA: 0x0007FC20 File Offset: 0x0007DE20
		// (set) Token: 0x06001D8B RID: 7563 RVA: 0x0000FA8A File Offset: 0x0000DC8A
		public unsafe IReadOnlyList<AccountIDUsernameMetadata> _Observers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversListData.NativeFieldInfoPtr__Observers_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<AccountIDUsernameMetadata>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversListData.NativeFieldInfoPtr__Observers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06001D8C RID: 7564 RVA: 0x0007FC50 File Offset: 0x0007DE50
		// (set) Token: 0x06001D8D RID: 7565 RVA: 0x0000FAA9 File Offset: 0x0000DCA9
		public unsafe List<AccountIDUsernameMetadata> observers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversListData.NativeFieldInfoPtr_observers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AccountIDUsernameMetadata>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversListData.NativeFieldInfoPtr_observers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012A0 RID: 4768
		private static readonly IntPtr NativeFieldInfoPtr__Observers_k__BackingField;

		// Token: 0x040012A1 RID: 4769
		private static readonly IntPtr NativeFieldInfoPtr_observers;

		// Token: 0x040012A2 RID: 4770
		private static readonly IntPtr NativeMethodInfoPtr_get_Observers_Public_get_IReadOnlyList_1_AccountIDUsernameMetadata_0;

		// Token: 0x040012A3 RID: 4771
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyList_1_AccountIDUsernameMetadata_0;

		// Token: 0x040012A4 RID: 4772
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_IReadOnlyList_1_AccountIDUsernameMetadata_0;

		// Token: 0x040012A5 RID: 4773
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
