using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200008E RID: 142
	public class PieChartSpec : Object
	{
		// Token: 0x06000AAD RID: 2733 RVA: 0x000339A0 File Offset: 0x00031BA0
		// Note: this type is marked as 'beforefieldinit'.
		static PieChartSpec()
		{
			Il2CppClassPointerStore<PieChartSpec>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "PieChartSpec");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PieChartSpec>.NativeClassPtr);
			PieChartSpec.NativeFieldInfoPtr__Domain_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PieChartSpec>.NativeClassPtr, "<Domain>k__BackingField");
			PieChartSpec.NativeFieldInfoPtr__LegendPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PieChartSpec>.NativeClassPtr, "<LegendPosition>k__BackingField");
			PieChartSpec.NativeFieldInfoPtr__PieHole_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PieChartSpec>.NativeClassPtr, "<PieHole>k__BackingField");
			PieChartSpec.NativeFieldInfoPtr__Series_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PieChartSpec>.NativeClassPtr, "<Series>k__BackingField");
			PieChartSpec.NativeFieldInfoPtr__ThreeDimensional_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PieChartSpec>.NativeClassPtr, "<ThreeDimensional>k__BackingField");
			PieChartSpec.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PieChartSpec>.NativeClassPtr, "<ETag>k__BackingField");
			PieChartSpec.NativeMethodInfoPtr_get_Domain_Public_Virtual_New_get_ChartData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PieChartSpec>.NativeClassPtr, 100664816);
			PieChartSpec.NativeMethodInfoPtr_set_Domain_Public_Virtual_New_set_Void_ChartData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PieChartSpec>.NativeClassPtr, 100664817);
			PieChartSpec.NativeMethodInfoPtr_get_LegendPosition_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PieChartSpec>.NativeClassPtr, 100664818);
			PieChartSpec.NativeMethodInfoPtr_set_LegendPosition_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PieChartSpec>.NativeClassPtr, 100664819);
			PieChartSpec.NativeMethodInfoPtr_get_PieHole_Public_Virtual_New_get_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PieChartSpec>.NativeClassPtr, 100664820);
			PieChartSpec.NativeMethodInfoPtr_set_PieHole_Public_Virtual_New_set_Void_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PieChartSpec>.NativeClassPtr, 100664821);
			PieChartSpec.NativeMethodInfoPtr_get_Series_Public_Virtual_New_get_ChartData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PieChartSpec>.NativeClassPtr, 100664822);
			PieChartSpec.NativeMethodInfoPtr_set_Series_Public_Virtual_New_set_Void_ChartData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PieChartSpec>.NativeClassPtr, 100664823);
			PieChartSpec.NativeMethodInfoPtr_get_ThreeDimensional_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PieChartSpec>.NativeClassPtr, 100664824);
			PieChartSpec.NativeMethodInfoPtr_set_ThreeDimensional_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PieChartSpec>.NativeClassPtr, 100664825);
			PieChartSpec.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PieChartSpec>.NativeClassPtr, 100664826);
			PieChartSpec.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PieChartSpec>.NativeClassPtr, 100664827);
			PieChartSpec.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PieChartSpec>.NativeClassPtr, 100664828);
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x00033B4C File Offset: 0x00031D4C
		// (set) Token: 0x06000AAF RID: 2735 RVA: 0x00033B98 File Offset: 0x00031D98
		public unsafe virtual ChartData Domain
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PieChartSpec.NativeMethodInfoPtr_get_Domain_Public_Virtual_New_get_ChartData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PieChartSpec.NativeMethodInfoPtr_set_Domain_Public_Virtual_New_set_Void_ChartData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x00033BE8 File Offset: 0x00031DE8
		// (set) Token: 0x06000AB1 RID: 2737 RVA: 0x00033C2C File Offset: 0x00031E2C
		public unsafe virtual string LegendPosition
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PieChartSpec.NativeMethodInfoPtr_get_LegendPosition_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PieChartSpec.NativeMethodInfoPtr_set_LegendPosition_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x00033C7C File Offset: 0x00031E7C
		// (set) Token: 0x06000AB3 RID: 2739 RVA: 0x00033CC0 File Offset: 0x00031EC0
		public unsafe virtual Nullable<double> PieHole
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PieChartSpec.NativeMethodInfoPtr_get_PieHole_Public_Virtual_New_get_Nullable_1_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PieChartSpec.NativeMethodInfoPtr_set_PieHole_Public_Virtual_New_set_Void_Nullable_1_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x00033D14 File Offset: 0x00031F14
		// (set) Token: 0x06000AB5 RID: 2741 RVA: 0x00033D60 File Offset: 0x00031F60
		public unsafe virtual ChartData Series
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PieChartSpec.NativeMethodInfoPtr_get_Series_Public_Virtual_New_get_ChartData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChartData>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PieChartSpec.NativeMethodInfoPtr_set_Series_Public_Virtual_New_set_Void_ChartData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x00033DB0 File Offset: 0x00031FB0
		// (set) Token: 0x06000AB7 RID: 2743 RVA: 0x00033DF4 File Offset: 0x00031FF4
		public unsafe virtual Nullable<bool> ThreeDimensional
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PieChartSpec.NativeMethodInfoPtr_get_ThreeDimensional_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PieChartSpec.NativeMethodInfoPtr_set_ThreeDimensional_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x00033E48 File Offset: 0x00032048
		// (set) Token: 0x06000AB9 RID: 2745 RVA: 0x00033E8C File Offset: 0x0003208C
		public unsafe virtual string ETag
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PieChartSpec.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PieChartSpec.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x00033EDC File Offset: 0x000320DC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PieChartSpec()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PieChartSpec>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PieChartSpec.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x00007226 File Offset: 0x00005426
		public PieChartSpec(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x00033F18 File Offset: 0x00032118
		// (set) Token: 0x06000ABD RID: 2749 RVA: 0x0000722F File Offset: 0x0000542F
		public unsafe ChartData _Domain_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PieChartSpec.NativeFieldInfoPtr__Domain_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChartData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PieChartSpec.NativeFieldInfoPtr__Domain_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x00033F48 File Offset: 0x00032148
		// (set) Token: 0x06000ABF RID: 2751 RVA: 0x0000724E File Offset: 0x0000544E
		public unsafe string _LegendPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PieChartSpec.NativeFieldInfoPtr__LegendPosition_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PieChartSpec.NativeFieldInfoPtr__LegendPosition_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x00033F70 File Offset: 0x00032170
		// (set) Token: 0x06000AC1 RID: 2753 RVA: 0x0000726D File Offset: 0x0000546D
		public Nullable<double> _PieHole_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PieChartSpec.NativeFieldInfoPtr__PieHole_k__BackingField);
				return new Nullable<double>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PieChartSpec.NativeFieldInfoPtr__PieHole_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x00033FA0 File Offset: 0x000321A0
		// (set) Token: 0x06000AC3 RID: 2755 RVA: 0x0000729B File Offset: 0x0000549B
		public unsafe ChartData _Series_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PieChartSpec.NativeFieldInfoPtr__Series_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChartData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PieChartSpec.NativeFieldInfoPtr__Series_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x00033FD0 File Offset: 0x000321D0
		// (set) Token: 0x06000AC5 RID: 2757 RVA: 0x000072BA File Offset: 0x000054BA
		public Nullable<bool> _ThreeDimensional_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PieChartSpec.NativeFieldInfoPtr__ThreeDimensional_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PieChartSpec.NativeFieldInfoPtr__ThreeDimensional_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x00034000 File Offset: 0x00032200
		// (set) Token: 0x06000AC7 RID: 2759 RVA: 0x000072E8 File Offset: 0x000054E8
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PieChartSpec.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PieChartSpec.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeFieldInfoPtr__Domain_k__BackingField;

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeFieldInfoPtr__LegendPosition_k__BackingField;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeFieldInfoPtr__PieHole_k__BackingField;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeFieldInfoPtr__Series_k__BackingField;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeFieldInfoPtr__ThreeDimensional_k__BackingField;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeMethodInfoPtr_get_Domain_Public_Virtual_New_get_ChartData_0;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeMethodInfoPtr_set_Domain_Public_Virtual_New_set_Void_ChartData_0;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeMethodInfoPtr_get_LegendPosition_Public_Virtual_New_get_String_0;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeMethodInfoPtr_set_LegendPosition_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeMethodInfoPtr_get_PieHole_Public_Virtual_New_get_Nullable_1_Double_0;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeMethodInfoPtr_set_PieHole_Public_Virtual_New_set_Void_Nullable_1_Double_0;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeMethodInfoPtr_get_Series_Public_Virtual_New_get_ChartData_0;

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeMethodInfoPtr_set_Series_Public_Virtual_New_set_Void_ChartData_0;

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeMethodInfoPtr_get_ThreeDimensional_Public_Virtual_New_get_Nullable_1_Boolean_0;

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeMethodInfoPtr_set_ThreeDimensional_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

		// Token: 0x04000763 RID: 1891
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000764 RID: 1892
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000765 RID: 1893
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
