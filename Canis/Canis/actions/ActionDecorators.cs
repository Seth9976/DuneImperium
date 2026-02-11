using System;
using System.Runtime.InteropServices;
using Canis.context;
using Canis.entities;
using Canis.events;
using Canis.json.events;
using Canis.messages;
using Canis.messages.effect;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Canis.actions
{
	// Token: 0x02000170 RID: 368
	public static class ActionDecorators : Object
	{
		// Token: 0x0600106E RID: 4206 RVA: 0x0005C088 File Offset: 0x0005A288
		// Note: this type is marked as 'beforefieldinit'.
		static ActionDecorators()
		{
			Il2CppClassPointerStore<ActionDecorators>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "ActionDecorators");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionDecorators>.NativeClassPtr);
			ActionDecorators.NativeMethodInfoPtr_AsAction_Public_Static_Action_IEnumerable_1_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionDecorators>.NativeClassPtr, 100666665);
			ActionDecorators.NativeMethodInfoPtr_AsSequence_Public_Static_Action_Il2CppReferenceArray_1_Action_String_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionDecorators>.NativeClassPtr, 100666666);
			ActionDecorators.NativeMethodInfoPtr_WithContext_Public_Static_TAct_TAct_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionDecorators>.NativeClassPtr, 100666667);
			ActionDecorators.NativeMethodInfoPtr_WithContext_Public_Static_TAct_TAct_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionDecorators>.NativeClassPtr, 100666668);
			ActionDecorators.NativeMethodInfoPtr_WithContext_Public_Static_TAct_TAct_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionDecorators>.NativeClassPtr, 100666669);
			ActionDecorators.NativeMethodInfoPtr_WrapInSequence_Public_Static_SequenceWrapper_1_TAct_TAct_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionDecorators>.NativeClassPtr, 100666670);
			ActionDecorators.NativeMethodInfoPtr_WithCost_Public_Static_Action_Action_CostAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionDecorators>.NativeClassPtr, 100666671);
			ActionDecorators.NativeMethodInfoPtr_Fire_Public_Static_Action_Event_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionDecorators>.NativeClassPtr, 100666672);
			ActionDecorators.NativeMethodInfoPtr_When_Public_Static_Action_Action_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionDecorators>.NativeClassPtr, 100666673);
			ActionDecorators.NativeMethodInfoPtr_Until_Public_Static_Action_Action_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionDecorators>.NativeClassPtr, 100666674);
			ActionDecorators.NativeMethodInfoPtr_WhenOnce_Public_Static_Action_Action_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionDecorators>.NativeClassPtr, 100666675);
			ActionDecorators.NativeMethodInfoPtr_Send_Public_Static_Action_NetworkMessageEvent_Match_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionDecorators>.NativeClassPtr, 100666676);
			ActionDecorators.NativeMethodInfoPtr_SendTo_Public_Static_Action_NetworkMessageEvent_Match_PlayerEntity_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionDecorators>.NativeClassPtr, 100666677);
			ActionDecorators.NativeMethodInfoPtr_SendTo_Public_Static_Action_NetworkMessageEvent_Context_Match_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionDecorators>.NativeClassPtr, 100666678);
			ActionDecorators.NativeMethodInfoPtr_Play_Public_Static_Action_EffectMessage_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionDecorators>.NativeClassPtr, 100666679);
			ActionDecorators.NativeMethodInfoPtr_PlayFor_Public_Static_IEnumerable_1_Action_EffectMessage_IEnumerable_1_PlayerEntity_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionDecorators>.NativeClassPtr, 100666680);
			ActionDecorators.NativeMethodInfoPtr_Emit_Public_Static_GameMessage_EffectMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionDecorators>.NativeClassPtr, 100666681);
			ActionDecorators.NativeMethodInfoPtr_Fire_Public_Static_Action_SerializableEvent_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionDecorators>.NativeClassPtr, 100666682);
			ActionDecorators.NativeMethodInfoPtr_WhenOnce_Public_Static_Action_Action_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionDecorators>.NativeClassPtr, 100666683);
			ActionDecorators.NativeMethodInfoPtr_Targeting_Public_Static_TargetPicker_Action_TargetPicker_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionDecorators>.NativeClassPtr, 100666684);
			ActionDecorators.NativeMethodInfoPtr_Targeting_Public_Static_TargetPicker_Action_Il2CppArrayBase_1_TEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionDecorators>.NativeClassPtr, 100666685);
			ActionDecorators.NativeMethodInfoPtr_Targeting_Public_Static_TargetPicker_Action_IEnumerable_1_TEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionDecorators>.NativeClassPtr, 100666686);
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x0005C270 File Offset: 0x0005A470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 580319, XrefRangeEnd = 580322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Action AsAction(this IEnumerable<Action> enumerable, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumerable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionDecorators.NativeMethodInfoPtr_AsAction_Public_Static_Action_IEnumerable_1_Action_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x0005C2C8 File Offset: 0x0005A4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 580322, XrefRangeEnd = 580326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Action AsSequence(this Il2CppReferenceArray<Action> actions, string sequenceName, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(actions);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sequenceName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionDecorators.NativeMethodInfoPtr_AsSequence_Public_Static_Action_Il2CppReferenceArray_1_Action_String_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x0005C330 File Offset: 0x0005A530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 580326, XrefRangeEnd = 580333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TAct WithContext<TAct>(this TAct action, Action act) where TAct : Action
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TAct).IsValueType)
				{
					TAct tact = action;
					intPtr = ((tact is string) ? IL2CPP.ManagedStringToIl2Cpp(tact as string) : IL2CPP.Il2CppObjectBaseToPtr(tact as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref action;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(act);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ActionDecorators.MethodInfoStoreGeneric_WithContext_Public_Static_TAct_TAct_Action_0<TAct>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<TAct>(intPtr2, false, true);
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x0005C3B8 File Offset: 0x0005A5B8
		[CallerCount(51)]
		[CachedScanResults(RefRangeStart = 580344, RefRangeEnd = 580395, XrefRangeStart = 580333, XrefRangeEnd = 580344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TAct WithContext<TAct>(this TAct action, Entity source) where TAct : Action
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TAct).IsValueType)
				{
					TAct tact = action;
					intPtr = ((tact is string) ? IL2CPP.ManagedStringToIl2Cpp(tact as string) : IL2CPP.Il2CppObjectBaseToPtr(tact as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref action;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ActionDecorators.MethodInfoStoreGeneric_WithContext_Public_Static_TAct_TAct_Entity_0<TAct>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<TAct>(intPtr2, false, true);
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x0005C440 File Offset: 0x0005A640
		[CallerCount(78)]
		[CachedScanResults(RefRangeStart = 580401, RefRangeEnd = 580479, XrefRangeStart = 580395, XrefRangeEnd = 580401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TAct WithContext<TAct>(this TAct action, Context newContext) where TAct : Action
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TAct).IsValueType)
				{
					TAct tact = action;
					intPtr = ((tact is string) ? IL2CPP.ManagedStringToIl2Cpp(tact as string) : IL2CPP.Il2CppObjectBaseToPtr(tact as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref action;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newContext);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ActionDecorators.MethodInfoStoreGeneric_WithContext_Public_Static_TAct_TAct_Context_0<TAct>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<TAct>(intPtr2, false, true);
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x0005C4C8 File Offset: 0x0005A6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 580479, XrefRangeEnd = 580483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SequenceWrapper<TAct> WrapInSequence<TAct>(this TAct action, string sequenceName) where TAct : Action
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TAct).IsValueType)
				{
					TAct tact = action;
					intPtr = ((tact is string) ? IL2CPP.ManagedStringToIl2Cpp(tact as string) : IL2CPP.Il2CppObjectBaseToPtr(tact as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref action;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sequenceName);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ActionDecorators.MethodInfoStoreGeneric_WrapInSequence_Public_Static_SequenceWrapper_1_TAct_TAct_String_0<TAct>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<SequenceWrapper<TAct>>(intPtr4) : null;
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x0005C554 File Offset: 0x0005A754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 580483, XrefRangeEnd = 580490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Action WithCost(this Action action, CostAction cost, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cost);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionDecorators.NativeMethodInfoPtr_WithCost_Public_Static_Action_Action_CostAction_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x0005C5BC File Offset: 0x0005A7BC
		[CallerCount(66)]
		[CachedScanResults(RefRangeStart = 580496, RefRangeEnd = 580562, XrefRangeStart = 580490, XrefRangeEnd = 580496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Action Fire(this Event evt, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionDecorators.NativeMethodInfoPtr_Fire_Public_Static_Action_Event_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x0005C614 File Offset: 0x0005A814
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 580569, RefRangeEnd = 580573, XrefRangeStart = 580562, XrefRangeEnd = 580569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Action When(this Action action, Event evt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionDecorators.NativeMethodInfoPtr_When_Public_Static_Action_Action_Event_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x0005C66C File Offset: 0x0005A86C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 580573, XrefRangeEnd = 580580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Action Until(this Action action, Event evt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionDecorators.NativeMethodInfoPtr_Until_Public_Static_Action_Action_Event_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x0005C6C4 File Offset: 0x0005A8C4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 580607, RefRangeEnd = 580617, XrefRangeStart = 580580, XrefRangeEnd = 580607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Action WhenOnce(this Action action, Event evt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionDecorators.NativeMethodInfoPtr_WhenOnce_Public_Static_Action_Action_Event_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x0005C71C File Offset: 0x0005A91C
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 580620, RefRangeEnd = 580647, XrefRangeStart = 580617, XrefRangeEnd = 580620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Action Send(this NetworkMessageEvent message, Match m, bool waitForResponse = true, bool sanitize = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref waitForResponse;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sanitize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionDecorators.NativeMethodInfoPtr_Send_Public_Static_Action_NetworkMessageEvent_Match_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x0005C790 File Offset: 0x0005A990
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 580654, RefRangeEnd = 580666, XrefRangeStart = 580647, XrefRangeEnd = 580654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Action SendTo(this NetworkMessageEvent message, Match m, PlayerEntity player, bool waitForResponse = true, bool sanitize = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref waitForResponse;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sanitize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionDecorators.NativeMethodInfoPtr_SendTo_Public_Static_Action_NetworkMessageEvent_Match_PlayerEntity_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x0005C814 File Offset: 0x0005AA14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 580666, XrefRangeEnd = 580673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Action SendTo(this NetworkMessageEvent message, Context context, Match m, bool waitForResponse = true, bool sanitize = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref waitForResponse;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sanitize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionDecorators.NativeMethodInfoPtr_SendTo_Public_Static_Action_NetworkMessageEvent_Context_Match_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x0005C898 File Offset: 0x0005AA98
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 580681, RefRangeEnd = 580720, XrefRangeStart = 580673, XrefRangeEnd = 580681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Action Play(this EffectMessage effect, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(effect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionDecorators.NativeMethodInfoPtr_Play_Public_Static_Action_EffectMessage_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x0005C8F0 File Offset: 0x0005AAF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 580736, RefRangeEnd = 580738, XrefRangeStart = 580720, XrefRangeEnd = 580736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Action> PlayFor(this EffectMessage effect, IEnumerable<PlayerEntity> players, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(effect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(players);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionDecorators.NativeMethodInfoPtr_PlayFor_Public_Static_IEnumerable_1_Action_EffectMessage_IEnumerable_1_PlayerEntity_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x0005C958 File Offset: 0x0005AB58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 580743, RefRangeEnd = 580744, XrefRangeStart = 580738, XrefRangeEnd = 580743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameMessage Emit(this EffectMessage effect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(effect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionDecorators.NativeMethodInfoPtr_Emit_Public_Static_GameMessage_EffectMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x0005C99C File Offset: 0x0005AB9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 580750, RefRangeEnd = 580751, XrefRangeStart = 580744, XrefRangeEnd = 580750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Action Fire(this SerializableEvent evt, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionDecorators.NativeMethodInfoPtr_Fire_Public_Static_Action_SerializableEvent_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x0005C9F4 File Offset: 0x0005ABF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 580751, XrefRangeEnd = 580766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Action WhenOnce(this Action action, SerializableEvent evt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionDecorators.NativeMethodInfoPtr_WhenOnce_Public_Static_Action_Action_SerializableEvent_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x0005CA4C File Offset: 0x0005AC4C
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 580769, RefRangeEnd = 580791, XrefRangeStart = 580766, XrefRangeEnd = 580769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TargetPicker Targeting<T>(this Action action, TargetPicker<T> picker)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(picker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionDecorators.MethodInfoStoreGeneric_Targeting_Public_Static_TargetPicker_Action_TargetPicker_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetPicker>(intPtr3) : null;
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x0005CAA4 File Offset: 0x0005ACA4
		[CallerCount(1391)]
		[CachedScanResults(RefRangeStart = 580797, RefRangeEnd = 582188, XrefRangeStart = 580791, XrefRangeEnd = 580797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TargetPicker Targeting<TEntity>(this Action action, [Optional] Il2CppArrayBase<TEntity> targets) where TEntity : Entity
		{
			if (targets == null)
			{
				targets = new Il2CppReferenceArray<TEntity>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targets);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionDecorators.MethodInfoStoreGeneric_Targeting_Public_Static_TargetPicker_Action_Il2CppArrayBase_1_TEntity_0<TEntity>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetPicker>(intPtr3) : null;
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x0005CB08 File Offset: 0x0005AD08
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 582194, RefRangeEnd = 582202, XrefRangeStart = 582188, XrefRangeEnd = 582194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TargetPicker Targeting<TEntity>(this Action action, IEnumerable<TEntity> targets) where TEntity : Entity
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targets);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionDecorators.MethodInfoStoreGeneric_Targeting_Public_Static_TargetPicker_Action_IEnumerable_1_TEntity_0<TEntity>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetPicker>(intPtr3) : null;
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x000084F7 File Offset: 0x000066F7
		public ActionDecorators(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AD6 RID: 2774
		private static readonly IntPtr NativeMethodInfoPtr_AsAction_Public_Static_Action_IEnumerable_1_Action_Match_0;

		// Token: 0x04000AD7 RID: 2775
		private static readonly IntPtr NativeMethodInfoPtr_AsSequence_Public_Static_Action_Il2CppReferenceArray_1_Action_String_Match_0;

		// Token: 0x04000AD8 RID: 2776
		private static readonly IntPtr NativeMethodInfoPtr_WithContext_Public_Static_TAct_TAct_Action_0;

		// Token: 0x04000AD9 RID: 2777
		private static readonly IntPtr NativeMethodInfoPtr_WithContext_Public_Static_TAct_TAct_Entity_0;

		// Token: 0x04000ADA RID: 2778
		private static readonly IntPtr NativeMethodInfoPtr_WithContext_Public_Static_TAct_TAct_Context_0;

		// Token: 0x04000ADB RID: 2779
		private static readonly IntPtr NativeMethodInfoPtr_WrapInSequence_Public_Static_SequenceWrapper_1_TAct_TAct_String_0;

		// Token: 0x04000ADC RID: 2780
		private static readonly IntPtr NativeMethodInfoPtr_WithCost_Public_Static_Action_Action_CostAction_Match_0;

		// Token: 0x04000ADD RID: 2781
		private static readonly IntPtr NativeMethodInfoPtr_Fire_Public_Static_Action_Event_Match_0;

		// Token: 0x04000ADE RID: 2782
		private static readonly IntPtr NativeMethodInfoPtr_When_Public_Static_Action_Action_Event_0;

		// Token: 0x04000ADF RID: 2783
		private static readonly IntPtr NativeMethodInfoPtr_Until_Public_Static_Action_Action_Event_0;

		// Token: 0x04000AE0 RID: 2784
		private static readonly IntPtr NativeMethodInfoPtr_WhenOnce_Public_Static_Action_Action_Event_0;

		// Token: 0x04000AE1 RID: 2785
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Static_Action_NetworkMessageEvent_Match_Boolean_Boolean_0;

		// Token: 0x04000AE2 RID: 2786
		private static readonly IntPtr NativeMethodInfoPtr_SendTo_Public_Static_Action_NetworkMessageEvent_Match_PlayerEntity_Boolean_Boolean_0;

		// Token: 0x04000AE3 RID: 2787
		private static readonly IntPtr NativeMethodInfoPtr_SendTo_Public_Static_Action_NetworkMessageEvent_Context_Match_Boolean_Boolean_0;

		// Token: 0x04000AE4 RID: 2788
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_Action_EffectMessage_Match_0;

		// Token: 0x04000AE5 RID: 2789
		private static readonly IntPtr NativeMethodInfoPtr_PlayFor_Public_Static_IEnumerable_1_Action_EffectMessage_IEnumerable_1_PlayerEntity_Match_0;

		// Token: 0x04000AE6 RID: 2790
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Public_Static_GameMessage_EffectMessage_0;

		// Token: 0x04000AE7 RID: 2791
		private static readonly IntPtr NativeMethodInfoPtr_Fire_Public_Static_Action_SerializableEvent_Match_0;

		// Token: 0x04000AE8 RID: 2792
		private static readonly IntPtr NativeMethodInfoPtr_WhenOnce_Public_Static_Action_Action_SerializableEvent_0;

		// Token: 0x04000AE9 RID: 2793
		private static readonly IntPtr NativeMethodInfoPtr_Targeting_Public_Static_TargetPicker_Action_TargetPicker_1_T_0;

		// Token: 0x04000AEA RID: 2794
		private static readonly IntPtr NativeMethodInfoPtr_Targeting_Public_Static_TargetPicker_Action_Il2CppArrayBase_1_TEntity_0;

		// Token: 0x04000AEB RID: 2795
		private static readonly IntPtr NativeMethodInfoPtr_Targeting_Public_Static_TargetPicker_Action_IEnumerable_1_TEntity_0;

		// Token: 0x020003A8 RID: 936
		[ObfuscatedName("Canis.actions.ActionDecorators+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Object
		{
			// Token: 0x06002754 RID: 10068 RVA: 0x000AC0DC File Offset: 0x000AA2DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<ActionDecorators.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActionDecorators>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionDecorators.__c__DisplayClass15_0>.NativeClassPtr);
				ActionDecorators.__c__DisplayClass15_0.NativeFieldInfoPtr_effect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionDecorators.__c__DisplayClass15_0>.NativeClassPtr, "effect");
				ActionDecorators.__c__DisplayClass15_0.NativeFieldInfoPtr_m = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionDecorators.__c__DisplayClass15_0>.NativeClassPtr, "m");
				ActionDecorators.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionDecorators.__c__DisplayClass15_0>.NativeClassPtr, 100666687);
				ActionDecorators.__c__DisplayClass15_0.NativeMethodInfoPtr__PlayFor_b__0_Internal_Action_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionDecorators.__c__DisplayClass15_0>.NativeClassPtr, 100666688);
			}

			// Token: 0x06002755 RID: 10069 RVA: 0x000AC158 File Offset: 0x000AA358
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionDecorators.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionDecorators.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002756 RID: 10070 RVA: 0x000AC194 File Offset: 0x000AA394
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 580307, XrefRangeEnd = 580319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Action _PlayFor_b__0(PlayerEntity p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionDecorators.__c__DisplayClass15_0.NativeMethodInfoPtr__PlayFor_b__0_Internal_Action_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002757 RID: 10071 RVA: 0x00012D5D File Offset: 0x00010F5D
			public __c__DisplayClass15_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009C9 RID: 2505
			// (get) Token: 0x06002758 RID: 10072 RVA: 0x000AC1E4 File Offset: 0x000AA3E4
			// (set) Token: 0x06002759 RID: 10073 RVA: 0x00012D66 File Offset: 0x00010F66
			public unsafe EffectMessage effect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionDecorators.__c__DisplayClass15_0.NativeFieldInfoPtr_effect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EffectMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionDecorators.__c__DisplayClass15_0.NativeFieldInfoPtr_effect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009CA RID: 2506
			// (get) Token: 0x0600275A RID: 10074 RVA: 0x000AC214 File Offset: 0x000AA414
			// (set) Token: 0x0600275B RID: 10075 RVA: 0x00012D85 File Offset: 0x00010F85
			public unsafe Match m
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionDecorators.__c__DisplayClass15_0.NativeFieldInfoPtr_m);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionDecorators.__c__DisplayClass15_0.NativeFieldInfoPtr_m), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001889 RID: 6281
			private static readonly IntPtr NativeFieldInfoPtr_effect;

			// Token: 0x0400188A RID: 6282
			private static readonly IntPtr NativeFieldInfoPtr_m;

			// Token: 0x0400188B RID: 6283
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400188C RID: 6284
			private static readonly IntPtr NativeMethodInfoPtr__PlayFor_b__0_Internal_Action_PlayerEntity_0;
		}

		// Token: 0x020003A9 RID: 937
		private sealed class MethodInfoStoreGeneric_WithContext_Public_Static_TAct_TAct_Action_0<TAct>
		{
			// Token: 0x0400188D RID: 6285
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ActionDecorators.NativeMethodInfoPtr_WithContext_Public_Static_TAct_TAct_Action_0, Il2CppClassPointerStore<ActionDecorators>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAct>.NativeClassPtr)) }))));
		}

		// Token: 0x020003AA RID: 938
		private sealed class MethodInfoStoreGeneric_WithContext_Public_Static_TAct_TAct_Entity_0<TAct>
		{
			// Token: 0x0400188E RID: 6286
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ActionDecorators.NativeMethodInfoPtr_WithContext_Public_Static_TAct_TAct_Entity_0, Il2CppClassPointerStore<ActionDecorators>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAct>.NativeClassPtr)) }))));
		}

		// Token: 0x020003AB RID: 939
		private sealed class MethodInfoStoreGeneric_WithContext_Public_Static_TAct_TAct_Context_0<TAct>
		{
			// Token: 0x0400188F RID: 6287
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ActionDecorators.NativeMethodInfoPtr_WithContext_Public_Static_TAct_TAct_Context_0, Il2CppClassPointerStore<ActionDecorators>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAct>.NativeClassPtr)) }))));
		}

		// Token: 0x020003AC RID: 940
		private sealed class MethodInfoStoreGeneric_WrapInSequence_Public_Static_SequenceWrapper_1_TAct_TAct_String_0<TAct>
		{
			// Token: 0x04001890 RID: 6288
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ActionDecorators.NativeMethodInfoPtr_WrapInSequence_Public_Static_SequenceWrapper_1_TAct_TAct_String_0, Il2CppClassPointerStore<ActionDecorators>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAct>.NativeClassPtr)) }))));
		}

		// Token: 0x020003AD RID: 941
		private sealed class MethodInfoStoreGeneric_Targeting_Public_Static_TargetPicker_Action_TargetPicker_1_T_0<T>
		{
			// Token: 0x04001891 RID: 6289
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ActionDecorators.NativeMethodInfoPtr_Targeting_Public_Static_TargetPicker_Action_TargetPicker_1_T_0, Il2CppClassPointerStore<ActionDecorators>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003AE RID: 942
		private sealed class MethodInfoStoreGeneric_Targeting_Public_Static_TargetPicker_Action_Il2CppArrayBase_1_TEntity_0<TEntity>
		{
			// Token: 0x04001892 RID: 6290
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ActionDecorators.NativeMethodInfoPtr_Targeting_Public_Static_TargetPicker_Action_Il2CppArrayBase_1_TEntity_0, Il2CppClassPointerStore<ActionDecorators>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEntity>.NativeClassPtr)) }))));
		}

		// Token: 0x020003AF RID: 943
		private sealed class MethodInfoStoreGeneric_Targeting_Public_Static_TargetPicker_Action_IEnumerable_1_TEntity_0<TEntity>
		{
			// Token: 0x04001893 RID: 6291
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ActionDecorators.NativeMethodInfoPtr_Targeting_Public_Static_TargetPicker_Action_IEnumerable_1_TEntity_0, Il2CppClassPointerStore<ActionDecorators>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEntity>.NativeClassPtr)) }))));
		}
	}
}
