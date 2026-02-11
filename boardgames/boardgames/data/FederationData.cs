using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.data
{
	// Token: 0x0200013C RID: 316
	public class FederationData : VersionedDataComponent
	{
		// Token: 0x06001060 RID: 4192 RVA: 0x000434A0 File Offset: 0x000416A0
		// Note: this type is marked as 'beforefieldinit'.
		static FederationData()
		{
			Il2CppClassPointerStore<FederationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.data", "FederationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FederationData>.NativeClassPtr);
			FederationData.NativeFieldInfoPtr_NoPlatformID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FederationData>.NativeClassPtr, "NoPlatformID");
			FederationData.NativeFieldInfoPtr__PlatformID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FederationData>.NativeClassPtr, "<PlatformID>k__BackingField");
			FederationData.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FederationData>.NativeClassPtr, 100665696);
			FederationData.NativeMethodInfoPtr_get_IsFederated_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FederationData>.NativeClassPtr, 100665697);
			FederationData.NativeMethodInfoPtr_get_FederatedName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FederationData>.NativeClassPtr, 100665698);
			FederationData.NativeMethodInfoPtr_get_PlatformID_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FederationData>.NativeClassPtr, 100665699);
			FederationData.NativeMethodInfoPtr_set_PlatformID_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FederationData>.NativeClassPtr, 100665700);
			FederationData.NativeMethodInfoPtr_Set_Public_Virtual_New_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FederationData>.NativeClassPtr, 100665701);
			FederationData.NativeMethodInfoPtr_ToMetadata_Public_Virtual_New_IDictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FederationData>.NativeClassPtr, 100665702);
			FederationData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FederationData>.NativeClassPtr, 100665703);
			FederationData.NativeMethodInfoPtr_Create_Public_Static_FederationData_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FederationData>.NativeClassPtr, 100665704);
			FederationData.NativeMethodInfoPtr_Create_Public_Static_FederationData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FederationData>.NativeClassPtr, 100665705);
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x000435C0 File Offset: 0x000417C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999249, XrefRangeEnd = 999250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FederationData(ulong platformID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FederationData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref platformID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FederationData.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06001062 RID: 4194 RVA: 0x00043608 File Offset: 0x00041808
		public unsafe virtual bool IsFederated
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FederationData.NativeMethodInfoPtr_get_IsFederated_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06001063 RID: 4195 RVA: 0x00043650 File Offset: 0x00041850
		public unsafe virtual string FederatedName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999250, XrefRangeEnd = 999252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FederationData.NativeMethodInfoPtr_get_FederatedName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06001064 RID: 4196 RVA: 0x00043694 File Offset: 0x00041894
		// (set) Token: 0x06001065 RID: 4197 RVA: 0x000436D0 File Offset: 0x000418D0
		public unsafe ulong PlatformID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FederationData.NativeMethodInfoPtr_get_PlatformID_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FederationData.NativeMethodInfoPtr_set_PlatformID_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x00043710 File Offset: 0x00041910
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 514351, RefRangeEnd = 514353, XrefRangeStart = 514351, XrefRangeEnd = 514353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Set(ulong platformID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref platformID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FederationData.NativeMethodInfoPtr_Set_Public_Virtual_New_Void_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x0004375C File Offset: 0x0004195C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999252, XrefRangeEnd = 999258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionary<string, string> ToMetadata()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FederationData.NativeMethodInfoPtr_ToMetadata_Public_Virtual_New_IDictionary_2_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr3) : null;
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x000437A8 File Offset: 0x000419A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999258, XrefRangeEnd = 999291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FederationData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x000437EC File Offset: 0x000419EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999291, XrefRangeEnd = 999305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FederationData Create(ulong platformID = 0UL)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref platformID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FederationData.NativeMethodInfoPtr_Create_Public_Static_FederationData_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FederationData>(intPtr3) : null;
			}
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x0004382C File Offset: 0x00041A2C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 999320, RefRangeEnd = 999326, XrefRangeStart = 999305, XrefRangeEnd = 999320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FederationData Create(string platformIDString)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(platformIDString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FederationData.NativeMethodInfoPtr_Create_Public_Static_FederationData_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FederationData>(intPtr3) : null;
			}
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x000099CD File Offset: 0x00007BCD
		public FederationData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x0600106C RID: 4204 RVA: 0x00043870 File Offset: 0x00041A70
		// (set) Token: 0x0600106D RID: 4205 RVA: 0x000099D6 File Offset: 0x00007BD6
		public unsafe static ulong NoPlatformID
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(FederationData.NativeFieldInfoPtr_NoPlatformID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FederationData.NativeFieldInfoPtr_NoPlatformID, (void*)(&value));
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x0600106E RID: 4206 RVA: 0x0004388C File Offset: 0x00041A8C
		// (set) Token: 0x0600106F RID: 4207 RVA: 0x000099E4 File Offset: 0x00007BE4
		public unsafe ulong _PlatformID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FederationData.NativeFieldInfoPtr__PlatformID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FederationData.NativeFieldInfoPtr__PlatformID_k__BackingField)) = value;
			}
		}

		// Token: 0x040009FB RID: 2555
		private static readonly IntPtr NativeFieldInfoPtr_NoPlatformID;

		// Token: 0x040009FC RID: 2556
		private static readonly IntPtr NativeFieldInfoPtr__PlatformID_k__BackingField;

		// Token: 0x040009FD RID: 2557
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x040009FE RID: 2558
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFederated_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040009FF RID: 2559
		private static readonly IntPtr NativeMethodInfoPtr_get_FederatedName_Public_Virtual_New_get_String_0;

		// Token: 0x04000A00 RID: 2560
		private static readonly IntPtr NativeMethodInfoPtr_get_PlatformID_Public_get_UInt64_0;

		// Token: 0x04000A01 RID: 2561
		private static readonly IntPtr NativeMethodInfoPtr_set_PlatformID_Private_set_Void_UInt64_0;

		// Token: 0x04000A02 RID: 2562
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Virtual_New_Void_UInt64_0;

		// Token: 0x04000A03 RID: 2563
		private static readonly IntPtr NativeMethodInfoPtr_ToMetadata_Public_Virtual_New_IDictionary_2_String_String_0;

		// Token: 0x04000A04 RID: 2564
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000A05 RID: 2565
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_FederationData_UInt64_0;

		// Token: 0x04000A06 RID: 2566
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_FederationData_String_0;
	}
}
