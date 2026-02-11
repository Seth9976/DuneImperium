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
using worm.canis.data.enums;
using worm.canis.entities;

namespace worm.canis.data.Tutorial
{
	// Token: 0x02000049 RID: 73
	public class WormTutorialScript2 : WormTutorialScript
	{
		// Token: 0x06000A67 RID: 2663 RVA: 0x00089024 File Offset: 0x00087224
		// Note: this type is marked as 'beforefieldinit'.
		static WormTutorialScript2()
		{
			Il2CppClassPointerStore<WormTutorialScript2>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Tutorial", "WormTutorialScript2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialScript2>.NativeClassPtr);
			WormTutorialScript2.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2>.NativeClassPtr, 100664895);
			WormTutorialScript2.NativeMethodInfoPtr_tutorialItems_Protected_Virtual_IEnumerable_1_TutorialItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2>.NativeClassPtr, 100664896);
			WormTutorialScript2.NativeMethodInfoPtr_Check4VPScore_Private_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2>.NativeClassPtr, 100664897);
			WormTutorialScript2.NativeMethodInfoPtr_GetAIGarrisonTroops_Private_IEnumerable_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2>.NativeClassPtr, 100664898);
			WormTutorialScript2.NativeMethodInfoPtr_GetHumanGarrisonTroops_Private_IEnumerable_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2>.NativeClassPtr, 100664899);
			WormTutorialScript2.NativeMethodInfoPtr_FactionTrack_Private_WormFactionTrack_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2>.NativeClassPtr, 100664900);
			WormTutorialScript2.NativeMethodInfoPtr_AIHas4Strength_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2>.NativeClassPtr, 100664901);
			WormTutorialScript2.NativeMethodInfoPtr_AIHas8Strength_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2>.NativeClassPtr, 100664902);
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x000890F4 File Offset: 0x000872F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54376, RefRangeEnd = 54377, XrefRangeStart = 54376, XrefRangeEnd = 54377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTutorialScript2(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialScript2>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x00089140 File Offset: 0x00087340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59442, XrefRangeEnd = 61900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<AdvancedTutorialScript.TutorialItem> tutorialItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTutorialScript2.NativeMethodInfoPtr_tutorialItems_Protected_Virtual_IEnumerable_1_TutorialItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AdvancedTutorialScript.TutorialItem>>(intPtr3) : null;
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x0008918C File Offset: 0x0008738C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61900, XrefRangeEnd = 61921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Check4VPScore(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.NativeMethodInfoPtr_Check4VPScore_Private_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x000891DC File Offset: 0x000873DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61921, XrefRangeEnd = 61946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Entity> GetAIGarrisonTroops()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.NativeMethodInfoPtr_GetAIGarrisonTroops_Private_IEnumerable_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x0008921C File Offset: 0x0008741C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61946, XrefRangeEnd = 61971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Entity> GetHumanGarrisonTroops()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.NativeMethodInfoPtr_GetHumanGarrisonTroops_Private_IEnumerable_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x0008925C File Offset: 0x0008745C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 61989, RefRangeEnd = 62001, XrefRangeStart = 61971, XrefRangeEnd = 61989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormFactionTrack FactionTrack(Factions faction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref faction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.NativeMethodInfoPtr_FactionTrack_Private_WormFactionTrack_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormFactionTrack>(intPtr3) : null;
			}
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x000892A8 File Offset: 0x000874A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62001, XrefRangeEnd = 62021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AIHas4Strength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.NativeMethodInfoPtr_AIHas4Strength_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x000892E4 File Offset: 0x000874E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62021, XrefRangeEnd = 62041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AIHas8Strength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.NativeMethodInfoPtr_AIHas8Strength_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00006B7D File Offset: 0x00004D7D
		public WormTutorialScript2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000678 RID: 1656
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04000679 RID: 1657
		private static readonly IntPtr NativeMethodInfoPtr_tutorialItems_Protected_Virtual_IEnumerable_1_TutorialItem_0;

		// Token: 0x0400067A RID: 1658
		private static readonly IntPtr NativeMethodInfoPtr_Check4VPScore_Private_Boolean_Context_0;

		// Token: 0x0400067B RID: 1659
		private static readonly IntPtr NativeMethodInfoPtr_GetAIGarrisonTroops_Private_IEnumerable_1_Entity_0;

		// Token: 0x0400067C RID: 1660
		private static readonly IntPtr NativeMethodInfoPtr_GetHumanGarrisonTroops_Private_IEnumerable_1_Entity_0;

		// Token: 0x0400067D RID: 1661
		private static readonly IntPtr NativeMethodInfoPtr_FactionTrack_Private_WormFactionTrack_Factions_0;

		// Token: 0x0400067E RID: 1662
		private static readonly IntPtr NativeMethodInfoPtr_AIHas4Strength_Private_Boolean_0;

		// Token: 0x0400067F RID: 1663
		private static readonly IntPtr NativeMethodInfoPtr_AIHas8Strength_Private_Boolean_0;

		// Token: 0x020005EC RID: 1516
		[ObfuscatedName("worm.canis.data.Tutorial.WormTutorialScript2+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06004A6F RID: 19055 RVA: 0x00194F88 File Offset: 0x00193188
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTutorialScript2>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr);
				WormTutorialScript2.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, "<>9");
				WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, "<>9__1_0");
				WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, "<>9__1_1");
				WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_30 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, "<>9__1_30");
				WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_31 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, "<>9__1_31");
				WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, "<>9__1_32");
				WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_34 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, "<>9__1_34");
				WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, "<>9__1_16");
				WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_35 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, "<>9__1_35");
				WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, "<>9__1_17");
				WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_39 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, "<>9__1_39");
				WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_27 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, "<>9__1_27");
				WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_40 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, "<>9__1_40");
				WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_28 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, "<>9__1_28");
				WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_29 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, "<>9__1_29");
				WormTutorialScript2.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, "<>9__2_0");
				WormTutorialScript2.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, "<>9__3_0");
				WormTutorialScript2.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, "<>9__4_0");
				WormTutorialScript2.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, "<>9__6_0");
				WormTutorialScript2.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, "<>9__7_0");
				WormTutorialScript2.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, 100664904);
				WormTutorialScript2.__c.NativeMethodInfoPtr__tutorialItems_b__1_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, 100664905);
				WormTutorialScript2.__c.NativeMethodInfoPtr__tutorialItems_b__1_1_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, 100664906);
				WormTutorialScript2.__c.NativeMethodInfoPtr__tutorialItems_b__1_30_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, 100664907);
				WormTutorialScript2.__c.NativeMethodInfoPtr__tutorialItems_b__1_31_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, 100664908);
				WormTutorialScript2.__c.NativeMethodInfoPtr__tutorialItems_b__1_32_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, 100664909);
				WormTutorialScript2.__c.NativeMethodInfoPtr__tutorialItems_b__1_16_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, 100664910);
				WormTutorialScript2.__c.NativeMethodInfoPtr__tutorialItems_b__1_34_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, 100664911);
				WormTutorialScript2.__c.NativeMethodInfoPtr__tutorialItems_b__1_17_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, 100664912);
				WormTutorialScript2.__c.NativeMethodInfoPtr__tutorialItems_b__1_35_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, 100664913);
				WormTutorialScript2.__c.NativeMethodInfoPtr__tutorialItems_b__1_27_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, 100664914);
				WormTutorialScript2.__c.NativeMethodInfoPtr__tutorialItems_b__1_39_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, 100664915);
				WormTutorialScript2.__c.NativeMethodInfoPtr__tutorialItems_b__1_28_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, 100664916);
				WormTutorialScript2.__c.NativeMethodInfoPtr__tutorialItems_b__1_40_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, 100664917);
				WormTutorialScript2.__c.NativeMethodInfoPtr__tutorialItems_b__1_29_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, 100664918);
				WormTutorialScript2.__c.NativeMethodInfoPtr__Check4VPScore_b__2_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, 100664919);
				WormTutorialScript2.__c.NativeMethodInfoPtr__GetAIGarrisonTroops_b__3_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, 100664920);
				WormTutorialScript2.__c.NativeMethodInfoPtr__GetHumanGarrisonTroops_b__4_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, 100664921);
				WormTutorialScript2.__c.NativeMethodInfoPtr__AIHas4Strength_b__6_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, 100664922);
				WormTutorialScript2.__c.NativeMethodInfoPtr__AIHas8Strength_b__7_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr, 100664923);
			}

			// Token: 0x06004A70 RID: 19056 RVA: 0x001952D4 File Offset: 0x001934D4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialScript2.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A71 RID: 19057 RVA: 0x00195310 File Offset: 0x00193510
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c.NativeMethodInfoPtr__tutorialItems_b__1_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A72 RID: 19058 RVA: 0x00195360 File Offset: 0x00193560
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c.NativeMethodInfoPtr__tutorialItems_b__1_1_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A73 RID: 19059 RVA: 0x001953B0 File Offset: 0x001935B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59120, XrefRangeEnd = 59129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_30(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c.NativeMethodInfoPtr__tutorialItems_b__1_30_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A74 RID: 19060 RVA: 0x00195400 File Offset: 0x00193600
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59129, XrefRangeEnd = 59138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_31(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c.NativeMethodInfoPtr__tutorialItems_b__1_31_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A75 RID: 19061 RVA: 0x00195450 File Offset: 0x00193650
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59138, XrefRangeEnd = 59147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_32(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c.NativeMethodInfoPtr__tutorialItems_b__1_32_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A76 RID: 19062 RVA: 0x001954A0 File Offset: 0x001936A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59147, XrefRangeEnd = 59166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__1_16(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c.NativeMethodInfoPtr__tutorialItems_b__1_16_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A77 RID: 19063 RVA: 0x001954F0 File Offset: 0x001936F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59166, XrefRangeEnd = 59175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_34(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c.NativeMethodInfoPtr__tutorialItems_b__1_34_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A78 RID: 19064 RVA: 0x00195540 File Offset: 0x00193740
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59175, XrefRangeEnd = 59194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__1_17(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c.NativeMethodInfoPtr__tutorialItems_b__1_17_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A79 RID: 19065 RVA: 0x00195590 File Offset: 0x00193790
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59194, XrefRangeEnd = 59203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_35(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c.NativeMethodInfoPtr__tutorialItems_b__1_35_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A7A RID: 19066 RVA: 0x001955E0 File Offset: 0x001937E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59203, XrefRangeEnd = 59222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__1_27(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c.NativeMethodInfoPtr__tutorialItems_b__1_27_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A7B RID: 19067 RVA: 0x00195630 File Offset: 0x00193830
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59222, XrefRangeEnd = 59231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_39(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c.NativeMethodInfoPtr__tutorialItems_b__1_39_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A7C RID: 19068 RVA: 0x00195680 File Offset: 0x00193880
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59231, XrefRangeEnd = 59250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__1_28(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c.NativeMethodInfoPtr__tutorialItems_b__1_28_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A7D RID: 19069 RVA: 0x001956D0 File Offset: 0x001938D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59250, XrefRangeEnd = 59259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__1_40(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c.NativeMethodInfoPtr__tutorialItems_b__1_40_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A7E RID: 19070 RVA: 0x00195720 File Offset: 0x00193920
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59259, XrefRangeEnd = 59263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__1_29(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c.NativeMethodInfoPtr__tutorialItems_b__1_29_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004A7F RID: 19071 RVA: 0x00195770 File Offset: 0x00193970
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Check4VPScore_b__2_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c.NativeMethodInfoPtr__Check4VPScore_b__2_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A80 RID: 19072 RVA: 0x001957C0 File Offset: 0x001939C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAIGarrisonTroops_b__3_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c.NativeMethodInfoPtr__GetAIGarrisonTroops_b__3_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A81 RID: 19073 RVA: 0x00195810 File Offset: 0x00193A10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetHumanGarrisonTroops_b__4_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c.NativeMethodInfoPtr__GetHumanGarrisonTroops_b__4_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A82 RID: 19074 RVA: 0x00195860 File Offset: 0x00193A60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AIHas4Strength_b__6_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c.NativeMethodInfoPtr__AIHas4Strength_b__6_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A83 RID: 19075 RVA: 0x001958B0 File Offset: 0x00193AB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AIHas8Strength_b__7_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c.NativeMethodInfoPtr__AIHas8Strength_b__7_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A84 RID: 19076 RVA: 0x000197D9 File Offset: 0x000179D9
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001220 RID: 4640
			// (get) Token: 0x06004A85 RID: 19077 RVA: 0x00195900 File Offset: 0x00193B00
			// (set) Token: 0x06004A86 RID: 19078 RVA: 0x000197E2 File Offset: 0x000179E2
			public unsafe static WormTutorialScript2.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTutorialScript2.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001221 RID: 4641
			// (get) Token: 0x06004A87 RID: 19079 RVA: 0x00195928 File Offset: 0x00193B28
			// (set) Token: 0x06004A88 RID: 19080 RVA: 0x000197F4 File Offset: 0x000179F4
			public unsafe static Func<WormPlayer, bool> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001222 RID: 4642
			// (get) Token: 0x06004A89 RID: 19081 RVA: 0x00195950 File Offset: 0x00193B50
			// (set) Token: 0x06004A8A RID: 19082 RVA: 0x00019806 File Offset: 0x00017A06
			public unsafe static Func<WormPlayer, bool> __9__1_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001223 RID: 4643
			// (get) Token: 0x06004A8B RID: 19083 RVA: 0x00195978 File Offset: 0x00193B78
			// (set) Token: 0x06004A8C RID: 19084 RVA: 0x00019818 File Offset: 0x00017A18
			public unsafe static Func<Entity, bool> __9__1_30
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_30, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_30, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001224 RID: 4644
			// (get) Token: 0x06004A8D RID: 19085 RVA: 0x001959A0 File Offset: 0x00193BA0
			// (set) Token: 0x06004A8E RID: 19086 RVA: 0x0001982A File Offset: 0x00017A2A
			public unsafe static Func<Entity, bool> __9__1_31
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_31, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_31, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001225 RID: 4645
			// (get) Token: 0x06004A8F RID: 19087 RVA: 0x001959C8 File Offset: 0x00193BC8
			// (set) Token: 0x06004A90 RID: 19088 RVA: 0x0001983C File Offset: 0x00017A3C
			public unsafe static Func<Entity, bool> __9__1_32
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_32, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_32, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001226 RID: 4646
			// (get) Token: 0x06004A91 RID: 19089 RVA: 0x001959F0 File Offset: 0x00193BF0
			// (set) Token: 0x06004A92 RID: 19090 RVA: 0x0001984E File Offset: 0x00017A4E
			public unsafe static Func<Entity, bool> __9__1_34
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_34, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_34, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001227 RID: 4647
			// (get) Token: 0x06004A93 RID: 19091 RVA: 0x00195A18 File Offset: 0x00193C18
			// (set) Token: 0x06004A94 RID: 19092 RVA: 0x00019860 File Offset: 0x00017A60
			public unsafe static Func<WormPlaymat, Entity> __9__1_16
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_16, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_16, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001228 RID: 4648
			// (get) Token: 0x06004A95 RID: 19093 RVA: 0x00195A40 File Offset: 0x00193C40
			// (set) Token: 0x06004A96 RID: 19094 RVA: 0x00019872 File Offset: 0x00017A72
			public unsafe static Func<Entity, bool> __9__1_35
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_35, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_35, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001229 RID: 4649
			// (get) Token: 0x06004A97 RID: 19095 RVA: 0x00195A68 File Offset: 0x00193C68
			// (set) Token: 0x06004A98 RID: 19096 RVA: 0x00019884 File Offset: 0x00017A84
			public unsafe static Func<WormPlaymat, Entity> __9__1_17
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_17, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_17, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700122A RID: 4650
			// (get) Token: 0x06004A99 RID: 19097 RVA: 0x00195A90 File Offset: 0x00193C90
			// (set) Token: 0x06004A9A RID: 19098 RVA: 0x00019896 File Offset: 0x00017A96
			public unsafe static Func<Entity, bool> __9__1_39
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_39, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_39, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700122B RID: 4651
			// (get) Token: 0x06004A9B RID: 19099 RVA: 0x00195AB8 File Offset: 0x00193CB8
			// (set) Token: 0x06004A9C RID: 19100 RVA: 0x000198A8 File Offset: 0x00017AA8
			public unsafe static Func<WormPlaymat, Entity> __9__1_27
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_27, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_27, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700122C RID: 4652
			// (get) Token: 0x06004A9D RID: 19101 RVA: 0x00195AE0 File Offset: 0x00193CE0
			// (set) Token: 0x06004A9E RID: 19102 RVA: 0x000198BA File Offset: 0x00017ABA
			public unsafe static Func<Entity, bool> __9__1_40
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_40, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_40, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700122D RID: 4653
			// (get) Token: 0x06004A9F RID: 19103 RVA: 0x00195B08 File Offset: 0x00193D08
			// (set) Token: 0x06004AA0 RID: 19104 RVA: 0x000198CC File Offset: 0x00017ACC
			public unsafe static Func<WormPlaymat, Entity> __9__1_28
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_28, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_28, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700122E RID: 4654
			// (get) Token: 0x06004AA1 RID: 19105 RVA: 0x00195B30 File Offset: 0x00193D30
			// (set) Token: 0x06004AA2 RID: 19106 RVA: 0x000198DE File Offset: 0x00017ADE
			public unsafe static Func<WormPlaymat, Entity> __9__1_29
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_29, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__1_29, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700122F RID: 4655
			// (get) Token: 0x06004AA3 RID: 19107 RVA: 0x00195B58 File Offset: 0x00193D58
			// (set) Token: 0x06004AA4 RID: 19108 RVA: 0x000198F0 File Offset: 0x00017AF0
			public unsafe static Func<WormPlayer, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001230 RID: 4656
			// (get) Token: 0x06004AA5 RID: 19109 RVA: 0x00195B80 File Offset: 0x00193D80
			// (set) Token: 0x06004AA6 RID: 19110 RVA: 0x00019902 File Offset: 0x00017B02
			public unsafe static Func<WormPlayer, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001231 RID: 4657
			// (get) Token: 0x06004AA7 RID: 19111 RVA: 0x00195BA8 File Offset: 0x00193DA8
			// (set) Token: 0x06004AA8 RID: 19112 RVA: 0x00019914 File Offset: 0x00017B14
			public unsafe static Func<WormPlayer, bool> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001232 RID: 4658
			// (get) Token: 0x06004AA9 RID: 19113 RVA: 0x00195BD0 File Offset: 0x00193DD0
			// (set) Token: 0x06004AAA RID: 19114 RVA: 0x00019926 File Offset: 0x00017B26
			public unsafe static Func<WormPlayer, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001233 RID: 4659
			// (get) Token: 0x06004AAB RID: 19115 RVA: 0x00195BF8 File Offset: 0x00193DF8
			// (set) Token: 0x06004AAC RID: 19116 RVA: 0x00019938 File Offset: 0x00017B38
			public unsafe static Func<WormPlayer, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript2.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040030DA RID: 12506
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040030DB RID: 12507
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x040030DC RID: 12508
			private static readonly IntPtr NativeFieldInfoPtr___9__1_1;

			// Token: 0x040030DD RID: 12509
			private static readonly IntPtr NativeFieldInfoPtr___9__1_30;

			// Token: 0x040030DE RID: 12510
			private static readonly IntPtr NativeFieldInfoPtr___9__1_31;

			// Token: 0x040030DF RID: 12511
			private static readonly IntPtr NativeFieldInfoPtr___9__1_32;

			// Token: 0x040030E0 RID: 12512
			private static readonly IntPtr NativeFieldInfoPtr___9__1_34;

			// Token: 0x040030E1 RID: 12513
			private static readonly IntPtr NativeFieldInfoPtr___9__1_16;

			// Token: 0x040030E2 RID: 12514
			private static readonly IntPtr NativeFieldInfoPtr___9__1_35;

			// Token: 0x040030E3 RID: 12515
			private static readonly IntPtr NativeFieldInfoPtr___9__1_17;

			// Token: 0x040030E4 RID: 12516
			private static readonly IntPtr NativeFieldInfoPtr___9__1_39;

			// Token: 0x040030E5 RID: 12517
			private static readonly IntPtr NativeFieldInfoPtr___9__1_27;

			// Token: 0x040030E6 RID: 12518
			private static readonly IntPtr NativeFieldInfoPtr___9__1_40;

			// Token: 0x040030E7 RID: 12519
			private static readonly IntPtr NativeFieldInfoPtr___9__1_28;

			// Token: 0x040030E8 RID: 12520
			private static readonly IntPtr NativeFieldInfoPtr___9__1_29;

			// Token: 0x040030E9 RID: 12521
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x040030EA RID: 12522
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x040030EB RID: 12523
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x040030EC RID: 12524
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x040030ED RID: 12525
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x040030EE RID: 12526
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040030EF RID: 12527
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x040030F0 RID: 12528
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_1_Internal_Boolean_WormPlayer_0;

			// Token: 0x040030F1 RID: 12529
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_30_Internal_Boolean_Entity_0;

			// Token: 0x040030F2 RID: 12530
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_31_Internal_Boolean_Entity_0;

			// Token: 0x040030F3 RID: 12531
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_32_Internal_Boolean_Entity_0;

			// Token: 0x040030F4 RID: 12532
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_16_Internal_Entity_WormPlaymat_0;

			// Token: 0x040030F5 RID: 12533
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_34_Internal_Boolean_Entity_0;

			// Token: 0x040030F6 RID: 12534
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_17_Internal_Entity_WormPlaymat_0;

			// Token: 0x040030F7 RID: 12535
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_35_Internal_Boolean_Entity_0;

			// Token: 0x040030F8 RID: 12536
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_27_Internal_Entity_WormPlaymat_0;

			// Token: 0x040030F9 RID: 12537
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_39_Internal_Boolean_Entity_0;

			// Token: 0x040030FA RID: 12538
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_28_Internal_Entity_WormPlaymat_0;

			// Token: 0x040030FB RID: 12539
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_40_Internal_Boolean_Entity_0;

			// Token: 0x040030FC RID: 12540
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_29_Internal_Entity_WormPlaymat_0;

			// Token: 0x040030FD RID: 12541
			private static readonly IntPtr NativeMethodInfoPtr__Check4VPScore_b__2_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x040030FE RID: 12542
			private static readonly IntPtr NativeMethodInfoPtr__GetAIGarrisonTroops_b__3_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x040030FF RID: 12543
			private static readonly IntPtr NativeMethodInfoPtr__GetHumanGarrisonTroops_b__4_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x04003100 RID: 12544
			private static readonly IntPtr NativeMethodInfoPtr__AIHas4Strength_b__6_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x04003101 RID: 12545
			private static readonly IntPtr NativeMethodInfoPtr__AIHas8Strength_b__7_0_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x020005ED RID: 1517
		[ObfuscatedName("worm.canis.data.Tutorial.WormTutorialScript2+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06004AAD RID: 19117 RVA: 0x00195C20 File Offset: 0x00193E20
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTutorialScript2>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr);
				WormTutorialScript2.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, "<>4__this");
				WormTutorialScript2.__c__DisplayClass1_0.NativeFieldInfoPtr_humanPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, "humanPlayer");
				WormTutorialScript2.__c__DisplayClass1_0.NativeFieldInfoPtr_aiPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, "aiPlayer");
				WormTutorialScript2.__c__DisplayClass1_0.NativeFieldInfoPtr___9__33 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, "<>9__33");
				WormTutorialScript2.__c__DisplayClass1_0.NativeFieldInfoPtr___9__36 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, "<>9__36");
				WormTutorialScript2.__c__DisplayClass1_0.NativeFieldInfoPtr___9__37 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, "<>9__37");
				WormTutorialScript2.__c__DisplayClass1_0.NativeFieldInfoPtr___9__38 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, "<>9__38");
				WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, 100664924);
				WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__2_Internal_Il2CppReferenceArray_1_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, 100664925);
				WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__3_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, 100664926);
				WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__4_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, 100664927);
				WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__5_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, 100664928);
				WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__6_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, 100664929);
				WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__7_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, 100664930);
				WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__8_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, 100664931);
				WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__9_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, 100664932);
				WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__10_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, 100664933);
				WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__11_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, 100664934);
				WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__12_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, 100664935);
				WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__13_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, 100664936);
				WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__14_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, 100664937);
				WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__15_Internal_Void_WormTutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, 100664938);
				WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__33_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, 100664939);
				WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__18_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, 100664940);
				WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__36_Internal_Boolean_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, 100664941);
				WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__19_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, 100664942);
				WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__37_Internal_Boolean_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, 100664943);
				WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__20_Internal_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, 100664944);
				WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__21_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, 100664945);
				WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__38_Internal_Boolean_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, 100664946);
				WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__22_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, 100664947);
				WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__23_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, 100664948);
				WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__24_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, 100664949);
				WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__25_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, 100664950);
				WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__26_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr, 100664951);
			}

			// Token: 0x06004AAE RID: 19118 RVA: 0x00195F08 File Offset: 0x00194108
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004AAF RID: 19119 RVA: 0x00195F44 File Offset: 0x00194144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59263, XrefRangeEnd = 59275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<Entity> _tutorialItems_b__2(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__2_Internal_Il2CppReferenceArray_1_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x06004AB0 RID: 19120 RVA: 0x00195F94 File Offset: 0x00194194
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59275, XrefRangeEnd = 59277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__3(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__3_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004AB1 RID: 19121 RVA: 0x00195FE4 File Offset: 0x001941E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__4(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__4_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004AB2 RID: 19122 RVA: 0x00196034 File Offset: 0x00194234
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59277, XrefRangeEnd = 59296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__5(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__5_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004AB3 RID: 19123 RVA: 0x00196084 File Offset: 0x00194284
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59296, XrefRangeEnd = 59315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__6(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__6_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004AB4 RID: 19124 RVA: 0x001960D4 File Offset: 0x001942D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__7(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__7_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004AB5 RID: 19125 RVA: 0x00196124 File Offset: 0x00194324
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59315, XrefRangeEnd = 59317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__8(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__8_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004AB6 RID: 19126 RVA: 0x00196174 File Offset: 0x00194374
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__9(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__9_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004AB7 RID: 19127 RVA: 0x001961C4 File Offset: 0x001943C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59317, XrefRangeEnd = 59321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__10(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__10_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004AB8 RID: 19128 RVA: 0x00196214 File Offset: 0x00194414
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59321, XrefRangeEnd = 59340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__11(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__11_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004AB9 RID: 19129 RVA: 0x00196264 File Offset: 0x00194464
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59340, XrefRangeEnd = 59344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__12(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__12_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004ABA RID: 19130 RVA: 0x001962B4 File Offset: 0x001944B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59344, XrefRangeEnd = 59348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__13(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__13_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004ABB RID: 19131 RVA: 0x00196304 File Offset: 0x00194504
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59348, XrefRangeEnd = 59352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__14(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__14_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004ABC RID: 19132 RVA: 0x00196354 File Offset: 0x00194554
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59352, XrefRangeEnd = 59361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _tutorialItems_b__15(WormTutorialAction a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__15_Internal_Void_WormTutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004ABD RID: 19133 RVA: 0x00196398 File Offset: 0x00194598
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59361, XrefRangeEnd = 59365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__33(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__33_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004ABE RID: 19134 RVA: 0x001963E8 File Offset: 0x001945E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59365, XrefRangeEnd = 59377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__18(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__18_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004ABF RID: 19135 RVA: 0x00196438 File Offset: 0x00194638
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59377, XrefRangeEnd = 59383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__36(WormPlayArea garrison)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(garrison);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__36_Internal_Boolean_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004AC0 RID: 19136 RVA: 0x00196488 File Offset: 0x00194688
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59383, XrefRangeEnd = 59395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__19(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__19_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004AC1 RID: 19137 RVA: 0x001964D8 File Offset: 0x001946D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59395, XrefRangeEnd = 59401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__37(WormPlayArea garrison)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(garrison);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__37_Internal_Boolean_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004AC2 RID: 19138 RVA: 0x00196528 File Offset: 0x00194728
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__20()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__20_Internal_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004AC3 RID: 19139 RVA: 0x00196568 File Offset: 0x00194768
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59401, XrefRangeEnd = 59413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__21(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__21_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004AC4 RID: 19140 RVA: 0x001965B8 File Offset: 0x001947B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59413, XrefRangeEnd = 59419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__38(WormPlayArea garrison)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(garrison);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__38_Internal_Boolean_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004AC5 RID: 19141 RVA: 0x00196608 File Offset: 0x00194808
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59419, XrefRangeEnd = 59423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__22(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__22_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004AC6 RID: 19142 RVA: 0x00196658 File Offset: 0x00194858
			[CallerCount(0)]
			public unsafe Entity _tutorialItems_b__23(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__23_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004AC7 RID: 19143 RVA: 0x001966A8 File Offset: 0x001948A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59423, XrefRangeEnd = 59432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__24(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__24_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004AC8 RID: 19144 RVA: 0x001966F8 File Offset: 0x001948F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__25(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__25_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004AC9 RID: 19145 RVA: 0x00196748 File Offset: 0x00194948
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59432, XrefRangeEnd = 59441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__26(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__26_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004ACA RID: 19146 RVA: 0x0001994A File Offset: 0x00017B4A
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001234 RID: 4660
			// (get) Token: 0x06004ACB RID: 19147 RVA: 0x00196798 File Offset: 0x00194998
			// (set) Token: 0x06004ACC RID: 19148 RVA: 0x00019953 File Offset: 0x00017B53
			public unsafe WormTutorialScript2 __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript2.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTutorialScript2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript2.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001235 RID: 4661
			// (get) Token: 0x06004ACD RID: 19149 RVA: 0x001967C8 File Offset: 0x001949C8
			// (set) Token: 0x06004ACE RID: 19150 RVA: 0x00019972 File Offset: 0x00017B72
			public unsafe WormPlayer humanPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript2.__c__DisplayClass1_0.NativeFieldInfoPtr_humanPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript2.__c__DisplayClass1_0.NativeFieldInfoPtr_humanPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001236 RID: 4662
			// (get) Token: 0x06004ACF RID: 19151 RVA: 0x001967F8 File Offset: 0x001949F8
			// (set) Token: 0x06004AD0 RID: 19152 RVA: 0x00019991 File Offset: 0x00017B91
			public unsafe WormPlayer aiPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript2.__c__DisplayClass1_0.NativeFieldInfoPtr_aiPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript2.__c__DisplayClass1_0.NativeFieldInfoPtr_aiPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001237 RID: 4663
			// (get) Token: 0x06004AD1 RID: 19153 RVA: 0x00196828 File Offset: 0x00194A28
			// (set) Token: 0x06004AD2 RID: 19154 RVA: 0x000199B0 File Offset: 0x00017BB0
			public unsafe Func<Context, Entity> __9__33
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript2.__c__DisplayClass1_0.NativeFieldInfoPtr___9__33);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Context, Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript2.__c__DisplayClass1_0.NativeFieldInfoPtr___9__33), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001238 RID: 4664
			// (get) Token: 0x06004AD3 RID: 19155 RVA: 0x00196858 File Offset: 0x00194A58
			// (set) Token: 0x06004AD4 RID: 19156 RVA: 0x000199CF File Offset: 0x00017BCF
			public unsafe Func<WormPlayArea, bool> __9__36
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript2.__c__DisplayClass1_0.NativeFieldInfoPtr___9__36);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayArea, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript2.__c__DisplayClass1_0.NativeFieldInfoPtr___9__36), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001239 RID: 4665
			// (get) Token: 0x06004AD5 RID: 19157 RVA: 0x00196888 File Offset: 0x00194A88
			// (set) Token: 0x06004AD6 RID: 19158 RVA: 0x000199EE File Offset: 0x00017BEE
			public unsafe Func<WormPlayArea, bool> __9__37
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript2.__c__DisplayClass1_0.NativeFieldInfoPtr___9__37);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayArea, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript2.__c__DisplayClass1_0.NativeFieldInfoPtr___9__37), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700123A RID: 4666
			// (get) Token: 0x06004AD7 RID: 19159 RVA: 0x001968B8 File Offset: 0x00194AB8
			// (set) Token: 0x06004AD8 RID: 19160 RVA: 0x00019A0D File Offset: 0x00017C0D
			public unsafe Func<WormPlayArea, bool> __9__38
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript2.__c__DisplayClass1_0.NativeFieldInfoPtr___9__38);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayArea, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript2.__c__DisplayClass1_0.NativeFieldInfoPtr___9__38), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003102 RID: 12546
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003103 RID: 12547
			private static readonly IntPtr NativeFieldInfoPtr_humanPlayer;

			// Token: 0x04003104 RID: 12548
			private static readonly IntPtr NativeFieldInfoPtr_aiPlayer;

			// Token: 0x04003105 RID: 12549
			private static readonly IntPtr NativeFieldInfoPtr___9__33;

			// Token: 0x04003106 RID: 12550
			private static readonly IntPtr NativeFieldInfoPtr___9__36;

			// Token: 0x04003107 RID: 12551
			private static readonly IntPtr NativeFieldInfoPtr___9__37;

			// Token: 0x04003108 RID: 12552
			private static readonly IntPtr NativeFieldInfoPtr___9__38;

			// Token: 0x04003109 RID: 12553
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400310A RID: 12554
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__2_Internal_Il2CppReferenceArray_1_Entity_Context_0;

			// Token: 0x0400310B RID: 12555
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__3_Internal_Entity_Context_0;

			// Token: 0x0400310C RID: 12556
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__4_Internal_Entity_Context_0;

			// Token: 0x0400310D RID: 12557
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__5_Internal_Entity_Context_0;

			// Token: 0x0400310E RID: 12558
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__6_Internal_Entity_Context_0;

			// Token: 0x0400310F RID: 12559
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__7_Internal_Entity_Context_0;

			// Token: 0x04003110 RID: 12560
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__8_Internal_Entity_Context_0;

			// Token: 0x04003111 RID: 12561
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__9_Internal_Entity_Context_0;

			// Token: 0x04003112 RID: 12562
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__10_Internal_Entity_Context_0;

			// Token: 0x04003113 RID: 12563
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__11_Internal_Entity_Context_0;

			// Token: 0x04003114 RID: 12564
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__12_Internal_Entity_Context_0;

			// Token: 0x04003115 RID: 12565
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__13_Internal_Entity_Context_0;

			// Token: 0x04003116 RID: 12566
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__14_Internal_Entity_Context_0;

			// Token: 0x04003117 RID: 12567
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__15_Internal_Void_WormTutorialAction_0;

			// Token: 0x04003118 RID: 12568
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__33_Internal_Entity_Context_0;

			// Token: 0x04003119 RID: 12569
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__18_Internal_Entity_WormPlaymat_0;

			// Token: 0x0400311A RID: 12570
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__36_Internal_Boolean_WormPlayArea_0;

			// Token: 0x0400311B RID: 12571
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__19_Internal_Entity_WormPlaymat_0;

			// Token: 0x0400311C RID: 12572
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__37_Internal_Boolean_WormPlayArea_0;

			// Token: 0x0400311D RID: 12573
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__20_Internal_Entity_0;

			// Token: 0x0400311E RID: 12574
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__21_Internal_Entity_WormPlaymat_0;

			// Token: 0x0400311F RID: 12575
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__38_Internal_Boolean_WormPlayArea_0;

			// Token: 0x04003120 RID: 12576
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__22_Internal_Entity_Context_0;

			// Token: 0x04003121 RID: 12577
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__23_Internal_Entity_Context_0;

			// Token: 0x04003122 RID: 12578
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__24_Internal_Entity_Context_0;

			// Token: 0x04003123 RID: 12579
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__25_Internal_Entity_Context_0;

			// Token: 0x04003124 RID: 12580
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__26_Internal_Entity_Context_0;
		}

		// Token: 0x020005EE RID: 1518
		[ObfuscatedName("worm.canis.data.Tutorial.WormTutorialScript2+<>c__DisplayClass5_0")]
		public new sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x06004AD9 RID: 19161 RVA: 0x001968E8 File Offset: 0x00194AE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTutorialScript2>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass5_0>.NativeClassPtr);
				WormTutorialScript2.__c__DisplayClass5_0.NativeFieldInfoPtr_faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass5_0>.NativeClassPtr, "faction");
				WormTutorialScript2.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass5_0>.NativeClassPtr, 100664952);
				WormTutorialScript2.__c__DisplayClass5_0.NativeMethodInfoPtr__FactionTrack_b__0_Internal_Boolean_WormFactionTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass5_0>.NativeClassPtr, 100664953);
			}

			// Token: 0x06004ADA RID: 19162 RVA: 0x00196950 File Offset: 0x00194B50
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialScript2.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004ADB RID: 19163 RVA: 0x0019698C File Offset: 0x00194B8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59441, XrefRangeEnd = 59442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FactionTrack_b__0(WormFactionTrack t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript2.__c__DisplayClass5_0.NativeMethodInfoPtr__FactionTrack_b__0_Internal_Boolean_WormFactionTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004ADC RID: 19164 RVA: 0x00019A2C File Offset: 0x00017C2C
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700123B RID: 4667
			// (get) Token: 0x06004ADD RID: 19165 RVA: 0x001969DC File Offset: 0x00194BDC
			// (set) Token: 0x06004ADE RID: 19166 RVA: 0x00019A35 File Offset: 0x00017C35
			public unsafe Factions faction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript2.__c__DisplayClass5_0.NativeFieldInfoPtr_faction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript2.__c__DisplayClass5_0.NativeFieldInfoPtr_faction)) = value;
				}
			}

			// Token: 0x04003125 RID: 12581
			private static readonly IntPtr NativeFieldInfoPtr_faction;

			// Token: 0x04003126 RID: 12582
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003127 RID: 12583
			private static readonly IntPtr NativeMethodInfoPtr__FactionTrack_b__0_Internal_Boolean_WormFactionTrack_0;
		}
	}
}
