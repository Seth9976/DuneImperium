using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x020000CC RID: 204
	public class WaterfallChartCustomSubtotal : Object
	{
		// Token: 0x0600112B RID: 4395 RVA: 0x0004CE44 File Offset: 0x0004B044
		// Note: this type is marked as 'beforefieldinit'.
		static WaterfallChartCustomSubtotal()
		{
			Il2CppClassPointerStore<WaterfallChartCustomSubtotal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "WaterfallChartCustomSubtotal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaterfallChartCustomSubtotal>.NativeClassPtr);
			WaterfallChartCustomSubtotal.NativeFieldInfoPtr__DataIsSubtotal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterfallChartCustomSubtotal>.NativeClassPtr, "<DataIsSubtotal>k__BackingField");
			WaterfallChartCustomSubtotal.NativeFieldInfoPtr__Label_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterfallChartCustomSubtotal>.NativeClassPtr, "<Label>k__BackingField");
			WaterfallChartCustomSubtotal.NativeFieldInfoPtr__SubtotalIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterfallChartCustomSubtotal>.NativeClassPtr, "<SubtotalIndex>k__BackingField");
			WaterfallChartCustomSubtotal.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterfallChartCustomSubtotal>.NativeClassPtr, "<ETag>k__BackingField");
			WaterfallChartCustomSubtotal.NativeMethodInfoPtr_get_DataIsSubtotal_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartCustomSubtotal>.NativeClassPtr, 100665616);
			WaterfallChartCustomSubtotal.NativeMethodInfoPtr_set_DataIsSubtotal_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartCustomSubtotal>.NativeClassPtr, 100665617);
			WaterfallChartCustomSubtotal.NativeMethodInfoPtr_get_Label_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartCustomSubtotal>.NativeClassPtr, 100665618);
			WaterfallChartCustomSubtotal.NativeMethodInfoPtr_set_Label_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartCustomSubtotal>.NativeClassPtr, 100665619);
			WaterfallChartCustomSubtotal.NativeMethodInfoPtr_get_SubtotalIndex_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartCustomSubtotal>.NativeClassPtr, 100665620);
			WaterfallChartCustomSubtotal.NativeMethodInfoPtr_set_SubtotalIndex_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartCustomSubtotal>.NativeClassPtr, 100665621);
			WaterfallChartCustomSubtotal.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartCustomSubtotal>.NativeClassPtr, 100665622);
			WaterfallChartCustomSubtotal.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartCustomSubtotal>.NativeClassPtr, 100665623);
			WaterfallChartCustomSubtotal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartCustomSubtotal>.NativeClassPtr, 100665624);
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x0600112C RID: 4396 RVA: 0x0004CF78 File Offset: 0x0004B178
		// (set) Token: 0x0600112D RID: 4397 RVA: 0x0004CFBC File Offset: 0x0004B1BC
		public unsafe virtual Nullable<bool> DataIsSubtotal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartCustomSubtotal.NativeMethodInfoPtr_get_DataIsSubtotal_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartCustomSubtotal.NativeMethodInfoPtr_set_DataIsSubtotal_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x0600112E RID: 4398 RVA: 0x0004D010 File Offset: 0x0004B210
		// (set) Token: 0x0600112F RID: 4399 RVA: 0x0004D054 File Offset: 0x0004B254
		public unsafe virtual string Label
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartCustomSubtotal.NativeMethodInfoPtr_get_Label_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartCustomSubtotal.NativeMethodInfoPtr_set_Label_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06001130 RID: 4400 RVA: 0x0004D0A4 File Offset: 0x0004B2A4
		// (set) Token: 0x06001131 RID: 4401 RVA: 0x0004D0E8 File Offset: 0x0004B2E8
		public unsafe virtual Nullable<int> SubtotalIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartCustomSubtotal.NativeMethodInfoPtr_get_SubtotalIndex_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartCustomSubtotal.NativeMethodInfoPtr_set_SubtotalIndex_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06001132 RID: 4402 RVA: 0x0004D13C File Offset: 0x0004B33C
		// (set) Token: 0x06001133 RID: 4403 RVA: 0x0004D180 File Offset: 0x0004B380
		public unsafe virtual string ETag
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartCustomSubtotal.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartCustomSubtotal.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x0004D1D0 File Offset: 0x0004B3D0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaterfallChartCustomSubtotal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaterfallChartCustomSubtotal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterfallChartCustomSubtotal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x0000A3E2 File Offset: 0x000085E2
		public WaterfallChartCustomSubtotal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06001136 RID: 4406 RVA: 0x0004D20C File Offset: 0x0004B40C
		// (set) Token: 0x06001137 RID: 4407 RVA: 0x0000A3EB File Offset: 0x000085EB
		public Nullable<bool> _DataIsSubtotal_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartCustomSubtotal.NativeFieldInfoPtr__DataIsSubtotal_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartCustomSubtotal.NativeFieldInfoPtr__DataIsSubtotal_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06001138 RID: 4408 RVA: 0x0004D23C File Offset: 0x0004B43C
		// (set) Token: 0x06001139 RID: 4409 RVA: 0x0000A419 File Offset: 0x00008619
		public unsafe string _Label_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartCustomSubtotal.NativeFieldInfoPtr__Label_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartCustomSubtotal.NativeFieldInfoPtr__Label_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x0600113A RID: 4410 RVA: 0x0004D264 File Offset: 0x0004B464
		// (set) Token: 0x0600113B RID: 4411 RVA: 0x0000A438 File Offset: 0x00008638
		public Nullable<int> _SubtotalIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartCustomSubtotal.NativeFieldInfoPtr__SubtotalIndex_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartCustomSubtotal.NativeFieldInfoPtr__SubtotalIndex_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x0600113C RID: 4412 RVA: 0x0004D294 File Offset: 0x0004B494
		// (set) Token: 0x0600113D RID: 4413 RVA: 0x0000A466 File Offset: 0x00008666
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartCustomSubtotal.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartCustomSubtotal.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000BE4 RID: 3044
		private static readonly IntPtr NativeFieldInfoPtr__DataIsSubtotal_k__BackingField;

		// Token: 0x04000BE5 RID: 3045
		private static readonly IntPtr NativeFieldInfoPtr__Label_k__BackingField;

		// Token: 0x04000BE6 RID: 3046
		private static readonly IntPtr NativeFieldInfoPtr__SubtotalIndex_k__BackingField;

		// Token: 0x04000BE7 RID: 3047
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000BE8 RID: 3048
		private static readonly IntPtr NativeMethodInfoPtr_get_DataIsSubtotal_Public_Virtual_New_get_Nullable_1_Boolean_0;

		// Token: 0x04000BE9 RID: 3049
		private static readonly IntPtr NativeMethodInfoPtr_set_DataIsSubtotal_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

		// Token: 0x04000BEA RID: 3050
		private static readonly IntPtr NativeMethodInfoPtr_get_Label_Public_Virtual_New_get_String_0;

		// Token: 0x04000BEB RID: 3051
		private static readonly IntPtr NativeMethodInfoPtr_set_Label_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000BEC RID: 3052
		private static readonly IntPtr NativeMethodInfoPtr_get_SubtotalIndex_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x04000BED RID: 3053
		private static readonly IntPtr NativeMethodInfoPtr_set_SubtotalIndex_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000BEE RID: 3054
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000BEF RID: 3055
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000BF0 RID: 3056
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
