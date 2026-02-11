using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x020000CF RID: 207
	public class WaterfallChartSpec : Object
	{
		// Token: 0x0600116C RID: 4460 RVA: 0x0004DDE4 File Offset: 0x0004BFE4
		// Note: this type is marked as 'beforefieldinit'.
		static WaterfallChartSpec()
		{
			Il2CppClassPointerStore<WaterfallChartSpec>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "WaterfallChartSpec");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaterfallChartSpec>.NativeClassPtr);
			WaterfallChartSpec.NativeFieldInfoPtr__ConnectorLineStyle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterfallChartSpec>.NativeClassPtr, "<ConnectorLineStyle>k__BackingField");
			WaterfallChartSpec.NativeFieldInfoPtr__Domain_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterfallChartSpec>.NativeClassPtr, "<Domain>k__BackingField");
			WaterfallChartSpec.NativeFieldInfoPtr__FirstValueIsTotal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterfallChartSpec>.NativeClassPtr, "<FirstValueIsTotal>k__BackingField");
			WaterfallChartSpec.NativeFieldInfoPtr__HideConnectorLines_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterfallChartSpec>.NativeClassPtr, "<HideConnectorLines>k__BackingField");
			WaterfallChartSpec.NativeFieldInfoPtr__Series_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterfallChartSpec>.NativeClassPtr, "<Series>k__BackingField");
			WaterfallChartSpec.NativeFieldInfoPtr__StackedType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterfallChartSpec>.NativeClassPtr, "<StackedType>k__BackingField");
			WaterfallChartSpec.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterfallChartSpec>.NativeClassPtr, "<ETag>k__BackingField");
			WaterfallChartSpec.NativeMethodInfoPtr_get_ConnectorLineStyle_Public_Virtual_New_get_LineStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartSpec>.NativeClassPtr, 100665647);
			WaterfallChartSpec.NativeMethodInfoPtr_set_ConnectorLineStyle_Public_Virtual_New_set_Void_LineStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartSpec>.NativeClassPtr, 100665648);
			WaterfallChartSpec.NativeMethodInfoPtr_get_Domain_Public_Virtual_New_get_WaterfallChartDomain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartSpec>.NativeClassPtr, 100665649);
			WaterfallChartSpec.NativeMethodInfoPtr_set_Domain_Public_Virtual_New_set_Void_WaterfallChartDomain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartSpec>.NativeClassPtr, 100665650);
			WaterfallChartSpec.NativeMethodInfoPtr_get_FirstValueIsTotal_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartSpec>.NativeClassPtr, 100665651);
			WaterfallChartSpec.NativeMethodInfoPtr_set_FirstValueIsTotal_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartSpec>.NativeClassPtr, 100665652);
			WaterfallChartSpec.NativeMethodInfoPtr_get_HideConnectorLines_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartSpec>.NativeClassPtr, 100665653);
			WaterfallChartSpec.NativeMethodInfoPtr_set_HideConnectorLines_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartSpec>.NativeClassPtr, 100665654);
			WaterfallChartSpec.NativeMethodInfoPtr_get_Series_Public_Virtual_New_get_IList_1_WaterfallChartSeries_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartSpec>.NativeClassPtr, 100665655);
			WaterfallChartSpec.NativeMethodInfoPtr_set_Series_Public_Virtual_New_set_Void_IList_1_WaterfallChartSeries_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartSpec>.NativeClassPtr, 100665656);
			WaterfallChartSpec.NativeMethodInfoPtr_get_StackedType_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartSpec>.NativeClassPtr, 100665657);
			WaterfallChartSpec.NativeMethodInfoPtr_set_StackedType_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartSpec>.NativeClassPtr, 100665658);
			WaterfallChartSpec.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartSpec>.NativeClassPtr, 100665659);
			WaterfallChartSpec.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartSpec>.NativeClassPtr, 100665660);
			WaterfallChartSpec.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterfallChartSpec>.NativeClassPtr, 100665661);
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x0600116D RID: 4461 RVA: 0x0004DFCC File Offset: 0x0004C1CC
		// (set) Token: 0x0600116E RID: 4462 RVA: 0x0004E018 File Offset: 0x0004C218
		public unsafe virtual LineStyle ConnectorLineStyle
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartSpec.NativeMethodInfoPtr_get_ConnectorLineStyle_Public_Virtual_New_get_LineStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LineStyle>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartSpec.NativeMethodInfoPtr_set_ConnectorLineStyle_Public_Virtual_New_set_Void_LineStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x0600116F RID: 4463 RVA: 0x0004E068 File Offset: 0x0004C268
		// (set) Token: 0x06001170 RID: 4464 RVA: 0x0004E0B4 File Offset: 0x0004C2B4
		public unsafe virtual WaterfallChartDomain Domain
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartSpec.NativeMethodInfoPtr_get_Domain_Public_Virtual_New_get_WaterfallChartDomain_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaterfallChartDomain>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartSpec.NativeMethodInfoPtr_set_Domain_Public_Virtual_New_set_Void_WaterfallChartDomain_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06001171 RID: 4465 RVA: 0x0004E104 File Offset: 0x0004C304
		// (set) Token: 0x06001172 RID: 4466 RVA: 0x0004E148 File Offset: 0x0004C348
		public unsafe virtual Nullable<bool> FirstValueIsTotal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartSpec.NativeMethodInfoPtr_get_FirstValueIsTotal_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartSpec.NativeMethodInfoPtr_set_FirstValueIsTotal_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06001173 RID: 4467 RVA: 0x0004E19C File Offset: 0x0004C39C
		// (set) Token: 0x06001174 RID: 4468 RVA: 0x0004E1E0 File Offset: 0x0004C3E0
		public unsafe virtual Nullable<bool> HideConnectorLines
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartSpec.NativeMethodInfoPtr_get_HideConnectorLines_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartSpec.NativeMethodInfoPtr_set_HideConnectorLines_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06001175 RID: 4469 RVA: 0x0004E234 File Offset: 0x0004C434
		// (set) Token: 0x06001176 RID: 4470 RVA: 0x0004E280 File Offset: 0x0004C480
		public unsafe virtual IList<WaterfallChartSeries> Series
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartSpec.NativeMethodInfoPtr_get_Series_Public_Virtual_New_get_IList_1_WaterfallChartSeries_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<WaterfallChartSeries>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartSpec.NativeMethodInfoPtr_set_Series_Public_Virtual_New_set_Void_IList_1_WaterfallChartSeries_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06001177 RID: 4471 RVA: 0x0004E2D0 File Offset: 0x0004C4D0
		// (set) Token: 0x06001178 RID: 4472 RVA: 0x0004E314 File Offset: 0x0004C514
		public unsafe virtual string StackedType
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartSpec.NativeMethodInfoPtr_get_StackedType_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartSpec.NativeMethodInfoPtr_set_StackedType_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06001179 RID: 4473 RVA: 0x0004E364 File Offset: 0x0004C564
		// (set) Token: 0x0600117A RID: 4474 RVA: 0x0004E3A8 File Offset: 0x0004C5A8
		public unsafe virtual string ETag
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartSpec.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterfallChartSpec.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x0004E3F8 File Offset: 0x0004C5F8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaterfallChartSpec()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaterfallChartSpec>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterfallChartSpec.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x0000A5EB File Offset: 0x000087EB
		public WaterfallChartSpec(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x0600117D RID: 4477 RVA: 0x0004E434 File Offset: 0x0004C634
		// (set) Token: 0x0600117E RID: 4478 RVA: 0x0000A5F4 File Offset: 0x000087F4
		public unsafe LineStyle _ConnectorLineStyle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartSpec.NativeFieldInfoPtr__ConnectorLineStyle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LineStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartSpec.NativeFieldInfoPtr__ConnectorLineStyle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x0600117F RID: 4479 RVA: 0x0004E464 File Offset: 0x0004C664
		// (set) Token: 0x06001180 RID: 4480 RVA: 0x0000A613 File Offset: 0x00008813
		public unsafe WaterfallChartDomain _Domain_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartSpec.NativeFieldInfoPtr__Domain_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaterfallChartDomain>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartSpec.NativeFieldInfoPtr__Domain_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06001181 RID: 4481 RVA: 0x0004E494 File Offset: 0x0004C694
		// (set) Token: 0x06001182 RID: 4482 RVA: 0x0000A632 File Offset: 0x00008832
		public Nullable<bool> _FirstValueIsTotal_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartSpec.NativeFieldInfoPtr__FirstValueIsTotal_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartSpec.NativeFieldInfoPtr__FirstValueIsTotal_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06001183 RID: 4483 RVA: 0x0004E4C4 File Offset: 0x0004C6C4
		// (set) Token: 0x06001184 RID: 4484 RVA: 0x0000A660 File Offset: 0x00008860
		public Nullable<bool> _HideConnectorLines_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartSpec.NativeFieldInfoPtr__HideConnectorLines_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartSpec.NativeFieldInfoPtr__HideConnectorLines_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06001185 RID: 4485 RVA: 0x0004E4F4 File Offset: 0x0004C6F4
		// (set) Token: 0x06001186 RID: 4486 RVA: 0x0000A68E File Offset: 0x0000888E
		public unsafe IList<WaterfallChartSeries> _Series_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartSpec.NativeFieldInfoPtr__Series_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<WaterfallChartSeries>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartSpec.NativeFieldInfoPtr__Series_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06001187 RID: 4487 RVA: 0x0004E524 File Offset: 0x0004C724
		// (set) Token: 0x06001188 RID: 4488 RVA: 0x0000A6AD File Offset: 0x000088AD
		public unsafe string _StackedType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartSpec.NativeFieldInfoPtr__StackedType_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartSpec.NativeFieldInfoPtr__StackedType_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06001189 RID: 4489 RVA: 0x0004E54C File Offset: 0x0004C74C
		// (set) Token: 0x0600118A RID: 4490 RVA: 0x0000A6CC File Offset: 0x000088CC
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartSpec.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterfallChartSpec.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000C11 RID: 3089
		private static readonly IntPtr NativeFieldInfoPtr__ConnectorLineStyle_k__BackingField;

		// Token: 0x04000C12 RID: 3090
		private static readonly IntPtr NativeFieldInfoPtr__Domain_k__BackingField;

		// Token: 0x04000C13 RID: 3091
		private static readonly IntPtr NativeFieldInfoPtr__FirstValueIsTotal_k__BackingField;

		// Token: 0x04000C14 RID: 3092
		private static readonly IntPtr NativeFieldInfoPtr__HideConnectorLines_k__BackingField;

		// Token: 0x04000C15 RID: 3093
		private static readonly IntPtr NativeFieldInfoPtr__Series_k__BackingField;

		// Token: 0x04000C16 RID: 3094
		private static readonly IntPtr NativeFieldInfoPtr__StackedType_k__BackingField;

		// Token: 0x04000C17 RID: 3095
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000C18 RID: 3096
		private static readonly IntPtr NativeMethodInfoPtr_get_ConnectorLineStyle_Public_Virtual_New_get_LineStyle_0;

		// Token: 0x04000C19 RID: 3097
		private static readonly IntPtr NativeMethodInfoPtr_set_ConnectorLineStyle_Public_Virtual_New_set_Void_LineStyle_0;

		// Token: 0x04000C1A RID: 3098
		private static readonly IntPtr NativeMethodInfoPtr_get_Domain_Public_Virtual_New_get_WaterfallChartDomain_0;

		// Token: 0x04000C1B RID: 3099
		private static readonly IntPtr NativeMethodInfoPtr_set_Domain_Public_Virtual_New_set_Void_WaterfallChartDomain_0;

		// Token: 0x04000C1C RID: 3100
		private static readonly IntPtr NativeMethodInfoPtr_get_FirstValueIsTotal_Public_Virtual_New_get_Nullable_1_Boolean_0;

		// Token: 0x04000C1D RID: 3101
		private static readonly IntPtr NativeMethodInfoPtr_set_FirstValueIsTotal_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

		// Token: 0x04000C1E RID: 3102
		private static readonly IntPtr NativeMethodInfoPtr_get_HideConnectorLines_Public_Virtual_New_get_Nullable_1_Boolean_0;

		// Token: 0x04000C1F RID: 3103
		private static readonly IntPtr NativeMethodInfoPtr_set_HideConnectorLines_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

		// Token: 0x04000C20 RID: 3104
		private static readonly IntPtr NativeMethodInfoPtr_get_Series_Public_Virtual_New_get_IList_1_WaterfallChartSeries_0;

		// Token: 0x04000C21 RID: 3105
		private static readonly IntPtr NativeMethodInfoPtr_set_Series_Public_Virtual_New_set_Void_IList_1_WaterfallChartSeries_0;

		// Token: 0x04000C22 RID: 3106
		private static readonly IntPtr NativeMethodInfoPtr_get_StackedType_Public_Virtual_New_get_String_0;

		// Token: 0x04000C23 RID: 3107
		private static readonly IntPtr NativeMethodInfoPtr_set_StackedType_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000C24 RID: 3108
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000C25 RID: 3109
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000C26 RID: 3110
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
