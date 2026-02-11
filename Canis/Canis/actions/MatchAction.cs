using System;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions
{
	// Token: 0x020001B4 RID: 436
	public class MatchAction<TMatch, TPlayer> : StateMachineAction<MatchStates> where TMatch : Match where TPlayer : PlayerEntity
	{
		// Token: 0x06001286 RID: 4742 RVA: 0x000644B8 File Offset: 0x000626B8
		// Note: this type is marked as 'beforefieldinit'.
		static MatchAction()
		{
			Il2CppClassPointerStore<MatchAction<TMatch, TPlayer>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "MatchAction`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlayer>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchAction<TMatch, TPlayer>>.NativeClassPtr);
			MatchAction<TMatch, TPlayer>.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchAction<TMatch, TPlayer>>.NativeClassPtr, "match");
			MatchAction<TMatch, TPlayer>.NativeFieldInfoPtr_currentPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchAction<TMatch, TPlayer>>.NativeClassPtr, "currentPlayer");
			MatchAction<TMatch, TPlayer>.NativeFieldInfoPtr_scenarioAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchAction<TMatch, TPlayer>>.NativeClassPtr, "scenarioAction");
			MatchAction<TMatch, TPlayer>.NativeMethodInfoPtr_get_ShouldExecuteOnForcedEnd_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchAction<TMatch, TPlayer>>.NativeClassPtr, 100667270);
			MatchAction<TMatch, TPlayer>.NativeMethodInfoPtr__ctor_Public_Void_Match_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchAction<TMatch, TPlayer>>.NativeClassPtr, 100667271);
			MatchAction<TMatch, TPlayer>.NativeMethodInfoPtr_InitializeFromSerialized_Public_Virtual_Void_SerializedStateMachineAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchAction<TMatch, TPlayer>>.NativeClassPtr, 100667272);
			MatchAction<TMatch, TPlayer>.NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_MatchStates_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchAction<TMatch, TPlayer>>.NativeClassPtr, 100667273);
			MatchAction<TMatch, TPlayer>.NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_MatchStates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchAction<TMatch, TPlayer>>.NativeClassPtr, 100667274);
			MatchAction<TMatch, TPlayer>.NativeMethodInfoPtr_Initialize_Protected_Abstract_Virtual_New_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchAction<TMatch, TPlayer>>.NativeClassPtr, 100667275);
			MatchAction<TMatch, TPlayer>.NativeMethodInfoPtr_GameSetup_Protected_Abstract_Virtual_New_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchAction<TMatch, TPlayer>>.NativeClassPtr, 100667276);
			MatchAction<TMatch, TPlayer>.NativeMethodInfoPtr_GameTurn_Protected_Abstract_Virtual_New_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchAction<TMatch, TPlayer>>.NativeClassPtr, 100667277);
			MatchAction<TMatch, TPlayer>.NativeMethodInfoPtr_GameTurnOver_Protected_Abstract_Virtual_New_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchAction<TMatch, TPlayer>>.NativeClassPtr, 100667278);
			MatchAction<TMatch, TPlayer>.NativeMethodInfoPtr_GameOver_Protected_Abstract_Virtual_New_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchAction<TMatch, TPlayer>>.NativeClassPtr, 100667279);
			MatchAction<TMatch, TPlayer>.NativeMethodInfoPtr_MatchOver_Protected_Abstract_Virtual_New_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchAction<TMatch, TPlayer>>.NativeClassPtr, 100667280);
			MatchAction<TMatch, TPlayer>.NativeMethodInfoPtr_MakeSerializedMatchAction_Protected_Abstract_Virtual_New_SerializedMatchAction_2_TMatch_TPlayer_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchAction<TMatch, TPlayer>>.NativeClassPtr, 100667281);
			MatchAction<TMatch, TPlayer>.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_Final_SerializedStateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchAction<TMatch, TPlayer>>.NativeClassPtr, 100667282);
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06001287 RID: 4743 RVA: 0x00064678 File Offset: 0x00062878
		public unsafe virtual bool ShouldExecuteOnForcedEnd
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchAction<TMatch, TPlayer>.NativeMethodInfoPtr_get_ShouldExecuteOnForcedEnd_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x000646B4 File Offset: 0x000628B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 585524, RefRangeEnd = 585526, XrefRangeStart = 585509, XrefRangeEnd = 585524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchAction(Match m, Action scenarioAction)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchAction<TMatch, TPlayer>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scenarioAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchAction<TMatch, TPlayer>.NativeMethodInfoPtr__ctor_Public_Void_Match_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x00064714 File Offset: 0x00062914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585526, XrefRangeEnd = 585538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeFromSerialized(SerializedStateMachineAction serialized)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchAction<TMatch, TPlayer>.NativeMethodInfoPtr_InitializeFromSerialized_Public_Virtual_Void_SerializedStateMachineAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x00064764 File Offset: 0x00062964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585538, XrefRangeEnd = 585542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Nullable<MatchStates> DetermineNextTypedState(Action lastAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchAction<TMatch, TPlayer>.NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_MatchStates_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<MatchStates>(intPtr);
			}
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x000647B8 File Offset: 0x000629B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585542, XrefRangeEnd = 585546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StateMachineAction.StateBehavior TypedBehaviorFor(MatchStates state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchAction<TMatch, TPlayer>.NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_MatchStates_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineAction.StateBehavior>(intPtr3) : null;
			}
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x00064810 File Offset: 0x00062A10
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Action> Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchAction<TMatch, TPlayer>.NativeMethodInfoPtr_Initialize_Protected_Abstract_Virtual_New_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x0006485C File Offset: 0x00062A5C
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Action> GameSetup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchAction<TMatch, TPlayer>.NativeMethodInfoPtr_GameSetup_Protected_Abstract_Virtual_New_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x000648A8 File Offset: 0x00062AA8
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Action> GameTurn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchAction<TMatch, TPlayer>.NativeMethodInfoPtr_GameTurn_Protected_Abstract_Virtual_New_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x000648F4 File Offset: 0x00062AF4
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Action> GameTurnOver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchAction<TMatch, TPlayer>.NativeMethodInfoPtr_GameTurnOver_Protected_Abstract_Virtual_New_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x00064940 File Offset: 0x00062B40
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Action> GameOver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchAction<TMatch, TPlayer>.NativeMethodInfoPtr_GameOver_Protected_Abstract_Virtual_New_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x0006498C File Offset: 0x00062B8C
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Action> MatchOver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchAction<TMatch, TPlayer>.NativeMethodInfoPtr_MatchOver_Protected_Abstract_Virtual_New_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x000649D8 File Offset: 0x00062BD8
		[CallerCount(0)]
		public unsafe virtual SerializedMatchAction<TMatch, TPlayer> MakeSerializedMatchAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchAction<TMatch, TPlayer>.NativeMethodInfoPtr_MakeSerializedMatchAction_Protected_Abstract_Virtual_New_SerializedMatchAction_2_TMatch_TPlayer_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedMatchAction<TMatch, TPlayer>>(intPtr3) : null;
			}
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x00064A34 File Offset: 0x00062C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585546, XrefRangeEnd = 585547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedStateMachineAction MakeSerializedStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchAction<TMatch, TPlayer>.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_Final_SerializedStateMachineAction_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedStateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x00009206 File Offset: 0x00007406
		public MatchAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06001295 RID: 4757 RVA: 0x00064A84 File Offset: 0x00062C84
		// (set) Token: 0x06001296 RID: 4758 RVA: 0x00064AAC File Offset: 0x00062CAC
		public unsafe TMatch match
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchAction<TMatch, TPlayer>.NativeFieldInfoPtr_match);
				return IL2CPP.PointerToValueGeneric<TMatch>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchAction<TMatch, TPlayer>.NativeFieldInfoPtr_match);
				Type typeFromHandle = typeof(TMatch);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06001297 RID: 4759 RVA: 0x00064B54 File Offset: 0x00062D54
		// (set) Token: 0x06001298 RID: 4760 RVA: 0x00064B7C File Offset: 0x00062D7C
		public unsafe TPlayer currentPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchAction<TMatch, TPlayer>.NativeFieldInfoPtr_currentPlayer);
				return IL2CPP.PointerToValueGeneric<TPlayer>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchAction<TMatch, TPlayer>.NativeFieldInfoPtr_currentPlayer);
				Type typeFromHandle = typeof(TPlayer);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06001299 RID: 4761 RVA: 0x00064C24 File Offset: 0x00062E24
		// (set) Token: 0x0600129A RID: 4762 RVA: 0x0000920F File Offset: 0x0000740F
		public unsafe Action scenarioAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchAction<TMatch, TPlayer>.NativeFieldInfoPtr_scenarioAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchAction<TMatch, TPlayer>.NativeFieldInfoPtr_scenarioAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C15 RID: 3093
		private static readonly IntPtr NativeFieldInfoPtr_match;

		// Token: 0x04000C16 RID: 3094
		private static readonly IntPtr NativeFieldInfoPtr_currentPlayer;

		// Token: 0x04000C17 RID: 3095
		private static readonly IntPtr NativeFieldInfoPtr_scenarioAction;

		// Token: 0x04000C18 RID: 3096
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldExecuteOnForcedEnd_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000C19 RID: 3097
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_Action_0;

		// Token: 0x04000C1A RID: 3098
		private static readonly IntPtr NativeMethodInfoPtr_InitializeFromSerialized_Public_Virtual_Void_SerializedStateMachineAction_0;

		// Token: 0x04000C1B RID: 3099
		private static readonly IntPtr NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_MatchStates_Action_0;

		// Token: 0x04000C1C RID: 3100
		private static readonly IntPtr NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_MatchStates_0;

		// Token: 0x04000C1D RID: 3101
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Abstract_Virtual_New_IEnumerable_1_Action_0;

		// Token: 0x04000C1E RID: 3102
		private static readonly IntPtr NativeMethodInfoPtr_GameSetup_Protected_Abstract_Virtual_New_IEnumerable_1_Action_0;

		// Token: 0x04000C1F RID: 3103
		private static readonly IntPtr NativeMethodInfoPtr_GameTurn_Protected_Abstract_Virtual_New_IEnumerable_1_Action_0;

		// Token: 0x04000C20 RID: 3104
		private static readonly IntPtr NativeMethodInfoPtr_GameTurnOver_Protected_Abstract_Virtual_New_IEnumerable_1_Action_0;

		// Token: 0x04000C21 RID: 3105
		private static readonly IntPtr NativeMethodInfoPtr_GameOver_Protected_Abstract_Virtual_New_IEnumerable_1_Action_0;

		// Token: 0x04000C22 RID: 3106
		private static readonly IntPtr NativeMethodInfoPtr_MatchOver_Protected_Abstract_Virtual_New_IEnumerable_1_Action_0;

		// Token: 0x04000C23 RID: 3107
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedMatchAction_Protected_Abstract_Virtual_New_SerializedMatchAction_2_TMatch_TPlayer_Match_0;

		// Token: 0x04000C24 RID: 3108
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_Final_SerializedStateMachineAction_Match_0;
	}
}
