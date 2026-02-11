using System;
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

namespace Canis.triggers
{
	// Token: 0x02000043 RID: 67
	public class TriggerDefinition : Entity
	{
		// Token: 0x06000444 RID: 1092 RVA: 0x0002A7E0 File Offset: 0x000289E0
		// Note: this type is marked as 'beforefieldinit'.
		static TriggerDefinition()
		{
			Il2CppClassPointerStore<TriggerDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.triggers", "TriggerDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriggerDefinition>.NativeClassPtr);
			TriggerDefinition.NativeFieldInfoPtr_trigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerDefinition>.NativeClassPtr, "trigger");
			TriggerDefinition.NativeMethodInfoPtr__ctor_Public_Void_Match_String_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition>.NativeClassPtr, 100664182);
			TriggerDefinition.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition>.NativeClassPtr, 100664183);
			TriggerDefinition.NativeMethodInfoPtr_InitializeTrigger_Public_Virtual_New_Void_Trigger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition>.NativeClassPtr, 100664184);
			TriggerDefinition.NativeMethodInfoPtr_AbilityTriggered_Public_Virtual_New_IEnumerable_1_Action_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition>.NativeClassPtr, 100664185);
			TriggerDefinition.NativeMethodInfoPtr_Trigger_Public_Virtual_New_IEnumerable_1_Action_Int32_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition>.NativeClassPtr, 100664186);
			TriggerDefinition.NativeMethodInfoPtr_Cost_Public_Abstract_Virtual_New_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition>.NativeClassPtr, 100664187);
			TriggerDefinition.NativeMethodInfoPtr_GetEffects_Public_Virtual_New_IEnumerable_1_Action_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition>.NativeClassPtr, 100664188);
			TriggerDefinition.NativeMethodInfoPtr_getSequenceName_Protected_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition>.NativeClassPtr, 100664189);
			TriggerDefinition.NativeMethodInfoPtr_GetEntityID_Public_Abstract_Virtual_New_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition>.NativeClassPtr, 100664190);
			TriggerDefinition.NativeMethodInfoPtr_Serialize_Public_Virtual_SerializedEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition>.NativeClassPtr, 100664191);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0002A8EC File Offset: 0x00028AEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 553224, RefRangeEnd = 553227, XrefRangeStart = 553223, XrefRangeEnd = 553224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TriggerDefinition(Match m, string name = "", PlayerEntity owningPlayer = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TriggerDefinition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owningPlayer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerDefinition.NativeMethodInfoPtr__ctor_Public_Void_Match_String_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0002A95C File Offset: 0x00028B5C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 553228, RefRangeEnd = 553234, XrefRangeStart = 553227, XrefRangeEnd = 553228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TriggerDefinition(SerializedEntity se, Match m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TriggerDefinition>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerDefinition.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0002A9CC File Offset: 0x00028BCC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeTrigger(Trigger t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TriggerDefinition.NativeMethodInfoPtr_InitializeTrigger_Public_Virtual_New_Void_Trigger_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0002AA1C File Offset: 0x00028C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553234, XrefRangeEnd = 553239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<Canis.actions.Action> AbilityTriggered(EntityID playerEntityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerEntityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TriggerDefinition.NativeMethodInfoPtr_AbilityTriggered_Public_Virtual_New_IEnumerable_1_Action_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0002AA78 File Offset: 0x00028C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553239, XrefRangeEnd = 553247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<Canis.actions.Action> Trigger(int phase, Match match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref phase;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TriggerDefinition.NativeMethodInfoPtr_Trigger_Public_Virtual_New_IEnumerable_1_Action_Int32_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0002AAF4 File Offset: 0x00028CF4
		[CallerCount(0)]
		public unsafe virtual CostAction Cost(Match match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TriggerDefinition.NativeMethodInfoPtr_Cost_Public_Abstract_Virtual_New_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0002AB64 File Offset: 0x00028D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553247, XrefRangeEnd = 553252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<Canis.actions.Action> GetEffects(Match match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TriggerDefinition.NativeMethodInfoPtr_GetEffects_Public_Virtual_New_IEnumerable_1_Action_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0002ABD4 File Offset: 0x00028DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553252, XrefRangeEnd = 553254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string getSequenceName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TriggerDefinition.NativeMethodInfoPtr_getSequenceName_Protected_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0002AC18 File Offset: 0x00028E18
		[CallerCount(0)]
		public unsafe virtual EntityID GetEntityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TriggerDefinition.NativeMethodInfoPtr_GetEntityID_Public_Abstract_Virtual_New_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0002AC64 File Offset: 0x00028E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553254, XrefRangeEnd = 553262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedEntity Serialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TriggerDefinition.NativeMethodInfoPtr_Serialize_Public_Virtual_SerializedEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedEntity>(intPtr3) : null;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00003D21 File Offset: 0x00001F21
		public TriggerDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x0002ACB0 File Offset: 0x00028EB0
		// (set) Token: 0x06000451 RID: 1105 RVA: 0x00003D2A File Offset: 0x00001F2A
		public unsafe int trigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition.NativeFieldInfoPtr_trigger);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition.NativeFieldInfoPtr_trigger)) = value;
			}
		}

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeFieldInfoPtr_trigger;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_String_PlayerEntity_0;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeMethodInfoPtr_InitializeTrigger_Public_Virtual_New_Void_Trigger_0;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeMethodInfoPtr_AbilityTriggered_Public_Virtual_New_IEnumerable_1_Action_EntityID_0;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeMethodInfoPtr_Trigger_Public_Virtual_New_IEnumerable_1_Action_Int32_Match_Context_0;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Abstract_Virtual_New_CostAction_Match_Context_0;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeMethodInfoPtr_GetEffects_Public_Virtual_New_IEnumerable_1_Action_Match_Context_0;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeMethodInfoPtr_getSequenceName_Protected_Virtual_New_String_0;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeMethodInfoPtr_GetEntityID_Public_Abstract_Virtual_New_EntityID_0;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_SerializedEntity_0;

		// Token: 0x0200029B RID: 667
		[ObfuscatedName("Canis.triggers.TriggerDefinition+<AbilityTriggered>d__4")]
		public sealed class _AbilityTriggered_d__4 : Object
		{
			// Token: 0x06001BF6 RID: 7158 RVA: 0x00085F50 File Offset: 0x00084150
			// Note: this type is marked as 'beforefieldinit'.
			static _AbilityTriggered_d__4()
			{
				Il2CppClassPointerStore<TriggerDefinition._AbilityTriggered_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TriggerDefinition>.NativeClassPtr, "<AbilityTriggered>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriggerDefinition._AbilityTriggered_d__4>.NativeClassPtr);
				TriggerDefinition._AbilityTriggered_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerDefinition._AbilityTriggered_d__4>.NativeClassPtr, "<>1__state");
				TriggerDefinition._AbilityTriggered_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerDefinition._AbilityTriggered_d__4>.NativeClassPtr, "<>2__current");
				TriggerDefinition._AbilityTriggered_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerDefinition._AbilityTriggered_d__4>.NativeClassPtr, "<>l__initialThreadId");
				TriggerDefinition._AbilityTriggered_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition._AbilityTriggered_d__4>.NativeClassPtr, 100664192);
				TriggerDefinition._AbilityTriggered_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition._AbilityTriggered_d__4>.NativeClassPtr, 100664193);
				TriggerDefinition._AbilityTriggered_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition._AbilityTriggered_d__4>.NativeClassPtr, 100664194);
				TriggerDefinition._AbilityTriggered_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition._AbilityTriggered_d__4>.NativeClassPtr, 100664195);
				TriggerDefinition._AbilityTriggered_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition._AbilityTriggered_d__4>.NativeClassPtr, 100664196);
				TriggerDefinition._AbilityTriggered_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition._AbilityTriggered_d__4>.NativeClassPtr, 100664197);
				TriggerDefinition._AbilityTriggered_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition._AbilityTriggered_d__4>.NativeClassPtr, 100664198);
				TriggerDefinition._AbilityTriggered_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition._AbilityTriggered_d__4>.NativeClassPtr, 100664199);
			}

			// Token: 0x06001BF7 RID: 7159 RVA: 0x00086058 File Offset: 0x00084258
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AbilityTriggered_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TriggerDefinition._AbilityTriggered_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerDefinition._AbilityTriggered_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BF8 RID: 7160 RVA: 0x000860A0 File Offset: 0x000842A0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerDefinition._AbilityTriggered_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BF9 RID: 7161 RVA: 0x000860D4 File Offset: 0x000842D4
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerDefinition._AbilityTriggered_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700066A RID: 1642
			// (get) Token: 0x06001BFA RID: 7162 RVA: 0x00086110 File Offset: 0x00084310
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerDefinition._AbilityTriggered_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06001BFB RID: 7163 RVA: 0x00086150 File Offset: 0x00084350
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553164, XrefRangeEnd = 553169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerDefinition._AbilityTriggered_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700066B RID: 1643
			// (get) Token: 0x06001BFC RID: 7164 RVA: 0x00086184 File Offset: 0x00084384
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerDefinition._AbilityTriggered_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001BFD RID: 7165 RVA: 0x000861C4 File Offset: 0x000843C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553169, XrefRangeEnd = 553171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerDefinition._AbilityTriggered_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06001BFE RID: 7166 RVA: 0x00086204 File Offset: 0x00084404
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerDefinition._AbilityTriggered_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001BFF RID: 7167 RVA: 0x0000D534 File Offset: 0x0000B734
			public _AbilityTriggered_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000667 RID: 1639
			// (get) Token: 0x06001C00 RID: 7168 RVA: 0x00086244 File Offset: 0x00084444
			// (set) Token: 0x06001C01 RID: 7169 RVA: 0x0000D53D File Offset: 0x0000B73D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._AbilityTriggered_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._AbilityTriggered_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000668 RID: 1640
			// (get) Token: 0x06001C02 RID: 7170 RVA: 0x0008626C File Offset: 0x0008446C
			// (set) Token: 0x06001C03 RID: 7171 RVA: 0x0000D558 File Offset: 0x0000B758
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._AbilityTriggered_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._AbilityTriggered_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000669 RID: 1641
			// (get) Token: 0x06001C04 RID: 7172 RVA: 0x0008629C File Offset: 0x0008449C
			// (set) Token: 0x06001C05 RID: 7173 RVA: 0x0000D577 File Offset: 0x0000B777
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._AbilityTriggered_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._AbilityTriggered_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x040011D7 RID: 4567
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040011D8 RID: 4568
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040011D9 RID: 4569
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040011DA RID: 4570
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040011DB RID: 4571
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040011DC RID: 4572
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040011DD RID: 4573
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040011DE RID: 4574
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040011DF RID: 4575
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040011E0 RID: 4576
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040011E1 RID: 4577
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200029C RID: 668
		[ObfuscatedName("Canis.triggers.TriggerDefinition+<GetEffects>d__7")]
		public sealed class _GetEffects_d__7 : Object
		{
			// Token: 0x06001C06 RID: 7174 RVA: 0x000862C4 File Offset: 0x000844C4
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEffects_d__7()
			{
				Il2CppClassPointerStore<TriggerDefinition._GetEffects_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TriggerDefinition>.NativeClassPtr, "<GetEffects>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriggerDefinition._GetEffects_d__7>.NativeClassPtr);
				TriggerDefinition._GetEffects_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerDefinition._GetEffects_d__7>.NativeClassPtr, "<>1__state");
				TriggerDefinition._GetEffects_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerDefinition._GetEffects_d__7>.NativeClassPtr, "<>2__current");
				TriggerDefinition._GetEffects_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerDefinition._GetEffects_d__7>.NativeClassPtr, "<>l__initialThreadId");
				TriggerDefinition._GetEffects_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition._GetEffects_d__7>.NativeClassPtr, 100664200);
				TriggerDefinition._GetEffects_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition._GetEffects_d__7>.NativeClassPtr, 100664201);
				TriggerDefinition._GetEffects_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition._GetEffects_d__7>.NativeClassPtr, 100664202);
				TriggerDefinition._GetEffects_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition._GetEffects_d__7>.NativeClassPtr, 100664203);
				TriggerDefinition._GetEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition._GetEffects_d__7>.NativeClassPtr, 100664204);
				TriggerDefinition._GetEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition._GetEffects_d__7>.NativeClassPtr, 100664205);
				TriggerDefinition._GetEffects_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition._GetEffects_d__7>.NativeClassPtr, 100664206);
				TriggerDefinition._GetEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition._GetEffects_d__7>.NativeClassPtr, 100664207);
			}

			// Token: 0x06001C07 RID: 7175 RVA: 0x000863CC File Offset: 0x000845CC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetEffects_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TriggerDefinition._GetEffects_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerDefinition._GetEffects_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C08 RID: 7176 RVA: 0x00086414 File Offset: 0x00084614
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerDefinition._GetEffects_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C09 RID: 7177 RVA: 0x00086448 File Offset: 0x00084648
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerDefinition._GetEffects_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700066F RID: 1647
			// (get) Token: 0x06001C0A RID: 7178 RVA: 0x00086484 File Offset: 0x00084684
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerDefinition._GetEffects_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06001C0B RID: 7179 RVA: 0x000864C4 File Offset: 0x000846C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553171, XrefRangeEnd = 553176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerDefinition._GetEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000670 RID: 1648
			// (get) Token: 0x06001C0C RID: 7180 RVA: 0x000864F8 File Offset: 0x000846F8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerDefinition._GetEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001C0D RID: 7181 RVA: 0x00086538 File Offset: 0x00084738
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553176, XrefRangeEnd = 553178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerDefinition._GetEffects_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06001C0E RID: 7182 RVA: 0x00086578 File Offset: 0x00084778
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerDefinition._GetEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001C0F RID: 7183 RVA: 0x0000D592 File Offset: 0x0000B792
			public _GetEffects_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700066C RID: 1644
			// (get) Token: 0x06001C10 RID: 7184 RVA: 0x000865B8 File Offset: 0x000847B8
			// (set) Token: 0x06001C11 RID: 7185 RVA: 0x0000D59B File Offset: 0x0000B79B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._GetEffects_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._GetEffects_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700066D RID: 1645
			// (get) Token: 0x06001C12 RID: 7186 RVA: 0x000865E0 File Offset: 0x000847E0
			// (set) Token: 0x06001C13 RID: 7187 RVA: 0x0000D5B6 File Offset: 0x0000B7B6
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._GetEffects_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._GetEffects_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700066E RID: 1646
			// (get) Token: 0x06001C14 RID: 7188 RVA: 0x00086610 File Offset: 0x00084810
			// (set) Token: 0x06001C15 RID: 7189 RVA: 0x0000D5D5 File Offset: 0x0000B7D5
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._GetEffects_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._GetEffects_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x040011E2 RID: 4578
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040011E3 RID: 4579
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040011E4 RID: 4580
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040011E5 RID: 4581
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040011E6 RID: 4582
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040011E7 RID: 4583
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040011E8 RID: 4584
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040011E9 RID: 4585
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040011EA RID: 4586
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040011EB RID: 4587
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040011EC RID: 4588
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200029D RID: 669
		[ObfuscatedName("Canis.triggers.TriggerDefinition+<Trigger>d__5")]
		public sealed class _Trigger_d__5 : Object
		{
			// Token: 0x06001C16 RID: 7190 RVA: 0x00086638 File Offset: 0x00084838
			// Note: this type is marked as 'beforefieldinit'.
			static _Trigger_d__5()
			{
				Il2CppClassPointerStore<TriggerDefinition._Trigger_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TriggerDefinition>.NativeClassPtr, "<Trigger>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriggerDefinition._Trigger_d__5>.NativeClassPtr);
				TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerDefinition._Trigger_d__5>.NativeClassPtr, "<>1__state");
				TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerDefinition._Trigger_d__5>.NativeClassPtr, "<>2__current");
				TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerDefinition._Trigger_d__5>.NativeClassPtr, "<>l__initialThreadId");
				TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerDefinition._Trigger_d__5>.NativeClassPtr, "<>4__this");
				TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr_phase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerDefinition._Trigger_d__5>.NativeClassPtr, "phase");
				TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr___3__phase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerDefinition._Trigger_d__5>.NativeClassPtr, "<>3__phase");
				TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerDefinition._Trigger_d__5>.NativeClassPtr, "match");
				TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerDefinition._Trigger_d__5>.NativeClassPtr, "<>3__match");
				TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerDefinition._Trigger_d__5>.NativeClassPtr, "context");
				TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerDefinition._Trigger_d__5>.NativeClassPtr, "<>3__context");
				TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerDefinition._Trigger_d__5>.NativeClassPtr, "<>7__wrap1");
				TriggerDefinition._Trigger_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition._Trigger_d__5>.NativeClassPtr, 100664208);
				TriggerDefinition._Trigger_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition._Trigger_d__5>.NativeClassPtr, 100664209);
				TriggerDefinition._Trigger_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition._Trigger_d__5>.NativeClassPtr, 100664210);
				TriggerDefinition._Trigger_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition._Trigger_d__5>.NativeClassPtr, 100664211);
				TriggerDefinition._Trigger_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition._Trigger_d__5>.NativeClassPtr, 100664212);
				TriggerDefinition._Trigger_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition._Trigger_d__5>.NativeClassPtr, 100664213);
				TriggerDefinition._Trigger_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition._Trigger_d__5>.NativeClassPtr, 100664214);
				TriggerDefinition._Trigger_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition._Trigger_d__5>.NativeClassPtr, 100664215);
				TriggerDefinition._Trigger_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerDefinition._Trigger_d__5>.NativeClassPtr, 100664216);
			}

			// Token: 0x06001C17 RID: 7191 RVA: 0x000867F4 File Offset: 0x000849F4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Trigger_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TriggerDefinition._Trigger_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerDefinition._Trigger_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C18 RID: 7192 RVA: 0x0008683C File Offset: 0x00084A3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553178, XrefRangeEnd = 553183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerDefinition._Trigger_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C19 RID: 7193 RVA: 0x00086870 File Offset: 0x00084A70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553183, XrefRangeEnd = 553205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerDefinition._Trigger_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001C1A RID: 7194 RVA: 0x000868AC File Offset: 0x00084AAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553205, XrefRangeEnd = 553208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerDefinition._Trigger_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700067C RID: 1660
			// (get) Token: 0x06001C1B RID: 7195 RVA: 0x000868E0 File Offset: 0x00084AE0
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerDefinition._Trigger_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06001C1C RID: 7196 RVA: 0x00086920 File Offset: 0x00084B20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553208, XrefRangeEnd = 553213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerDefinition._Trigger_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700067D RID: 1661
			// (get) Token: 0x06001C1D RID: 7197 RVA: 0x00086954 File Offset: 0x00084B54
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerDefinition._Trigger_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001C1E RID: 7198 RVA: 0x00086994 File Offset: 0x00084B94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553213, XrefRangeEnd = 553223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerDefinition._Trigger_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06001C1F RID: 7199 RVA: 0x000869D4 File Offset: 0x00084BD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerDefinition._Trigger_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001C20 RID: 7200 RVA: 0x0000D5F0 File Offset: 0x0000B7F0
			public _Trigger_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000671 RID: 1649
			// (get) Token: 0x06001C21 RID: 7201 RVA: 0x00086A14 File Offset: 0x00084C14
			// (set) Token: 0x06001C22 RID: 7202 RVA: 0x0000D5F9 File Offset: 0x0000B7F9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000672 RID: 1650
			// (get) Token: 0x06001C23 RID: 7203 RVA: 0x00086A3C File Offset: 0x00084C3C
			// (set) Token: 0x06001C24 RID: 7204 RVA: 0x0000D614 File Offset: 0x0000B814
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000673 RID: 1651
			// (get) Token: 0x06001C25 RID: 7205 RVA: 0x00086A6C File Offset: 0x00084C6C
			// (set) Token: 0x06001C26 RID: 7206 RVA: 0x0000D633 File Offset: 0x0000B833
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000674 RID: 1652
			// (get) Token: 0x06001C27 RID: 7207 RVA: 0x00086A94 File Offset: 0x00084C94
			// (set) Token: 0x06001C28 RID: 7208 RVA: 0x0000D64E File Offset: 0x0000B84E
			public unsafe TriggerDefinition __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TriggerDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000675 RID: 1653
			// (get) Token: 0x06001C29 RID: 7209 RVA: 0x00086AC4 File Offset: 0x00084CC4
			// (set) Token: 0x06001C2A RID: 7210 RVA: 0x0000D66D File Offset: 0x0000B86D
			public unsafe int phase
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr_phase);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr_phase)) = value;
				}
			}

			// Token: 0x17000676 RID: 1654
			// (get) Token: 0x06001C2B RID: 7211 RVA: 0x00086AEC File Offset: 0x00084CEC
			// (set) Token: 0x06001C2C RID: 7212 RVA: 0x0000D688 File Offset: 0x0000B888
			public unsafe int __3__phase
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr___3__phase);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr___3__phase)) = value;
				}
			}

			// Token: 0x17000677 RID: 1655
			// (get) Token: 0x06001C2D RID: 7213 RVA: 0x00086B14 File Offset: 0x00084D14
			// (set) Token: 0x06001C2E RID: 7214 RVA: 0x0000D6A3 File Offset: 0x0000B8A3
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000678 RID: 1656
			// (get) Token: 0x06001C2F RID: 7215 RVA: 0x00086B44 File Offset: 0x00084D44
			// (set) Token: 0x06001C30 RID: 7216 RVA: 0x0000D6C2 File Offset: 0x0000B8C2
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000679 RID: 1657
			// (get) Token: 0x06001C31 RID: 7217 RVA: 0x00086B74 File Offset: 0x00084D74
			// (set) Token: 0x06001C32 RID: 7218 RVA: 0x0000D6E1 File Offset: 0x0000B8E1
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700067A RID: 1658
			// (get) Token: 0x06001C33 RID: 7219 RVA: 0x00086BA4 File Offset: 0x00084DA4
			// (set) Token: 0x06001C34 RID: 7220 RVA: 0x0000D700 File Offset: 0x0000B900
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700067B RID: 1659
			// (get) Token: 0x06001C35 RID: 7221 RVA: 0x00086BD4 File Offset: 0x00084DD4
			// (set) Token: 0x06001C36 RID: 7222 RVA: 0x0000D71F File Offset: 0x0000B91F
			public unsafe IEnumerator<Canis.actions.Action> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerDefinition._Trigger_d__5.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011ED RID: 4589
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040011EE RID: 4590
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040011EF RID: 4591
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040011F0 RID: 4592
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040011F1 RID: 4593
			private static readonly IntPtr NativeFieldInfoPtr_phase;

			// Token: 0x040011F2 RID: 4594
			private static readonly IntPtr NativeFieldInfoPtr___3__phase;

			// Token: 0x040011F3 RID: 4595
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040011F4 RID: 4596
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x040011F5 RID: 4597
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040011F6 RID: 4598
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x040011F7 RID: 4599
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040011F8 RID: 4600
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040011F9 RID: 4601
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040011FA RID: 4602
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040011FB RID: 4603
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040011FC RID: 4604
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040011FD RID: 4605
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040011FE RID: 4606
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040011FF RID: 4607
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001200 RID: 4608
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
