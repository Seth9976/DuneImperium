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
	// Token: 0x0200004A RID: 74
	public class WormTutorialScript3 : WormTutorialScript
	{
		// Token: 0x06000A71 RID: 2673 RVA: 0x00089320 File Offset: 0x00087520
		// Note: this type is marked as 'beforefieldinit'.
		static WormTutorialScript3()
		{
			Il2CppClassPointerStore<WormTutorialScript3>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Tutorial", "WormTutorialScript3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialScript3>.NativeClassPtr);
			WormTutorialScript3.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript3>.NativeClassPtr, 100664954);
			WormTutorialScript3.NativeMethodInfoPtr_tutorialItems_Protected_Virtual_IEnumerable_1_TutorialItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript3>.NativeClassPtr, 100664955);
			WormTutorialScript3.NativeMethodInfoPtr_AllianceTokenEntity_Private_Entity_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript3>.NativeClassPtr, 100664956);
			WormTutorialScript3.NativeMethodInfoPtr_FactionTrack_Private_WormFactionTrack_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript3>.NativeClassPtr, 100664957);
			WormTutorialScript3.NativeMethodInfoPtr_HasVisitedMentat_Private_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript3>.NativeClassPtr, 100664958);
			WormTutorialScript3.NativeMethodInfoPtr_HasStarted5VP_Private_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript3>.NativeClassPtr, 100664959);
			WormTutorialScript3.NativeMethodInfoPtr_HasAllianceToken_Private_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript3>.NativeClassPtr, 100664960);
			WormTutorialScript3.NativeMethodInfoPtr_HasSpaceControl_Private_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript3>.NativeClassPtr, 100664961);
			WormTutorialScript3.NativeMethodInfoPtr_Check5VPScore_Private_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript3>.NativeClassPtr, 100664962);
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00089404 File Offset: 0x00087604
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54376, RefRangeEnd = 54377, XrefRangeStart = 54376, XrefRangeEnd = 54377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTutorialScript3(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialScript3>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript3.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00089450 File Offset: 0x00087650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62144, XrefRangeEnd = 63344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<AdvancedTutorialScript.TutorialItem> tutorialItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTutorialScript3.NativeMethodInfoPtr_tutorialItems_Protected_Virtual_IEnumerable_1_TutorialItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AdvancedTutorialScript.TutorialItem>>(intPtr3) : null;
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x0008949C File Offset: 0x0008769C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 63360, RefRangeEnd = 63364, XrefRangeStart = 63344, XrefRangeEnd = 63360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entity AllianceTokenEntity(Factions faction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref faction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript3.NativeMethodInfoPtr_AllianceTokenEntity_Private_Entity_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x000894E8 File Offset: 0x000876E8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 63382, RefRangeEnd = 63390, XrefRangeStart = 63364, XrefRangeEnd = 63382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormFactionTrack FactionTrack(Factions faction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref faction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript3.NativeMethodInfoPtr_FactionTrack_Private_WormFactionTrack_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormFactionTrack>(intPtr3) : null;
			}
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x00089534 File Offset: 0x00087734
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63431, RefRangeEnd = 63432, XrefRangeStart = 63390, XrefRangeEnd = 63431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasVisitedMentat(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript3.NativeMethodInfoPtr_HasVisitedMentat_Private_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x00089584 File Offset: 0x00087784
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63452, RefRangeEnd = 63453, XrefRangeStart = 63432, XrefRangeEnd = 63452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasStarted5VP(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript3.NativeMethodInfoPtr_HasStarted5VP_Private_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x000895D4 File Offset: 0x000877D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63453, XrefRangeEnd = 63475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasAllianceToken(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript3.NativeMethodInfoPtr_HasAllianceToken_Private_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x00089624 File Offset: 0x00087824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63475, XrefRangeEnd = 63497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasSpaceControl(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript3.NativeMethodInfoPtr_HasSpaceControl_Private_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x00089674 File Offset: 0x00087874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63497, XrefRangeEnd = 63518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Check5VPScore(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript3.NativeMethodInfoPtr_Check5VPScore_Private_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x00006B86 File Offset: 0x00004D86
		public WormTutorialScript3(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000680 RID: 1664
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04000681 RID: 1665
		private static readonly IntPtr NativeMethodInfoPtr_tutorialItems_Protected_Virtual_IEnumerable_1_TutorialItem_0;

		// Token: 0x04000682 RID: 1666
		private static readonly IntPtr NativeMethodInfoPtr_AllianceTokenEntity_Private_Entity_Factions_0;

		// Token: 0x04000683 RID: 1667
		private static readonly IntPtr NativeMethodInfoPtr_FactionTrack_Private_WormFactionTrack_Factions_0;

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeMethodInfoPtr_HasVisitedMentat_Private_Boolean_Context_0;

		// Token: 0x04000685 RID: 1669
		private static readonly IntPtr NativeMethodInfoPtr_HasStarted5VP_Private_Boolean_Context_0;

		// Token: 0x04000686 RID: 1670
		private static readonly IntPtr NativeMethodInfoPtr_HasAllianceToken_Private_Boolean_Context_0;

		// Token: 0x04000687 RID: 1671
		private static readonly IntPtr NativeMethodInfoPtr_HasSpaceControl_Private_Boolean_Context_0;

		// Token: 0x04000688 RID: 1672
		private static readonly IntPtr NativeMethodInfoPtr_Check5VPScore_Private_Boolean_Context_0;

		// Token: 0x020005EF RID: 1519
		[ObfuscatedName("worm.canis.data.Tutorial.WormTutorialScript3+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06004ADF RID: 19167 RVA: 0x00196A04 File Offset: 0x00194C04
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormTutorialScript3.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTutorialScript3>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialScript3.__c>.NativeClassPtr);
				WormTutorialScript3.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript3.__c>.NativeClassPtr, "<>9");
				WormTutorialScript3.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript3.__c>.NativeClassPtr, "<>9__1_0");
				WormTutorialScript3.__c.NativeFieldInfoPtr___9__1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript3.__c>.NativeClassPtr, "<>9__1_1");
				WormTutorialScript3.__c.NativeFieldInfoPtr___9__1_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript3.__c>.NativeClassPtr, "<>9__1_7");
				WormTutorialScript3.__c.NativeFieldInfoPtr___9__1_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript3.__c>.NativeClassPtr, "<>9__1_8");
				WormTutorialScript3.__c.NativeFieldInfoPtr___9__1_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript3.__c>.NativeClassPtr, "<>9__1_10");
				WormTutorialScript3.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript3.__c>.NativeClassPtr, "<>9__4_0");
				WormTutorialScript3.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript3.__c>.NativeClassPtr, "<>9__5_0");
				WormTutorialScript3.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript3.__c>.NativeClassPtr, "<>9__6_0");
				WormTutorialScript3.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript3.__c>.NativeClassPtr, "<>9__7_0");
				WormTutorialScript3.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript3.__c>.NativeClassPtr, "<>9__8_0");
				WormTutorialScript3.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript3.__c>.NativeClassPtr, 100664964);
				WormTutorialScript3.__c.NativeMethodInfoPtr__tutorialItems_b__1_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript3.__c>.NativeClassPtr, 100664965);
				WormTutorialScript3.__c.NativeMethodInfoPtr__tutorialItems_b__1_1_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript3.__c>.NativeClassPtr, 100664966);
				WormTutorialScript3.__c.NativeMethodInfoPtr__tutorialItems_b__1_7_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript3.__c>.NativeClassPtr, 100664967);
				WormTutorialScript3.__c.NativeMethodInfoPtr__tutorialItems_b__1_8_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript3.__c>.NativeClassPtr, 100664968);
				WormTutorialScript3.__c.NativeMethodInfoPtr__tutorialItems_b__1_10_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript3.__c>.NativeClassPtr, 100664969);
				WormTutorialScript3.__c.NativeMethodInfoPtr__HasVisitedMentat_b__4_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript3.__c>.NativeClassPtr, 100664970);
				WormTutorialScript3.__c.NativeMethodInfoPtr__HasStarted5VP_b__5_0_Internal_Boolean_Objective_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript3.__c>.NativeClassPtr, 100664971);
				WormTutorialScript3.__c.NativeMethodInfoPtr__HasAllianceToken_b__6_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript3.__c>.NativeClassPtr, 100664972);
				WormTutorialScript3.__c.NativeMethodInfoPtr__HasSpaceControl_b__7_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript3.__c>.NativeClassPtr, 100664973);
				WormTutorialScript3.__c.NativeMethodInfoPtr__Check5VPScore_b__8_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript3.__c>.NativeClassPtr, 100664974);
			}

			// Token: 0x06004AE0 RID: 19168 RVA: 0x00196BE8 File Offset: 0x00194DE8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialScript3.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript3.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004AE1 RID: 19169 RVA: 0x00196C24 File Offset: 0x00194E24
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript3.__c.NativeMethodInfoPtr__tutorialItems_b__1_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004AE2 RID: 19170 RVA: 0x00196C74 File Offset: 0x00194E74
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript3.__c.NativeMethodInfoPtr__tutorialItems_b__1_1_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004AE3 RID: 19171 RVA: 0x00196CC4 File Offset: 0x00194EC4
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript3.__c.NativeMethodInfoPtr__tutorialItems_b__1_7_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004AE4 RID: 19172 RVA: 0x00196D14 File Offset: 0x00194F14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62041, XrefRangeEnd = 62045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__1_8(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript3.__c.NativeMethodInfoPtr__tutorialItems_b__1_8_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004AE5 RID: 19173 RVA: 0x00196D64 File Offset: 0x00194F64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _tutorialItems_b__1_10(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript3.__c.NativeMethodInfoPtr__tutorialItems_b__1_10_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004AE6 RID: 19174 RVA: 0x00196DB4 File Offset: 0x00194FB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HasVisitedMentat_b__4_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript3.__c.NativeMethodInfoPtr__HasVisitedMentat_b__4_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004AE7 RID: 19175 RVA: 0x00196E04 File Offset: 0x00195004
			[CallerCount(0)]
			public unsafe bool _HasStarted5VP_b__5_0(Objective o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript3.__c.NativeMethodInfoPtr__HasStarted5VP_b__5_0_Internal_Boolean_Objective_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004AE8 RID: 19176 RVA: 0x00196E54 File Offset: 0x00195054
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HasAllianceToken_b__6_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript3.__c.NativeMethodInfoPtr__HasAllianceToken_b__6_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004AE9 RID: 19177 RVA: 0x00196EA4 File Offset: 0x001950A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62045, XrefRangeEnd = 62050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HasSpaceControl_b__7_0(Entity e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript3.__c.NativeMethodInfoPtr__HasSpaceControl_b__7_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004AEA RID: 19178 RVA: 0x00196EF4 File Offset: 0x001950F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Check5VPScore_b__8_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript3.__c.NativeMethodInfoPtr__Check5VPScore_b__8_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004AEB RID: 19179 RVA: 0x00019A50 File Offset: 0x00017C50
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700123C RID: 4668
			// (get) Token: 0x06004AEC RID: 19180 RVA: 0x00196F44 File Offset: 0x00195144
			// (set) Token: 0x06004AED RID: 19181 RVA: 0x00019A59 File Offset: 0x00017C59
			public unsafe static WormTutorialScript3.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript3.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTutorialScript3.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript3.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700123D RID: 4669
			// (get) Token: 0x06004AEE RID: 19182 RVA: 0x00196F6C File Offset: 0x0019516C
			// (set) Token: 0x06004AEF RID: 19183 RVA: 0x00019A6B File Offset: 0x00017C6B
			public unsafe static Func<WormPlayer, bool> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript3.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript3.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700123E RID: 4670
			// (get) Token: 0x06004AF0 RID: 19184 RVA: 0x00196F94 File Offset: 0x00195194
			// (set) Token: 0x06004AF1 RID: 19185 RVA: 0x00019A7D File Offset: 0x00017C7D
			public unsafe static Func<WormPlayer, bool> __9__1_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript3.__c.NativeFieldInfoPtr___9__1_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript3.__c.NativeFieldInfoPtr___9__1_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700123F RID: 4671
			// (get) Token: 0x06004AF2 RID: 19186 RVA: 0x00196FBC File Offset: 0x001951BC
			// (set) Token: 0x06004AF3 RID: 19187 RVA: 0x00019A8F File Offset: 0x00017C8F
			public unsafe static Func<WormPlaymat, Entity> __9__1_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript3.__c.NativeFieldInfoPtr___9__1_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript3.__c.NativeFieldInfoPtr___9__1_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001240 RID: 4672
			// (get) Token: 0x06004AF4 RID: 19188 RVA: 0x00196FE4 File Offset: 0x001951E4
			// (set) Token: 0x06004AF5 RID: 19189 RVA: 0x00019AA1 File Offset: 0x00017CA1
			public unsafe static Func<WormPlaymat, Entity> __9__1_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript3.__c.NativeFieldInfoPtr___9__1_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript3.__c.NativeFieldInfoPtr___9__1_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001241 RID: 4673
			// (get) Token: 0x06004AF6 RID: 19190 RVA: 0x0019700C File Offset: 0x0019520C
			// (set) Token: 0x06004AF7 RID: 19191 RVA: 0x00019AB3 File Offset: 0x00017CB3
			public unsafe static Func<WormPlaymat, Entity> __9__1_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript3.__c.NativeFieldInfoPtr___9__1_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript3.__c.NativeFieldInfoPtr___9__1_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001242 RID: 4674
			// (get) Token: 0x06004AF8 RID: 19192 RVA: 0x00197034 File Offset: 0x00195234
			// (set) Token: 0x06004AF9 RID: 19193 RVA: 0x00019AC5 File Offset: 0x00017CC5
			public unsafe static Func<WormPlayer, bool> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript3.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript3.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001243 RID: 4675
			// (get) Token: 0x06004AFA RID: 19194 RVA: 0x0019705C File Offset: 0x0019525C
			// (set) Token: 0x06004AFB RID: 19195 RVA: 0x00019AD7 File Offset: 0x00017CD7
			public unsafe static Func<Objective, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript3.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Objective, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript3.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001244 RID: 4676
			// (get) Token: 0x06004AFC RID: 19196 RVA: 0x00197084 File Offset: 0x00195284
			// (set) Token: 0x06004AFD RID: 19197 RVA: 0x00019AE9 File Offset: 0x00017CE9
			public unsafe static Func<WormPlayer, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript3.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript3.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001245 RID: 4677
			// (get) Token: 0x06004AFE RID: 19198 RVA: 0x001970AC File Offset: 0x001952AC
			// (set) Token: 0x06004AFF RID: 19199 RVA: 0x00019AFB File Offset: 0x00017CFB
			public unsafe static Func<Entity, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript3.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript3.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001246 RID: 4678
			// (get) Token: 0x06004B00 RID: 19200 RVA: 0x001970D4 File Offset: 0x001952D4
			// (set) Token: 0x06004B01 RID: 19201 RVA: 0x00019B0D File Offset: 0x00017D0D
			public unsafe static Func<WormPlayer, bool> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialScript3.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialScript3.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003128 RID: 12584
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003129 RID: 12585
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x0400312A RID: 12586
			private static readonly IntPtr NativeFieldInfoPtr___9__1_1;

			// Token: 0x0400312B RID: 12587
			private static readonly IntPtr NativeFieldInfoPtr___9__1_7;

			// Token: 0x0400312C RID: 12588
			private static readonly IntPtr NativeFieldInfoPtr___9__1_8;

			// Token: 0x0400312D RID: 12589
			private static readonly IntPtr NativeFieldInfoPtr___9__1_10;

			// Token: 0x0400312E RID: 12590
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x0400312F RID: 12591
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04003130 RID: 12592
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04003131 RID: 12593
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04003132 RID: 12594
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04003133 RID: 12595
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003134 RID: 12596
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x04003135 RID: 12597
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_1_Internal_Boolean_WormPlayer_0;

			// Token: 0x04003136 RID: 12598
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_7_Internal_Entity_WormPlaymat_0;

			// Token: 0x04003137 RID: 12599
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_8_Internal_Entity_WormPlaymat_0;

			// Token: 0x04003138 RID: 12600
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__1_10_Internal_Entity_WormPlaymat_0;

			// Token: 0x04003139 RID: 12601
			private static readonly IntPtr NativeMethodInfoPtr__HasVisitedMentat_b__4_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x0400313A RID: 12602
			private static readonly IntPtr NativeMethodInfoPtr__HasStarted5VP_b__5_0_Internal_Boolean_Objective_0;

			// Token: 0x0400313B RID: 12603
			private static readonly IntPtr NativeMethodInfoPtr__HasAllianceToken_b__6_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x0400313C RID: 12604
			private static readonly IntPtr NativeMethodInfoPtr__HasSpaceControl_b__7_0_Internal_Boolean_Entity_0;

			// Token: 0x0400313D RID: 12605
			private static readonly IntPtr NativeMethodInfoPtr__Check5VPScore_b__8_0_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x020005F0 RID: 1520
		[ObfuscatedName("worm.canis.data.Tutorial.WormTutorialScript3+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06004B02 RID: 19202 RVA: 0x001970FC File Offset: 0x001952FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<WormTutorialScript3.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTutorialScript3>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialScript3.__c__DisplayClass1_0>.NativeClassPtr);
				WormTutorialScript3.__c__DisplayClass1_0.NativeFieldInfoPtr_humanPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript3.__c__DisplayClass1_0>.NativeClassPtr, "humanPlayer");
				WormTutorialScript3.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript3.__c__DisplayClass1_0>.NativeClassPtr, "<>4__this");
				WormTutorialScript3.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript3.__c__DisplayClass1_0>.NativeClassPtr, 100664975);
				WormTutorialScript3.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__2_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript3.__c__DisplayClass1_0>.NativeClassPtr, 100664976);
				WormTutorialScript3.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__3_Internal_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript3.__c__DisplayClass1_0>.NativeClassPtr, 100664977);
				WormTutorialScript3.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__4_Internal_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript3.__c__DisplayClass1_0>.NativeClassPtr, 100664978);
				WormTutorialScript3.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__5_Internal_Il2CppReferenceArray_1_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript3.__c__DisplayClass1_0>.NativeClassPtr, 100664979);
				WormTutorialScript3.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__6_Internal_Il2CppReferenceArray_1_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript3.__c__DisplayClass1_0>.NativeClassPtr, 100664980);
				WormTutorialScript3.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__9_Internal_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript3.__c__DisplayClass1_0>.NativeClassPtr, 100664981);
				WormTutorialScript3.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__11_Internal_Il2CppReferenceArray_1_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript3.__c__DisplayClass1_0>.NativeClassPtr, 100664982);
			}

			// Token: 0x06004B03 RID: 19203 RVA: 0x001971F0 File Offset: 0x001953F0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialScript3.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript3.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B04 RID: 19204 RVA: 0x0019722C File Offset: 0x0019542C
			[CallerCount(0)]
			public unsafe Entity _tutorialItems_b__2(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript3.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__2_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004B05 RID: 19205 RVA: 0x0019727C File Offset: 0x0019547C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62050, XrefRangeEnd = 62051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__3(Context context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript3.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__3_Internal_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B06 RID: 19206 RVA: 0x001972CC File Offset: 0x001954CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62051, XrefRangeEnd = 62052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__4(Context context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript3.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__4_Internal_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B07 RID: 19207 RVA: 0x0019731C File Offset: 0x0019551C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62052, XrefRangeEnd = 62067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<Entity> _tutorialItems_b__5(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript3.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__5_Internal_Il2CppReferenceArray_1_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x06004B08 RID: 19208 RVA: 0x0019736C File Offset: 0x0019556C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62067, XrefRangeEnd = 62104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<Entity> _tutorialItems_b__6(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript3.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__6_Internal_Il2CppReferenceArray_1_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x06004B09 RID: 19209 RVA: 0x001973BC File Offset: 0x001955BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62104, XrefRangeEnd = 62125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialItems_b__9(Context context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript3.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__9_Internal_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B0A RID: 19210 RVA: 0x0019740C File Offset: 0x0019560C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62125, XrefRangeEnd = 62140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<Entity> _tutorialItems_b__11(Context _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript3.__c__DisplayClass1_0.NativeMethodInfoPtr__tutorialItems_b__11_Internal_Il2CppReferenceArray_1_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x06004B0B RID: 19211 RVA: 0x00019B1F File Offset: 0x00017D1F
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001247 RID: 4679
			// (get) Token: 0x06004B0C RID: 19212 RVA: 0x0019745C File Offset: 0x0019565C
			// (set) Token: 0x06004B0D RID: 19213 RVA: 0x00019B28 File Offset: 0x00017D28
			public unsafe WormPlayer humanPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript3.__c__DisplayClass1_0.NativeFieldInfoPtr_humanPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript3.__c__DisplayClass1_0.NativeFieldInfoPtr_humanPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001248 RID: 4680
			// (get) Token: 0x06004B0E RID: 19214 RVA: 0x0019748C File Offset: 0x0019568C
			// (set) Token: 0x06004B0F RID: 19215 RVA: 0x00019B47 File Offset: 0x00017D47
			public unsafe WormTutorialScript3 __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript3.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTutorialScript3>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript3.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400313E RID: 12606
			private static readonly IntPtr NativeFieldInfoPtr_humanPlayer;

			// Token: 0x0400313F RID: 12607
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003140 RID: 12608
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003141 RID: 12609
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__2_Internal_Entity_Context_0;

			// Token: 0x04003142 RID: 12610
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__3_Internal_Boolean_Context_0;

			// Token: 0x04003143 RID: 12611
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__4_Internal_Boolean_Context_0;

			// Token: 0x04003144 RID: 12612
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__5_Internal_Il2CppReferenceArray_1_Entity_Context_0;

			// Token: 0x04003145 RID: 12613
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__6_Internal_Il2CppReferenceArray_1_Entity_Context_0;

			// Token: 0x04003146 RID: 12614
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__9_Internal_Boolean_Context_0;

			// Token: 0x04003147 RID: 12615
			private static readonly IntPtr NativeMethodInfoPtr__tutorialItems_b__11_Internal_Il2CppReferenceArray_1_Entity_Context_0;
		}

		// Token: 0x020005F1 RID: 1521
		[ObfuscatedName("worm.canis.data.Tutorial.WormTutorialScript3+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x06004B10 RID: 19216 RVA: 0x001974BC File Offset: 0x001956BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<WormTutorialScript3.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTutorialScript3>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialScript3.__c__DisplayClass2_0>.NativeClassPtr);
				WormTutorialScript3.__c__DisplayClass2_0.NativeFieldInfoPtr_faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript3.__c__DisplayClass2_0>.NativeClassPtr, "faction");
				WormTutorialScript3.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript3.__c__DisplayClass2_0>.NativeClassPtr, 100664983);
				WormTutorialScript3.__c__DisplayClass2_0.NativeMethodInfoPtr__AllianceTokenEntity_b__0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript3.__c__DisplayClass2_0>.NativeClassPtr, 100664984);
			}

			// Token: 0x06004B11 RID: 19217 RVA: 0x00197524 File Offset: 0x00195724
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialScript3.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript3.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B12 RID: 19218 RVA: 0x00197560 File Offset: 0x00195760
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62140, XrefRangeEnd = 62144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AllianceTokenEntity_b__0(Entity e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript3.__c__DisplayClass2_0.NativeMethodInfoPtr__AllianceTokenEntity_b__0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B13 RID: 19219 RVA: 0x00019B66 File Offset: 0x00017D66
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001249 RID: 4681
			// (get) Token: 0x06004B14 RID: 19220 RVA: 0x001975B0 File Offset: 0x001957B0
			// (set) Token: 0x06004B15 RID: 19221 RVA: 0x00019B6F File Offset: 0x00017D6F
			public unsafe Factions faction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript3.__c__DisplayClass2_0.NativeFieldInfoPtr_faction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript3.__c__DisplayClass2_0.NativeFieldInfoPtr_faction)) = value;
				}
			}

			// Token: 0x04003148 RID: 12616
			private static readonly IntPtr NativeFieldInfoPtr_faction;

			// Token: 0x04003149 RID: 12617
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400314A RID: 12618
			private static readonly IntPtr NativeMethodInfoPtr__AllianceTokenEntity_b__0_Internal_Boolean_Entity_0;
		}

		// Token: 0x020005F2 RID: 1522
		[ObfuscatedName("worm.canis.data.Tutorial.WormTutorialScript3+<>c__DisplayClass3_0")]
		public new sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06004B16 RID: 19222 RVA: 0x001975D8 File Offset: 0x001957D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<WormTutorialScript3.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTutorialScript3>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialScript3.__c__DisplayClass3_0>.NativeClassPtr);
				WormTutorialScript3.__c__DisplayClass3_0.NativeFieldInfoPtr_faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialScript3.__c__DisplayClass3_0>.NativeClassPtr, "faction");
				WormTutorialScript3.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript3.__c__DisplayClass3_0>.NativeClassPtr, 100664985);
				WormTutorialScript3.__c__DisplayClass3_0.NativeMethodInfoPtr__FactionTrack_b__0_Internal_Boolean_WormFactionTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialScript3.__c__DisplayClass3_0>.NativeClassPtr, 100664986);
			}

			// Token: 0x06004B17 RID: 19223 RVA: 0x00197640 File Offset: 0x00195840
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialScript3.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript3.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B18 RID: 19224 RVA: 0x0019767C File Offset: 0x0019587C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FactionTrack_b__0(WormFactionTrack t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialScript3.__c__DisplayClass3_0.NativeMethodInfoPtr__FactionTrack_b__0_Internal_Boolean_WormFactionTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B19 RID: 19225 RVA: 0x00019B8A File Offset: 0x00017D8A
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700124A RID: 4682
			// (get) Token: 0x06004B1A RID: 19226 RVA: 0x001976CC File Offset: 0x001958CC
			// (set) Token: 0x06004B1B RID: 19227 RVA: 0x00019B93 File Offset: 0x00017D93
			public unsafe Factions faction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript3.__c__DisplayClass3_0.NativeFieldInfoPtr_faction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialScript3.__c__DisplayClass3_0.NativeFieldInfoPtr_faction)) = value;
				}
			}

			// Token: 0x0400314B RID: 12619
			private static readonly IntPtr NativeFieldInfoPtr_faction;

			// Token: 0x0400314C RID: 12620
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400314D RID: 12621
			private static readonly IntPtr NativeMethodInfoPtr__FactionTrack_b__0_Internal_Boolean_WormFactionTrack_0;
		}
	}
}
