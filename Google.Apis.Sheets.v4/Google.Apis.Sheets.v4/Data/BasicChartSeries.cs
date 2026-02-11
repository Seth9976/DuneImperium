using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000020 RID: 32
	public class BasicChartSeries : Object
	{
		// Token: 0x060001FB RID: 507 RVA: 0x000127FC File Offset: 0x000109FC
		// Note: this type is marked as 'beforefieldinit'.
		static BasicChartSeries()
		{
			Il2CppClassPointerStore<BasicChartSeries>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "BasicChartSeries");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicChartSeries>.NativeClassPtr);
			BasicChartSeries.NativeFieldInfoPtr__Color_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChartSeries>.NativeClassPtr, "<Color>k__BackingField");
			BasicChartSeries.NativeFieldInfoPtr__ColorStyle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChartSeries>.NativeClassPtr, "<ColorStyle>k__BackingField");
			BasicChartSeries.NativeFieldInfoPtr__LineStyle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChartSeries>.NativeClassPtr, "<LineStyle>k__BackingField");
			BasicChartSeries.NativeFieldInfoPtr__Series_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChartSeries>.NativeClassPtr, "<Series>k__BackingField");
			BasicChartSeries.NativeFieldInfoPtr__TargetAxis_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChartSeries>.NativeClassPtr, "<TargetAxis>k__BackingField");
			BasicChartSeries.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChartSeries>.NativeClassPtr, "<Type>k__BackingField");
			BasicChartSeries.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChartSeries>.NativeClassPtr, "<ETag>k__BackingField");
			BasicChartSeries.NativeMethodInfoPtr_get_Color_Public_Virtual_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSeries>.NativeClassPtr, 100663758);
			BasicChartSeries.NativeMethodInfoPtr_set_Color_Public_Virtual_New_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSeries>.NativeClassPtr, 100663759);
			BasicChartSeries.NativeMethodInfoPtr_get_ColorStyle_Public_Virtual_New_get_ColorStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSeries>.NativeClassPtr, 100663760);
			BasicChartSeries.NativeMethodInfoPtr_set_ColorStyle_Public_Virtual_New_set_Void_ColorStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSeries>.NativeClassPtr, 100663761);
			BasicChartSeries.NativeMethodInfoPtr_get_LineStyle_Public_Virtual_New_get_LineStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSeries>.NativeClassPtr, 100663762);
			BasicChartSeries.NativeMethodInfoPtr_set_LineStyle_Public_Virtual_New_set_Void_LineStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSeries>.NativeClassPtr, 100663763);
			BasicChartSeries.NativeMethodInfoPtr_get_Series_Public_Virtual_New_get_ChartData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSeries>.NativeClassPtr, 100663764);
			BasicChartSeries.NativeMethodInfoPtr_set_Series_Public_Virtual_New_set_Void_ChartData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSeries>.NativeClassPtr, 100663765);
			BasicChartSeries.NativeMethodInfoPtr_get_TargetAxis_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSeries>.NativeClassPtr, 100663766);
			BasicChartSeries.NativeMethodInfoPtr_set_TargetAxis_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSeries>.NativeClassPtr, 100663767);
			BasicChartSeries.NativeMethodInfoPtr_get_Type_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSeries>.NativeClassPtr, 100663768);
			BasicChartSeries.NativeMethodInfoPtr_set_Type_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSeries>.NativeClassPtr, 100663769);
			BasicChartSeries.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSeries>.NativeClassPtr, 100663770);
			BasicChartSeries.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSeries>.NativeClassPtr, 100663771);
			BasicChartSeries.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSeries>.NativeClassPtr, 100663772);
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060001FC RID: 508 RVA: 0x000129E4 File Offset: 0x00010BE4
		// (set) Token: 0x060001FD RID: 509 RVA: 0x00012A30 File Offset: 0x00010C30
		public unsafe virtual Color Color
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSeries.NativeMethodInfoPtr_get_Color_Public_Virtual_New_get_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSeries.NativeMethodInfoPtr_set_Color_Public_Virtual_New_set_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060001FE RID: 510 RVA: 0x00012A80 File Offset: 0x00010C80
		// (set) Token: 0x060001FF RID: 511 RVA: 0x00012ACC File Offset: 0x00010CCC
		public unsafe virtual ColorStyle ColorStyle
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSeries.NativeMethodInfoPtr_get_ColorStyle_Public_Virtual_New_get_ColorStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ColorStyle>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSeries.NativeMethodInfoPtr_set_ColorStyle_Public_Virtual_New_set_Void_ColorStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00012B1C File Offset: 0x00010D1C
		// (set) Token: 0x06000201 RID: 513 RVA: 0x00012B68 File Offset: 0x00010D68
		public unsafe virtual LineStyle LineStyle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSeries.NativeMethodInfoPtr_get_LineStyle_Public_Virtual_New_get_LineStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LineStyle>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSeries.NativeMethodInfoPtr_set_LineStyle_Public_Virtual_New_set_Void_LineStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00012BB8 File Offset: 0x00010DB8
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00012C04 File Offset: 0x00010E04
		public unsafe virtual ChartData Series
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSeries.NativeMethodInfoPtr_get_Series_Public_Virtual_New_get_ChartData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSeries.NativeMethodInfoPtr_set_Series_Public_Virtual_New_set_Void_ChartData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00012C54 File Offset: 0x00010E54
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00012C98 File Offset: 0x00010E98
		public unsafe virtual string TargetAxis
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSeries.NativeMethodInfoPtr_get_TargetAxis_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSeries.NativeMethodInfoPtr_set_TargetAxis_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00012CE8 File Offset: 0x00010EE8
		// (set) Token: 0x06000207 RID: 519 RVA: 0x00012D2C File Offset: 0x00010F2C
		public unsafe virtual string Type
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSeries.NativeMethodInfoPtr_get_Type_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSeries.NativeMethodInfoPtr_set_Type_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00012D7C File Offset: 0x00010F7C
		// (set) Token: 0x06000209 RID: 521 RVA: 0x00012DC0 File Offset: 0x00010FC0
		public unsafe virtual string ETag
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSeries.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSeries.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00012E10 File Offset: 0x00011010
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasicChartSeries()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicChartSeries>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicChartSeries.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002E61 File Offset: 0x00001061
		public BasicChartSeries(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00012E4C File Offset: 0x0001104C
		// (set) Token: 0x0600020D RID: 525 RVA: 0x00002E6A File Offset: 0x0000106A
		public unsafe Color _Color_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSeries.NativeFieldInfoPtr__Color_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSeries.NativeFieldInfoPtr__Color_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00012E7C File Offset: 0x0001107C
		// (set) Token: 0x0600020F RID: 527 RVA: 0x00002E89 File Offset: 0x00001089
		public unsafe ColorStyle _ColorStyle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSeries.NativeFieldInfoPtr__ColorStyle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSeries.NativeFieldInfoPtr__ColorStyle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00012EAC File Offset: 0x000110AC
		// (set) Token: 0x06000211 RID: 529 RVA: 0x00002EA8 File Offset: 0x000010A8
		public unsafe LineStyle _LineStyle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSeries.NativeFieldInfoPtr__LineStyle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LineStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSeries.NativeFieldInfoPtr__LineStyle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000212 RID: 530 RVA: 0x00012EDC File Offset: 0x000110DC
		// (set) Token: 0x06000213 RID: 531 RVA: 0x00002EC7 File Offset: 0x000010C7
		public unsafe ChartData _Series_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSeries.NativeFieldInfoPtr__Series_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChartData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSeries.NativeFieldInfoPtr__Series_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00012F0C File Offset: 0x0001110C
		// (set) Token: 0x06000215 RID: 533 RVA: 0x00002EE6 File Offset: 0x000010E6
		public unsafe string _TargetAxis_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSeries.NativeFieldInfoPtr__TargetAxis_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSeries.NativeFieldInfoPtr__TargetAxis_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00012F34 File Offset: 0x00011134
		// (set) Token: 0x06000217 RID: 535 RVA: 0x00002F05 File Offset: 0x00001105
		public unsafe string _Type_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSeries.NativeFieldInfoPtr__Type_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSeries.NativeFieldInfoPtr__Type_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00012F5C File Offset: 0x0001115C
		// (set) Token: 0x06000219 RID: 537 RVA: 0x00002F24 File Offset: 0x00001124
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSeries.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSeries.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeFieldInfoPtr__Color_k__BackingField;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeFieldInfoPtr__ColorStyle_k__BackingField;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeFieldInfoPtr__LineStyle_k__BackingField;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeFieldInfoPtr__Series_k__BackingField;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeFieldInfoPtr__TargetAxis_k__BackingField;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_Virtual_New_get_Color_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_set_Color_Public_Virtual_New_set_Void_Color_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_get_ColorStyle_Public_Virtual_New_get_ColorStyle_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_set_ColorStyle_Public_Virtual_New_set_Void_ColorStyle_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_get_LineStyle_Public_Virtual_New_get_LineStyle_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_set_LineStyle_Public_Virtual_New_set_Void_LineStyle_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_get_Series_Public_Virtual_New_get_ChartData_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_set_Series_Public_Virtual_New_set_Void_ChartData_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetAxis_Public_Virtual_New_get_String_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetAxis_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_New_get_String_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_set_Type_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
