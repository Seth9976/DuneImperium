using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000018 RID: 24
	public class AppendValuesResponse : Object
	{
		// Token: 0x0600013B RID: 315 RVA: 0x0000F998 File Offset: 0x0000DB98
		// Note: this type is marked as 'beforefieldinit'.
		static AppendValuesResponse()
		{
			Il2CppClassPointerStore<AppendValuesResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "AppendValuesResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppendValuesResponse>.NativeClassPtr);
			AppendValuesResponse.NativeFieldInfoPtr__SpreadsheetId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppendValuesResponse>.NativeClassPtr, "<SpreadsheetId>k__BackingField");
			AppendValuesResponse.NativeFieldInfoPtr__TableRange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppendValuesResponse>.NativeClassPtr, "<TableRange>k__BackingField");
			AppendValuesResponse.NativeFieldInfoPtr__Updates_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppendValuesResponse>.NativeClassPtr, "<Updates>k__BackingField");
			AppendValuesResponse.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppendValuesResponse>.NativeClassPtr, "<ETag>k__BackingField");
			AppendValuesResponse.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppendValuesResponse>.NativeClassPtr, 100663666);
			AppendValuesResponse.NativeMethodInfoPtr_set_SpreadsheetId_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppendValuesResponse>.NativeClassPtr, 100663667);
			AppendValuesResponse.NativeMethodInfoPtr_get_TableRange_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppendValuesResponse>.NativeClassPtr, 100663668);
			AppendValuesResponse.NativeMethodInfoPtr_set_TableRange_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppendValuesResponse>.NativeClassPtr, 100663669);
			AppendValuesResponse.NativeMethodInfoPtr_get_Updates_Public_Virtual_New_get_UpdateValuesResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppendValuesResponse>.NativeClassPtr, 100663670);
			AppendValuesResponse.NativeMethodInfoPtr_set_Updates_Public_Virtual_New_set_Void_UpdateValuesResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppendValuesResponse>.NativeClassPtr, 100663671);
			AppendValuesResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppendValuesResponse>.NativeClassPtr, 100663672);
			AppendValuesResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppendValuesResponse>.NativeClassPtr, 100663673);
			AppendValuesResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppendValuesResponse>.NativeClassPtr, 100663674);
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600013C RID: 316 RVA: 0x0000FACC File Offset: 0x0000DCCC
		// (set) Token: 0x0600013D RID: 317 RVA: 0x0000FB10 File Offset: 0x0000DD10
		public unsafe virtual string SpreadsheetId
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppendValuesResponse.NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppendValuesResponse.NativeMethodInfoPtr_set_SpreadsheetId_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600013E RID: 318 RVA: 0x0000FB60 File Offset: 0x0000DD60
		// (set) Token: 0x0600013F RID: 319 RVA: 0x0000FBA4 File Offset: 0x0000DDA4
		public unsafe virtual string TableRange
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppendValuesResponse.NativeMethodInfoPtr_get_TableRange_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppendValuesResponse.NativeMethodInfoPtr_set_TableRange_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000140 RID: 320 RVA: 0x0000FBF4 File Offset: 0x0000DDF4
		// (set) Token: 0x06000141 RID: 321 RVA: 0x0000FC40 File Offset: 0x0000DE40
		public unsafe virtual UpdateValuesResponse Updates
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppendValuesResponse.NativeMethodInfoPtr_get_Updates_Public_Virtual_New_get_UpdateValuesResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UpdateValuesResponse>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppendValuesResponse.NativeMethodInfoPtr_set_Updates_Public_Virtual_New_set_Void_UpdateValuesResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000142 RID: 322 RVA: 0x0000FC90 File Offset: 0x0000DE90
		// (set) Token: 0x06000143 RID: 323 RVA: 0x0000FCD4 File Offset: 0x0000DED4
		public unsafe virtual string ETag
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppendValuesResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppendValuesResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000FD24 File Offset: 0x0000DF24
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppendValuesResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppendValuesResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppendValuesResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000028D6 File Offset: 0x00000AD6
		public AppendValuesResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000146 RID: 326 RVA: 0x0000FD60 File Offset: 0x0000DF60
		// (set) Token: 0x06000147 RID: 327 RVA: 0x000028DF File Offset: 0x00000ADF
		public unsafe string _SpreadsheetId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppendValuesResponse.NativeFieldInfoPtr__SpreadsheetId_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppendValuesResponse.NativeFieldInfoPtr__SpreadsheetId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0000FD88 File Offset: 0x0000DF88
		// (set) Token: 0x06000149 RID: 329 RVA: 0x000028FE File Offset: 0x00000AFE
		public unsafe string _TableRange_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppendValuesResponse.NativeFieldInfoPtr__TableRange_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppendValuesResponse.NativeFieldInfoPtr__TableRange_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600014A RID: 330 RVA: 0x0000FDB0 File Offset: 0x0000DFB0
		// (set) Token: 0x0600014B RID: 331 RVA: 0x0000291D File Offset: 0x00000B1D
		public unsafe UpdateValuesResponse _Updates_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppendValuesResponse.NativeFieldInfoPtr__Updates_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateValuesResponse>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppendValuesResponse.NativeFieldInfoPtr__Updates_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600014C RID: 332 RVA: 0x0000FDE0 File Offset: 0x0000DFE0
		// (set) Token: 0x0600014D RID: 333 RVA: 0x0000293C File Offset: 0x00000B3C
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppendValuesResponse.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppendValuesResponse.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeFieldInfoPtr__SpreadsheetId_k__BackingField;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeFieldInfoPtr__TableRange_k__BackingField;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeFieldInfoPtr__Updates_k__BackingField;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_get_SpreadsheetId_Public_Virtual_New_get_String_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_set_SpreadsheetId_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_get_TableRange_Public_Virtual_New_get_String_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_set_TableRange_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_get_Updates_Public_Virtual_New_get_UpdateValuesResponse_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_set_Updates_Public_Virtual_New_set_Void_UpdateValuesResponse_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
