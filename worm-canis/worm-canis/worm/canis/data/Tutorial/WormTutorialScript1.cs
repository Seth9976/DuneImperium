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
	// Token: 0x02000048 RID: 72
	public class WormTutorialScript1 : WormTutorialScript
	{
		// Token: 0x06000A5D RID: 2653 RVA: 0x00088D48 File Offset: 0x00086F48
		// Note: this type is marked as 'beforefieldinit'.
		static WormTutorialScript1()
		{
			Il2CppClassPointerStore<WormTutorialScript1>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Tutorial", "WormTutorialScript1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialScript1>.NativeClassPtr);
			WormTutorialScript1.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1>.NativeClassPtr, 100664798);
			WormTutorialScript1.NativeMethodInfoPtr_tutorialItems_Protected_Virtual_IEnumerable_1_TutorialItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1>.NativeClassPtr, 100664799);
			WormTutorialScript1.NativeMethodInfoPtr_GetAIGarrisonTroops_Private_IEnumerable_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1>.NativeClassPtr, 100664800);
			WormTutorialScript1.NativeMethodInfoPtr_GetHumanGarrisonTroops_Private_IEnumerable_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1>.NativeClassPtr, 100664801);
			WormTutorialScript1.NativeMethodInfoPtr_GetHumanSupplyTroops_Private_IEnumerable_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1>.NativeClassPtr, 100664802);
			WormTutorialScript1.NativeMethodInfoPtr_HumanHasNoDeployedTroops_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1>.NativeClassPtr, 100664803);
			WormTutorialScript1.NativeMethodInfoPtr_HumanHas3DeployedTroops_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1>.NativeClassPtr, 100664804);
			WormTutorialScript1.NativeMethodInfoPtr_HumanHas5DeployedTroops_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1>.NativeClassPtr, 100664805);
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x00088E18 File Offset: 0x00087018
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54376, RefRangeEnd = 54377, XrefRangeStart = 54375, XrefRangeEnd = 54376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTutorialScript1(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialScript1>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00088E64 File Offset: 0x00087064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54377, XrefRangeEnd = 58974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<AdvancedTutorialScript.TutorialItem> tutorialItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTutorialScript1.NativeMethodInfoPtr_tutorialItems_Protected_Virtual_IEnumerable_1_TutorialItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AdvancedTutorialScript.TutorialItem>>(intPtr3) : null;
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x00088EB0 File Offset: 0x000870B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58974, XrefRangeEnd = 58999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Entity> GetAIGarrisonTroops()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.NativeMethodInfoPtr_GetAIGarrisonTroops_Private_IEnumerable_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x00088EF0 File Offset: 0x000870F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58999, XrefRangeEnd = 59024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Entity> GetHumanGarrisonTroops()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.NativeMethodInfoPtr_GetHumanGarrisonTroops_Private_IEnumerable_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x00088F30 File Offset: 0x00087130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59024, XrefRangeEnd = 59047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Entity> GetHumanSupplyTroops()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.NativeMethodInfoPtr_GetHumanSupplyTroops_Private_IEnumerable_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x00088F70 File Offset: 0x00087170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59047, XrefRangeEnd = 59076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HumanHasNoDeployedTroops()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.NativeMethodInfoPtr_HumanHasNoDeployedTroops_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x00088FAC File Offset: 0x000871AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59076, XrefRangeEnd = 59098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HumanHas3DeployedTroops()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.NativeMethodInfoPtr_HumanHas3DeployedTroops_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00088FE8 File Offset: 0x000871E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59098, XrefRangeEnd = 59120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HumanHas5DeployedTroops()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.NativeMethodInfoPtr_HumanHas5DeployedTroops_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x00006B74 File Offset: 0x00004D74
		public WormTutorialScript1(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04000671 RID: 1649
		private static readonly IntPtr NativeMethodInfoPtr_tutorialItems_Protected_Virtual_IEnumerable_1_TutorialItem_0;

		// Token: 0x04000672 RID: 1650
		private static readonly IntPtr NativeMethodInfoPtr_GetAIGarrisonTroops_Private_IEnumerable_1_Entity_0;

		// Token: 0x04000673 RID: 1651
		private static readonly IntPtr NativeMethodInfoPtr_GetHumanGarrisonTroops_Private_IEnumerable_1_Entity_0;

		// Token: 0x04000674 RID: 1652
		private static readonly IntPtr NativeMethodInfoPtr_GetHumanSupplyTroops_Private_IEnumerable_1_Entity_0;

		// Token: 0x04000675 RID: 1653
		private static readonly IntPtr NativeMethodInfoPtr_HumanHasNoDeployedTroops_Private_Boolean_0;

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeMethodInfoPtr_HumanHas3DeployedTroops_Private_Boolean_0;

		// Token: 0x04000677 RID: 1655
		private static readonly IntPtr NativeMethodInfoPtr_HumanHas5DeployedTroops_Private_Boolean_0;

		// Token: 0x020005EA RID: 1514
		[ObfuscatedName("worm.canis.data.Tutorial.WormTutorialScript1+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x060049A1 RID: 18849 RVA: 0x00191F64 File Offset: 0x00190164
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTutorialScript1>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr);
				WormTutorialScript1.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_0");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_1");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_48 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_48");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_50 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_50");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_51 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_51");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_53 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_53");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_7");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_54 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_54");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_55 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_55");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_56 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_56");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_11");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_12");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_57 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_57");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_13");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_58 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_58");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_14");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_15");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_16");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_17");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_59 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_59");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_18");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_62 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_62");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_68 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_68");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_69 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_69");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_71 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_71");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_72 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_72");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_74 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_74");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_75 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_75");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_38 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_38");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_76 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_76");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_44 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_44");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_77 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_77");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_45 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_45");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_78 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_78");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_46 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_46");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_79 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_79");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_47 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__1_47");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__2_0");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__3_0");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__4_0");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__5_0");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__6_0");
				WormTutorialScript1.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, "<>9__7_0");
				WormTutorialScript1.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664807);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664808);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_1_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664809);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_48_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664810);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_50_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664811);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_51_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664812);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_53_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664813);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_7_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664814);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_54_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664815);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_55_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664816);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_11_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664817);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_56_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664818);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_12_Internal_Il2CppReferenceArray_1_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664819);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_13_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664820);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_57_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664821);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_14_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664822);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_58_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664823);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_15_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664824);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_16_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664825);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_17_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664826);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_18_Internal_Void_WormTutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664827);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_59_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664828);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_62_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664829);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_68_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664830);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_69_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664831);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_71_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664832);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_72_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664833);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_74_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664834);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_38_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664835);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_75_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664836);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_44_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664837);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_76_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664838);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_45_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664839);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_77_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664840);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_46_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664841);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_78_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664842);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_47_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664843);
				WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_79_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664844);
				WormTutorialScript1.__c.NativeMethodInfoPtr__GetAIGarrisonTroops_b__2_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664845);
				WormTutorialScript1.__c.NativeMethodInfoPtr__GetHumanGarrisonTroops_b__3_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664846);
				WormTutorialScript1.__c.NativeMethodInfoPtr__GetHumanSupplyTroops_b__4_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664847);
				WormTutorialScript1.__c.NativeMethodInfoPtr__HumanHasNoDeployedTroops_b__5_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664848);
				WormTutorialScript1.__c.NativeMethodInfoPtr__HumanHas3DeployedTroops_b__6_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664849);
				WormTutorialScript1.__c.NativeMethodInfoPtr__HumanHas5DeployedTroops_b__7_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr, 100664850);
			}

			// Token: 0x060049A2 RID: 18850 RVA: 0x00192670 File Offset: 0x00190870
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialScript1.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060049A3 RID: 18851 RVA: 0x001926AC File Offset: 0x001908AC
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049A4 RID: 18852 RVA: 0x001926FC File Offset: 0x001908FC
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_1_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049A5 RID: 18853 RVA: 0x0019274C File Offset: 0x0019094C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53552, XrefRangeEnd = 53561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_48(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_48_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049A6 RID: 18854 RVA: 0x0019279C File Offset: 0x0019099C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53561, XrefRangeEnd = 53570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_50(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_50_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049A7 RID: 18855 RVA: 0x001927EC File Offset: 0x001909EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53570, XrefRangeEnd = 53579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_51(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_51_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049A8 RID: 18856 RVA: 0x0019283C File Offset: 0x00190A3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53579, XrefRangeEnd = 53588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_53(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_53_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049A9 RID: 18857 RVA: 0x0019288C File Offset: 0x00190A8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53588, XrefRangeEnd = 53600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_7(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_7_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049AA RID: 18858 RVA: 0x001928DC File Offset: 0x00190ADC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53600, XrefRangeEnd = 53609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_54(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_54_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049AB RID: 18859 RVA: 0x0019292C File Offset: 0x00190B2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53609, XrefRangeEnd = 53618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_55(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_55_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049AC RID: 18860 RVA: 0x0019297C File Offset: 0x00190B7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53618, XrefRangeEnd = 53637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__1_11(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_11_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x060049AD RID: 18861 RVA: 0x001929CC File Offset: 0x00190BCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53637, XrefRangeEnd = 53646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_56(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_56_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049AE RID: 18862 RVA: 0x00192A1C File Offset: 0x00190C1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53646, XrefRangeEnd = 53657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<Entity> _tutorialItems_b__1_12(Context context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_12_Internal_Il2CppReferenceArray_1_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x060049AF RID: 18863 RVA: 0x00192A6C File Offset: 0x00190C6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53657, XrefRangeEnd = 53676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__1_13(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_13_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x060049B0 RID: 18864 RVA: 0x00192ABC File Offset: 0x00190CBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53676, XrefRangeEnd = 53685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_57(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_57_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049B1 RID: 18865 RVA: 0x00192B0C File Offset: 0x00190D0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53685, XrefRangeEnd = 53704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__1_14(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_14_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x060049B2 RID: 18866 RVA: 0x00192B5C File Offset: 0x00190D5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53704, XrefRangeEnd = 53713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_58(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_58_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049B3 RID: 18867 RVA: 0x00192BAC File Offset: 0x00190DAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53713, XrefRangeEnd = 53715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__1_15(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_15_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x060049B4 RID: 18868 RVA: 0x00192BFC File Offset: 0x00190DFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__1_16(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_16_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x060049B5 RID: 18869 RVA: 0x00192C4C File Offset: 0x00190E4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__1_17(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_17_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x060049B6 RID: 18870 RVA: 0x00192C9C File Offset: 0x00190E9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53715, XrefRangeEnd = 53732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _tutorialItems_b__1_18(WormTutorialAction a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_18_Internal_Void_WormTutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060049B7 RID: 18871 RVA: 0x00192CE0 File Offset: 0x00190EE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__1_59(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_59_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x060049B8 RID: 18872 RVA: 0x00192D30 File Offset: 0x00190F30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53732, XrefRangeEnd = 53741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_62(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_62_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049B9 RID: 18873 RVA: 0x00192D80 File Offset: 0x00190F80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53741, XrefRangeEnd = 53750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_68(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_68_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049BA RID: 18874 RVA: 0x00192DD0 File Offset: 0x00190FD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53750, XrefRangeEnd = 53759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_69(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_69_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049BB RID: 18875 RVA: 0x00192E20 File Offset: 0x00191020
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53759, XrefRangeEnd = 53768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_71(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_71_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049BC RID: 18876 RVA: 0x00192E70 File Offset: 0x00191070
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53768, XrefRangeEnd = 53777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_72(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_72_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049BD RID: 18877 RVA: 0x00192EC0 File Offset: 0x001910C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53777, XrefRangeEnd = 53786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_74(Entity c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_74_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049BE RID: 18878 RVA: 0x00192F10 File Offset: 0x00191110
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53786, XrefRangeEnd = 53805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__1_38(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_38_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x060049BF RID: 18879 RVA: 0x00192F60 File Offset: 0x00191160
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53805, XrefRangeEnd = 53814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_75(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_75_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049C0 RID: 18880 RVA: 0x00192FB0 File Offset: 0x001911B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53814, XrefRangeEnd = 53833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__1_44(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_44_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x060049C1 RID: 18881 RVA: 0x00193000 File Offset: 0x00191200
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53833, XrefRangeEnd = 53842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_76(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_76_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049C2 RID: 18882 RVA: 0x00193050 File Offset: 0x00191250
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53842, XrefRangeEnd = 53861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__1_45(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_45_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x060049C3 RID: 18883 RVA: 0x001930A0 File Offset: 0x001912A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53861, XrefRangeEnd = 53870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_77(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_77_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049C4 RID: 18884 RVA: 0x001930F0 File Offset: 0x001912F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53870, XrefRangeEnd = 53889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__1_46(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_46_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x060049C5 RID: 18885 RVA: 0x00193140 File Offset: 0x00191340
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53889, XrefRangeEnd = 53898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_78(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_78_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049C6 RID: 18886 RVA: 0x00193190 File Offset: 0x00191390
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53898, XrefRangeEnd = 53917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__1_47(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_47_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x060049C7 RID: 18887 RVA: 0x001931E0 File Offset: 0x001913E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53917, XrefRangeEnd = 53926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_79(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__tutorialItems_b__1_79_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049C8 RID: 18888 RVA: 0x00193230 File Offset: 0x00191430
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAIGarrisonTroops_b__2_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__GetAIGarrisonTroops_b__2_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049C9 RID: 18889 RVA: 0x00193280 File Offset: 0x00191480
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetHumanGarrisonTroops_b__3_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__GetHumanGarrisonTroops_b__3_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049CA RID: 18890 RVA: 0x001932D0 File Offset: 0x001914D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetHumanSupplyTroops_b__4_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__GetHumanSupplyTroops_b__4_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049CB RID: 18891 RVA: 0x00193320 File Offset: 0x00191520
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HumanHasNoDeployedTroops_b__5_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__HumanHasNoDeployedTroops_b__5_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049CC RID: 18892 RVA: 0x00193370 File Offset: 0x00191570
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HumanHas3DeployedTroops_b__6_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__HumanHas3DeployedTroops_b__6_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049CD RID: 18893 RVA: 0x001933C0 File Offset: 0x001915C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HumanHas5DeployedTroops_b__7_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c.NativeMethodInfoPtr__HumanHas5DeployedTroops_b__7_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049CE RID: 18894 RVA: 0x0001931C File Offset: 0x0001751C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011E7 RID: 4583
			// (get) Token: 0x060049CF RID: 18895 RVA: 0x00193410 File Offset: 0x00191610
			// (set) Token: 0x060049D0 RID: 18896 RVA: 0x00019325 File Offset: 0x00017525
			public unsafe static WormTutorialScript1.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTutorialScript1.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011E8 RID: 4584
			// (get) Token: 0x060049D1 RID: 18897 RVA: 0x00193438 File Offset: 0x00191638
			// (set) Token: 0x060049D2 RID: 18898 RVA: 0x00019337 File Offset: 0x00017537
			public unsafe static Func<WormPlayer, bool> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011E9 RID: 4585
			// (get) Token: 0x060049D3 RID: 18899 RVA: 0x00193460 File Offset: 0x00191660
			// (set) Token: 0x060049D4 RID: 18900 RVA: 0x00019349 File Offset: 0x00017549
			public unsafe static Func<WormPlayer, bool> __9__1_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011EA RID: 4586
			// (get) Token: 0x060049D5 RID: 18901 RVA: 0x00193488 File Offset: 0x00191688
			// (set) Token: 0x060049D6 RID: 18902 RVA: 0x0001935B File Offset: 0x0001755B
			public unsafe static Func<Entity, bool> __9__1_48
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_48, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_48, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011EB RID: 4587
			// (get) Token: 0x060049D7 RID: 18903 RVA: 0x001934B0 File Offset: 0x001916B0
			// (set) Token: 0x060049D8 RID: 18904 RVA: 0x0001936D File Offset: 0x0001756D
			public unsafe static Func<Entity, bool> __9__1_50
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_50, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_50, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011EC RID: 4588
			// (get) Token: 0x060049D9 RID: 18905 RVA: 0x001934D8 File Offset: 0x001916D8
			// (set) Token: 0x060049DA RID: 18906 RVA: 0x0001937F File Offset: 0x0001757F
			public unsafe static Func<Entity, bool> __9__1_51
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_51, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_51, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011ED RID: 4589
			// (get) Token: 0x060049DB RID: 18907 RVA: 0x00193500 File Offset: 0x00191700
			// (set) Token: 0x060049DC RID: 18908 RVA: 0x00019391 File Offset: 0x00017591
			public unsafe static Func<Entity, bool> __9__1_53
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_53, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_53, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011EE RID: 4590
			// (get) Token: 0x060049DD RID: 18909 RVA: 0x00193528 File Offset: 0x00191728
			// (set) Token: 0x060049DE RID: 18910 RVA: 0x000193A3 File Offset: 0x000175A3
			public unsafe static Func<Entity, bool> __9__1_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011EF RID: 4591
			// (get) Token: 0x060049DF RID: 18911 RVA: 0x00193550 File Offset: 0x00191750
			// (set) Token: 0x060049E0 RID: 18912 RVA: 0x000193B5 File Offset: 0x000175B5
			public unsafe static Func<Entity, bool> __9__1_54
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_54, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_54, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011F0 RID: 4592
			// (get) Token: 0x060049E1 RID: 18913 RVA: 0x00193578 File Offset: 0x00191778
			// (set) Token: 0x060049E2 RID: 18914 RVA: 0x000193C7 File Offset: 0x000175C7
			public unsafe static Func<Entity, bool> __9__1_55
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_55, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_55, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011F1 RID: 4593
			// (get) Token: 0x060049E3 RID: 18915 RVA: 0x001935A0 File Offset: 0x001917A0
			// (set) Token: 0x060049E4 RID: 18916 RVA: 0x000193D9 File Offset: 0x000175D9
			public unsafe static Func<Entity, bool> __9__1_56
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_56, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_56, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011F2 RID: 4594
			// (get) Token: 0x060049E5 RID: 18917 RVA: 0x001935C8 File Offset: 0x001917C8
			// (set) Token: 0x060049E6 RID: 18918 RVA: 0x000193EB File Offset: 0x000175EB
			public unsafe static Func<WormPlaymat, Entity> __9__1_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011F3 RID: 4595
			// (get) Token: 0x060049E7 RID: 18919 RVA: 0x001935F0 File Offset: 0x001917F0
			// (set) Token: 0x060049E8 RID: 18920 RVA: 0x000193FD File Offset: 0x000175FD
			public unsafe static Func<Context, Il2CppReferenceArray<Entity>> __9__1_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Context, Il2CppReferenceArray<Entity>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011F4 RID: 4596
			// (get) Token: 0x060049E9 RID: 18921 RVA: 0x00193618 File Offset: 0x00191818
			// (set) Token: 0x060049EA RID: 18922 RVA: 0x0001940F File Offset: 0x0001760F
			public unsafe static Func<Entity, bool> __9__1_57
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_57, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_57, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011F5 RID: 4597
			// (get) Token: 0x060049EB RID: 18923 RVA: 0x00193640 File Offset: 0x00191840
			// (set) Token: 0x060049EC RID: 18924 RVA: 0x00019421 File Offset: 0x00017621
			public unsafe static Func<WormPlaymat, Entity> __9__1_13
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_13, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_13, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011F6 RID: 4598
			// (get) Token: 0x060049ED RID: 18925 RVA: 0x00193668 File Offset: 0x00191868
			// (set) Token: 0x060049EE RID: 18926 RVA: 0x00019433 File Offset: 0x00017633
			public unsafe static Func<Entity, bool> __9__1_58
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_58, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_58, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011F7 RID: 4599
			// (get) Token: 0x060049EF RID: 18927 RVA: 0x00193690 File Offset: 0x00191890
			// (set) Token: 0x060049F0 RID: 18928 RVA: 0x00019445 File Offset: 0x00017645
			public unsafe static Func<WormPlaymat, Entity> __9__1_14
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_14, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_14, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011F8 RID: 4600
			// (get) Token: 0x060049F1 RID: 18929 RVA: 0x001936B8 File Offset: 0x001918B8
			// (set) Token: 0x060049F2 RID: 18930 RVA: 0x00019457 File Offset: 0x00017657
			public unsafe static Func<WormPlaymat, Entity> __9__1_15
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_15, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_15, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011F9 RID: 4601
			// (get) Token: 0x060049F3 RID: 18931 RVA: 0x001936E0 File Offset: 0x001918E0
			// (set) Token: 0x060049F4 RID: 18932 RVA: 0x00019469 File Offset: 0x00017669
			public unsafe static Func<WormPlaymat, Entity> __9__1_16
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_16, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_16, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011FA RID: 4602
			// (get) Token: 0x060049F5 RID: 18933 RVA: 0x00193708 File Offset: 0x00191908
			// (set) Token: 0x060049F6 RID: 18934 RVA: 0x0001947B File Offset: 0x0001767B
			public unsafe static Func<WormPlaymat, Entity> __9__1_17
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_17, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_17, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011FB RID: 4603
			// (get) Token: 0x060049F7 RID: 18935 RVA: 0x00193730 File Offset: 0x00191930
			// (set) Token: 0x060049F8 RID: 18936 RVA: 0x0001948D File Offset: 0x0001768D
			public unsafe static Func<WormPlaymat, Entity> __9__1_59
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_59, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_59, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011FC RID: 4604
			// (get) Token: 0x060049F9 RID: 18937 RVA: 0x00193758 File Offset: 0x00191958
			// (set) Token: 0x060049FA RID: 18938 RVA: 0x0001949F File Offset: 0x0001769F
			public unsafe static Action<WormTutorialAction> __9__1_18
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_18, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<WormTutorialAction>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_18, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011FD RID: 4605
			// (get) Token: 0x060049FB RID: 18939 RVA: 0x00193780 File Offset: 0x00191980
			// (set) Token: 0x060049FC RID: 18940 RVA: 0x000194B1 File Offset: 0x000176B1
			public unsafe static Func<Entity, bool> __9__1_62
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_62, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_62, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011FE RID: 4606
			// (get) Token: 0x060049FD RID: 18941 RVA: 0x001937A8 File Offset: 0x001919A8
			// (set) Token: 0x060049FE RID: 18942 RVA: 0x000194C3 File Offset: 0x000176C3
			public unsafe static Func<Entity, bool> __9__1_68
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_68, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_68, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011FF RID: 4607
			// (get) Token: 0x060049FF RID: 18943 RVA: 0x001937D0 File Offset: 0x001919D0
			// (set) Token: 0x06004A00 RID: 18944 RVA: 0x000194D5 File Offset: 0x000176D5
			public unsafe static Func<Entity, bool> __9__1_69
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_69, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_69, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001200 RID: 4608
			// (get) Token: 0x06004A01 RID: 18945 RVA: 0x001937F8 File Offset: 0x001919F8
			// (set) Token: 0x06004A02 RID: 18946 RVA: 0x000194E7 File Offset: 0x000176E7
			public unsafe static Func<Entity, bool> __9__1_71
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_71, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_71, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001201 RID: 4609
			// (get) Token: 0x06004A03 RID: 18947 RVA: 0x00193820 File Offset: 0x00191A20
			// (set) Token: 0x06004A04 RID: 18948 RVA: 0x000194F9 File Offset: 0x000176F9
			public unsafe static Func<Entity, bool> __9__1_72
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_72, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_72, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001202 RID: 4610
			// (get) Token: 0x06004A05 RID: 18949 RVA: 0x00193848 File Offset: 0x00191A48
			// (set) Token: 0x06004A06 RID: 18950 RVA: 0x0001950B File Offset: 0x0001770B
			public unsafe static Func<Entity, bool> __9__1_74
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_74, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_74, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001203 RID: 4611
			// (get) Token: 0x06004A07 RID: 18951 RVA: 0x00193870 File Offset: 0x00191A70
			// (set) Token: 0x06004A08 RID: 18952 RVA: 0x0001951D File Offset: 0x0001771D
			public unsafe static Func<Entity, bool> __9__1_75
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_75, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_75, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001204 RID: 4612
			// (get) Token: 0x06004A09 RID: 18953 RVA: 0x00193898 File Offset: 0x00191A98
			// (set) Token: 0x06004A0A RID: 18954 RVA: 0x0001952F File Offset: 0x0001772F
			public unsafe static Func<WormPlaymat, Entity> __9__1_38
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_38, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_38, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001205 RID: 4613
			// (get) Token: 0x06004A0B RID: 18955 RVA: 0x001938C0 File Offset: 0x00191AC0
			// (set) Token: 0x06004A0C RID: 18956 RVA: 0x00019541 File Offset: 0x00017741
			public unsafe static Func<Entity, bool> __9__1_76
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_76, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_76, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001206 RID: 4614
			// (get) Token: 0x06004A0D RID: 18957 RVA: 0x001938E8 File Offset: 0x00191AE8
			// (set) Token: 0x06004A0E RID: 18958 RVA: 0x00019553 File Offset: 0x00017753
			public unsafe static Func<WormPlaymat, Entity> __9__1_44
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_44, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_44, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001207 RID: 4615
			// (get) Token: 0x06004A0F RID: 18959 RVA: 0x00193910 File Offset: 0x00191B10
			// (set) Token: 0x06004A10 RID: 18960 RVA: 0x00019565 File Offset: 0x00017765
			public unsafe static Func<Entity, bool> __9__1_77
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_77, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_77, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001208 RID: 4616
			// (get) Token: 0x06004A11 RID: 18961 RVA: 0x00193938 File Offset: 0x00191B38
			// (set) Token: 0x06004A12 RID: 18962 RVA: 0x00019577 File Offset: 0x00017777
			public unsafe static Func<WormPlaymat, Entity> __9__1_45
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_45, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_45, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001209 RID: 4617
			// (get) Token: 0x06004A13 RID: 18963 RVA: 0x00193960 File Offset: 0x00191B60
			// (set) Token: 0x06004A14 RID: 18964 RVA: 0x00019589 File Offset: 0x00017789
			public unsafe static Func<Entity, bool> __9__1_78
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_78, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_78, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700120A RID: 4618
			// (get) Token: 0x06004A15 RID: 18965 RVA: 0x00193988 File Offset: 0x00191B88
			// (set) Token: 0x06004A16 RID: 18966 RVA: 0x0001959B File Offset: 0x0001779B
			public unsafe static Func<WormPlaymat, Entity> __9__1_46
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_46, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_46, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700120B RID: 4619
			// (get) Token: 0x06004A17 RID: 18967 RVA: 0x001939B0 File Offset: 0x00191BB0
			// (set) Token: 0x06004A18 RID: 18968 RVA: 0x000195AD File Offset: 0x000177AD
			public unsafe static Func<Entity, bool> __9__1_79
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_79, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_79, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700120C RID: 4620
			// (get) Token: 0x06004A19 RID: 18969 RVA: 0x001939D8 File Offset: 0x00191BD8
			// (set) Token: 0x06004A1A RID: 18970 RVA: 0x000195BF File Offset: 0x000177BF
			public unsafe static Func<WormPlaymat, Entity> __9__1_47
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_47, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__1_47, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700120D RID: 4621
			// (get) Token: 0x06004A1B RID: 18971 RVA: 0x00193A00 File Offset: 0x00191C00
			// (set) Token: 0x06004A1C RID: 18972 RVA: 0x000195D1 File Offset: 0x000177D1
			public unsafe static Func<WormPlayer, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700120E RID: 4622
			// (get) Token: 0x06004A1D RID: 18973 RVA: 0x00193A28 File Offset: 0x00191C28
			// (set) Token: 0x06004A1E RID: 18974 RVA: 0x000195E3 File Offset: 0x000177E3
			public unsafe static Func<WormPlayer, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700120F RID: 4623
			// (get) Token: 0x06004A1F RID: 18975 RVA: 0x00193A50 File Offset: 0x00191C50
			// (set) Token: 0x06004A20 RID: 18976 RVA: 0x000195F5 File Offset: 0x000177F5
			public unsafe static Func<WormPlayer, bool> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001210 RID: 4624
			// (get) Token: 0x06004A21 RID: 18977 RVA: 0x00193A78 File Offset: 0x00191C78
			// (set) Token: 0x06004A22 RID: 18978 RVA: 0x00019607 File Offset: 0x00017807
			public unsafe static Func<WormPlayer, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001211 RID: 4625
			// (get) Token: 0x06004A23 RID: 18979 RVA: 0x00193AA0 File Offset: 0x00191CA0
			// (set) Token: 0x06004A24 RID: 18980 RVA: 0x00019619 File Offset: 0x00017819
			public unsafe static Func<WormPlayer, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001212 RID: 4626
			// (get) Token: 0x06004A25 RID: 18981 RVA: 0x00193AC8 File Offset: 0x00191CC8
			// (set) Token: 0x06004A26 RID: 18982 RVA: 0x0001962B File Offset: 0x0001782B
			public unsafe static Func<WormPlayer, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript1.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003049 RID: 12361
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400304A RID: 12362
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x0400304B RID: 12363
			private static readonly IntPtr NativeFieldInfoPtr___9__1_1;

			// Token: 0x0400304C RID: 12364
			private static readonly IntPtr NativeFieldInfoPtr___9__1_48;

			// Token: 0x0400304D RID: 12365
			private static readonly IntPtr NativeFieldInfoPtr___9__1_50;

			// Token: 0x0400304E RID: 12366
			private static readonly IntPtr NativeFieldInfoPtr___9__1_51;

			// Token: 0x0400304F RID: 12367
			private static readonly IntPtr NativeFieldInfoPtr___9__1_53;

			// Token: 0x04003050 RID: 12368
			private static readonly IntPtr NativeFieldInfoPtr___9__1_7;

			// Token: 0x04003051 RID: 12369
			private static readonly IntPtr NativeFieldInfoPtr___9__1_54;

			// Token: 0x04003052 RID: 12370
			private static readonly IntPtr NativeFieldInfoPtr___9__1_55;

			// Token: 0x04003053 RID: 12371
			private static readonly IntPtr NativeFieldInfoPtr___9__1_56;

			// Token: 0x04003054 RID: 12372
			private static readonly IntPtr NativeFieldInfoPtr___9__1_11;

			// Token: 0x04003055 RID: 12373
			private static readonly IntPtr NativeFieldInfoPtr___9__1_12;

			// Token: 0x04003056 RID: 12374
			private static readonly IntPtr NativeFieldInfoPtr___9__1_57;

			// Token: 0x04003057 RID: 12375
			private static readonly IntPtr NativeFieldInfoPtr___9__1_13;

			// Token: 0x04003058 RID: 12376
			private static readonly IntPtr NativeFieldInfoPtr___9__1_58;

			// Token: 0x04003059 RID: 12377
			private static readonly IntPtr NativeFieldInfoPtr___9__1_14;

			// Token: 0x0400305A RID: 12378
			private static readonly IntPtr NativeFieldInfoPtr___9__1_15;

			// Token: 0x0400305B RID: 12379
			private static readonly IntPtr NativeFieldInfoPtr___9__1_16;

			// Token: 0x0400305C RID: 12380
			private static readonly IntPtr NativeFieldInfoPtr___9__1_17;

			// Token: 0x0400305D RID: 12381
			private static readonly IntPtr NativeFieldInfoPtr___9__1_59;

			// Token: 0x0400305E RID: 12382
			private static readonly IntPtr NativeFieldInfoPtr___9__1_18;

			// Token: 0x0400305F RID: 12383
			private static readonly IntPtr NativeFieldInfoPtr___9__1_62;

			// Token: 0x04003060 RID: 12384
			private static readonly IntPtr NativeFieldInfoPtr___9__1_68;

			// Token: 0x04003061 RID: 12385
			private static readonly IntPtr NativeFieldInfoPtr___9__1_69;

			// Token: 0x04003062 RID: 12386
			private static readonly IntPtr NativeFieldInfoPtr___9__1_71;

			// Token: 0x04003063 RID: 12387
			private static readonly IntPtr NativeFieldInfoPtr___9__1_72;

			// Token: 0x04003064 RID: 12388
			private static readonly IntPtr NativeFieldInfoPtr___9__1_74;

			// Token: 0x04003065 RID: 12389
			private static readonly IntPtr NativeFieldInfoPtr___9__1_75;

			// Token: 0x04003066 RID: 12390
			private static readonly IntPtr NativeFieldInfoPtr___9__1_38;

			// Token: 0x04003067 RID: 12391
			private static readonly IntPtr NativeFieldInfoPtr___9__1_76;

			// Token: 0x04003068 RID: 12392
			private static readonly IntPtr NativeFieldInfoPtr___9__1_44;

			// Token: 0x04003069 RID: 12393
			private static readonly IntPtr NativeFieldInfoPtr___9__1_77;

			// Token: 0x0400306A RID: 12394
			private static readonly IntPtr NativeFieldInfoPtr___9__1_45;

			// Token: 0x0400306B RID: 12395
			private static readonly IntPtr NativeFieldInfoPtr___9__1_78;

			// Token: 0x0400306C RID: 12396
			private static readonly IntPtr NativeFieldInfoPtr___9__1_46;

			// Token: 0x0400306D RID: 12397
			private static readonly IntPtr NativeFieldInfoPtr___9__1_79;

			// Token: 0x0400306E RID: 12398
			private static readonly IntPtr NativeFieldInfoPtr___9__1_47;

			// Token: 0x0400306F RID: 12399
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04003070 RID: 12400
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04003071 RID: 12401
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04003072 RID: 12402
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04003073 RID: 12403
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04003074 RID: 12404
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04003075 RID: 12405
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003076 RID: 12406
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x04003077 RID: 12407
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_1_Internal_Boolean_WormPlayer_0;

			// Token: 0x04003078 RID: 12408
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_48_Internal_Boolean_Entity_0;

			// Token: 0x04003079 RID: 12409
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_50_Internal_Boolean_Entity_0;

			// Token: 0x0400307A RID: 12410
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_51_Internal_Boolean_Entity_0;

			// Token: 0x0400307B RID: 12411
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_53_Internal_Boolean_Entity_0;

			// Token: 0x0400307C RID: 12412
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_7_Internal_Boolean_Entity_0;

			// Token: 0x0400307D RID: 12413
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_54_Internal_Boolean_Entity_0;

			// Token: 0x0400307E RID: 12414
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_55_Internal_Boolean_Entity_0;

			// Token: 0x0400307F RID: 12415
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_11_Internal_Entity_WormPlaymat_0;

			// Token: 0x04003080 RID: 12416
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_56_Internal_Boolean_Entity_0;

			// Token: 0x04003081 RID: 12417
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_12_Internal_Il2CppReferenceArray_1_Entity_Context_0;

			// Token: 0x04003082 RID: 12418
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_13_Internal_Entity_WormPlaymat_0;

			// Token: 0x04003083 RID: 12419
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_57_Internal_Boolean_Entity_0;

			// Token: 0x04003084 RID: 12420
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_14_Internal_Entity_WormPlaymat_0;

			// Token: 0x04003085 RID: 12421
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_58_Internal_Boolean_Entity_0;

			// Token: 0x04003086 RID: 12422
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_15_Internal_Entity_WormPlaymat_0;

			// Token: 0x04003087 RID: 12423
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_16_Internal_Entity_WormPlaymat_0;

			// Token: 0x04003088 RID: 12424
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_17_Internal_Entity_WormPlaymat_0;

			// Token: 0x04003089 RID: 12425
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_18_Internal_Void_WormTutorialAction_0;

			// Token: 0x0400308A RID: 12426
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_59_Internal_Entity_WormPlaymat_0;

			// Token: 0x0400308B RID: 12427
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_62_Internal_Boolean_Entity_0;

			// Token: 0x0400308C RID: 12428
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_68_Internal_Boolean_Entity_0;

			// Token: 0x0400308D RID: 12429
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_69_Internal_Boolean_Entity_0;

			// Token: 0x0400308E RID: 12430
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_71_Internal_Boolean_Entity_0;

			// Token: 0x0400308F RID: 12431
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_72_Internal_Boolean_Entity_0;

			// Token: 0x04003090 RID: 12432
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_74_Internal_Boolean_Entity_0;

			// Token: 0x04003091 RID: 12433
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_38_Internal_Entity_WormPlaymat_0;

			// Token: 0x04003092 RID: 12434
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_75_Internal_Boolean_Entity_0;

			// Token: 0x04003093 RID: 12435
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_44_Internal_Entity_WormPlaymat_0;

			// Token: 0x04003094 RID: 12436
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_76_Internal_Boolean_Entity_0;

			// Token: 0x04003095 RID: 12437
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_45_Internal_Entity_WormPlaymat_0;

			// Token: 0x04003096 RID: 12438
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_77_Internal_Boolean_Entity_0;

			// Token: 0x04003097 RID: 12439
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_46_Internal_Entity_WormPlaymat_0;

			// Token: 0x04003098 RID: 12440
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_78_Internal_Boolean_Entity_0;

			// Token: 0x04003099 RID: 12441
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_47_Internal_Entity_WormPlaymat_0;

			// Token: 0x0400309A RID: 12442
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_79_Internal_Boolean_Entity_0;

			// Token: 0x0400309B RID: 12443
			private static readonly IntPtr NativeMethodInfoPtr__GetAIGarrisonTroops_b__2_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x0400309C RID: 12444
			private static readonly IntPtr NativeMethodInfoPtr__GetHumanGarrisonTroops_b__3_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x0400309D RID: 12445
			private static readonly IntPtr NativeMethodInfoPtr__GetHumanSupplyTroops_b__4_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x0400309E RID: 12446
			private static readonly IntPtr NativeMethodInfoPtr__HumanHasNoDeployedTroops_b__5_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x0400309F RID: 12447
			private static readonly IntPtr NativeMethodInfoPtr__HumanHas3DeployedTroops_b__6_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x040030A0 RID: 12448
			private static readonly IntPtr NativeMethodInfoPtr__HumanHas5DeployedTroops_b__7_0_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x020005EB RID: 1515
		[ObfuscatedName("worm.canis.data.Tutorial.WormTutorialScript1+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06004A27 RID: 18983 RVA: 0x00193AF0 File Offset: 0x00191CF0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTutorialScript1>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr);
				WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr_humanPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, "humanPlayer");
				WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr_aiPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, "aiPlayer");
				WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__49 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, "<>9__49");
				WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__52 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, "<>9__52");
				WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__60 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, "<>9__60");
				WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__61 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, "<>9__61");
				WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__63 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, "<>9__63");
				WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, "<>9__64");
				WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__65 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, "<>9__65");
				WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__66 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, "<>9__66");
				WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__67 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, "<>9__67");
				WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__70 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, "<>9__70");
				WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__73 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, "<>9__73");
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664851);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__2_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664852);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__3_Internal_Void_WormTutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664853);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__49_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664854);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__4_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664855);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__5_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664856);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__52_Internal_Boolean_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664857);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__6_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664858);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__8_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664859);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__9_Internal_Il2CppReferenceArray_1_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664860);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__10_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664861);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__19_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664862);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__60_Internal_Boolean_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664863);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__20_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664864);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__61_Internal_Boolean_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664865);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__21_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664866);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__22_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664867);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__23_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664868);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__24_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664869);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__25_Internal_Void_WormTutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664870);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__63_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664871);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__26_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664872);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__64_Internal_Boolean_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664873);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__27_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664874);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__65_Internal_Boolean_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664875);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__28_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664876);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__66_Internal_Boolean_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664877);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__29_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664878);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__67_Internal_Boolean_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664879);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__30_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664880);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__31_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664881);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__32_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664882);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__33_Internal_Void_WormTutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664883);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__70_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664884);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__34_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664885);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__35_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664886);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__36_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664887);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__73_Internal_Boolean_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664888);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__37_Internal_Il2CppReferenceArray_1_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664889);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__39_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664890);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__40_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664891);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__41_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664892);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__42_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664893);
				WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__43_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr, 100664894);
			}

			// Token: 0x06004A28 RID: 18984 RVA: 0x00193F90 File Offset: 0x00192190
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialScript1.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A29 RID: 18985 RVA: 0x00193FCC File Offset: 0x001921CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53926, XrefRangeEnd = 53945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__2(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__2_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A2A RID: 18986 RVA: 0x0019401C File Offset: 0x0019221C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53945, XrefRangeEnd = 53954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _tutorialItems_b__3(WormTutorialAction a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__3_Internal_Void_WormTutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004A2B RID: 18987 RVA: 0x00194060 File Offset: 0x00192260
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53954, XrefRangeEnd = 53973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__49(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__49_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A2C RID: 18988 RVA: 0x001940B0 File Offset: 0x001922B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53973, XrefRangeEnd = 53992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__4(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__4_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A2D RID: 18989 RVA: 0x00194100 File Offset: 0x00192300
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53992, XrefRangeEnd = 54004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__5(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__5_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A2E RID: 18990 RVA: 0x00194150 File Offset: 0x00192350
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54004, XrefRangeEnd = 54010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__52(WormPlayArea garrison)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(garrison);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__52_Internal_Boolean_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A2F RID: 18991 RVA: 0x001941A0 File Offset: 0x001923A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54010, XrefRangeEnd = 54029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__6(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__6_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A30 RID: 18992 RVA: 0x001941F0 File Offset: 0x001923F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54029, XrefRangeEnd = 54033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__8(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__8_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A31 RID: 18993 RVA: 0x00194240 File Offset: 0x00192440
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54033, XrefRangeEnd = 54055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<Entity> _tutorialItems_b__9(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__9_Internal_Il2CppReferenceArray_1_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x06004A32 RID: 18994 RVA: 0x00194290 File Offset: 0x00192490
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54055, XrefRangeEnd = 54074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__10(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__10_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A33 RID: 18995 RVA: 0x001942E0 File Offset: 0x001924E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54074, XrefRangeEnd = 54086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__19(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__19_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A34 RID: 18996 RVA: 0x00194330 File Offset: 0x00192530
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54086, XrefRangeEnd = 54092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__60(WormPlayArea garrison)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(garrison);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__60_Internal_Boolean_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A35 RID: 18997 RVA: 0x00194380 File Offset: 0x00192580
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54092, XrefRangeEnd = 54104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__20(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__20_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A36 RID: 18998 RVA: 0x001943D0 File Offset: 0x001925D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54104, XrefRangeEnd = 54110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__61(WormPlayArea garrison)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(garrison);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__61_Internal_Boolean_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A37 RID: 18999 RVA: 0x00194420 File Offset: 0x00192620
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54110, XrefRangeEnd = 54114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__21(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__21_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A38 RID: 19000 RVA: 0x00194470 File Offset: 0x00192670
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54114, XrefRangeEnd = 54133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__22(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__22_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A39 RID: 19001 RVA: 0x001944C0 File Offset: 0x001926C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54133, XrefRangeEnd = 54137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__23(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__23_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A3A RID: 19002 RVA: 0x00194510 File Offset: 0x00192710
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54137, XrefRangeEnd = 54141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__24(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__24_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A3B RID: 19003 RVA: 0x00194560 File Offset: 0x00192760
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54141, XrefRangeEnd = 54150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _tutorialItems_b__25(WormTutorialAction a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__25_Internal_Void_WormTutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004A3C RID: 19004 RVA: 0x001945A4 File Offset: 0x001927A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54150, XrefRangeEnd = 54154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__63(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__63_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A3D RID: 19005 RVA: 0x001945F4 File Offset: 0x001927F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54154, XrefRangeEnd = 54166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__26(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__26_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A3E RID: 19006 RVA: 0x00194644 File Offset: 0x00192844
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54166, XrefRangeEnd = 54172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__64(WormPlayArea garrison)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(garrison);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__64_Internal_Boolean_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A3F RID: 19007 RVA: 0x00194694 File Offset: 0x00192894
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54172, XrefRangeEnd = 54184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__27(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__27_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A40 RID: 19008 RVA: 0x001946E4 File Offset: 0x001928E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54184, XrefRangeEnd = 54190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__65(WormPlayArea garrison)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(garrison);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__65_Internal_Boolean_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A41 RID: 19009 RVA: 0x00194734 File Offset: 0x00192934
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54190, XrefRangeEnd = 54202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__28(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__28_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A42 RID: 19010 RVA: 0x00194784 File Offset: 0x00192984
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54202, XrefRangeEnd = 54208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__66(WormPlayArea garrison)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(garrison);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__66_Internal_Boolean_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A43 RID: 19011 RVA: 0x001947D4 File Offset: 0x001929D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54208, XrefRangeEnd = 54220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__29(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__29_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A44 RID: 19012 RVA: 0x00194824 File Offset: 0x00192A24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54220, XrefRangeEnd = 54226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__67(WormPlayArea garrison)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(garrison);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__67_Internal_Boolean_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A45 RID: 19013 RVA: 0x00194874 File Offset: 0x00192A74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54226, XrefRangeEnd = 54230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__30(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__30_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A46 RID: 19014 RVA: 0x001948C4 File Offset: 0x00192AC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54230, XrefRangeEnd = 54249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__31(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__31_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A47 RID: 19015 RVA: 0x00194914 File Offset: 0x00192B14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54249, XrefRangeEnd = 54268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__32(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__32_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A48 RID: 19016 RVA: 0x00194964 File Offset: 0x00192B64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54268, XrefRangeEnd = 54277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _tutorialItems_b__33(WormTutorialAction a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__33_Internal_Void_WormTutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004A49 RID: 19017 RVA: 0x001949A8 File Offset: 0x00192BA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54277, XrefRangeEnd = 54296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__70(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__70_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A4A RID: 19018 RVA: 0x001949F8 File Offset: 0x00192BF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54296, XrefRangeEnd = 54300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__34(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__34_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A4B RID: 19019 RVA: 0x00194A48 File Offset: 0x00192C48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54300, XrefRangeEnd = 54319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__35(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__35_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A4C RID: 19020 RVA: 0x00194A98 File Offset: 0x00192C98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54319, XrefRangeEnd = 54331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__36(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__36_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A4D RID: 19021 RVA: 0x00194AE8 File Offset: 0x00192CE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54331, XrefRangeEnd = 54337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__73(WormPlayArea garrison)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(garrison);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__73_Internal_Boolean_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A4E RID: 19022 RVA: 0x00194B38 File Offset: 0x00192D38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54337, XrefRangeEnd = 54359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<Entity> _tutorialItems_b__37(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__37_Internal_Il2CppReferenceArray_1_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x06004A4F RID: 19023 RVA: 0x00194B88 File Offset: 0x00192D88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54359, XrefRangeEnd = 54363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__39(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__39_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A50 RID: 19024 RVA: 0x00194BD8 File Offset: 0x00192DD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54363, XrefRangeEnd = 54367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__40(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__40_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A51 RID: 19025 RVA: 0x00194C28 File Offset: 0x00192E28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54367, XrefRangeEnd = 54371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__41(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__41_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A52 RID: 19026 RVA: 0x00194C78 File Offset: 0x00192E78
			[CallerCount(0)]
			public unsafe Entity _tutorialItems_b__42(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__42_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A53 RID: 19027 RVA: 0x00194CC8 File Offset: 0x00192EC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54371, XrefRangeEnd = 54375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__43(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript1.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__43_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A54 RID: 19028 RVA: 0x0001963D File Offset: 0x0001783D
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001213 RID: 4627
			// (get) Token: 0x06004A55 RID: 19029 RVA: 0x00194D18 File Offset: 0x00192F18
			// (set) Token: 0x06004A56 RID: 19030 RVA: 0x00019646 File Offset: 0x00017846
			public unsafe WormPlayer humanPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr_humanPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr_humanPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001214 RID: 4628
			// (get) Token: 0x06004A57 RID: 19031 RVA: 0x00194D48 File Offset: 0x00192F48
			// (set) Token: 0x06004A58 RID: 19032 RVA: 0x00019665 File Offset: 0x00017865
			public unsafe WormPlayer aiPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr_aiPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr_aiPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001215 RID: 4629
			// (get) Token: 0x06004A59 RID: 19033 RVA: 0x00194D78 File Offset: 0x00192F78
			// (set) Token: 0x06004A5A RID: 19034 RVA: 0x00019684 File Offset: 0x00017884
			public unsafe Func<Context, Entity> __9__49
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__49);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Context, Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__49), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001216 RID: 4630
			// (get) Token: 0x06004A5B RID: 19035 RVA: 0x00194DA8 File Offset: 0x00192FA8
			// (set) Token: 0x06004A5C RID: 19036 RVA: 0x000196A3 File Offset: 0x000178A3
			public unsafe Func<WormPlayArea, bool> __9__52
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__52);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayArea, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__52), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001217 RID: 4631
			// (get) Token: 0x06004A5D RID: 19037 RVA: 0x00194DD8 File Offset: 0x00192FD8
			// (set) Token: 0x06004A5E RID: 19038 RVA: 0x000196C2 File Offset: 0x000178C2
			public unsafe Func<WormPlayArea, bool> __9__60
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__60);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayArea, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__60), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001218 RID: 4632
			// (get) Token: 0x06004A5F RID: 19039 RVA: 0x00194E08 File Offset: 0x00193008
			// (set) Token: 0x06004A60 RID: 19040 RVA: 0x000196E1 File Offset: 0x000178E1
			public unsafe Func<WormPlayArea, bool> __9__61
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__61);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayArea, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__61), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001219 RID: 4633
			// (get) Token: 0x06004A61 RID: 19041 RVA: 0x00194E38 File Offset: 0x00193038
			// (set) Token: 0x06004A62 RID: 19042 RVA: 0x00019700 File Offset: 0x00017900
			public unsafe Func<Context, Entity> __9__63
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__63);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Context, Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__63), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700121A RID: 4634
			// (get) Token: 0x06004A63 RID: 19043 RVA: 0x00194E68 File Offset: 0x00193068
			// (set) Token: 0x06004A64 RID: 19044 RVA: 0x0001971F File Offset: 0x0001791F
			public unsafe Func<WormPlayArea, bool> __9__64
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__64);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayArea, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__64), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700121B RID: 4635
			// (get) Token: 0x06004A65 RID: 19045 RVA: 0x00194E98 File Offset: 0x00193098
			// (set) Token: 0x06004A66 RID: 19046 RVA: 0x0001973E File Offset: 0x0001793E
			public unsafe Func<WormPlayArea, bool> __9__65
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__65);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayArea, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__65), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700121C RID: 4636
			// (get) Token: 0x06004A67 RID: 19047 RVA: 0x00194EC8 File Offset: 0x001930C8
			// (set) Token: 0x06004A68 RID: 19048 RVA: 0x0001975D File Offset: 0x0001795D
			public unsafe Func<WormPlayArea, bool> __9__66
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__66);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayArea, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__66), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700121D RID: 4637
			// (get) Token: 0x06004A69 RID: 19049 RVA: 0x00194EF8 File Offset: 0x001930F8
			// (set) Token: 0x06004A6A RID: 19050 RVA: 0x0001977C File Offset: 0x0001797C
			public unsafe Func<WormPlayArea, bool> __9__67
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__67);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayArea, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__67), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700121E RID: 4638
			// (get) Token: 0x06004A6B RID: 19051 RVA: 0x00194F28 File Offset: 0x00193128
			// (set) Token: 0x06004A6C RID: 19052 RVA: 0x0001979B File Offset: 0x0001799B
			public unsafe Func<Context, Entity> __9__70
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__70);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Context, Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__70), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700121F RID: 4639
			// (get) Token: 0x06004A6D RID: 19053 RVA: 0x00194F58 File Offset: 0x00193158
			// (set) Token: 0x06004A6E RID: 19054 RVA: 0x000197BA File Offset: 0x000179BA
			public unsafe Func<WormPlayArea, bool> __9__73
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__73);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayArea, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript1.__c__DisplayClass1_0.NativeFieldInfoPtr___9__73), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040030A1 RID: 12449
			private static readonly IntPtr NativeFieldInfoPtr_humanPlayer;

			// Token: 0x040030A2 RID: 12450
			private static readonly IntPtr NativeFieldInfoPtr_aiPlayer;

			// Token: 0x040030A3 RID: 12451
			private static readonly IntPtr NativeFieldInfoPtr___9__49;

			// Token: 0x040030A4 RID: 12452
			private static readonly IntPtr NativeFieldInfoPtr___9__52;

			// Token: 0x040030A5 RID: 12453
			private static readonly IntPtr NativeFieldInfoPtr___9__60;

			// Token: 0x040030A6 RID: 12454
			private static readonly IntPtr NativeFieldInfoPtr___9__61;

			// Token: 0x040030A7 RID: 12455
			private static readonly IntPtr NativeFieldInfoPtr___9__63;

			// Token: 0x040030A8 RID: 12456
			private static readonly IntPtr NativeFieldInfoPtr___9__64;

			// Token: 0x040030A9 RID: 12457
			private static readonly IntPtr NativeFieldInfoPtr___9__65;

			// Token: 0x040030AA RID: 12458
			private static readonly IntPtr NativeFieldInfoPtr___9__66;

			// Token: 0x040030AB RID: 12459
			private static readonly IntPtr NativeFieldInfoPtr___9__67;

			// Token: 0x040030AC RID: 12460
			private static readonly IntPtr NativeFieldInfoPtr___9__70;

			// Token: 0x040030AD RID: 12461
			private static readonly IntPtr NativeFieldInfoPtr___9__73;

			// Token: 0x040030AE RID: 12462
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040030AF RID: 12463
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__2_Internal_Entity_Context_0;

			// Token: 0x040030B0 RID: 12464
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__3_Internal_Void_WormTutorialAction_0;

			// Token: 0x040030B1 RID: 12465
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__49_Internal_Entity_Context_0;

			// Token: 0x040030B2 RID: 12466
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__4_Internal_Entity_Context_0;

			// Token: 0x040030B3 RID: 12467
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__5_Internal_Entity_WormPlaymat_0;

			// Token: 0x040030B4 RID: 12468
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__52_Internal_Boolean_WormPlayArea_0;

			// Token: 0x040030B5 RID: 12469
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__6_Internal_Entity_Context_0;

			// Token: 0x040030B6 RID: 12470
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__8_Internal_Entity_Context_0;

			// Token: 0x040030B7 RID: 12471
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__9_Internal_Il2CppReferenceArray_1_Entity_Context_0;

			// Token: 0x040030B8 RID: 12472
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__10_Internal_Entity_Context_0;

			// Token: 0x040030B9 RID: 12473
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__19_Internal_Entity_WormPlaymat_0;

			// Token: 0x040030BA RID: 12474
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__60_Internal_Boolean_WormPlayArea_0;

			// Token: 0x040030BB RID: 12475
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__20_Internal_Entity_WormPlaymat_0;

			// Token: 0x040030BC RID: 12476
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__61_Internal_Boolean_WormPlayArea_0;

			// Token: 0x040030BD RID: 12477
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__21_Internal_Entity_Context_0;

			// Token: 0x040030BE RID: 12478
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__22_Internal_Entity_Context_0;

			// Token: 0x040030BF RID: 12479
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__23_Internal_Entity_Context_0;

			// Token: 0x040030C0 RID: 12480
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__24_Internal_Entity_Context_0;

			// Token: 0x040030C1 RID: 12481
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__25_Internal_Void_WormTutorialAction_0;

			// Token: 0x040030C2 RID: 12482
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__63_Internal_Entity_Context_0;

			// Token: 0x040030C3 RID: 12483
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__26_Internal_Entity_WormPlaymat_0;

			// Token: 0x040030C4 RID: 12484
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__64_Internal_Boolean_WormPlayArea_0;

			// Token: 0x040030C5 RID: 12485
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__27_Internal_Entity_WormPlaymat_0;

			// Token: 0x040030C6 RID: 12486
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__65_Internal_Boolean_WormPlayArea_0;

			// Token: 0x040030C7 RID: 12487
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__28_Internal_Entity_WormPlaymat_0;

			// Token: 0x040030C8 RID: 12488
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__66_Internal_Boolean_WormPlayArea_0;

			// Token: 0x040030C9 RID: 12489
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__29_Internal_Entity_WormPlaymat_0;

			// Token: 0x040030CA RID: 12490
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__67_Internal_Boolean_WormPlayArea_0;

			// Token: 0x040030CB RID: 12491
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__30_Internal_Entity_Context_0;

			// Token: 0x040030CC RID: 12492
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__31_Internal_Entity_Context_0;

			// Token: 0x040030CD RID: 12493
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__32_Internal_Entity_Context_0;

			// Token: 0x040030CE RID: 12494
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__33_Internal_Void_WormTutorialAction_0;

			// Token: 0x040030CF RID: 12495
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__70_Internal_Entity_Context_0;

			// Token: 0x040030D0 RID: 12496
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__34_Internal_Entity_Context_0;

			// Token: 0x040030D1 RID: 12497
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__35_Internal_Entity_Context_0;

			// Token: 0x040030D2 RID: 12498
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__36_Internal_Entity_WormPlaymat_0;

			// Token: 0x040030D3 RID: 12499
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__73_Internal_Boolean_WormPlayArea_0;

			// Token: 0x040030D4 RID: 12500
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__37_Internal_Il2CppReferenceArray_1_Entity_Context_0;

			// Token: 0x040030D5 RID: 12501
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__39_Internal_Entity_Context_0;

			// Token: 0x040030D6 RID: 12502
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__40_Internal_Entity_Context_0;

			// Token: 0x040030D7 RID: 12503
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__41_Internal_Entity_Context_0;

			// Token: 0x040030D8 RID: 12504
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__42_Internal_Entity_Context_0;

			// Token: 0x040030D9 RID: 12505
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__43_Internal_Entity_Context_0;
		}
	}
}
