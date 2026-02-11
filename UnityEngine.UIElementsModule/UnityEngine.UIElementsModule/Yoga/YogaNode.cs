using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Yoga
{
	// Token: 0x02000011 RID: 17
	public class YogaNode : Object
	{
		// Token: 0x060000AA RID: 170 RVA: 0x0001ED84 File Offset: 0x0001CF84
		// Note: this type is marked as 'beforefieldinit'.
		static YogaNode()
		{
			Il2CppClassPointerStore<YogaNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.Yoga", "YogaNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YogaNode>.NativeClassPtr);
			YogaNode.NativeFieldInfoPtr__ygNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, "_ygNode");
			YogaNode.NativeFieldInfoPtr__config = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, "_config");
			YogaNode.NativeFieldInfoPtr__parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, "_parent");
			YogaNode.NativeFieldInfoPtr__children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, "_children");
			YogaNode.NativeFieldInfoPtr__measureFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, "_measureFunction");
			YogaNode.NativeFieldInfoPtr__baselineFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, "_baselineFunction");
			YogaNode.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, "_data");
			YogaNode.NativeMethodInfoPtr__ctor_Public_Void_YogaConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663384);
			YogaNode.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663385);
			YogaNode.NativeMethodInfoPtr_set_Config_Internal_set_Void_YogaConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663386);
			YogaNode.NativeMethodInfoPtr_get_IsDirty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663387);
			YogaNode.NativeMethodInfoPtr_MarkDirty_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663388);
			YogaNode.NativeMethodInfoPtr_get_HasNewLayout_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663389);
			YogaNode.NativeMethodInfoPtr_get_IsMeasureDefined_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663390);
			YogaNode.NativeMethodInfoPtr_get_IsBaselineDefined_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663391);
			YogaNode.NativeMethodInfoPtr_CopyStyle_Public_Void_YogaNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663392);
			YogaNode.NativeMethodInfoPtr_set_FlexDirection_Public_set_Void_YogaFlexDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663393);
			YogaNode.NativeMethodInfoPtr_set_JustifyContent_Public_set_Void_YogaJustify_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663394);
			YogaNode.NativeMethodInfoPtr_set_Display_Public_set_Void_YogaDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663395);
			YogaNode.NativeMethodInfoPtr_set_AlignItems_Public_set_Void_YogaAlign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663396);
			YogaNode.NativeMethodInfoPtr_set_AlignSelf_Public_set_Void_YogaAlign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663397);
			YogaNode.NativeMethodInfoPtr_set_AlignContent_Public_set_Void_YogaAlign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663398);
			YogaNode.NativeMethodInfoPtr_set_PositionType_Public_set_Void_YogaPositionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663399);
			YogaNode.NativeMethodInfoPtr_set_Wrap_Public_set_Void_YogaWrap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663400);
			YogaNode.NativeMethodInfoPtr_set_Flex_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663401);
			YogaNode.NativeMethodInfoPtr_set_FlexGrow_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663402);
			YogaNode.NativeMethodInfoPtr_set_FlexShrink_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663403);
			YogaNode.NativeMethodInfoPtr_set_FlexBasis_Public_set_Void_YogaValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663404);
			YogaNode.NativeMethodInfoPtr_set_Width_Public_set_Void_YogaValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663405);
			YogaNode.NativeMethodInfoPtr_set_Height_Public_set_Void_YogaValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663406);
			YogaNode.NativeMethodInfoPtr_set_MaxWidth_Public_set_Void_YogaValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663407);
			YogaNode.NativeMethodInfoPtr_set_MaxHeight_Public_set_Void_YogaValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663408);
			YogaNode.NativeMethodInfoPtr_set_MinWidth_Public_set_Void_YogaValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663409);
			YogaNode.NativeMethodInfoPtr_set_MinHeight_Public_set_Void_YogaValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663410);
			YogaNode.NativeMethodInfoPtr_get_LayoutX_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663411);
			YogaNode.NativeMethodInfoPtr_get_LayoutY_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663412);
			YogaNode.NativeMethodInfoPtr_get_LayoutRight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663413);
			YogaNode.NativeMethodInfoPtr_get_LayoutBottom_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663414);
			YogaNode.NativeMethodInfoPtr_get_LayoutWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663415);
			YogaNode.NativeMethodInfoPtr_get_LayoutHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663416);
			YogaNode.NativeMethodInfoPtr_set_Overflow_Public_set_Void_YogaOverflow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663417);
			YogaNode.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663418);
			YogaNode.NativeMethodInfoPtr_MarkLayoutSeen_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663419);
			YogaNode.NativeMethodInfoPtr_Insert_Public_Void_Int32_YogaNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663420);
			YogaNode.NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663421);
			YogaNode.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663422);
			YogaNode.NativeMethodInfoPtr_SetMeasureFunction_Public_Void_MeasureFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663423);
			YogaNode.NativeMethodInfoPtr_CalculateLayout_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663424);
			YogaNode.NativeMethodInfoPtr_MeasureInternal_Public_Static_YogaSize_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663425);
			YogaNode.NativeMethodInfoPtr_BaselineInternal_Public_Static_Single_YogaNode_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663426);
			YogaNode.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_YogaNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663427);
			YogaNode.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663428);
			YogaNode.NativeMethodInfoPtr_set_Left_Public_set_Void_YogaValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663429);
			YogaNode.NativeMethodInfoPtr_set_Top_Public_set_Void_YogaValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663430);
			YogaNode.NativeMethodInfoPtr_set_Right_Public_set_Void_YogaValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663431);
			YogaNode.NativeMethodInfoPtr_set_Bottom_Public_set_Void_YogaValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663432);
			YogaNode.NativeMethodInfoPtr_SetStylePosition_Private_Void_YogaEdge_YogaValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663433);
			YogaNode.NativeMethodInfoPtr_set_MarginLeft_Public_set_Void_YogaValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663434);
			YogaNode.NativeMethodInfoPtr_set_MarginTop_Public_set_Void_YogaValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663435);
			YogaNode.NativeMethodInfoPtr_set_MarginRight_Public_set_Void_YogaValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663436);
			YogaNode.NativeMethodInfoPtr_set_MarginBottom_Public_set_Void_YogaValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663437);
			YogaNode.NativeMethodInfoPtr_SetStyleMargin_Private_Void_YogaEdge_YogaValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663438);
			YogaNode.NativeMethodInfoPtr_set_PaddingLeft_Public_set_Void_YogaValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663439);
			YogaNode.NativeMethodInfoPtr_set_PaddingTop_Public_set_Void_YogaValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663440);
			YogaNode.NativeMethodInfoPtr_set_PaddingRight_Public_set_Void_YogaValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663441);
			YogaNode.NativeMethodInfoPtr_set_PaddingBottom_Public_set_Void_YogaValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663442);
			YogaNode.NativeMethodInfoPtr_SetStylePadding_Private_Void_YogaEdge_YogaValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663443);
			YogaNode.NativeMethodInfoPtr_set_BorderLeftWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663444);
			YogaNode.NativeMethodInfoPtr_set_BorderTopWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663445);
			YogaNode.NativeMethodInfoPtr_set_BorderRightWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663446);
			YogaNode.NativeMethodInfoPtr_set_BorderBottomWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663447);
			YogaNode.NativeMethodInfoPtr_get_LayoutMarginLeft_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663448);
			YogaNode.NativeMethodInfoPtr_get_LayoutMarginTop_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663449);
			YogaNode.NativeMethodInfoPtr_get_LayoutMarginRight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663450);
			YogaNode.NativeMethodInfoPtr_get_LayoutMarginBottom_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663451);
			YogaNode.NativeMethodInfoPtr_get_LayoutPaddingLeft_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663452);
			YogaNode.NativeMethodInfoPtr_get_LayoutPaddingTop_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663453);
			YogaNode.NativeMethodInfoPtr_get_LayoutPaddingRight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663454);
			YogaNode.NativeMethodInfoPtr_get_LayoutPaddingBottom_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663455);
			YogaNode.NativeMethodInfoPtr_get_LayoutBorderLeft_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663456);
			YogaNode.NativeMethodInfoPtr_get_LayoutBorderTop_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663457);
			YogaNode.NativeMethodInfoPtr_get_LayoutBorderRight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663458);
			YogaNode.NativeMethodInfoPtr_get_LayoutBorderBottom_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaNode>.NativeClassPtr, 100663459);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0001F430 File Offset: 0x0001D630
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 282760, RefRangeEnd = 282763, XrefRangeStart = 282751, XrefRangeEnd = 282760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe YogaNode(YogaConfig config = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YogaNode>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(config);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr__ctor_Public_Void_YogaConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0001F47C File Offset: 0x0001D67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282763, XrefRangeEnd = 282769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), YogaNode.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00020D90 File Offset: 0x0001EF90
		// (set) Token: 0x060000AD RID: 173 RVA: 0x0001F4B8 File Offset: 0x0001D6B8
		public unsafe YogaConfig Config
		{
			get
			{
				return this._config;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 282777, RefRangeEnd = 282779, XrefRangeStart = 282769, XrefRangeEnd = 282777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_Config_Internal_set_Void_YogaConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0001F4FC File Offset: 0x0001D6FC
		public unsafe bool IsDirty
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 282781, RefRangeEnd = 282782, XrefRangeStart = 282779, XrefRangeEnd = 282781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_get_IsDirty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0001F538 File Offset: 0x0001D738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282782, XrefRangeEnd = 282784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MarkDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), YogaNode.NativeMethodInfoPtr_MarkDirty_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x0001F574 File Offset: 0x0001D774
		public unsafe bool HasNewLayout
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 282786, RefRangeEnd = 282788, XrefRangeStart = 282784, XrefRangeEnd = 282786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_get_HasNewLayout_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x0001F5B0 File Offset: 0x0001D7B0
		public unsafe bool IsMeasureDefined
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 282788, RefRangeEnd = 282791, XrefRangeStart = 282788, XrefRangeEnd = 282788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_get_IsMeasureDefined_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x0001F5EC File Offset: 0x0001D7EC
		public unsafe bool IsBaselineDefined
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_get_IsBaselineDefined_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0001F628 File Offset: 0x0001D828
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282794, RefRangeEnd = 282795, XrefRangeStart = 282791, XrefRangeEnd = 282794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyStyle(YogaNode srcNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(srcNode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_CopyStyle_Public_Void_YogaNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00020DF8 File Offset: 0x0001EFF8
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x0001F66C File Offset: 0x0001D86C
		public unsafe YogaFlexDirection FlexDirection
		{
			get
			{
				return Native.YGNodeStyleGetFlexDirection(this._ygNode);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 282797, RefRangeEnd = 282800, XrefRangeStart = 282795, XrefRangeEnd = 282797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_FlexDirection_Public_set_Void_YogaFlexDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00020E18 File Offset: 0x0001F018
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x0001F6AC File Offset: 0x0001D8AC
		public unsafe YogaJustify JustifyContent
		{
			get
			{
				return Native.YGNodeStyleGetJustifyContent(this._ygNode);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 282802, RefRangeEnd = 282804, XrefRangeStart = 282800, XrefRangeEnd = 282802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_JustifyContent_Public_set_Void_YogaJustify_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00020E38 File Offset: 0x0001F038
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x0001F6EC File Offset: 0x0001D8EC
		public unsafe YogaDisplay Display
		{
			get
			{
				return Native.YGNodeStyleGetDisplay(this._ygNode);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 282806, RefRangeEnd = 282809, XrefRangeStart = 282804, XrefRangeEnd = 282806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_Display_Public_set_Void_YogaDisplay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00020E58 File Offset: 0x0001F058
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x0001F72C File Offset: 0x0001D92C
		public unsafe YogaAlign AlignItems
		{
			get
			{
				return Native.YGNodeStyleGetAlignItems(this._ygNode);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 282811, RefRangeEnd = 282813, XrefRangeStart = 282809, XrefRangeEnd = 282811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_AlignItems_Public_set_Void_YogaAlign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00020E78 File Offset: 0x0001F078
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x0001F76C File Offset: 0x0001D96C
		public unsafe YogaAlign AlignSelf
		{
			get
			{
				return Native.YGNodeStyleGetAlignSelf(this._ygNode);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 282815, RefRangeEnd = 282817, XrefRangeStart = 282813, XrefRangeEnd = 282815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_AlignSelf_Public_set_Void_YogaAlign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00020E98 File Offset: 0x0001F098
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x0001F7AC File Offset: 0x0001D9AC
		public unsafe YogaAlign AlignContent
		{
			get
			{
				return Native.YGNodeStyleGetAlignContent(this._ygNode);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 282819, RefRangeEnd = 282821, XrefRangeStart = 282817, XrefRangeEnd = 282819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_AlignContent_Public_set_Void_YogaAlign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00020EB8 File Offset: 0x0001F0B8
		// (set) Token: 0x060000BA RID: 186 RVA: 0x0001F7EC File Offset: 0x0001D9EC
		public unsafe YogaPositionType PositionType
		{
			get
			{
				return Native.YGNodeStyleGetPositionType(this._ygNode);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 282823, RefRangeEnd = 282826, XrefRangeStart = 282821, XrefRangeEnd = 282823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_PositionType_Public_set_Void_YogaPositionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00020ED8 File Offset: 0x0001F0D8
		// (set) Token: 0x060000BB RID: 187 RVA: 0x0001F82C File Offset: 0x0001DA2C
		public unsafe YogaWrap Wrap
		{
			get
			{
				return Native.YGNodeStyleGetFlexWrap(this._ygNode);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 282828, RefRangeEnd = 282830, XrefRangeStart = 282826, XrefRangeEnd = 282828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_Wrap_Public_set_Void_YogaWrap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001C RID: 28
		// (set) Token: 0x060000BC RID: 188 RVA: 0x0001F86C File Offset: 0x0001DA6C
		public unsafe float Flex
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 282832, RefRangeEnd = 282833, XrefRangeStart = 282830, XrefRangeEnd = 282832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_Flex_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00020EF8 File Offset: 0x0001F0F8
		// (set) Token: 0x060000BD RID: 189 RVA: 0x0001F8AC File Offset: 0x0001DAAC
		public unsafe float FlexGrow
		{
			get
			{
				return Native.YGNodeStyleGetFlexGrow(this._ygNode);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 282835, RefRangeEnd = 282837, XrefRangeStart = 282833, XrefRangeEnd = 282835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_FlexGrow_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00020F18 File Offset: 0x0001F118
		// (set) Token: 0x060000BE RID: 190 RVA: 0x0001F8EC File Offset: 0x0001DAEC
		public unsafe float FlexShrink
		{
			get
			{
				return Native.YGNodeStyleGetFlexShrink(this._ygNode);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 282839, RefRangeEnd = 282841, XrefRangeStart = 282837, XrefRangeEnd = 282839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_FlexShrink_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00020F38 File Offset: 0x0001F138
		// (set) Token: 0x060000BF RID: 191 RVA: 0x0001F92C File Offset: 0x0001DB2C
		public unsafe YogaValue FlexBasis
		{
			get
			{
				return YogaValue.MarshalValue(Native.YGNodeStyleGetFlexBasis(this._ygNode));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 282847, RefRangeEnd = 282849, XrefRangeStart = 282841, XrefRangeEnd = 282847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_FlexBasis_Public_set_Void_YogaValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00020F5C File Offset: 0x0001F15C
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x0001F96C File Offset: 0x0001DB6C
		public unsafe YogaValue Width
		{
			get
			{
				return YogaValue.MarshalValue(Native.YGNodeStyleGetWidth(this._ygNode));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 282855, RefRangeEnd = 282857, XrefRangeStart = 282849, XrefRangeEnd = 282855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_Width_Public_set_Void_YogaValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00020F80 File Offset: 0x0001F180
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x0001F9AC File Offset: 0x0001DBAC
		public unsafe YogaValue Height
		{
			get
			{
				return YogaValue.MarshalValue(Native.YGNodeStyleGetHeight(this._ygNode));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 282863, RefRangeEnd = 282865, XrefRangeStart = 282857, XrefRangeEnd = 282863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_Height_Public_set_Void_YogaValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00020FA4 File Offset: 0x0001F1A4
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x0001F9EC File Offset: 0x0001DBEC
		public unsafe YogaValue MaxWidth
		{
			get
			{
				return YogaValue.MarshalValue(Native.YGNodeStyleGetMaxWidth(this._ygNode));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 282867, RefRangeEnd = 282869, XrefRangeStart = 282865, XrefRangeEnd = 282867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_MaxWidth_Public_set_Void_YogaValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00020FC8 File Offset: 0x0001F1C8
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x0001FA2C File Offset: 0x0001DC2C
		public unsafe YogaValue MaxHeight
		{
			get
			{
				return YogaValue.MarshalValue(Native.YGNodeStyleGetMaxHeight(this._ygNode));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 282871, RefRangeEnd = 282873, XrefRangeStart = 282869, XrefRangeEnd = 282871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_MaxHeight_Public_set_Void_YogaValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00020FEC File Offset: 0x0001F1EC
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x0001FA6C File Offset: 0x0001DC6C
		public unsafe YogaValue MinWidth
		{
			get
			{
				return YogaValue.MarshalValue(Native.YGNodeStyleGetMinWidth(this._ygNode));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 282875, RefRangeEnd = 282877, XrefRangeStart = 282873, XrefRangeEnd = 282875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_MinWidth_Public_set_Void_YogaValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00021010 File Offset: 0x0001F210
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x0001FAAC File Offset: 0x0001DCAC
		public unsafe YogaValue MinHeight
		{
			get
			{
				return YogaValue.MarshalValue(Native.YGNodeStyleGetMinHeight(this._ygNode));
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 282879, RefRangeEnd = 282880, XrefRangeStart = 282877, XrefRangeEnd = 282879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_MinHeight_Public_set_Void_YogaValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x0001FAEC File Offset: 0x0001DCEC
		public unsafe float LayoutX
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 282882, RefRangeEnd = 282885, XrefRangeStart = 282880, XrefRangeEnd = 282882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_get_LayoutX_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x0001FB28 File Offset: 0x0001DD28
		public unsafe float LayoutY
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 282887, RefRangeEnd = 282890, XrefRangeStart = 282885, XrefRangeEnd = 282887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_get_LayoutY_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x0001FB64 File Offset: 0x0001DD64
		public unsafe float LayoutRight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 282892, RefRangeEnd = 282893, XrefRangeStart = 282890, XrefRangeEnd = 282892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_get_LayoutRight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x0001FBA0 File Offset: 0x0001DDA0
		public unsafe float LayoutBottom
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 282895, RefRangeEnd = 282896, XrefRangeStart = 282893, XrefRangeEnd = 282895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_get_LayoutBottom_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000CA RID: 202 RVA: 0x0001FBDC File Offset: 0x0001DDDC
		public unsafe float LayoutWidth
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 282898, RefRangeEnd = 282901, XrefRangeStart = 282896, XrefRangeEnd = 282898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_get_LayoutWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000CB RID: 203 RVA: 0x0001FC18 File Offset: 0x0001DE18
		public unsafe float LayoutHeight
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 282903, RefRangeEnd = 282906, XrefRangeStart = 282901, XrefRangeEnd = 282903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_get_LayoutHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00021074 File Offset: 0x0001F274
		// (set) Token: 0x060000CC RID: 204 RVA: 0x0001FC54 File Offset: 0x0001DE54
		public unsafe YogaOverflow Overflow
		{
			get
			{
				return Native.YGNodeStyleGetOverflow(this._ygNode);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 282908, RefRangeEnd = 282911, XrefRangeStart = 282906, XrefRangeEnd = 282908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_Overflow_Public_set_Void_YogaOverflow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000CD RID: 205 RVA: 0x0001FC94 File Offset: 0x0001DE94
		public unsafe int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282911, XrefRangeEnd = 282912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0001FCD0 File Offset: 0x0001DED0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282914, RefRangeEnd = 282915, XrefRangeStart = 282912, XrefRangeEnd = 282914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkLayoutSeen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_MarkLayoutSeen_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0001FD04 File Offset: 0x0001DF04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282933, RefRangeEnd = 282934, XrefRangeStart = 282915, XrefRangeEnd = 282933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Insert(int index, YogaNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_Insert_Public_Void_Int32_YogaNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0001FD54 File Offset: 0x0001DF54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282944, RefRangeEnd = 282945, XrefRangeStart = 282934, XrefRangeEnd = 282944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0001FD94 File Offset: 0x0001DF94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282956, RefRangeEnd = 282957, XrefRangeStart = 282945, XrefRangeEnd = 282956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0001FDC8 File Offset: 0x0001DFC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 282962, RefRangeEnd = 282965, XrefRangeStart = 282957, XrefRangeEnd = 282962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMeasureFunction(MeasureFunction measureFunction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(measureFunction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_SetMeasureFunction_Public_Void_MeasureFunction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0001FE0C File Offset: 0x0001E00C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282969, RefRangeEnd = 282970, XrefRangeStart = 282965, XrefRangeEnd = 282969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateLayout(float width = float.NaN, float height = float.NaN)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_CalculateLayout_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0001FE58 File Offset: 0x0001E058
		[CallerCount(0)]
		public unsafe static YogaSize MeasureInternal(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref widthMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref heightMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_MeasureInternal_Public_Static_YogaSize_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0001FED4 File Offset: 0x0001E0D4
		[CallerCount(0)]
		public unsafe static float BaselineInternal(YogaNode node, float width, float height)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_BaselineInternal_Public_Static_Single_YogaNode_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0001FF34 File Offset: 0x0001E134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282970, XrefRangeEnd = 282977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<YogaNode> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_YogaNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<YogaNode>>(intPtr3) : null;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0001FF74 File Offset: 0x0001E174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282977, XrefRangeEnd = 282984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000106 RID: 262 RVA: 0x000208B0 File Offset: 0x0001EAB0
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x0001FFB4 File Offset: 0x0001E1B4
		public unsafe YogaValue Left
		{
			get
			{
				return YogaValue.MarshalValue(Native.YGNodeStyleGetPosition(this._ygNode, YogaEdge.Left));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 282986, RefRangeEnd = 282988, XrefRangeStart = 282984, XrefRangeEnd = 282986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_Left_Public_set_Void_YogaValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000107 RID: 263 RVA: 0x000208D4 File Offset: 0x0001EAD4
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x0001FFF4 File Offset: 0x0001E1F4
		public unsafe YogaValue Top
		{
			get
			{
				return YogaValue.MarshalValue(Native.YGNodeStyleGetPosition(this._ygNode, YogaEdge.Top));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 282993, RefRangeEnd = 282995, XrefRangeStart = 282988, XrefRangeEnd = 282993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_Top_Public_set_Void_YogaValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000108 RID: 264 RVA: 0x000208F8 File Offset: 0x0001EAF8
		// (set) Token: 0x060000DA RID: 218 RVA: 0x00020034 File Offset: 0x0001E234
		public unsafe YogaValue Right
		{
			get
			{
				return YogaValue.MarshalValue(Native.YGNodeStyleGetPosition(this._ygNode, YogaEdge.Right));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 283000, RefRangeEnd = 283002, XrefRangeStart = 282995, XrefRangeEnd = 283000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_Right_Public_set_Void_YogaValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000109 RID: 265 RVA: 0x0002091C File Offset: 0x0001EB1C
		// (set) Token: 0x060000DB RID: 219 RVA: 0x00020074 File Offset: 0x0001E274
		public unsafe YogaValue Bottom
		{
			get
			{
				return YogaValue.MarshalValue(Native.YGNodeStyleGetPosition(this._ygNode, YogaEdge.Bottom));
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 283007, RefRangeEnd = 283010, XrefRangeStart = 283002, XrefRangeEnd = 283007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_Bottom_Public_set_Void_YogaValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000200B4 File Offset: 0x0001E2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283010, XrefRangeEnd = 283015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStylePosition(YogaEdge edge, YogaValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref edge;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_SetStylePosition_Private_Void_YogaEdge_YogaValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00020988 File Offset: 0x0001EB88
		// (set) Token: 0x060000DD RID: 221 RVA: 0x00020100 File Offset: 0x0001E300
		public unsafe YogaValue MarginLeft
		{
			get
			{
				return YogaValue.MarshalValue(Native.YGNodeStyleGetMargin(this._ygNode, YogaEdge.Left));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 283016, RefRangeEnd = 283018, XrefRangeStart = 283015, XrefRangeEnd = 283016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_MarginLeft_Public_set_Void_YogaValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600010F RID: 271 RVA: 0x000209AC File Offset: 0x0001EBAC
		// (set) Token: 0x060000DE RID: 222 RVA: 0x00020140 File Offset: 0x0001E340
		public unsafe YogaValue MarginTop
		{
			get
			{
				return YogaValue.MarshalValue(Native.YGNodeStyleGetMargin(this._ygNode, YogaEdge.Top));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 283019, RefRangeEnd = 283021, XrefRangeStart = 283018, XrefRangeEnd = 283019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_MarginTop_Public_set_Void_YogaValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000110 RID: 272 RVA: 0x000209D0 File Offset: 0x0001EBD0
		// (set) Token: 0x060000DF RID: 223 RVA: 0x00020180 File Offset: 0x0001E380
		public unsafe YogaValue MarginRight
		{
			get
			{
				return YogaValue.MarshalValue(Native.YGNodeStyleGetMargin(this._ygNode, YogaEdge.Right));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 283022, RefRangeEnd = 283024, XrefRangeStart = 283021, XrefRangeEnd = 283022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_MarginRight_Public_set_Void_YogaValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000111 RID: 273 RVA: 0x000209F4 File Offset: 0x0001EBF4
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x000201C0 File Offset: 0x0001E3C0
		public unsafe YogaValue MarginBottom
		{
			get
			{
				return YogaValue.MarshalValue(Native.YGNodeStyleGetMargin(this._ygNode, YogaEdge.Bottom));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 283025, RefRangeEnd = 283027, XrefRangeStart = 283024, XrefRangeEnd = 283025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_MarginBottom_Public_set_Void_YogaValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00020200 File Offset: 0x0001E400
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 283034, RefRangeEnd = 283038, XrefRangeStart = 283027, XrefRangeEnd = 283034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStyleMargin(YogaEdge edge, YogaValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref edge;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_SetStyleMargin_Private_Void_YogaEdge_YogaValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00020ACC File Offset: 0x0001ECCC
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x0002024C File Offset: 0x0001E44C
		public unsafe YogaValue PaddingLeft
		{
			get
			{
				return YogaValue.MarshalValue(Native.YGNodeStyleGetPadding(this._ygNode, YogaEdge.Left));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 283040, RefRangeEnd = 283042, XrefRangeStart = 283038, XrefRangeEnd = 283040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_PaddingLeft_Public_set_Void_YogaValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00020AF0 File Offset: 0x0001ECF0
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x0002028C File Offset: 0x0001E48C
		public unsafe YogaValue PaddingTop
		{
			get
			{
				return YogaValue.MarshalValue(Native.YGNodeStyleGetPadding(this._ygNode, YogaEdge.Top));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 283047, RefRangeEnd = 283049, XrefRangeStart = 283042, XrefRangeEnd = 283047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_PaddingTop_Public_set_Void_YogaValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00020B14 File Offset: 0x0001ED14
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x000202CC File Offset: 0x0001E4CC
		public unsafe YogaValue PaddingRight
		{
			get
			{
				return YogaValue.MarshalValue(Native.YGNodeStyleGetPadding(this._ygNode, YogaEdge.Right));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 283054, RefRangeEnd = 283056, XrefRangeStart = 283049, XrefRangeEnd = 283054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_PaddingRight_Public_set_Void_YogaValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00020B38 File Offset: 0x0001ED38
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x0002030C File Offset: 0x0001E50C
		public unsafe YogaValue PaddingBottom
		{
			get
			{
				return YogaValue.MarshalValue(Native.YGNodeStyleGetPadding(this._ygNode, YogaEdge.Bottom));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 283061, RefRangeEnd = 283063, XrefRangeStart = 283056, XrefRangeEnd = 283061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_PaddingBottom_Public_set_Void_YogaValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0002034C File Offset: 0x0001E54C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283063, XrefRangeEnd = 283068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStylePadding(YogaEdge edge, YogaValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref edge;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_SetStylePadding_Private_Void_YogaEdge_YogaValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00020C10 File Offset: 0x0001EE10
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x00020398 File Offset: 0x0001E598
		public unsafe float BorderLeftWidth
		{
			get
			{
				return Native.YGNodeStyleGetBorder(this._ygNode, YogaEdge.Left);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 283070, RefRangeEnd = 283072, XrefRangeStart = 283068, XrefRangeEnd = 283070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_BorderLeftWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00020C30 File Offset: 0x0001EE30
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x000203D8 File Offset: 0x0001E5D8
		public unsafe float BorderTopWidth
		{
			get
			{
				return Native.YGNodeStyleGetBorder(this._ygNode, YogaEdge.Top);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 283074, RefRangeEnd = 283076, XrefRangeStart = 283072, XrefRangeEnd = 283074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_BorderTopWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00020C50 File Offset: 0x0001EE50
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x00020418 File Offset: 0x0001E618
		public unsafe float BorderRightWidth
		{
			get
			{
				return Native.YGNodeStyleGetBorder(this._ygNode, YogaEdge.Right);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 283078, RefRangeEnd = 283080, XrefRangeStart = 283076, XrefRangeEnd = 283078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_BorderRightWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00020C70 File Offset: 0x0001EE70
		// (set) Token: 0x060000EA RID: 234 RVA: 0x00020458 File Offset: 0x0001E658
		public unsafe float BorderBottomWidth
		{
			get
			{
				return Native.YGNodeStyleGetBorder(this._ygNode, YogaEdge.Bottom);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 283082, RefRangeEnd = 283085, XrefRangeStart = 283080, XrefRangeEnd = 283082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_set_BorderBottomWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00020498 File Offset: 0x0001E698
		public unsafe float LayoutMarginLeft
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 283087, RefRangeEnd = 283088, XrefRangeStart = 283085, XrefRangeEnd = 283087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_get_LayoutMarginLeft_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000EC RID: 236 RVA: 0x000204D4 File Offset: 0x0001E6D4
		public unsafe float LayoutMarginTop
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 283090, RefRangeEnd = 283091, XrefRangeStart = 283088, XrefRangeEnd = 283090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_get_LayoutMarginTop_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00020510 File Offset: 0x0001E710
		public unsafe float LayoutMarginRight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 283093, RefRangeEnd = 283094, XrefRangeStart = 283091, XrefRangeEnd = 283093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_get_LayoutMarginRight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000EE RID: 238 RVA: 0x0002054C File Offset: 0x0001E74C
		public unsafe float LayoutMarginBottom
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 283096, RefRangeEnd = 283097, XrefRangeStart = 283094, XrefRangeEnd = 283096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_get_LayoutMarginBottom_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00020588 File Offset: 0x0001E788
		public unsafe float LayoutPaddingLeft
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 283099, RefRangeEnd = 283102, XrefRangeStart = 283097, XrefRangeEnd = 283099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_get_LayoutPaddingLeft_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x000205C4 File Offset: 0x0001E7C4
		public unsafe float LayoutPaddingTop
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 283104, RefRangeEnd = 283105, XrefRangeStart = 283102, XrefRangeEnd = 283104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_get_LayoutPaddingTop_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00020600 File Offset: 0x0001E800
		public unsafe float LayoutPaddingRight
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 283107, RefRangeEnd = 283109, XrefRangeStart = 283105, XrefRangeEnd = 283107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_get_LayoutPaddingRight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x0002063C File Offset: 0x0001E83C
		public unsafe float LayoutPaddingBottom
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 283111, RefRangeEnd = 283113, XrefRangeStart = 283109, XrefRangeEnd = 283111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_get_LayoutPaddingBottom_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00020678 File Offset: 0x0001E878
		public unsafe float LayoutBorderLeft
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 283115, RefRangeEnd = 283116, XrefRangeStart = 283113, XrefRangeEnd = 283115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_get_LayoutBorderLeft_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x000206B4 File Offset: 0x0001E8B4
		public unsafe float LayoutBorderTop
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 283118, RefRangeEnd = 283119, XrefRangeStart = 283116, XrefRangeEnd = 283118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_get_LayoutBorderTop_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x000206F0 File Offset: 0x0001E8F0
		public unsafe float LayoutBorderRight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 283121, RefRangeEnd = 283122, XrefRangeStart = 283119, XrefRangeEnd = 283121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_get_LayoutBorderRight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x0002072C File Offset: 0x0001E92C
		public unsafe float LayoutBorderBottom
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 283124, RefRangeEnd = 283125, XrefRangeStart = 283122, XrefRangeEnd = 283124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaNode.NativeMethodInfoPtr_get_LayoutBorderBottom_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000023DE File Offset: 0x000005DE
		public YogaNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00020768 File Offset: 0x0001E968
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x000023E7 File Offset: 0x000005E7
		public unsafe IntPtr _ygNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__ygNode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__ygNode)) = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00020790 File Offset: 0x0001E990
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00002402 File Offset: 0x00000602
		public unsafe YogaConfig _config
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__config);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<YogaConfig>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__config), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000FC RID: 252 RVA: 0x000207C0 File Offset: 0x0001E9C0
		// (set) Token: 0x060000FD RID: 253 RVA: 0x00002421 File Offset: 0x00000621
		public unsafe WeakReference _parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeakReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000FE RID: 254 RVA: 0x000207F0 File Offset: 0x0001E9F0
		// (set) Token: 0x060000FF RID: 255 RVA: 0x00002440 File Offset: 0x00000640
		public unsafe List<YogaNode> _children
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__children);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<YogaNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__children), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00020820 File Offset: 0x0001EA20
		// (set) Token: 0x06000101 RID: 257 RVA: 0x0000245F File Offset: 0x0000065F
		public unsafe MeasureFunction _measureFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__measureFunction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeasureFunction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__measureFunction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00020850 File Offset: 0x0001EA50
		// (set) Token: 0x06000103 RID: 259 RVA: 0x0000247E File Offset: 0x0000067E
		public unsafe BaselineFunction _baselineFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__baselineFunction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaselineFunction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__baselineFunction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00020880 File Offset: 0x0001EA80
		// (set) Token: 0x06000105 RID: 261 RVA: 0x0000249D File Offset: 0x0000069D
		public unsafe Object _data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaNode.NativeFieldInfoPtr__data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00020940 File Offset: 0x0001EB40
		// (set) Token: 0x0600010B RID: 267 RVA: 0x000024BC File Offset: 0x000006BC
		public YogaValue Start
		{
			get
			{
				return YogaValue.MarshalValue(Native.YGNodeStyleGetPosition(this._ygNode, YogaEdge.Start));
			}
			set
			{
				this.SetStylePosition(YogaEdge.Start, value);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00020964 File Offset: 0x0001EB64
		// (set) Token: 0x0600010D RID: 269 RVA: 0x000024C8 File Offset: 0x000006C8
		public YogaValue End
		{
			get
			{
				return YogaValue.MarshalValue(Native.YGNodeStyleGetPosition(this._ygNode, YogaEdge.End));
			}
			set
			{
				this.SetStylePosition(YogaEdge.End, value);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00020A18 File Offset: 0x0001EC18
		// (set) Token: 0x06000113 RID: 275 RVA: 0x000024D4 File Offset: 0x000006D4
		public YogaValue MarginStart
		{
			get
			{
				return YogaValue.MarshalValue(Native.YGNodeStyleGetMargin(this._ygNode, YogaEdge.Start));
			}
			set
			{
				this.SetStyleMargin(YogaEdge.Start, value);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00020A3C File Offset: 0x0001EC3C
		// (set) Token: 0x06000115 RID: 277 RVA: 0x000024E0 File Offset: 0x000006E0
		public YogaValue MarginEnd
		{
			get
			{
				return YogaValue.MarshalValue(Native.YGNodeStyleGetMargin(this._ygNode, YogaEdge.End));
			}
			set
			{
				this.SetStyleMargin(YogaEdge.End, value);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00020A60 File Offset: 0x0001EC60
		// (set) Token: 0x06000117 RID: 279 RVA: 0x000024EC File Offset: 0x000006EC
		public YogaValue MarginHorizontal
		{
			get
			{
				return YogaValue.MarshalValue(Native.YGNodeStyleGetMargin(this._ygNode, YogaEdge.Horizontal));
			}
			set
			{
				this.SetStyleMargin(YogaEdge.Horizontal, value);
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00020A84 File Offset: 0x0001EC84
		// (set) Token: 0x06000119 RID: 281 RVA: 0x000024F8 File Offset: 0x000006F8
		public YogaValue MarginVertical
		{
			get
			{
				return YogaValue.MarshalValue(Native.YGNodeStyleGetMargin(this._ygNode, YogaEdge.Vertical));
			}
			set
			{
				this.SetStyleMargin(YogaEdge.Vertical, value);
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00020AA8 File Offset: 0x0001ECA8
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00002504 File Offset: 0x00000704
		public YogaValue Margin
		{
			get
			{
				return YogaValue.MarshalValue(Native.YGNodeStyleGetMargin(this._ygNode, YogaEdge.All));
			}
			set
			{
				this.SetStyleMargin(YogaEdge.All, value);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00020B5C File Offset: 0x0001ED5C
		// (set) Token: 0x06000121 RID: 289 RVA: 0x00002510 File Offset: 0x00000710
		public YogaValue PaddingStart
		{
			get
			{
				return YogaValue.MarshalValue(Native.YGNodeStyleGetPadding(this._ygNode, YogaEdge.Start));
			}
			set
			{
				this.SetStylePadding(YogaEdge.Start, value);
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00020B80 File Offset: 0x0001ED80
		// (set) Token: 0x06000123 RID: 291 RVA: 0x0000251C File Offset: 0x0000071C
		public YogaValue PaddingEnd
		{
			get
			{
				return YogaValue.MarshalValue(Native.YGNodeStyleGetPadding(this._ygNode, YogaEdge.End));
			}
			set
			{
				this.SetStylePadding(YogaEdge.End, value);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00020BA4 File Offset: 0x0001EDA4
		// (set) Token: 0x06000125 RID: 293 RVA: 0x00002528 File Offset: 0x00000728
		public YogaValue PaddingHorizontal
		{
			get
			{
				return YogaValue.MarshalValue(Native.YGNodeStyleGetPadding(this._ygNode, YogaEdge.Horizontal));
			}
			set
			{
				this.SetStylePadding(YogaEdge.Horizontal, value);
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00020BC8 File Offset: 0x0001EDC8
		// (set) Token: 0x06000127 RID: 295 RVA: 0x00002534 File Offset: 0x00000734
		public YogaValue PaddingVertical
		{
			get
			{
				return YogaValue.MarshalValue(Native.YGNodeStyleGetPadding(this._ygNode, YogaEdge.Vertical));
			}
			set
			{
				this.SetStylePadding(YogaEdge.Vertical, value);
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00020BEC File Offset: 0x0001EDEC
		// (set) Token: 0x06000129 RID: 297 RVA: 0x00002540 File Offset: 0x00000740
		public YogaValue Padding
		{
			get
			{
				return YogaValue.MarshalValue(Native.YGNodeStyleGetPadding(this._ygNode, YogaEdge.All));
			}
			set
			{
				this.SetStylePadding(YogaEdge.All, value);
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00020C90 File Offset: 0x0001EE90
		// (set) Token: 0x0600012F RID: 303 RVA: 0x0000254C File Offset: 0x0000074C
		public float BorderStartWidth
		{
			get
			{
				return Native.YGNodeStyleGetBorder(this._ygNode, YogaEdge.Start);
			}
			set
			{
				Native.YGNodeStyleSetBorder(this._ygNode, YogaEdge.Start, value);
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00020CB0 File Offset: 0x0001EEB0
		// (set) Token: 0x06000131 RID: 305 RVA: 0x0000255D File Offset: 0x0000075D
		public float BorderEndWidth
		{
			get
			{
				return Native.YGNodeStyleGetBorder(this._ygNode, YogaEdge.End);
			}
			set
			{
				Native.YGNodeStyleSetBorder(this._ygNode, YogaEdge.End, value);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00020CD0 File Offset: 0x0001EED0
		// (set) Token: 0x06000133 RID: 307 RVA: 0x0000256E File Offset: 0x0000076E
		public float BorderWidth
		{
			get
			{
				return Native.YGNodeStyleGetBorder(this._ygNode, YogaEdge.All);
			}
			set
			{
				Native.YGNodeStyleSetBorder(this._ygNode, YogaEdge.All, value);
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00020CF0 File Offset: 0x0001EEF0
		public float LayoutMarginStart
		{
			get
			{
				return Native.YGNodeLayoutGetMargin(this._ygNode, YogaEdge.Start);
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00020D10 File Offset: 0x0001EF10
		public float LayoutMarginEnd
		{
			get
			{
				return Native.YGNodeLayoutGetMargin(this._ygNode, YogaEdge.End);
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00020D30 File Offset: 0x0001EF30
		public float LayoutPaddingStart
		{
			get
			{
				return Native.YGNodeLayoutGetPadding(this._ygNode, YogaEdge.Start);
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00020D50 File Offset: 0x0001EF50
		public float LayoutPaddingEnd
		{
			get
			{
				return Native.YGNodeLayoutGetPadding(this._ygNode, YogaEdge.End);
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00020D70 File Offset: 0x0001EF70
		public float ComputedFlexBasis
		{
			get
			{
				return Native.YGNodeGetComputedFlexBasis(this._ygNode);
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000257F File Offset: 0x0000077F
		public void Reset()
		{
			this._measureFunction = null;
			this._baselineFunction = null;
			this._data = null;
			Native.YGSetManagedObject(this._ygNode, null);
			Native.YGNodeReset(this._ygNode);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x000025B0 File Offset: 0x000007B0
		public void MarkHasNewLayout()
		{
			Native.YGNodeSetHasNewLayout(this._ygNode, true);
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00020DA8 File Offset: 0x0001EFA8
		public YogaNode Parent
		{
			get
			{
				return (this._parent != null) ? this._parent.Target.TryCast<YogaNode>() : null;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00020DD8 File Offset: 0x0001EFD8
		// (set) Token: 0x0600013E RID: 318 RVA: 0x000025C0 File Offset: 0x000007C0
		public YogaDirection StyleDirection
		{
			get
			{
				return Native.YGNodeStyleGetDirection(this._ygNode);
			}
			set
			{
				Native.YGNodeStyleSetDirection(this._ygNode, value);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00021034 File Offset: 0x0001F234
		// (set) Token: 0x06000151 RID: 337 RVA: 0x000025D0 File Offset: 0x000007D0
		public float AspectRatio
		{
			get
			{
				return Native.YGNodeStyleGetAspectRatio(this._ygNode);
			}
			set
			{
				Native.YGNodeStyleSetAspectRatio(this._ygNode, value);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00021054 File Offset: 0x0001F254
		public YogaDirection LayoutDirection
		{
			get
			{
				return Native.YGNodeLayoutGetDirection(this._ygNode);
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00021094 File Offset: 0x0001F294
		// (set) Token: 0x06000155 RID: 341 RVA: 0x000025E0 File Offset: 0x000007E0
		public Object Data
		{
			get
			{
				return this._data;
			}
			set
			{
				this._data = value;
			}
		}

		// Token: 0x17000063 RID: 99
		public YogaNode this[int index]
		{
			get
			{
				return this._children[index];
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000210CC File Offset: 0x0001F2CC
		public bool ValuesEqual(float f1, float f2)
		{
			bool flag = Single.IsNaN(f1) || Single.IsNaN(f2);
			bool flag2;
			if (flag)
			{
				flag2 = Single.IsNaN(f1) && Single.IsNaN(f2);
			}
			else
			{
				flag2 = Math.Abs(f2 - f1) < float.Epsilon;
			}
			return flag2;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000025EA File Offset: 0x000007EA
		public void AddChild(YogaNode child)
		{
			this.Insert(this.Count, child);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00021118 File Offset: 0x0001F318
		public void RemoveChild(YogaNode child)
		{
			int num = this.IndexOf(child);
			bool flag = num >= 0;
			if (flag)
			{
				this.RemoveAt(num);
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00021144 File Offset: 0x0001F344
		public int IndexOf(YogaNode node)
		{
			return (this._children != null) ? this._children.IndexOf(node) : (-1);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00021170 File Offset: 0x0001F370
		public void SetBaselineFunction(BaselineFunction baselineFunction)
		{
			this._baselineFunction = baselineFunction;
			bool flag = baselineFunction == null;
			if (flag)
			{
				bool flag2 = !this.IsMeasureDefined;
				if (flag2)
				{
					Native.YGSetManagedObject(this._ygNode, null);
				}
				Native.YGNodeRemoveBaselineFunc(this._ygNode);
			}
			else
			{
				Native.YGSetManagedObject(this._ygNode, this);
				Native.YGNodeSetBaselineFunc(this._ygNode);
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000025FB File Offset: 0x000007FB
		public string Print([Optional] YogaPrintOptions options)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600015D RID: 349 RVA: 0x000211D4 File Offset: 0x0001F3D4
		public static int GetInstanceCount()
		{
			return Native.YGNodeGetInstanceCount();
		}

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeFieldInfoPtr__ygNode;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeFieldInfoPtr__config;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeFieldInfoPtr__parent;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeFieldInfoPtr__children;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeFieldInfoPtr__measureFunction;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeFieldInfoPtr__baselineFunction;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeFieldInfoPtr__data;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_YogaConfig_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_set_Config_Internal_set_Void_YogaConfig_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDirty_Public_get_Boolean_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_MarkDirty_Public_Virtual_New_Void_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_get_HasNewLayout_Public_get_Boolean_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMeasureDefined_Public_get_Boolean_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBaselineDefined_Public_get_Boolean_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_CopyStyle_Public_Void_YogaNode_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_set_FlexDirection_Public_set_Void_YogaFlexDirection_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_set_JustifyContent_Public_set_Void_YogaJustify_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_set_Display_Public_set_Void_YogaDisplay_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_set_AlignItems_Public_set_Void_YogaAlign_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_set_AlignSelf_Public_set_Void_YogaAlign_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_set_AlignContent_Public_set_Void_YogaAlign_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_set_PositionType_Public_set_Void_YogaPositionType_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_set_Wrap_Public_set_Void_YogaWrap_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_set_Flex_Public_set_Void_Single_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_set_FlexGrow_Public_set_Void_Single_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_set_FlexShrink_Public_set_Void_Single_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr_set_FlexBasis_Public_set_Void_YogaValue_0;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr_set_Width_Public_set_Void_YogaValue_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_set_Height_Public_set_Void_YogaValue_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxWidth_Public_set_Void_YogaValue_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxHeight_Public_set_Void_YogaValue_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_set_MinWidth_Public_set_Void_YogaValue_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_set_MinHeight_Public_set_Void_YogaValue_0;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr_get_LayoutX_Public_get_Single_0;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr_get_LayoutY_Public_get_Single_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_get_LayoutRight_Public_get_Single_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_get_LayoutBottom_Public_get_Single_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_get_LayoutWidth_Public_get_Single_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_get_LayoutHeight_Public_get_Single_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_set_Overflow_Public_set_Void_YogaOverflow_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_MarkLayoutSeen_Public_Void_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Void_Int32_YogaNode_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_SetMeasureFunction_Public_Void_MeasureFunction_0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayout_Public_Void_Single_Single_0;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr_MeasureInternal_Public_Static_YogaSize_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_BaselineInternal_Public_Static_Single_YogaNode_Single_Single_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_YogaNode_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_set_Left_Public_set_Void_YogaValue_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_set_Top_Public_set_Void_YogaValue_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_set_Right_Public_set_Void_YogaValue_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_set_Bottom_Public_set_Void_YogaValue_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_SetStylePosition_Private_Void_YogaEdge_YogaValue_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_set_MarginLeft_Public_set_Void_YogaValue_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_set_MarginTop_Public_set_Void_YogaValue_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_set_MarginRight_Public_set_Void_YogaValue_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr_set_MarginBottom_Public_set_Void_YogaValue_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_SetStyleMargin_Private_Void_YogaEdge_YogaValue_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_set_PaddingLeft_Public_set_Void_YogaValue_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_set_PaddingTop_Public_set_Void_YogaValue_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_set_PaddingRight_Public_set_Void_YogaValue_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_set_PaddingBottom_Public_set_Void_YogaValue_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_SetStylePadding_Private_Void_YogaEdge_YogaValue_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_set_BorderLeftWidth_Public_set_Void_Single_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_set_BorderTopWidth_Public_set_Void_Single_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_set_BorderRightWidth_Public_set_Void_Single_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr_set_BorderBottomWidth_Public_set_Void_Single_0;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_get_LayoutMarginLeft_Public_get_Single_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_get_LayoutMarginTop_Public_get_Single_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_get_LayoutMarginRight_Public_get_Single_0;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_get_LayoutMarginBottom_Public_get_Single_0;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_get_LayoutPaddingLeft_Public_get_Single_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_get_LayoutPaddingTop_Public_get_Single_0;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr_get_LayoutPaddingRight_Public_get_Single_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr_get_LayoutPaddingBottom_Public_get_Single_0;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_get_LayoutBorderLeft_Public_get_Single_0;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr_get_LayoutBorderTop_Public_get_Single_0;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_get_LayoutBorderRight_Public_get_Single_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_get_LayoutBorderBottom_Public_get_Single_0;

		// Token: 0x02000320 RID: 800
		public sealed class <>c__DisplayClass253_0
		{
		}
	}
}
