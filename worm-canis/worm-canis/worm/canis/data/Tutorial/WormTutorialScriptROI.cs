using System;
using Canis.context;
using Canis.entities;
using Canis.tutorialScripts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.data.Tutorial
{
	// Token: 0x0200004D RID: 77
	public class WormTutorialScriptROI : WormTutorialScript
	{
		// Token: 0x06000A8C RID: 2700 RVA: 0x00089B60 File Offset: 0x00087D60
		// Note: this type is marked as 'beforefieldinit'.
		static WormTutorialScriptROI()
		{
			Il2CppClassPointerStore<WormTutorialScriptROI>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Tutorial", "WormTutorialScriptROI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialScriptROI>.NativeClassPtr);
			WormTutorialScriptROI.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI>.NativeClassPtr, 100665087);
			WormTutorialScriptROI.NativeMethodInfoPtr_tutorialItems_Protected_Virtual_IEnumerable_1_TutorialItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI>.NativeClassPtr, 100665088);
			WormTutorialScriptROI.NativeMethodInfoPtr_HoldAI_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI>.NativeClassPtr, 100665089);
			WormTutorialScriptROI.NativeMethodInfoPtr_HumanShippingTrackUndo_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI>.NativeClassPtr, 100665090);
			WormTutorialScriptROI.NativeMethodInfoPtr_HumanShippingTrackRedo_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI>.NativeClassPtr, 100665091);
			WormTutorialScriptROI.NativeMethodInfoPtr_ShippingCompleted_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI>.NativeClassPtr, 100665092);
			WormTutorialScriptROI.NativeMethodInfoPtr_ThreeShippingAbilities_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI>.NativeClassPtr, 100665093);
			WormTutorialScriptROI.NativeMethodInfoPtr_TwoShippingAbilities_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI>.NativeClassPtr, 100665094);
			WormTutorialScriptROI.NativeMethodInfoPtr_OneShippingAbility_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI>.NativeClassPtr, 100665095);
			WormTutorialScriptROI.NativeMethodInfoPtr_TechAcquired_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI>.NativeClassPtr, 100665096);
			WormTutorialScriptROI.NativeMethodInfoPtr_DreadnoughtActive_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI>.NativeClassPtr, 100665097);
			WormTutorialScriptROI.NativeMethodInfoPtr_ControlActive_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI>.NativeClassPtr, 100665098);
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x00089C80 File Offset: 0x00087E80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54376, RefRangeEnd = 54377, XrefRangeStart = 54376, XrefRangeEnd = 54377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTutorialScriptROI(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialScriptROI>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x00089CCC File Offset: 0x00087ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68001, XrefRangeEnd = 70409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<AdvancedTutorialScript.TutorialItem> tutorialItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTutorialScriptROI.NativeMethodInfoPtr_tutorialItems_Protected_Virtual_IEnumerable_1_TutorialItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AdvancedTutorialScript.TutorialItem>>(intPtr3) : null;
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00089D18 File Offset: 0x00087F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70409, XrefRangeEnd = 70437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HoldAI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.NativeMethodInfoPtr_HoldAI_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00089D54 File Offset: 0x00087F54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 70484, RefRangeEnd = 70486, XrefRangeStart = 70437, XrefRangeEnd = 70484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HumanShippingTrackUndo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.NativeMethodInfoPtr_HumanShippingTrackUndo_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x00089D90 File Offset: 0x00087F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70486, XrefRangeEnd = 70533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HumanShippingTrackRedo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.NativeMethodInfoPtr_HumanShippingTrackRedo_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00089DCC File Offset: 0x00087FCC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 70562, RefRangeEnd = 70567, XrefRangeStart = 70533, XrefRangeEnd = 70562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShippingCompleted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.NativeMethodInfoPtr_ShippingCompleted_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00089E08 File Offset: 0x00088008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70567, XrefRangeEnd = 70619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ThreeShippingAbilities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.NativeMethodInfoPtr_ThreeShippingAbilities_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x00089E44 File Offset: 0x00088044
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70671, RefRangeEnd = 70672, XrefRangeStart = 70619, XrefRangeEnd = 70671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TwoShippingAbilities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.NativeMethodInfoPtr_TwoShippingAbilities_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x00089E80 File Offset: 0x00088080
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70724, RefRangeEnd = 70725, XrefRangeStart = 70672, XrefRangeEnd = 70724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OneShippingAbility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.NativeMethodInfoPtr_OneShippingAbility_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00089EBC File Offset: 0x000880BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70725, XrefRangeEnd = 70732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TechAcquired()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.NativeMethodInfoPtr_TechAcquired_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x00089EF8 File Offset: 0x000880F8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 70760, RefRangeEnd = 70768, XrefRangeStart = 70732, XrefRangeEnd = 70760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DreadnoughtActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.NativeMethodInfoPtr_DreadnoughtActive_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x00089F34 File Offset: 0x00088134
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70796, RefRangeEnd = 70797, XrefRangeStart = 70768, XrefRangeEnd = 70796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ControlActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.NativeMethodInfoPtr_ControlActive_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x00006BA1 File Offset: 0x00004DA1
		public WormTutorialScriptROI(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeMethodInfoPtr_tutorialItems_Protected_Virtual_IEnumerable_1_TutorialItem_0;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeMethodInfoPtr_HoldAI_Private_Boolean_0;

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeMethodInfoPtr_HumanShippingTrackUndo_Private_Boolean_0;

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeMethodInfoPtr_HumanShippingTrackRedo_Private_Boolean_0;

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeMethodInfoPtr_ShippingCompleted_Private_Boolean_0;

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeMethodInfoPtr_ThreeShippingAbilities_Private_Boolean_0;

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeMethodInfoPtr_TwoShippingAbilities_Private_Boolean_0;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeMethodInfoPtr_OneShippingAbility_Private_Boolean_0;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeMethodInfoPtr_TechAcquired_Private_Boolean_0;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeMethodInfoPtr_DreadnoughtActive_Private_Boolean_0;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeMethodInfoPtr_ControlActive_Private_Boolean_0;

		// Token: 0x020005F8 RID: 1528
		[ObfuscatedName("worm.canis.data.Tutorial.WormTutorialScriptROI+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06004BF4 RID: 19444 RVA: 0x0019A690 File Offset: 0x00198890
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTutorialScriptROI>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr);
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__1_0");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__1_1");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__1_3");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__1_4");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_30 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__1_30");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_31 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__1_31");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__1_7");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__1_8");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__1_9");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__1_10");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__1_18");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__1_32");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_34 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__1_34");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_33 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__1_33");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__1_19");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_35 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__1_35");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_22 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__1_22");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_36 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__1_36");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_23 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__1_23");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_37 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__1_37");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_38 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__1_38");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__2_0");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__3_0");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__3_1");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__4_0");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__4_1");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__5_0");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__6_0");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__7_0");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__8_0");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__9_0");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__10_0");
				WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, "<>9__11_0");
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665100);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665101);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_1_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665102);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_3_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665103);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_4_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665104);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_30_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665105);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_31_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665106);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_7_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665107);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_8_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665108);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_9_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665109);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_10_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665110);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_18_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665111);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_19_Internal_Il2CppReferenceArray_1_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665112);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_32_Internal_Boolean_WormTechTileStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665113);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_33_Internal_Entity_WormTechTileStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665114);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_34_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665115);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_22_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665116);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_35_Internal_Boolean_WormTechTileStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665117);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_23_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665118);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_36_Internal_Boolean_WormTechTileStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665119);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_37_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665120);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_38_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665121);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__HoldAI_b__2_0_Internal_Boolean_Objective_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665122);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__HumanShippingTrackUndo_b__3_0_Internal_Boolean_Objective_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665123);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__HumanShippingTrackUndo_b__3_1_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665124);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__HumanShippingTrackRedo_b__4_0_Internal_Boolean_Objective_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665125);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__HumanShippingTrackRedo_b__4_1_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665126);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__ShippingCompleted_b__5_0_Internal_Boolean_Objective_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665127);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__ThreeShippingAbilities_b__6_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665128);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__TwoShippingAbilities_b__7_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665129);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__OneShippingAbility_b__8_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665130);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__TechAcquired_b__9_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665131);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__DreadnoughtActive_b__10_0_Internal_Boolean_Objective_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665132);
				WormTutorialScriptROI.__c.NativeMethodInfoPtr__ControlActive_b__11_0_Internal_Boolean_Objective_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr, 100665133);
			}

			// Token: 0x06004BF5 RID: 19445 RVA: 0x0019AC0C File Offset: 0x00198E0C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialScriptROI.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004BF6 RID: 19446 RVA: 0x0019AC48 File Offset: 0x00198E48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004BF7 RID: 19447 RVA: 0x0019AC98 File Offset: 0x00198E98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_1(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_1_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004BF8 RID: 19448 RVA: 0x0019ACE8 File Offset: 0x00198EE8
			[CallerCount(0)]
			public unsafe Entity _tutorialItems_b__1_3(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_3_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004BF9 RID: 19449 RVA: 0x0019AD38 File Offset: 0x00198F38
			[CallerCount(0)]
			public unsafe Entity _tutorialItems_b__1_4(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_4_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004BFA RID: 19450 RVA: 0x0019AD88 File Offset: 0x00198F88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67692, XrefRangeEnd = 67701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_30(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_30_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004BFB RID: 19451 RVA: 0x0019ADD8 File Offset: 0x00198FD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67701, XrefRangeEnd = 67710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_31(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_31_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004BFC RID: 19452 RVA: 0x0019AE28 File Offset: 0x00199028
			[CallerCount(0)]
			public unsafe Entity _tutorialItems_b__1_7(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_7_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004BFD RID: 19453 RVA: 0x0019AE78 File Offset: 0x00199078
			[CallerCount(0)]
			public unsafe Entity _tutorialItems_b__1_8(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_8_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004BFE RID: 19454 RVA: 0x0019AEC8 File Offset: 0x001990C8
			[CallerCount(0)]
			public unsafe Entity _tutorialItems_b__1_9(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_9_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004BFF RID: 19455 RVA: 0x0019AF18 File Offset: 0x00199118
			[CallerCount(0)]
			public unsafe Entity _tutorialItems_b__1_10(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_10_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004C00 RID: 19456 RVA: 0x0019AF68 File Offset: 0x00199168
			[CallerCount(0)]
			public unsafe Entity _tutorialItems_b__1_18(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_18_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004C01 RID: 19457 RVA: 0x0019AFB8 File Offset: 0x001991B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67710, XrefRangeEnd = 67756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<Entity> _tutorialItems_b__1_19(Context context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_19_Internal_Il2CppReferenceArray_1_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x06004C02 RID: 19458 RVA: 0x0019B008 File Offset: 0x00199208
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67756, XrefRangeEnd = 67760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_32(WormTechTileStack _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_32_Internal_Boolean_WormTechTileStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C03 RID: 19459 RVA: 0x0019B058 File Offset: 0x00199258
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67760, XrefRangeEnd = 67779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__1_33(WormTechTileStack _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_33_Internal_Entity_WormTechTileStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004C04 RID: 19460 RVA: 0x0019B0A8 File Offset: 0x001992A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67779, XrefRangeEnd = 67784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_34(Entity tile)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(tile);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_34_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C05 RID: 19461 RVA: 0x0019B0F8 File Offset: 0x001992F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67784, XrefRangeEnd = 67811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__1_22(Context context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_22_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004C06 RID: 19462 RVA: 0x0019B148 File Offset: 0x00199348
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67811, XrefRangeEnd = 67823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_35(WormTechTileStack stack)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stack);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_35_Internal_Boolean_WormTechTileStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C07 RID: 19463 RVA: 0x0019B198 File Offset: 0x00199398
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67823, XrefRangeEnd = 67850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__1_23(Context context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_23_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004C08 RID: 19464 RVA: 0x0019B1E8 File Offset: 0x001993E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67850, XrefRangeEnd = 67862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_36(WormTechTileStack stack)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stack);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_36_Internal_Boolean_WormTechTileStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C09 RID: 19465 RVA: 0x0019B238 File Offset: 0x00199438
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67862, XrefRangeEnd = 67871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_37(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_37_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C0A RID: 19466 RVA: 0x0019B288 File Offset: 0x00199488
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67871, XrefRangeEnd = 67880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_38(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__tutorialItems_b__1_38_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C0B RID: 19467 RVA: 0x0019B2D8 File Offset: 0x001994D8
			[CallerCount(0)]
			public unsafe bool _HoldAI_b__2_0(Objective o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__HoldAI_b__2_0_Internal_Boolean_Objective_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C0C RID: 19468 RVA: 0x0019B328 File Offset: 0x00199528
			[CallerCount(0)]
			public unsafe bool _HumanShippingTrackUndo_b__3_0(Objective o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__HumanShippingTrackUndo_b__3_0_Internal_Boolean_Objective_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C0D RID: 19469 RVA: 0x0019B378 File Offset: 0x00199578
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HumanShippingTrackUndo_b__3_1(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__HumanShippingTrackUndo_b__3_1_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C0E RID: 19470 RVA: 0x0019B3C8 File Offset: 0x001995C8
			[CallerCount(0)]
			public unsafe bool _HumanShippingTrackRedo_b__4_0(Objective o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__HumanShippingTrackRedo_b__4_0_Internal_Boolean_Objective_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C0F RID: 19471 RVA: 0x0019B418 File Offset: 0x00199618
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HumanShippingTrackRedo_b__4_1(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__HumanShippingTrackRedo_b__4_1_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C10 RID: 19472 RVA: 0x0019B468 File Offset: 0x00199668
			[CallerCount(0)]
			public unsafe bool _ShippingCompleted_b__5_0(Objective o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__ShippingCompleted_b__5_0_Internal_Boolean_Objective_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C11 RID: 19473 RVA: 0x0019B4B8 File Offset: 0x001996B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ThreeShippingAbilities_b__6_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__ThreeShippingAbilities_b__6_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C12 RID: 19474 RVA: 0x0019B508 File Offset: 0x00199708
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TwoShippingAbilities_b__7_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__TwoShippingAbilities_b__7_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C13 RID: 19475 RVA: 0x0019B558 File Offset: 0x00199758
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OneShippingAbility_b__8_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__OneShippingAbility_b__8_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C14 RID: 19476 RVA: 0x0019B5A8 File Offset: 0x001997A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TechAcquired_b__9_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__TechAcquired_b__9_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C15 RID: 19477 RVA: 0x0019B5F8 File Offset: 0x001997F8
			[CallerCount(0)]
			public unsafe bool _DreadnoughtActive_b__10_0(Objective o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__DreadnoughtActive_b__10_0_Internal_Boolean_Objective_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C16 RID: 19478 RVA: 0x0019B648 File Offset: 0x00199848
			[CallerCount(0)]
			public unsafe bool _ControlActive_b__11_0(Objective o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c.NativeMethodInfoPtr__ControlActive_b__11_0_Internal_Boolean_Objective_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C17 RID: 19479 RVA: 0x0001A080 File Offset: 0x00018280
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001289 RID: 4745
			// (get) Token: 0x06004C18 RID: 19480 RVA: 0x0019B698 File Offset: 0x00199898
			// (set) Token: 0x06004C19 RID: 19481 RVA: 0x0001A089 File Offset: 0x00018289
			public unsafe static WormTutorialScriptROI.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTutorialScriptROI.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700128A RID: 4746
			// (get) Token: 0x06004C1A RID: 19482 RVA: 0x0019B6C0 File Offset: 0x001998C0
			// (set) Token: 0x06004C1B RID: 19483 RVA: 0x0001A09B File Offset: 0x0001829B
			public unsafe static Func<WormPlayer, bool> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700128B RID: 4747
			// (get) Token: 0x06004C1C RID: 19484 RVA: 0x0019B6E8 File Offset: 0x001998E8
			// (set) Token: 0x06004C1D RID: 19485 RVA: 0x0001A0AD File Offset: 0x000182AD
			public unsafe static Func<WormPlayer, bool> __9__1_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700128C RID: 4748
			// (get) Token: 0x06004C1E RID: 19486 RVA: 0x0019B710 File Offset: 0x00199910
			// (set) Token: 0x06004C1F RID: 19487 RVA: 0x0001A0BF File Offset: 0x000182BF
			public unsafe static Func<WormPlaymat, Entity> __9__1_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700128D RID: 4749
			// (get) Token: 0x06004C20 RID: 19488 RVA: 0x0019B738 File Offset: 0x00199938
			// (set) Token: 0x06004C21 RID: 19489 RVA: 0x0001A0D1 File Offset: 0x000182D1
			public unsafe static Func<WormPlaymat, Entity> __9__1_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700128E RID: 4750
			// (get) Token: 0x06004C22 RID: 19490 RVA: 0x0019B760 File Offset: 0x00199960
			// (set) Token: 0x06004C23 RID: 19491 RVA: 0x0001A0E3 File Offset: 0x000182E3
			public unsafe static Func<Entity, bool> __9__1_30
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_30, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_30, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700128F RID: 4751
			// (get) Token: 0x06004C24 RID: 19492 RVA: 0x0019B788 File Offset: 0x00199988
			// (set) Token: 0x06004C25 RID: 19493 RVA: 0x0001A0F5 File Offset: 0x000182F5
			public unsafe static Func<Entity, bool> __9__1_31
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_31, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_31, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001290 RID: 4752
			// (get) Token: 0x06004C26 RID: 19494 RVA: 0x0019B7B0 File Offset: 0x001999B0
			// (set) Token: 0x06004C27 RID: 19495 RVA: 0x0001A107 File Offset: 0x00018307
			public unsafe static Func<WormPlaymat, Entity> __9__1_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001291 RID: 4753
			// (get) Token: 0x06004C28 RID: 19496 RVA: 0x0019B7D8 File Offset: 0x001999D8
			// (set) Token: 0x06004C29 RID: 19497 RVA: 0x0001A119 File Offset: 0x00018319
			public unsafe static Func<WormPlaymat, Entity> __9__1_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001292 RID: 4754
			// (get) Token: 0x06004C2A RID: 19498 RVA: 0x0019B800 File Offset: 0x00199A00
			// (set) Token: 0x06004C2B RID: 19499 RVA: 0x0001A12B File Offset: 0x0001832B
			public unsafe static Func<WormPlaymat, Entity> __9__1_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001293 RID: 4755
			// (get) Token: 0x06004C2C RID: 19500 RVA: 0x0019B828 File Offset: 0x00199A28
			// (set) Token: 0x06004C2D RID: 19501 RVA: 0x0001A13D File Offset: 0x0001833D
			public unsafe static Func<WormPlaymat, Entity> __9__1_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001294 RID: 4756
			// (get) Token: 0x06004C2E RID: 19502 RVA: 0x0019B850 File Offset: 0x00199A50
			// (set) Token: 0x06004C2F RID: 19503 RVA: 0x0001A14F File Offset: 0x0001834F
			public unsafe static Func<WormPlaymat, Entity> __9__1_18
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_18, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_18, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001295 RID: 4757
			// (get) Token: 0x06004C30 RID: 19504 RVA: 0x0019B878 File Offset: 0x00199A78
			// (set) Token: 0x06004C31 RID: 19505 RVA: 0x0001A161 File Offset: 0x00018361
			public unsafe static Func<WormTechTileStack, bool> __9__1_32
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_32, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormTechTileStack, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_32, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001296 RID: 4758
			// (get) Token: 0x06004C32 RID: 19506 RVA: 0x0019B8A0 File Offset: 0x00199AA0
			// (set) Token: 0x06004C33 RID: 19507 RVA: 0x0001A173 File Offset: 0x00018373
			public unsafe static Func<Entity, bool> __9__1_34
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_34, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_34, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001297 RID: 4759
			// (get) Token: 0x06004C34 RID: 19508 RVA: 0x0019B8C8 File Offset: 0x00199AC8
			// (set) Token: 0x06004C35 RID: 19509 RVA: 0x0001A185 File Offset: 0x00018385
			public unsafe static Func<WormTechTileStack, Entity> __9__1_33
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_33, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormTechTileStack, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_33, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001298 RID: 4760
			// (get) Token: 0x06004C36 RID: 19510 RVA: 0x0019B8F0 File Offset: 0x00199AF0
			// (set) Token: 0x06004C37 RID: 19511 RVA: 0x0001A197 File Offset: 0x00018397
			public unsafe static Func<Context, Il2CppReferenceArray<Entity>> __9__1_19
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_19, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Context, Il2CppReferenceArray<Entity>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_19, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001299 RID: 4761
			// (get) Token: 0x06004C38 RID: 19512 RVA: 0x0019B918 File Offset: 0x00199B18
			// (set) Token: 0x06004C39 RID: 19513 RVA: 0x0001A1A9 File Offset: 0x000183A9
			public unsafe static Func<WormTechTileStack, bool> __9__1_35
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_35, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormTechTileStack, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_35, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700129A RID: 4762
			// (get) Token: 0x06004C3A RID: 19514 RVA: 0x0019B940 File Offset: 0x00199B40
			// (set) Token: 0x06004C3B RID: 19515 RVA: 0x0001A1BB File Offset: 0x000183BB
			public unsafe static Func<Context, Entity> __9__1_22
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_22, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Context, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_22, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700129B RID: 4763
			// (get) Token: 0x06004C3C RID: 19516 RVA: 0x0019B968 File Offset: 0x00199B68
			// (set) Token: 0x06004C3D RID: 19517 RVA: 0x0001A1CD File Offset: 0x000183CD
			public unsafe static Func<WormTechTileStack, bool> __9__1_36
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_36, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormTechTileStack, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_36, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700129C RID: 4764
			// (get) Token: 0x06004C3E RID: 19518 RVA: 0x0019B990 File Offset: 0x00199B90
			// (set) Token: 0x06004C3F RID: 19519 RVA: 0x0001A1DF File Offset: 0x000183DF
			public unsafe static Func<Context, Entity> __9__1_23
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_23, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Context, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_23, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700129D RID: 4765
			// (get) Token: 0x06004C40 RID: 19520 RVA: 0x0019B9B8 File Offset: 0x00199BB8
			// (set) Token: 0x06004C41 RID: 19521 RVA: 0x0001A1F1 File Offset: 0x000183F1
			public unsafe static Func<Entity, bool> __9__1_37
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_37, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_37, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700129E RID: 4766
			// (get) Token: 0x06004C42 RID: 19522 RVA: 0x0019B9E0 File Offset: 0x00199BE0
			// (set) Token: 0x06004C43 RID: 19523 RVA: 0x0001A203 File Offset: 0x00018403
			public unsafe static Func<Entity, bool> __9__1_38
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_38, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__1_38, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700129F RID: 4767
			// (get) Token: 0x06004C44 RID: 19524 RVA: 0x0019BA08 File Offset: 0x00199C08
			// (set) Token: 0x06004C45 RID: 19525 RVA: 0x0001A215 File Offset: 0x00018415
			public unsafe static Func<Objective, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Objective, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012A0 RID: 4768
			// (get) Token: 0x06004C46 RID: 19526 RVA: 0x0019BA30 File Offset: 0x00199C30
			// (set) Token: 0x06004C47 RID: 19527 RVA: 0x0001A227 File Offset: 0x00018427
			public unsafe static Func<Objective, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Objective, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012A1 RID: 4769
			// (get) Token: 0x06004C48 RID: 19528 RVA: 0x0019BA58 File Offset: 0x00199C58
			// (set) Token: 0x06004C49 RID: 19529 RVA: 0x0001A239 File Offset: 0x00018439
			public unsafe static Func<WormPlayer, bool> __9__3_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012A2 RID: 4770
			// (get) Token: 0x06004C4A RID: 19530 RVA: 0x0019BA80 File Offset: 0x00199C80
			// (set) Token: 0x06004C4B RID: 19531 RVA: 0x0001A24B File Offset: 0x0001844B
			public unsafe static Func<Objective, bool> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Objective, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012A3 RID: 4771
			// (get) Token: 0x06004C4C RID: 19532 RVA: 0x0019BAA8 File Offset: 0x00199CA8
			// (set) Token: 0x06004C4D RID: 19533 RVA: 0x0001A25D File Offset: 0x0001845D
			public unsafe static Func<WormPlayer, bool> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012A4 RID: 4772
			// (get) Token: 0x06004C4E RID: 19534 RVA: 0x0019BAD0 File Offset: 0x00199CD0
			// (set) Token: 0x06004C4F RID: 19535 RVA: 0x0001A26F File Offset: 0x0001846F
			public unsafe static Func<Objective, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Objective, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012A5 RID: 4773
			// (get) Token: 0x06004C50 RID: 19536 RVA: 0x0019BAF8 File Offset: 0x00199CF8
			// (set) Token: 0x06004C51 RID: 19537 RVA: 0x0001A281 File Offset: 0x00018481
			public unsafe static Func<WormPlayer, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012A6 RID: 4774
			// (get) Token: 0x06004C52 RID: 19538 RVA: 0x0019BB20 File Offset: 0x00199D20
			// (set) Token: 0x06004C53 RID: 19539 RVA: 0x0001A293 File Offset: 0x00018493
			public unsafe static Func<WormPlayer, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012A7 RID: 4775
			// (get) Token: 0x06004C54 RID: 19540 RVA: 0x0019BB48 File Offset: 0x00199D48
			// (set) Token: 0x06004C55 RID: 19541 RVA: 0x0001A2A5 File Offset: 0x000184A5
			public unsafe static Func<WormPlayer, bool> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012A8 RID: 4776
			// (get) Token: 0x06004C56 RID: 19542 RVA: 0x0019BB70 File Offset: 0x00199D70
			// (set) Token: 0x06004C57 RID: 19543 RVA: 0x0001A2B7 File Offset: 0x000184B7
			public unsafe static Func<WormPlayer, bool> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012A9 RID: 4777
			// (get) Token: 0x06004C58 RID: 19544 RVA: 0x0019BB98 File Offset: 0x00199D98
			// (set) Token: 0x06004C59 RID: 19545 RVA: 0x0001A2C9 File Offset: 0x000184C9
			public unsafe static Func<Objective, bool> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Objective, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012AA RID: 4778
			// (get) Token: 0x06004C5A RID: 19546 RVA: 0x0019BBC0 File Offset: 0x00199DC0
			// (set) Token: 0x06004C5B RID: 19547 RVA: 0x0001A2DB File Offset: 0x000184DB
			public unsafe static Func<Objective, bool> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Objective, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptROI.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040031E0 RID: 12768
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040031E1 RID: 12769
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x040031E2 RID: 12770
			private static readonly IntPtr NativeFieldInfoPtr___9__1_1;

			// Token: 0x040031E3 RID: 12771
			private static readonly IntPtr NativeFieldInfoPtr___9__1_3;

			// Token: 0x040031E4 RID: 12772
			private static readonly IntPtr NativeFieldInfoPtr___9__1_4;

			// Token: 0x040031E5 RID: 12773
			private static readonly IntPtr NativeFieldInfoPtr___9__1_30;

			// Token: 0x040031E6 RID: 12774
			private static readonly IntPtr NativeFieldInfoPtr___9__1_31;

			// Token: 0x040031E7 RID: 12775
			private static readonly IntPtr NativeFieldInfoPtr___9__1_7;

			// Token: 0x040031E8 RID: 12776
			private static readonly IntPtr NativeFieldInfoPtr___9__1_8;

			// Token: 0x040031E9 RID: 12777
			private static readonly IntPtr NativeFieldInfoPtr___9__1_9;

			// Token: 0x040031EA RID: 12778
			private static readonly IntPtr NativeFieldInfoPtr___9__1_10;

			// Token: 0x040031EB RID: 12779
			private static readonly IntPtr NativeFieldInfoPtr___9__1_18;

			// Token: 0x040031EC RID: 12780
			private static readonly IntPtr NativeFieldInfoPtr___9__1_32;

			// Token: 0x040031ED RID: 12781
			private static readonly IntPtr NativeFieldInfoPtr___9__1_34;

			// Token: 0x040031EE RID: 12782
			private static readonly IntPtr NativeFieldInfoPtr___9__1_33;

			// Token: 0x040031EF RID: 12783
			private static readonly IntPtr NativeFieldInfoPtr___9__1_19;

			// Token: 0x040031F0 RID: 12784
			private static readonly IntPtr NativeFieldInfoPtr___9__1_35;

			// Token: 0x040031F1 RID: 12785
			private static readonly IntPtr NativeFieldInfoPtr___9__1_22;

			// Token: 0x040031F2 RID: 12786
			private static readonly IntPtr NativeFieldInfoPtr___9__1_36;

			// Token: 0x040031F3 RID: 12787
			private static readonly IntPtr NativeFieldInfoPtr___9__1_23;

			// Token: 0x040031F4 RID: 12788
			private static readonly IntPtr NativeFieldInfoPtr___9__1_37;

			// Token: 0x040031F5 RID: 12789
			private static readonly IntPtr NativeFieldInfoPtr___9__1_38;

			// Token: 0x040031F6 RID: 12790
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x040031F7 RID: 12791
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x040031F8 RID: 12792
			private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

			// Token: 0x040031F9 RID: 12793
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x040031FA RID: 12794
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x040031FB RID: 12795
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x040031FC RID: 12796
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x040031FD RID: 12797
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x040031FE RID: 12798
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x040031FF RID: 12799
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04003200 RID: 12800
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04003201 RID: 12801
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04003202 RID: 12802
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003203 RID: 12803
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x04003204 RID: 12804
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_1_Internal_Boolean_WormPlayer_0;

			// Token: 0x04003205 RID: 12805
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_3_Internal_Entity_WormPlaymat_0;

			// Token: 0x04003206 RID: 12806
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_4_Internal_Entity_WormPlaymat_0;

			// Token: 0x04003207 RID: 12807
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_30_Internal_Boolean_Entity_0;

			// Token: 0x04003208 RID: 12808
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_31_Internal_Boolean_Entity_0;

			// Token: 0x04003209 RID: 12809
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_7_Internal_Entity_WormPlaymat_0;

			// Token: 0x0400320A RID: 12810
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_8_Internal_Entity_WormPlaymat_0;

			// Token: 0x0400320B RID: 12811
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_9_Internal_Entity_WormPlaymat_0;

			// Token: 0x0400320C RID: 12812
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_10_Internal_Entity_WormPlaymat_0;

			// Token: 0x0400320D RID: 12813
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_18_Internal_Entity_WormPlaymat_0;

			// Token: 0x0400320E RID: 12814
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_19_Internal_Il2CppReferenceArray_1_Entity_Context_0;

			// Token: 0x0400320F RID: 12815
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_32_Internal_Boolean_WormTechTileStack_0;

			// Token: 0x04003210 RID: 12816
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_33_Internal_Entity_WormTechTileStack_0;

			// Token: 0x04003211 RID: 12817
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_34_Internal_Boolean_Entity_0;

			// Token: 0x04003212 RID: 12818
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_22_Internal_Entity_Context_0;

			// Token: 0x04003213 RID: 12819
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_35_Internal_Boolean_WormTechTileStack_0;

			// Token: 0x04003214 RID: 12820
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_23_Internal_Entity_Context_0;

			// Token: 0x04003215 RID: 12821
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_36_Internal_Boolean_WormTechTileStack_0;

			// Token: 0x04003216 RID: 12822
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_37_Internal_Boolean_Entity_0;

			// Token: 0x04003217 RID: 12823
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_38_Internal_Boolean_Entity_0;

			// Token: 0x04003218 RID: 12824
			private static readonly IntPtr NativeMethodInfoPtr__HoldAI_b__2_0_Internal_Boolean_Objective_0;

			// Token: 0x04003219 RID: 12825
			private static readonly IntPtr NativeMethodInfoPtr__HumanShippingTrackUndo_b__3_0_Internal_Boolean_Objective_0;

			// Token: 0x0400321A RID: 12826
			private static readonly IntPtr NativeMethodInfoPtr__HumanShippingTrackUndo_b__3_1_Internal_Boolean_WormPlayer_0;

			// Token: 0x0400321B RID: 12827
			private static readonly IntPtr NativeMethodInfoPtr__HumanShippingTrackRedo_b__4_0_Internal_Boolean_Objective_0;

			// Token: 0x0400321C RID: 12828
			private static readonly IntPtr NativeMethodInfoPtr__HumanShippingTrackRedo_b__4_1_Internal_Boolean_WormPlayer_0;

			// Token: 0x0400321D RID: 12829
			private static readonly IntPtr NativeMethodInfoPtr__ShippingCompleted_b__5_0_Internal_Boolean_Objective_0;

			// Token: 0x0400321E RID: 12830
			private static readonly IntPtr NativeMethodInfoPtr__ThreeShippingAbilities_b__6_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x0400321F RID: 12831
			private static readonly IntPtr NativeMethodInfoPtr__TwoShippingAbilities_b__7_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x04003220 RID: 12832
			private static readonly IntPtr NativeMethodInfoPtr__OneShippingAbility_b__8_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x04003221 RID: 12833
			private static readonly IntPtr NativeMethodInfoPtr__TechAcquired_b__9_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x04003222 RID: 12834
			private static readonly IntPtr NativeMethodInfoPtr__DreadnoughtActive_b__10_0_Internal_Boolean_Objective_0;

			// Token: 0x04003223 RID: 12835
			private static readonly IntPtr NativeMethodInfoPtr__ControlActive_b__11_0_Internal_Boolean_Objective_0;
		}

		// Token: 0x020005F9 RID: 1529
		[ObfuscatedName("worm.canis.data.Tutorial.WormTutorialScriptROI+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06004C5C RID: 19548 RVA: 0x0019BBE8 File Offset: 0x00199DE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<WormTutorialScriptROI.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTutorialScriptROI>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialScriptROI.__c__DisplayClass1_0>.NativeClassPtr);
				WormTutorialScriptROI.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c__DisplayClass1_0>.NativeClassPtr, "<>4__this");
				WormTutorialScriptROI.__c__DisplayClass1_0.NativeFieldInfoPtr_humanPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptROI.__c__DisplayClass1_0>.NativeClassPtr, "humanPlayer");
				WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c__DisplayClass1_0>.NativeClassPtr, 100665134);
				WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__2_Internal_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c__DisplayClass1_0>.NativeClassPtr, 100665135);
				WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__5_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c__DisplayClass1_0>.NativeClassPtr, 100665136);
				WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__6_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c__DisplayClass1_0>.NativeClassPtr, 100665137);
				WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__11_Internal_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c__DisplayClass1_0>.NativeClassPtr, 100665138);
				WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__12_Internal_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c__DisplayClass1_0>.NativeClassPtr, 100665139);
				WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__13_Internal_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c__DisplayClass1_0>.NativeClassPtr, 100665140);
				WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__14_Internal_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c__DisplayClass1_0>.NativeClassPtr, 100665141);
				WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__15_Internal_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c__DisplayClass1_0>.NativeClassPtr, 100665142);
				WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__16_Internal_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c__DisplayClass1_0>.NativeClassPtr, 100665143);
				WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__17_Internal_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c__DisplayClass1_0>.NativeClassPtr, 100665144);
				WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__20_Internal_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c__DisplayClass1_0>.NativeClassPtr, 100665145);
				WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__21_Internal_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c__DisplayClass1_0>.NativeClassPtr, 100665146);
				WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__24_Internal_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c__DisplayClass1_0>.NativeClassPtr, 100665147);
				WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__25_Internal_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c__DisplayClass1_0>.NativeClassPtr, 100665148);
				WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__26_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c__DisplayClass1_0>.NativeClassPtr, 100665149);
				WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__27_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c__DisplayClass1_0>.NativeClassPtr, 100665150);
				WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__28_Internal_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c__DisplayClass1_0>.NativeClassPtr, 100665151);
				WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__29_Internal_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptROI.__c__DisplayClass1_0>.NativeClassPtr, 100665152);
			}

			// Token: 0x06004C5D RID: 19549 RVA: 0x0019BDB8 File Offset: 0x00199FB8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialScriptROI.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004C5E RID: 19550 RVA: 0x0019BDF4 File Offset: 0x00199FF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67880, XrefRangeEnd = 67908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__2(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__2_Internal_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C5F RID: 19551 RVA: 0x0019BE44 File Offset: 0x0019A044
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67908, XrefRangeEnd = 67927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__5(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__5_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004C60 RID: 19552 RVA: 0x0019BE94 File Offset: 0x0019A094
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67927, XrefRangeEnd = 67946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__6(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__6_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004C61 RID: 19553 RVA: 0x0019BEE4 File Offset: 0x0019A0E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67946, XrefRangeEnd = 67948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__11(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__11_Internal_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C62 RID: 19554 RVA: 0x0019BF34 File Offset: 0x0019A134
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__12(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__12_Internal_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C63 RID: 19555 RVA: 0x0019BF84 File Offset: 0x0019A184
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67948, XrefRangeEnd = 67949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__13(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__13_Internal_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C64 RID: 19556 RVA: 0x0019BFD4 File Offset: 0x0019A1D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__14(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__14_Internal_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C65 RID: 19557 RVA: 0x0019C024 File Offset: 0x0019A224
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67949, XrefRangeEnd = 67951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__15(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__15_Internal_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C66 RID: 19558 RVA: 0x0019C074 File Offset: 0x0019A274
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__16(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__16_Internal_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C67 RID: 19559 RVA: 0x0019C0C4 File Offset: 0x0019A2C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67951, XrefRangeEnd = 67953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__17(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__17_Internal_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C68 RID: 19560 RVA: 0x0019C114 File Offset: 0x0019A314
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__20(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__20_Internal_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C69 RID: 19561 RVA: 0x0019C164 File Offset: 0x0019A364
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__21(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__21_Internal_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C6A RID: 19562 RVA: 0x0019C1B4 File Offset: 0x0019A3B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__24(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__24_Internal_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C6B RID: 19563 RVA: 0x0019C204 File Offset: 0x0019A404
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67953, XrefRangeEnd = 67960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__25(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__25_Internal_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C6C RID: 19564 RVA: 0x0019C254 File Offset: 0x0019A454
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67960, XrefRangeEnd = 67979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__26(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__26_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004C6D RID: 19565 RVA: 0x0019C2A4 File Offset: 0x0019A4A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67979, XrefRangeEnd = 67998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__27(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__27_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004C6E RID: 19566 RVA: 0x0019C2F4 File Offset: 0x0019A4F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67998, XrefRangeEnd = 67999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__28(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__28_Internal_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C6F RID: 19567 RVA: 0x0019C344 File Offset: 0x0019A544
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67999, XrefRangeEnd = 68001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__29(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptROI.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__29_Internal_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004C70 RID: 19568 RVA: 0x0001A2ED File Offset: 0x000184ED
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012AB RID: 4779
			// (get) Token: 0x06004C71 RID: 19569 RVA: 0x0019C394 File Offset: 0x0019A594
			// (set) Token: 0x06004C72 RID: 19570 RVA: 0x0001A2F6 File Offset: 0x000184F6
			public unsafe WormTutorialScriptROI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScriptROI.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTutorialScriptROI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScriptROI.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012AC RID: 4780
			// (get) Token: 0x06004C73 RID: 19571 RVA: 0x0019C3C4 File Offset: 0x0019A5C4
			// (set) Token: 0x06004C74 RID: 19572 RVA: 0x0001A315 File Offset: 0x00018515
			public unsafe WormPlayer humanPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScriptROI.__c__DisplayClass1_0.NativeFieldInfoPtr_humanPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScriptROI.__c__DisplayClass1_0.NativeFieldInfoPtr_humanPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003224 RID: 12836
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003225 RID: 12837
			private static readonly IntPtr NativeFieldInfoPtr_humanPlayer;

			// Token: 0x04003226 RID: 12838
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003227 RID: 12839
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__2_Internal_Boolean_Context_0;

			// Token: 0x04003228 RID: 12840
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__5_Internal_Entity_Context_0;

			// Token: 0x04003229 RID: 12841
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__6_Internal_Entity_Context_0;

			// Token: 0x0400322A RID: 12842
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__11_Internal_Boolean_Context_0;

			// Token: 0x0400322B RID: 12843
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__12_Internal_Boolean_Context_0;

			// Token: 0x0400322C RID: 12844
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__13_Internal_Boolean_Context_0;

			// Token: 0x0400322D RID: 12845
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__14_Internal_Boolean_Context_0;

			// Token: 0x0400322E RID: 12846
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__15_Internal_Boolean_Context_0;

			// Token: 0x0400322F RID: 12847
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__16_Internal_Boolean_Context_0;

			// Token: 0x04003230 RID: 12848
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__17_Internal_Boolean_Context_0;

			// Token: 0x04003231 RID: 12849
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__20_Internal_Boolean_Context_0;

			// Token: 0x04003232 RID: 12850
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__21_Internal_Boolean_Context_0;

			// Token: 0x04003233 RID: 12851
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__24_Internal_Boolean_Context_0;

			// Token: 0x04003234 RID: 12852
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__25_Internal_Boolean_Context_0;

			// Token: 0x04003235 RID: 12853
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__26_Internal_Entity_Context_0;

			// Token: 0x04003236 RID: 12854
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__27_Internal_Entity_Context_0;

			// Token: 0x04003237 RID: 12855
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__28_Internal_Boolean_Context_0;

			// Token: 0x04003238 RID: 12856
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__29_Internal_Boolean_Context_0;
		}
	}
}
