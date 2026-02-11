using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x020000C9 RID: 201
	public class UpdateValuesResponse : Object
	{
		// Token: 0x060010E6 RID: 4326 RVA: 0x0004BDD8 File Offset: 0x00049FD8
		// Note: this type is marked as 'beforefieldinit'.
		static UpdateValuesResponse()
		{
			Il2CppClassPointerStore<UpdateValuesResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "UpdateValuesResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateValuesResponse>.NativeClassPtr);
			UpdateValuesResponse.NativeFieldInfoPtr__SpreadsheetId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateValuesResponse>.NativeClassPtr, "<SpreadsheetId>k__BackingField");
			UpdateValuesResponse.NativeFieldInfoPtr__UpdatedCells_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateValuesResponse>.NativeClassPtr, "<UpdatedCells>k__BackingField");
			UpdateValuesResponse.NativeFieldInfoPtr__UpdatedColumns_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateValuesResponse>.NativeClassPtr, "<UpdatedColumns>k__BackingField");
			UpdateValuesResponse.NativeFieldInfoPtr__UpdatedData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateValuesResponse>.NativeClassPtr, "<UpdatedData>k__BackingField");
			UpdateValuesResponse.NativeFieldInfoPtr__UpdatedRange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateValuesResponse>.NativeClassPtr, "<UpdatedRange>k__BackingField");
			UpdateValuesResponse.NativeFieldInfoPtr__UpdatedRows_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateValuesResponse>.NativeClassPtr, "<UpdatedRows>k__BackingField");
			UpdateValuesResponse.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateValuesResponse>.NativeClassPtr, "<ETag>k__BackingField");
			UpdateValuesResponse.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateValuesResponse>.NativeClassPtr, 100665583);
			UpdateValuesResponse.NativeMethodInfoPtr_set_SpreadsheetId_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateValuesResponse>.NativeClassPtr, 100665584);
			UpdateValuesResponse.NativeMethodInfoPtr_get_UpdatedCells_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateValuesResponse>.NativeClassPtr, 100665585);
			UpdateValuesResponse.NativeMethodInfoPtr_set_UpdatedCells_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateValuesResponse>.NativeClassPtr, 100665586);
			UpdateValuesResponse.NativeMethodInfoPtr_get_UpdatedColumns_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateValuesResponse>.NativeClassPtr, 100665587);
			UpdateValuesResponse.NativeMethodInfoPtr_set_UpdatedColumns_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateValuesResponse>.NativeClassPtr, 100665588);
			UpdateValuesResponse.NativeMethodInfoPtr_get_UpdatedData_Public_Virtual_New_get_ValueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateValuesResponse>.NativeClassPtr, 100665589);
			UpdateValuesResponse.NativeMethodInfoPtr_set_UpdatedData_Public_Virtual_New_set_Void_ValueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateValuesResponse>.NativeClassPtr, 100665590);
			UpdateValuesResponse.NativeMethodInfoPtr_get_UpdatedRange_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateValuesResponse>.NativeClassPtr, 100665591);
			UpdateValuesResponse.NativeMethodInfoPtr_set_UpdatedRange_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateValuesResponse>.NativeClassPtr, 100665592);
			UpdateValuesResponse.NativeMethodInfoPtr_get_UpdatedRows_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateValuesResponse>.NativeClassPtr, 100665593);
			UpdateValuesResponse.NativeMethodInfoPtr_set_UpdatedRows_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateValuesResponse>.NativeClassPtr, 100665594);
			UpdateValuesResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateValuesResponse>.NativeClassPtr, 100665595);
			UpdateValuesResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateValuesResponse>.NativeClassPtr, 100665596);
			UpdateValuesResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateValuesResponse>.NativeClassPtr, 100665597);
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x060010E7 RID: 4327 RVA: 0x0004BFC0 File Offset: 0x0004A1C0
		// (set) Token: 0x060010E8 RID: 4328 RVA: 0x0004C004 File Offset: 0x0004A204
		public unsafe virtual string SpreadsheetId
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateValuesResponse.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateValuesResponse.NativeMethodInfoPtr_set_SpreadsheetId_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x060010E9 RID: 4329 RVA: 0x0004C054 File Offset: 0x0004A254
		// (set) Token: 0x060010EA RID: 4330 RVA: 0x0004C098 File Offset: 0x0004A298
		public unsafe virtual Nullable<int> UpdatedCells
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateValuesResponse.NativeMethodInfoPtr_get_UpdatedCells_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateValuesResponse.NativeMethodInfoPtr_set_UpdatedCells_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x060010EB RID: 4331 RVA: 0x0004C0EC File Offset: 0x0004A2EC
		// (set) Token: 0x060010EC RID: 4332 RVA: 0x0004C130 File Offset: 0x0004A330
		public unsafe virtual Nullable<int> UpdatedColumns
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateValuesResponse.NativeMethodInfoPtr_get_UpdatedColumns_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateValuesResponse.NativeMethodInfoPtr_set_UpdatedColumns_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x060010ED RID: 4333 RVA: 0x0004C184 File Offset: 0x0004A384
		// (set) Token: 0x060010EE RID: 4334 RVA: 0x0004C1D0 File Offset: 0x0004A3D0
		public unsafe virtual ValueRange UpdatedData
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateValuesResponse.NativeMethodInfoPtr_get_UpdatedData_Public_Virtual_New_get_ValueRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValueRange>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateValuesResponse.NativeMethodInfoPtr_set_UpdatedData_Public_Virtual_New_set_Void_ValueRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x060010EF RID: 4335 RVA: 0x0004C220 File Offset: 0x0004A420
		// (set) Token: 0x060010F0 RID: 4336 RVA: 0x0004C264 File Offset: 0x0004A464
		public unsafe virtual string UpdatedRange
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateValuesResponse.NativeMethodInfoPtr_get_UpdatedRange_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateValuesResponse.NativeMethodInfoPtr_set_UpdatedRange_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x060010F1 RID: 4337 RVA: 0x0004C2B4 File Offset: 0x0004A4B4
		// (set) Token: 0x060010F2 RID: 4338 RVA: 0x0004C2F8 File Offset: 0x0004A4F8
		public unsafe virtual Nullable<int> UpdatedRows
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateValuesResponse.NativeMethodInfoPtr_get_UpdatedRows_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateValuesResponse.NativeMethodInfoPtr_set_UpdatedRows_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x060010F3 RID: 4339 RVA: 0x0004C34C File Offset: 0x0004A54C
		// (set) Token: 0x060010F4 RID: 4340 RVA: 0x0004C390 File Offset: 0x0004A590
		public unsafe virtual string ETag
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateValuesResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateValuesResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x0004C3E0 File Offset: 0x0004A5E0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UpdateValuesResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateValuesResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateValuesResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x0000A1C9 File Offset: 0x000083C9
		public UpdateValuesResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x060010F7 RID: 4343 RVA: 0x0004C41C File Offset: 0x0004A61C
		// (set) Token: 0x060010F8 RID: 4344 RVA: 0x0000A1D2 File Offset: 0x000083D2
		public unsafe string _SpreadsheetId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateValuesResponse.NativeFieldInfoPtr__SpreadsheetId_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateValuesResponse.NativeFieldInfoPtr__SpreadsheetId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x060010F9 RID: 4345 RVA: 0x0004C444 File Offset: 0x0004A644
		// (set) Token: 0x060010FA RID: 4346 RVA: 0x0000A1F1 File Offset: 0x000083F1
		public Nullable<int> _UpdatedCells_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateValuesResponse.NativeFieldInfoPtr__UpdatedCells_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateValuesResponse.NativeFieldInfoPtr__UpdatedCells_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x060010FB RID: 4347 RVA: 0x0004C474 File Offset: 0x0004A674
		// (set) Token: 0x060010FC RID: 4348 RVA: 0x0000A21F File Offset: 0x0000841F
		public Nullable<int> _UpdatedColumns_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateValuesResponse.NativeFieldInfoPtr__UpdatedColumns_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateValuesResponse.NativeFieldInfoPtr__UpdatedColumns_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x0004C4A4 File Offset: 0x0004A6A4
		// (set) Token: 0x060010FE RID: 4350 RVA: 0x0000A24D File Offset: 0x0000844D
		public unsafe ValueRange _UpdatedData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateValuesResponse.NativeFieldInfoPtr__UpdatedData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueRange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateValuesResponse.NativeFieldInfoPtr__UpdatedData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x060010FF RID: 4351 RVA: 0x0004C4D4 File Offset: 0x0004A6D4
		// (set) Token: 0x06001100 RID: 4352 RVA: 0x0000A26C File Offset: 0x0000846C
		public unsafe string _UpdatedRange_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateValuesResponse.NativeFieldInfoPtr__UpdatedRange_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateValuesResponse.NativeFieldInfoPtr__UpdatedRange_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06001101 RID: 4353 RVA: 0x0004C4FC File Offset: 0x0004A6FC
		// (set) Token: 0x06001102 RID: 4354 RVA: 0x0000A28B File Offset: 0x0000848B
		public Nullable<int> _UpdatedRows_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateValuesResponse.NativeFieldInfoPtr__UpdatedRows_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateValuesResponse.NativeFieldInfoPtr__UpdatedRows_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06001103 RID: 4355 RVA: 0x0004C52C File Offset: 0x0004A72C
		// (set) Token: 0x06001104 RID: 4356 RVA: 0x0000A2B9 File Offset: 0x000084B9
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateValuesResponse.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateValuesResponse.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000BB4 RID: 2996
		private static readonly IntPtr NativeFieldInfoPtr__SpreadsheetId_k__BackingField;

		// Token: 0x04000BB5 RID: 2997
		private static readonly IntPtr NativeFieldInfoPtr__UpdatedCells_k__BackingField;

		// Token: 0x04000BB6 RID: 2998
		private static readonly IntPtr NativeFieldInfoPtr__UpdatedColumns_k__BackingField;

		// Token: 0x04000BB7 RID: 2999
		private static readonly IntPtr NativeFieldInfoPtr__UpdatedData_k__BackingField;

		// Token: 0x04000BB8 RID: 3000
		private static readonly IntPtr NativeFieldInfoPtr__UpdatedRange_k__BackingField;

		// Token: 0x04000BB9 RID: 3001
		private static readonly IntPtr NativeFieldInfoPtr__UpdatedRows_k__BackingField;

		// Token: 0x04000BBA RID: 3002
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000BBB RID: 3003
		private static readonly IntPtr NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0;

		// Token: 0x04000BBC RID: 3004
		private static readonly IntPtr NativeMethodInfoPtr_set_SpreadsheetId_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000BBD RID: 3005
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdatedCells_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x04000BBE RID: 3006
		private static readonly IntPtr NativeMethodInfoPtr_set_UpdatedCells_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000BBF RID: 3007
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdatedColumns_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x04000BC0 RID: 3008
		private static readonly IntPtr NativeMethodInfoPtr_set_UpdatedColumns_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000BC1 RID: 3009
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdatedData_Public_Virtual_New_get_ValueRange_0;

		// Token: 0x04000BC2 RID: 3010
		private static readonly IntPtr NativeMethodInfoPtr_set_UpdatedData_Public_Virtual_New_set_Void_ValueRange_0;

		// Token: 0x04000BC3 RID: 3011
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdatedRange_Public_Virtual_New_get_String_0;

		// Token: 0x04000BC4 RID: 3012
		private static readonly IntPtr NativeMethodInfoPtr_set_UpdatedRange_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000BC5 RID: 3013
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdatedRows_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x04000BC6 RID: 3014
		private static readonly IntPtr NativeMethodInfoPtr_set_UpdatedRows_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000BC7 RID: 3015
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000BC8 RID: 3016
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000BC9 RID: 3017
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
