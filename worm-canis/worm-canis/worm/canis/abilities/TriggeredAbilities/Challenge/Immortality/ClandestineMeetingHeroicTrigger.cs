using System;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.events;
using Canis.gameLogs;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.abilities.TriggeredAbilities.Skirmish;
using worm.canis.entities;

namespace worm.canis.abilities.TriggeredAbilities.Challenge.Immortality
{
	// Token: 0x020003A0 RID: 928
	public class ClandestineMeetingHeroicTrigger : RuleModAbility
	{
		// Token: 0x060026BB RID: 9915 RVA: 0x000F5760 File Offset: 0x000F3960
		// Note: this type is marked as 'beforefieldinit'.
		static ClandestineMeetingHeroicTrigger()
		{
			Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.Challenge.Immortality", "ClandestineMeetingHeroicTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger>.NativeClassPtr);
			ClandestineMeetingHeroicTrigger.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger>.NativeClassPtr, "AbilityName");
			ClandestineMeetingHeroicTrigger.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger>.NativeClassPtr, "AbilityID");
			ClandestineMeetingHeroicTrigger.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger>.NativeClassPtr, 100674240);
			ClandestineMeetingHeroicTrigger.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger>.NativeClassPtr, 100674241);
			ClandestineMeetingHeroicTrigger.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger>.NativeClassPtr, 100674242);
			ClandestineMeetingHeroicTrigger.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger>.NativeClassPtr, 100674243);
			ClandestineMeetingHeroicTrigger.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger>.NativeClassPtr, 100674244);
			ClandestineMeetingHeroicTrigger.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger>.NativeClassPtr, 100674245);
		}

		// Token: 0x060026BC RID: 9916 RVA: 0x000F5830 File Offset: 0x000F3A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193295, XrefRangeEnd = 193299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClandestineMeetingHeroicTrigger.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x000F587C File Offset: 0x000F3A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193299, XrefRangeEnd = 193315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GameLogBuilder MakeGameLogBuilder(IHasGameLogs hasGameLogs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasGameLogs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClandestineMeetingHeroicTrigger.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x000F58D8 File Offset: 0x000F3AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193315, XrefRangeEnd = 193318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClandestineMeetingHeroicTrigger(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClandestineMeetingHeroicTrigger.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x000F5924 File Offset: 0x000F3B24
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClandestineMeetingHeroicTrigger(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClandestineMeetingHeroicTrigger.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x000F5994 File Offset: 0x000F3B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193318, XrefRangeEnd = 193325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<PlayerEntity> IsValidFor(SerializableEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClandestineMeetingHeroicTrigger.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x060026C1 RID: 9921 RVA: 0x000F59F0 File Offset: 0x000F3BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193325, XrefRangeEnd = 193332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Canis.actions.Action> BeginExecution(WormActiveAbility activeAbility, WormMatch match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeAbility);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClandestineMeetingHeroicTrigger.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060026C2 RID: 9922 RVA: 0x0000ECEE File Offset: 0x0000CEEE
		public ClandestineMeetingHeroicTrigger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x060026C3 RID: 9923 RVA: 0x000F5A70 File Offset: 0x000F3C70
		// (set) Token: 0x060026C4 RID: 9924 RVA: 0x0000ECF7 File Offset: 0x0000CEF7
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ClandestineMeetingHeroicTrigger.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClandestineMeetingHeroicTrigger.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x060026C5 RID: 9925 RVA: 0x000F5A90 File Offset: 0x000F3C90
		// (set) Token: 0x060026C6 RID: 9926 RVA: 0x0000ED09 File Offset: 0x0000CF09
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ClandestineMeetingHeroicTrigger.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClandestineMeetingHeroicTrigger.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018BA RID: 6330
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x040018BB RID: 6331
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x040018BC RID: 6332
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x040018BD RID: 6333
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0;

		// Token: 0x040018BE RID: 6334
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x040018BF RID: 6335
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x040018C0 RID: 6336
		private static readonly IntPtr NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0;

		// Token: 0x040018C1 RID: 6337
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x02000916 RID: 2326
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.Immortality.ClandestineMeetingHeroicTrigger+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06008A3B RID: 35387 RVA: 0x002589E8 File Offset: 0x00256BE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger.__c>.NativeClassPtr);
				ClandestineMeetingHeroicTrigger.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger.__c>.NativeClassPtr, "<>9");
				ClandestineMeetingHeroicTrigger.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger.__c>.NativeClassPtr, "<>9__6_0");
				ClandestineMeetingHeroicTrigger.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger.__c>.NativeClassPtr, "<>9__7_0");
				ClandestineMeetingHeroicTrigger.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger.__c>.NativeClassPtr, "<>9__7_1");
				ClandestineMeetingHeroicTrigger.__c.NativeFieldInfoPtr___9__7_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger.__c>.NativeClassPtr, "<>9__7_2");
				ClandestineMeetingHeroicTrigger.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger.__c>.NativeClassPtr, 100674248);
				ClandestineMeetingHeroicTrigger.__c.NativeMethodInfoPtr__IsValidFor_b__6_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger.__c>.NativeClassPtr, 100674249);
				ClandestineMeetingHeroicTrigger.__c.NativeMethodInfoPtr__BeginExecution_b__7_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger.__c>.NativeClassPtr, 100674250);
				ClandestineMeetingHeroicTrigger.__c.NativeMethodInfoPtr__BeginExecution_b__7_1_Internal_Boolean_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger.__c>.NativeClassPtr, 100674251);
				ClandestineMeetingHeroicTrigger.__c.NativeMethodInfoPtr__BeginExecution_b__7_2_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger.__c>.NativeClassPtr, 100674252);
			}

			// Token: 0x06008A3C RID: 35388 RVA: 0x00258ADC File Offset: 0x00256CDC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClandestineMeetingHeroicTrigger.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008A3D RID: 35389 RVA: 0x00258B18 File Offset: 0x00256D18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsValidFor_b__6_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClandestineMeetingHeroicTrigger.__c.NativeMethodInfoPtr__IsValidFor_b__6_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06008A3E RID: 35390 RVA: 0x00258B68 File Offset: 0x00256D68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193069, XrefRangeEnd = 193078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginExecution_b__7_0(Entity e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClandestineMeetingHeroicTrigger.__c.NativeMethodInfoPtr__BeginExecution_b__7_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06008A3F RID: 35391 RVA: 0x00258BB8 File Offset: 0x00256DB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193078, XrefRangeEnd = 193087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginExecution_b__7_1(WormImperiumPlayable e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClandestineMeetingHeroicTrigger.__c.NativeMethodInfoPtr__BeginExecution_b__7_1_Internal_Boolean_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06008A40 RID: 35392 RVA: 0x00258C08 File Offset: 0x00256E08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193087, XrefRangeEnd = 193096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginExecution_b__7_2(WormAbilityDefinition ab)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ab);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClandestineMeetingHeroicTrigger.__c.NativeMethodInfoPtr__BeginExecution_b__7_2_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06008A41 RID: 35393 RVA: 0x0003ADCF File Offset: 0x00038FCF
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002817 RID: 10263
			// (get) Token: 0x06008A42 RID: 35394 RVA: 0x00258C58 File Offset: 0x00256E58
			// (set) Token: 0x06008A43 RID: 35395 RVA: 0x0003ADD8 File Offset: 0x00038FD8
			public unsafe static ClandestineMeetingHeroicTrigger.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ClandestineMeetingHeroicTrigger.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClandestineMeetingHeroicTrigger.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ClandestineMeetingHeroicTrigger.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002818 RID: 10264
			// (get) Token: 0x06008A44 RID: 35396 RVA: 0x00258C80 File Offset: 0x00256E80
			// (set) Token: 0x06008A45 RID: 35397 RVA: 0x0003ADEA File Offset: 0x00038FEA
			public unsafe static Func<WormPlayer, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ClandestineMeetingHeroicTrigger.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ClandestineMeetingHeroicTrigger.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002819 RID: 10265
			// (get) Token: 0x06008A46 RID: 35398 RVA: 0x00258CA8 File Offset: 0x00256EA8
			// (set) Token: 0x06008A47 RID: 35399 RVA: 0x0003ADFC File Offset: 0x00038FFC
			public unsafe static Func<Entity, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ClandestineMeetingHeroicTrigger.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ClandestineMeetingHeroicTrigger.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700281A RID: 10266
			// (get) Token: 0x06008A48 RID: 35400 RVA: 0x00258CD0 File Offset: 0x00256ED0
			// (set) Token: 0x06008A49 RID: 35401 RVA: 0x0003AE0E File Offset: 0x0003900E
			public unsafe static Func<WormImperiumPlayable, bool> __9__7_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ClandestineMeetingHeroicTrigger.__c.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ClandestineMeetingHeroicTrigger.__c.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700281B RID: 10267
			// (get) Token: 0x06008A4A RID: 35402 RVA: 0x00258CF8 File Offset: 0x00256EF8
			// (set) Token: 0x06008A4B RID: 35403 RVA: 0x0003AE20 File Offset: 0x00039020
			public unsafe static Func<WormAbilityDefinition, bool> __9__7_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ClandestineMeetingHeroicTrigger.__c.NativeFieldInfoPtr___9__7_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ClandestineMeetingHeroicTrigger.__c.NativeFieldInfoPtr___9__7_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005859 RID: 22617
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400585A RID: 22618
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x0400585B RID: 22619
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x0400585C RID: 22620
			private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

			// Token: 0x0400585D RID: 22621
			private static readonly IntPtr NativeFieldInfoPtr___9__7_2;

			// Token: 0x0400585E RID: 22622
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400585F RID: 22623
			private static readonly IntPtr NativeMethodInfoPtr__IsValidFor_b__6_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x04005860 RID: 22624
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__7_0_Internal_Boolean_Entity_0;

			// Token: 0x04005861 RID: 22625
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__7_1_Internal_Boolean_WormImperiumPlayable_0;

			// Token: 0x04005862 RID: 22626
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__7_2_Internal_Boolean_WormAbilityDefinition_0;
		}

		// Token: 0x02000917 RID: 2327
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.Immortality.ClandestineMeetingHeroicTrigger+<BeginExecution>d__7")]
		public sealed class _BeginExecution_d__7 : Object
		{
			// Token: 0x06008A4C RID: 35404 RVA: 0x00258D20 File Offset: 0x00256F20
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__7()
			{
				Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._BeginExecution_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger>.NativeClassPtr, "<BeginExecution>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._BeginExecution_d__7>.NativeClassPtr);
				ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._BeginExecution_d__7>.NativeClassPtr, "<>1__state");
				ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._BeginExecution_d__7>.NativeClassPtr, "<>2__current");
				ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._BeginExecution_d__7>.NativeClassPtr, "<>l__initialThreadId");
				ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._BeginExecution_d__7>.NativeClassPtr, "activeAbility");
				ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._BeginExecution_d__7>.NativeClassPtr, "<>3__activeAbility");
				ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._BeginExecution_d__7>.NativeClassPtr, "match");
				ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._BeginExecution_d__7>.NativeClassPtr, "<>3__match");
				ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._BeginExecution_d__7>.NativeClassPtr, "<player>5__2");
				ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._BeginExecution_d__7>.NativeClassPtr, "<>7__wrap2");
				ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeFieldInfoPtr__opponent_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._BeginExecution_d__7>.NativeClassPtr, "<opponent>5__4");
				ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._BeginExecution_d__7>.NativeClassPtr, 100674253);
				ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._BeginExecution_d__7>.NativeClassPtr, 100674254);
				ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._BeginExecution_d__7>.NativeClassPtr, 100674255);
				ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._BeginExecution_d__7>.NativeClassPtr, 100674256);
				ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._BeginExecution_d__7>.NativeClassPtr, 100674257);
				ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._BeginExecution_d__7>.NativeClassPtr, 100674258);
				ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._BeginExecution_d__7>.NativeClassPtr, 100674259);
				ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._BeginExecution_d__7>.NativeClassPtr, 100674260);
				ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._BeginExecution_d__7>.NativeClassPtr, 100674261);
			}

			// Token: 0x06008A4D RID: 35405 RVA: 0x00258EC8 File Offset: 0x002570C8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._BeginExecution_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06008A4E RID: 35406 RVA: 0x00258F10 File Offset: 0x00257110
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193096, XrefRangeEnd = 193101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008A4F RID: 35407 RVA: 0x00258F44 File Offset: 0x00257144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193101, XrefRangeEnd = 193242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008A50 RID: 35408 RVA: 0x00258F80 File Offset: 0x00257180
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193242, XrefRangeEnd = 193245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002826 RID: 10278
			// (get) Token: 0x06008A51 RID: 35409 RVA: 0x00258FB4 File Offset: 0x002571B4
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06008A52 RID: 35410 RVA: 0x00258FF4 File Offset: 0x002571F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193245, XrefRangeEnd = 193250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002827 RID: 10279
			// (get) Token: 0x06008A53 RID: 35411 RVA: 0x00259028 File Offset: 0x00257228
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008A54 RID: 35412 RVA: 0x00259068 File Offset: 0x00257268
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193250, XrefRangeEnd = 193259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06008A55 RID: 35413 RVA: 0x002590A8 File Offset: 0x002572A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06008A56 RID: 35414 RVA: 0x0003AE32 File Offset: 0x00039032
			public _BeginExecution_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700281C RID: 10268
			// (get) Token: 0x06008A57 RID: 35415 RVA: 0x002590E8 File Offset: 0x002572E8
			// (set) Token: 0x06008A58 RID: 35416 RVA: 0x0003AE3B File Offset: 0x0003903B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700281D RID: 10269
			// (get) Token: 0x06008A59 RID: 35417 RVA: 0x00259110 File Offset: 0x00257310
			// (set) Token: 0x06008A5A RID: 35418 RVA: 0x0003AE56 File Offset: 0x00039056
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700281E RID: 10270
			// (get) Token: 0x06008A5B RID: 35419 RVA: 0x00259140 File Offset: 0x00257340
			// (set) Token: 0x06008A5C RID: 35420 RVA: 0x0003AE75 File Offset: 0x00039075
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700281F RID: 10271
			// (get) Token: 0x06008A5D RID: 35421 RVA: 0x00259168 File Offset: 0x00257368
			// (set) Token: 0x06008A5E RID: 35422 RVA: 0x0003AE90 File Offset: 0x00039090
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002820 RID: 10272
			// (get) Token: 0x06008A5F RID: 35423 RVA: 0x00259198 File Offset: 0x00257398
			// (set) Token: 0x06008A60 RID: 35424 RVA: 0x0003AEAF File Offset: 0x000390AF
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002821 RID: 10273
			// (get) Token: 0x06008A61 RID: 35425 RVA: 0x002591C8 File Offset: 0x002573C8
			// (set) Token: 0x06008A62 RID: 35426 RVA: 0x0003AECE File Offset: 0x000390CE
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002822 RID: 10274
			// (get) Token: 0x06008A63 RID: 35427 RVA: 0x002591F8 File Offset: 0x002573F8
			// (set) Token: 0x06008A64 RID: 35428 RVA: 0x0003AEED File Offset: 0x000390ED
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002823 RID: 10275
			// (get) Token: 0x06008A65 RID: 35429 RVA: 0x00259228 File Offset: 0x00257428
			// (set) Token: 0x06008A66 RID: 35430 RVA: 0x0003AF0C File Offset: 0x0003910C
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002824 RID: 10276
			// (get) Token: 0x06008A67 RID: 35431 RVA: 0x00259258 File Offset: 0x00257458
			// (set) Token: 0x06008A68 RID: 35432 RVA: 0x0003AF2B File Offset: 0x0003912B
			public unsafe IEnumerator<WormPlayer> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<WormPlayer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002825 RID: 10277
			// (get) Token: 0x06008A69 RID: 35433 RVA: 0x00259288 File Offset: 0x00257488
			// (set) Token: 0x06008A6A RID: 35434 RVA: 0x0003AF4A File Offset: 0x0003914A
			public unsafe WormPlayer _opponent_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeFieldInfoPtr__opponent_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClandestineMeetingHeroicTrigger._BeginExecution_d__7.NativeFieldInfoPtr__opponent_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005863 RID: 22627
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005864 RID: 22628
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005865 RID: 22629
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04005866 RID: 22630
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04005867 RID: 22631
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04005868 RID: 22632
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04005869 RID: 22633
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x0400586A RID: 22634
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x0400586B RID: 22635
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x0400586C RID: 22636
			private static readonly IntPtr NativeFieldInfoPtr__opponent_5__4;

			// Token: 0x0400586D RID: 22637
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400586E RID: 22638
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400586F RID: 22639
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005870 RID: 22640
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04005871 RID: 22641
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04005872 RID: 22642
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005873 RID: 22643
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005874 RID: 22644
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04005875 RID: 22645
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000918 RID: 2328
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.Immortality.ClandestineMeetingHeroicTrigger+<IsValidFor>d__6")]
		public sealed class _IsValidFor_d__6 : Object
		{
			// Token: 0x06008A6B RID: 35435 RVA: 0x002592B8 File Offset: 0x002574B8
			// Note: this type is marked as 'beforefieldinit'.
			static _IsValidFor_d__6()
			{
				Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._IsValidFor_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger>.NativeClassPtr, "<IsValidFor>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._IsValidFor_d__6>.NativeClassPtr);
				ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._IsValidFor_d__6>.NativeClassPtr, "<>1__state");
				ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._IsValidFor_d__6>.NativeClassPtr, "<>2__current");
				ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._IsValidFor_d__6>.NativeClassPtr, "<>l__initialThreadId");
				ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._IsValidFor_d__6>.NativeClassPtr, "evt");
				ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeFieldInfoPtr___3__evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._IsValidFor_d__6>.NativeClassPtr, "<>3__evt");
				ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._IsValidFor_d__6>.NativeClassPtr, "<>4__this");
				ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._IsValidFor_d__6>.NativeClassPtr, 100674262);
				ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._IsValidFor_d__6>.NativeClassPtr, 100674263);
				ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._IsValidFor_d__6>.NativeClassPtr, 100674264);
				ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._IsValidFor_d__6>.NativeClassPtr, 100674265);
				ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._IsValidFor_d__6>.NativeClassPtr, 100674266);
				ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._IsValidFor_d__6>.NativeClassPtr, 100674267);
				ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._IsValidFor_d__6>.NativeClassPtr, 100674268);
				ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._IsValidFor_d__6>.NativeClassPtr, 100674269);
			}

			// Token: 0x06008A6C RID: 35436 RVA: 0x002593FC File Offset: 0x002575FC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _IsValidFor_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClandestineMeetingHeroicTrigger._IsValidFor_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06008A6D RID: 35437 RVA: 0x00259444 File Offset: 0x00257644
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008A6E RID: 35438 RVA: 0x00259478 File Offset: 0x00257678
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193259, XrefRangeEnd = 193281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700282E RID: 10286
			// (get) Token: 0x06008A6F RID: 35439 RVA: 0x002594B4 File Offset: 0x002576B4
			public unsafe PlayerEntity System.Collections.Generic.IEnumerator<Canis.entities.PlayerEntity>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
				}
			}

			// Token: 0x06008A70 RID: 35440 RVA: 0x002594F4 File Offset: 0x002576F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193281, XrefRangeEnd = 193286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700282F RID: 10287
			// (get) Token: 0x06008A71 RID: 35441 RVA: 0x00259528 File Offset: 0x00257728
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008A72 RID: 35442 RVA: 0x00259568 File Offset: 0x00257768
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193286, XrefRangeEnd = 193295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<PlayerEntity> System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayerEntity>>(intPtr3) : null;
			}

			// Token: 0x06008A73 RID: 35443 RVA: 0x002595A8 File Offset: 0x002577A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06008A74 RID: 35444 RVA: 0x0003AF69 File Offset: 0x00039169
			public _IsValidFor_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002828 RID: 10280
			// (get) Token: 0x06008A75 RID: 35445 RVA: 0x002595E8 File Offset: 0x002577E8
			// (set) Token: 0x06008A76 RID: 35446 RVA: 0x0003AF72 File Offset: 0x00039172
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002829 RID: 10281
			// (get) Token: 0x06008A77 RID: 35447 RVA: 0x00259610 File Offset: 0x00257810
			// (set) Token: 0x06008A78 RID: 35448 RVA: 0x0003AF8D File Offset: 0x0003918D
			public unsafe PlayerEntity __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700282A RID: 10282
			// (get) Token: 0x06008A79 RID: 35449 RVA: 0x00259640 File Offset: 0x00257840
			// (set) Token: 0x06008A7A RID: 35450 RVA: 0x0003AFAC File Offset: 0x000391AC
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700282B RID: 10283
			// (get) Token: 0x06008A7B RID: 35451 RVA: 0x00259668 File Offset: 0x00257868
			// (set) Token: 0x06008A7C RID: 35452 RVA: 0x0003AFC7 File Offset: 0x000391C7
			public unsafe SerializableEvent evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeFieldInfoPtr_evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700282C RID: 10284
			// (get) Token: 0x06008A7D RID: 35453 RVA: 0x00259698 File Offset: 0x00257898
			// (set) Token: 0x06008A7E RID: 35454 RVA: 0x0003AFE6 File Offset: 0x000391E6
			public unsafe SerializableEvent __3__evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeFieldInfoPtr___3__evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeFieldInfoPtr___3__evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700282D RID: 10285
			// (get) Token: 0x06008A7F RID: 35455 RVA: 0x002596C8 File Offset: 0x002578C8
			// (set) Token: 0x06008A80 RID: 35456 RVA: 0x0003B005 File Offset: 0x00039205
			public unsafe ClandestineMeetingHeroicTrigger __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClandestineMeetingHeroicTrigger>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClandestineMeetingHeroicTrigger._IsValidFor_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005876 RID: 22646
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005877 RID: 22647
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005878 RID: 22648
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04005879 RID: 22649
			private static readonly IntPtr NativeFieldInfoPtr_evt;

			// Token: 0x0400587A RID: 22650
			private static readonly IntPtr NativeFieldInfoPtr___3__evt;

			// Token: 0x0400587B RID: 22651
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400587C RID: 22652
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400587D RID: 22653
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400587E RID: 22654
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400587F RID: 22655
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0;

			// Token: 0x04005880 RID: 22656
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005881 RID: 22657
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005882 RID: 22658
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0;

			// Token: 0x04005883 RID: 22659
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
