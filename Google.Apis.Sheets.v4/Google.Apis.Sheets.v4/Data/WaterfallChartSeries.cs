using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x020000CE RID: 206
	public class WaterfallChartSeries : Object
	{
		// Token: 0x0600114D RID: 4429 RVA: 0x0004D640 File Offset: 0x0004B840
		// Note: this type is marked as 'beforefieldinit'.
		static WaterfallChartSeries()
		{
			Il2CppClassPointerStore<WaterfallChartSeries>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "WaterfallChartSeries");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaterfallChartSeries>.NativeClassPtr);
			WaterfallChartSeries.NativeFieldInfoPtr__CustomSubtotals_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterfallChartSeries>.NativeClassPtr, "<CustomSubtotals>k__BackingField");
			WaterfallChartSeries.NativeFieldInfoPtr__Data_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterfallChartSeries>.NativeClassPtr, "<Data>k__BackingField");
			WaterfallChartSeries.NativeFieldInfoPtr__HideTrailingSubtotal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterfallChartSeries>.NativeClassPtr, "<HideTrailingSubtotal>k__BackingField");
			WaterfallChartSeries.NativeFieldInfoPtr__NegativeColumnsStyle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterfallChartSeries>.NativeClassPtr, "<NegativeColumnsStyle>k__BackingField");
			WaterfallChartSeries.NativeFieldInfoPtr__PositiveColumnsStyle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterfallChartSeries>.NativeClassPtr, "<PositiveColumnsStyle>k__BackingField");
			WaterfallChartSeries.NativeFieldInfoPtr__SubtotalColumnsStyle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterfallChartSeries>.NativeClassPtr, "<SubtotalColumnsStyle>k__BackingField");
			WaterfallChartSeries.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterfallChartSeries>.NativeClassPtr, "<ETag>k__BackingField");
			WaterfallChartSeries.NativeMethodInfoPtr_get_CustomSubtotals_Public_Virtual_New_get_IList_1_WaterfallChartCustomSubtotal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartSeries>.NativeClassPtr, 100665632);
			WaterfallChartSeries.NativeMethodInfoPtr_set_CustomSubtotals_Public_Virtual_New_set_Void_IList_1_WaterfallChartCustomSubtotal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartSeries>.NativeClassPtr, 100665633);
			WaterfallChartSeries.NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_ChartData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartSeries>.NativeClassPtr, 100665634);
			WaterfallChartSeries.NativeMethodInfoPtr_set_Data_Public_Virtual_New_set_Void_ChartData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartSeries>.NativeClassPtr, 100665635);
			WaterfallChartSeries.NativeMethodInfoPtr_get_HideTrailingSubtotal_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartSeries>.NativeClassPtr, 100665636);
			WaterfallChartSeries.NativeMethodInfoPtr_set_HideTrailingSubtotal_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartSeries>.NativeClassPtr, 100665637);
			WaterfallChartSeries.NativeMethodInfoPtr_get_NegativeColumnsStyle_Public_Virtual_New_get_WaterfallChartColumnStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartSeries>.NativeClassPtr, 100665638);
			WaterfallChartSeries.NativeMethodInfoPtr_set_NegativeColumnsStyle_Public_Virtual_New_set_Void_WaterfallChartColumnStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartSeries>.NativeClassPtr, 100665639);
			WaterfallChartSeries.NativeMethodInfoPtr_get_PositiveColumnsStyle_Public_Virtual_New_get_WaterfallChartColumnStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartSeries>.NativeClassPtr, 100665640);
			WaterfallChartSeries.NativeMethodInfoPtr_set_PositiveColumnsStyle_Public_Virtual_New_set_Void_WaterfallChartColumnStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartSeries>.NativeClassPtr, 100665641);
			WaterfallChartSeries.NativeMethodInfoPtr_get_SubtotalColumnsStyle_Public_Virtual_New_get_WaterfallChartColumnStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartSeries>.NativeClassPtr, 100665642);
			WaterfallChartSeries.NativeMethodInfoPtr_set_SubtotalColumnsStyle_Public_Virtual_New_set_Void_WaterfallChartColumnStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartSeries>.NativeClassPtr, 100665643);
			WaterfallChartSeries.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartSeries>.NativeClassPtr, 100665644);
			WaterfallChartSeries.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartSeries>.NativeClassPtr, 100665645);
			WaterfallChartSeries.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartSeries>.NativeClassPtr, 100665646);
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x0600114E RID: 4430 RVA: 0x0004D828 File Offset: 0x0004BA28
		// (set) Token: 0x0600114F RID: 4431 RVA: 0x0004D874 File Offset: 0x0004BA74
		public unsafe virtual IList<WaterfallChartCustomSubtotal> CustomSubtotals
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartSeries.NativeMethodInfoPtr_get_CustomSubtotals_Public_Virtual_New_get_IList_1_WaterfallChartCustomSubtotal_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<WaterfallChartCustomSubtotal>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartSeries.NativeMethodInfoPtr_set_CustomSubtotals_Public_Virtual_New_set_Void_IList_1_WaterfallChartCustomSubtotal_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x0004D8C4 File Offset: 0x0004BAC4
		// (set) Token: 0x06001151 RID: 4433 RVA: 0x0004D910 File Offset: 0x0004BB10
		public unsafe virtual ChartData Data
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartSeries.NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_ChartData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartSeries.NativeMethodInfoPtr_set_Data_Public_Virtual_New_set_Void_ChartData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06001152 RID: 4434 RVA: 0x0004D960 File Offset: 0x0004BB60
		// (set) Token: 0x06001153 RID: 4435 RVA: 0x0004D9A4 File Offset: 0x0004BBA4
		public unsafe virtual Nullable<bool> HideTrailingSubtotal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartSeries.NativeMethodInfoPtr_get_HideTrailingSubtotal_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartSeries.NativeMethodInfoPtr_set_HideTrailingSubtotal_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06001154 RID: 4436 RVA: 0x0004D9F8 File Offset: 0x0004BBF8
		// (set) Token: 0x06001155 RID: 4437 RVA: 0x0004DA44 File Offset: 0x0004BC44
		public unsafe virtual WaterfallChartColumnStyle NegativeColumnsStyle
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartSeries.NativeMethodInfoPtr_get_NegativeColumnsStyle_Public_Virtual_New_get_WaterfallChartColumnStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaterfallChartColumnStyle>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartSeries.NativeMethodInfoPtr_set_NegativeColumnsStyle_Public_Virtual_New_set_Void_WaterfallChartColumnStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06001156 RID: 4438 RVA: 0x0004DA94 File Offset: 0x0004BC94
		// (set) Token: 0x06001157 RID: 4439 RVA: 0x0004DAE0 File Offset: 0x0004BCE0
		public unsafe virtual WaterfallChartColumnStyle PositiveColumnsStyle
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartSeries.NativeMethodInfoPtr_get_PositiveColumnsStyle_Public_Virtual_New_get_WaterfallChartColumnStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaterfallChartColumnStyle>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartSeries.NativeMethodInfoPtr_set_PositiveColumnsStyle_Public_Virtual_New_set_Void_WaterfallChartColumnStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06001158 RID: 4440 RVA: 0x0004DB30 File Offset: 0x0004BD30
		// (set) Token: 0x06001159 RID: 4441 RVA: 0x0004DB7C File Offset: 0x0004BD7C
		public unsafe virtual WaterfallChartColumnStyle SubtotalColumnsStyle
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartSeries.NativeMethodInfoPtr_get_SubtotalColumnsStyle_Public_Virtual_New_get_WaterfallChartColumnStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaterfallChartColumnStyle>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartSeries.NativeMethodInfoPtr_set_SubtotalColumnsStyle_Public_Virtual_New_set_Void_WaterfallChartColumnStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x0600115A RID: 4442 RVA: 0x0004DBCC File Offset: 0x0004BDCC
		// (set) Token: 0x0600115B RID: 4443 RVA: 0x0004DC10 File Offset: 0x0004BE10
		public unsafe virtual string ETag
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartSeries.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartSeries.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x0004DC60 File Offset: 0x0004BE60
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaterfallChartSeries()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaterfallChartSeries>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterfallChartSeries.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x0000A4FA File Offset: 0x000086FA
		public WaterfallChartSeries(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x0600115E RID: 4446 RVA: 0x0004DC9C File Offset: 0x0004BE9C
		// (set) Token: 0x0600115F RID: 4447 RVA: 0x0000A503 File Offset: 0x00008703
		public unsafe IList<WaterfallChartCustomSubtotal> _CustomSubtotals_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartSeries.NativeFieldInfoPtr__CustomSubtotals_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<WaterfallChartCustomSubtotal>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartSeries.NativeFieldInfoPtr__CustomSubtotals_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06001160 RID: 4448 RVA: 0x0004DCCC File Offset: 0x0004BECC
		// (set) Token: 0x06001161 RID: 4449 RVA: 0x0000A522 File Offset: 0x00008722
		public unsafe ChartData _Data_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartSeries.NativeFieldInfoPtr__Data_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChartData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartSeries.NativeFieldInfoPtr__Data_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06001162 RID: 4450 RVA: 0x0004DCFC File Offset: 0x0004BEFC
		// (set) Token: 0x06001163 RID: 4451 RVA: 0x0000A541 File Offset: 0x00008741
		public Nullable<bool> _HideTrailingSubtotal_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartSeries.NativeFieldInfoPtr__HideTrailingSubtotal_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartSeries.NativeFieldInfoPtr__HideTrailingSubtotal_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06001164 RID: 4452 RVA: 0x0004DD2C File Offset: 0x0004BF2C
		// (set) Token: 0x06001165 RID: 4453 RVA: 0x0000A56F File Offset: 0x0000876F
		public unsafe WaterfallChartColumnStyle _NegativeColumnsStyle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartSeries.NativeFieldInfoPtr__NegativeColumnsStyle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaterfallChartColumnStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartSeries.NativeFieldInfoPtr__NegativeColumnsStyle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06001166 RID: 4454 RVA: 0x0004DD5C File Offset: 0x0004BF5C
		// (set) Token: 0x06001167 RID: 4455 RVA: 0x0000A58E File Offset: 0x0000878E
		public unsafe WaterfallChartColumnStyle _PositiveColumnsStyle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartSeries.NativeFieldInfoPtr__PositiveColumnsStyle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaterfallChartColumnStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartSeries.NativeFieldInfoPtr__PositiveColumnsStyle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06001168 RID: 4456 RVA: 0x0004DD8C File Offset: 0x0004BF8C
		// (set) Token: 0x06001169 RID: 4457 RVA: 0x0000A5AD File Offset: 0x000087AD
		public unsafe WaterfallChartColumnStyle _SubtotalColumnsStyle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartSeries.NativeFieldInfoPtr__SubtotalColumnsStyle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaterfallChartColumnStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartSeries.NativeFieldInfoPtr__SubtotalColumnsStyle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x0600116A RID: 4458 RVA: 0x0004DDBC File Offset: 0x0004BFBC
		// (set) Token: 0x0600116B RID: 4459 RVA: 0x0000A5CC File Offset: 0x000087CC
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartSeries.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartSeries.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000BFB RID: 3067
		private static readonly IntPtr NativeFieldInfoPtr__CustomSubtotals_k__BackingField;

		// Token: 0x04000BFC RID: 3068
		private static readonly IntPtr NativeFieldInfoPtr__Data_k__BackingField;

		// Token: 0x04000BFD RID: 3069
		private static readonly IntPtr NativeFieldInfoPtr__HideTrailingSubtotal_k__BackingField;

		// Token: 0x04000BFE RID: 3070
		private static readonly IntPtr NativeFieldInfoPtr__NegativeColumnsStyle_k__BackingField;

		// Token: 0x04000BFF RID: 3071
		private static readonly IntPtr NativeFieldInfoPtr__PositiveColumnsStyle_k__BackingField;

		// Token: 0x04000C00 RID: 3072
		private static readonly IntPtr NativeFieldInfoPtr__SubtotalColumnsStyle_k__BackingField;

		// Token: 0x04000C01 RID: 3073
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000C02 RID: 3074
		private static readonly IntPtr NativeMethodInfoPtr_get_CustomSubtotals_Public_Virtual_New_get_IList_1_WaterfallChartCustomSubtotal_0;

		// Token: 0x04000C03 RID: 3075
		private static readonly IntPtr NativeMethodInfoPtr_set_CustomSubtotals_Public_Virtual_New_set_Void_IList_1_WaterfallChartCustomSubtotal_0;

		// Token: 0x04000C04 RID: 3076
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_ChartData_0;

		// Token: 0x04000C05 RID: 3077
		private static readonly IntPtr NativeMethodInfoPtr_set_Data_Public_Virtual_New_set_Void_ChartData_0;

		// Token: 0x04000C06 RID: 3078
		private static readonly IntPtr NativeMethodInfoPtr_get_HideTrailingSubtotal_Public_Virtual_New_get_Nullable_1_Boolean_0;

		// Token: 0x04000C07 RID: 3079
		private static readonly IntPtr NativeMethodInfoPtr_set_HideTrailingSubtotal_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

		// Token: 0x04000C08 RID: 3080
		private static readonly IntPtr NativeMethodInfoPtr_get_NegativeColumnsStyle_Public_Virtual_New_get_WaterfallChartColumnStyle_0;

		// Token: 0x04000C09 RID: 3081
		private static readonly IntPtr NativeMethodInfoPtr_set_NegativeColumnsStyle_Public_Virtual_New_set_Void_WaterfallChartColumnStyle_0;

		// Token: 0x04000C0A RID: 3082
		private static readonly IntPtr NativeMethodInfoPtr_get_PositiveColumnsStyle_Public_Virtual_New_get_WaterfallChartColumnStyle_0;

		// Token: 0x04000C0B RID: 3083
		private static readonly IntPtr NativeMethodInfoPtr_set_PositiveColumnsStyle_Public_Virtual_New_set_Void_WaterfallChartColumnStyle_0;

		// Token: 0x04000C0C RID: 3084
		private static readonly IntPtr NativeMethodInfoPtr_get_SubtotalColumnsStyle_Public_Virtual_New_get_WaterfallChartColumnStyle_0;

		// Token: 0x04000C0D RID: 3085
		private static readonly IntPtr NativeMethodInfoPtr_set_SubtotalColumnsStyle_Public_Virtual_New_set_Void_WaterfallChartColumnStyle_0;

		// Token: 0x04000C0E RID: 3086
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000C0F RID: 3087
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000C10 RID: 3088
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
