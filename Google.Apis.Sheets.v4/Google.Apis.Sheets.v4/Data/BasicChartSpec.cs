using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000021 RID: 33
	public class BasicChartSpec : Object
	{
		// Token: 0x0600021A RID: 538 RVA: 0x00012F84 File Offset: 0x00011184
		// Note: this type is marked as 'beforefieldinit'.
		static BasicChartSpec()
		{
			Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "BasicChartSpec");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr);
			BasicChartSpec.NativeFieldInfoPtr__Axis_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, "<Axis>k__BackingField");
			BasicChartSpec.NativeFieldInfoPtr__ChartType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, "<ChartType>k__BackingField");
			BasicChartSpec.NativeFieldInfoPtr__CompareMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, "<CompareMode>k__BackingField");
			BasicChartSpec.NativeFieldInfoPtr__Domains_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, "<Domains>k__BackingField");
			BasicChartSpec.NativeFieldInfoPtr__HeaderCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, "<HeaderCount>k__BackingField");
			BasicChartSpec.NativeFieldInfoPtr__InterpolateNulls_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, "<InterpolateNulls>k__BackingField");
			BasicChartSpec.NativeFieldInfoPtr__LegendPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, "<LegendPosition>k__BackingField");
			BasicChartSpec.NativeFieldInfoPtr__LineSmoothing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, "<LineSmoothing>k__BackingField");
			BasicChartSpec.NativeFieldInfoPtr__Series_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, "<Series>k__BackingField");
			BasicChartSpec.NativeFieldInfoPtr__StackedType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, "<StackedType>k__BackingField");
			BasicChartSpec.NativeFieldInfoPtr__ThreeDimensional_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, "<ThreeDimensional>k__BackingField");
			BasicChartSpec.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, "<ETag>k__BackingField");
			BasicChartSpec.NativeMethodInfoPtr_get_Axis_Public_Virtual_New_get_IList_1_BasicChartAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, 100663773);
			BasicChartSpec.NativeMethodInfoPtr_set_Axis_Public_Virtual_New_set_Void_IList_1_BasicChartAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, 100663774);
			BasicChartSpec.NativeMethodInfoPtr_get_ChartType_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, 100663775);
			BasicChartSpec.NativeMethodInfoPtr_set_ChartType_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, 100663776);
			BasicChartSpec.NativeMethodInfoPtr_get_CompareMode_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, 100663777);
			BasicChartSpec.NativeMethodInfoPtr_set_CompareMode_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, 100663778);
			BasicChartSpec.NativeMethodInfoPtr_get_Domains_Public_Virtual_New_get_IList_1_BasicChartDomain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, 100663779);
			BasicChartSpec.NativeMethodInfoPtr_set_Domains_Public_Virtual_New_set_Void_IList_1_BasicChartDomain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, 100663780);
			BasicChartSpec.NativeMethodInfoPtr_get_HeaderCount_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, 100663781);
			BasicChartSpec.NativeMethodInfoPtr_set_HeaderCount_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, 100663782);
			BasicChartSpec.NativeMethodInfoPtr_get_InterpolateNulls_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, 100663783);
			BasicChartSpec.NativeMethodInfoPtr_set_InterpolateNulls_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, 100663784);
			BasicChartSpec.NativeMethodInfoPtr_get_LegendPosition_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, 100663785);
			BasicChartSpec.NativeMethodInfoPtr_set_LegendPosition_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, 100663786);
			BasicChartSpec.NativeMethodInfoPtr_get_LineSmoothing_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, 100663787);
			BasicChartSpec.NativeMethodInfoPtr_set_LineSmoothing_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, 100663788);
			BasicChartSpec.NativeMethodInfoPtr_get_Series_Public_Virtual_New_get_IList_1_BasicChartSeries_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, 100663789);
			BasicChartSpec.NativeMethodInfoPtr_set_Series_Public_Virtual_New_set_Void_IList_1_BasicChartSeries_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, 100663790);
			BasicChartSpec.NativeMethodInfoPtr_get_StackedType_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, 100663791);
			BasicChartSpec.NativeMethodInfoPtr_set_StackedType_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, 100663792);
			BasicChartSpec.NativeMethodInfoPtr_get_ThreeDimensional_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, 100663793);
			BasicChartSpec.NativeMethodInfoPtr_set_ThreeDimensional_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, 100663794);
			BasicChartSpec.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, 100663795);
			BasicChartSpec.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, 100663796);
			BasicChartSpec.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr, 100663797);
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00013298 File Offset: 0x00011498
		// (set) Token: 0x0600021C RID: 540 RVA: 0x000132E4 File Offset: 0x000114E4
		public unsafe virtual IList<BasicChartAxis> Axis
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSpec.NativeMethodInfoPtr_get_Axis_Public_Virtual_New_get_IList_1_BasicChartAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<BasicChartAxis>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSpec.NativeMethodInfoPtr_set_Axis_Public_Virtual_New_set_Void_IList_1_BasicChartAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00013334 File Offset: 0x00011534
		// (set) Token: 0x0600021E RID: 542 RVA: 0x00013378 File Offset: 0x00011578
		public unsafe virtual string ChartType
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSpec.NativeMethodInfoPtr_get_ChartType_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSpec.NativeMethodInfoPtr_set_ChartType_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600021F RID: 543 RVA: 0x000133C8 File Offset: 0x000115C8
		// (set) Token: 0x06000220 RID: 544 RVA: 0x0001340C File Offset: 0x0001160C
		public unsafe virtual string CompareMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSpec.NativeMethodInfoPtr_get_CompareMode_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSpec.NativeMethodInfoPtr_set_CompareMode_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000221 RID: 545 RVA: 0x0001345C File Offset: 0x0001165C
		// (set) Token: 0x06000222 RID: 546 RVA: 0x000134A8 File Offset: 0x000116A8
		public unsafe virtual IList<BasicChartDomain> Domains
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSpec.NativeMethodInfoPtr_get_Domains_Public_Virtual_New_get_IList_1_BasicChartDomain_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<BasicChartDomain>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSpec.NativeMethodInfoPtr_set_Domains_Public_Virtual_New_set_Void_IList_1_BasicChartDomain_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000223 RID: 547 RVA: 0x000134F8 File Offset: 0x000116F8
		// (set) Token: 0x06000224 RID: 548 RVA: 0x0001353C File Offset: 0x0001173C
		public unsafe virtual Nullable<int> HeaderCount
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSpec.NativeMethodInfoPtr_get_HeaderCount_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSpec.NativeMethodInfoPtr_set_HeaderCount_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000225 RID: 549 RVA: 0x00013590 File Offset: 0x00011790
		// (set) Token: 0x06000226 RID: 550 RVA: 0x000135D4 File Offset: 0x000117D4
		public unsafe virtual Nullable<bool> InterpolateNulls
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSpec.NativeMethodInfoPtr_get_InterpolateNulls_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSpec.NativeMethodInfoPtr_set_InterpolateNulls_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00013628 File Offset: 0x00011828
		// (set) Token: 0x06000228 RID: 552 RVA: 0x0001366C File Offset: 0x0001186C
		public unsafe virtual string LegendPosition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSpec.NativeMethodInfoPtr_get_LegendPosition_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSpec.NativeMethodInfoPtr_set_LegendPosition_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000229 RID: 553 RVA: 0x000136BC File Offset: 0x000118BC
		// (set) Token: 0x0600022A RID: 554 RVA: 0x00013700 File Offset: 0x00011900
		public unsafe virtual Nullable<bool> LineSmoothing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSpec.NativeMethodInfoPtr_get_LineSmoothing_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSpec.NativeMethodInfoPtr_set_LineSmoothing_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600022B RID: 555 RVA: 0x00013754 File Offset: 0x00011954
		// (set) Token: 0x0600022C RID: 556 RVA: 0x000137A0 File Offset: 0x000119A0
		public unsafe virtual IList<BasicChartSeries> Series
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSpec.NativeMethodInfoPtr_get_Series_Public_Virtual_New_get_IList_1_BasicChartSeries_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<BasicChartSeries>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSpec.NativeMethodInfoPtr_set_Series_Public_Virtual_New_set_Void_IList_1_BasicChartSeries_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600022D RID: 557 RVA: 0x000137F0 File Offset: 0x000119F0
		// (set) Token: 0x0600022E RID: 558 RVA: 0x00013834 File Offset: 0x00011A34
		public unsafe virtual string StackedType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSpec.NativeMethodInfoPtr_get_StackedType_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSpec.NativeMethodInfoPtr_set_StackedType_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00013884 File Offset: 0x00011A84
		// (set) Token: 0x06000230 RID: 560 RVA: 0x000138C8 File Offset: 0x00011AC8
		public unsafe virtual Nullable<bool> ThreeDimensional
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSpec.NativeMethodInfoPtr_get_ThreeDimensional_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSpec.NativeMethodInfoPtr_set_ThreeDimensional_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000231 RID: 561 RVA: 0x0001391C File Offset: 0x00011B1C
		// (set) Token: 0x06000232 RID: 562 RVA: 0x00013960 File Offset: 0x00011B60
		public unsafe virtual string ETag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSpec.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChartSpec.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000233 RID: 563 RVA: 0x000139B0 File Offset: 0x00011BB0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasicChartSpec()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicChartSpec>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicChartSpec.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002F43 File Offset: 0x00001143
		public BasicChartSpec(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000235 RID: 565 RVA: 0x000139EC File Offset: 0x00011BEC
		// (set) Token: 0x06000236 RID: 566 RVA: 0x00002F4C File Offset: 0x0000114C
		public unsafe IList<BasicChartAxis> _Axis_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSpec.NativeFieldInfoPtr__Axis_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<BasicChartAxis>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSpec.NativeFieldInfoPtr__Axis_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000237 RID: 567 RVA: 0x00013A1C File Offset: 0x00011C1C
		// (set) Token: 0x06000238 RID: 568 RVA: 0x00002F6B File Offset: 0x0000116B
		public unsafe string _ChartType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSpec.NativeFieldInfoPtr__ChartType_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSpec.NativeFieldInfoPtr__ChartType_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000239 RID: 569 RVA: 0x00013A44 File Offset: 0x00011C44
		// (set) Token: 0x0600023A RID: 570 RVA: 0x00002F8A File Offset: 0x0000118A
		public unsafe string _CompareMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSpec.NativeFieldInfoPtr__CompareMode_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSpec.NativeFieldInfoPtr__CompareMode_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600023B RID: 571 RVA: 0x00013A6C File Offset: 0x00011C6C
		// (set) Token: 0x0600023C RID: 572 RVA: 0x00002FA9 File Offset: 0x000011A9
		public unsafe IList<BasicChartDomain> _Domains_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSpec.NativeFieldInfoPtr__Domains_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<BasicChartDomain>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSpec.NativeFieldInfoPtr__Domains_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600023D RID: 573 RVA: 0x00013A9C File Offset: 0x00011C9C
		// (set) Token: 0x0600023E RID: 574 RVA: 0x00002FC8 File Offset: 0x000011C8
		public Nullable<int> _HeaderCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSpec.NativeFieldInfoPtr__HeaderCount_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSpec.NativeFieldInfoPtr__HeaderCount_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600023F RID: 575 RVA: 0x00013ACC File Offset: 0x00011CCC
		// (set) Token: 0x06000240 RID: 576 RVA: 0x00002FF6 File Offset: 0x000011F6
		public Nullable<bool> _InterpolateNulls_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSpec.NativeFieldInfoPtr__InterpolateNulls_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSpec.NativeFieldInfoPtr__InterpolateNulls_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00013AFC File Offset: 0x00011CFC
		// (set) Token: 0x06000242 RID: 578 RVA: 0x00003024 File Offset: 0x00001224
		public unsafe string _LegendPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSpec.NativeFieldInfoPtr__LegendPosition_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSpec.NativeFieldInfoPtr__LegendPosition_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00013B24 File Offset: 0x00011D24
		// (set) Token: 0x06000244 RID: 580 RVA: 0x00003043 File Offset: 0x00001243
		public Nullable<bool> _LineSmoothing_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSpec.NativeFieldInfoPtr__LineSmoothing_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSpec.NativeFieldInfoPtr__LineSmoothing_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00013B54 File Offset: 0x00011D54
		// (set) Token: 0x06000246 RID: 582 RVA: 0x00003071 File Offset: 0x00001271
		public unsafe IList<BasicChartSeries> _Series_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSpec.NativeFieldInfoPtr__Series_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<BasicChartSeries>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSpec.NativeFieldInfoPtr__Series_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000247 RID: 583 RVA: 0x00013B84 File Offset: 0x00011D84
		// (set) Token: 0x06000248 RID: 584 RVA: 0x00003090 File Offset: 0x00001290
		public unsafe string _StackedType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSpec.NativeFieldInfoPtr__StackedType_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSpec.NativeFieldInfoPtr__StackedType_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000249 RID: 585 RVA: 0x00013BAC File Offset: 0x00011DAC
		// (set) Token: 0x0600024A RID: 586 RVA: 0x000030AF File Offset: 0x000012AF
		public Nullable<bool> _ThreeDimensional_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSpec.NativeFieldInfoPtr__ThreeDimensional_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSpec.NativeFieldInfoPtr__ThreeDimensional_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00013BDC File Offset: 0x00011DDC
		// (set) Token: 0x0600024C RID: 588 RVA: 0x000030DD File Offset: 0x000012DD
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSpec.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChartSpec.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeFieldInfoPtr__Axis_k__BackingField;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeFieldInfoPtr__ChartType_k__BackingField;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeFieldInfoPtr__CompareMode_k__BackingField;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeFieldInfoPtr__Domains_k__BackingField;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeFieldInfoPtr__HeaderCount_k__BackingField;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeFieldInfoPtr__InterpolateNulls_k__BackingField;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeFieldInfoPtr__LegendPosition_k__BackingField;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeFieldInfoPtr__LineSmoothing_k__BackingField;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeFieldInfoPtr__Series_k__BackingField;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeFieldInfoPtr__StackedType_k__BackingField;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeFieldInfoPtr__ThreeDimensional_k__BackingField;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_get_Axis_Public_Virtual_New_get_IList_1_BasicChartAxis_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_set_Axis_Public_Virtual_New_set_Void_IList_1_BasicChartAxis_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_get_ChartType_Public_Virtual_New_get_String_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr_set_ChartType_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr_get_CompareMode_Public_Virtual_New_get_String_0;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_set_CompareMode_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr_get_Domains_Public_Virtual_New_get_IList_1_BasicChartDomain_0;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr_set_Domains_Public_Virtual_New_set_Void_IList_1_BasicChartDomain_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_get_HeaderCount_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr_set_HeaderCount_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_get_InterpolateNulls_Public_Virtual_New_get_Nullable_1_Boolean_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_set_InterpolateNulls_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr_get_LegendPosition_Public_Virtual_New_get_String_0;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_set_LegendPosition_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_get_LineSmoothing_Public_Virtual_New_get_Nullable_1_Boolean_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_set_LineSmoothing_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_get_Series_Public_Virtual_New_get_IList_1_BasicChartSeries_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_set_Series_Public_Virtual_New_set_Void_IList_1_BasicChartSeries_0;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr_get_StackedType_Public_Virtual_New_get_String_0;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr_set_StackedType_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr_get_ThreeDimensional_Public_Virtual_New_get_Nullable_1_Boolean_0;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr_set_ThreeDimensional_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
