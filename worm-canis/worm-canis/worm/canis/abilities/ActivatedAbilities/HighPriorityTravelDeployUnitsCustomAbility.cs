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

namespace worm.canis.abilities.ActivatedAbilities
{
	// Token: 0x020004AA RID: 1194
	public class HighPriorityTravelDeployUnitsCustomAbility : DeployUnitsAbility
	{
		// Token: 0x06003596 RID: 13718 RVA: 0x0013E668 File Offset: 0x0013C868
		// Note: this type is marked as 'beforefieldinit'.
		static HighPriorityTravelDeployUnitsCustomAbility()
		{
			Il2CppClassPointerStore<HighPriorityTravelDeployUnitsCustomAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.ActivatedAbilities", "HighPriorityTravelDeployUnitsCustomAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HighPriorityTravelDeployUnitsCustomAbility>.NativeClassPtr);
			HighPriorityTravelDeployUnitsCustomAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HighPriorityTravelDeployUnitsCustomAbility>.NativeClassPtr, "AbilityName");
			HighPriorityTravelDeployUnitsCustomAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HighPriorityTravelDeployUnitsCustomAbility>.NativeClassPtr, "AbilityID");
			HighPriorityTravelDeployUnitsCustomAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighPriorityTravelDeployUnitsCustomAbility>.NativeClassPtr, 100680248);
			HighPriorityTravelDeployUnitsCustomAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighPriorityTravelDeployUnitsCustomAbility>.NativeClassPtr, 100680249);
			HighPriorityTravelDeployUnitsCustomAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighPriorityTravelDeployUnitsCustomAbility>.NativeClassPtr, 100680250);
			HighPriorityTravelDeployUnitsCustomAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighPriorityTravelDeployUnitsCustomAbility>.NativeClassPtr, 100680251);
			HighPriorityTravelDeployUnitsCustomAbility.NativeMethodInfoPtr_IsUnexhausted_Protected_Virtual_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighPriorityTravelDeployUnitsCustomAbility>.NativeClassPtr, 100680252);
			HighPriorityTravelDeployUnitsCustomAbility.NativeMethodInfoPtr_CustomExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighPriorityTravelDeployUnitsCustomAbility>.NativeClassPtr, 100680253);
		}

		// Token: 0x06003597 RID: 13719 RVA: 0x0013E738 File Offset: 0x0013C938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242667, XrefRangeEnd = 242671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HighPriorityTravelDeployUnitsCustomAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06003598 RID: 13720 RVA: 0x0013E784 File Offset: 0x0013C984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242671, XrefRangeEnd = 242677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HighPriorityTravelDeployUnitsCustomAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HighPriorityTravelDeployUnitsCustomAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighPriorityTravelDeployUnitsCustomAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003599 RID: 13721 RVA: 0x0013E7D0 File Offset: 0x0013C9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242677, XrefRangeEnd = 242681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HighPriorityTravelDeployUnitsCustomAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HighPriorityTravelDeployUnitsCustomAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighPriorityTravelDeployUnitsCustomAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600359A RID: 13722 RVA: 0x0013E840 File Offset: 0x0013CA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242681, XrefRangeEnd = 242689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HighPriorityTravelDeployUnitsCustomAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x0600359B RID: 13723 RVA: 0x0013E8B0 File Offset: 0x0013CAB0
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HighPriorityTravelDeployUnitsCustomAbility.NativeMethodInfoPtr_IsUnexhausted_Protected_Virtual_Boolean_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600359C RID: 13724 RVA: 0x0013E908 File Offset: 0x0013CB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242689, XrefRangeEnd = 242697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HighPriorityTravelDeployUnitsCustomAbility.NativeMethodInfoPtr_CustomExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600359D RID: 13725 RVA: 0x000122D2 File Offset: 0x000104D2
		public HighPriorityTravelDeployUnitsCustomAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x0600359E RID: 13726 RVA: 0x0013E988 File Offset: 0x0013CB88
		// (set) Token: 0x0600359F RID: 13727 RVA: 0x000122DB File Offset: 0x000104DB
		public new unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HighPriorityTravelDeployUnitsCustomAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HighPriorityTravelDeployUnitsCustomAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x060035A0 RID: 13728 RVA: 0x0013E9A8 File Offset: 0x0013CBA8
		// (set) Token: 0x060035A1 RID: 13729 RVA: 0x000122ED File Offset: 0x000104ED
		public new unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HighPriorityTravelDeployUnitsCustomAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HighPriorityTravelDeployUnitsCustomAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040022F9 RID: 8953
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x040022FA RID: 8954
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x040022FB RID: 8955
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x040022FC RID: 8956
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x040022FD RID: 8957
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x040022FE RID: 8958
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x040022FF RID: 8959
		private static readonly IntPtr NativeMethodInfoPtr_IsUnexhausted_Protected_Virtual_Boolean_PlayerEntity_0;

		// Token: 0x04002300 RID: 8960
		private static readonly IntPtr NativeMethodInfoPtr_CustomExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x02000B65 RID: 2917
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.HighPriorityTravelDeployUnitsCustomAbility+<CustomExecution>d__7")]
		public sealed class _CustomExecution_d__7 : Object
		{
			// Token: 0x0600B909 RID: 47369 RVA: 0x002E175C File Offset: 0x002DF95C
			// Note: this type is marked as 'beforefieldinit'.
			static _CustomExecution_d__7()
			{
				Il2CppClassPointerStore<HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HighPriorityTravelDeployUnitsCustomAbility>.NativeClassPtr, "<CustomExecution>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7>.NativeClassPtr);
				HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7>.NativeClassPtr, "<>1__state");
				HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7>.NativeClassPtr, "<>2__current");
				HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7>.NativeClassPtr, "<>l__initialThreadId");
				HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7>.NativeClassPtr, "activeAbility");
				HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7>.NativeClassPtr, "<>3__activeAbility");
				HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7>.NativeClassPtr, "<>4__this");
				HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7>.NativeClassPtr, "match");
				HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7>.NativeClassPtr, "<>3__match");
				HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7>.NativeClassPtr, 100680255);
				HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7>.NativeClassPtr, 100680256);
				HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7>.NativeClassPtr, 100680257);
				HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7>.NativeClassPtr, 100680258);
				HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7>.NativeClassPtr, 100680259);
				HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7>.NativeClassPtr, 100680260);
				HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7>.NativeClassPtr, 100680261);
				HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7>.NativeClassPtr, 100680262);
			}

			// Token: 0x0600B90A RID: 47370 RVA: 0x002E18C8 File Offset: 0x002DFAC8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CustomExecution_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600B90B RID: 47371 RVA: 0x002E1910 File Offset: 0x002DFB10
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B90C RID: 47372 RVA: 0x002E1944 File Offset: 0x002DFB44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242634, XrefRangeEnd = 242652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003902 RID: 14594
			// (get) Token: 0x0600B90D RID: 47373 RVA: 0x002E1980 File Offset: 0x002DFB80
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600B90E RID: 47374 RVA: 0x002E19C0 File Offset: 0x002DFBC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242652, XrefRangeEnd = 242657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003903 RID: 14595
			// (get) Token: 0x0600B90F RID: 47375 RVA: 0x002E19F4 File Offset: 0x002DFBF4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B910 RID: 47376 RVA: 0x002E1A34 File Offset: 0x002DFC34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242657, XrefRangeEnd = 242667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600B911 RID: 47377 RVA: 0x002E1A74 File Offset: 0x002DFC74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600B912 RID: 47378 RVA: 0x00055C04 File Offset: 0x00053E04
			public _CustomExecution_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170038FA RID: 14586
			// (get) Token: 0x0600B913 RID: 47379 RVA: 0x002E1AB4 File Offset: 0x002DFCB4
			// (set) Token: 0x0600B914 RID: 47380 RVA: 0x00055C0D File Offset: 0x00053E0D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170038FB RID: 14587
			// (get) Token: 0x0600B915 RID: 47381 RVA: 0x002E1ADC File Offset: 0x002DFCDC
			// (set) Token: 0x0600B916 RID: 47382 RVA: 0x00055C28 File Offset: 0x00053E28
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038FC RID: 14588
			// (get) Token: 0x0600B917 RID: 47383 RVA: 0x002E1B0C File Offset: 0x002DFD0C
			// (set) Token: 0x0600B918 RID: 47384 RVA: 0x00055C47 File Offset: 0x00053E47
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170038FD RID: 14589
			// (get) Token: 0x0600B919 RID: 47385 RVA: 0x002E1B34 File Offset: 0x002DFD34
			// (set) Token: 0x0600B91A RID: 47386 RVA: 0x00055C62 File Offset: 0x00053E62
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038FE RID: 14590
			// (get) Token: 0x0600B91B RID: 47387 RVA: 0x002E1B64 File Offset: 0x002DFD64
			// (set) Token: 0x0600B91C RID: 47388 RVA: 0x00055C81 File Offset: 0x00053E81
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038FF RID: 14591
			// (get) Token: 0x0600B91D RID: 47389 RVA: 0x002E1B94 File Offset: 0x002DFD94
			// (set) Token: 0x0600B91E RID: 47390 RVA: 0x00055CA0 File Offset: 0x00053EA0
			public unsafe HighPriorityTravelDeployUnitsCustomAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HighPriorityTravelDeployUnitsCustomAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003900 RID: 14592
			// (get) Token: 0x0600B91F RID: 47391 RVA: 0x002E1BC4 File Offset: 0x002DFDC4
			// (set) Token: 0x0600B920 RID: 47392 RVA: 0x00055CBF File Offset: 0x00053EBF
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003901 RID: 14593
			// (get) Token: 0x0600B921 RID: 47393 RVA: 0x002E1BF4 File Offset: 0x002DFDF4
			// (set) Token: 0x0600B922 RID: 47394 RVA: 0x00055CDE File Offset: 0x00053EDE
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HighPriorityTravelDeployUnitsCustomAbility._CustomExecution_d__7.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400746A RID: 29802
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400746B RID: 29803
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400746C RID: 29804
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400746D RID: 29805
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x0400746E RID: 29806
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x0400746F RID: 29807
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007470 RID: 29808
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04007471 RID: 29809
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04007472 RID: 29810
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007473 RID: 29811
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007474 RID: 29812
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007475 RID: 29813
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04007476 RID: 29814
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007477 RID: 29815
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007478 RID: 29816
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04007479 RID: 29817
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
