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
	// Token: 0x0200004C RID: 76
	public class WormTutorialScriptIMMO : WormTutorialScript
	{
		// Token: 0x06000A80 RID: 2688 RVA: 0x000897B4 File Offset: 0x000879B4
		// Note: this type is marked as 'beforefieldinit'.
		static WormTutorialScriptIMMO()
		{
			Il2CppClassPointerStore<WormTutorialScriptIMMO>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Tutorial", "WormTutorialScriptIMMO");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialScriptIMMO>.NativeClassPtr);
			WormTutorialScriptIMMO.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO>.NativeClassPtr, 100665000);
			WormTutorialScriptIMMO.NativeMethodInfoPtr_tutorialItems_Protected_Virtual_IEnumerable_1_TutorialItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO>.NativeClassPtr, 100665001);
			WormTutorialScriptIMMO.NativeMethodInfoPtr_HoldAI_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO>.NativeClassPtr, 100665002);
			WormTutorialScriptIMMO.NativeMethodInfoPtr_CompleteActive_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO>.NativeClassPtr, 100665003);
			WormTutorialScriptIMMO.NativeMethodInfoPtr_HumanHasSpecimens_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO>.NativeClassPtr, 100665004);
			WormTutorialScriptIMMO.NativeMethodInfoPtr_HumanResearchCount1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO>.NativeClassPtr, 100665005);
			WormTutorialScriptIMMO.NativeMethodInfoPtr_HumanResearchCount2_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO>.NativeClassPtr, 100665006);
			WormTutorialScriptIMMO.NativeMethodInfoPtr_Check5VPScore_Private_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO>.NativeClassPtr, 100665007);
			WormTutorialScriptIMMO.NativeMethodInfoPtr_AcquiredContaminator_Private_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO>.NativeClassPtr, 100665008);
			WormTutorialScriptIMMO.NativeMethodInfoPtr_AcquiredPairedCoupling_Private_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO>.NativeClassPtr, 100665009);
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x000898AC File Offset: 0x00087AAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54376, RefRangeEnd = 54377, XrefRangeStart = 54376, XrefRangeEnd = 54377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTutorialScriptIMMO(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialScriptIMMO>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x000898F8 File Offset: 0x00087AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64284, XrefRangeEnd = 67530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<AdvancedTutorialScript.TutorialItem> tutorialItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTutorialScriptIMMO.NativeMethodInfoPtr_tutorialItems_Protected_Virtual_IEnumerable_1_TutorialItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AdvancedTutorialScript.TutorialItem>>(intPtr3) : null;
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x00089944 File Offset: 0x00087B44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 67558, RefRangeEnd = 67559, XrefRangeStart = 67530, XrefRangeEnd = 67558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HoldAI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.NativeMethodInfoPtr_HoldAI_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x00089980 File Offset: 0x00087B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67559, XrefRangeEnd = 67587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CompleteActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.NativeMethodInfoPtr_CompleteActive_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x000899BC File Offset: 0x00087BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67587, XrefRangeEnd = 67611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HumanHasSpecimens()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.NativeMethodInfoPtr_HumanHasSpecimens_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x000899F8 File Offset: 0x00087BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67611, XrefRangeEnd = 67637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HumanResearchCount1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.NativeMethodInfoPtr_HumanResearchCount1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x00089A34 File Offset: 0x00087C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67637, XrefRangeEnd = 67663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HumanResearchCount2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.NativeMethodInfoPtr_HumanResearchCount2_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x00089A70 File Offset: 0x00087C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67663, XrefRangeEnd = 67684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Check5VPScore(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.NativeMethodInfoPtr_Check5VPScore_Private_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00089AC0 File Offset: 0x00087CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67684, XrefRangeEnd = 67688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AcquiredContaminator(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.NativeMethodInfoPtr_AcquiredContaminator_Private_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x00089B10 File Offset: 0x00087D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67688, XrefRangeEnd = 67692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AcquiredPairedCoupling(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.NativeMethodInfoPtr_AcquiredPairedCoupling_Private_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x00006B98 File Offset: 0x00004D98
		public WormTutorialScriptIMMO(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400068B RID: 1675
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x0400068C RID: 1676
		private static readonly IntPtr NativeMethodInfoPtr_tutorialItems_Protected_Virtual_IEnumerable_1_TutorialItem_0;

		// Token: 0x0400068D RID: 1677
		private static readonly IntPtr NativeMethodInfoPtr_HoldAI_Private_Boolean_0;

		// Token: 0x0400068E RID: 1678
		private static readonly IntPtr NativeMethodInfoPtr_CompleteActive_Private_Boolean_0;

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeMethodInfoPtr_HumanHasSpecimens_Private_Boolean_0;

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeMethodInfoPtr_HumanResearchCount1_Private_Boolean_0;

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeMethodInfoPtr_HumanResearchCount2_Private_Boolean_0;

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeMethodInfoPtr_Check5VPScore_Private_Boolean_Context_0;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeMethodInfoPtr_AcquiredContaminator_Private_Boolean_Context_0;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeMethodInfoPtr_AcquiredPairedCoupling_Private_Boolean_Context_0;

		// Token: 0x020005F5 RID: 1525
		[ObfuscatedName("worm.canis.data.Tutorial.WormTutorialScriptIMMO+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06004B36 RID: 19254 RVA: 0x00197C04 File Offset: 0x00195E04
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTutorialScriptIMMO>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr);
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_0");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_1");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_39 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_39");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_40 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_40");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_6");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_7");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_8");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_41 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_41");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_42 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_42");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_12");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_13");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_14");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_15");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_44 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_44");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_17");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_45 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_45");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_18");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_46 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_46");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_19");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_47 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_47");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_20");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_48 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_48");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_49 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_49");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_50 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_50");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_51 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_51");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_52 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_52");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_54 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_54");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_55 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_55");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_56 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_56");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_57 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_57");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_58 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_58");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_59 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_59");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_60 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_60");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_61 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_61");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_63 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_63");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_35 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_35");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_64");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_36 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_36");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_65 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_65");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_37 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_37");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_66 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_66");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_38 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__1_38");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__2_0");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__3_0");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__4_0");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__5_0");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__6_0");
				WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, "<>9__7_0");
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665011);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665012);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_1_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665013);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_39_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665014);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_40_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665015);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_6_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665016);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_7_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665017);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_8_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665018);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_41_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665019);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_42_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665020);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_12_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665021);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_13_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665022);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_14_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665023);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_15_Internal_Il2CppReferenceArray_1_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665024);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_17_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665025);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_44_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665026);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_18_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665027);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_45_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665028);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_19_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665029);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_46_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665030);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_20_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665031);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_47_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665032);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_48_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665033);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_49_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665034);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_50_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665035);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_51_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665036);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_52_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665037);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_54_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665038);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_55_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665039);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_56_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665040);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_57_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665041);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_58_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665042);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_59_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665043);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_60_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665044);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_61_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665045);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_63_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665046);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_35_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665047);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_36_Internal_Il2CppReferenceArray_1_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665048);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_64_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665049);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_37_Internal_Il2CppReferenceArray_1_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665050);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_65_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665051);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_38_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665052);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_66_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665053);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__HoldAI_b__2_0_Internal_Boolean_Objective_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665054);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__CompleteActive_b__3_0_Internal_Boolean_Objective_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665055);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__HumanHasSpecimens_b__4_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665056);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__HumanResearchCount1_b__5_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665057);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__HumanResearchCount2_b__6_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665058);
				WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__Check5VPScore_b__7_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr, 100665059);
			}

			// Token: 0x06004B37 RID: 19255 RVA: 0x001983D8 File Offset: 0x001965D8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B38 RID: 19256 RVA: 0x00198414 File Offset: 0x00196614
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B39 RID: 19257 RVA: 0x00198464 File Offset: 0x00196664
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_1_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B3A RID: 19258 RVA: 0x001984B4 File Offset: 0x001966B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63558, XrefRangeEnd = 63563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_39(Entity ent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_39_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B3B RID: 19259 RVA: 0x00198504 File Offset: 0x00196704
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63563, XrefRangeEnd = 63568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_40(Entity ent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_40_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B3C RID: 19260 RVA: 0x00198554 File Offset: 0x00196754
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63568, XrefRangeEnd = 63570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__1_6(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_6_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004B3D RID: 19261 RVA: 0x001985A4 File Offset: 0x001967A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__1_7(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_7_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004B3E RID: 19262 RVA: 0x001985F4 File Offset: 0x001967F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__1_8(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_8_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004B3F RID: 19263 RVA: 0x00198644 File Offset: 0x00196844
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63570, XrefRangeEnd = 63575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_41(Entity ent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_41_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B40 RID: 19264 RVA: 0x00198694 File Offset: 0x00196894
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63575, XrefRangeEnd = 63580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_42(Entity ent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_42_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B41 RID: 19265 RVA: 0x001986E4 File Offset: 0x001968E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63580, XrefRangeEnd = 63582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__1_12(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_12_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004B42 RID: 19266 RVA: 0x00198734 File Offset: 0x00196934
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__1_13(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_13_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004B43 RID: 19267 RVA: 0x00198784 File Offset: 0x00196984
			[CallerCount(0)]
			public unsafe Entity _tutorialItems_b__1_14(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_14_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004B44 RID: 19268 RVA: 0x001987D4 File Offset: 0x001969D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63582, XrefRangeEnd = 63610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<Entity> _tutorialItems_b__1_15(Context context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_15_Internal_Il2CppReferenceArray_1_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x06004B45 RID: 19269 RVA: 0x00198824 File Offset: 0x00196A24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63610, XrefRangeEnd = 63629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__1_17(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_17_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004B46 RID: 19270 RVA: 0x00198874 File Offset: 0x00196A74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63629, XrefRangeEnd = 63634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_44(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_44_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B47 RID: 19271 RVA: 0x001988C4 File Offset: 0x00196AC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63634, XrefRangeEnd = 63653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__1_18(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_18_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004B48 RID: 19272 RVA: 0x00198914 File Offset: 0x00196B14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63653, XrefRangeEnd = 63658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_45(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_45_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B49 RID: 19273 RVA: 0x00198964 File Offset: 0x00196B64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63658, XrefRangeEnd = 63677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__1_19(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_19_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004B4A RID: 19274 RVA: 0x001989B4 File Offset: 0x00196BB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63677, XrefRangeEnd = 63686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_46(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_46_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B4B RID: 19275 RVA: 0x00198A04 File Offset: 0x00196C04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63686, XrefRangeEnd = 63705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__1_20(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_20_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004B4C RID: 19276 RVA: 0x00198A54 File Offset: 0x00196C54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63705, XrefRangeEnd = 63714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_47(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_47_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B4D RID: 19277 RVA: 0x00198AA4 File Offset: 0x00196CA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63714, XrefRangeEnd = 63719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_48(Entity ent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_48_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B4E RID: 19278 RVA: 0x00198AF4 File Offset: 0x00196CF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63719, XrefRangeEnd = 63724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_49(Entity ent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_49_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B4F RID: 19279 RVA: 0x00198B44 File Offset: 0x00196D44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63724, XrefRangeEnd = 63729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_50(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_50_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B50 RID: 19280 RVA: 0x00198B94 File Offset: 0x00196D94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63729, XrefRangeEnd = 63734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_51(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_51_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B51 RID: 19281 RVA: 0x00198BE4 File Offset: 0x00196DE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63734, XrefRangeEnd = 63739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_52(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_52_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B52 RID: 19282 RVA: 0x00198C34 File Offset: 0x00196E34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63739, XrefRangeEnd = 63744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_54(Entity c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_54_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B53 RID: 19283 RVA: 0x00198C84 File Offset: 0x00196E84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63744, XrefRangeEnd = 63749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_55(Entity ent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_55_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B54 RID: 19284 RVA: 0x00198CD4 File Offset: 0x00196ED4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63749, XrefRangeEnd = 63754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_56(Entity ent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_56_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B55 RID: 19285 RVA: 0x00198D24 File Offset: 0x00196F24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63754, XrefRangeEnd = 63759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_57(Entity ent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_57_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B56 RID: 19286 RVA: 0x00198D74 File Offset: 0x00196F74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63759, XrefRangeEnd = 63764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_58(Entity ent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_58_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B57 RID: 19287 RVA: 0x00198DC4 File Offset: 0x00196FC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63764, XrefRangeEnd = 63769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_59(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_59_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B58 RID: 19288 RVA: 0x00198E14 File Offset: 0x00197014
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63769, XrefRangeEnd = 63774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_60(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_60_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B59 RID: 19289 RVA: 0x00198E64 File Offset: 0x00197064
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63774, XrefRangeEnd = 63779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_61(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_61_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B5A RID: 19290 RVA: 0x00198EB4 File Offset: 0x001970B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63779, XrefRangeEnd = 63784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_63(Entity c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_63_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B5B RID: 19291 RVA: 0x00198F04 File Offset: 0x00197104
			[CallerCount(0)]
			public unsafe Entity _tutorialItems_b__1_35(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_35_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004B5C RID: 19292 RVA: 0x00198F54 File Offset: 0x00197154
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63784, XrefRangeEnd = 63811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<Entity> _tutorialItems_b__1_36(Context context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_36_Internal_Il2CppReferenceArray_1_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x06004B5D RID: 19293 RVA: 0x00198FA4 File Offset: 0x001971A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63811, XrefRangeEnd = 63818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_64(WormSpace space)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(space);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_64_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B5E RID: 19294 RVA: 0x00198FF4 File Offset: 0x001971F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63818, XrefRangeEnd = 63845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<Entity> _tutorialItems_b__1_37(Context context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_37_Internal_Il2CppReferenceArray_1_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x06004B5F RID: 19295 RVA: 0x00199044 File Offset: 0x00197244
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63845, XrefRangeEnd = 63852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_65(WormSpace space)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(space);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_65_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B60 RID: 19296 RVA: 0x00199094 File Offset: 0x00197294
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63852, XrefRangeEnd = 63871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__1_38(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_38_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004B61 RID: 19297 RVA: 0x001990E4 File Offset: 0x001972E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63871, XrefRangeEnd = 63876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_66(Entity c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__tutorialItems_b__1_66_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B62 RID: 19298 RVA: 0x00199134 File Offset: 0x00197334
			[CallerCount(0)]
			public unsafe bool _HoldAI_b__2_0(Objective o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__HoldAI_b__2_0_Internal_Boolean_Objective_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B63 RID: 19299 RVA: 0x00199184 File Offset: 0x00197384
			[CallerCount(0)]
			public unsafe bool _CompleteActive_b__3_0(Objective o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__CompleteActive_b__3_0_Internal_Boolean_Objective_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B64 RID: 19300 RVA: 0x001991D4 File Offset: 0x001973D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HumanHasSpecimens_b__4_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__HumanHasSpecimens_b__4_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B65 RID: 19301 RVA: 0x00199224 File Offset: 0x00197424
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HumanResearchCount1_b__5_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__HumanResearchCount1_b__5_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B66 RID: 19302 RVA: 0x00199274 File Offset: 0x00197474
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HumanResearchCount2_b__6_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__HumanResearchCount2_b__6_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B67 RID: 19303 RVA: 0x001992C4 File Offset: 0x001974C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Check5VPScore_b__7_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c.NativeMethodInfoPtr__Check5VPScore_b__7_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B68 RID: 19304 RVA: 0x00019C58 File Offset: 0x00017E58
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001253 RID: 4691
			// (get) Token: 0x06004B69 RID: 19305 RVA: 0x00199314 File Offset: 0x00197514
			// (set) Token: 0x06004B6A RID: 19306 RVA: 0x00019C61 File Offset: 0x00017E61
			public unsafe static WormTutorialScriptIMMO.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTutorialScriptIMMO.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001254 RID: 4692
			// (get) Token: 0x06004B6B RID: 19307 RVA: 0x0019933C File Offset: 0x0019753C
			// (set) Token: 0x06004B6C RID: 19308 RVA: 0x00019C73 File Offset: 0x00017E73
			public unsafe static Func<WormPlayer, bool> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001255 RID: 4693
			// (get) Token: 0x06004B6D RID: 19309 RVA: 0x00199364 File Offset: 0x00197564
			// (set) Token: 0x06004B6E RID: 19310 RVA: 0x00019C85 File Offset: 0x00017E85
			public unsafe static Func<WormPlayer, bool> __9__1_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001256 RID: 4694
			// (get) Token: 0x06004B6F RID: 19311 RVA: 0x0019938C File Offset: 0x0019758C
			// (set) Token: 0x06004B70 RID: 19312 RVA: 0x00019C97 File Offset: 0x00017E97
			public unsafe static Func<Entity, bool> __9__1_39
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_39, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_39, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001257 RID: 4695
			// (get) Token: 0x06004B71 RID: 19313 RVA: 0x001993B4 File Offset: 0x001975B4
			// (set) Token: 0x06004B72 RID: 19314 RVA: 0x00019CA9 File Offset: 0x00017EA9
			public unsafe static Func<Entity, bool> __9__1_40
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_40, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_40, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001258 RID: 4696
			// (get) Token: 0x06004B73 RID: 19315 RVA: 0x001993DC File Offset: 0x001975DC
			// (set) Token: 0x06004B74 RID: 19316 RVA: 0x00019CBB File Offset: 0x00017EBB
			public unsafe static Func<WormPlaymat, Entity> __9__1_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001259 RID: 4697
			// (get) Token: 0x06004B75 RID: 19317 RVA: 0x00199404 File Offset: 0x00197604
			// (set) Token: 0x06004B76 RID: 19318 RVA: 0x00019CCD File Offset: 0x00017ECD
			public unsafe static Func<WormPlaymat, Entity> __9__1_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700125A RID: 4698
			// (get) Token: 0x06004B77 RID: 19319 RVA: 0x0019942C File Offset: 0x0019762C
			// (set) Token: 0x06004B78 RID: 19320 RVA: 0x00019CDF File Offset: 0x00017EDF
			public unsafe static Func<WormPlaymat, Entity> __9__1_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700125B RID: 4699
			// (get) Token: 0x06004B79 RID: 19321 RVA: 0x00199454 File Offset: 0x00197654
			// (set) Token: 0x06004B7A RID: 19322 RVA: 0x00019CF1 File Offset: 0x00017EF1
			public unsafe static Func<Entity, bool> __9__1_41
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_41, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_41, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700125C RID: 4700
			// (get) Token: 0x06004B7B RID: 19323 RVA: 0x0019947C File Offset: 0x0019767C
			// (set) Token: 0x06004B7C RID: 19324 RVA: 0x00019D03 File Offset: 0x00017F03
			public unsafe static Func<Entity, bool> __9__1_42
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_42, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_42, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700125D RID: 4701
			// (get) Token: 0x06004B7D RID: 19325 RVA: 0x001994A4 File Offset: 0x001976A4
			// (set) Token: 0x06004B7E RID: 19326 RVA: 0x00019D15 File Offset: 0x00017F15
			public unsafe static Func<WormPlaymat, Entity> __9__1_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700125E RID: 4702
			// (get) Token: 0x06004B7F RID: 19327 RVA: 0x001994CC File Offset: 0x001976CC
			// (set) Token: 0x06004B80 RID: 19328 RVA: 0x00019D27 File Offset: 0x00017F27
			public unsafe static Func<WormPlaymat, Entity> __9__1_13
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_13, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_13, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700125F RID: 4703
			// (get) Token: 0x06004B81 RID: 19329 RVA: 0x001994F4 File Offset: 0x001976F4
			// (set) Token: 0x06004B82 RID: 19330 RVA: 0x00019D39 File Offset: 0x00017F39
			public unsafe static Func<WormPlaymat, Entity> __9__1_14
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_14, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_14, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001260 RID: 4704
			// (get) Token: 0x06004B83 RID: 19331 RVA: 0x0019951C File Offset: 0x0019771C
			// (set) Token: 0x06004B84 RID: 19332 RVA: 0x00019D4B File Offset: 0x00017F4B
			public unsafe static Func<Context, Il2CppReferenceArray<Entity>> __9__1_15
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_15, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Context, Il2CppReferenceArray<Entity>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_15, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001261 RID: 4705
			// (get) Token: 0x06004B85 RID: 19333 RVA: 0x00199544 File Offset: 0x00197744
			// (set) Token: 0x06004B86 RID: 19334 RVA: 0x00019D5D File Offset: 0x00017F5D
			public unsafe static Func<Entity, bool> __9__1_44
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_44, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_44, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001262 RID: 4706
			// (get) Token: 0x06004B87 RID: 19335 RVA: 0x0019956C File Offset: 0x0019776C
			// (set) Token: 0x06004B88 RID: 19336 RVA: 0x00019D6F File Offset: 0x00017F6F
			public unsafe static Func<WormPlaymat, Entity> __9__1_17
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_17, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_17, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001263 RID: 4707
			// (get) Token: 0x06004B89 RID: 19337 RVA: 0x00199594 File Offset: 0x00197794
			// (set) Token: 0x06004B8A RID: 19338 RVA: 0x00019D81 File Offset: 0x00017F81
			public unsafe static Func<Entity, bool> __9__1_45
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_45, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_45, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001264 RID: 4708
			// (get) Token: 0x06004B8B RID: 19339 RVA: 0x001995BC File Offset: 0x001977BC
			// (set) Token: 0x06004B8C RID: 19340 RVA: 0x00019D93 File Offset: 0x00017F93
			public unsafe static Func<WormPlaymat, Entity> __9__1_18
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_18, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_18, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001265 RID: 4709
			// (get) Token: 0x06004B8D RID: 19341 RVA: 0x001995E4 File Offset: 0x001977E4
			// (set) Token: 0x06004B8E RID: 19342 RVA: 0x00019DA5 File Offset: 0x00017FA5
			public unsafe static Func<Entity, bool> __9__1_46
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_46, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_46, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001266 RID: 4710
			// (get) Token: 0x06004B8F RID: 19343 RVA: 0x0019960C File Offset: 0x0019780C
			// (set) Token: 0x06004B90 RID: 19344 RVA: 0x00019DB7 File Offset: 0x00017FB7
			public unsafe static Func<WormPlaymat, Entity> __9__1_19
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_19, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_19, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001267 RID: 4711
			// (get) Token: 0x06004B91 RID: 19345 RVA: 0x00199634 File Offset: 0x00197834
			// (set) Token: 0x06004B92 RID: 19346 RVA: 0x00019DC9 File Offset: 0x00017FC9
			public unsafe static Func<Entity, bool> __9__1_47
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_47, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_47, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001268 RID: 4712
			// (get) Token: 0x06004B93 RID: 19347 RVA: 0x0019965C File Offset: 0x0019785C
			// (set) Token: 0x06004B94 RID: 19348 RVA: 0x00019DDB File Offset: 0x00017FDB
			public unsafe static Func<WormPlaymat, Entity> __9__1_20
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_20, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_20, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001269 RID: 4713
			// (get) Token: 0x06004B95 RID: 19349 RVA: 0x00199684 File Offset: 0x00197884
			// (set) Token: 0x06004B96 RID: 19350 RVA: 0x00019DED File Offset: 0x00017FED
			public unsafe static Func<Entity, bool> __9__1_48
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_48, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_48, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700126A RID: 4714
			// (get) Token: 0x06004B97 RID: 19351 RVA: 0x001996AC File Offset: 0x001978AC
			// (set) Token: 0x06004B98 RID: 19352 RVA: 0x00019DFF File Offset: 0x00017FFF
			public unsafe static Func<Entity, bool> __9__1_49
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_49, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_49, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700126B RID: 4715
			// (get) Token: 0x06004B99 RID: 19353 RVA: 0x001996D4 File Offset: 0x001978D4
			// (set) Token: 0x06004B9A RID: 19354 RVA: 0x00019E11 File Offset: 0x00018011
			public unsafe static Func<Entity, bool> __9__1_50
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_50, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_50, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700126C RID: 4716
			// (get) Token: 0x06004B9B RID: 19355 RVA: 0x001996FC File Offset: 0x001978FC
			// (set) Token: 0x06004B9C RID: 19356 RVA: 0x00019E23 File Offset: 0x00018023
			public unsafe static Func<Entity, bool> __9__1_51
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_51, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_51, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700126D RID: 4717
			// (get) Token: 0x06004B9D RID: 19357 RVA: 0x00199724 File Offset: 0x00197924
			// (set) Token: 0x06004B9E RID: 19358 RVA: 0x00019E35 File Offset: 0x00018035
			public unsafe static Func<Entity, bool> __9__1_52
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_52, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_52, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700126E RID: 4718
			// (get) Token: 0x06004B9F RID: 19359 RVA: 0x0019974C File Offset: 0x0019794C
			// (set) Token: 0x06004BA0 RID: 19360 RVA: 0x00019E47 File Offset: 0x00018047
			public unsafe static Func<Entity, bool> __9__1_54
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_54, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_54, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700126F RID: 4719
			// (get) Token: 0x06004BA1 RID: 19361 RVA: 0x00199774 File Offset: 0x00197974
			// (set) Token: 0x06004BA2 RID: 19362 RVA: 0x00019E59 File Offset: 0x00018059
			public unsafe static Func<Entity, bool> __9__1_55
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_55, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_55, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001270 RID: 4720
			// (get) Token: 0x06004BA3 RID: 19363 RVA: 0x0019979C File Offset: 0x0019799C
			// (set) Token: 0x06004BA4 RID: 19364 RVA: 0x00019E6B File Offset: 0x0001806B
			public unsafe static Func<Entity, bool> __9__1_56
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_56, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_56, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001271 RID: 4721
			// (get) Token: 0x06004BA5 RID: 19365 RVA: 0x001997C4 File Offset: 0x001979C4
			// (set) Token: 0x06004BA6 RID: 19366 RVA: 0x00019E7D File Offset: 0x0001807D
			public unsafe static Func<Entity, bool> __9__1_57
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_57, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_57, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001272 RID: 4722
			// (get) Token: 0x06004BA7 RID: 19367 RVA: 0x001997EC File Offset: 0x001979EC
			// (set) Token: 0x06004BA8 RID: 19368 RVA: 0x00019E8F File Offset: 0x0001808F
			public unsafe static Func<Entity, bool> __9__1_58
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_58, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_58, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001273 RID: 4723
			// (get) Token: 0x06004BA9 RID: 19369 RVA: 0x00199814 File Offset: 0x00197A14
			// (set) Token: 0x06004BAA RID: 19370 RVA: 0x00019EA1 File Offset: 0x000180A1
			public unsafe static Func<Entity, bool> __9__1_59
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_59, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_59, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001274 RID: 4724
			// (get) Token: 0x06004BAB RID: 19371 RVA: 0x0019983C File Offset: 0x00197A3C
			// (set) Token: 0x06004BAC RID: 19372 RVA: 0x00019EB3 File Offset: 0x000180B3
			public unsafe static Func<Entity, bool> __9__1_60
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_60, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_60, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001275 RID: 4725
			// (get) Token: 0x06004BAD RID: 19373 RVA: 0x00199864 File Offset: 0x00197A64
			// (set) Token: 0x06004BAE RID: 19374 RVA: 0x00019EC5 File Offset: 0x000180C5
			public unsafe static Func<Entity, bool> __9__1_61
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_61, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_61, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001276 RID: 4726
			// (get) Token: 0x06004BAF RID: 19375 RVA: 0x0019988C File Offset: 0x00197A8C
			// (set) Token: 0x06004BB0 RID: 19376 RVA: 0x00019ED7 File Offset: 0x000180D7
			public unsafe static Func<Entity, bool> __9__1_63
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_63, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_63, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001277 RID: 4727
			// (get) Token: 0x06004BB1 RID: 19377 RVA: 0x001998B4 File Offset: 0x00197AB4
			// (set) Token: 0x06004BB2 RID: 19378 RVA: 0x00019EE9 File Offset: 0x000180E9
			public unsafe static Func<WormPlaymat, Entity> __9__1_35
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_35, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_35, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001278 RID: 4728
			// (get) Token: 0x06004BB3 RID: 19379 RVA: 0x001998DC File Offset: 0x00197ADC
			// (set) Token: 0x06004BB4 RID: 19380 RVA: 0x00019EFB File Offset: 0x000180FB
			public unsafe static Func<WormSpace, bool> __9__1_64
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_64, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormSpace, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_64, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001279 RID: 4729
			// (get) Token: 0x06004BB5 RID: 19381 RVA: 0x00199904 File Offset: 0x00197B04
			// (set) Token: 0x06004BB6 RID: 19382 RVA: 0x00019F0D File Offset: 0x0001810D
			public unsafe static Func<Context, Il2CppReferenceArray<Entity>> __9__1_36
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_36, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Context, Il2CppReferenceArray<Entity>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_36, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700127A RID: 4730
			// (get) Token: 0x06004BB7 RID: 19383 RVA: 0x0019992C File Offset: 0x00197B2C
			// (set) Token: 0x06004BB8 RID: 19384 RVA: 0x00019F1F File Offset: 0x0001811F
			public unsafe static Func<WormSpace, bool> __9__1_65
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_65, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormSpace, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_65, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700127B RID: 4731
			// (get) Token: 0x06004BB9 RID: 19385 RVA: 0x00199954 File Offset: 0x00197B54
			// (set) Token: 0x06004BBA RID: 19386 RVA: 0x00019F31 File Offset: 0x00018131
			public unsafe static Func<Context, Il2CppReferenceArray<Entity>> __9__1_37
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_37, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Context, Il2CppReferenceArray<Entity>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_37, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700127C RID: 4732
			// (get) Token: 0x06004BBB RID: 19387 RVA: 0x0019997C File Offset: 0x00197B7C
			// (set) Token: 0x06004BBC RID: 19388 RVA: 0x00019F43 File Offset: 0x00018143
			public unsafe static Func<Entity, bool> __9__1_66
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_66, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_66, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700127D RID: 4733
			// (get) Token: 0x06004BBD RID: 19389 RVA: 0x001999A4 File Offset: 0x00197BA4
			// (set) Token: 0x06004BBE RID: 19390 RVA: 0x00019F55 File Offset: 0x00018155
			public unsafe static Func<WormPlaymat, Entity> __9__1_38
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_38, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__1_38, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700127E RID: 4734
			// (get) Token: 0x06004BBF RID: 19391 RVA: 0x001999CC File Offset: 0x00197BCC
			// (set) Token: 0x06004BC0 RID: 19392 RVA: 0x00019F67 File Offset: 0x00018167
			public unsafe static Func<Objective, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Objective, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700127F RID: 4735
			// (get) Token: 0x06004BC1 RID: 19393 RVA: 0x001999F4 File Offset: 0x00197BF4
			// (set) Token: 0x06004BC2 RID: 19394 RVA: 0x00019F79 File Offset: 0x00018179
			public unsafe static Func<Objective, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Objective, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001280 RID: 4736
			// (get) Token: 0x06004BC3 RID: 19395 RVA: 0x00199A1C File Offset: 0x00197C1C
			// (set) Token: 0x06004BC4 RID: 19396 RVA: 0x00019F8B File Offset: 0x0001818B
			public unsafe static Func<WormPlayer, bool> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001281 RID: 4737
			// (get) Token: 0x06004BC5 RID: 19397 RVA: 0x00199A44 File Offset: 0x00197C44
			// (set) Token: 0x06004BC6 RID: 19398 RVA: 0x00019F9D File Offset: 0x0001819D
			public unsafe static Func<WormPlayer, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001282 RID: 4738
			// (get) Token: 0x06004BC7 RID: 19399 RVA: 0x00199A6C File Offset: 0x00197C6C
			// (set) Token: 0x06004BC8 RID: 19400 RVA: 0x00019FAF File Offset: 0x000181AF
			public unsafe static Func<WormPlayer, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001283 RID: 4739
			// (get) Token: 0x06004BC9 RID: 19401 RVA: 0x00199A94 File Offset: 0x00197C94
			// (set) Token: 0x06004BCA RID: 19402 RVA: 0x00019FC1 File Offset: 0x000181C1
			public unsafe static Func<WormPlayer, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScriptIMMO.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400315E RID: 12638
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400315F RID: 12639
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04003160 RID: 12640
			private static readonly IntPtr NativeFieldInfoPtr___9__1_1;

			// Token: 0x04003161 RID: 12641
			private static readonly IntPtr NativeFieldInfoPtr___9__1_39;

			// Token: 0x04003162 RID: 12642
			private static readonly IntPtr NativeFieldInfoPtr___9__1_40;

			// Token: 0x04003163 RID: 12643
			private static readonly IntPtr NativeFieldInfoPtr___9__1_6;

			// Token: 0x04003164 RID: 12644
			private static readonly IntPtr NativeFieldInfoPtr___9__1_7;

			// Token: 0x04003165 RID: 12645
			private static readonly IntPtr NativeFieldInfoPtr___9__1_8;

			// Token: 0x04003166 RID: 12646
			private static readonly IntPtr NativeFieldInfoPtr___9__1_41;

			// Token: 0x04003167 RID: 12647
			private static readonly IntPtr NativeFieldInfoPtr___9__1_42;

			// Token: 0x04003168 RID: 12648
			private static readonly IntPtr NativeFieldInfoPtr___9__1_12;

			// Token: 0x04003169 RID: 12649
			private static readonly IntPtr NativeFieldInfoPtr___9__1_13;

			// Token: 0x0400316A RID: 12650
			private static readonly IntPtr NativeFieldInfoPtr___9__1_14;

			// Token: 0x0400316B RID: 12651
			private static readonly IntPtr NativeFieldInfoPtr___9__1_15;

			// Token: 0x0400316C RID: 12652
			private static readonly IntPtr NativeFieldInfoPtr___9__1_44;

			// Token: 0x0400316D RID: 12653
			private static readonly IntPtr NativeFieldInfoPtr___9__1_17;

			// Token: 0x0400316E RID: 12654
			private static readonly IntPtr NativeFieldInfoPtr___9__1_45;

			// Token: 0x0400316F RID: 12655
			private static readonly IntPtr NativeFieldInfoPtr___9__1_18;

			// Token: 0x04003170 RID: 12656
			private static readonly IntPtr NativeFieldInfoPtr___9__1_46;

			// Token: 0x04003171 RID: 12657
			private static readonly IntPtr NativeFieldInfoPtr___9__1_19;

			// Token: 0x04003172 RID: 12658
			private static readonly IntPtr NativeFieldInfoPtr___9__1_47;

			// Token: 0x04003173 RID: 12659
			private static readonly IntPtr NativeFieldInfoPtr___9__1_20;

			// Token: 0x04003174 RID: 12660
			private static readonly IntPtr NativeFieldInfoPtr___9__1_48;

			// Token: 0x04003175 RID: 12661
			private static readonly IntPtr NativeFieldInfoPtr___9__1_49;

			// Token: 0x04003176 RID: 12662
			private static readonly IntPtr NativeFieldInfoPtr___9__1_50;

			// Token: 0x04003177 RID: 12663
			private static readonly IntPtr NativeFieldInfoPtr___9__1_51;

			// Token: 0x04003178 RID: 12664
			private static readonly IntPtr NativeFieldInfoPtr___9__1_52;

			// Token: 0x04003179 RID: 12665
			private static readonly IntPtr NativeFieldInfoPtr___9__1_54;

			// Token: 0x0400317A RID: 12666
			private static readonly IntPtr NativeFieldInfoPtr___9__1_55;

			// Token: 0x0400317B RID: 12667
			private static readonly IntPtr NativeFieldInfoPtr___9__1_56;

			// Token: 0x0400317C RID: 12668
			private static readonly IntPtr NativeFieldInfoPtr___9__1_57;

			// Token: 0x0400317D RID: 12669
			private static readonly IntPtr NativeFieldInfoPtr___9__1_58;

			// Token: 0x0400317E RID: 12670
			private static readonly IntPtr NativeFieldInfoPtr___9__1_59;

			// Token: 0x0400317F RID: 12671
			private static readonly IntPtr NativeFieldInfoPtr___9__1_60;

			// Token: 0x04003180 RID: 12672
			private static readonly IntPtr NativeFieldInfoPtr___9__1_61;

			// Token: 0x04003181 RID: 12673
			private static readonly IntPtr NativeFieldInfoPtr___9__1_63;

			// Token: 0x04003182 RID: 12674
			private static readonly IntPtr NativeFieldInfoPtr___9__1_35;

			// Token: 0x04003183 RID: 12675
			private static readonly IntPtr NativeFieldInfoPtr___9__1_64;

			// Token: 0x04003184 RID: 12676
			private static readonly IntPtr NativeFieldInfoPtr___9__1_36;

			// Token: 0x04003185 RID: 12677
			private static readonly IntPtr NativeFieldInfoPtr___9__1_65;

			// Token: 0x04003186 RID: 12678
			private static readonly IntPtr NativeFieldInfoPtr___9__1_37;

			// Token: 0x04003187 RID: 12679
			private static readonly IntPtr NativeFieldInfoPtr___9__1_66;

			// Token: 0x04003188 RID: 12680
			private static readonly IntPtr NativeFieldInfoPtr___9__1_38;

			// Token: 0x04003189 RID: 12681
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x0400318A RID: 12682
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x0400318B RID: 12683
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x0400318C RID: 12684
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x0400318D RID: 12685
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x0400318E RID: 12686
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x0400318F RID: 12687
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003190 RID: 12688
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x04003191 RID: 12689
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_1_Internal_Boolean_WormPlayer_0;

			// Token: 0x04003192 RID: 12690
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_39_Internal_Boolean_Entity_0;

			// Token: 0x04003193 RID: 12691
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_40_Internal_Boolean_Entity_0;

			// Token: 0x04003194 RID: 12692
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_6_Internal_Entity_WormPlaymat_0;

			// Token: 0x04003195 RID: 12693
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_7_Internal_Entity_WormPlaymat_0;

			// Token: 0x04003196 RID: 12694
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_8_Internal_Entity_WormPlaymat_0;

			// Token: 0x04003197 RID: 12695
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_41_Internal_Boolean_Entity_0;

			// Token: 0x04003198 RID: 12696
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_42_Internal_Boolean_Entity_0;

			// Token: 0x04003199 RID: 12697
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_12_Internal_Entity_WormPlaymat_0;

			// Token: 0x0400319A RID: 12698
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_13_Internal_Entity_WormPlaymat_0;

			// Token: 0x0400319B RID: 12699
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_14_Internal_Entity_WormPlaymat_0;

			// Token: 0x0400319C RID: 12700
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_15_Internal_Il2CppReferenceArray_1_Entity_Context_0;

			// Token: 0x0400319D RID: 12701
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_17_Internal_Entity_WormPlaymat_0;

			// Token: 0x0400319E RID: 12702
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_44_Internal_Boolean_Entity_0;

			// Token: 0x0400319F RID: 12703
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_18_Internal_Entity_WormPlaymat_0;

			// Token: 0x040031A0 RID: 12704
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_45_Internal_Boolean_Entity_0;

			// Token: 0x040031A1 RID: 12705
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_19_Internal_Entity_WormPlaymat_0;

			// Token: 0x040031A2 RID: 12706
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_46_Internal_Boolean_Entity_0;

			// Token: 0x040031A3 RID: 12707
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_20_Internal_Entity_WormPlaymat_0;

			// Token: 0x040031A4 RID: 12708
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_47_Internal_Boolean_Entity_0;

			// Token: 0x040031A5 RID: 12709
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_48_Internal_Boolean_Entity_0;

			// Token: 0x040031A6 RID: 12710
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_49_Internal_Boolean_Entity_0;

			// Token: 0x040031A7 RID: 12711
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_50_Internal_Boolean_Entity_0;

			// Token: 0x040031A8 RID: 12712
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_51_Internal_Boolean_Entity_0;

			// Token: 0x040031A9 RID: 12713
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_52_Internal_Boolean_Entity_0;

			// Token: 0x040031AA RID: 12714
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_54_Internal_Boolean_Entity_0;

			// Token: 0x040031AB RID: 12715
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_55_Internal_Boolean_Entity_0;

			// Token: 0x040031AC RID: 12716
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_56_Internal_Boolean_Entity_0;

			// Token: 0x040031AD RID: 12717
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_57_Internal_Boolean_Entity_0;

			// Token: 0x040031AE RID: 12718
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_58_Internal_Boolean_Entity_0;

			// Token: 0x040031AF RID: 12719
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_59_Internal_Boolean_Entity_0;

			// Token: 0x040031B0 RID: 12720
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_60_Internal_Boolean_Entity_0;

			// Token: 0x040031B1 RID: 12721
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_61_Internal_Boolean_Entity_0;

			// Token: 0x040031B2 RID: 12722
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_63_Internal_Boolean_Entity_0;

			// Token: 0x040031B3 RID: 12723
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_35_Internal_Entity_WormPlaymat_0;

			// Token: 0x040031B4 RID: 12724
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_36_Internal_Il2CppReferenceArray_1_Entity_Context_0;

			// Token: 0x040031B5 RID: 12725
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_64_Internal_Boolean_WormSpace_0;

			// Token: 0x040031B6 RID: 12726
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_37_Internal_Il2CppReferenceArray_1_Entity_Context_0;

			// Token: 0x040031B7 RID: 12727
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_65_Internal_Boolean_WormSpace_0;

			// Token: 0x040031B8 RID: 12728
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_38_Internal_Entity_WormPlaymat_0;

			// Token: 0x040031B9 RID: 12729
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_66_Internal_Boolean_Entity_0;

			// Token: 0x040031BA RID: 12730
			private static readonly IntPtr NativeMethodInfoPtr__HoldAI_b__2_0_Internal_Boolean_Objective_0;

			// Token: 0x040031BB RID: 12731
			private static readonly IntPtr NativeMethodInfoPtr__CompleteActive_b__3_0_Internal_Boolean_Objective_0;

			// Token: 0x040031BC RID: 12732
			private static readonly IntPtr NativeMethodInfoPtr__HumanHasSpecimens_b__4_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x040031BD RID: 12733
			private static readonly IntPtr NativeMethodInfoPtr__HumanResearchCount1_b__5_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x040031BE RID: 12734
			private static readonly IntPtr NativeMethodInfoPtr__HumanResearchCount2_b__6_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x040031BF RID: 12735
			private static readonly IntPtr NativeMethodInfoPtr__Check5VPScore_b__7_0_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x020005F6 RID: 1526
		[ObfuscatedName("worm.canis.data.Tutorial.WormTutorialScriptIMMO+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06004BCB RID: 19403 RVA: 0x00199ABC File Offset: 0x00197CBC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTutorialScriptIMMO>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_0>.NativeClassPtr);
				WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_0>.NativeClassPtr, "<>4__this");
				WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeFieldInfoPtr_humanPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_0>.NativeClassPtr, "humanPlayer");
				WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeFieldInfoPtr___9__53 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_0>.NativeClassPtr, "<>9__53");
				WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeFieldInfoPtr___9__62 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_0>.NativeClassPtr, "<>9__62");
				WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_0>.NativeClassPtr, 100665060);
				WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__2_Internal_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_0>.NativeClassPtr, 100665061);
				WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__3_Internal_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_0>.NativeClassPtr, 100665062);
				WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__4_Internal_Il2CppReferenceArray_1_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_0>.NativeClassPtr, 100665063);
				WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__5_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_0>.NativeClassPtr, 100665064);
				WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__9_Internal_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_0>.NativeClassPtr, 100665065);
				WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__10_Internal_Il2CppReferenceArray_1_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_0>.NativeClassPtr, 100665066);
				WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__11_Internal_Il2CppReferenceArray_1_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_0>.NativeClassPtr, 100665067);
				WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__16_Internal_Il2CppReferenceArray_1_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_0>.NativeClassPtr, 100665068);
				WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__21_Internal_Il2CppReferenceArray_1_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_0>.NativeClassPtr, 100665069);
				WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__22_Internal_Il2CppReferenceArray_1_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_0>.NativeClassPtr, 100665070);
				WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__23_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_0>.NativeClassPtr, 100665071);
				WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__24_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_0>.NativeClassPtr, 100665072);
				WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__25_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_0>.NativeClassPtr, 100665073);
				WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__26_Internal_Void_WormTutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_0>.NativeClassPtr, 100665074);
				WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__53_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_0>.NativeClassPtr, 100665075);
				WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__27_Internal_Il2CppReferenceArray_1_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_0>.NativeClassPtr, 100665076);
				WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__28_Internal_Il2CppReferenceArray_1_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_0>.NativeClassPtr, 100665077);
				WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__29_Internal_Il2CppReferenceArray_1_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_0>.NativeClassPtr, 100665078);
				WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__30_Internal_Il2CppReferenceArray_1_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_0>.NativeClassPtr, 100665079);
				WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__31_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_0>.NativeClassPtr, 100665080);
				WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__32_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_0>.NativeClassPtr, 100665081);
				WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__33_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_0>.NativeClassPtr, 100665082);
				WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__34_Internal_Void_WormTutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_0>.NativeClassPtr, 100665083);
				WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__62_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_0>.NativeClassPtr, 100665084);
			}

			// Token: 0x06004BCC RID: 19404 RVA: 0x00199D2C File Offset: 0x00197F2C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004BCD RID: 19405 RVA: 0x00199D68 File Offset: 0x00197F68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63876, XrefRangeEnd = 63878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__2(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__2_Internal_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004BCE RID: 19406 RVA: 0x00199DB8 File Offset: 0x00197FB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63878, XrefRangeEnd = 63881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__3_Internal_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004BCF RID: 19407 RVA: 0x00199DF8 File Offset: 0x00197FF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63881, XrefRangeEnd = 63903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<Entity> _tutorialItems_b__4(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__4_Internal_Il2CppReferenceArray_1_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x06004BD0 RID: 19408 RVA: 0x00199E48 File Offset: 0x00198048
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63903, XrefRangeEnd = 63928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__5(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__5_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004BD1 RID: 19409 RVA: 0x00199E98 File Offset: 0x00198098
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63928, XrefRangeEnd = 63931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__9()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__9_Internal_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004BD2 RID: 19410 RVA: 0x00199ED8 File Offset: 0x001980D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63931, XrefRangeEnd = 63953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<Entity> _tutorialItems_b__10(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__10_Internal_Il2CppReferenceArray_1_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x06004BD3 RID: 19411 RVA: 0x00199F28 File Offset: 0x00198128
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63953, XrefRangeEnd = 63975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<Entity> _tutorialItems_b__11(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__11_Internal_Il2CppReferenceArray_1_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x06004BD4 RID: 19412 RVA: 0x00199F78 File Offset: 0x00198178
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63975, XrefRangeEnd = 63980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<Entity> _tutorialItems_b__16(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__16_Internal_Il2CppReferenceArray_1_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x06004BD5 RID: 19413 RVA: 0x00199FC8 File Offset: 0x001981C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63980, XrefRangeEnd = 64002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<Entity> _tutorialItems_b__21(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__21_Internal_Il2CppReferenceArray_1_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x06004BD6 RID: 19414 RVA: 0x0019A018 File Offset: 0x00198218
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64002, XrefRangeEnd = 64024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<Entity> _tutorialItems_b__22(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__22_Internal_Il2CppReferenceArray_1_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x06004BD7 RID: 19415 RVA: 0x0019A068 File Offset: 0x00198268
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64024, XrefRangeEnd = 64043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__23(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__23_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004BD8 RID: 19416 RVA: 0x0019A0B8 File Offset: 0x001982B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64043, XrefRangeEnd = 64062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__24(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__24_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004BD9 RID: 19417 RVA: 0x0019A108 File Offset: 0x00198308
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64062, XrefRangeEnd = 64081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__25(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__25_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004BDA RID: 19418 RVA: 0x0019A158 File Offset: 0x00198358
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64081, XrefRangeEnd = 64090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _tutorialItems_b__26(WormTutorialAction a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__26_Internal_Void_WormTutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004BDB RID: 19419 RVA: 0x0019A19C File Offset: 0x0019839C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64090, XrefRangeEnd = 64109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__53(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__53_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004BDC RID: 19420 RVA: 0x0019A1EC File Offset: 0x001983EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64109, XrefRangeEnd = 64131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<Entity> _tutorialItems_b__27(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__27_Internal_Il2CppReferenceArray_1_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x06004BDD RID: 19421 RVA: 0x0019A23C File Offset: 0x0019843C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64131, XrefRangeEnd = 64153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<Entity> _tutorialItems_b__28(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__28_Internal_Il2CppReferenceArray_1_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x06004BDE RID: 19422 RVA: 0x0019A28C File Offset: 0x0019848C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64153, XrefRangeEnd = 64175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<Entity> _tutorialItems_b__29(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__29_Internal_Il2CppReferenceArray_1_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x06004BDF RID: 19423 RVA: 0x0019A2DC File Offset: 0x001984DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64175, XrefRangeEnd = 64197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<Entity> _tutorialItems_b__30(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__30_Internal_Il2CppReferenceArray_1_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x06004BE0 RID: 19424 RVA: 0x0019A32C File Offset: 0x0019852C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64197, XrefRangeEnd = 64216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__31(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__31_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004BE1 RID: 19425 RVA: 0x0019A37C File Offset: 0x0019857C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64216, XrefRangeEnd = 64235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__32(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__32_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004BE2 RID: 19426 RVA: 0x0019A3CC File Offset: 0x001985CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64235, XrefRangeEnd = 64254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__33(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__33_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004BE3 RID: 19427 RVA: 0x0019A41C File Offset: 0x0019861C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64254, XrefRangeEnd = 64263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _tutorialItems_b__34(WormTutorialAction a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__34_Internal_Void_WormTutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004BE4 RID: 19428 RVA: 0x0019A460 File Offset: 0x00198660
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64263, XrefRangeEnd = 64282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__62(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__62_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004BE5 RID: 19429 RVA: 0x00019FD3 File Offset: 0x000181D3
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001284 RID: 4740
			// (get) Token: 0x06004BE6 RID: 19430 RVA: 0x0019A4B0 File Offset: 0x001986B0
			// (set) Token: 0x06004BE7 RID: 19431 RVA: 0x00019FDC File Offset: 0x000181DC
			public unsafe WormTutorialScriptIMMO __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTutorialScriptIMMO>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001285 RID: 4741
			// (get) Token: 0x06004BE8 RID: 19432 RVA: 0x0019A4E0 File Offset: 0x001986E0
			// (set) Token: 0x06004BE9 RID: 19433 RVA: 0x00019FFB File Offset: 0x000181FB
			public unsafe WormPlayer humanPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeFieldInfoPtr_humanPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeFieldInfoPtr_humanPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001286 RID: 4742
			// (get) Token: 0x06004BEA RID: 19434 RVA: 0x0019A510 File Offset: 0x00198710
			// (set) Token: 0x06004BEB RID: 19435 RVA: 0x0001A01A File Offset: 0x0001821A
			public unsafe Func<Context, Entity> __9__53
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeFieldInfoPtr___9__53);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Context, Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeFieldInfoPtr___9__53), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001287 RID: 4743
			// (get) Token: 0x06004BEC RID: 19436 RVA: 0x0019A540 File Offset: 0x00198740
			// (set) Token: 0x06004BED RID: 19437 RVA: 0x0001A039 File Offset: 0x00018239
			public unsafe Func<Context, Entity> __9__62
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeFieldInfoPtr___9__62);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Context, Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScriptIMMO.__c__DisplayClass1_0.NativeFieldInfoPtr___9__62), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040031C0 RID: 12736
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040031C1 RID: 12737
			private static readonly IntPtr NativeFieldInfoPtr_humanPlayer;

			// Token: 0x040031C2 RID: 12738
			private static readonly IntPtr NativeFieldInfoPtr___9__53;

			// Token: 0x040031C3 RID: 12739
			private static readonly IntPtr NativeFieldInfoPtr___9__62;

			// Token: 0x040031C4 RID: 12740
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040031C5 RID: 12741
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__2_Internal_Boolean_Context_0;

			// Token: 0x040031C6 RID: 12742
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__3_Internal_Entity_0;

			// Token: 0x040031C7 RID: 12743
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__4_Internal_Il2CppReferenceArray_1_Entity_Context_0;

			// Token: 0x040031C8 RID: 12744
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__5_Internal_Entity_Context_0;

			// Token: 0x040031C9 RID: 12745
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__9_Internal_Entity_0;

			// Token: 0x040031CA RID: 12746
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__10_Internal_Il2CppReferenceArray_1_Entity_Context_0;

			// Token: 0x040031CB RID: 12747
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__11_Internal_Il2CppReferenceArray_1_Entity_Context_0;

			// Token: 0x040031CC RID: 12748
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__16_Internal_Il2CppReferenceArray_1_Entity_Context_0;

			// Token: 0x040031CD RID: 12749
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__21_Internal_Il2CppReferenceArray_1_Entity_Context_0;

			// Token: 0x040031CE RID: 12750
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__22_Internal_Il2CppReferenceArray_1_Entity_Context_0;

			// Token: 0x040031CF RID: 12751
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__23_Internal_Entity_Context_0;

			// Token: 0x040031D0 RID: 12752
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__24_Internal_Entity_Context_0;

			// Token: 0x040031D1 RID: 12753
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__25_Internal_Entity_Context_0;

			// Token: 0x040031D2 RID: 12754
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__26_Internal_Void_WormTutorialAction_0;

			// Token: 0x040031D3 RID: 12755
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__53_Internal_Entity_Context_0;

			// Token: 0x040031D4 RID: 12756
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__27_Internal_Il2CppReferenceArray_1_Entity_Context_0;

			// Token: 0x040031D5 RID: 12757
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__28_Internal_Il2CppReferenceArray_1_Entity_Context_0;

			// Token: 0x040031D6 RID: 12758
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__29_Internal_Il2CppReferenceArray_1_Entity_Context_0;

			// Token: 0x040031D7 RID: 12759
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__30_Internal_Il2CppReferenceArray_1_Entity_Context_0;

			// Token: 0x040031D8 RID: 12760
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__31_Internal_Entity_Context_0;

			// Token: 0x040031D9 RID: 12761
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__32_Internal_Entity_Context_0;

			// Token: 0x040031DA RID: 12762
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__33_Internal_Entity_Context_0;

			// Token: 0x040031DB RID: 12763
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__34_Internal_Void_WormTutorialAction_0;

			// Token: 0x040031DC RID: 12764
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__62_Internal_Entity_Context_0;
		}

		// Token: 0x020005F7 RID: 1527
		[ObfuscatedName("worm.canis.data.Tutorial.WormTutorialScriptIMMO+<>c__DisplayClass1_1")]
		public sealed class __c__DisplayClass1_1 : Object
		{
			// Token: 0x06004BEE RID: 19438 RVA: 0x0019A570 File Offset: 0x00198770
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_1()
			{
				Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTutorialScriptIMMO>.NativeClassPtr, "<>c__DisplayClass1_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_1>.NativeClassPtr);
				WormTutorialScriptIMMO.__c__DisplayClass1_1.NativeFieldInfoPtr_track = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_1>.NativeClassPtr, "track");
				WormTutorialScriptIMMO.__c__DisplayClass1_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_1>.NativeClassPtr, 100665085);
				WormTutorialScriptIMMO.__c__DisplayClass1_1.NativeMethodInfoPtr__tutorialItems_b__43_Internal_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_1>.NativeClassPtr, 100665086);
			}

			// Token: 0x06004BEF RID: 19439 RVA: 0x0019A5D8 File Offset: 0x001987D8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialScriptIMMO.__c__DisplayClass1_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c__DisplayClass1_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004BF0 RID: 19440 RVA: 0x0019A614 File Offset: 0x00198814
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64282, XrefRangeEnd = 64284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__43(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScriptIMMO.__c__DisplayClass1_1.NativeMethodInfoPtr__tutorialItems_b__43_Internal_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004BF1 RID: 19441 RVA: 0x0001A058 File Offset: 0x00018258
			public __c__DisplayClass1_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001288 RID: 4744
			// (get) Token: 0x06004BF2 RID: 19442 RVA: 0x0019A660 File Offset: 0x00198860
			// (set) Token: 0x06004BF3 RID: 19443 RVA: 0x0001A061 File Offset: 0x00018261
			public unsafe WormTleilaxuTrack track
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScriptIMMO.__c__DisplayClass1_1.NativeFieldInfoPtr_track);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTleilaxuTrack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScriptIMMO.__c__DisplayClass1_1.NativeFieldInfoPtr_track), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040031DD RID: 12765
			private static readonly IntPtr NativeFieldInfoPtr_track;

			// Token: 0x040031DE RID: 12766
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040031DF RID: 12767
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__43_Internal_Entity_Int32_0;
		}
	}
}
