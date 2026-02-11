using System;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.events;
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
	// Token: 0x020003AA RID: 938
	public class ResearchAssignmentEndOfRoundTrigger : RuleModAbility
	{
		// Token: 0x06002730 RID: 10032 RVA: 0x000F780C File Offset: 0x000F5A0C
		// Note: this type is marked as 'beforefieldinit'.
		static ResearchAssignmentEndOfRoundTrigger()
		{
			Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.Challenge.Immortality", "ResearchAssignmentEndOfRoundTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger>.NativeClassPtr);
			ResearchAssignmentEndOfRoundTrigger.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger>.NativeClassPtr, "AbilityName");
			ResearchAssignmentEndOfRoundTrigger.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger>.NativeClassPtr, "AbilityID");
			ResearchAssignmentEndOfRoundTrigger.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger>.NativeClassPtr, 100674500);
			ResearchAssignmentEndOfRoundTrigger.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger>.NativeClassPtr, 100674501);
			ResearchAssignmentEndOfRoundTrigger.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger>.NativeClassPtr, 100674502);
			ResearchAssignmentEndOfRoundTrigger.NativeMethodInfoPtr_get_ShouldExhaust_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger>.NativeClassPtr, 100674503);
			ResearchAssignmentEndOfRoundTrigger.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger>.NativeClassPtr, 100674504);
			ResearchAssignmentEndOfRoundTrigger.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger>.NativeClassPtr, 100674505);
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x000F78DC File Offset: 0x000F5ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195512, XrefRangeEnd = 195516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResearchAssignmentEndOfRoundTrigger.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x000F7928 File Offset: 0x000F5B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195516, XrefRangeEnd = 195519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResearchAssignmentEndOfRoundTrigger(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentEndOfRoundTrigger.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x000F7974 File Offset: 0x000F5B74
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResearchAssignmentEndOfRoundTrigger(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentEndOfRoundTrigger.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06002734 RID: 10036 RVA: 0x000F79E4 File Offset: 0x000F5BE4
		public unsafe override bool ShouldExhaust
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResearchAssignmentEndOfRoundTrigger.NativeMethodInfoPtr_get_ShouldExhaust_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x000F7A2C File Offset: 0x000F5C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195519, XrefRangeEnd = 195532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<PlayerEntity> IsValidFor(SerializableEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResearchAssignmentEndOfRoundTrigger.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x06002736 RID: 10038 RVA: 0x000F7A88 File Offset: 0x000F5C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195532, XrefRangeEnd = 195539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResearchAssignmentEndOfRoundTrigger.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06002737 RID: 10039 RVA: 0x0000EE9E File Offset: 0x0000D09E
		public ResearchAssignmentEndOfRoundTrigger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06002738 RID: 10040 RVA: 0x000F7B08 File Offset: 0x000F5D08
		// (set) Token: 0x06002739 RID: 10041 RVA: 0x0000EEA7 File Offset: 0x0000D0A7
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResearchAssignmentEndOfRoundTrigger.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResearchAssignmentEndOfRoundTrigger.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x0600273A RID: 10042 RVA: 0x000F7B28 File Offset: 0x000F5D28
		// (set) Token: 0x0600273B RID: 10043 RVA: 0x0000EEB9 File Offset: 0x0000D0B9
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResearchAssignmentEndOfRoundTrigger.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResearchAssignmentEndOfRoundTrigger.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001908 RID: 6408
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001909 RID: 6409
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x0400190A RID: 6410
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x0400190B RID: 6411
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x0400190C RID: 6412
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x0400190D RID: 6413
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldExhaust_Public_Virtual_get_Boolean_0;

		// Token: 0x0400190E RID: 6414
		private static readonly IntPtr NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0;

		// Token: 0x0400190F RID: 6415
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x02000930 RID: 2352
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.Immortality.ResearchAssignmentEndOfRoundTrigger+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06008C96 RID: 35990 RVA: 0x0025F8C8 File Offset: 0x0025DAC8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger.__c>.NativeClassPtr);
				ResearchAssignmentEndOfRoundTrigger.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger.__c>.NativeClassPtr, "<>9");
				ResearchAssignmentEndOfRoundTrigger.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger.__c>.NativeClassPtr, "<>9__7_0");
				ResearchAssignmentEndOfRoundTrigger.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger.__c>.NativeClassPtr, 100674508);
				ResearchAssignmentEndOfRoundTrigger.__c.NativeMethodInfoPtr__IsValidFor_b__7_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger.__c>.NativeClassPtr, 100674509);
			}

			// Token: 0x06008C97 RID: 35991 RVA: 0x0025F944 File Offset: 0x0025DB44
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentEndOfRoundTrigger.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C98 RID: 35992 RVA: 0x0025F980 File Offset: 0x0025DB80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsValidFor_b__7_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentEndOfRoundTrigger.__c.NativeMethodInfoPtr__IsValidFor_b__7_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06008C99 RID: 35993 RVA: 0x0003C326 File Offset: 0x0003A526
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170028F4 RID: 10484
			// (get) Token: 0x06008C9A RID: 35994 RVA: 0x0025F9D0 File Offset: 0x0025DBD0
			// (set) Token: 0x06008C9B RID: 35995 RVA: 0x0003C32F File Offset: 0x0003A52F
			public unsafe static ResearchAssignmentEndOfRoundTrigger.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResearchAssignmentEndOfRoundTrigger.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResearchAssignmentEndOfRoundTrigger.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResearchAssignmentEndOfRoundTrigger.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170028F5 RID: 10485
			// (get) Token: 0x06008C9C RID: 35996 RVA: 0x0025F9F8 File Offset: 0x0025DBF8
			// (set) Token: 0x06008C9D RID: 35997 RVA: 0x0003C341 File Offset: 0x0003A541
			public unsafe static Func<WormPlayer, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResearchAssignmentEndOfRoundTrigger.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResearchAssignmentEndOfRoundTrigger.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040059C9 RID: 22985
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040059CA RID: 22986
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x040059CB RID: 22987
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040059CC RID: 22988
			private static readonly IntPtr NativeMethodInfoPtr__IsValidFor_b__7_0_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x02000931 RID: 2353
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.Immortality.ResearchAssignmentEndOfRoundTrigger+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x06008C9E RID: 35998 RVA: 0x0025FA20 File Offset: 0x0025DC20
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger.__c__DisplayClass8_0>.NativeClassPtr);
				ResearchAssignmentEndOfRoundTrigger.__c__DisplayClass8_0.NativeFieldInfoPtr_abilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger.__c__DisplayClass8_0>.NativeClassPtr, "abilityID");
				ResearchAssignmentEndOfRoundTrigger.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger.__c__DisplayClass8_0>.NativeClassPtr, 100674510);
				ResearchAssignmentEndOfRoundTrigger.__c__DisplayClass8_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger.__c__DisplayClass8_0>.NativeClassPtr, 100674511);
			}

			// Token: 0x06008C9F RID: 35999 RVA: 0x0025FA88 File Offset: 0x0025DC88
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentEndOfRoundTrigger.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008CA0 RID: 36000 RVA: 0x0025FAC4 File Offset: 0x0025DCC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195191, XrefRangeEnd = 195308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginExecution_b__0(WormAbilityDefinition a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentEndOfRoundTrigger.__c__DisplayClass8_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06008CA1 RID: 36001 RVA: 0x0003C353 File Offset: 0x0003A553
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170028F6 RID: 10486
			// (get) Token: 0x06008CA2 RID: 36002 RVA: 0x0025FB14 File Offset: 0x0025DD14
			// (set) Token: 0x06008CA3 RID: 36003 RVA: 0x0003C35C File Offset: 0x0003A55C
			public unsafe AbilityID abilityID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentEndOfRoundTrigger.__c__DisplayClass8_0.NativeFieldInfoPtr_abilityID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentEndOfRoundTrigger.__c__DisplayClass8_0.NativeFieldInfoPtr_abilityID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040059CD RID: 22989
			private static readonly IntPtr NativeFieldInfoPtr_abilityID;

			// Token: 0x040059CE RID: 22990
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040059CF RID: 22991
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__0_Internal_Boolean_WormAbilityDefinition_0;
		}

		// Token: 0x02000932 RID: 2354
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.Immortality.ResearchAssignmentEndOfRoundTrigger+<BeginExecution>d__8")]
		public sealed class _BeginExecution_d__8 : Object
		{
			// Token: 0x06008CA4 RID: 36004 RVA: 0x0025FB44 File Offset: 0x0025DD44
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__8()
			{
				Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger>.NativeClassPtr, "<BeginExecution>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8>.NativeClassPtr);
				ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8>.NativeClassPtr, "<>1__state");
				ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8>.NativeClassPtr, "<>2__current");
				ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8>.NativeClassPtr, "<>l__initialThreadId");
				ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8>.NativeClassPtr, "activeAbility");
				ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8>.NativeClassPtr, "<>3__activeAbility");
				ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8>.NativeClassPtr, "match");
				ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8>.NativeClassPtr, "<>3__match");
				ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8>.NativeClassPtr, "<player>5__2");
				ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr__card_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8>.NativeClassPtr, "<card>5__3");
				ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr__wormCard_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8>.NativeClassPtr, "<wormCard>5__4");
				ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8>.NativeClassPtr, "<>7__wrap4");
				ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8>.NativeClassPtr, 100674512);
				ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8>.NativeClassPtr, 100674513);
				ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8>.NativeClassPtr, 100674514);
				ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8>.NativeClassPtr, 100674515);
				ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8>.NativeClassPtr, 100674516);
				ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8>.NativeClassPtr, 100674517);
				ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8>.NativeClassPtr, 100674518);
				ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8>.NativeClassPtr, 100674519);
				ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8>.NativeClassPtr, 100674520);
			}

			// Token: 0x06008CA5 RID: 36005 RVA: 0x0025FD00 File Offset: 0x0025DF00
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06008CA6 RID: 36006 RVA: 0x0025FD48 File Offset: 0x0025DF48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195308, XrefRangeEnd = 195313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008CA7 RID: 36007 RVA: 0x0025FD7C File Offset: 0x0025DF7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195313, XrefRangeEnd = 195494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008CA8 RID: 36008 RVA: 0x0025FDB8 File Offset: 0x0025DFB8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 195497, RefRangeEnd = 195498, XrefRangeStart = 195494, XrefRangeEnd = 195497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002902 RID: 10498
			// (get) Token: 0x06008CA9 RID: 36009 RVA: 0x0025FDEC File Offset: 0x0025DFEC
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06008CAA RID: 36010 RVA: 0x0025FE2C File Offset: 0x0025E02C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195498, XrefRangeEnd = 195503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002903 RID: 10499
			// (get) Token: 0x06008CAB RID: 36011 RVA: 0x0025FE60 File Offset: 0x0025E060
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008CAC RID: 36012 RVA: 0x0025FEA0 File Offset: 0x0025E0A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195503, XrefRangeEnd = 195512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06008CAD RID: 36013 RVA: 0x0025FEE0 File Offset: 0x0025E0E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06008CAE RID: 36014 RVA: 0x0003C37B File Offset: 0x0003A57B
			public _BeginExecution_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170028F7 RID: 10487
			// (get) Token: 0x06008CAF RID: 36015 RVA: 0x0025FF20 File Offset: 0x0025E120
			// (set) Token: 0x06008CB0 RID: 36016 RVA: 0x0003C384 File Offset: 0x0003A584
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170028F8 RID: 10488
			// (get) Token: 0x06008CB1 RID: 36017 RVA: 0x0025FF48 File Offset: 0x0025E148
			// (set) Token: 0x06008CB2 RID: 36018 RVA: 0x0003C39F File Offset: 0x0003A59F
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170028F9 RID: 10489
			// (get) Token: 0x06008CB3 RID: 36019 RVA: 0x0025FF78 File Offset: 0x0025E178
			// (set) Token: 0x06008CB4 RID: 36020 RVA: 0x0003C3BE File Offset: 0x0003A5BE
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170028FA RID: 10490
			// (get) Token: 0x06008CB5 RID: 36021 RVA: 0x0025FFA0 File Offset: 0x0025E1A0
			// (set) Token: 0x06008CB6 RID: 36022 RVA: 0x0003C3D9 File Offset: 0x0003A5D9
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170028FB RID: 10491
			// (get) Token: 0x06008CB7 RID: 36023 RVA: 0x0025FFD0 File Offset: 0x0025E1D0
			// (set) Token: 0x06008CB8 RID: 36024 RVA: 0x0003C3F8 File Offset: 0x0003A5F8
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170028FC RID: 10492
			// (get) Token: 0x06008CB9 RID: 36025 RVA: 0x00260000 File Offset: 0x0025E200
			// (set) Token: 0x06008CBA RID: 36026 RVA: 0x0003C417 File Offset: 0x0003A617
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170028FD RID: 10493
			// (get) Token: 0x06008CBB RID: 36027 RVA: 0x00260030 File Offset: 0x0025E230
			// (set) Token: 0x06008CBC RID: 36028 RVA: 0x0003C436 File Offset: 0x0003A636
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170028FE RID: 10494
			// (get) Token: 0x06008CBD RID: 36029 RVA: 0x00260060 File Offset: 0x0025E260
			// (set) Token: 0x06008CBE RID: 36030 RVA: 0x0003C455 File Offset: 0x0003A655
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170028FF RID: 10495
			// (get) Token: 0x06008CBF RID: 36031 RVA: 0x00260090 File Offset: 0x0025E290
			// (set) Token: 0x06008CC0 RID: 36032 RVA: 0x0003C474 File Offset: 0x0003A674
			public unsafe Entity _card_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr__card_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr__card_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002900 RID: 10496
			// (get) Token: 0x06008CC1 RID: 36033 RVA: 0x002600C0 File Offset: 0x0025E2C0
			// (set) Token: 0x06008CC2 RID: 36034 RVA: 0x0003C493 File Offset: 0x0003A693
			public unsafe WormImperiumPlayable _wormCard_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr__wormCard_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr__wormCard_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002901 RID: 10497
			// (get) Token: 0x06008CC3 RID: 36035 RVA: 0x002600F0 File Offset: 0x0025E2F0
			// (set) Token: 0x06008CC4 RID: 36036 RVA: 0x0003C4B2 File Offset: 0x0003A6B2
			public List<AbilityID>.Enumerator __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___7__wrap4);
					return new List<AbilityID>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<AbilityID>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResearchAssignmentEndOfRoundTrigger._BeginExecution_d__8.NativeFieldInfoPtr___7__wrap4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<AbilityID>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040059D0 RID: 22992
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040059D1 RID: 22993
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040059D2 RID: 22994
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040059D3 RID: 22995
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x040059D4 RID: 22996
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x040059D5 RID: 22997
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040059D6 RID: 22998
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x040059D7 RID: 22999
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x040059D8 RID: 23000
			private static readonly IntPtr NativeFieldInfoPtr__card_5__3;

			// Token: 0x040059D9 RID: 23001
			private static readonly IntPtr NativeFieldInfoPtr__wormCard_5__4;

			// Token: 0x040059DA RID: 23002
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x040059DB RID: 23003
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040059DC RID: 23004
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040059DD RID: 23005
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040059DE RID: 23006
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040059DF RID: 23007
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040059E0 RID: 23008
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040059E1 RID: 23009
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040059E2 RID: 23010
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040059E3 RID: 23011
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
