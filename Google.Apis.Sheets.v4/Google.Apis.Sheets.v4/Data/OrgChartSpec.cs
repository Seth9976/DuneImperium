using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200008A RID: 138
	public class OrgChartSpec : Object
	{
		// Token: 0x06000A39 RID: 2617 RVA: 0x00031D74 File Offset: 0x0002FF74
		// Note: this type is marked as 'beforefieldinit'.
		static OrgChartSpec()
		{
			Il2CppClassPointerStore<OrgChartSpec>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "OrgChartSpec");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrgChartSpec>.NativeClassPtr);
			OrgChartSpec.NativeFieldInfoPtr__Labels_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrgChartSpec>.NativeClassPtr, "<Labels>k__BackingField");
			OrgChartSpec.NativeFieldInfoPtr__NodeColor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrgChartSpec>.NativeClassPtr, "<NodeColor>k__BackingField");
			OrgChartSpec.NativeFieldInfoPtr__NodeColorStyle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrgChartSpec>.NativeClassPtr, "<NodeColorStyle>k__BackingField");
			OrgChartSpec.NativeFieldInfoPtr__NodeSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrgChartSpec>.NativeClassPtr, "<NodeSize>k__BackingField");
			OrgChartSpec.NativeFieldInfoPtr__ParentLabels_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrgChartSpec>.NativeClassPtr, "<ParentLabels>k__BackingField");
			OrgChartSpec.NativeFieldInfoPtr__SelectedNodeColor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrgChartSpec>.NativeClassPtr, "<SelectedNodeColor>k__BackingField");
			OrgChartSpec.NativeFieldInfoPtr__SelectedNodeColorStyle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrgChartSpec>.NativeClassPtr, "<SelectedNodeColorStyle>k__BackingField");
			OrgChartSpec.NativeFieldInfoPtr__Tooltips_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrgChartSpec>.NativeClassPtr, "<Tooltips>k__BackingField");
			OrgChartSpec.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrgChartSpec>.NativeClassPtr, "<ETag>k__BackingField");
			OrgChartSpec.NativeMethodInfoPtr_get_Labels_Public_Virtual_New_get_ChartData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrgChartSpec>.NativeClassPtr, 100664760);
			OrgChartSpec.NativeMethodInfoPtr_set_Labels_Public_Virtual_New_set_Void_ChartData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrgChartSpec>.NativeClassPtr, 100664761);
			OrgChartSpec.NativeMethodInfoPtr_get_NodeColor_Public_Virtual_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrgChartSpec>.NativeClassPtr, 100664762);
			OrgChartSpec.NativeMethodInfoPtr_set_NodeColor_Public_Virtual_New_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrgChartSpec>.NativeClassPtr, 100664763);
			OrgChartSpec.NativeMethodInfoPtr_get_NodeColorStyle_Public_Virtual_New_get_ColorStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrgChartSpec>.NativeClassPtr, 100664764);
			OrgChartSpec.NativeMethodInfoPtr_set_NodeColorStyle_Public_Virtual_New_set_Void_ColorStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrgChartSpec>.NativeClassPtr, 100664765);
			OrgChartSpec.NativeMethodInfoPtr_get_NodeSize_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrgChartSpec>.NativeClassPtr, 100664766);
			OrgChartSpec.NativeMethodInfoPtr_set_NodeSize_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrgChartSpec>.NativeClassPtr, 100664767);
			OrgChartSpec.NativeMethodInfoPtr_get_ParentLabels_Public_Virtual_New_get_ChartData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrgChartSpec>.NativeClassPtr, 100664768);
			OrgChartSpec.NativeMethodInfoPtr_set_ParentLabels_Public_Virtual_New_set_Void_ChartData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrgChartSpec>.NativeClassPtr, 100664769);
			OrgChartSpec.NativeMethodInfoPtr_get_SelectedNodeColor_Public_Virtual_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrgChartSpec>.NativeClassPtr, 100664770);
			OrgChartSpec.NativeMethodInfoPtr_set_SelectedNodeColor_Public_Virtual_New_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrgChartSpec>.NativeClassPtr, 100664771);
			OrgChartSpec.NativeMethodInfoPtr_get_SelectedNodeColorStyle_Public_Virtual_New_get_ColorStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrgChartSpec>.NativeClassPtr, 100664772);
			OrgChartSpec.NativeMethodInfoPtr_set_SelectedNodeColorStyle_Public_Virtual_New_set_Void_ColorStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrgChartSpec>.NativeClassPtr, 100664773);
			OrgChartSpec.NativeMethodInfoPtr_get_Tooltips_Public_Virtual_New_get_ChartData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrgChartSpec>.NativeClassPtr, 100664774);
			OrgChartSpec.NativeMethodInfoPtr_set_Tooltips_Public_Virtual_New_set_Void_ChartData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrgChartSpec>.NativeClassPtr, 100664775);
			OrgChartSpec.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrgChartSpec>.NativeClassPtr, 100664776);
			OrgChartSpec.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrgChartSpec>.NativeClassPtr, 100664777);
			OrgChartSpec.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrgChartSpec>.NativeClassPtr, 100664778);
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000A3A RID: 2618 RVA: 0x00031FD4 File Offset: 0x000301D4
		// (set) Token: 0x06000A3B RID: 2619 RVA: 0x00032020 File Offset: 0x00030220
		public unsafe virtual ChartData Labels
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrgChartSpec.NativeMethodInfoPtr_get_Labels_Public_Virtual_New_get_ChartData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrgChartSpec.NativeMethodInfoPtr_set_Labels_Public_Virtual_New_set_Void_ChartData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000A3C RID: 2620 RVA: 0x00032070 File Offset: 0x00030270
		// (set) Token: 0x06000A3D RID: 2621 RVA: 0x000320BC File Offset: 0x000302BC
		public unsafe virtual Color NodeColor
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrgChartSpec.NativeMethodInfoPtr_get_NodeColor_Public_Virtual_New_get_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrgChartSpec.NativeMethodInfoPtr_set_NodeColor_Public_Virtual_New_set_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x0003210C File Offset: 0x0003030C
		// (set) Token: 0x06000A3F RID: 2623 RVA: 0x00032158 File Offset: 0x00030358
		public unsafe virtual ColorStyle NodeColorStyle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrgChartSpec.NativeMethodInfoPtr_get_NodeColorStyle_Public_Virtual_New_get_ColorStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrgChartSpec.NativeMethodInfoPtr_set_NodeColorStyle_Public_Virtual_New_set_Void_ColorStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000A40 RID: 2624 RVA: 0x000321A8 File Offset: 0x000303A8
		// (set) Token: 0x06000A41 RID: 2625 RVA: 0x000321EC File Offset: 0x000303EC
		public unsafe virtual string NodeSize
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrgChartSpec.NativeMethodInfoPtr_get_NodeSize_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrgChartSpec.NativeMethodInfoPtr_set_NodeSize_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000A42 RID: 2626 RVA: 0x0003223C File Offset: 0x0003043C
		// (set) Token: 0x06000A43 RID: 2627 RVA: 0x00032288 File Offset: 0x00030488
		public unsafe virtual ChartData ParentLabels
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrgChartSpec.NativeMethodInfoPtr_get_ParentLabels_Public_Virtual_New_get_ChartData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrgChartSpec.NativeMethodInfoPtr_set_ParentLabels_Public_Virtual_New_set_Void_ChartData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000A44 RID: 2628 RVA: 0x000322D8 File Offset: 0x000304D8
		// (set) Token: 0x06000A45 RID: 2629 RVA: 0x00032324 File Offset: 0x00030524
		public unsafe virtual Color SelectedNodeColor
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrgChartSpec.NativeMethodInfoPtr_get_SelectedNodeColor_Public_Virtual_New_get_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrgChartSpec.NativeMethodInfoPtr_set_SelectedNodeColor_Public_Virtual_New_set_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x00032374 File Offset: 0x00030574
		// (set) Token: 0x06000A47 RID: 2631 RVA: 0x000323C0 File Offset: 0x000305C0
		public unsafe virtual ColorStyle SelectedNodeColorStyle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrgChartSpec.NativeMethodInfoPtr_get_SelectedNodeColorStyle_Public_Virtual_New_get_ColorStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrgChartSpec.NativeMethodInfoPtr_set_SelectedNodeColorStyle_Public_Virtual_New_set_Void_ColorStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000A48 RID: 2632 RVA: 0x00032410 File Offset: 0x00030610
		// (set) Token: 0x06000A49 RID: 2633 RVA: 0x0003245C File Offset: 0x0003065C
		public unsafe virtual ChartData Tooltips
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrgChartSpec.NativeMethodInfoPtr_get_Tooltips_Public_Virtual_New_get_ChartData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrgChartSpec.NativeMethodInfoPtr_set_Tooltips_Public_Virtual_New_set_Void_ChartData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000A4A RID: 2634 RVA: 0x000324AC File Offset: 0x000306AC
		// (set) Token: 0x06000A4B RID: 2635 RVA: 0x000324F0 File Offset: 0x000306F0
		public unsafe virtual string ETag
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrgChartSpec.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrgChartSpec.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x00032540 File Offset: 0x00030740
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OrgChartSpec()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrgChartSpec>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrgChartSpec.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00006E55 File Offset: 0x00005055
		public OrgChartSpec(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000A4E RID: 2638 RVA: 0x0003257C File Offset: 0x0003077C
		// (set) Token: 0x06000A4F RID: 2639 RVA: 0x00006E5E File Offset: 0x0000505E
		public unsafe ChartData _Labels_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrgChartSpec.NativeFieldInfoPtr__Labels_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChartData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrgChartSpec.NativeFieldInfoPtr__Labels_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x000325AC File Offset: 0x000307AC
		// (set) Token: 0x06000A51 RID: 2641 RVA: 0x00006E7D File Offset: 0x0000507D
		public unsafe Color _NodeColor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrgChartSpec.NativeFieldInfoPtr__NodeColor_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrgChartSpec.NativeFieldInfoPtr__NodeColor_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x000325DC File Offset: 0x000307DC
		// (set) Token: 0x06000A53 RID: 2643 RVA: 0x00006E9C File Offset: 0x0000509C
		public unsafe ColorStyle _NodeColorStyle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrgChartSpec.NativeFieldInfoPtr__NodeColorStyle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrgChartSpec.NativeFieldInfoPtr__NodeColorStyle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000A54 RID: 2644 RVA: 0x0003260C File Offset: 0x0003080C
		// (set) Token: 0x06000A55 RID: 2645 RVA: 0x00006EBB File Offset: 0x000050BB
		public unsafe string _NodeSize_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrgChartSpec.NativeFieldInfoPtr__NodeSize_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrgChartSpec.NativeFieldInfoPtr__NodeSize_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000A56 RID: 2646 RVA: 0x00032634 File Offset: 0x00030834
		// (set) Token: 0x06000A57 RID: 2647 RVA: 0x00006EDA File Offset: 0x000050DA
		public unsafe ChartData _ParentLabels_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrgChartSpec.NativeFieldInfoPtr__ParentLabels_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChartData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrgChartSpec.NativeFieldInfoPtr__ParentLabels_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000A58 RID: 2648 RVA: 0x00032664 File Offset: 0x00030864
		// (set) Token: 0x06000A59 RID: 2649 RVA: 0x00006EF9 File Offset: 0x000050F9
		public unsafe Color _SelectedNodeColor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrgChartSpec.NativeFieldInfoPtr__SelectedNodeColor_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrgChartSpec.NativeFieldInfoPtr__SelectedNodeColor_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000A5A RID: 2650 RVA: 0x00032694 File Offset: 0x00030894
		// (set) Token: 0x06000A5B RID: 2651 RVA: 0x00006F18 File Offset: 0x00005118
		public unsafe ColorStyle _SelectedNodeColorStyle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrgChartSpec.NativeFieldInfoPtr__SelectedNodeColorStyle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrgChartSpec.NativeFieldInfoPtr__SelectedNodeColorStyle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x000326C4 File Offset: 0x000308C4
		// (set) Token: 0x06000A5D RID: 2653 RVA: 0x00006F37 File Offset: 0x00005137
		public unsafe ChartData _Tooltips_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrgChartSpec.NativeFieldInfoPtr__Tooltips_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChartData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrgChartSpec.NativeFieldInfoPtr__Tooltips_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x000326F4 File Offset: 0x000308F4
		// (set) Token: 0x06000A5F RID: 2655 RVA: 0x00006F56 File Offset: 0x00005156
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrgChartSpec.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrgChartSpec.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeFieldInfoPtr__Labels_k__BackingField;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeFieldInfoPtr__NodeColor_k__BackingField;

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeFieldInfoPtr__NodeColorStyle_k__BackingField;

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeFieldInfoPtr__NodeSize_k__BackingField;

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeFieldInfoPtr__ParentLabels_k__BackingField;

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeFieldInfoPtr__SelectedNodeColor_k__BackingField;

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeFieldInfoPtr__SelectedNodeColorStyle_k__BackingField;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeFieldInfoPtr__Tooltips_k__BackingField;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeMethodInfoPtr_get_Labels_Public_Virtual_New_get_ChartData_0;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeMethodInfoPtr_set_Labels_Public_Virtual_New_set_Void_ChartData_0;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeColor_Public_Virtual_New_get_Color_0;

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeMethodInfoPtr_set_NodeColor_Public_Virtual_New_set_Void_Color_0;

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeColorStyle_Public_Virtual_New_get_ColorStyle_0;

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeMethodInfoPtr_set_NodeColorStyle_Public_Virtual_New_set_Void_ColorStyle_0;

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeSize_Public_Virtual_New_get_String_0;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeMethodInfoPtr_set_NodeSize_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentLabels_Public_Virtual_New_get_ChartData_0;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeMethodInfoPtr_set_ParentLabels_Public_Virtual_New_set_Void_ChartData_0;

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedNodeColor_Public_Virtual_New_get_Color_0;

		// Token: 0x04000715 RID: 1813
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedNodeColor_Public_Virtual_New_set_Void_Color_0;

		// Token: 0x04000716 RID: 1814
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedNodeColorStyle_Public_Virtual_New_get_ColorStyle_0;

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedNodeColorStyle_Public_Virtual_New_set_Void_ColorStyle_0;

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeMethodInfoPtr_get_Tooltips_Public_Virtual_New_get_ChartData_0;

		// Token: 0x04000719 RID: 1817
		private static readonly IntPtr NativeMethodInfoPtr_set_Tooltips_Public_Virtual_New_set_Void_ChartData_0;

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
