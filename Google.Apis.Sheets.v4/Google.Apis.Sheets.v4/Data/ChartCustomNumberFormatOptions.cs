using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200003C RID: 60
	public class ChartCustomNumberFormatOptions : Object
	{
		// Token: 0x060004A3 RID: 1187 RVA: 0x0001CB68 File Offset: 0x0001AD68
		// Note: this type is marked as 'beforefieldinit'.
		static ChartCustomNumberFormatOptions()
		{
			Il2CppClassPointerStore<ChartCustomNumberFormatOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "ChartCustomNumberFormatOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChartCustomNumberFormatOptions>.NativeClassPtr);
			ChartCustomNumberFormatOptions.NativeFieldInfoPtr__Prefix_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartCustomNumberFormatOptions>.NativeClassPtr, "<Prefix>k__BackingField");
			ChartCustomNumberFormatOptions.NativeFieldInfoPtr__Suffix_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartCustomNumberFormatOptions>.NativeClassPtr, "<Suffix>k__BackingField");
			ChartCustomNumberFormatOptions.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartCustomNumberFormatOptions>.NativeClassPtr, "<ETag>k__BackingField");
			ChartCustomNumberFormatOptions.NativeMethodInfoPtr_get_Prefix_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCustomNumberFormatOptions>.NativeClassPtr, 100664084);
			ChartCustomNumberFormatOptions.NativeMethodInfoPtr_set_Prefix_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCustomNumberFormatOptions>.NativeClassPtr, 100664085);
			ChartCustomNumberFormatOptions.NativeMethodInfoPtr_get_Suffix_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCustomNumberFormatOptions>.NativeClassPtr, 100664086);
			ChartCustomNumberFormatOptions.NativeMethodInfoPtr_set_Suffix_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCustomNumberFormatOptions>.NativeClassPtr, 100664087);
			ChartCustomNumberFormatOptions.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCustomNumberFormatOptions>.NativeClassPtr, 100664088);
			ChartCustomNumberFormatOptions.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCustomNumberFormatOptions>.NativeClassPtr, 100664089);
			ChartCustomNumberFormatOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartCustomNumberFormatOptions>.NativeClassPtr, 100664090);
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x0001CC60 File Offset: 0x0001AE60
		// (set) Token: 0x060004A5 RID: 1189 RVA: 0x0001CCA4 File Offset: 0x0001AEA4
		public unsafe virtual string Prefix
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChartCustomNumberFormatOptions.NativeMethodInfoPtr_get_Prefix_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChartCustomNumberFormatOptions.NativeMethodInfoPtr_set_Prefix_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x0001CCF4 File Offset: 0x0001AEF4
		// (set) Token: 0x060004A7 RID: 1191 RVA: 0x0001CD38 File Offset: 0x0001AF38
		public unsafe virtual string Suffix
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChartCustomNumberFormatOptions.NativeMethodInfoPtr_get_Suffix_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChartCustomNumberFormatOptions.NativeMethodInfoPtr_set_Suffix_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x0001CD88 File Offset: 0x0001AF88
		// (set) Token: 0x060004A9 RID: 1193 RVA: 0x0001CDCC File Offset: 0x0001AFCC
		public unsafe virtual string ETag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChartCustomNumberFormatOptions.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChartCustomNumberFormatOptions.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0001CE1C File Offset: 0x0001B01C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChartCustomNumberFormatOptions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChartCustomNumberFormatOptions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChartCustomNumberFormatOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x000042C1 File Offset: 0x000024C1
		public ChartCustomNumberFormatOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x0001CE58 File Offset: 0x0001B058
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x000042CA File Offset: 0x000024CA
		public unsafe string _Prefix_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChartCustomNumberFormatOptions.NativeFieldInfoPtr__Prefix_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChartCustomNumberFormatOptions.NativeFieldInfoPtr__Prefix_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x0001CE80 File Offset: 0x0001B080
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x000042E9 File Offset: 0x000024E9
		public unsafe string _Suffix_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChartCustomNumberFormatOptions.NativeFieldInfoPtr__Suffix_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChartCustomNumberFormatOptions.NativeFieldInfoPtr__Suffix_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x0001CEA8 File Offset: 0x0001B0A8
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x00004308 File Offset: 0x00002508
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChartCustomNumberFormatOptions.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChartCustomNumberFormatOptions.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeFieldInfoPtr__Prefix_k__BackingField;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeFieldInfoPtr__Suffix_k__BackingField;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_Virtual_New_get_String_0;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeMethodInfoPtr_set_Prefix_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeMethodInfoPtr_get_Suffix_Public_Virtual_New_get_String_0;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeMethodInfoPtr_set_Suffix_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
