using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200007F RID: 127
	public class IterativeCalculationSettings : Object
	{
		// Token: 0x06000994 RID: 2452 RVA: 0x0002F70C File Offset: 0x0002D90C
		// Note: this type is marked as 'beforefieldinit'.
		static IterativeCalculationSettings()
		{
			Il2CppClassPointerStore<IterativeCalculationSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "IterativeCalculationSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IterativeCalculationSettings>.NativeClassPtr);
			IterativeCalculationSettings.NativeFieldInfoPtr__ConvergenceThreshold_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IterativeCalculationSettings>.NativeClassPtr, "<ConvergenceThreshold>k__BackingField");
			IterativeCalculationSettings.NativeFieldInfoPtr__MaxIterations_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IterativeCalculationSettings>.NativeClassPtr, "<MaxIterations>k__BackingField");
			IterativeCalculationSettings.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IterativeCalculationSettings>.NativeClassPtr, "<ETag>k__BackingField");
			IterativeCalculationSettings.NativeMethodInfoPtr_get_ConvergenceThreshold_Public_Virtual_New_get_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IterativeCalculationSettings>.NativeClassPtr, 100664683);
			IterativeCalculationSettings.NativeMethodInfoPtr_set_ConvergenceThreshold_Public_Virtual_New_set_Void_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IterativeCalculationSettings>.NativeClassPtr, 100664684);
			IterativeCalculationSettings.NativeMethodInfoPtr_get_MaxIterations_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IterativeCalculationSettings>.NativeClassPtr, 100664685);
			IterativeCalculationSettings.NativeMethodInfoPtr_set_MaxIterations_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IterativeCalculationSettings>.NativeClassPtr, 100664686);
			IterativeCalculationSettings.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IterativeCalculationSettings>.NativeClassPtr, 100664687);
			IterativeCalculationSettings.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IterativeCalculationSettings>.NativeClassPtr, 100664688);
			IterativeCalculationSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IterativeCalculationSettings>.NativeClassPtr, 100664689);
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x0002F804 File Offset: 0x0002DA04
		// (set) Token: 0x06000996 RID: 2454 RVA: 0x0002F848 File Offset: 0x0002DA48
		public unsafe virtual Nullable<double> ConvergenceThreshold
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IterativeCalculationSettings.NativeMethodInfoPtr_get_ConvergenceThreshold_Public_Virtual_New_get_Nullable_1_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<double>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IterativeCalculationSettings.NativeMethodInfoPtr_set_ConvergenceThreshold_Public_Virtual_New_set_Void_Nullable_1_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x0002F89C File Offset: 0x0002DA9C
		// (set) Token: 0x06000998 RID: 2456 RVA: 0x0002F8E0 File Offset: 0x0002DAE0
		public unsafe virtual Nullable<int> MaxIterations
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IterativeCalculationSettings.NativeMethodInfoPtr_get_MaxIterations_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IterativeCalculationSettings.NativeMethodInfoPtr_set_MaxIterations_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x0002F934 File Offset: 0x0002DB34
		// (set) Token: 0x0600099A RID: 2458 RVA: 0x0002F978 File Offset: 0x0002DB78
		public unsafe virtual string ETag
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IterativeCalculationSettings.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IterativeCalculationSettings.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x0002F9C8 File Offset: 0x0002DBC8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IterativeCalculationSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IterativeCalculationSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IterativeCalculationSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x000069B7 File Offset: 0x00004BB7
		public IterativeCalculationSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x0002FA04 File Offset: 0x0002DC04
		// (set) Token: 0x0600099E RID: 2462 RVA: 0x000069C0 File Offset: 0x00004BC0
		public Nullable<double> _ConvergenceThreshold_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IterativeCalculationSettings.NativeFieldInfoPtr__ConvergenceThreshold_k__BackingField);
				return new Nullable<double>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IterativeCalculationSettings.NativeFieldInfoPtr__ConvergenceThreshold_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x0600099F RID: 2463 RVA: 0x0002FA34 File Offset: 0x0002DC34
		// (set) Token: 0x060009A0 RID: 2464 RVA: 0x000069EE File Offset: 0x00004BEE
		public Nullable<int> _MaxIterations_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IterativeCalculationSettings.NativeFieldInfoPtr__MaxIterations_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IterativeCalculationSettings.NativeFieldInfoPtr__MaxIterations_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x0002FA64 File Offset: 0x0002DC64
		// (set) Token: 0x060009A2 RID: 2466 RVA: 0x00006A1C File Offset: 0x00004C1C
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IterativeCalculationSettings.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IterativeCalculationSettings.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeFieldInfoPtr__ConvergenceThreshold_k__BackingField;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeFieldInfoPtr__MaxIterations_k__BackingField;

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeMethodInfoPtr_get_ConvergenceThreshold_Public_Virtual_New_get_Nullable_1_Double_0;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeMethodInfoPtr_set_ConvergenceThreshold_Public_Virtual_New_set_Void_Nullable_1_Double_0;

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxIterations_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxIterations_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
