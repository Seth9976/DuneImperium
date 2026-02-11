using System;
using Canis;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.events;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.abilities.TriggeredAbilities;
using worm.canis.data.enums;
using worm.canis.entities;

namespace worm.canis.abilities.PlayAbilities.RiseOfIx
{
	// Token: 0x0200044C RID: 1100
	public class CarefulObservationOppTriggeredAbility : TriggeredAbility
	{
		// Token: 0x06003016 RID: 12310 RVA: 0x00122A80 File Offset: 0x00120C80
		// Note: this type is marked as 'beforefieldinit'.
		static CarefulObservationOppTriggeredAbility()
		{
			Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.PlayAbilities.RiseOfIx", "CarefulObservationOppTriggeredAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility>.NativeClassPtr);
			CarefulObservationOppTriggeredAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility>.NativeClassPtr, "AbilityName");
			CarefulObservationOppTriggeredAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility>.NativeClassPtr, "AbilityID");
			CarefulObservationOppTriggeredAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility>.NativeClassPtr, 100677998);
			CarefulObservationOppTriggeredAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility>.NativeClassPtr, 100677999);
			CarefulObservationOppTriggeredAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility>.NativeClassPtr, 100678000);
			CarefulObservationOppTriggeredAbility.NativeMethodInfoPtr_GetPlayedFremenCards_Private_Il2CppReferenceArray_1_WormPlayable_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility>.NativeClassPtr, 100678001);
			CarefulObservationOppTriggeredAbility.NativeMethodInfoPtr_IsOpponentTurn_Private_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility>.NativeClassPtr, 100678002);
			CarefulObservationOppTriggeredAbility.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility>.NativeClassPtr, 100678003);
			CarefulObservationOppTriggeredAbility.NativeMethodInfoPtr_get_ShouldExhaust_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility>.NativeClassPtr, 100678004);
			CarefulObservationOppTriggeredAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility>.NativeClassPtr, 100678005);
			CarefulObservationOppTriggeredAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility>.NativeClassPtr, 100678006);
			CarefulObservationOppTriggeredAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility>.NativeClassPtr, 100678007);
			CarefulObservationOppTriggeredAbility.NativeMethodInfoPtr__GetPlayedFremenCards_b__5_0_Private_Boolean_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility>.NativeClassPtr, 100678009);
		}

		// Token: 0x06003017 RID: 12311 RVA: 0x00122BB4 File Offset: 0x00120DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222938, XrefRangeEnd = 222942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CarefulObservationOppTriggeredAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06003018 RID: 12312 RVA: 0x00122C00 File Offset: 0x00120E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222942, XrefRangeEnd = 222955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CarefulObservationOppTriggeredAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarefulObservationOppTriggeredAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003019 RID: 12313 RVA: 0x00122C4C File Offset: 0x00120E4C
		[CallerCount(314)]
		[CachedScanResults(RefRangeStart = 176275, RefRangeEnd = 176589, XrefRangeStart = 176275, XrefRangeEnd = 176589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CarefulObservationOppTriggeredAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarefulObservationOppTriggeredAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600301A RID: 12314 RVA: 0x00122CBC File Offset: 0x00120EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222955, XrefRangeEnd = 222975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<WormPlayable> GetPlayedFremenCards(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarefulObservationOppTriggeredAbility.NativeMethodInfoPtr_GetPlayedFremenCards_Private_Il2CppReferenceArray_1_WormPlayable_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WormPlayable>>(intPtr3) : null;
			}
		}

		// Token: 0x0600301B RID: 12315 RVA: 0x00122D0C File Offset: 0x00120F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222975, XrefRangeEnd = 222978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsOpponentTurn(WormPlayer gainingPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gainingPlayer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarefulObservationOppTriggeredAbility.NativeMethodInfoPtr_IsOpponentTurn_Private_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600301C RID: 12316 RVA: 0x00122D5C File Offset: 0x00120F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222978, XrefRangeEnd = 222985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<PlayerEntity> IsValidFor(SerializableEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CarefulObservationOppTriggeredAbility.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x0600301D RID: 12317 RVA: 0x00122DB8 File Offset: 0x00120FB8
		public unsafe override bool ShouldExhaust
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CarefulObservationOppTriggeredAbility.NativeMethodInfoPtr_get_ShouldExhaust_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600301E RID: 12318 RVA: 0x00122E00 File Offset: 0x00121000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222985, XrefRangeEnd = 222989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override CostAction Cost(Match match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CarefulObservationOppTriggeredAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x0600301F RID: 12319 RVA: 0x00122E70 File Offset: 0x00121070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222989, XrefRangeEnd = 222998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> BeginExecution(WormActiveAbility activeAbility, WormMatch match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CarefulObservationOppTriggeredAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06003020 RID: 12320 RVA: 0x00122EF0 File Offset: 0x001210F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222998, XrefRangeEnd = 223001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ResumeExecution(WormActiveAbility activeAbility, global::Canis.actions.Action returningAction, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CarefulObservationOppTriggeredAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003021 RID: 12321 RVA: 0x00122F6C File Offset: 0x0012116C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223001, XrefRangeEnd = 223003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetPlayedFremenCards_b__5_0(WormPlayable card)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarefulObservationOppTriggeredAbility.NativeMethodInfoPtr__GetPlayedFremenCards_b__5_0_Private_Boolean_WormPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003022 RID: 12322 RVA: 0x00011073 File Offset: 0x0000F273
		public CarefulObservationOppTriggeredAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x06003023 RID: 12323 RVA: 0x00122FBC File Offset: 0x001211BC
		// (set) Token: 0x06003024 RID: 12324 RVA: 0x0001107C File Offset: 0x0000F27C
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CarefulObservationOppTriggeredAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CarefulObservationOppTriggeredAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x06003025 RID: 12325 RVA: 0x00122FDC File Offset: 0x001211DC
		// (set) Token: 0x06003026 RID: 12326 RVA: 0x0001108E File Offset: 0x0000F28E
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CarefulObservationOppTriggeredAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CarefulObservationOppTriggeredAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F0B RID: 7947
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001F0C RID: 7948
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001F0D RID: 7949
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001F0E RID: 7950
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001F0F RID: 7951
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001F10 RID: 7952
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayedFremenCards_Private_Il2CppReferenceArray_1_WormPlayable_Context_0;

		// Token: 0x04001F11 RID: 7953
		private static readonly IntPtr NativeMethodInfoPtr_IsOpponentTurn_Private_Boolean_WormPlayer_0;

		// Token: 0x04001F12 RID: 7954
		private static readonly IntPtr NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0;

		// Token: 0x04001F13 RID: 7955
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldExhaust_Public_Virtual_get_Boolean_0;

		// Token: 0x04001F14 RID: 7956
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x04001F15 RID: 7957
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x04001F16 RID: 7958
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0;

		// Token: 0x04001F17 RID: 7959
		private static readonly IntPtr NativeMethodInfoPtr__GetPlayedFremenCards_b__5_0_Private_Boolean_WormPlayable_0;

		// Token: 0x02000A75 RID: 2677
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.RiseOfIx.CarefulObservationOppTriggeredAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600A79E RID: 42910 RVA: 0x002AEC3C File Offset: 0x002ACE3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility.__c>.NativeClassPtr);
				CarefulObservationOppTriggeredAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility.__c>.NativeClassPtr, "<>9");
				CarefulObservationOppTriggeredAbility.__c.NativeFieldInfoPtr___9__11_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility.__c>.NativeClassPtr, "<>9__11_1");
				CarefulObservationOppTriggeredAbility.__c.NativeFieldInfoPtr___9__11_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility.__c>.NativeClassPtr, "<>9__11_2");
				CarefulObservationOppTriggeredAbility.__c.NativeFieldInfoPtr___9__11_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility.__c>.NativeClassPtr, "<>9__11_3");
				CarefulObservationOppTriggeredAbility.__c.NativeFieldInfoPtr___9__11_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility.__c>.NativeClassPtr, "<>9__11_4");
				CarefulObservationOppTriggeredAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility.__c>.NativeClassPtr, 100678011);
				CarefulObservationOppTriggeredAbility.__c.NativeMethodInfoPtr__BeginExecution_b__11_1_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility.__c>.NativeClassPtr, 100678012);
				CarefulObservationOppTriggeredAbility.__c.NativeMethodInfoPtr__BeginExecution_b__11_2_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility.__c>.NativeClassPtr, 100678013);
				CarefulObservationOppTriggeredAbility.__c.NativeMethodInfoPtr__BeginExecution_b__11_3_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility.__c>.NativeClassPtr, 100678014);
				CarefulObservationOppTriggeredAbility.__c.NativeMethodInfoPtr__BeginExecution_b__11_4_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility.__c>.NativeClassPtr, 100678015);
			}

			// Token: 0x0600A79F RID: 42911 RVA: 0x002AED30 File Offset: 0x002ACF30
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarefulObservationOppTriggeredAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A7A0 RID: 42912 RVA: 0x002AED6C File Offset: 0x002ACF6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222630, XrefRangeEnd = 222631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginExecution_b__11_1(WormAbilityDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarefulObservationOppTriggeredAbility.__c.NativeMethodInfoPtr__BeginExecution_b__11_1_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600A7A1 RID: 42913 RVA: 0x002AEDBC File Offset: 0x002ACFBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222631, XrefRangeEnd = 222632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginExecution_b__11_2(WormAbilityDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarefulObservationOppTriggeredAbility.__c.NativeMethodInfoPtr__BeginExecution_b__11_2_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600A7A2 RID: 42914 RVA: 0x002AEE0C File Offset: 0x002AD00C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222632, XrefRangeEnd = 222633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginExecution_b__11_3(WormAbilityDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarefulObservationOppTriggeredAbility.__c.NativeMethodInfoPtr__BeginExecution_b__11_3_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600A7A3 RID: 42915 RVA: 0x002AEE5C File Offset: 0x002AD05C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222633, XrefRangeEnd = 222634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginExecution_b__11_4(WormAbilityDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarefulObservationOppTriggeredAbility.__c.NativeMethodInfoPtr__BeginExecution_b__11_4_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600A7A4 RID: 42916 RVA: 0x0004BD24 File Offset: 0x00049F24
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170032D3 RID: 13011
			// (get) Token: 0x0600A7A5 RID: 42917 RVA: 0x002AEEAC File Offset: 0x002AD0AC
			// (set) Token: 0x0600A7A6 RID: 42918 RVA: 0x0004BD2D File Offset: 0x00049F2D
			public unsafe static CarefulObservationOppTriggeredAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CarefulObservationOppTriggeredAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CarefulObservationOppTriggeredAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CarefulObservationOppTriggeredAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032D4 RID: 13012
			// (get) Token: 0x0600A7A7 RID: 42919 RVA: 0x002AEED4 File Offset: 0x002AD0D4
			// (set) Token: 0x0600A7A8 RID: 42920 RVA: 0x0004BD3F File Offset: 0x00049F3F
			public unsafe static Func<WormAbilityDefinition, bool> __9__11_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CarefulObservationOppTriggeredAbility.__c.NativeFieldInfoPtr___9__11_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CarefulObservationOppTriggeredAbility.__c.NativeFieldInfoPtr___9__11_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032D5 RID: 13013
			// (get) Token: 0x0600A7A9 RID: 42921 RVA: 0x002AEEFC File Offset: 0x002AD0FC
			// (set) Token: 0x0600A7AA RID: 42922 RVA: 0x0004BD51 File Offset: 0x00049F51
			public unsafe static Func<WormAbilityDefinition, bool> __9__11_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CarefulObservationOppTriggeredAbility.__c.NativeFieldInfoPtr___9__11_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CarefulObservationOppTriggeredAbility.__c.NativeFieldInfoPtr___9__11_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032D6 RID: 13014
			// (get) Token: 0x0600A7AB RID: 42923 RVA: 0x002AEF24 File Offset: 0x002AD124
			// (set) Token: 0x0600A7AC RID: 42924 RVA: 0x0004BD63 File Offset: 0x00049F63
			public unsafe static Func<WormAbilityDefinition, bool> __9__11_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CarefulObservationOppTriggeredAbility.__c.NativeFieldInfoPtr___9__11_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CarefulObservationOppTriggeredAbility.__c.NativeFieldInfoPtr___9__11_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032D7 RID: 13015
			// (get) Token: 0x0600A7AD RID: 42925 RVA: 0x002AEF4C File Offset: 0x002AD14C
			// (set) Token: 0x0600A7AE RID: 42926 RVA: 0x0004BD75 File Offset: 0x00049F75
			public unsafe static Func<WormAbilityDefinition, bool> __9__11_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CarefulObservationOppTriggeredAbility.__c.NativeFieldInfoPtr___9__11_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CarefulObservationOppTriggeredAbility.__c.NativeFieldInfoPtr___9__11_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006A1A RID: 27162
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006A1B RID: 27163
			private static readonly IntPtr NativeFieldInfoPtr___9__11_1;

			// Token: 0x04006A1C RID: 27164
			private static readonly IntPtr NativeFieldInfoPtr___9__11_2;

			// Token: 0x04006A1D RID: 27165
			private static readonly IntPtr NativeFieldInfoPtr___9__11_3;

			// Token: 0x04006A1E RID: 27166
			private static readonly IntPtr NativeFieldInfoPtr___9__11_4;

			// Token: 0x04006A1F RID: 27167
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006A20 RID: 27168
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__11_1_Internal_Boolean_WormAbilityDefinition_0;

			// Token: 0x04006A21 RID: 27169
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__11_2_Internal_Boolean_WormAbilityDefinition_0;

			// Token: 0x04006A22 RID: 27170
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__11_3_Internal_Boolean_WormAbilityDefinition_0;

			// Token: 0x04006A23 RID: 27171
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__11_4_Internal_Boolean_WormAbilityDefinition_0;
		}

		// Token: 0x02000A76 RID: 2678
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.RiseOfIx.CarefulObservationOppTriggeredAbility+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x0600A7AF RID: 42927 RVA: 0x002AEF74 File Offset: 0x002AD174
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility.__c__DisplayClass11_0>.NativeClassPtr);
				CarefulObservationOppTriggeredAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_forFaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility.__c__DisplayClass11_0>.NativeClassPtr, "forFaction");
				CarefulObservationOppTriggeredAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility.__c__DisplayClass11_0>.NativeClassPtr, 100678016);
				CarefulObservationOppTriggeredAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_Boolean_WormFactionTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility.__c__DisplayClass11_0>.NativeClassPtr, 100678017);
			}

			// Token: 0x0600A7B0 RID: 42928 RVA: 0x002AEFDC File Offset: 0x002AD1DC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarefulObservationOppTriggeredAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A7B1 RID: 42929 RVA: 0x002AF018 File Offset: 0x002AD218
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginExecution_b__0(WormFactionTrack _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarefulObservationOppTriggeredAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_Boolean_WormFactionTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600A7B2 RID: 42930 RVA: 0x0004BD87 File Offset: 0x00049F87
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170032D8 RID: 13016
			// (get) Token: 0x0600A7B3 RID: 42931 RVA: 0x002AF068 File Offset: 0x002AD268
			// (set) Token: 0x0600A7B4 RID: 42932 RVA: 0x0004BD90 File Offset: 0x00049F90
			public unsafe Factions forFaction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_forFaction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_forFaction)) = value;
				}
			}

			// Token: 0x04006A24 RID: 27172
			private static readonly IntPtr NativeFieldInfoPtr_forFaction;

			// Token: 0x04006A25 RID: 27173
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006A26 RID: 27174
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__0_Internal_Boolean_WormFactionTrack_0;
		}

		// Token: 0x02000A77 RID: 2679
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.RiseOfIx.CarefulObservationOppTriggeredAbility+<BeginExecution>d__11")]
		public sealed class _BeginExecution_d__11 : Object
		{
			// Token: 0x0600A7B5 RID: 42933 RVA: 0x002AF090 File Offset: 0x002AD290
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__11()
			{
				Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._BeginExecution_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility>.NativeClassPtr, "<BeginExecution>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._BeginExecution_d__11>.NativeClassPtr);
				CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._BeginExecution_d__11>.NativeClassPtr, "<>1__state");
				CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._BeginExecution_d__11>.NativeClassPtr, "<>2__current");
				CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._BeginExecution_d__11>.NativeClassPtr, "<>l__initialThreadId");
				CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._BeginExecution_d__11>.NativeClassPtr, "activeAbility");
				CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._BeginExecution_d__11>.NativeClassPtr, "<>3__activeAbility");
				CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._BeginExecution_d__11>.NativeClassPtr, "context");
				CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._BeginExecution_d__11>.NativeClassPtr, "<>3__context");
				CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._BeginExecution_d__11>.NativeClassPtr, "match");
				CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._BeginExecution_d__11>.NativeClassPtr, "<>3__match");
				CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._BeginExecution_d__11>.NativeClassPtr, "<>4__this");
				CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._BeginExecution_d__11>.NativeClassPtr, "<>8__1");
				CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._BeginExecution_d__11>.NativeClassPtr, "<player>5__2");
				CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr__wad_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._BeginExecution_d__11>.NativeClassPtr, "<wad>5__3");
				CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr__factionTrack_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._BeginExecution_d__11>.NativeClassPtr, "<factionTrack>5__4");
				CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._BeginExecution_d__11>.NativeClassPtr, 100678018);
				CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._BeginExecution_d__11>.NativeClassPtr, 100678019);
				CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._BeginExecution_d__11>.NativeClassPtr, 100678020);
				CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._BeginExecution_d__11>.NativeClassPtr, 100678021);
				CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._BeginExecution_d__11>.NativeClassPtr, 100678022);
				CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._BeginExecution_d__11>.NativeClassPtr, 100678023);
				CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._BeginExecution_d__11>.NativeClassPtr, 100678024);
				CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._BeginExecution_d__11>.NativeClassPtr, 100678025);
			}

			// Token: 0x0600A7B6 RID: 42934 RVA: 0x002AF274 File Offset: 0x002AD474
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._BeginExecution_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600A7B7 RID: 42935 RVA: 0x002AF2BC File Offset: 0x002AD4BC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A7B8 RID: 42936 RVA: 0x002AF2F0 File Offset: 0x002AD4F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222634, XrefRangeEnd = 222865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170032E7 RID: 13031
			// (get) Token: 0x0600A7B9 RID: 42937 RVA: 0x002AF32C File Offset: 0x002AD52C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600A7BA RID: 42938 RVA: 0x002AF36C File Offset: 0x002AD56C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222865, XrefRangeEnd = 222870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170032E8 RID: 13032
			// (get) Token: 0x0600A7BB RID: 42939 RVA: 0x002AF3A0 File Offset: 0x002AD5A0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A7BC RID: 42940 RVA: 0x002AF3E0 File Offset: 0x002AD5E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222870, XrefRangeEnd = 222881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600A7BD RID: 42941 RVA: 0x002AF420 File Offset: 0x002AD620
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600A7BE RID: 42942 RVA: 0x0004BDAB File Offset: 0x00049FAB
			public _BeginExecution_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170032D9 RID: 13017
			// (get) Token: 0x0600A7BF RID: 42943 RVA: 0x002AF460 File Offset: 0x002AD660
			// (set) Token: 0x0600A7C0 RID: 42944 RVA: 0x0004BDB4 File Offset: 0x00049FB4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170032DA RID: 13018
			// (get) Token: 0x0600A7C1 RID: 42945 RVA: 0x002AF488 File Offset: 0x002AD688
			// (set) Token: 0x0600A7C2 RID: 42946 RVA: 0x0004BDCF File Offset: 0x00049FCF
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032DB RID: 13019
			// (get) Token: 0x0600A7C3 RID: 42947 RVA: 0x002AF4B8 File Offset: 0x002AD6B8
			// (set) Token: 0x0600A7C4 RID: 42948 RVA: 0x0004BDEE File Offset: 0x00049FEE
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170032DC RID: 13020
			// (get) Token: 0x0600A7C5 RID: 42949 RVA: 0x002AF4E0 File Offset: 0x002AD6E0
			// (set) Token: 0x0600A7C6 RID: 42950 RVA: 0x0004BE09 File Offset: 0x0004A009
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032DD RID: 13021
			// (get) Token: 0x0600A7C7 RID: 42951 RVA: 0x002AF510 File Offset: 0x002AD710
			// (set) Token: 0x0600A7C8 RID: 42952 RVA: 0x0004BE28 File Offset: 0x0004A028
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032DE RID: 13022
			// (get) Token: 0x0600A7C9 RID: 42953 RVA: 0x002AF540 File Offset: 0x002AD740
			// (set) Token: 0x0600A7CA RID: 42954 RVA: 0x0004BE47 File Offset: 0x0004A047
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032DF RID: 13023
			// (get) Token: 0x0600A7CB RID: 42955 RVA: 0x002AF570 File Offset: 0x002AD770
			// (set) Token: 0x0600A7CC RID: 42956 RVA: 0x0004BE66 File Offset: 0x0004A066
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032E0 RID: 13024
			// (get) Token: 0x0600A7CD RID: 42957 RVA: 0x002AF5A0 File Offset: 0x002AD7A0
			// (set) Token: 0x0600A7CE RID: 42958 RVA: 0x0004BE85 File Offset: 0x0004A085
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032E1 RID: 13025
			// (get) Token: 0x0600A7CF RID: 42959 RVA: 0x002AF5D0 File Offset: 0x002AD7D0
			// (set) Token: 0x0600A7D0 RID: 42960 RVA: 0x0004BEA4 File Offset: 0x0004A0A4
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032E2 RID: 13026
			// (get) Token: 0x0600A7D1 RID: 42961 RVA: 0x002AF600 File Offset: 0x002AD800
			// (set) Token: 0x0600A7D2 RID: 42962 RVA: 0x0004BEC3 File Offset: 0x0004A0C3
			public unsafe CarefulObservationOppTriggeredAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CarefulObservationOppTriggeredAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032E3 RID: 13027
			// (get) Token: 0x0600A7D3 RID: 42963 RVA: 0x002AF630 File Offset: 0x002AD830
			// (set) Token: 0x0600A7D4 RID: 42964 RVA: 0x0004BEE2 File Offset: 0x0004A0E2
			public unsafe CarefulObservationOppTriggeredAbility.__c__DisplayClass11_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CarefulObservationOppTriggeredAbility.__c__DisplayClass11_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032E4 RID: 13028
			// (get) Token: 0x0600A7D5 RID: 42965 RVA: 0x002AF660 File Offset: 0x002AD860
			// (set) Token: 0x0600A7D6 RID: 42966 RVA: 0x0004BF01 File Offset: 0x0004A101
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032E5 RID: 13029
			// (get) Token: 0x0600A7D7 RID: 42967 RVA: 0x002AF690 File Offset: 0x002AD890
			// (set) Token: 0x0600A7D8 RID: 42968 RVA: 0x0004BF20 File Offset: 0x0004A120
			public unsafe WormAbilityDefinition _wad_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr__wad_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAbilityDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr__wad_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032E6 RID: 13030
			// (get) Token: 0x0600A7D9 RID: 42969 RVA: 0x002AF6C0 File Offset: 0x002AD8C0
			// (set) Token: 0x0600A7DA RID: 42970 RVA: 0x0004BF3F File Offset: 0x0004A13F
			public unsafe WormFactionTrack _factionTrack_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr__factionTrack_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormFactionTrack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._BeginExecution_d__11.NativeFieldInfoPtr__factionTrack_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006A27 RID: 27175
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006A28 RID: 27176
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006A29 RID: 27177
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04006A2A RID: 27178
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04006A2B RID: 27179
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04006A2C RID: 27180
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04006A2D RID: 27181
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x04006A2E RID: 27182
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04006A2F RID: 27183
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04006A30 RID: 27184
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006A31 RID: 27185
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04006A32 RID: 27186
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04006A33 RID: 27187
			private static readonly IntPtr NativeFieldInfoPtr__wad_5__3;

			// Token: 0x04006A34 RID: 27188
			private static readonly IntPtr NativeFieldInfoPtr__factionTrack_5__4;

			// Token: 0x04006A35 RID: 27189
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006A36 RID: 27190
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006A37 RID: 27191
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006A38 RID: 27192
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04006A39 RID: 27193
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006A3A RID: 27194
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006A3B RID: 27195
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04006A3C RID: 27196
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000A78 RID: 2680
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.RiseOfIx.CarefulObservationOppTriggeredAbility+<IsValidFor>d__7")]
		public sealed class _IsValidFor_d__7 : Object
		{
			// Token: 0x0600A7DB RID: 42971 RVA: 0x002AF6F0 File Offset: 0x002AD8F0
			// Note: this type is marked as 'beforefieldinit'.
			static _IsValidFor_d__7()
			{
				Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._IsValidFor_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility>.NativeClassPtr, "<IsValidFor>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._IsValidFor_d__7>.NativeClassPtr);
				CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._IsValidFor_d__7>.NativeClassPtr, "<>1__state");
				CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._IsValidFor_d__7>.NativeClassPtr, "<>2__current");
				CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._IsValidFor_d__7>.NativeClassPtr, "<>l__initialThreadId");
				CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._IsValidFor_d__7>.NativeClassPtr, "evt");
				CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeFieldInfoPtr___3__evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._IsValidFor_d__7>.NativeClassPtr, "<>3__evt");
				CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._IsValidFor_d__7>.NativeClassPtr, "<>4__this");
				CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._IsValidFor_d__7>.NativeClassPtr, 100678026);
				CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._IsValidFor_d__7>.NativeClassPtr, 100678027);
				CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._IsValidFor_d__7>.NativeClassPtr, 100678028);
				CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._IsValidFor_d__7>.NativeClassPtr, 100678029);
				CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._IsValidFor_d__7>.NativeClassPtr, 100678030);
				CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._IsValidFor_d__7>.NativeClassPtr, 100678031);
				CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._IsValidFor_d__7>.NativeClassPtr, 100678032);
				CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._IsValidFor_d__7>.NativeClassPtr, 100678033);
			}

			// Token: 0x0600A7DC RID: 42972 RVA: 0x002AF834 File Offset: 0x002ADA34
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _IsValidFor_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarefulObservationOppTriggeredAbility._IsValidFor_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600A7DD RID: 42973 RVA: 0x002AF87C File Offset: 0x002ADA7C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A7DE RID: 42974 RVA: 0x002AF8B0 File Offset: 0x002ADAB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222881, XrefRangeEnd = 222924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170032EF RID: 13039
			// (get) Token: 0x0600A7DF RID: 42975 RVA: 0x002AF8EC File Offset: 0x002ADAEC
			public unsafe PlayerEntity System.Collections.Generic.IEnumerator<Canis.entities.PlayerEntity>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
				}
			}

			// Token: 0x0600A7E0 RID: 42976 RVA: 0x002AF92C File Offset: 0x002ADB2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222924, XrefRangeEnd = 222929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170032F0 RID: 13040
			// (get) Token: 0x0600A7E1 RID: 42977 RVA: 0x002AF960 File Offset: 0x002ADB60
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A7E2 RID: 42978 RVA: 0x002AF9A0 File Offset: 0x002ADBA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222929, XrefRangeEnd = 222938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<PlayerEntity> System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayerEntity>>(intPtr3) : null;
			}

			// Token: 0x0600A7E3 RID: 42979 RVA: 0x002AF9E0 File Offset: 0x002ADBE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600A7E4 RID: 42980 RVA: 0x0004BF5E File Offset: 0x0004A15E
			public _IsValidFor_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170032E9 RID: 13033
			// (get) Token: 0x0600A7E5 RID: 42981 RVA: 0x002AFA20 File Offset: 0x002ADC20
			// (set) Token: 0x0600A7E6 RID: 42982 RVA: 0x0004BF67 File Offset: 0x0004A167
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170032EA RID: 13034
			// (get) Token: 0x0600A7E7 RID: 42983 RVA: 0x002AFA48 File Offset: 0x002ADC48
			// (set) Token: 0x0600A7E8 RID: 42984 RVA: 0x0004BF82 File Offset: 0x0004A182
			public unsafe PlayerEntity __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032EB RID: 13035
			// (get) Token: 0x0600A7E9 RID: 42985 RVA: 0x002AFA78 File Offset: 0x002ADC78
			// (set) Token: 0x0600A7EA RID: 42986 RVA: 0x0004BFA1 File Offset: 0x0004A1A1
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170032EC RID: 13036
			// (get) Token: 0x0600A7EB RID: 42987 RVA: 0x002AFAA0 File Offset: 0x002ADCA0
			// (set) Token: 0x0600A7EC RID: 42988 RVA: 0x0004BFBC File Offset: 0x0004A1BC
			public unsafe SerializableEvent evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeFieldInfoPtr_evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032ED RID: 13037
			// (get) Token: 0x0600A7ED RID: 42989 RVA: 0x002AFAD0 File Offset: 0x002ADCD0
			// (set) Token: 0x0600A7EE RID: 42990 RVA: 0x0004BFDB File Offset: 0x0004A1DB
			public unsafe SerializableEvent __3__evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeFieldInfoPtr___3__evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeFieldInfoPtr___3__evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032EE RID: 13038
			// (get) Token: 0x0600A7EF RID: 42991 RVA: 0x002AFB00 File Offset: 0x002ADD00
			// (set) Token: 0x0600A7F0 RID: 42992 RVA: 0x0004BFFA File Offset: 0x0004A1FA
			public unsafe CarefulObservationOppTriggeredAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CarefulObservationOppTriggeredAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarefulObservationOppTriggeredAbility._IsValidFor_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006A3D RID: 27197
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006A3E RID: 27198
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006A3F RID: 27199
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04006A40 RID: 27200
			private static readonly IntPtr NativeFieldInfoPtr_evt;

			// Token: 0x04006A41 RID: 27201
			private static readonly IntPtr NativeFieldInfoPtr___3__evt;

			// Token: 0x04006A42 RID: 27202
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006A43 RID: 27203
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006A44 RID: 27204
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006A45 RID: 27205
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006A46 RID: 27206
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0;

			// Token: 0x04006A47 RID: 27207
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006A48 RID: 27208
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006A49 RID: 27209
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0;

			// Token: 0x04006A4A RID: 27210
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
