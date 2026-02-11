using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x020000B9 RID: 185
	public class UpdateChartSpecRequest : Object
	{
		// Token: 0x06000FCE RID: 4046 RVA: 0x00047B44 File Offset: 0x00045D44
		// Note: this type is marked as 'beforefieldinit'.
		static UpdateChartSpecRequest()
		{
			Il2CppClassPointerStore<UpdateChartSpecRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "UpdateChartSpecRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateChartSpecRequest>.NativeClassPtr);
			UpdateChartSpecRequest.NativeFieldInfoPtr__ChartId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateChartSpecRequest>.NativeClassPtr, "<ChartId>k__BackingField");
			UpdateChartSpecRequest.NativeFieldInfoPtr__Spec_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateChartSpecRequest>.NativeClassPtr, "<Spec>k__BackingField");
			UpdateChartSpecRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateChartSpecRequest>.NativeClassPtr, "<ETag>k__BackingField");
			UpdateChartSpecRequest.NativeMethodInfoPtr_get_ChartId_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateChartSpecRequest>.NativeClassPtr, 100665451);
			UpdateChartSpecRequest.NativeMethodInfoPtr_set_ChartId_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateChartSpecRequest>.NativeClassPtr, 100665452);
			UpdateChartSpecRequest.NativeMethodInfoPtr_get_Spec_Public_Virtual_New_get_ChartSpec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateChartSpecRequest>.NativeClassPtr, 100665453);
			UpdateChartSpecRequest.NativeMethodInfoPtr_set_Spec_Public_Virtual_New_set_Void_ChartSpec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateChartSpecRequest>.NativeClassPtr, 100665454);
			UpdateChartSpecRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateChartSpecRequest>.NativeClassPtr, 100665455);
			UpdateChartSpecRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateChartSpecRequest>.NativeClassPtr, 100665456);
			UpdateChartSpecRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateChartSpecRequest>.NativeClassPtr, 100665457);
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06000FCF RID: 4047 RVA: 0x00047C3C File Offset: 0x00045E3C
		// (set) Token: 0x06000FD0 RID: 4048 RVA: 0x00047C80 File Offset: 0x00045E80
		public unsafe virtual Nullable<int> ChartId
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateChartSpecRequest.NativeMethodInfoPtr_get_ChartId_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateChartSpecRequest.NativeMethodInfoPtr_set_ChartId_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06000FD1 RID: 4049 RVA: 0x00047CD4 File Offset: 0x00045ED4
		// (set) Token: 0x06000FD2 RID: 4050 RVA: 0x00047D20 File Offset: 0x00045F20
		public unsafe virtual ChartSpec Spec
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateChartSpecRequest.NativeMethodInfoPtr_get_Spec_Public_Virtual_New_get_ChartSpec_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChartSpec>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateChartSpecRequest.NativeMethodInfoPtr_set_Spec_Public_Virtual_New_set_Void_ChartSpec_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x00047D70 File Offset: 0x00045F70
		// (set) Token: 0x06000FD4 RID: 4052 RVA: 0x00047DB4 File Offset: 0x00045FB4
		public unsafe virtual string ETag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateChartSpecRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateChartSpecRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x00047E04 File Offset: 0x00046004
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UpdateChartSpecRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateChartSpecRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateChartSpecRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x0000998E File Offset: 0x00007B8E
		public UpdateChartSpecRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06000FD7 RID: 4055 RVA: 0x00047E40 File Offset: 0x00046040
		// (set) Token: 0x06000FD8 RID: 4056 RVA: 0x00009997 File Offset: 0x00007B97
		public Nullable<int> _ChartId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateChartSpecRequest.NativeFieldInfoPtr__ChartId_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateChartSpecRequest.NativeFieldInfoPtr__ChartId_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x00047E70 File Offset: 0x00046070
		// (set) Token: 0x06000FDA RID: 4058 RVA: 0x000099C5 File Offset: 0x00007BC5
		public unsafe ChartSpec _Spec_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateChartSpecRequest.NativeFieldInfoPtr__Spec_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChartSpec>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateChartSpecRequest.NativeFieldInfoPtr__Spec_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06000FDB RID: 4059 RVA: 0x00047EA0 File Offset: 0x000460A0
		// (set) Token: 0x06000FDC RID: 4060 RVA: 0x000099E4 File Offset: 0x00007BE4
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateChartSpecRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateChartSpecRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000AF6 RID: 2806
		private static readonly IntPtr NativeFieldInfoPtr__ChartId_k__BackingField;

		// Token: 0x04000AF7 RID: 2807
		private static readonly IntPtr NativeFieldInfoPtr__Spec_k__BackingField;

		// Token: 0x04000AF8 RID: 2808
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000AF9 RID: 2809
		private static readonly IntPtr NativeMethodInfoPtr_get_ChartId_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x04000AFA RID: 2810
		private static readonly IntPtr NativeMethodInfoPtr_set_ChartId_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000AFB RID: 2811
		private static readonly IntPtr NativeMethodInfoPtr_get_Spec_Public_Virtual_New_get_ChartSpec_0;

		// Token: 0x04000AFC RID: 2812
		private static readonly IntPtr NativeMethodInfoPtr_set_Spec_Public_Virtual_New_set_Void_ChartSpec_0;

		// Token: 0x04000AFD RID: 2813
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000AFE RID: 2814
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000AFF RID: 2815
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
