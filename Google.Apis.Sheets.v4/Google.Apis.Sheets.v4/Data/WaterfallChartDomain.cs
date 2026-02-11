using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x020000CD RID: 205
	public class WaterfallChartDomain : Object
	{
		// Token: 0x0600113E RID: 4414 RVA: 0x0004D2BC File Offset: 0x0004B4BC
		// Note: this type is marked as 'beforefieldinit'.
		static WaterfallChartDomain()
		{
			Il2CppClassPointerStore<WaterfallChartDomain>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "WaterfallChartDomain");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaterfallChartDomain>.NativeClassPtr);
			WaterfallChartDomain.NativeFieldInfoPtr__Data_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterfallChartDomain>.NativeClassPtr, "<Data>k__BackingField");
			WaterfallChartDomain.NativeFieldInfoPtr__Reversed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterfallChartDomain>.NativeClassPtr, "<Reversed>k__BackingField");
			WaterfallChartDomain.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterfallChartDomain>.NativeClassPtr, "<ETag>k__BackingField");
			WaterfallChartDomain.NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_ChartData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartDomain>.NativeClassPtr, 100665625);
			WaterfallChartDomain.NativeMethodInfoPtr_set_Data_Public_Virtual_New_set_Void_ChartData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartDomain>.NativeClassPtr, 100665626);
			WaterfallChartDomain.NativeMethodInfoPtr_get_Reversed_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartDomain>.NativeClassPtr, 100665627);
			WaterfallChartDomain.NativeMethodInfoPtr_set_Reversed_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartDomain>.NativeClassPtr, 100665628);
			WaterfallChartDomain.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartDomain>.NativeClassPtr, 100665629);
			WaterfallChartDomain.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartDomain>.NativeClassPtr, 100665630);
			WaterfallChartDomain.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartDomain>.NativeClassPtr, 100665631);
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x0600113F RID: 4415 RVA: 0x0004D3B4 File Offset: 0x0004B5B4
		// (set) Token: 0x06001140 RID: 4416 RVA: 0x0004D400 File Offset: 0x0004B600
		public unsafe virtual ChartData Data
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartDomain.NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_ChartData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChartData>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartDomain.NativeMethodInfoPtr_set_Data_Public_Virtual_New_set_Void_ChartData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06001141 RID: 4417 RVA: 0x0004D450 File Offset: 0x0004B650
		// (set) Token: 0x06001142 RID: 4418 RVA: 0x0004D494 File Offset: 0x0004B694
		public unsafe virtual Nullable<bool> Reversed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartDomain.NativeMethodInfoPtr_get_Reversed_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartDomain.NativeMethodInfoPtr_set_Reversed_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06001143 RID: 4419 RVA: 0x0004D4E8 File Offset: 0x0004B6E8
		// (set) Token: 0x06001144 RID: 4420 RVA: 0x0004D52C File Offset: 0x0004B72C
		public unsafe virtual string ETag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartDomain.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartDomain.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x0004D57C File Offset: 0x0004B77C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaterfallChartDomain()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaterfallChartDomain>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterfallChartDomain.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x0000A485 File Offset: 0x00008685
		public WaterfallChartDomain(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06001147 RID: 4423 RVA: 0x0004D5B8 File Offset: 0x0004B7B8
		// (set) Token: 0x06001148 RID: 4424 RVA: 0x0000A48E File Offset: 0x0000868E
		public unsafe ChartData _Data_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartDomain.NativeFieldInfoPtr__Data_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChartData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartDomain.NativeFieldInfoPtr__Data_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06001149 RID: 4425 RVA: 0x0004D5E8 File Offset: 0x0004B7E8
		// (set) Token: 0x0600114A RID: 4426 RVA: 0x0000A4AD File Offset: 0x000086AD
		public Nullable<bool> _Reversed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartDomain.NativeFieldInfoPtr__Reversed_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartDomain.NativeFieldInfoPtr__Reversed_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x0600114B RID: 4427 RVA: 0x0004D618 File Offset: 0x0004B818
		// (set) Token: 0x0600114C RID: 4428 RVA: 0x0000A4DB File Offset: 0x000086DB
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartDomain.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartDomain.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000BF1 RID: 3057
		private static readonly IntPtr NativeFieldInfoPtr__Data_k__BackingField;

		// Token: 0x04000BF2 RID: 3058
		private static readonly IntPtr NativeFieldInfoPtr__Reversed_k__BackingField;

		// Token: 0x04000BF3 RID: 3059
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000BF4 RID: 3060
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_ChartData_0;

		// Token: 0x04000BF5 RID: 3061
		private static readonly IntPtr NativeMethodInfoPtr_set_Data_Public_Virtual_New_set_Void_ChartData_0;

		// Token: 0x04000BF6 RID: 3062
		private static readonly IntPtr NativeMethodInfoPtr_get_Reversed_Public_Virtual_New_get_Nullable_1_Boolean_0;

		// Token: 0x04000BF7 RID: 3063
		private static readonly IntPtr NativeMethodInfoPtr_set_Reversed_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

		// Token: 0x04000BF8 RID: 3064
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000BF9 RID: 3065
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000BFA RID: 3066
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
