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
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.abilities.TriggeredAbilities.Skirmish.RiseOfIx
{
	// Token: 0x0200034E RID: 846
	public class IntimidatingForceTrigger : RuleModAbility
	{
		// Token: 0x06002294 RID: 8852 RVA: 0x000E1C10 File Offset: 0x000DFE10
		// Note: this type is marked as 'beforefieldinit'.
		static IntimidatingForceTrigger()
		{
			Il2CppClassPointerStore<IntimidatingForceTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.Skirmish.RiseOfIx", "IntimidatingForceTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntimidatingForceTrigger>.NativeClassPtr);
			IntimidatingForceTrigger.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntimidatingForceTrigger>.NativeClassPtr, "AbilityName");
			IntimidatingForceTrigger.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntimidatingForceTrigger>.NativeClassPtr, "AbilityID");
			IntimidatingForceTrigger.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntimidatingForceTrigger>.NativeClassPtr, 100672193);
			IntimidatingForceTrigger.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntimidatingForceTrigger>.NativeClassPtr, 100672194);
			IntimidatingForceTrigger.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntimidatingForceTrigger>.NativeClassPtr, 100672195);
			IntimidatingForceTrigger.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntimidatingForceTrigger>.NativeClassPtr, 100672196);
			IntimidatingForceTrigger.NativeMethodInfoPtr_GetDeployedDreadnoughts_Private_Il2CppReferenceArray_1_WormDreadnought_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntimidatingForceTrigger>.NativeClassPtr, 100672197);
			IntimidatingForceTrigger.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntimidatingForceTrigger>.NativeClassPtr, 100672198);
			IntimidatingForceTrigger.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntimidatingForceTrigger>.NativeClassPtr, 100672199);
			IntimidatingForceTrigger.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntimidatingForceTrigger>.NativeClassPtr, 100672200);
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x000E1D08 File Offset: 0x000DFF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181460, XrefRangeEnd = 181464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntimidatingForceTrigger.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x000E1D54 File Offset: 0x000DFF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181464, XrefRangeEnd = 181480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GameLogBuilder MakeGameLogBuilder(IHasGameLogs hasGameLogs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasGameLogs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntimidatingForceTrigger.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x000E1DB0 File Offset: 0x000DFFB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181480, XrefRangeEnd = 181483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntimidatingForceTrigger(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntimidatingForceTrigger>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntimidatingForceTrigger.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002298 RID: 8856 RVA: 0x000E1DFC File Offset: 0x000DFFFC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntimidatingForceTrigger(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntimidatingForceTrigger>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntimidatingForceTrigger.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002299 RID: 8857 RVA: 0x000E1E6C File Offset: 0x000E006C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181483, XrefRangeEnd = 181498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<WormDreadnought> GetDeployedDreadnoughts(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntimidatingForceTrigger.NativeMethodInfoPtr_GetDeployedDreadnoughts_Private_Il2CppReferenceArray_1_WormDreadnought_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WormDreadnought>>(intPtr3) : null;
			}
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x000E1EBC File Offset: 0x000E00BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181498, XrefRangeEnd = 181505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<PlayerEntity> IsValidFor(SerializableEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntimidatingForceTrigger.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x0600229B RID: 8859 RVA: 0x000E1F18 File Offset: 0x000E0118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181505, XrefRangeEnd = 181512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntimidatingForceTrigger.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600229C RID: 8860 RVA: 0x000E1F98 File Offset: 0x000E0198
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25007, RefRangeEnd = 25008, XrefRangeStart = 25007, XrefRangeEnd = 25008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ResumeExecution(WormActiveAbility activeAbility, Canis.actions.Action returningAction, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeAbility);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returningAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntimidatingForceTrigger.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x0000DE45 File Offset: 0x0000C045
		public IntimidatingForceTrigger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x0600229E RID: 8862 RVA: 0x000E2014 File Offset: 0x000E0214
		// (set) Token: 0x0600229F RID: 8863 RVA: 0x0000DE4E File Offset: 0x0000C04E
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IntimidatingForceTrigger.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IntimidatingForceTrigger.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x060022A0 RID: 8864 RVA: 0x000E2034 File Offset: 0x000E0234
		// (set) Token: 0x060022A1 RID: 8865 RVA: 0x0000DE60 File Offset: 0x0000C060
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IntimidatingForceTrigger.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IntimidatingForceTrigger.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040015E1 RID: 5601
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x040015E2 RID: 5602
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x040015E3 RID: 5603
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x040015E4 RID: 5604
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0;

		// Token: 0x040015E5 RID: 5605
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x040015E6 RID: 5606
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x040015E7 RID: 5607
		private static readonly IntPtr NativeMethodInfoPtr_GetDeployedDreadnoughts_Private_Il2CppReferenceArray_1_WormDreadnought_Context_0;

		// Token: 0x040015E8 RID: 5608
		private static readonly IntPtr NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0;

		// Token: 0x040015E9 RID: 5609
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x040015EA RID: 5610
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0;

		// Token: 0x02000842 RID: 2114
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Skirmish.RiseOfIx.IntimidatingForceTrigger+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x06007941 RID: 31041 RVA: 0x002267AC File Offset: 0x002249AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<IntimidatingForceTrigger.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IntimidatingForceTrigger>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntimidatingForceTrigger.__c__DisplayClass8_0>.NativeClassPtr);
				IntimidatingForceTrigger.__c__DisplayClass8_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntimidatingForceTrigger.__c__DisplayClass8_0>.NativeClassPtr, "player");
				IntimidatingForceTrigger.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntimidatingForceTrigger.__c__DisplayClass8_0>.NativeClassPtr, 100672202);
				IntimidatingForceTrigger.__c__DisplayClass8_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntimidatingForceTrigger.__c__DisplayClass8_0>.NativeClassPtr, 100672203);
			}

			// Token: 0x06007942 RID: 31042 RVA: 0x00226814 File Offset: 0x00224A14
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntimidatingForceTrigger.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntimidatingForceTrigger.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007943 RID: 31043 RVA: 0x00226850 File Offset: 0x00224A50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181206, XrefRangeEnd = 181210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _BeginExecution_b__0(GameLogBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntimidatingForceTrigger.__c__DisplayClass8_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x06007944 RID: 31044 RVA: 0x000314ED File Offset: 0x0002F6ED
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170021F1 RID: 8689
			// (get) Token: 0x06007945 RID: 31045 RVA: 0x002268A0 File Offset: 0x00224AA0
			// (set) Token: 0x06007946 RID: 31046 RVA: 0x000314F6 File Offset: 0x0002F6F6
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntimidatingForceTrigger.__c__DisplayClass8_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntimidatingForceTrigger.__c__DisplayClass8_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004E09 RID: 19977
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04004E0A RID: 19978
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004E0B RID: 19979
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__0_Internal_GameLogBuilder_GameLogBuilder_0;
		}

		// Token: 0x02000843 RID: 2115
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Skirmish.RiseOfIx.IntimidatingForceTrigger+<>c__DisplayClass8_1")]
		public sealed class __c__DisplayClass8_1 : Object
		{
			// Token: 0x06007947 RID: 31047 RVA: 0x002268D0 File Offset: 0x00224AD0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_1()
			{
				Il2CppClassPointerStore<IntimidatingForceTrigger.__c__DisplayClass8_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IntimidatingForceTrigger>.NativeClassPtr, "<>c__DisplayClass8_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntimidatingForceTrigger.__c__DisplayClass8_1>.NativeClassPtr);
				IntimidatingForceTrigger.__c__DisplayClass8_1.NativeFieldInfoPtr_affectedOpponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntimidatingForceTrigger.__c__DisplayClass8_1>.NativeClassPtr, "affectedOpponents");
				IntimidatingForceTrigger.__c__DisplayClass8_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntimidatingForceTrigger.__c__DisplayClass8_1>.NativeClassPtr, 100672204);
				IntimidatingForceTrigger.__c__DisplayClass8_1.NativeMethodInfoPtr__BeginExecution_b__1_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntimidatingForceTrigger.__c__DisplayClass8_1>.NativeClassPtr, 100672205);
			}

			// Token: 0x06007948 RID: 31048 RVA: 0x00226938 File Offset: 0x00224B38
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntimidatingForceTrigger.__c__DisplayClass8_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntimidatingForceTrigger.__c__DisplayClass8_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007949 RID: 31049 RVA: 0x00226974 File Offset: 0x00224B74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181210, XrefRangeEnd = 181312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _BeginExecution_b__1(GameLogBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntimidatingForceTrigger.__c__DisplayClass8_1.NativeMethodInfoPtr__BeginExecution_b__1_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x0600794A RID: 31050 RVA: 0x00031515 File Offset: 0x0002F715
			public __c__DisplayClass8_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170021F2 RID: 8690
			// (get) Token: 0x0600794B RID: 31051 RVA: 0x002269C4 File Offset: 0x00224BC4
			// (set) Token: 0x0600794C RID: 31052 RVA: 0x0003151E File Offset: 0x0002F71E
			public unsafe List<WormPlayer> affectedOpponents
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntimidatingForceTrigger.__c__DisplayClass8_1.NativeFieldInfoPtr_affectedOpponents);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormPlayer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntimidatingForceTrigger.__c__DisplayClass8_1.NativeFieldInfoPtr_affectedOpponents), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004E0C RID: 19980
			private static readonly IntPtr NativeFieldInfoPtr_affectedOpponents;

			// Token: 0x04004E0D RID: 19981
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004E0E RID: 19982
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__1_Internal_GameLogBuilder_GameLogBuilder_0;
		}

		// Token: 0x02000844 RID: 2116
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Skirmish.RiseOfIx.IntimidatingForceTrigger+<BeginExecution>d__8")]
		public sealed class _BeginExecution_d__8 : Object
		{
			// Token: 0x0600794D RID: 31053 RVA: 0x002269F4 File Offset: 0x00224BF4
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__8()
			{
				Il2CppClassPointerStore<IntimidatingForceTrigger._BeginExecution_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IntimidatingForceTrigger>.NativeClassPtr, "<BeginExecution>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntimidatingForceTrigger._BeginExecution_d__8>.NativeClassPtr);
				IntimidatingForceTrigger._BeginExecution_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntimidatingForceTrigger._BeginExecution_d__8>.NativeClassPtr, "<>1__state");
				IntimidatingForceTrigger._BeginExecution_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntimidatingForceTrigger._BeginExecution_d__8>.NativeClassPtr, "<>2__current");
				IntimidatingForceTrigger._BeginExecution_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntimidatingForceTrigger._BeginExecution_d__8>.NativeClassPtr, "<>l__initialThreadId");
				IntimidatingForceTrigger._BeginExecution_d__8.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntimidatingForceTrigger._BeginExecution_d__8>.NativeClassPtr, "activeAbility");
				IntimidatingForceTrigger._BeginExecution_d__8.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntimidatingForceTrigger._BeginExecution_d__8>.NativeClassPtr, "<>3__activeAbility");
				IntimidatingForceTrigger._BeginExecution_d__8.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntimidatingForceTrigger._BeginExecution_d__8>.NativeClassPtr, "match");
				IntimidatingForceTrigger._BeginExecution_d__8.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntimidatingForceTrigger._BeginExecution_d__8>.NativeClassPtr, "<>3__match");
				IntimidatingForceTrigger._BeginExecution_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntimidatingForceTrigger._BeginExecution_d__8>.NativeClassPtr, 100672206);
				IntimidatingForceTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntimidatingForceTrigger._BeginExecution_d__8>.NativeClassPtr, 100672207);
				IntimidatingForceTrigger._BeginExecution_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntimidatingForceTrigger._BeginExecution_d__8>.NativeClassPtr, 100672208);
				IntimidatingForceTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntimidatingForceTrigger._BeginExecution_d__8>.NativeClassPtr, 100672209);
				IntimidatingForceTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntimidatingForceTrigger._BeginExecution_d__8>.NativeClassPtr, 100672210);
				IntimidatingForceTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntimidatingForceTrigger._BeginExecution_d__8>.NativeClassPtr, 100672211);
				IntimidatingForceTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntimidatingForceTrigger._BeginExecution_d__8>.NativeClassPtr, 100672212);
				IntimidatingForceTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntimidatingForceTrigger._BeginExecution_d__8>.NativeClassPtr, 100672213);
			}

			// Token: 0x0600794E RID: 31054 RVA: 0x00226B4C File Offset: 0x00224D4C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntimidatingForceTrigger._BeginExecution_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntimidatingForceTrigger._BeginExecution_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600794F RID: 31055 RVA: 0x00226B94 File Offset: 0x00224D94
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntimidatingForceTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007950 RID: 31056 RVA: 0x00226BC8 File Offset: 0x00224DC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181312, XrefRangeEnd = 181400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntimidatingForceTrigger._BeginExecution_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170021FA RID: 8698
			// (get) Token: 0x06007951 RID: 31057 RVA: 0x00226C04 File Offset: 0x00224E04
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntimidatingForceTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06007952 RID: 31058 RVA: 0x00226C44 File Offset: 0x00224E44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181400, XrefRangeEnd = 181405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntimidatingForceTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170021FB RID: 8699
			// (get) Token: 0x06007953 RID: 31059 RVA: 0x00226C78 File Offset: 0x00224E78
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntimidatingForceTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007954 RID: 31060 RVA: 0x00226CB8 File Offset: 0x00224EB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181405, XrefRangeEnd = 181414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntimidatingForceTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06007955 RID: 31061 RVA: 0x00226CF8 File Offset: 0x00224EF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntimidatingForceTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06007956 RID: 31062 RVA: 0x0003153D File Offset: 0x0002F73D
			public _BeginExecution_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170021F3 RID: 8691
			// (get) Token: 0x06007957 RID: 31063 RVA: 0x00226D38 File Offset: 0x00224F38
			// (set) Token: 0x06007958 RID: 31064 RVA: 0x00031546 File Offset: 0x0002F746
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntimidatingForceTrigger._BeginExecution_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntimidatingForceTrigger._BeginExecution_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170021F4 RID: 8692
			// (get) Token: 0x06007959 RID: 31065 RVA: 0x00226D60 File Offset: 0x00224F60
			// (set) Token: 0x0600795A RID: 31066 RVA: 0x00031561 File Offset: 0x0002F761
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntimidatingForceTrigger._BeginExecution_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntimidatingForceTrigger._BeginExecution_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170021F5 RID: 8693
			// (get) Token: 0x0600795B RID: 31067 RVA: 0x00226D90 File Offset: 0x00224F90
			// (set) Token: 0x0600795C RID: 31068 RVA: 0x00031580 File Offset: 0x0002F780
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntimidatingForceTrigger._BeginExecution_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntimidatingForceTrigger._BeginExecution_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170021F6 RID: 8694
			// (get) Token: 0x0600795D RID: 31069 RVA: 0x00226DB8 File Offset: 0x00224FB8
			// (set) Token: 0x0600795E RID: 31070 RVA: 0x0003159B File Offset: 0x0002F79B
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntimidatingForceTrigger._BeginExecution_d__8.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntimidatingForceTrigger._BeginExecution_d__8.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170021F7 RID: 8695
			// (get) Token: 0x0600795F RID: 31071 RVA: 0x00226DE8 File Offset: 0x00224FE8
			// (set) Token: 0x06007960 RID: 31072 RVA: 0x000315BA File Offset: 0x0002F7BA
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntimidatingForceTrigger._BeginExecution_d__8.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntimidatingForceTrigger._BeginExecution_d__8.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170021F8 RID: 8696
			// (get) Token: 0x06007961 RID: 31073 RVA: 0x00226E18 File Offset: 0x00225018
			// (set) Token: 0x06007962 RID: 31074 RVA: 0x000315D9 File Offset: 0x0002F7D9
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntimidatingForceTrigger._BeginExecution_d__8.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntimidatingForceTrigger._BeginExecution_d__8.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170021F9 RID: 8697
			// (get) Token: 0x06007963 RID: 31075 RVA: 0x00226E48 File Offset: 0x00225048
			// (set) Token: 0x06007964 RID: 31076 RVA: 0x000315F8 File Offset: 0x0002F7F8
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntimidatingForceTrigger._BeginExecution_d__8.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntimidatingForceTrigger._BeginExecution_d__8.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004E0F RID: 19983
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004E10 RID: 19984
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004E11 RID: 19985
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004E12 RID: 19986
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04004E13 RID: 19987
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04004E14 RID: 19988
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04004E15 RID: 19989
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04004E16 RID: 19990
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004E17 RID: 19991
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004E18 RID: 19992
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004E19 RID: 19993
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004E1A RID: 19994
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004E1B RID: 19995
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004E1C RID: 19996
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004E1D RID: 19997
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000845 RID: 2117
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Skirmish.RiseOfIx.IntimidatingForceTrigger+<IsValidFor>d__7")]
		public sealed class _IsValidFor_d__7 : Object
		{
			// Token: 0x06007965 RID: 31077 RVA: 0x00226E78 File Offset: 0x00225078
			// Note: this type is marked as 'beforefieldinit'.
			static _IsValidFor_d__7()
			{
				Il2CppClassPointerStore<IntimidatingForceTrigger._IsValidFor_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IntimidatingForceTrigger>.NativeClassPtr, "<IsValidFor>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntimidatingForceTrigger._IsValidFor_d__7>.NativeClassPtr);
				IntimidatingForceTrigger._IsValidFor_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntimidatingForceTrigger._IsValidFor_d__7>.NativeClassPtr, "<>1__state");
				IntimidatingForceTrigger._IsValidFor_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntimidatingForceTrigger._IsValidFor_d__7>.NativeClassPtr, "<>2__current");
				IntimidatingForceTrigger._IsValidFor_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntimidatingForceTrigger._IsValidFor_d__7>.NativeClassPtr, "<>l__initialThreadId");
				IntimidatingForceTrigger._IsValidFor_d__7.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntimidatingForceTrigger._IsValidFor_d__7>.NativeClassPtr, "evt");
				IntimidatingForceTrigger._IsValidFor_d__7.NativeFieldInfoPtr___3__evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntimidatingForceTrigger._IsValidFor_d__7>.NativeClassPtr, "<>3__evt");
				IntimidatingForceTrigger._IsValidFor_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntimidatingForceTrigger._IsValidFor_d__7>.NativeClassPtr, "<>4__this");
				IntimidatingForceTrigger._IsValidFor_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntimidatingForceTrigger._IsValidFor_d__7>.NativeClassPtr, 100672214);
				IntimidatingForceTrigger._IsValidFor_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntimidatingForceTrigger._IsValidFor_d__7>.NativeClassPtr, 100672215);
				IntimidatingForceTrigger._IsValidFor_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntimidatingForceTrigger._IsValidFor_d__7>.NativeClassPtr, 100672216);
				IntimidatingForceTrigger._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntimidatingForceTrigger._IsValidFor_d__7>.NativeClassPtr, 100672217);
				IntimidatingForceTrigger._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntimidatingForceTrigger._IsValidFor_d__7>.NativeClassPtr, 100672218);
				IntimidatingForceTrigger._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntimidatingForceTrigger._IsValidFor_d__7>.NativeClassPtr, 100672219);
				IntimidatingForceTrigger._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntimidatingForceTrigger._IsValidFor_d__7>.NativeClassPtr, 100672220);
				IntimidatingForceTrigger._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntimidatingForceTrigger._IsValidFor_d__7>.NativeClassPtr, 100672221);
			}

			// Token: 0x06007966 RID: 31078 RVA: 0x00226FBC File Offset: 0x002251BC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _IsValidFor_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntimidatingForceTrigger._IsValidFor_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntimidatingForceTrigger._IsValidFor_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06007967 RID: 31079 RVA: 0x00227004 File Offset: 0x00225204
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntimidatingForceTrigger._IsValidFor_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007968 RID: 31080 RVA: 0x00227038 File Offset: 0x00225238
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181414, XrefRangeEnd = 181446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntimidatingForceTrigger._IsValidFor_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002202 RID: 8706
			// (get) Token: 0x06007969 RID: 31081 RVA: 0x00227074 File Offset: 0x00225274
			public unsafe PlayerEntity System.Collections.Generic.IEnumerator<Canis.entities.PlayerEntity>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntimidatingForceTrigger._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
				}
			}

			// Token: 0x0600796A RID: 31082 RVA: 0x002270B4 File Offset: 0x002252B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181446, XrefRangeEnd = 181451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntimidatingForceTrigger._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002203 RID: 8707
			// (get) Token: 0x0600796B RID: 31083 RVA: 0x002270E8 File Offset: 0x002252E8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntimidatingForceTrigger._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600796C RID: 31084 RVA: 0x00227128 File Offset: 0x00225328
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181451, XrefRangeEnd = 181460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<PlayerEntity> System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntimidatingForceTrigger._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayerEntity>>(intPtr3) : null;
			}

			// Token: 0x0600796D RID: 31085 RVA: 0x00227168 File Offset: 0x00225368
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntimidatingForceTrigger._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600796E RID: 31086 RVA: 0x00031617 File Offset: 0x0002F817
			public _IsValidFor_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170021FC RID: 8700
			// (get) Token: 0x0600796F RID: 31087 RVA: 0x002271A8 File Offset: 0x002253A8
			// (set) Token: 0x06007970 RID: 31088 RVA: 0x00031620 File Offset: 0x0002F820
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntimidatingForceTrigger._IsValidFor_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntimidatingForceTrigger._IsValidFor_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170021FD RID: 8701
			// (get) Token: 0x06007971 RID: 31089 RVA: 0x002271D0 File Offset: 0x002253D0
			// (set) Token: 0x06007972 RID: 31090 RVA: 0x0003163B File Offset: 0x0002F83B
			public unsafe PlayerEntity __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntimidatingForceTrigger._IsValidFor_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntimidatingForceTrigger._IsValidFor_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170021FE RID: 8702
			// (get) Token: 0x06007973 RID: 31091 RVA: 0x00227200 File Offset: 0x00225400
			// (set) Token: 0x06007974 RID: 31092 RVA: 0x0003165A File Offset: 0x0002F85A
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntimidatingForceTrigger._IsValidFor_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntimidatingForceTrigger._IsValidFor_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170021FF RID: 8703
			// (get) Token: 0x06007975 RID: 31093 RVA: 0x00227228 File Offset: 0x00225428
			// (set) Token: 0x06007976 RID: 31094 RVA: 0x00031675 File Offset: 0x0002F875
			public unsafe SerializableEvent evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntimidatingForceTrigger._IsValidFor_d__7.NativeFieldInfoPtr_evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntimidatingForceTrigger._IsValidFor_d__7.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002200 RID: 8704
			// (get) Token: 0x06007977 RID: 31095 RVA: 0x00227258 File Offset: 0x00225458
			// (set) Token: 0x06007978 RID: 31096 RVA: 0x00031694 File Offset: 0x0002F894
			public unsafe SerializableEvent __3__evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntimidatingForceTrigger._IsValidFor_d__7.NativeFieldInfoPtr___3__evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntimidatingForceTrigger._IsValidFor_d__7.NativeFieldInfoPtr___3__evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002201 RID: 8705
			// (get) Token: 0x06007979 RID: 31097 RVA: 0x00227288 File Offset: 0x00225488
			// (set) Token: 0x0600797A RID: 31098 RVA: 0x000316B3 File Offset: 0x0002F8B3
			public unsafe IntimidatingForceTrigger __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntimidatingForceTrigger._IsValidFor_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntimidatingForceTrigger>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntimidatingForceTrigger._IsValidFor_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004E1E RID: 19998
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004E1F RID: 19999
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004E20 RID: 20000
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004E21 RID: 20001
			private static readonly IntPtr NativeFieldInfoPtr_evt;

			// Token: 0x04004E22 RID: 20002
			private static readonly IntPtr NativeFieldInfoPtr___3__evt;

			// Token: 0x04004E23 RID: 20003
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004E24 RID: 20004
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004E25 RID: 20005
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004E26 RID: 20006
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004E27 RID: 20007
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0;

			// Token: 0x04004E28 RID: 20008
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004E29 RID: 20009
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004E2A RID: 20010
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0;

			// Token: 0x04004E2B RID: 20011
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
