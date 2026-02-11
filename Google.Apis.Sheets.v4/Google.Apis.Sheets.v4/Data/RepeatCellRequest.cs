using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000098 RID: 152
	public class RepeatCellRequest : Object
	{
		// Token: 0x06000B97 RID: 2967 RVA: 0x000371CC File Offset: 0x000353CC
		// Note: this type is marked as 'beforefieldinit'.
		static RepeatCellRequest()
		{
			Il2CppClassPointerStore<RepeatCellRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "RepeatCellRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RepeatCellRequest>.NativeClassPtr);
			RepeatCellRequest.NativeFieldInfoPtr__Cell_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatCellRequest>.NativeClassPtr, "<Cell>k__BackingField");
			RepeatCellRequest.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatCellRequest>.NativeClassPtr, "<Fields>k__BackingField");
			RepeatCellRequest.NativeFieldInfoPtr__Range_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatCellRequest>.NativeClassPtr, "<Range>k__BackingField");
			RepeatCellRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatCellRequest>.NativeClassPtr, "<ETag>k__BackingField");
			RepeatCellRequest.NativeMethodInfoPtr_get_Cell_Public_Virtual_New_get_CellData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatCellRequest>.NativeClassPtr, 100664928);
			RepeatCellRequest.NativeMethodInfoPtr_set_Cell_Public_Virtual_New_set_Void_CellData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatCellRequest>.NativeClassPtr, 100664929);
			RepeatCellRequest.NativeMethodInfoPtr_get_Fields_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatCellRequest>.NativeClassPtr, 100664930);
			RepeatCellRequest.NativeMethodInfoPtr_set_Fields_Public_Virtual_New_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatCellRequest>.NativeClassPtr, 100664931);
			RepeatCellRequest.NativeMethodInfoPtr_get_Range_Public_Virtual_New_get_GridRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatCellRequest>.NativeClassPtr, 100664932);
			RepeatCellRequest.NativeMethodInfoPtr_set_Range_Public_Virtual_New_set_Void_GridRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatCellRequest>.NativeClassPtr, 100664933);
			RepeatCellRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatCellRequest>.NativeClassPtr, 100664934);
			RepeatCellRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatCellRequest>.NativeClassPtr, 100664935);
			RepeatCellRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatCellRequest>.NativeClassPtr, 100664936);
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000B98 RID: 2968 RVA: 0x00037300 File Offset: 0x00035500
		// (set) Token: 0x06000B99 RID: 2969 RVA: 0x0003734C File Offset: 0x0003554C
		public unsafe virtual CellData Cell
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RepeatCellRequest.NativeMethodInfoPtr_get_Cell_Public_Virtual_New_get_CellData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CellData>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RepeatCellRequest.NativeMethodInfoPtr_set_Cell_Public_Virtual_New_set_Void_CellData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000B9A RID: 2970 RVA: 0x0003739C File Offset: 0x0003559C
		// (set) Token: 0x06000B9B RID: 2971 RVA: 0x000373E8 File Offset: 0x000355E8
		public unsafe virtual Object Fields
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RepeatCellRequest.NativeMethodInfoPtr_get_Fields_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RepeatCellRequest.NativeMethodInfoPtr_set_Fields_Public_Virtual_New_set_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000B9C RID: 2972 RVA: 0x00037438 File Offset: 0x00035638
		// (set) Token: 0x06000B9D RID: 2973 RVA: 0x00037484 File Offset: 0x00035684
		public unsafe virtual GridRange Range
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RepeatCellRequest.NativeMethodInfoPtr_get_Range_Public_Virtual_New_get_GridRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RepeatCellRequest.NativeMethodInfoPtr_set_Range_Public_Virtual_New_set_Void_GridRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000B9E RID: 2974 RVA: 0x000374D4 File Offset: 0x000356D4
		// (set) Token: 0x06000B9F RID: 2975 RVA: 0x00037518 File Offset: 0x00035718
		public unsafe virtual string ETag
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RepeatCellRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RepeatCellRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x00037568 File Offset: 0x00035768
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RepeatCellRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RepeatCellRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RepeatCellRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x00007952 File Offset: 0x00005B52
		public RepeatCellRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x000375A4 File Offset: 0x000357A4
		// (set) Token: 0x06000BA3 RID: 2979 RVA: 0x0000795B File Offset: 0x00005B5B
		public unsafe CellData _Cell_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepeatCellRequest.NativeFieldInfoPtr__Cell_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CellData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepeatCellRequest.NativeFieldInfoPtr__Cell_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000BA4 RID: 2980 RVA: 0x000375D4 File Offset: 0x000357D4
		// (set) Token: 0x06000BA5 RID: 2981 RVA: 0x0000797A File Offset: 0x00005B7A
		public unsafe Object _Fields_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepeatCellRequest.NativeFieldInfoPtr__Fields_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepeatCellRequest.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000BA6 RID: 2982 RVA: 0x00037604 File Offset: 0x00035804
		// (set) Token: 0x06000BA7 RID: 2983 RVA: 0x00007999 File Offset: 0x00005B99
		public unsafe GridRange _Range_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepeatCellRequest.NativeFieldInfoPtr__Range_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridRange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepeatCellRequest.NativeFieldInfoPtr__Range_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x00037634 File Offset: 0x00035834
		// (set) Token: 0x06000BA9 RID: 2985 RVA: 0x000079B8 File Offset: 0x00005BB8
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepeatCellRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepeatCellRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeFieldInfoPtr__Cell_k__BackingField;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeFieldInfoPtr__Range_k__BackingField;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeMethodInfoPtr_get_Cell_Public_Virtual_New_get_CellData_0;

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeMethodInfoPtr_set_Cell_Public_Virtual_New_set_Void_CellData_0;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_Virtual_New_get_Object_0;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeMethodInfoPtr_set_Fields_Public_Virtual_New_set_Void_Object_0;

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeMethodInfoPtr_get_Range_Public_Virtual_New_get_GridRange_0;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeMethodInfoPtr_set_Range_Public_Virtual_New_set_Void_GridRange_0;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
