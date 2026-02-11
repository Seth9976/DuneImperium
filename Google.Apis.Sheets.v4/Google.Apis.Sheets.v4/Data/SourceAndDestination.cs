using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x020000A7 RID: 167
	public class SourceAndDestination : Object
	{
		// Token: 0x06000E2C RID: 3628 RVA: 0x00041698 File Offset: 0x0003F898
		// Note: this type is marked as 'beforefieldinit'.
		static SourceAndDestination()
		{
			Il2CppClassPointerStore<SourceAndDestination>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "SourceAndDestination");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SourceAndDestination>.NativeClassPtr);
			SourceAndDestination.NativeFieldInfoPtr__Dimension_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceAndDestination>.NativeClassPtr, "<Dimension>k__BackingField");
			SourceAndDestination.NativeFieldInfoPtr__FillLength_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceAndDestination>.NativeClassPtr, "<FillLength>k__BackingField");
			SourceAndDestination.NativeFieldInfoPtr__Source_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceAndDestination>.NativeClassPtr, "<Source>k__BackingField");
			SourceAndDestination.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceAndDestination>.NativeClassPtr, "<ETag>k__BackingField");
			SourceAndDestination.NativeMethodInfoPtr_get_Dimension_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceAndDestination>.NativeClassPtr, 100665251);
			SourceAndDestination.NativeMethodInfoPtr_set_Dimension_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceAndDestination>.NativeClassPtr, 100665252);
			SourceAndDestination.NativeMethodInfoPtr_get_FillLength_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceAndDestination>.NativeClassPtr, 100665253);
			SourceAndDestination.NativeMethodInfoPtr_set_FillLength_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceAndDestination>.NativeClassPtr, 100665254);
			SourceAndDestination.NativeMethodInfoPtr_get_Source_Public_Virtual_New_get_GridRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceAndDestination>.NativeClassPtr, 100665255);
			SourceAndDestination.NativeMethodInfoPtr_set_Source_Public_Virtual_New_set_Void_GridRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceAndDestination>.NativeClassPtr, 100665256);
			SourceAndDestination.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceAndDestination>.NativeClassPtr, 100665257);
			SourceAndDestination.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceAndDestination>.NativeClassPtr, 100665258);
			SourceAndDestination.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceAndDestination>.NativeClassPtr, 100665259);
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x000417CC File Offset: 0x0003F9CC
		// (set) Token: 0x06000E2E RID: 3630 RVA: 0x00041810 File Offset: 0x0003FA10
		public unsafe virtual string Dimension
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SourceAndDestination.NativeMethodInfoPtr_get_Dimension_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SourceAndDestination.NativeMethodInfoPtr_set_Dimension_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06000E2F RID: 3631 RVA: 0x00041860 File Offset: 0x0003FA60
		// (set) Token: 0x06000E30 RID: 3632 RVA: 0x000418A4 File Offset: 0x0003FAA4
		public unsafe virtual Nullable<int> FillLength
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SourceAndDestination.NativeMethodInfoPtr_get_FillLength_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SourceAndDestination.NativeMethodInfoPtr_set_FillLength_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06000E31 RID: 3633 RVA: 0x000418F8 File Offset: 0x0003FAF8
		// (set) Token: 0x06000E32 RID: 3634 RVA: 0x00041944 File Offset: 0x0003FB44
		public unsafe virtual GridRange Source
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SourceAndDestination.NativeMethodInfoPtr_get_Source_Public_Virtual_New_get_GridRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SourceAndDestination.NativeMethodInfoPtr_set_Source_Public_Virtual_New_set_Void_GridRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06000E33 RID: 3635 RVA: 0x00041994 File Offset: 0x0003FB94
		// (set) Token: 0x06000E34 RID: 3636 RVA: 0x000419D8 File Offset: 0x0003FBD8
		public unsafe virtual string ETag
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SourceAndDestination.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SourceAndDestination.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x00041A28 File Offset: 0x0003FC28
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SourceAndDestination()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SourceAndDestination>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceAndDestination.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x00008D06 File Offset: 0x00006F06
		public SourceAndDestination(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06000E37 RID: 3639 RVA: 0x00041A64 File Offset: 0x0003FC64
		// (set) Token: 0x06000E38 RID: 3640 RVA: 0x00008D0F File Offset: 0x00006F0F
		public unsafe string _Dimension_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceAndDestination.NativeFieldInfoPtr__Dimension_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceAndDestination.NativeFieldInfoPtr__Dimension_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06000E39 RID: 3641 RVA: 0x00041A8C File Offset: 0x0003FC8C
		// (set) Token: 0x06000E3A RID: 3642 RVA: 0x00008D2E File Offset: 0x00006F2E
		public Nullable<int> _FillLength_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceAndDestination.NativeFieldInfoPtr__FillLength_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceAndDestination.NativeFieldInfoPtr__FillLength_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06000E3B RID: 3643 RVA: 0x00041ABC File Offset: 0x0003FCBC
		// (set) Token: 0x06000E3C RID: 3644 RVA: 0x00008D5C File Offset: 0x00006F5C
		public unsafe GridRange _Source_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceAndDestination.NativeFieldInfoPtr__Source_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridRange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceAndDestination.NativeFieldInfoPtr__Source_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06000E3D RID: 3645 RVA: 0x00041AEC File Offset: 0x0003FCEC
		// (set) Token: 0x06000E3E RID: 3646 RVA: 0x00008D7B File Offset: 0x00006F7B
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceAndDestination.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceAndDestination.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040009D3 RID: 2515
		private static readonly IntPtr NativeFieldInfoPtr__Dimension_k__BackingField;

		// Token: 0x040009D4 RID: 2516
		private static readonly IntPtr NativeFieldInfoPtr__FillLength_k__BackingField;

		// Token: 0x040009D5 RID: 2517
		private static readonly IntPtr NativeFieldInfoPtr__Source_k__BackingField;

		// Token: 0x040009D6 RID: 2518
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040009D7 RID: 2519
		private static readonly IntPtr NativeMethodInfoPtr_get_Dimension_Public_Virtual_New_get_String_0;

		// Token: 0x040009D8 RID: 2520
		private static readonly IntPtr NativeMethodInfoPtr_set_Dimension_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040009D9 RID: 2521
		private static readonly IntPtr NativeMethodInfoPtr_get_FillLength_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x040009DA RID: 2522
		private static readonly IntPtr NativeMethodInfoPtr_set_FillLength_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x040009DB RID: 2523
		private static readonly IntPtr NativeMethodInfoPtr_get_Source_Public_Virtual_New_get_GridRange_0;

		// Token: 0x040009DC RID: 2524
		private static readonly IntPtr NativeMethodInfoPtr_set_Source_Public_Virtual_New_set_Void_GridRange_0;

		// Token: 0x040009DD RID: 2525
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040009DE RID: 2526
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040009DF RID: 2527
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
