using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000096 RID: 150
	public class ProtectedRange : Object
	{
		// Token: 0x06000B65 RID: 2917 RVA: 0x000365C0 File Offset: 0x000347C0
		// Note: this type is marked as 'beforefieldinit'.
		static ProtectedRange()
		{
			Il2CppClassPointerStore<ProtectedRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "ProtectedRange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProtectedRange>.NativeClassPtr);
			ProtectedRange.NativeFieldInfoPtr__Description_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProtectedRange>.NativeClassPtr, "<Description>k__BackingField");
			ProtectedRange.NativeFieldInfoPtr__Editors_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProtectedRange>.NativeClassPtr, "<Editors>k__BackingField");
			ProtectedRange.NativeFieldInfoPtr__NamedRangeId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProtectedRange>.NativeClassPtr, "<NamedRangeId>k__BackingField");
			ProtectedRange.NativeFieldInfoPtr__ProtectedRangeId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProtectedRange>.NativeClassPtr, "<ProtectedRangeId>k__BackingField");
			ProtectedRange.NativeFieldInfoPtr__Range_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProtectedRange>.NativeClassPtr, "<Range>k__BackingField");
			ProtectedRange.NativeFieldInfoPtr__RequestingUserCanEdit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProtectedRange>.NativeClassPtr, "<RequestingUserCanEdit>k__BackingField");
			ProtectedRange.NativeFieldInfoPtr__UnprotectedRanges_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProtectedRange>.NativeClassPtr, "<UnprotectedRanges>k__BackingField");
			ProtectedRange.NativeFieldInfoPtr__WarningOnly_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProtectedRange>.NativeClassPtr, "<WarningOnly>k__BackingField");
			ProtectedRange.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProtectedRange>.NativeClassPtr, "<ETag>k__BackingField");
			ProtectedRange.NativeMethodInfoPtr_get_Description_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProtectedRange>.NativeClassPtr, 100664904);
			ProtectedRange.NativeMethodInfoPtr_set_Description_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProtectedRange>.NativeClassPtr, 100664905);
			ProtectedRange.NativeMethodInfoPtr_get_Editors_Public_Virtual_New_get_Editors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProtectedRange>.NativeClassPtr, 100664906);
			ProtectedRange.NativeMethodInfoPtr_set_Editors_Public_Virtual_New_set_Void_Editors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProtectedRange>.NativeClassPtr, 100664907);
			ProtectedRange.NativeMethodInfoPtr_get_NamedRangeId_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProtectedRange>.NativeClassPtr, 100664908);
			ProtectedRange.NativeMethodInfoPtr_set_NamedRangeId_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProtectedRange>.NativeClassPtr, 100664909);
			ProtectedRange.NativeMethodInfoPtr_get_ProtectedRangeId_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProtectedRange>.NativeClassPtr, 100664910);
			ProtectedRange.NativeMethodInfoPtr_set_ProtectedRangeId_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProtectedRange>.NativeClassPtr, 100664911);
			ProtectedRange.NativeMethodInfoPtr_get_Range_Public_Virtual_New_get_GridRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProtectedRange>.NativeClassPtr, 100664912);
			ProtectedRange.NativeMethodInfoPtr_set_Range_Public_Virtual_New_set_Void_GridRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProtectedRange>.NativeClassPtr, 100664913);
			ProtectedRange.NativeMethodInfoPtr_get_RequestingUserCanEdit_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProtectedRange>.NativeClassPtr, 100664914);
			ProtectedRange.NativeMethodInfoPtr_set_RequestingUserCanEdit_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProtectedRange>.NativeClassPtr, 100664915);
			ProtectedRange.NativeMethodInfoPtr_get_UnprotectedRanges_Public_Virtual_New_get_IList_1_GridRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProtectedRange>.NativeClassPtr, 100664916);
			ProtectedRange.NativeMethodInfoPtr_set_UnprotectedRanges_Public_Virtual_New_set_Void_IList_1_GridRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProtectedRange>.NativeClassPtr, 100664917);
			ProtectedRange.NativeMethodInfoPtr_get_WarningOnly_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProtectedRange>.NativeClassPtr, 100664918);
			ProtectedRange.NativeMethodInfoPtr_set_WarningOnly_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProtectedRange>.NativeClassPtr, 100664919);
			ProtectedRange.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProtectedRange>.NativeClassPtr, 100664920);
			ProtectedRange.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProtectedRange>.NativeClassPtr, 100664921);
			ProtectedRange.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProtectedRange>.NativeClassPtr, 100664922);
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x00036820 File Offset: 0x00034A20
		// (set) Token: 0x06000B67 RID: 2919 RVA: 0x00036864 File Offset: 0x00034A64
		public unsafe virtual string Description
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProtectedRange.NativeMethodInfoPtr_get_Description_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProtectedRange.NativeMethodInfoPtr_set_Description_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000B68 RID: 2920 RVA: 0x000368B4 File Offset: 0x00034AB4
		// (set) Token: 0x06000B69 RID: 2921 RVA: 0x00036900 File Offset: 0x00034B00
		public unsafe virtual Editors Editors
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProtectedRange.NativeMethodInfoPtr_get_Editors_Public_Virtual_New_get_Editors_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Editors>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProtectedRange.NativeMethodInfoPtr_set_Editors_Public_Virtual_New_set_Void_Editors_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000B6A RID: 2922 RVA: 0x00036950 File Offset: 0x00034B50
		// (set) Token: 0x06000B6B RID: 2923 RVA: 0x00036994 File Offset: 0x00034B94
		public unsafe virtual string NamedRangeId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProtectedRange.NativeMethodInfoPtr_get_NamedRangeId_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProtectedRange.NativeMethodInfoPtr_set_NamedRangeId_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000B6C RID: 2924 RVA: 0x000369E4 File Offset: 0x00034BE4
		// (set) Token: 0x06000B6D RID: 2925 RVA: 0x00036A28 File Offset: 0x00034C28
		public unsafe virtual Nullable<int> ProtectedRangeId
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProtectedRange.NativeMethodInfoPtr_get_ProtectedRangeId_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 312312, RefRangeEnd = 312313, XrefRangeStart = 312312, XrefRangeEnd = 312313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProtectedRange.NativeMethodInfoPtr_set_ProtectedRangeId_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x00036A7C File Offset: 0x00034C7C
		// (set) Token: 0x06000B6F RID: 2927 RVA: 0x00036AC8 File Offset: 0x00034CC8
		public unsafe virtual GridRange Range
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProtectedRange.NativeMethodInfoPtr_get_Range_Public_Virtual_New_get_GridRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GridRange>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProtectedRange.NativeMethodInfoPtr_set_Range_Public_Virtual_New_set_Void_GridRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x00036B18 File Offset: 0x00034D18
		// (set) Token: 0x06000B71 RID: 2929 RVA: 0x00036B5C File Offset: 0x00034D5C
		public unsafe virtual Nullable<bool> RequestingUserCanEdit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProtectedRange.NativeMethodInfoPtr_get_RequestingUserCanEdit_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProtectedRange.NativeMethodInfoPtr_set_RequestingUserCanEdit_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000B72 RID: 2930 RVA: 0x00036BB0 File Offset: 0x00034DB0
		// (set) Token: 0x06000B73 RID: 2931 RVA: 0x00036BFC File Offset: 0x00034DFC
		public unsafe virtual IList<GridRange> UnprotectedRanges
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProtectedRange.NativeMethodInfoPtr_get_UnprotectedRanges_Public_Virtual_New_get_IList_1_GridRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<GridRange>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProtectedRange.NativeMethodInfoPtr_set_UnprotectedRanges_Public_Virtual_New_set_Void_IList_1_GridRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000B74 RID: 2932 RVA: 0x00036C4C File Offset: 0x00034E4C
		// (set) Token: 0x06000B75 RID: 2933 RVA: 0x00036C90 File Offset: 0x00034E90
		public unsafe virtual Nullable<bool> WarningOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProtectedRange.NativeMethodInfoPtr_get_WarningOnly_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProtectedRange.NativeMethodInfoPtr_set_WarningOnly_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x00036CE4 File Offset: 0x00034EE4
		// (set) Token: 0x06000B77 RID: 2935 RVA: 0x00036D28 File Offset: 0x00034F28
		public unsafe virtual string ETag
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProtectedRange.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProtectedRange.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00036D78 File Offset: 0x00034F78
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProtectedRange()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProtectedRange>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProtectedRange.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x000077BE File Offset: 0x000059BE
		public ProtectedRange(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000B7A RID: 2938 RVA: 0x00036DB4 File Offset: 0x00034FB4
		// (set) Token: 0x06000B7B RID: 2939 RVA: 0x000077C7 File Offset: 0x000059C7
		public unsafe string _Description_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProtectedRange.NativeFieldInfoPtr__Description_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProtectedRange.NativeFieldInfoPtr__Description_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000B7C RID: 2940 RVA: 0x00036DDC File Offset: 0x00034FDC
		// (set) Token: 0x06000B7D RID: 2941 RVA: 0x000077E6 File Offset: 0x000059E6
		public unsafe Editors _Editors_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProtectedRange.NativeFieldInfoPtr__Editors_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Editors>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProtectedRange.NativeFieldInfoPtr__Editors_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000B7E RID: 2942 RVA: 0x00036E0C File Offset: 0x0003500C
		// (set) Token: 0x06000B7F RID: 2943 RVA: 0x00007805 File Offset: 0x00005A05
		public unsafe string _NamedRangeId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProtectedRange.NativeFieldInfoPtr__NamedRangeId_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProtectedRange.NativeFieldInfoPtr__NamedRangeId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000B80 RID: 2944 RVA: 0x00036E34 File Offset: 0x00035034
		// (set) Token: 0x06000B81 RID: 2945 RVA: 0x00007824 File Offset: 0x00005A24
		public Nullable<int> _ProtectedRangeId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProtectedRange.NativeFieldInfoPtr__ProtectedRangeId_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProtectedRange.NativeFieldInfoPtr__ProtectedRangeId_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000B82 RID: 2946 RVA: 0x00036E64 File Offset: 0x00035064
		// (set) Token: 0x06000B83 RID: 2947 RVA: 0x00007852 File Offset: 0x00005A52
		public unsafe GridRange _Range_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProtectedRange.NativeFieldInfoPtr__Range_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridRange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProtectedRange.NativeFieldInfoPtr__Range_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000B84 RID: 2948 RVA: 0x00036E94 File Offset: 0x00035094
		// (set) Token: 0x06000B85 RID: 2949 RVA: 0x00007871 File Offset: 0x00005A71
		public Nullable<bool> _RequestingUserCanEdit_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProtectedRange.NativeFieldInfoPtr__RequestingUserCanEdit_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProtectedRange.NativeFieldInfoPtr__RequestingUserCanEdit_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000B86 RID: 2950 RVA: 0x00036EC4 File Offset: 0x000350C4
		// (set) Token: 0x06000B87 RID: 2951 RVA: 0x0000789F File Offset: 0x00005A9F
		public unsafe IList<GridRange> _UnprotectedRanges_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProtectedRange.NativeFieldInfoPtr__UnprotectedRanges_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<GridRange>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProtectedRange.NativeFieldInfoPtr__UnprotectedRanges_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000B88 RID: 2952 RVA: 0x00036EF4 File Offset: 0x000350F4
		// (set) Token: 0x06000B89 RID: 2953 RVA: 0x000078BE File Offset: 0x00005ABE
		public Nullable<bool> _WarningOnly_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProtectedRange.NativeFieldInfoPtr__WarningOnly_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProtectedRange.NativeFieldInfoPtr__WarningOnly_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000B8A RID: 2954 RVA: 0x00036F24 File Offset: 0x00035124
		// (set) Token: 0x06000B8B RID: 2955 RVA: 0x000078EC File Offset: 0x00005AEC
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProtectedRange.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProtectedRange.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeFieldInfoPtr__Description_k__BackingField;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeFieldInfoPtr__Editors_k__BackingField;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeFieldInfoPtr__NamedRangeId_k__BackingField;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeFieldInfoPtr__ProtectedRangeId_k__BackingField;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeFieldInfoPtr__Range_k__BackingField;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeFieldInfoPtr__RequestingUserCanEdit_k__BackingField;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeFieldInfoPtr__UnprotectedRanges_k__BackingField;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeFieldInfoPtr__WarningOnly_k__BackingField;

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeMethodInfoPtr_get_Description_Public_Virtual_New_get_String_0;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeMethodInfoPtr_set_Description_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeMethodInfoPtr_get_Editors_Public_Virtual_New_get_Editors_0;

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeMethodInfoPtr_set_Editors_Public_Virtual_New_set_Void_Editors_0;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeMethodInfoPtr_get_NamedRangeId_Public_Virtual_New_get_String_0;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeMethodInfoPtr_set_NamedRangeId_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeMethodInfoPtr_get_ProtectedRangeId_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeMethodInfoPtr_set_ProtectedRangeId_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeMethodInfoPtr_get_Range_Public_Virtual_New_get_GridRange_0;

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeMethodInfoPtr_set_Range_Public_Virtual_New_set_Void_GridRange_0;

		// Token: 0x040007E6 RID: 2022
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestingUserCanEdit_Public_Virtual_New_get_Nullable_1_Boolean_0;

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeMethodInfoPtr_set_RequestingUserCanEdit_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeMethodInfoPtr_get_UnprotectedRanges_Public_Virtual_New_get_IList_1_GridRange_0;

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeMethodInfoPtr_set_UnprotectedRanges_Public_Virtual_New_set_Void_IList_1_GridRange_0;

		// Token: 0x040007EA RID: 2026
		private static readonly IntPtr NativeMethodInfoPtr_get_WarningOnly_Public_Virtual_New_get_Nullable_1_Boolean_0;

		// Token: 0x040007EB RID: 2027
		private static readonly IntPtr NativeMethodInfoPtr_set_WarningOnly_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

		// Token: 0x040007EC RID: 2028
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040007ED RID: 2029
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
