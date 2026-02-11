using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001F8 RID: 504
	public sealed class DlcInformation : ValueType
	{
		// Token: 0x06001949 RID: 6473 RVA: 0x0007AC78 File Offset: 0x00078E78
		// Note: this type is marked as 'beforefieldinit'.
		static DlcInformation()
		{
			Il2CppClassPointerStore<DlcInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "DlcInformation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DlcInformation>.NativeClassPtr);
			DlcInformation.NativeFieldInfoPtr__AppId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DlcInformation>.NativeClassPtr, "<AppId>k__BackingField");
			DlcInformation.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DlcInformation>.NativeClassPtr, "<Name>k__BackingField");
			DlcInformation.NativeFieldInfoPtr__Available_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DlcInformation>.NativeClassPtr, "<Available>k__BackingField");
			DlcInformation.NativeMethodInfoPtr_get_AppId_Public_get_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DlcInformation>.NativeClassPtr, 100667915);
			DlcInformation.NativeMethodInfoPtr_set_AppId_Internal_set_Void_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DlcInformation>.NativeClassPtr, 100667916);
			DlcInformation.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DlcInformation>.NativeClassPtr, 100667917);
			DlcInformation.NativeMethodInfoPtr_set_Name_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DlcInformation>.NativeClassPtr, 100667918);
			DlcInformation.NativeMethodInfoPtr_get_Available_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DlcInformation>.NativeClassPtr, 100667919);
			DlcInformation.NativeMethodInfoPtr_set_Available_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DlcInformation>.NativeClassPtr, 100667920);
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x0600194A RID: 6474 RVA: 0x0007AD5C File Offset: 0x00078F5C
		// (set) Token: 0x0600194B RID: 6475 RVA: 0x0007ADA0 File Offset: 0x00078FA0
		public unsafe AppId AppId
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DlcInformation.NativeMethodInfoPtr_get_AppId_Public_get_AppId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 320163, RefRangeEnd = 320170, XrefRangeStart = 320163, XrefRangeEnd = 320170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DlcInformation.NativeMethodInfoPtr_set_AppId_Internal_set_Void_AppId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x0600194C RID: 6476 RVA: 0x0007ADE4 File Offset: 0x00078FE4
		// (set) Token: 0x0600194D RID: 6477 RVA: 0x0007AE20 File Offset: 0x00079020
		public unsafe string Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DlcInformation.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 315685, RefRangeEnd = 315686, XrefRangeStart = 315685, XrefRangeEnd = 315686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DlcInformation.NativeMethodInfoPtr_set_Name_Internal_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x0600194E RID: 6478 RVA: 0x0007AE68 File Offset: 0x00079068
		// (set) Token: 0x0600194F RID: 6479 RVA: 0x0007AEAC File Offset: 0x000790AC
		public unsafe bool Available
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DlcInformation.NativeMethodInfoPtr_get_Available_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DlcInformation.NativeMethodInfoPtr_set_Available_Internal_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x00008313 File Offset: 0x00006513
		public DlcInformation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x0000831C File Offset: 0x0000651C
		public DlcInformation()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DlcInformation>.NativeClassPtr))
		{
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001952 RID: 6482 RVA: 0x0007AEF0 File Offset: 0x000790F0
		// (set) Token: 0x06001953 RID: 6483 RVA: 0x0000832E File Offset: 0x0000652E
		public unsafe AppId _AppId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DlcInformation.NativeFieldInfoPtr__AppId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DlcInformation.NativeFieldInfoPtr__AppId_k__BackingField)) = value;
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001954 RID: 6484 RVA: 0x0007AF18 File Offset: 0x00079118
		// (set) Token: 0x06001955 RID: 6485 RVA: 0x00008349 File Offset: 0x00006549
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DlcInformation.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DlcInformation.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06001956 RID: 6486 RVA: 0x0007AF40 File Offset: 0x00079140
		// (set) Token: 0x06001957 RID: 6487 RVA: 0x00008368 File Offset: 0x00006568
		public unsafe bool _Available_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DlcInformation.NativeFieldInfoPtr__Available_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DlcInformation.NativeFieldInfoPtr__Available_k__BackingField)) = value;
			}
		}

		// Token: 0x04001E89 RID: 7817
		private static readonly IntPtr NativeFieldInfoPtr__AppId_k__BackingField;

		// Token: 0x04001E8A RID: 7818
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04001E8B RID: 7819
		private static readonly IntPtr NativeFieldInfoPtr__Available_k__BackingField;

		// Token: 0x04001E8C RID: 7820
		private static readonly IntPtr NativeMethodInfoPtr_get_AppId_Public_get_AppId_0;

		// Token: 0x04001E8D RID: 7821
		private static readonly IntPtr NativeMethodInfoPtr_set_AppId_Internal_set_Void_AppId_0;

		// Token: 0x04001E8E RID: 7822
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04001E8F RID: 7823
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Internal_set_Void_String_0;

		// Token: 0x04001E90 RID: 7824
		private static readonly IntPtr NativeMethodInfoPtr_get_Available_Public_get_Boolean_0;

		// Token: 0x04001E91 RID: 7825
		private static readonly IntPtr NativeMethodInfoPtr_set_Available_Internal_set_Void_Boolean_0;
	}
}
