using System;
using Canis;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.abilities.ActivatedAbilities.RiseOfIx
{
	// Token: 0x020004DD RID: 1245
	public class FreighterCustomAbility : FreighterAbility
	{
		// Token: 0x0600388D RID: 14477 RVA: 0x0014D7A0 File Offset: 0x0014B9A0
		// Note: this type is marked as 'beforefieldinit'.
		static FreighterCustomAbility()
		{
			Il2CppClassPointerStore<FreighterCustomAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.ActivatedAbilities.RiseOfIx", "FreighterCustomAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FreighterCustomAbility>.NativeClassPtr);
			FreighterCustomAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterCustomAbility>.NativeClassPtr, "AbilityName");
			FreighterCustomAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterCustomAbility>.NativeClassPtr, "AbilityID");
			FreighterCustomAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterCustomAbility>.NativeClassPtr, 100681396);
			FreighterCustomAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterCustomAbility>.NativeClassPtr, 100681397);
			FreighterCustomAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterCustomAbility>.NativeClassPtr, 100681398);
			FreighterCustomAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterCustomAbility>.NativeClassPtr, 100681399);
			FreighterCustomAbility.NativeMethodInfoPtr_IsUnexhausted_Protected_Virtual_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterCustomAbility>.NativeClassPtr, 100681400);
			FreighterCustomAbility.NativeMethodInfoPtr_CustomExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterCustomAbility>.NativeClassPtr, 100681401);
		}

		// Token: 0x0600388E RID: 14478 RVA: 0x0014D870 File Offset: 0x0014BA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252098, XrefRangeEnd = 252102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FreighterCustomAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x0600388F RID: 14479 RVA: 0x0014D8BC File Offset: 0x0014BABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252102, XrefRangeEnd = 252115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FreighterCustomAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FreighterCustomAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterCustomAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003890 RID: 14480 RVA: 0x0014D908 File Offset: 0x0014BB08
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FreighterCustomAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FreighterCustomAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterCustomAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003891 RID: 14481 RVA: 0x0014D978 File Offset: 0x0014BB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252115, XrefRangeEnd = 252119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FreighterCustomAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x06003892 RID: 14482 RVA: 0x0014D9E8 File Offset: 0x0014BBE8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsUnexhausted(PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FreighterCustomAbility.NativeMethodInfoPtr_IsUnexhausted_Protected_Virtual_Boolean_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003893 RID: 14483 RVA: 0x0014DA40 File Offset: 0x0014BC40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252119, XrefRangeEnd = 252127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> CustomExecution(WormActiveAbility activeAbility, WormMatch match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FreighterCustomAbility.NativeMethodInfoPtr_CustomExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06003894 RID: 14484 RVA: 0x00012C2B File Offset: 0x00010E2B
		public FreighterCustomAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x06003895 RID: 14485 RVA: 0x0014DAC0 File Offset: 0x0014BCC0
		// (set) Token: 0x06003896 RID: 14486 RVA: 0x00012C34 File Offset: 0x00010E34
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FreighterCustomAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FreighterCustomAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x06003897 RID: 14487 RVA: 0x0014DAE0 File Offset: 0x0014BCE0
		// (set) Token: 0x06003898 RID: 14488 RVA: 0x00012C46 File Offset: 0x00010E46
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FreighterCustomAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FreighterCustomAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400251B RID: 9499
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x0400251C RID: 9500
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x0400251D RID: 9501
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x0400251E RID: 9502
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x0400251F RID: 9503
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04002520 RID: 9504
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x04002521 RID: 9505
		private static readonly IntPtr NativeMethodInfoPtr_IsUnexhausted_Protected_Virtual_Boolean_PlayerEntity_0;

		// Token: 0x04002522 RID: 9506
		private static readonly IntPtr NativeMethodInfoPtr_CustomExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x02000BD2 RID: 3026
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.FreighterCustomAbility+<CustomExecution>d__7")]
		public sealed class _CustomExecution_d__7 : Object
		{
			// Token: 0x0600C1A4 RID: 49572 RVA: 0x002FA58C File Offset: 0x002F878C
			// Note: this type is marked as 'beforefieldinit'.
			static _CustomExecution_d__7()
			{
				Il2CppClassPointerStore<FreighterCustomAbility._CustomExecution_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FreighterCustomAbility>.NativeClassPtr, "<CustomExecution>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FreighterCustomAbility._CustomExecution_d__7>.NativeClassPtr);
				FreighterCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterCustomAbility._CustomExecution_d__7>.NativeClassPtr, "<>1__state");
				FreighterCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterCustomAbility._CustomExecution_d__7>.NativeClassPtr, "<>2__current");
				FreighterCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterCustomAbility._CustomExecution_d__7>.NativeClassPtr, "<>l__initialThreadId");
				FreighterCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterCustomAbility._CustomExecution_d__7>.NativeClassPtr, "activeAbility");
				FreighterCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterCustomAbility._CustomExecution_d__7>.NativeClassPtr, "<>3__activeAbility");
				FreighterCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterCustomAbility._CustomExecution_d__7>.NativeClassPtr, "<>4__this");
				FreighterCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterCustomAbility._CustomExecution_d__7>.NativeClassPtr, "match");
				FreighterCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterCustomAbility._CustomExecution_d__7>.NativeClassPtr, "<>3__match");
				FreighterCustomAbility._CustomExecution_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterCustomAbility._CustomExecution_d__7>.NativeClassPtr, 100681403);
				FreighterCustomAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterCustomAbility._CustomExecution_d__7>.NativeClassPtr, 100681404);
				FreighterCustomAbility._CustomExecution_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterCustomAbility._CustomExecution_d__7>.NativeClassPtr, 100681405);
				FreighterCustomAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterCustomAbility._CustomExecution_d__7>.NativeClassPtr, 100681406);
				FreighterCustomAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterCustomAbility._CustomExecution_d__7>.NativeClassPtr, 100681407);
				FreighterCustomAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterCustomAbility._CustomExecution_d__7>.NativeClassPtr, 100681408);
				FreighterCustomAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterCustomAbility._CustomExecution_d__7>.NativeClassPtr, 100681409);
				FreighterCustomAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterCustomAbility._CustomExecution_d__7>.NativeClassPtr, 100681410);
			}

			// Token: 0x0600C1A5 RID: 49573 RVA: 0x002FA6F8 File Offset: 0x002F88F8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CustomExecution_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FreighterCustomAbility._CustomExecution_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterCustomAbility._CustomExecution_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600C1A6 RID: 49574 RVA: 0x002FA740 File Offset: 0x002F8940
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterCustomAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1A7 RID: 49575 RVA: 0x002FA774 File Offset: 0x002F8974
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252065, XrefRangeEnd = 252083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterCustomAbility._CustomExecution_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003C24 RID: 15396
			// (get) Token: 0x0600C1A8 RID: 49576 RVA: 0x002FA7B0 File Offset: 0x002F89B0
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterCustomAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600C1A9 RID: 49577 RVA: 0x002FA7F0 File Offset: 0x002F89F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252083, XrefRangeEnd = 252088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterCustomAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003C25 RID: 15397
			// (get) Token: 0x0600C1AA RID: 49578 RVA: 0x002FA824 File Offset: 0x002F8A24
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterCustomAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C1AB RID: 49579 RVA: 0x002FA864 File Offset: 0x002F8A64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252088, XrefRangeEnd = 252098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterCustomAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600C1AC RID: 49580 RVA: 0x002FA8A4 File Offset: 0x002F8AA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterCustomAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C1AD RID: 49581 RVA: 0x0005AC94 File Offset: 0x00058E94
			public _CustomExecution_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003C1C RID: 15388
			// (get) Token: 0x0600C1AE RID: 49582 RVA: 0x002FA8E4 File Offset: 0x002F8AE4
			// (set) Token: 0x0600C1AF RID: 49583 RVA: 0x0005AC9D File Offset: 0x00058E9D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003C1D RID: 15389
			// (get) Token: 0x0600C1B0 RID: 49584 RVA: 0x002FA90C File Offset: 0x002F8B0C
			// (set) Token: 0x0600C1B1 RID: 49585 RVA: 0x0005ACB8 File Offset: 0x00058EB8
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C1E RID: 15390
			// (get) Token: 0x0600C1B2 RID: 49586 RVA: 0x002FA93C File Offset: 0x002F8B3C
			// (set) Token: 0x0600C1B3 RID: 49587 RVA: 0x0005ACD7 File Offset: 0x00058ED7
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003C1F RID: 15391
			// (get) Token: 0x0600C1B4 RID: 49588 RVA: 0x002FA964 File Offset: 0x002F8B64
			// (set) Token: 0x0600C1B5 RID: 49589 RVA: 0x0005ACF2 File Offset: 0x00058EF2
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C20 RID: 15392
			// (get) Token: 0x0600C1B6 RID: 49590 RVA: 0x002FA994 File Offset: 0x002F8B94
			// (set) Token: 0x0600C1B7 RID: 49591 RVA: 0x0005AD11 File Offset: 0x00058F11
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C21 RID: 15393
			// (get) Token: 0x0600C1B8 RID: 49592 RVA: 0x002FA9C4 File Offset: 0x002F8BC4
			// (set) Token: 0x0600C1B9 RID: 49593 RVA: 0x0005AD30 File Offset: 0x00058F30
			public unsafe FreighterCustomAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FreighterCustomAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C22 RID: 15394
			// (get) Token: 0x0600C1BA RID: 49594 RVA: 0x002FA9F4 File Offset: 0x002F8BF4
			// (set) Token: 0x0600C1BB RID: 49595 RVA: 0x0005AD4F File Offset: 0x00058F4F
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C23 RID: 15395
			// (get) Token: 0x0600C1BC RID: 49596 RVA: 0x002FAA24 File Offset: 0x002F8C24
			// (set) Token: 0x0600C1BD RID: 49597 RVA: 0x0005AD6E File Offset: 0x00058F6E
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007987 RID: 31111
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007988 RID: 31112
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007989 RID: 31113
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400798A RID: 31114
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x0400798B RID: 31115
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x0400798C RID: 31116
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400798D RID: 31117
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x0400798E RID: 31118
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x0400798F RID: 31119
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007990 RID: 31120
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007991 RID: 31121
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007992 RID: 31122
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04007993 RID: 31123
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007994 RID: 31124
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007995 RID: 31125
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04007996 RID: 31126
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
