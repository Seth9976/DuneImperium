using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Yoga
{
	// Token: 0x02000010 RID: 16
	public static class Native : Object
	{
		// Token: 0x06000032 RID: 50 RVA: 0x0001D264 File Offset: 0x0001B464
		// Note: this type is marked as 'beforefieldinit'.
		static Native()
		{
			Il2CppClassPointerStore<Native>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.Yoga", "Native");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Native>.NativeClassPtr);
			Native.NativeMethodInfoPtr_YGNodeNewWithConfig_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663313);
			Native.NativeMethodInfoPtr_YGNodeFree_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663314);
			Native.NativeMethodInfoPtr_YGNodeFreeInternal_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663315);
			Native.NativeMethodInfoPtr_YGSetManagedObject_Public_Static_Void_IntPtr_YogaNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663316);
			Native.NativeMethodInfoPtr_YGNodeSetConfig_Public_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663317);
			Native.NativeMethodInfoPtr_YGConfigGetDefault_Public_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663318);
			Native.NativeMethodInfoPtr_YGConfigNew_Public_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663319);
			Native.NativeMethodInfoPtr_YGConfigFree_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663320);
			Native.NativeMethodInfoPtr_YGConfigFreeInternal_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663321);
			Native.NativeMethodInfoPtr_YGConfigSetUseWebDefaults_Public_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663322);
			Native.NativeMethodInfoPtr_YGConfigGetUseWebDefaults_Public_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663323);
			Native.NativeMethodInfoPtr_YGConfigSetPointScaleFactor_Public_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663324);
			Native.NativeMethodInfoPtr_YGNodeInsertChild_Public_Static_Void_IntPtr_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663325);
			Native.NativeMethodInfoPtr_YGNodeRemoveChild_Public_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663326);
			Native.NativeMethodInfoPtr_YGNodeCalculateLayout_Public_Static_Void_IntPtr_Single_Single_YogaDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663327);
			Native.NativeMethodInfoPtr_YGNodeMarkDirty_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663328);
			Native.NativeMethodInfoPtr_YGNodeIsDirty_Public_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663329);
			Native.NativeMethodInfoPtr_YGNodeCopyStyle_Public_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663330);
			Native.NativeMethodInfoPtr_YGNodeSetMeasureFunc_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663331);
			Native.NativeMethodInfoPtr_YGNodeRemoveMeasureFunc_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663332);
			Native.NativeMethodInfoPtr_YGNodeMeasureInvoke_Public_Static_Void_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663333);
			Native.NativeMethodInfoPtr_YGNodeBaselineInvoke_Public_Static_Void_YogaNode_Single_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663334);
			Native.NativeMethodInfoPtr_YGNodeSetHasNewLayout_Public_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663335);
			Native.NativeMethodInfoPtr_YGNodeGetHasNewLayout_Public_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663336);
			Native.NativeMethodInfoPtr_YGNodeStyleGetDirection_Public_Static_YogaDirection_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663337);
			Native.NativeMethodInfoPtr_YGNodeStyleSetFlexDirection_Public_Static_Void_IntPtr_YogaFlexDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663338);
			Native.NativeMethodInfoPtr_YGNodeStyleSetJustifyContent_Public_Static_Void_IntPtr_YogaJustify_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663339);
			Native.NativeMethodInfoPtr_YGNodeStyleSetAlignContent_Public_Static_Void_IntPtr_YogaAlign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663340);
			Native.NativeMethodInfoPtr_YGNodeStyleSetAlignItems_Public_Static_Void_IntPtr_YogaAlign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663341);
			Native.NativeMethodInfoPtr_YGNodeStyleSetAlignSelf_Public_Static_Void_IntPtr_YogaAlign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663342);
			Native.NativeMethodInfoPtr_YGNodeStyleSetPositionType_Public_Static_Void_IntPtr_YogaPositionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663343);
			Native.NativeMethodInfoPtr_YGNodeStyleSetFlexWrap_Public_Static_Void_IntPtr_YogaWrap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663344);
			Native.NativeMethodInfoPtr_YGNodeStyleSetOverflow_Public_Static_Void_IntPtr_YogaOverflow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663345);
			Native.NativeMethodInfoPtr_YGNodeStyleSetDisplay_Public_Static_Void_IntPtr_YogaDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663346);
			Native.NativeMethodInfoPtr_YGNodeStyleSetFlex_Public_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663347);
			Native.NativeMethodInfoPtr_YGNodeStyleSetFlexGrow_Public_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663348);
			Native.NativeMethodInfoPtr_YGNodeStyleSetFlexShrink_Public_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663349);
			Native.NativeMethodInfoPtr_YGNodeStyleSetFlexBasis_Public_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663350);
			Native.NativeMethodInfoPtr_YGNodeStyleSetFlexBasisPercent_Public_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663351);
			Native.NativeMethodInfoPtr_YGNodeStyleSetFlexBasisAuto_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663352);
			Native.NativeMethodInfoPtr_YGNodeStyleSetWidth_Public_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663353);
			Native.NativeMethodInfoPtr_YGNodeStyleSetWidthPercent_Public_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663354);
			Native.NativeMethodInfoPtr_YGNodeStyleSetWidthAuto_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663355);
			Native.NativeMethodInfoPtr_YGNodeStyleSetHeight_Public_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663356);
			Native.NativeMethodInfoPtr_YGNodeStyleSetHeightPercent_Public_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663357);
			Native.NativeMethodInfoPtr_YGNodeStyleSetHeightAuto_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663358);
			Native.NativeMethodInfoPtr_YGNodeStyleSetMinWidth_Public_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663359);
			Native.NativeMethodInfoPtr_YGNodeStyleSetMinWidthPercent_Public_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663360);
			Native.NativeMethodInfoPtr_YGNodeStyleSetMinHeight_Public_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663361);
			Native.NativeMethodInfoPtr_YGNodeStyleSetMinHeightPercent_Public_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663362);
			Native.NativeMethodInfoPtr_YGNodeStyleSetMaxWidth_Public_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663363);
			Native.NativeMethodInfoPtr_YGNodeStyleSetMaxWidthPercent_Public_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663364);
			Native.NativeMethodInfoPtr_YGNodeStyleSetMaxHeight_Public_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663365);
			Native.NativeMethodInfoPtr_YGNodeStyleSetMaxHeightPercent_Public_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663366);
			Native.NativeMethodInfoPtr_YGNodeStyleSetPosition_Public_Static_Void_IntPtr_YogaEdge_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663367);
			Native.NativeMethodInfoPtr_YGNodeStyleSetPositionPercent_Public_Static_Void_IntPtr_YogaEdge_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663368);
			Native.NativeMethodInfoPtr_YGNodeStyleSetMargin_Public_Static_Void_IntPtr_YogaEdge_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663369);
			Native.NativeMethodInfoPtr_YGNodeStyleSetMarginPercent_Public_Static_Void_IntPtr_YogaEdge_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663370);
			Native.NativeMethodInfoPtr_YGNodeStyleSetMarginAuto_Public_Static_Void_IntPtr_YogaEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663371);
			Native.NativeMethodInfoPtr_YGNodeStyleSetPadding_Public_Static_Void_IntPtr_YogaEdge_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663372);
			Native.NativeMethodInfoPtr_YGNodeStyleSetPaddingPercent_Public_Static_Void_IntPtr_YogaEdge_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663373);
			Native.NativeMethodInfoPtr_YGNodeStyleSetBorder_Public_Static_Void_IntPtr_YogaEdge_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663374);
			Native.NativeMethodInfoPtr_YGNodeLayoutGetLeft_Public_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663375);
			Native.NativeMethodInfoPtr_YGNodeLayoutGetTop_Public_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663376);
			Native.NativeMethodInfoPtr_YGNodeLayoutGetRight_Public_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663377);
			Native.NativeMethodInfoPtr_YGNodeLayoutGetBottom_Public_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663378);
			Native.NativeMethodInfoPtr_YGNodeLayoutGetWidth_Public_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663379);
			Native.NativeMethodInfoPtr_YGNodeLayoutGetHeight_Public_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663380);
			Native.NativeMethodInfoPtr_YGNodeLayoutGetMargin_Public_Static_Single_IntPtr_YogaEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663381);
			Native.NativeMethodInfoPtr_YGNodeLayoutGetPadding_Public_Static_Single_IntPtr_YogaEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663382);
			Native.NativeMethodInfoPtr_YGNodeLayoutGetBorder_Public_Static_Single_IntPtr_YogaEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Native>.NativeClassPtr, 100663383);
			Native.YGNodeNewDelegateField = IL2CPP.ResolveICall<Native.YGNodeNewDelegate>("UnityEngine.Yoga.Native::YGNodeNew");
			Native.YGNodeResetDelegateField = IL2CPP.ResolveICall<Native.YGNodeResetDelegate>("UnityEngine.Yoga.Native::YGNodeReset");
			Native.YGNodeGetInstanceCountDelegateField = IL2CPP.ResolveICall<Native.YGNodeGetInstanceCountDelegate>("UnityEngine.Yoga.Native::YGNodeGetInstanceCount");
			Native.YGConfigGetInstanceCountDelegateField = IL2CPP.ResolveICall<Native.YGConfigGetInstanceCountDelegate>("UnityEngine.Yoga.Native::YGConfigGetInstanceCount");
			Native.YGConfigSetExperimentalFeatureEnabledDelegateField = IL2CPP.ResolveICall<Native.YGConfigSetExperimentalFeatureEnabledDelegate>("UnityEngine.Yoga.Native::YGConfigSetExperimentalFeatureEnabled");
			Native.YGConfigIsExperimentalFeatureEnabledDelegateField = IL2CPP.ResolveICall<Native.YGConfigIsExperimentalFeatureEnabledDelegate>("UnityEngine.Yoga.Native::YGConfigIsExperimentalFeatureEnabled");
			Native.YGConfigGetPointScaleFactorDelegateField = IL2CPP.ResolveICall<Native.YGConfigGetPointScaleFactorDelegate>("UnityEngine.Yoga.Native::YGConfigGetPointScaleFactor");
			Native.YGNodePrintDelegateField = IL2CPP.ResolveICall<Native.YGNodePrintDelegate>("UnityEngine.Yoga.Native::YGNodePrint");
			Native.YGNodeSetBaselineFuncDelegateField = IL2CPP.ResolveICall<Native.YGNodeSetBaselineFuncDelegate>("UnityEngine.Yoga.Native::YGNodeSetBaselineFunc");
			Native.YGNodeRemoveBaselineFuncDelegateField = IL2CPP.ResolveICall<Native.YGNodeRemoveBaselineFuncDelegate>("UnityEngine.Yoga.Native::YGNodeRemoveBaselineFunc");
			Native.YGNodeStyleSetDirectionDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetDirectionDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetDirection");
			Native.YGNodeStyleGetFlexDirectionDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetFlexDirectionDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetFlexDirection");
			Native.YGNodeStyleGetJustifyContentDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetJustifyContentDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetJustifyContent");
			Native.YGNodeStyleGetAlignContentDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetAlignContentDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetAlignContent");
			Native.YGNodeStyleGetAlignItemsDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetAlignItemsDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetAlignItems");
			Native.YGNodeStyleGetAlignSelfDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetAlignSelfDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetAlignSelf");
			Native.YGNodeStyleGetPositionTypeDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetPositionTypeDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetPositionType");
			Native.YGNodeStyleGetFlexWrapDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetFlexWrapDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetFlexWrap");
			Native.YGNodeStyleGetOverflowDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetOverflowDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetOverflow");
			Native.YGNodeStyleGetDisplayDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetDisplayDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetDisplay");
			Native.YGNodeStyleGetFlexGrowDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetFlexGrowDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetFlexGrow");
			Native.YGNodeStyleGetFlexShrinkDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetFlexShrinkDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetFlexShrink");
			Native.YGNodeGetComputedFlexBasisDelegateField = IL2CPP.ResolveICall<Native.YGNodeGetComputedFlexBasisDelegate>("UnityEngine.Yoga.Native::YGNodeGetComputedFlexBasis");
			Native.YGNodeStyleSetAspectRatioDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleSetAspectRatioDelegate>("UnityEngine.Yoga.Native::YGNodeStyleSetAspectRatio");
			Native.YGNodeStyleGetAspectRatioDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetAspectRatioDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetAspectRatio");
			Native.YGNodeStyleGetBorderDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetBorderDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetBorder");
			Native.YGNodeLayoutGetDirectionDelegateField = IL2CPP.ResolveICall<Native.YGNodeLayoutGetDirectionDelegate>("UnityEngine.Yoga.Native::YGNodeLayoutGetDirection");
			Native.YGNodeStyleGetFlexBasis_InjectedDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetFlexBasis_InjectedDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetFlexBasis_Injected");
			Native.YGNodeStyleGetWidth_InjectedDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetWidth_InjectedDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetWidth_Injected");
			Native.YGNodeStyleGetHeight_InjectedDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetHeight_InjectedDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetHeight_Injected");
			Native.YGNodeStyleGetMinWidth_InjectedDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetMinWidth_InjectedDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetMinWidth_Injected");
			Native.YGNodeStyleGetMinHeight_InjectedDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetMinHeight_InjectedDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetMinHeight_Injected");
			Native.YGNodeStyleGetMaxWidth_InjectedDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetMaxWidth_InjectedDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetMaxWidth_Injected");
			Native.YGNodeStyleGetMaxHeight_InjectedDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetMaxHeight_InjectedDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetMaxHeight_Injected");
			Native.YGNodeStyleGetPosition_InjectedDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetPosition_InjectedDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetPosition_Injected");
			Native.YGNodeStyleGetMargin_InjectedDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetMargin_InjectedDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetMargin_Injected");
			Native.YGNodeStyleGetPadding_InjectedDelegateField = IL2CPP.ResolveICall<Native.YGNodeStyleGetPadding_InjectedDelegate>("UnityEngine.Yoga.Native::YGNodeStyleGetPadding_Injected");
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0001DA4C File Offset: 0x0001BC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282609, XrefRangeEnd = 282611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr YGNodeNewWithConfig(IntPtr config)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref config;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeNewWithConfig_Public_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0001DA8C File Offset: 0x0001BC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282611, XrefRangeEnd = 282614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeFree(IntPtr ygNode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ygNode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeFree_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0001DAC0 File Offset: 0x0001BCC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282614, XrefRangeEnd = 282616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeFreeInternal(IntPtr ygNode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ygNode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeFreeInternal_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0001DAF4 File Offset: 0x0001BCF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282616, XrefRangeEnd = 282618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGSetManagedObject(IntPtr ygNode, YogaNode node)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ygNode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGSetManagedObject_Public_Static_Void_IntPtr_YogaNode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0001DB38 File Offset: 0x0001BD38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282618, XrefRangeEnd = 282620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeSetConfig(IntPtr ygNode, IntPtr config)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ygNode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref config;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeSetConfig_Public_Static_Void_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0001DB78 File Offset: 0x0001BD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282620, XrefRangeEnd = 282622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr YGConfigGetDefault()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGConfigGetDefault_Public_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0001DBA8 File Offset: 0x0001BDA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282622, XrefRangeEnd = 282624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr YGConfigNew()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGConfigNew_Public_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0001DBD8 File Offset: 0x0001BDD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282624, XrefRangeEnd = 282627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGConfigFree(IntPtr config)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref config;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGConfigFree_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0001DC0C File Offset: 0x0001BE0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282627, XrefRangeEnd = 282629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGConfigFreeInternal(IntPtr config)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref config;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGConfigFreeInternal_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0001DC40 File Offset: 0x0001BE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282629, XrefRangeEnd = 282631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGConfigSetUseWebDefaults(IntPtr config, bool useWebDefaults)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref config;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useWebDefaults;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGConfigSetUseWebDefaults_Public_Static_Void_IntPtr_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0001DC80 File Offset: 0x0001BE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282631, XrefRangeEnd = 282633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool YGConfigGetUseWebDefaults(IntPtr config)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref config;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGConfigGetUseWebDefaults_Public_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0001DCC0 File Offset: 0x0001BEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282633, XrefRangeEnd = 282635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGConfigSetPointScaleFactor(IntPtr config, float pixelsInPoint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref config;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsInPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGConfigSetPointScaleFactor_Public_Static_Void_IntPtr_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0001DD00 File Offset: 0x0001BF00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282635, XrefRangeEnd = 282637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeInsertChild(IntPtr node, IntPtr child, uint index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref child;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeInsertChild_Public_Static_Void_IntPtr_IntPtr_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0001DD50 File Offset: 0x0001BF50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282637, XrefRangeEnd = 282639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeRemoveChild(IntPtr node, IntPtr child)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref child;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeRemoveChild_Public_Static_Void_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0001DD90 File Offset: 0x0001BF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282639, XrefRangeEnd = 282641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeCalculateLayout(IntPtr node, float availableWidth, float availableHeight, YogaDirection parentDirection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref availableWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref availableHeight;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parentDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeCalculateLayout_Public_Static_Void_IntPtr_Single_Single_YogaDirection_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0001DDEC File Offset: 0x0001BFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282641, XrefRangeEnd = 282643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeMarkDirty(IntPtr node)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeMarkDirty_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0001DE20 File Offset: 0x0001C020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282643, XrefRangeEnd = 282645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool YGNodeIsDirty(IntPtr node)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeIsDirty_Public_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0001DE60 File Offset: 0x0001C060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282645, XrefRangeEnd = 282647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeCopyStyle(IntPtr dstNode, IntPtr srcNode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dstNode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcNode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeCopyStyle_Public_Static_Void_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0001DEA0 File Offset: 0x0001C0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282647, XrefRangeEnd = 282649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeSetMeasureFunc(IntPtr node)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeSetMeasureFunc_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0001DED4 File Offset: 0x0001C0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282649, XrefRangeEnd = 282651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeRemoveMeasureFunc(IntPtr node)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeRemoveMeasureFunc_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0001DF08 File Offset: 0x0001C108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282651, XrefRangeEnd = 282652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeMeasureInvoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode, IntPtr returnValueAddress)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref widthMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref heightMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnValueAddress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeMeasureInvoke_Public_Static_Void_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0001DF84 File Offset: 0x0001C184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282652, XrefRangeEnd = 282653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeBaselineInvoke(YogaNode node, float width, float height, IntPtr returnValueAddress)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnValueAddress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeBaselineInvoke_Public_Static_Void_YogaNode_Single_Single_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0001DFE4 File Offset: 0x0001C1E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282653, XrefRangeEnd = 282655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeSetHasNewLayout(IntPtr node, bool hasNewLayout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasNewLayout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeSetHasNewLayout_Public_Static_Void_IntPtr_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0001E024 File Offset: 0x0001C224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282655, XrefRangeEnd = 282657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool YGNodeGetHasNewLayout(IntPtr node)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeGetHasNewLayout_Public_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0001E064 File Offset: 0x0001C264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282657, XrefRangeEnd = 282659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static YogaDirection YGNodeStyleGetDirection(IntPtr node)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleGetDirection_Public_Static_YogaDirection_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0001E0A4 File Offset: 0x0001C2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282659, XrefRangeEnd = 282661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetFlexDirection(IntPtr node, YogaFlexDirection flexDirection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flexDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetFlexDirection_Public_Static_Void_IntPtr_YogaFlexDirection_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0001E0E4 File Offset: 0x0001C2E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282661, XrefRangeEnd = 282663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetJustifyContent(IntPtr node, YogaJustify justifyContent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref justifyContent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetJustifyContent_Public_Static_Void_IntPtr_YogaJustify_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0001E124 File Offset: 0x0001C324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282663, XrefRangeEnd = 282665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetAlignContent(IntPtr node, YogaAlign alignContent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignContent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetAlignContent_Public_Static_Void_IntPtr_YogaAlign_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0001E164 File Offset: 0x0001C364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282665, XrefRangeEnd = 282667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetAlignItems(IntPtr node, YogaAlign alignItems)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignItems;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetAlignItems_Public_Static_Void_IntPtr_YogaAlign_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0001E1A4 File Offset: 0x0001C3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282667, XrefRangeEnd = 282669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetAlignSelf(IntPtr node, YogaAlign alignSelf)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignSelf;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetAlignSelf_Public_Static_Void_IntPtr_YogaAlign_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0001E1E4 File Offset: 0x0001C3E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282669, XrefRangeEnd = 282671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetPositionType(IntPtr node, YogaPositionType positionType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref positionType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetPositionType_Public_Static_Void_IntPtr_YogaPositionType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0001E224 File Offset: 0x0001C424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282671, XrefRangeEnd = 282673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetFlexWrap(IntPtr node, YogaWrap flexWrap)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flexWrap;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetFlexWrap_Public_Static_Void_IntPtr_YogaWrap_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0001E264 File Offset: 0x0001C464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282673, XrefRangeEnd = 282675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetOverflow(IntPtr node, YogaOverflow flexWrap)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flexWrap;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetOverflow_Public_Static_Void_IntPtr_YogaOverflow_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0001E2A4 File Offset: 0x0001C4A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282675, XrefRangeEnd = 282677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetDisplay(IntPtr node, YogaDisplay display)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref display;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetDisplay_Public_Static_Void_IntPtr_YogaDisplay_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0001E2E4 File Offset: 0x0001C4E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282677, XrefRangeEnd = 282679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetFlex(IntPtr node, float flex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetFlex_Public_Static_Void_IntPtr_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0001E324 File Offset: 0x0001C524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282679, XrefRangeEnd = 282681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetFlexGrow(IntPtr node, float flexGrow)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flexGrow;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetFlexGrow_Public_Static_Void_IntPtr_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0001E364 File Offset: 0x0001C564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282681, XrefRangeEnd = 282683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetFlexShrink(IntPtr node, float flexShrink)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flexShrink;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetFlexShrink_Public_Static_Void_IntPtr_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0001E3A4 File Offset: 0x0001C5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282683, XrefRangeEnd = 282685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetFlexBasis(IntPtr node, float flexBasis)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flexBasis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetFlexBasis_Public_Static_Void_IntPtr_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0001E3E4 File Offset: 0x0001C5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282685, XrefRangeEnd = 282687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetFlexBasisPercent(IntPtr node, float flexBasis)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flexBasis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetFlexBasisPercent_Public_Static_Void_IntPtr_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0001E424 File Offset: 0x0001C624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282687, XrefRangeEnd = 282689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetFlexBasisAuto(IntPtr node)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetFlexBasisAuto_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0001E458 File Offset: 0x0001C658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282689, XrefRangeEnd = 282691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetWidth(IntPtr node, float width)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetWidth_Public_Static_Void_IntPtr_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0001E498 File Offset: 0x0001C698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282691, XrefRangeEnd = 282693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetWidthPercent(IntPtr node, float width)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetWidthPercent_Public_Static_Void_IntPtr_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0001E4D8 File Offset: 0x0001C6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282693, XrefRangeEnd = 282695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetWidthAuto(IntPtr node)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetWidthAuto_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0001E50C File Offset: 0x0001C70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282695, XrefRangeEnd = 282697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetHeight(IntPtr node, float height)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetHeight_Public_Static_Void_IntPtr_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0001E54C File Offset: 0x0001C74C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282697, XrefRangeEnd = 282699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetHeightPercent(IntPtr node, float height)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetHeightPercent_Public_Static_Void_IntPtr_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0001E58C File Offset: 0x0001C78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282699, XrefRangeEnd = 282701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetHeightAuto(IntPtr node)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetHeightAuto_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0001E5C0 File Offset: 0x0001C7C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282701, XrefRangeEnd = 282703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetMinWidth(IntPtr node, float minWidth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minWidth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetMinWidth_Public_Static_Void_IntPtr_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0001E600 File Offset: 0x0001C800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282703, XrefRangeEnd = 282705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetMinWidthPercent(IntPtr node, float minWidth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minWidth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetMinWidthPercent_Public_Static_Void_IntPtr_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0001E640 File Offset: 0x0001C840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282705, XrefRangeEnd = 282707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetMinHeight(IntPtr node, float minHeight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetMinHeight_Public_Static_Void_IntPtr_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0001E680 File Offset: 0x0001C880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282707, XrefRangeEnd = 282709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetMinHeightPercent(IntPtr node, float minHeight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetMinHeightPercent_Public_Static_Void_IntPtr_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0001E6C0 File Offset: 0x0001C8C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282709, XrefRangeEnd = 282711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetMaxWidth(IntPtr node, float maxWidth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxWidth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetMaxWidth_Public_Static_Void_IntPtr_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0001E700 File Offset: 0x0001C900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282711, XrefRangeEnd = 282713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetMaxWidthPercent(IntPtr node, float maxWidth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxWidth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetMaxWidthPercent_Public_Static_Void_IntPtr_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0001E740 File Offset: 0x0001C940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282713, XrefRangeEnd = 282715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetMaxHeight(IntPtr node, float maxHeight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetMaxHeight_Public_Static_Void_IntPtr_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0001E780 File Offset: 0x0001C980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282715, XrefRangeEnd = 282717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetMaxHeightPercent(IntPtr node, float maxHeight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetMaxHeightPercent_Public_Static_Void_IntPtr_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0001E7C0 File Offset: 0x0001C9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282717, XrefRangeEnd = 282719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetPosition(IntPtr node, YogaEdge edge, float position)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref edge;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetPosition_Public_Static_Void_IntPtr_YogaEdge_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0001E810 File Offset: 0x0001CA10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282719, XrefRangeEnd = 282721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetPositionPercent(IntPtr node, YogaEdge edge, float position)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref edge;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetPositionPercent_Public_Static_Void_IntPtr_YogaEdge_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0001E860 File Offset: 0x0001CA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282721, XrefRangeEnd = 282723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetMargin(IntPtr node, YogaEdge edge, float margin)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref edge;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref margin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetMargin_Public_Static_Void_IntPtr_YogaEdge_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0001E8B0 File Offset: 0x0001CAB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282723, XrefRangeEnd = 282725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetMarginPercent(IntPtr node, YogaEdge edge, float margin)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref edge;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref margin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetMarginPercent_Public_Static_Void_IntPtr_YogaEdge_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0001E900 File Offset: 0x0001CB00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282725, XrefRangeEnd = 282727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetMarginAuto(IntPtr node, YogaEdge edge)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref edge;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetMarginAuto_Public_Static_Void_IntPtr_YogaEdge_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0001E940 File Offset: 0x0001CB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282727, XrefRangeEnd = 282729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetPadding(IntPtr node, YogaEdge edge, float padding)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref edge;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref padding;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetPadding_Public_Static_Void_IntPtr_YogaEdge_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0001E990 File Offset: 0x0001CB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282729, XrefRangeEnd = 282731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetPaddingPercent(IntPtr node, YogaEdge edge, float padding)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref edge;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref padding;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetPaddingPercent_Public_Static_Void_IntPtr_YogaEdge_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0001E9E0 File Offset: 0x0001CBE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282731, XrefRangeEnd = 282733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YGNodeStyleSetBorder(IntPtr node, YogaEdge edge, float border)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref edge;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref border;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeStyleSetBorder_Public_Static_Void_IntPtr_YogaEdge_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0001EA30 File Offset: 0x0001CC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282733, XrefRangeEnd = 282735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float YGNodeLayoutGetLeft(IntPtr node)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeLayoutGetLeft_Public_Static_Single_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0001EA70 File Offset: 0x0001CC70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282735, XrefRangeEnd = 282737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float YGNodeLayoutGetTop(IntPtr node)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeLayoutGetTop_Public_Static_Single_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0001EAB0 File Offset: 0x0001CCB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282737, XrefRangeEnd = 282739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float YGNodeLayoutGetRight(IntPtr node)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeLayoutGetRight_Public_Static_Single_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0001EAF0 File Offset: 0x0001CCF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282739, XrefRangeEnd = 282741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float YGNodeLayoutGetBottom(IntPtr node)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeLayoutGetBottom_Public_Static_Single_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0001EB30 File Offset: 0x0001CD30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282741, XrefRangeEnd = 282743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float YGNodeLayoutGetWidth(IntPtr node)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeLayoutGetWidth_Public_Static_Single_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0001EB70 File Offset: 0x0001CD70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282743, XrefRangeEnd = 282745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float YGNodeLayoutGetHeight(IntPtr node)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeLayoutGetHeight_Public_Static_Single_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0001EBB0 File Offset: 0x0001CDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282745, XrefRangeEnd = 282747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float YGNodeLayoutGetMargin(IntPtr node, YogaEdge edge)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref edge;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeLayoutGetMargin_Public_Static_Single_IntPtr_YogaEdge_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0001EBFC File Offset: 0x0001CDFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282747, XrefRangeEnd = 282749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float YGNodeLayoutGetPadding(IntPtr node, YogaEdge edge)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref edge;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeLayoutGetPadding_Public_Static_Single_IntPtr_YogaEdge_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0001EC48 File Offset: 0x0001CE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282749, XrefRangeEnd = 282751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float YGNodeLayoutGetBorder(IntPtr node, YogaEdge edge)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref node;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref edge;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Native.NativeMethodInfoPtr_YGNodeLayoutGetBorder_Public_Static_Single_IntPtr_YogaEdge_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000021E3 File Offset: 0x000003E3
		public Native(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000021EC File Offset: 0x000003EC
		public static IntPtr YGNodeNew()
		{
			return Native.YGNodeNewDelegateField();
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000021F8 File Offset: 0x000003F8
		public static void YGNodeReset(IntPtr node)
		{
			Native.YGNodeResetDelegateField(node);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002205 File Offset: 0x00000405
		public static int YGNodeGetInstanceCount()
		{
			return Native.YGNodeGetInstanceCountDelegateField();
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002211 File Offset: 0x00000411
		public static int YGConfigGetInstanceCount()
		{
			return Native.YGConfigGetInstanceCountDelegateField();
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000221D File Offset: 0x0000041D
		public static void YGConfigSetExperimentalFeatureEnabled(IntPtr config, YogaExperimentalFeature feature, bool enabled)
		{
			Native.YGConfigSetExperimentalFeatureEnabledDelegateField(config, feature, enabled);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000222C File Offset: 0x0000042C
		public static bool YGConfigIsExperimentalFeatureEnabled(IntPtr config, YogaExperimentalFeature feature)
		{
			return Native.YGConfigIsExperimentalFeatureEnabledDelegateField(config, feature);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000223A File Offset: 0x0000043A
		public static float YGConfigGetPointScaleFactor(IntPtr config)
		{
			return Native.YGConfigGetPointScaleFactorDelegateField(config);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002247 File Offset: 0x00000447
		public static void YGNodePrint(IntPtr node, YogaPrintOptions options)
		{
			Native.YGNodePrintDelegateField(node, options);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002255 File Offset: 0x00000455
		public static void YGNodeSetBaselineFunc(IntPtr node)
		{
			Native.YGNodeSetBaselineFuncDelegateField(node);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002262 File Offset: 0x00000462
		public static void YGNodeRemoveBaselineFunc(IntPtr node)
		{
			Native.YGNodeRemoveBaselineFuncDelegateField(node);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000226F File Offset: 0x0000046F
		public static void YGNodeStyleSetDirection(IntPtr node, YogaDirection direction)
		{
			Native.YGNodeStyleSetDirectionDelegateField(node, direction);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000227D File Offset: 0x0000047D
		public static YogaFlexDirection YGNodeStyleGetFlexDirection(IntPtr node)
		{
			return Native.YGNodeStyleGetFlexDirectionDelegateField(node);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000228A File Offset: 0x0000048A
		public static YogaJustify YGNodeStyleGetJustifyContent(IntPtr node)
		{
			return Native.YGNodeStyleGetJustifyContentDelegateField(node);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002297 File Offset: 0x00000497
		public static YogaAlign YGNodeStyleGetAlignContent(IntPtr node)
		{
			return Native.YGNodeStyleGetAlignContentDelegateField(node);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000022A4 File Offset: 0x000004A4
		public static YogaAlign YGNodeStyleGetAlignItems(IntPtr node)
		{
			return Native.YGNodeStyleGetAlignItemsDelegateField(node);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000022B1 File Offset: 0x000004B1
		public static YogaAlign YGNodeStyleGetAlignSelf(IntPtr node)
		{
			return Native.YGNodeStyleGetAlignSelfDelegateField(node);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000022BE File Offset: 0x000004BE
		public static YogaPositionType YGNodeStyleGetPositionType(IntPtr node)
		{
			return Native.YGNodeStyleGetPositionTypeDelegateField(node);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000022CB File Offset: 0x000004CB
		public static YogaWrap YGNodeStyleGetFlexWrap(IntPtr node)
		{
			return Native.YGNodeStyleGetFlexWrapDelegateField(node);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000022D8 File Offset: 0x000004D8
		public static YogaOverflow YGNodeStyleGetOverflow(IntPtr node)
		{
			return Native.YGNodeStyleGetOverflowDelegateField(node);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000022E5 File Offset: 0x000004E5
		public static YogaDisplay YGNodeStyleGetDisplay(IntPtr node)
		{
			return Native.YGNodeStyleGetDisplayDelegateField(node);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000022F2 File Offset: 0x000004F2
		public static float YGNodeStyleGetFlexGrow(IntPtr node)
		{
			return Native.YGNodeStyleGetFlexGrowDelegateField(node);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000022FF File Offset: 0x000004FF
		public static float YGNodeStyleGetFlexShrink(IntPtr node)
		{
			return Native.YGNodeStyleGetFlexShrinkDelegateField(node);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0001EC94 File Offset: 0x0001CE94
		public static YogaValue YGNodeStyleGetFlexBasis(IntPtr node)
		{
			YogaValue yogaValue;
			Native.YGNodeStyleGetFlexBasis_Injected(node, out yogaValue);
			return yogaValue;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000230C File Offset: 0x0000050C
		public static float YGNodeGetComputedFlexBasis(IntPtr node)
		{
			return Native.YGNodeGetComputedFlexBasisDelegateField(node);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0001ECAC File Offset: 0x0001CEAC
		public static YogaValue YGNodeStyleGetWidth(IntPtr node)
		{
			YogaValue yogaValue;
			Native.YGNodeStyleGetWidth_Injected(node, out yogaValue);
			return yogaValue;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0001ECC4 File Offset: 0x0001CEC4
		public static YogaValue YGNodeStyleGetHeight(IntPtr node)
		{
			YogaValue yogaValue;
			Native.YGNodeStyleGetHeight_Injected(node, out yogaValue);
			return yogaValue;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0001ECDC File Offset: 0x0001CEDC
		public static YogaValue YGNodeStyleGetMinWidth(IntPtr node)
		{
			YogaValue yogaValue;
			Native.YGNodeStyleGetMinWidth_Injected(node, out yogaValue);
			return yogaValue;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0001ECF4 File Offset: 0x0001CEF4
		public static YogaValue YGNodeStyleGetMinHeight(IntPtr node)
		{
			YogaValue yogaValue;
			Native.YGNodeStyleGetMinHeight_Injected(node, out yogaValue);
			return yogaValue;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0001ED0C File Offset: 0x0001CF0C
		public static YogaValue YGNodeStyleGetMaxWidth(IntPtr node)
		{
			YogaValue yogaValue;
			Native.YGNodeStyleGetMaxWidth_Injected(node, out yogaValue);
			return yogaValue;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0001ED24 File Offset: 0x0001CF24
		public static YogaValue YGNodeStyleGetMaxHeight(IntPtr node)
		{
			YogaValue yogaValue;
			Native.YGNodeStyleGetMaxHeight_Injected(node, out yogaValue);
			return yogaValue;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002319 File Offset: 0x00000519
		public static void YGNodeStyleSetAspectRatio(IntPtr node, float aspectRatio)
		{
			Native.YGNodeStyleSetAspectRatioDelegateField(node, aspectRatio);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002327 File Offset: 0x00000527
		public static float YGNodeStyleGetAspectRatio(IntPtr node)
		{
			return Native.YGNodeStyleGetAspectRatioDelegateField(node);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0001ED3C File Offset: 0x0001CF3C
		public static YogaValue YGNodeStyleGetPosition(IntPtr node, YogaEdge edge)
		{
			YogaValue yogaValue;
			Native.YGNodeStyleGetPosition_Injected(node, edge, out yogaValue);
			return yogaValue;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0001ED54 File Offset: 0x0001CF54
		public static YogaValue YGNodeStyleGetMargin(IntPtr node, YogaEdge edge)
		{
			YogaValue yogaValue;
			Native.YGNodeStyleGetMargin_Injected(node, edge, out yogaValue);
			return yogaValue;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0001ED6C File Offset: 0x0001CF6C
		public static YogaValue YGNodeStyleGetPadding(IntPtr node, YogaEdge edge)
		{
			YogaValue yogaValue;
			Native.YGNodeStyleGetPadding_Injected(node, edge, out yogaValue);
			return yogaValue;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002334 File Offset: 0x00000534
		public static float YGNodeStyleGetBorder(IntPtr node, YogaEdge edge)
		{
			return Native.YGNodeStyleGetBorderDelegateField(node, edge);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002342 File Offset: 0x00000542
		public static YogaDirection YGNodeLayoutGetDirection(IntPtr node)
		{
			return Native.YGNodeLayoutGetDirectionDelegateField(node);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000234F File Offset: 0x0000054F
		public static void YGNodeStyleGetFlexBasis_Injected(IntPtr node, out YogaValue ret)
		{
			Native.YGNodeStyleGetFlexBasis_InjectedDelegateField(node, out ret);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000235D File Offset: 0x0000055D
		public static void YGNodeStyleGetWidth_Injected(IntPtr node, out YogaValue ret)
		{
			Native.YGNodeStyleGetWidth_InjectedDelegateField(node, out ret);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000236B File Offset: 0x0000056B
		public static void YGNodeStyleGetHeight_Injected(IntPtr node, out YogaValue ret)
		{
			Native.YGNodeStyleGetHeight_InjectedDelegateField(node, out ret);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002379 File Offset: 0x00000579
		public static void YGNodeStyleGetMinWidth_Injected(IntPtr node, out YogaValue ret)
		{
			Native.YGNodeStyleGetMinWidth_InjectedDelegateField(node, out ret);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002387 File Offset: 0x00000587
		public static void YGNodeStyleGetMinHeight_Injected(IntPtr node, out YogaValue ret)
		{
			Native.YGNodeStyleGetMinHeight_InjectedDelegateField(node, out ret);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002395 File Offset: 0x00000595
		public static void YGNodeStyleGetMaxWidth_Injected(IntPtr node, out YogaValue ret)
		{
			Native.YGNodeStyleGetMaxWidth_InjectedDelegateField(node, out ret);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000023A3 File Offset: 0x000005A3
		public static void YGNodeStyleGetMaxHeight_Injected(IntPtr node, out YogaValue ret)
		{
			Native.YGNodeStyleGetMaxHeight_InjectedDelegateField(node, out ret);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000023B1 File Offset: 0x000005B1
		public static void YGNodeStyleGetPosition_Injected(IntPtr node, YogaEdge edge, out YogaValue ret)
		{
			Native.YGNodeStyleGetPosition_InjectedDelegateField(node, edge, out ret);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000023C0 File Offset: 0x000005C0
		public static void YGNodeStyleGetMargin_Injected(IntPtr node, YogaEdge edge, out YogaValue ret)
		{
			Native.YGNodeStyleGetMargin_InjectedDelegateField(node, edge, out ret);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000023CF File Offset: 0x000005CF
		public static void YGNodeStyleGetPadding_Injected(IntPtr node, YogaEdge edge, out YogaValue ret)
		{
			Native.YGNodeStyleGetPadding_InjectedDelegateField(node, edge, out ret);
		}

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeNewWithConfig_Public_Static_IntPtr_IntPtr_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeFree_Public_Static_Void_IntPtr_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeFreeInternal_Private_Static_Void_IntPtr_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_YGSetManagedObject_Public_Static_Void_IntPtr_YogaNode_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeSetConfig_Public_Static_Void_IntPtr_IntPtr_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_YGConfigGetDefault_Public_Static_IntPtr_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_YGConfigNew_Public_Static_IntPtr_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_YGConfigFree_Public_Static_Void_IntPtr_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_YGConfigFreeInternal_Private_Static_Void_IntPtr_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_YGConfigSetUseWebDefaults_Public_Static_Void_IntPtr_Boolean_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_YGConfigGetUseWebDefaults_Public_Static_Boolean_IntPtr_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_YGConfigSetPointScaleFactor_Public_Static_Void_IntPtr_Single_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeInsertChild_Public_Static_Void_IntPtr_IntPtr_UInt32_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeRemoveChild_Public_Static_Void_IntPtr_IntPtr_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeCalculateLayout_Public_Static_Void_IntPtr_Single_Single_YogaDirection_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeMarkDirty_Public_Static_Void_IntPtr_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeIsDirty_Public_Static_Boolean_IntPtr_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeCopyStyle_Public_Static_Void_IntPtr_IntPtr_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeSetMeasureFunc_Public_Static_Void_IntPtr_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeRemoveMeasureFunc_Public_Static_Void_IntPtr_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeMeasureInvoke_Public_Static_Void_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode_IntPtr_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeBaselineInvoke_Public_Static_Void_YogaNode_Single_Single_IntPtr_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeSetHasNewLayout_Public_Static_Void_IntPtr_Boolean_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeGetHasNewLayout_Public_Static_Boolean_IntPtr_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleGetDirection_Public_Static_YogaDirection_IntPtr_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetFlexDirection_Public_Static_Void_IntPtr_YogaFlexDirection_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetJustifyContent_Public_Static_Void_IntPtr_YogaJustify_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetAlignContent_Public_Static_Void_IntPtr_YogaAlign_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetAlignItems_Public_Static_Void_IntPtr_YogaAlign_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetAlignSelf_Public_Static_Void_IntPtr_YogaAlign_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetPositionType_Public_Static_Void_IntPtr_YogaPositionType_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetFlexWrap_Public_Static_Void_IntPtr_YogaWrap_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetOverflow_Public_Static_Void_IntPtr_YogaOverflow_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetDisplay_Public_Static_Void_IntPtr_YogaDisplay_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetFlex_Public_Static_Void_IntPtr_Single_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetFlexGrow_Public_Static_Void_IntPtr_Single_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetFlexShrink_Public_Static_Void_IntPtr_Single_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetFlexBasis_Public_Static_Void_IntPtr_Single_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetFlexBasisPercent_Public_Static_Void_IntPtr_Single_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetFlexBasisAuto_Public_Static_Void_IntPtr_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetWidth_Public_Static_Void_IntPtr_Single_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetWidthPercent_Public_Static_Void_IntPtr_Single_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetWidthAuto_Public_Static_Void_IntPtr_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetHeight_Public_Static_Void_IntPtr_Single_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetHeightPercent_Public_Static_Void_IntPtr_Single_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetHeightAuto_Public_Static_Void_IntPtr_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetMinWidth_Public_Static_Void_IntPtr_Single_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetMinWidthPercent_Public_Static_Void_IntPtr_Single_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetMinHeight_Public_Static_Void_IntPtr_Single_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetMinHeightPercent_Public_Static_Void_IntPtr_Single_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetMaxWidth_Public_Static_Void_IntPtr_Single_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetMaxWidthPercent_Public_Static_Void_IntPtr_Single_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetMaxHeight_Public_Static_Void_IntPtr_Single_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetMaxHeightPercent_Public_Static_Void_IntPtr_Single_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetPosition_Public_Static_Void_IntPtr_YogaEdge_Single_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetPositionPercent_Public_Static_Void_IntPtr_YogaEdge_Single_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetMargin_Public_Static_Void_IntPtr_YogaEdge_Single_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetMarginPercent_Public_Static_Void_IntPtr_YogaEdge_Single_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetMarginAuto_Public_Static_Void_IntPtr_YogaEdge_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetPadding_Public_Static_Void_IntPtr_YogaEdge_Single_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetPaddingPercent_Public_Static_Void_IntPtr_YogaEdge_Single_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeStyleSetBorder_Public_Static_Void_IntPtr_YogaEdge_Single_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeLayoutGetLeft_Public_Static_Single_IntPtr_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeLayoutGetTop_Public_Static_Single_IntPtr_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeLayoutGetRight_Public_Static_Single_IntPtr_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeLayoutGetBottom_Public_Static_Single_IntPtr_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeLayoutGetWidth_Public_Static_Single_IntPtr_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeLayoutGetHeight_Public_Static_Single_IntPtr_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeLayoutGetMargin_Public_Static_Single_IntPtr_YogaEdge_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeLayoutGetPadding_Public_Static_Single_IntPtr_YogaEdge_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_YGNodeLayoutGetBorder_Public_Static_Single_IntPtr_YogaEdge_0;

		// Token: 0x0400008A RID: 138
		private static readonly Native.YGNodeNewDelegate YGNodeNewDelegateField;

		// Token: 0x0400008B RID: 139
		private static readonly Native.YGNodeResetDelegate YGNodeResetDelegateField;

		// Token: 0x0400008C RID: 140
		private static readonly Native.YGNodeGetInstanceCountDelegate YGNodeGetInstanceCountDelegateField;

		// Token: 0x0400008D RID: 141
		private static readonly Native.YGConfigGetInstanceCountDelegate YGConfigGetInstanceCountDelegateField;

		// Token: 0x0400008E RID: 142
		private static readonly Native.YGConfigSetExperimentalFeatureEnabledDelegate YGConfigSetExperimentalFeatureEnabledDelegateField;

		// Token: 0x0400008F RID: 143
		private static readonly Native.YGConfigIsExperimentalFeatureEnabledDelegate YGConfigIsExperimentalFeatureEnabledDelegateField;

		// Token: 0x04000090 RID: 144
		private static readonly Native.YGConfigGetPointScaleFactorDelegate YGConfigGetPointScaleFactorDelegateField;

		// Token: 0x04000091 RID: 145
		private static readonly Native.YGNodePrintDelegate YGNodePrintDelegateField;

		// Token: 0x04000092 RID: 146
		private static readonly Native.YGNodeSetBaselineFuncDelegate YGNodeSetBaselineFuncDelegateField;

		// Token: 0x04000093 RID: 147
		private static readonly Native.YGNodeRemoveBaselineFuncDelegate YGNodeRemoveBaselineFuncDelegateField;

		// Token: 0x04000094 RID: 148
		private static readonly Native.YGNodeStyleSetDirectionDelegate YGNodeStyleSetDirectionDelegateField;

		// Token: 0x04000095 RID: 149
		private static readonly Native.YGNodeStyleGetFlexDirectionDelegate YGNodeStyleGetFlexDirectionDelegateField;

		// Token: 0x04000096 RID: 150
		private static readonly Native.YGNodeStyleGetJustifyContentDelegate YGNodeStyleGetJustifyContentDelegateField;

		// Token: 0x04000097 RID: 151
		private static readonly Native.YGNodeStyleGetAlignContentDelegate YGNodeStyleGetAlignContentDelegateField;

		// Token: 0x04000098 RID: 152
		private static readonly Native.YGNodeStyleGetAlignItemsDelegate YGNodeStyleGetAlignItemsDelegateField;

		// Token: 0x04000099 RID: 153
		private static readonly Native.YGNodeStyleGetAlignSelfDelegate YGNodeStyleGetAlignSelfDelegateField;

		// Token: 0x0400009A RID: 154
		private static readonly Native.YGNodeStyleGetPositionTypeDelegate YGNodeStyleGetPositionTypeDelegateField;

		// Token: 0x0400009B RID: 155
		private static readonly Native.YGNodeStyleGetFlexWrapDelegate YGNodeStyleGetFlexWrapDelegateField;

		// Token: 0x0400009C RID: 156
		private static readonly Native.YGNodeStyleGetOverflowDelegate YGNodeStyleGetOverflowDelegateField;

		// Token: 0x0400009D RID: 157
		private static readonly Native.YGNodeStyleGetDisplayDelegate YGNodeStyleGetDisplayDelegateField;

		// Token: 0x0400009E RID: 158
		private static readonly Native.YGNodeStyleGetFlexGrowDelegate YGNodeStyleGetFlexGrowDelegateField;

		// Token: 0x0400009F RID: 159
		private static readonly Native.YGNodeStyleGetFlexShrinkDelegate YGNodeStyleGetFlexShrinkDelegateField;

		// Token: 0x040000A0 RID: 160
		private static readonly Native.YGNodeGetComputedFlexBasisDelegate YGNodeGetComputedFlexBasisDelegateField;

		// Token: 0x040000A1 RID: 161
		private static readonly Native.YGNodeStyleSetAspectRatioDelegate YGNodeStyleSetAspectRatioDelegateField;

		// Token: 0x040000A2 RID: 162
		private static readonly Native.YGNodeStyleGetAspectRatioDelegate YGNodeStyleGetAspectRatioDelegateField;

		// Token: 0x040000A3 RID: 163
		private static readonly Native.YGNodeStyleGetBorderDelegate YGNodeStyleGetBorderDelegateField;

		// Token: 0x040000A4 RID: 164
		private static readonly Native.YGNodeLayoutGetDirectionDelegate YGNodeLayoutGetDirectionDelegateField;

		// Token: 0x040000A5 RID: 165
		private static readonly Native.YGNodeStyleGetFlexBasis_InjectedDelegate YGNodeStyleGetFlexBasis_InjectedDelegateField;

		// Token: 0x040000A6 RID: 166
		private static readonly Native.YGNodeStyleGetWidth_InjectedDelegate YGNodeStyleGetWidth_InjectedDelegateField;

		// Token: 0x040000A7 RID: 167
		private static readonly Native.YGNodeStyleGetHeight_InjectedDelegate YGNodeStyleGetHeight_InjectedDelegateField;

		// Token: 0x040000A8 RID: 168
		private static readonly Native.YGNodeStyleGetMinWidth_InjectedDelegate YGNodeStyleGetMinWidth_InjectedDelegateField;

		// Token: 0x040000A9 RID: 169
		private static readonly Native.YGNodeStyleGetMinHeight_InjectedDelegate YGNodeStyleGetMinHeight_InjectedDelegateField;

		// Token: 0x040000AA RID: 170
		private static readonly Native.YGNodeStyleGetMaxWidth_InjectedDelegate YGNodeStyleGetMaxWidth_InjectedDelegateField;

		// Token: 0x040000AB RID: 171
		private static readonly Native.YGNodeStyleGetMaxHeight_InjectedDelegate YGNodeStyleGetMaxHeight_InjectedDelegateField;

		// Token: 0x040000AC RID: 172
		private static readonly Native.YGNodeStyleGetPosition_InjectedDelegate YGNodeStyleGetPosition_InjectedDelegateField;

		// Token: 0x040000AD RID: 173
		private static readonly Native.YGNodeStyleGetMargin_InjectedDelegate YGNodeStyleGetMargin_InjectedDelegateField;

		// Token: 0x040000AE RID: 174
		private static readonly Native.YGNodeStyleGetPadding_InjectedDelegate YGNodeStyleGetPadding_InjectedDelegateField;

		// Token: 0x020002FB RID: 763
		// (Invoke) Token: 0x060034CB RID: 13515
		private delegate IntPtr YGNodeNewDelegate();

		// Token: 0x020002FC RID: 764
		// (Invoke) Token: 0x060034CD RID: 13517
		private delegate void YGNodeResetDelegate(IntPtr node);

		// Token: 0x020002FD RID: 765
		// (Invoke) Token: 0x060034CF RID: 13519
		private delegate int YGNodeGetInstanceCountDelegate();

		// Token: 0x020002FE RID: 766
		// (Invoke) Token: 0x060034D1 RID: 13521
		private delegate int YGConfigGetInstanceCountDelegate();

		// Token: 0x020002FF RID: 767
		// (Invoke) Token: 0x060034D3 RID: 13523
		private delegate void YGConfigSetExperimentalFeatureEnabledDelegate(IntPtr config, YogaExperimentalFeature feature, bool enabled);

		// Token: 0x02000300 RID: 768
		// (Invoke) Token: 0x060034D5 RID: 13525
		private delegate bool YGConfigIsExperimentalFeatureEnabledDelegate(IntPtr config, YogaExperimentalFeature feature);

		// Token: 0x02000301 RID: 769
		// (Invoke) Token: 0x060034D7 RID: 13527
		private delegate float YGConfigGetPointScaleFactorDelegate(IntPtr config);

		// Token: 0x02000302 RID: 770
		// (Invoke) Token: 0x060034D9 RID: 13529
		private delegate void YGNodePrintDelegate(IntPtr node, YogaPrintOptions options);

		// Token: 0x02000303 RID: 771
		// (Invoke) Token: 0x060034DB RID: 13531
		private delegate void YGNodeSetBaselineFuncDelegate(IntPtr node);

		// Token: 0x02000304 RID: 772
		// (Invoke) Token: 0x060034DD RID: 13533
		private delegate void YGNodeRemoveBaselineFuncDelegate(IntPtr node);

		// Token: 0x02000305 RID: 773
		// (Invoke) Token: 0x060034DF RID: 13535
		private delegate void YGNodeStyleSetDirectionDelegate(IntPtr node, YogaDirection direction);

		// Token: 0x02000306 RID: 774
		// (Invoke) Token: 0x060034E1 RID: 13537
		private delegate YogaFlexDirection YGNodeStyleGetFlexDirectionDelegate(IntPtr node);

		// Token: 0x02000307 RID: 775
		// (Invoke) Token: 0x060034E3 RID: 13539
		private delegate YogaJustify YGNodeStyleGetJustifyContentDelegate(IntPtr node);

		// Token: 0x02000308 RID: 776
		// (Invoke) Token: 0x060034E5 RID: 13541
		private delegate YogaAlign YGNodeStyleGetAlignContentDelegate(IntPtr node);

		// Token: 0x02000309 RID: 777
		// (Invoke) Token: 0x060034E7 RID: 13543
		private delegate YogaAlign YGNodeStyleGetAlignItemsDelegate(IntPtr node);

		// Token: 0x0200030A RID: 778
		// (Invoke) Token: 0x060034E9 RID: 13545
		private delegate YogaAlign YGNodeStyleGetAlignSelfDelegate(IntPtr node);

		// Token: 0x0200030B RID: 779
		// (Invoke) Token: 0x060034EB RID: 13547
		private delegate YogaPositionType YGNodeStyleGetPositionTypeDelegate(IntPtr node);

		// Token: 0x0200030C RID: 780
		// (Invoke) Token: 0x060034ED RID: 13549
		private delegate YogaWrap YGNodeStyleGetFlexWrapDelegate(IntPtr node);

		// Token: 0x0200030D RID: 781
		// (Invoke) Token: 0x060034EF RID: 13551
		private delegate YogaOverflow YGNodeStyleGetOverflowDelegate(IntPtr node);

		// Token: 0x0200030E RID: 782
		// (Invoke) Token: 0x060034F1 RID: 13553
		private delegate YogaDisplay YGNodeStyleGetDisplayDelegate(IntPtr node);

		// Token: 0x0200030F RID: 783
		// (Invoke) Token: 0x060034F3 RID: 13555
		private delegate float YGNodeStyleGetFlexGrowDelegate(IntPtr node);

		// Token: 0x02000310 RID: 784
		// (Invoke) Token: 0x060034F5 RID: 13557
		private delegate float YGNodeStyleGetFlexShrinkDelegate(IntPtr node);

		// Token: 0x02000311 RID: 785
		// (Invoke) Token: 0x060034F7 RID: 13559
		private delegate float YGNodeGetComputedFlexBasisDelegate(IntPtr node);

		// Token: 0x02000312 RID: 786
		// (Invoke) Token: 0x060034F9 RID: 13561
		private delegate void YGNodeStyleSetAspectRatioDelegate(IntPtr node, float aspectRatio);

		// Token: 0x02000313 RID: 787
		// (Invoke) Token: 0x060034FB RID: 13563
		private delegate float YGNodeStyleGetAspectRatioDelegate(IntPtr node);

		// Token: 0x02000314 RID: 788
		// (Invoke) Token: 0x060034FD RID: 13565
		private delegate float YGNodeStyleGetBorderDelegate(IntPtr node, YogaEdge edge);

		// Token: 0x02000315 RID: 789
		// (Invoke) Token: 0x060034FF RID: 13567
		private delegate YogaDirection YGNodeLayoutGetDirectionDelegate(IntPtr node);

		// Token: 0x02000316 RID: 790
		// (Invoke) Token: 0x06003501 RID: 13569
		private delegate void YGNodeStyleGetFlexBasis_InjectedDelegate(IntPtr node, [Out] IntPtr ret);

		// Token: 0x02000317 RID: 791
		// (Invoke) Token: 0x06003503 RID: 13571
		private delegate void YGNodeStyleGetWidth_InjectedDelegate(IntPtr node, [Out] IntPtr ret);

		// Token: 0x02000318 RID: 792
		// (Invoke) Token: 0x06003505 RID: 13573
		private delegate void YGNodeStyleGetHeight_InjectedDelegate(IntPtr node, [Out] IntPtr ret);

		// Token: 0x02000319 RID: 793
		// (Invoke) Token: 0x06003507 RID: 13575
		private delegate void YGNodeStyleGetMinWidth_InjectedDelegate(IntPtr node, [Out] IntPtr ret);

		// Token: 0x0200031A RID: 794
		// (Invoke) Token: 0x06003509 RID: 13577
		private delegate void YGNodeStyleGetMinHeight_InjectedDelegate(IntPtr node, [Out] IntPtr ret);

		// Token: 0x0200031B RID: 795
		// (Invoke) Token: 0x0600350B RID: 13579
		private delegate void YGNodeStyleGetMaxWidth_InjectedDelegate(IntPtr node, [Out] IntPtr ret);

		// Token: 0x0200031C RID: 796
		// (Invoke) Token: 0x0600350D RID: 13581
		private delegate void YGNodeStyleGetMaxHeight_InjectedDelegate(IntPtr node, [Out] IntPtr ret);

		// Token: 0x0200031D RID: 797
		// (Invoke) Token: 0x0600350F RID: 13583
		private delegate void YGNodeStyleGetPosition_InjectedDelegate(IntPtr node, YogaEdge edge, [Out] IntPtr ret);

		// Token: 0x0200031E RID: 798
		// (Invoke) Token: 0x06003511 RID: 13585
		private delegate void YGNodeStyleGetMargin_InjectedDelegate(IntPtr node, YogaEdge edge, [Out] IntPtr ret);

		// Token: 0x0200031F RID: 799
		// (Invoke) Token: 0x06003513 RID: 13587
		private delegate void YGNodeStyleGetPadding_InjectedDelegate(IntPtr node, YogaEdge edge, [Out] IntPtr ret);
	}
}
