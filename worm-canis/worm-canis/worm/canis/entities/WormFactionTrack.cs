using System;
using Canis;
using Canis.actions;
using Canis.entities;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.actions;
using worm.canis.data.enums;

namespace worm.canis.entities
{
	// Token: 0x02000029 RID: 41
	public class WormFactionTrack : WormTrack
	{
		// Token: 0x06000373 RID: 883 RVA: 0x00076D34 File Offset: 0x00074F34
		// Note: this type is marked as 'beforefieldinit'.
		static WormFactionTrack()
		{
			Il2CppClassPointerStore<WormFactionTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.entities", "WormFactionTrack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormFactionTrack>.NativeClassPtr);
			WormFactionTrack.NativeFieldInfoPtr_faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack>.NativeClassPtr, "faction");
			WormFactionTrack.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack>.NativeClassPtr, 100664052);
			WormFactionTrack.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack>.NativeClassPtr, 100664053);
			WormFactionTrack.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack>.NativeClassPtr, 100664054);
			WormFactionTrack.NativeMethodInfoPtr_HighestOpponentRank_Public_Virtual_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack>.NativeClassPtr, 100664055);
			WormFactionTrack.NativeMethodInfoPtr_FactionTrackBonusAction_Public_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack>.NativeClassPtr, 100664056);
			WormFactionTrack.NativeMethodInfoPtr_ChangeRankBonuses_Protected_Virtual_IEnumerable_1_Action_WormPlayer_Int32_Int32_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack>.NativeClassPtr, 100664057);
			WormFactionTrack.NativeMethodInfoPtr_ChangeRank_Public_Virtual_IEnumerable_1_Action_WormPlayer_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack>.NativeClassPtr, 100664058);
			WormFactionTrack.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack>.NativeClassPtr, 100664059);
			WormFactionTrack.NativeMethodInfoPtr_IsNeutralShippingConglomerateChallenge_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack>.NativeClassPtr, 100664060);
			WormFactionTrack.NativeMethodInfoPtr__ChangeRankBonuses_b__6_0_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack>.NativeClassPtr, 100664061);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00076E40 File Offset: 0x00075040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38039, XrefRangeEnd = 38055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormFactionTrack(WormMatch m, Factions faction)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFactionTrack>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrack.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00076E9C File Offset: 0x0007509C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38067, RefRangeEnd = 38068, XrefRangeStart = 38055, XrefRangeEnd = 38067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormFactionTrack(SerializedEntity se, Match m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFactionTrack>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrack.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00076F0C File Offset: 0x0007510C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38068, XrefRangeEnd = 38190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormFactionTrack.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00076F48 File Offset: 0x00075148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38190, XrefRangeEnd = 38236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int HighestOpponentRank(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormFactionTrack.NativeMethodInfoPtr_HighestOpponentRank_Public_Virtual_Int32_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00076FA0 File Offset: 0x000751A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38245, RefRangeEnd = 38246, XrefRangeStart = 38236, XrefRangeEnd = 38245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe global::Canis.actions.Action FactionTrackBonusAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrack.NativeMethodInfoPtr_FactionTrackBonusAction_Public_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00076FE0 File Offset: 0x000751E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38246, XrefRangeEnd = 38253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> ChangeRankBonuses(WormPlayer player, int currentRank, int newRank, ActionLogModes logMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentRank;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newRank;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormFactionTrack.NativeMethodInfoPtr_ChangeRankBonuses_Protected_Virtual_IEnumerable_1_Action_WormPlayer_Int32_Int32_ActionLogModes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00077068 File Offset: 0x00075268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38253, XrefRangeEnd = 38261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> ChangeRank(WormPlayer player, global::Canis.actions.Action triggeringAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triggeringAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormFactionTrack.NativeMethodInfoPtr_ChangeRank_Public_Virtual_IEnumerable_1_Action_WormPlayer_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x000770D8 File Offset: 0x000752D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38261, XrefRangeEnd = 38264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormFactionTrack.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0007711C File Offset: 0x0007531C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 38268, RefRangeEnd = 38270, XrefRangeStart = 38264, XrefRangeEnd = 38268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNeutralShippingConglomerateChallenge()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrack.NativeMethodInfoPtr_IsNeutralShippingConglomerateChallenge_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00077158 File Offset: 0x00075358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38270, XrefRangeEnd = 38274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _ChangeRankBonuses_b__6_0(Entity _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrack.NativeMethodInfoPtr__ChangeRankBonuses_b__6_0_Private_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600037E RID: 894 RVA: 0x000036C4 File Offset: 0x000018C4
		public WormFactionTrack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x0600037F RID: 895 RVA: 0x000771A8 File Offset: 0x000753A8
		// (set) Token: 0x06000380 RID: 896 RVA: 0x000036CD File Offset: 0x000018CD
		public unsafe Factions faction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack.NativeFieldInfoPtr_faction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack.NativeFieldInfoPtr_faction)) = value;
			}
		}

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeFieldInfoPtr_faction;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_Factions_0;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeMethodInfoPtr_HighestOpponentRank_Public_Virtual_Int32_WormPlayer_0;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeMethodInfoPtr_FactionTrackBonusAction_Public_Action_0;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeMethodInfoPtr_ChangeRankBonuses_Protected_Virtual_IEnumerable_1_Action_WormPlayer_Int32_Int32_ActionLogModes_0;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr_ChangeRank_Public_Virtual_IEnumerable_1_Action_WormPlayer_Action_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeMethodInfoPtr_IsNeutralShippingConglomerateChallenge_Private_Boolean_0;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeMethodInfoPtr__ChangeRankBonuses_b__6_0_Private_Boolean_Entity_0;

		// Token: 0x02000597 RID: 1431
		[ObfuscatedName("worm.canis.entities.WormFactionTrack+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600447E RID: 17534 RVA: 0x001826E4 File Offset: 0x001808E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormFactionTrack.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormFactionTrack>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormFactionTrack.__c>.NativeClassPtr);
				WormFactionTrack.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack.__c>.NativeClassPtr, "<>9");
				WormFactionTrack.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack.__c>.NativeClassPtr, "<>9__4_0");
				WormFactionTrack.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack.__c>.NativeClassPtr, "<>9__7_0");
				WormFactionTrack.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack.__c>.NativeClassPtr, 100664063);
				WormFactionTrack.__c.NativeMethodInfoPtr__HighestOpponentRank_b__4_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack.__c>.NativeClassPtr, 100664064);
				WormFactionTrack.__c.NativeMethodInfoPtr__ChangeRank_b__7_0_Internal_Boolean_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack.__c>.NativeClassPtr, 100664065);
			}

			// Token: 0x0600447F RID: 17535 RVA: 0x00182788 File Offset: 0x00180988
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFactionTrack.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrack.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004480 RID: 17536 RVA: 0x001827C4 File Offset: 0x001809C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HighestOpponentRank_b__4_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrack.__c.NativeMethodInfoPtr__HighestOpponentRank_b__4_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004481 RID: 17537 RVA: 0x00182814 File Offset: 0x00180A14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37450, XrefRangeEnd = 37460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ChangeRank_b__7_0(WormPlayable c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrack.__c.NativeMethodInfoPtr__ChangeRank_b__7_0_Internal_Boolean_WormPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004482 RID: 17538 RVA: 0x000168C8 File Offset: 0x00014AC8
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001042 RID: 4162
			// (get) Token: 0x06004483 RID: 17539 RVA: 0x00182864 File Offset: 0x00180A64
			// (set) Token: 0x06004484 RID: 17540 RVA: 0x000168D1 File Offset: 0x00014AD1
			public unsafe static WormFactionTrack.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormFactionTrack.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormFactionTrack.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormFactionTrack.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001043 RID: 4163
			// (get) Token: 0x06004485 RID: 17541 RVA: 0x0018288C File Offset: 0x00180A8C
			// (set) Token: 0x06004486 RID: 17542 RVA: 0x000168E3 File Offset: 0x00014AE3
			public unsafe static Func<WormPlayer, bool> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormFactionTrack.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormFactionTrack.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001044 RID: 4164
			// (get) Token: 0x06004487 RID: 17543 RVA: 0x001828B4 File Offset: 0x00180AB4
			// (set) Token: 0x06004488 RID: 17544 RVA: 0x000168F5 File Offset: 0x00014AF5
			public unsafe static Func<WormPlayable, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormFactionTrack.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormFactionTrack.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D37 RID: 11575
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002D38 RID: 11576
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04002D39 RID: 11577
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04002D3A RID: 11578
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D3B RID: 11579
			private static readonly IntPtr NativeMethodInfoPtr__HighestOpponentRank_b__4_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x04002D3C RID: 11580
			private static readonly IntPtr NativeMethodInfoPtr__ChangeRank_b__7_0_Internal_Boolean_WormPlayable_0;
		}

		// Token: 0x02000598 RID: 1432
		[ObfuscatedName("worm.canis.entities.WormFactionTrack+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06004489 RID: 17545 RVA: 0x001828DC File Offset: 0x00180ADC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<WormFactionTrack.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormFactionTrack>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormFactionTrack.__c__DisplayClass4_0>.NativeClassPtr);
				WormFactionTrack.__c__DisplayClass4_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack.__c__DisplayClass4_0>.NativeClassPtr, "player");
				WormFactionTrack.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack.__c__DisplayClass4_0>.NativeClassPtr, 100664066);
				WormFactionTrack.__c__DisplayClass4_0.NativeMethodInfoPtr__HighestOpponentRank_b__1_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack.__c__DisplayClass4_0>.NativeClassPtr, 100664067);
			}

			// Token: 0x0600448A RID: 17546 RVA: 0x00182944 File Offset: 0x00180B44
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFactionTrack.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrack.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600448B RID: 17547 RVA: 0x00182980 File Offset: 0x00180B80
			[CallerCount(0)]
			public unsafe bool _HighestOpponentRank_b__1(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrack.__c__DisplayClass4_0.NativeMethodInfoPtr__HighestOpponentRank_b__1_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600448C RID: 17548 RVA: 0x00016907 File Offset: 0x00014B07
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001045 RID: 4165
			// (get) Token: 0x0600448D RID: 17549 RVA: 0x001829D0 File Offset: 0x00180BD0
			// (set) Token: 0x0600448E RID: 17550 RVA: 0x00016910 File Offset: 0x00014B10
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack.__c__DisplayClass4_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack.__c__DisplayClass4_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D3D RID: 11581
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04002D3E RID: 11582
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D3F RID: 11583
			private static readonly IntPtr NativeMethodInfoPtr__HighestOpponentRank_b__1_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x02000599 RID: 1433
		[ObfuscatedName("worm.canis.entities.WormFactionTrack+<ChangeRank>d__7")]
		public sealed class _ChangeRank_d__7 : Object
		{
			// Token: 0x0600448F RID: 17551 RVA: 0x00182A00 File Offset: 0x00180C00
			// Note: this type is marked as 'beforefieldinit'.
			static _ChangeRank_d__7()
			{
				Il2CppClassPointerStore<WormFactionTrack._ChangeRank_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormFactionTrack>.NativeClassPtr, "<ChangeRank>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormFactionTrack._ChangeRank_d__7>.NativeClassPtr);
				WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack._ChangeRank_d__7>.NativeClassPtr, "<>1__state");
				WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack._ChangeRank_d__7>.NativeClassPtr, "<>2__current");
				WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack._ChangeRank_d__7>.NativeClassPtr, "<>l__initialThreadId");
				WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr_triggeringAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack._ChangeRank_d__7>.NativeClassPtr, "triggeringAction");
				WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr___3__triggeringAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack._ChangeRank_d__7>.NativeClassPtr, "<>3__triggeringAction");
				WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack._ChangeRank_d__7>.NativeClassPtr, "<>4__this");
				WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack._ChangeRank_d__7>.NativeClassPtr, "player");
				WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack._ChangeRank_d__7>.NativeClassPtr, "<>3__player");
				WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr__gainFactionInfluence_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack._ChangeRank_d__7>.NativeClassPtr, "<gainFactionInfluence>5__2");
				WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr__amount_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack._ChangeRank_d__7>.NativeClassPtr, "<amount>5__3");
				WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr__logMode_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack._ChangeRank_d__7>.NativeClassPtr, "<logMode>5__4");
				WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr__marker_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack._ChangeRank_d__7>.NativeClassPtr, "<marker>5__5");
				WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr__currentRank_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack._ChangeRank_d__7>.NativeClassPtr, "<currentRank>5__6");
				WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr__newRank_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack._ChangeRank_d__7>.NativeClassPtr, "<newRank>5__7");
				WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr__childUndo_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack._ChangeRank_d__7>.NativeClassPtr, "<childUndo>5__8");
				WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr__newRankSpace_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack._ChangeRank_d__7>.NativeClassPtr, "<newRankSpace>5__9");
				WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr__sequenceHelper_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack._ChangeRank_d__7>.NativeClassPtr, "<sequenceHelper>5__10");
				WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr___7__wrap10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack._ChangeRank_d__7>.NativeClassPtr, "<>7__wrap10");
				WormFactionTrack._ChangeRank_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack._ChangeRank_d__7>.NativeClassPtr, 100664068);
				WormFactionTrack._ChangeRank_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack._ChangeRank_d__7>.NativeClassPtr, 100664069);
				WormFactionTrack._ChangeRank_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack._ChangeRank_d__7>.NativeClassPtr, 100664070);
				WormFactionTrack._ChangeRank_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack._ChangeRank_d__7>.NativeClassPtr, 100664071);
				WormFactionTrack._ChangeRank_d__7.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack._ChangeRank_d__7>.NativeClassPtr, 100664072);
				WormFactionTrack._ChangeRank_d__7.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack._ChangeRank_d__7>.NativeClassPtr, 100664073);
				WormFactionTrack._ChangeRank_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack._ChangeRank_d__7>.NativeClassPtr, 100664074);
				WormFactionTrack._ChangeRank_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack._ChangeRank_d__7>.NativeClassPtr, 100664075);
				WormFactionTrack._ChangeRank_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack._ChangeRank_d__7>.NativeClassPtr, 100664076);
				WormFactionTrack._ChangeRank_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack._ChangeRank_d__7>.NativeClassPtr, 100664077);
				WormFactionTrack._ChangeRank_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack._ChangeRank_d__7>.NativeClassPtr, 100664078);
			}

			// Token: 0x06004490 RID: 17552 RVA: 0x00182C70 File Offset: 0x00180E70
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ChangeRank_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFactionTrack._ChangeRank_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrack._ChangeRank_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004491 RID: 17553 RVA: 0x00182CB8 File Offset: 0x00180EB8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37460, RefRangeEnd = 37461, XrefRangeStart = 37460, XrefRangeEnd = 37460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrack._ChangeRank_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004492 RID: 17554 RVA: 0x00182CEC File Offset: 0x00180EEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37461, XrefRangeEnd = 37788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrack._ChangeRank_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004493 RID: 17555 RVA: 0x00182D28 File Offset: 0x00180F28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37788, XrefRangeEnd = 37791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrack._ChangeRank_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004494 RID: 17556 RVA: 0x00182D5C File Offset: 0x00180F5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37791, XrefRangeEnd = 37794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrack._ChangeRank_d__7.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004495 RID: 17557 RVA: 0x00182D90 File Offset: 0x00180F90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37794, XrefRangeEnd = 37797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrack._ChangeRank_d__7.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001058 RID: 4184
			// (get) Token: 0x06004496 RID: 17558 RVA: 0x00182DC4 File Offset: 0x00180FC4
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrack._ChangeRank_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06004497 RID: 17559 RVA: 0x00182E04 File Offset: 0x00181004
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37797, XrefRangeEnd = 37802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrack._ChangeRank_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001059 RID: 4185
			// (get) Token: 0x06004498 RID: 17560 RVA: 0x00182E38 File Offset: 0x00181038
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrack._ChangeRank_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004499 RID: 17561 RVA: 0x00182E78 File Offset: 0x00181078
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37802, XrefRangeEnd = 37812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrack._ChangeRank_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600449A RID: 17562 RVA: 0x00182EB8 File Offset: 0x001810B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrack._ChangeRank_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600449B RID: 17563 RVA: 0x0001692F File Offset: 0x00014B2F
			public _ChangeRank_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001046 RID: 4166
			// (get) Token: 0x0600449C RID: 17564 RVA: 0x00182EF8 File Offset: 0x001810F8
			// (set) Token: 0x0600449D RID: 17565 RVA: 0x00016938 File Offset: 0x00014B38
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001047 RID: 4167
			// (get) Token: 0x0600449E RID: 17566 RVA: 0x00182F20 File Offset: 0x00181120
			// (set) Token: 0x0600449F RID: 17567 RVA: 0x00016953 File Offset: 0x00014B53
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001048 RID: 4168
			// (get) Token: 0x060044A0 RID: 17568 RVA: 0x00182F50 File Offset: 0x00181150
			// (set) Token: 0x060044A1 RID: 17569 RVA: 0x00016972 File Offset: 0x00014B72
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001049 RID: 4169
			// (get) Token: 0x060044A2 RID: 17570 RVA: 0x00182F78 File Offset: 0x00181178
			// (set) Token: 0x060044A3 RID: 17571 RVA: 0x0001698D File Offset: 0x00014B8D
			public unsafe global::Canis.actions.Action triggeringAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr_triggeringAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr_triggeringAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700104A RID: 4170
			// (get) Token: 0x060044A4 RID: 17572 RVA: 0x00182FA8 File Offset: 0x001811A8
			// (set) Token: 0x060044A5 RID: 17573 RVA: 0x000169AC File Offset: 0x00014BAC
			public unsafe global::Canis.actions.Action __3__triggeringAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr___3__triggeringAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr___3__triggeringAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700104B RID: 4171
			// (get) Token: 0x060044A6 RID: 17574 RVA: 0x00182FD8 File Offset: 0x001811D8
			// (set) Token: 0x060044A7 RID: 17575 RVA: 0x000169CB File Offset: 0x00014BCB
			public unsafe WormFactionTrack __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormFactionTrack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700104C RID: 4172
			// (get) Token: 0x060044A8 RID: 17576 RVA: 0x00183008 File Offset: 0x00181208
			// (set) Token: 0x060044A9 RID: 17577 RVA: 0x000169EA File Offset: 0x00014BEA
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700104D RID: 4173
			// (get) Token: 0x060044AA RID: 17578 RVA: 0x00183038 File Offset: 0x00181238
			// (set) Token: 0x060044AB RID: 17579 RVA: 0x00016A09 File Offset: 0x00014C09
			public unsafe WormPlayer __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700104E RID: 4174
			// (get) Token: 0x060044AC RID: 17580 RVA: 0x00183068 File Offset: 0x00181268
			// (set) Token: 0x060044AD RID: 17581 RVA: 0x00016A28 File Offset: 0x00014C28
			public unsafe GainFactionInfluence _gainFactionInfluence_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr__gainFactionInfluence_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GainFactionInfluence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr__gainFactionInfluence_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700104F RID: 4175
			// (get) Token: 0x060044AE RID: 17582 RVA: 0x00183098 File Offset: 0x00181298
			// (set) Token: 0x060044AF RID: 17583 RVA: 0x00016A47 File Offset: 0x00014C47
			public unsafe int _amount_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr__amount_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr__amount_5__3)) = value;
				}
			}

			// Token: 0x17001050 RID: 4176
			// (get) Token: 0x060044B0 RID: 17584 RVA: 0x001830C0 File Offset: 0x001812C0
			// (set) Token: 0x060044B1 RID: 17585 RVA: 0x00016A62 File Offset: 0x00014C62
			public unsafe ActionLogModes _logMode_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr__logMode_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr__logMode_5__4)) = value;
				}
			}

			// Token: 0x17001051 RID: 4177
			// (get) Token: 0x060044B2 RID: 17586 RVA: 0x001830E8 File Offset: 0x001812E8
			// (set) Token: 0x060044B3 RID: 17587 RVA: 0x00016A7D File Offset: 0x00014C7D
			public unsafe Entity _marker_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr__marker_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr__marker_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001052 RID: 4178
			// (get) Token: 0x060044B4 RID: 17588 RVA: 0x00183118 File Offset: 0x00181318
			// (set) Token: 0x060044B5 RID: 17589 RVA: 0x00016A9C File Offset: 0x00014C9C
			public unsafe int _currentRank_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr__currentRank_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr__currentRank_5__6)) = value;
				}
			}

			// Token: 0x17001053 RID: 4179
			// (get) Token: 0x060044B6 RID: 17590 RVA: 0x00183140 File Offset: 0x00181340
			// (set) Token: 0x060044B7 RID: 17591 RVA: 0x00016AB7 File Offset: 0x00014CB7
			public unsafe int _newRank_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr__newRank_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr__newRank_5__7)) = value;
				}
			}

			// Token: 0x17001054 RID: 4180
			// (get) Token: 0x060044B8 RID: 17592 RVA: 0x00183168 File Offset: 0x00181368
			// (set) Token: 0x060044B9 RID: 17593 RVA: 0x00016AD2 File Offset: 0x00014CD2
			public unsafe UndoNode _childUndo_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr__childUndo_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr__childUndo_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001055 RID: 4181
			// (get) Token: 0x060044BA RID: 17594 RVA: 0x00183198 File Offset: 0x00181398
			// (set) Token: 0x060044BB RID: 17595 RVA: 0x00016AF1 File Offset: 0x00014CF1
			public unsafe WormSpace _newRankSpace_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr__newRankSpace_5__9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr__newRankSpace_5__9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001056 RID: 4182
			// (get) Token: 0x060044BC RID: 17596 RVA: 0x001831C8 File Offset: 0x001813C8
			// (set) Token: 0x060044BD RID: 17597 RVA: 0x00016B10 File Offset: 0x00014D10
			public unsafe SequenceHelper _sequenceHelper_5__10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr__sequenceHelper_5__10);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr__sequenceHelper_5__10), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001057 RID: 4183
			// (get) Token: 0x060044BE RID: 17598 RVA: 0x001831F8 File Offset: 0x001813F8
			// (set) Token: 0x060044BF RID: 17599 RVA: 0x00016B2F File Offset: 0x00014D2F
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr___7__wrap10);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRank_d__7.NativeFieldInfoPtr___7__wrap10), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D40 RID: 11584
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002D41 RID: 11585
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002D42 RID: 11586
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002D43 RID: 11587
			private static readonly IntPtr NativeFieldInfoPtr_triggeringAction;

			// Token: 0x04002D44 RID: 11588
			private static readonly IntPtr NativeFieldInfoPtr___3__triggeringAction;

			// Token: 0x04002D45 RID: 11589
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002D46 RID: 11590
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04002D47 RID: 11591
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x04002D48 RID: 11592
			private static readonly IntPtr NativeFieldInfoPtr__gainFactionInfluence_5__2;

			// Token: 0x04002D49 RID: 11593
			private static readonly IntPtr NativeFieldInfoPtr__amount_5__3;

			// Token: 0x04002D4A RID: 11594
			private static readonly IntPtr NativeFieldInfoPtr__logMode_5__4;

			// Token: 0x04002D4B RID: 11595
			private static readonly IntPtr NativeFieldInfoPtr__marker_5__5;

			// Token: 0x04002D4C RID: 11596
			private static readonly IntPtr NativeFieldInfoPtr__currentRank_5__6;

			// Token: 0x04002D4D RID: 11597
			private static readonly IntPtr NativeFieldInfoPtr__newRank_5__7;

			// Token: 0x04002D4E RID: 11598
			private static readonly IntPtr NativeFieldInfoPtr__childUndo_5__8;

			// Token: 0x04002D4F RID: 11599
			private static readonly IntPtr NativeFieldInfoPtr__newRankSpace_5__9;

			// Token: 0x04002D50 RID: 11600
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__10;

			// Token: 0x04002D51 RID: 11601
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap10;

			// Token: 0x04002D52 RID: 11602
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002D53 RID: 11603
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002D54 RID: 11604
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002D55 RID: 11605
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04002D56 RID: 11606
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04002D57 RID: 11607
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

			// Token: 0x04002D58 RID: 11608
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04002D59 RID: 11609
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002D5A RID: 11610
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002D5B RID: 11611
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04002D5C RID: 11612
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200059A RID: 1434
		[ObfuscatedName("worm.canis.entities.WormFactionTrack+<ChangeRankBonuses>d__6")]
		public sealed class _ChangeRankBonuses_d__6 : Object
		{
			// Token: 0x060044C0 RID: 17600 RVA: 0x00183228 File Offset: 0x00181428
			// Note: this type is marked as 'beforefieldinit'.
			static _ChangeRankBonuses_d__6()
			{
				Il2CppClassPointerStore<WormFactionTrack._ChangeRankBonuses_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormFactionTrack>.NativeClassPtr, "<ChangeRankBonuses>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormFactionTrack._ChangeRankBonuses_d__6>.NativeClassPtr);
				WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack._ChangeRankBonuses_d__6>.NativeClassPtr, "<>1__state");
				WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack._ChangeRankBonuses_d__6>.NativeClassPtr, "<>2__current");
				WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack._ChangeRankBonuses_d__6>.NativeClassPtr, "<>l__initialThreadId");
				WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr_currentRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack._ChangeRankBonuses_d__6>.NativeClassPtr, "currentRank");
				WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr___3__currentRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack._ChangeRankBonuses_d__6>.NativeClassPtr, "<>3__currentRank");
				WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr_newRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack._ChangeRankBonuses_d__6>.NativeClassPtr, "newRank");
				WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr___3__newRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack._ChangeRankBonuses_d__6>.NativeClassPtr, "<>3__newRank");
				WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack._ChangeRankBonuses_d__6>.NativeClassPtr, "<>4__this");
				WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack._ChangeRankBonuses_d__6>.NativeClassPtr, "player");
				WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack._ChangeRankBonuses_d__6>.NativeClassPtr, "<>3__player");
				WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr__vpToGain_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrack._ChangeRankBonuses_d__6>.NativeClassPtr, "<vpToGain>5__2");
				WormFactionTrack._ChangeRankBonuses_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack._ChangeRankBonuses_d__6>.NativeClassPtr, 100664079);
				WormFactionTrack._ChangeRankBonuses_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack._ChangeRankBonuses_d__6>.NativeClassPtr, 100664080);
				WormFactionTrack._ChangeRankBonuses_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack._ChangeRankBonuses_d__6>.NativeClassPtr, 100664081);
				WormFactionTrack._ChangeRankBonuses_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack._ChangeRankBonuses_d__6>.NativeClassPtr, 100664082);
				WormFactionTrack._ChangeRankBonuses_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack._ChangeRankBonuses_d__6>.NativeClassPtr, 100664083);
				WormFactionTrack._ChangeRankBonuses_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack._ChangeRankBonuses_d__6>.NativeClassPtr, 100664084);
				WormFactionTrack._ChangeRankBonuses_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack._ChangeRankBonuses_d__6>.NativeClassPtr, 100664085);
				WormFactionTrack._ChangeRankBonuses_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrack._ChangeRankBonuses_d__6>.NativeClassPtr, 100664086);
			}

			// Token: 0x060044C1 RID: 17601 RVA: 0x001833D0 File Offset: 0x001815D0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ChangeRankBonuses_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFactionTrack._ChangeRankBonuses_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrack._ChangeRankBonuses_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060044C2 RID: 17602 RVA: 0x00183418 File Offset: 0x00181618
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrack._ChangeRankBonuses_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060044C3 RID: 17603 RVA: 0x0018344C File Offset: 0x0018164C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37812, XrefRangeEnd = 38025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrack._ChangeRankBonuses_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001065 RID: 4197
			// (get) Token: 0x060044C4 RID: 17604 RVA: 0x00183488 File Offset: 0x00181688
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrack._ChangeRankBonuses_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060044C5 RID: 17605 RVA: 0x001834C8 File Offset: 0x001816C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38025, XrefRangeEnd = 38030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrack._ChangeRankBonuses_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001066 RID: 4198
			// (get) Token: 0x060044C6 RID: 17606 RVA: 0x001834FC File Offset: 0x001816FC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrack._ChangeRankBonuses_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060044C7 RID: 17607 RVA: 0x0018353C File Offset: 0x0018173C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38030, XrefRangeEnd = 38039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrack._ChangeRankBonuses_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060044C8 RID: 17608 RVA: 0x0018357C File Offset: 0x0018177C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrack._ChangeRankBonuses_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060044C9 RID: 17609 RVA: 0x00016B4E File Offset: 0x00014D4E
			public _ChangeRankBonuses_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700105A RID: 4186
			// (get) Token: 0x060044CA RID: 17610 RVA: 0x001835BC File Offset: 0x001817BC
			// (set) Token: 0x060044CB RID: 17611 RVA: 0x00016B57 File Offset: 0x00014D57
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700105B RID: 4187
			// (get) Token: 0x060044CC RID: 17612 RVA: 0x001835E4 File Offset: 0x001817E4
			// (set) Token: 0x060044CD RID: 17613 RVA: 0x00016B72 File Offset: 0x00014D72
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700105C RID: 4188
			// (get) Token: 0x060044CE RID: 17614 RVA: 0x00183614 File Offset: 0x00181814
			// (set) Token: 0x060044CF RID: 17615 RVA: 0x00016B91 File Offset: 0x00014D91
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700105D RID: 4189
			// (get) Token: 0x060044D0 RID: 17616 RVA: 0x0018363C File Offset: 0x0018183C
			// (set) Token: 0x060044D1 RID: 17617 RVA: 0x00016BAC File Offset: 0x00014DAC
			public unsafe int currentRank
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr_currentRank);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr_currentRank)) = value;
				}
			}

			// Token: 0x1700105E RID: 4190
			// (get) Token: 0x060044D2 RID: 17618 RVA: 0x00183664 File Offset: 0x00181864
			// (set) Token: 0x060044D3 RID: 17619 RVA: 0x00016BC7 File Offset: 0x00014DC7
			public unsafe int __3__currentRank
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr___3__currentRank);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr___3__currentRank)) = value;
				}
			}

			// Token: 0x1700105F RID: 4191
			// (get) Token: 0x060044D4 RID: 17620 RVA: 0x0018368C File Offset: 0x0018188C
			// (set) Token: 0x060044D5 RID: 17621 RVA: 0x00016BE2 File Offset: 0x00014DE2
			public unsafe int newRank
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr_newRank);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr_newRank)) = value;
				}
			}

			// Token: 0x17001060 RID: 4192
			// (get) Token: 0x060044D6 RID: 17622 RVA: 0x001836B4 File Offset: 0x001818B4
			// (set) Token: 0x060044D7 RID: 17623 RVA: 0x00016BFD File Offset: 0x00014DFD
			public unsafe int __3__newRank
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr___3__newRank);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr___3__newRank)) = value;
				}
			}

			// Token: 0x17001061 RID: 4193
			// (get) Token: 0x060044D8 RID: 17624 RVA: 0x001836DC File Offset: 0x001818DC
			// (set) Token: 0x060044D9 RID: 17625 RVA: 0x00016C18 File Offset: 0x00014E18
			public unsafe WormFactionTrack __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormFactionTrack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001062 RID: 4194
			// (get) Token: 0x060044DA RID: 17626 RVA: 0x0018370C File Offset: 0x0018190C
			// (set) Token: 0x060044DB RID: 17627 RVA: 0x00016C37 File Offset: 0x00014E37
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001063 RID: 4195
			// (get) Token: 0x060044DC RID: 17628 RVA: 0x0018373C File Offset: 0x0018193C
			// (set) Token: 0x060044DD RID: 17629 RVA: 0x00016C56 File Offset: 0x00014E56
			public unsafe WormPlayer __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001064 RID: 4196
			// (get) Token: 0x060044DE RID: 17630 RVA: 0x0018376C File Offset: 0x0018196C
			// (set) Token: 0x060044DF RID: 17631 RVA: 0x00016C75 File Offset: 0x00014E75
			public unsafe int _vpToGain_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr__vpToGain_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrack._ChangeRankBonuses_d__6.NativeFieldInfoPtr__vpToGain_5__2)) = value;
				}
			}

			// Token: 0x04002D5D RID: 11613
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002D5E RID: 11614
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002D5F RID: 11615
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002D60 RID: 11616
			private static readonly IntPtr NativeFieldInfoPtr_currentRank;

			// Token: 0x04002D61 RID: 11617
			private static readonly IntPtr NativeFieldInfoPtr___3__currentRank;

			// Token: 0x04002D62 RID: 11618
			private static readonly IntPtr NativeFieldInfoPtr_newRank;

			// Token: 0x04002D63 RID: 11619
			private static readonly IntPtr NativeFieldInfoPtr___3__newRank;

			// Token: 0x04002D64 RID: 11620
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002D65 RID: 11621
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04002D66 RID: 11622
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x04002D67 RID: 11623
			private static readonly IntPtr NativeFieldInfoPtr__vpToGain_5__2;

			// Token: 0x04002D68 RID: 11624
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002D69 RID: 11625
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002D6A RID: 11626
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002D6B RID: 11627
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04002D6C RID: 11628
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002D6D RID: 11629
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002D6E RID: 11630
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04002D6F RID: 11631
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
