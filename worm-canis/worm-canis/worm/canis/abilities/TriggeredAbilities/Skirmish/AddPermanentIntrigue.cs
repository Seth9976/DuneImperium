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
using worm.canis.entities;

namespace worm.canis.abilities.TriggeredAbilities.Skirmish
{
	// Token: 0x02000324 RID: 804
	public class AddPermanentIntrigue : RuleModAbility
	{
		// Token: 0x060020C2 RID: 8386 RVA: 0x000D9C40 File Offset: 0x000D7E40
		// Note: this type is marked as 'beforefieldinit'.
		static AddPermanentIntrigue()
		{
			Il2CppClassPointerStore<AddPermanentIntrigue>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.Skirmish", "AddPermanentIntrigue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddPermanentIntrigue>.NativeClassPtr);
			AddPermanentIntrigue.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddPermanentIntrigue>.NativeClassPtr, 100671385);
			AddPermanentIntrigue.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddPermanentIntrigue>.NativeClassPtr, 100671386);
			AddPermanentIntrigue.NativeMethodInfoPtr_get_CardArchetype_Protected_Virtual_New_get_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddPermanentIntrigue>.NativeClassPtr, 100671387);
			AddPermanentIntrigue.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddPermanentIntrigue>.NativeClassPtr, 100671388);
			AddPermanentIntrigue.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddPermanentIntrigue>.NativeClassPtr, 100671389);
			AddPermanentIntrigue.NativeMethodInfoPtr__BeginExecution_b__5_0_Private_Boolean_WormIntriguePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddPermanentIntrigue>.NativeClassPtr, 100671390);
		}

		// Token: 0x060020C3 RID: 8387 RVA: 0x000D9CE8 File Offset: 0x000D7EE8
		[CallerCount(154)]
		[CachedScanResults(RefRangeStart = 176120, RefRangeEnd = 176274, XrefRangeStart = 176120, XrefRangeEnd = 176274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddPermanentIntrigue(WormMatch m, string name = "", PlayerEntity owningPlayer = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddPermanentIntrigue>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddPermanentIntrigue.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020C4 RID: 8388 RVA: 0x000D9D58 File Offset: 0x000D7F58
		[CallerCount(314)]
		[CachedScanResults(RefRangeStart = 176275, RefRangeEnd = 176589, XrefRangeStart = 176275, XrefRangeEnd = 176589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddPermanentIntrigue(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddPermanentIntrigue>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddPermanentIntrigue.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x060020C5 RID: 8389 RVA: 0x000D9DC8 File Offset: 0x000D7FC8
		public unsafe virtual ArchetypeID CardArchetype
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177182, XrefRangeEnd = 177186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddPermanentIntrigue.NativeMethodInfoPtr_get_CardArchetype_Protected_Virtual_New_get_ArchetypeID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
			}
		}

		// Token: 0x060020C6 RID: 8390 RVA: 0x000D9E14 File Offset: 0x000D8014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177186, XrefRangeEnd = 177195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<PlayerEntity> IsValidFor(SerializableEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddPermanentIntrigue.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x060020C7 RID: 8391 RVA: 0x000D9E70 File Offset: 0x000D8070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177195, XrefRangeEnd = 177203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddPermanentIntrigue.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060020C8 RID: 8392 RVA: 0x000D9EF0 File Offset: 0x000D80F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177203, XrefRangeEnd = 177208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _BeginExecution_b__5_0(WormIntriguePlayable _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddPermanentIntrigue.NativeMethodInfoPtr__BeginExecution_b__5_0_Private_Boolean_WormIntriguePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020C9 RID: 8393 RVA: 0x0000D735 File Offset: 0x0000B935
		public AddPermanentIntrigue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014AF RID: 5295
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_PlayerEntity_0;

		// Token: 0x040014B0 RID: 5296
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x040014B1 RID: 5297
		private static readonly IntPtr NativeMethodInfoPtr_get_CardArchetype_Protected_Virtual_New_get_ArchetypeID_0;

		// Token: 0x040014B2 RID: 5298
		private static readonly IntPtr NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0;

		// Token: 0x040014B3 RID: 5299
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x040014B4 RID: 5300
		private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__5_0_Private_Boolean_WormIntriguePlayable_0;

		// Token: 0x020007EB RID: 2027
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Skirmish.AddPermanentIntrigue+<BeginExecution>d__5")]
		public sealed class _BeginExecution_d__5 : Object
		{
			// Token: 0x060072D7 RID: 29399 RVA: 0x002136CC File Offset: 0x002118CC
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__5()
			{
				Il2CppClassPointerStore<AddPermanentIntrigue._BeginExecution_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddPermanentIntrigue>.NativeClassPtr, "<BeginExecution>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddPermanentIntrigue._BeginExecution_d__5>.NativeClassPtr);
				AddPermanentIntrigue._BeginExecution_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddPermanentIntrigue._BeginExecution_d__5>.NativeClassPtr, "<>1__state");
				AddPermanentIntrigue._BeginExecution_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddPermanentIntrigue._BeginExecution_d__5>.NativeClassPtr, "<>2__current");
				AddPermanentIntrigue._BeginExecution_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddPermanentIntrigue._BeginExecution_d__5>.NativeClassPtr, "<>l__initialThreadId");
				AddPermanentIntrigue._BeginExecution_d__5.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddPermanentIntrigue._BeginExecution_d__5>.NativeClassPtr, "activeAbility");
				AddPermanentIntrigue._BeginExecution_d__5.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddPermanentIntrigue._BeginExecution_d__5>.NativeClassPtr, "<>3__activeAbility");
				AddPermanentIntrigue._BeginExecution_d__5.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddPermanentIntrigue._BeginExecution_d__5>.NativeClassPtr, "match");
				AddPermanentIntrigue._BeginExecution_d__5.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddPermanentIntrigue._BeginExecution_d__5>.NativeClassPtr, "<>3__match");
				AddPermanentIntrigue._BeginExecution_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddPermanentIntrigue._BeginExecution_d__5>.NativeClassPtr, "<>4__this");
				AddPermanentIntrigue._BeginExecution_d__5.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddPermanentIntrigue._BeginExecution_d__5>.NativeClassPtr, "<player>5__2");
				AddPermanentIntrigue._BeginExecution_d__5.NativeFieldInfoPtr__intrigueCard_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddPermanentIntrigue._BeginExecution_d__5>.NativeClassPtr, "<intrigueCard>5__3");
				AddPermanentIntrigue._BeginExecution_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddPermanentIntrigue._BeginExecution_d__5>.NativeClassPtr, 100671391);
				AddPermanentIntrigue._BeginExecution_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddPermanentIntrigue._BeginExecution_d__5>.NativeClassPtr, 100671392);
				AddPermanentIntrigue._BeginExecution_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddPermanentIntrigue._BeginExecution_d__5>.NativeClassPtr, 100671393);
				AddPermanentIntrigue._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddPermanentIntrigue._BeginExecution_d__5>.NativeClassPtr, 100671394);
				AddPermanentIntrigue._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddPermanentIntrigue._BeginExecution_d__5>.NativeClassPtr, 100671395);
				AddPermanentIntrigue._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddPermanentIntrigue._BeginExecution_d__5>.NativeClassPtr, 100671396);
				AddPermanentIntrigue._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddPermanentIntrigue._BeginExecution_d__5>.NativeClassPtr, 100671397);
				AddPermanentIntrigue._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddPermanentIntrigue._BeginExecution_d__5>.NativeClassPtr, 100671398);
			}

			// Token: 0x060072D8 RID: 29400 RVA: 0x00213860 File Offset: 0x00211A60
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddPermanentIntrigue._BeginExecution_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddPermanentIntrigue._BeginExecution_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060072D9 RID: 29401 RVA: 0x002138A8 File Offset: 0x00211AA8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddPermanentIntrigue._BeginExecution_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060072DA RID: 29402 RVA: 0x002138DC File Offset: 0x00211ADC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177131, XrefRangeEnd = 177167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddPermanentIntrigue._BeginExecution_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001FB3 RID: 8115
			// (get) Token: 0x060072DB RID: 29403 RVA: 0x00213918 File Offset: 0x00211B18
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddPermanentIntrigue._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060072DC RID: 29404 RVA: 0x00213958 File Offset: 0x00211B58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177167, XrefRangeEnd = 177172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddPermanentIntrigue._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001FB4 RID: 8116
			// (get) Token: 0x060072DD RID: 29405 RVA: 0x0021398C File Offset: 0x00211B8C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddPermanentIntrigue._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060072DE RID: 29406 RVA: 0x002139CC File Offset: 0x00211BCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177172, XrefRangeEnd = 177182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddPermanentIntrigue._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060072DF RID: 29407 RVA: 0x00213A0C File Offset: 0x00211C0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddPermanentIntrigue._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060072E0 RID: 29408 RVA: 0x0002DC36 File Offset: 0x0002BE36
			public _BeginExecution_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001FA9 RID: 8105
			// (get) Token: 0x060072E1 RID: 29409 RVA: 0x00213A4C File Offset: 0x00211C4C
			// (set) Token: 0x060072E2 RID: 29410 RVA: 0x0002DC3F File Offset: 0x0002BE3F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPermanentIntrigue._BeginExecution_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPermanentIntrigue._BeginExecution_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001FAA RID: 8106
			// (get) Token: 0x060072E3 RID: 29411 RVA: 0x00213A74 File Offset: 0x00211C74
			// (set) Token: 0x060072E4 RID: 29412 RVA: 0x0002DC5A File Offset: 0x0002BE5A
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPermanentIntrigue._BeginExecution_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPermanentIntrigue._BeginExecution_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001FAB RID: 8107
			// (get) Token: 0x060072E5 RID: 29413 RVA: 0x00213AA4 File Offset: 0x00211CA4
			// (set) Token: 0x060072E6 RID: 29414 RVA: 0x0002DC79 File Offset: 0x0002BE79
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPermanentIntrigue._BeginExecution_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPermanentIntrigue._BeginExecution_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001FAC RID: 8108
			// (get) Token: 0x060072E7 RID: 29415 RVA: 0x00213ACC File Offset: 0x00211CCC
			// (set) Token: 0x060072E8 RID: 29416 RVA: 0x0002DC94 File Offset: 0x0002BE94
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPermanentIntrigue._BeginExecution_d__5.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPermanentIntrigue._BeginExecution_d__5.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001FAD RID: 8109
			// (get) Token: 0x060072E9 RID: 29417 RVA: 0x00213AFC File Offset: 0x00211CFC
			// (set) Token: 0x060072EA RID: 29418 RVA: 0x0002DCB3 File Offset: 0x0002BEB3
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPermanentIntrigue._BeginExecution_d__5.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPermanentIntrigue._BeginExecution_d__5.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001FAE RID: 8110
			// (get) Token: 0x060072EB RID: 29419 RVA: 0x00213B2C File Offset: 0x00211D2C
			// (set) Token: 0x060072EC RID: 29420 RVA: 0x0002DCD2 File Offset: 0x0002BED2
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPermanentIntrigue._BeginExecution_d__5.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPermanentIntrigue._BeginExecution_d__5.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001FAF RID: 8111
			// (get) Token: 0x060072ED RID: 29421 RVA: 0x00213B5C File Offset: 0x00211D5C
			// (set) Token: 0x060072EE RID: 29422 RVA: 0x0002DCF1 File Offset: 0x0002BEF1
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPermanentIntrigue._BeginExecution_d__5.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPermanentIntrigue._BeginExecution_d__5.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001FB0 RID: 8112
			// (get) Token: 0x060072EF RID: 29423 RVA: 0x00213B8C File Offset: 0x00211D8C
			// (set) Token: 0x060072F0 RID: 29424 RVA: 0x0002DD10 File Offset: 0x0002BF10
			public unsafe AddPermanentIntrigue __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPermanentIntrigue._BeginExecution_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddPermanentIntrigue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPermanentIntrigue._BeginExecution_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001FB1 RID: 8113
			// (get) Token: 0x060072F1 RID: 29425 RVA: 0x00213BBC File Offset: 0x00211DBC
			// (set) Token: 0x060072F2 RID: 29426 RVA: 0x0002DD2F File Offset: 0x0002BF2F
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPermanentIntrigue._BeginExecution_d__5.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPermanentIntrigue._BeginExecution_d__5.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001FB2 RID: 8114
			// (get) Token: 0x060072F3 RID: 29427 RVA: 0x00213BEC File Offset: 0x00211DEC
			// (set) Token: 0x060072F4 RID: 29428 RVA: 0x0002DD4E File Offset: 0x0002BF4E
			public unsafe Entity _intrigueCard_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPermanentIntrigue._BeginExecution_d__5.NativeFieldInfoPtr__intrigueCard_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddPermanentIntrigue._BeginExecution_d__5.NativeFieldInfoPtr__intrigueCard_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004A23 RID: 18979
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004A24 RID: 18980
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004A25 RID: 18981
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004A26 RID: 18982
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04004A27 RID: 18983
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04004A28 RID: 18984
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04004A29 RID: 18985
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04004A2A RID: 18986
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004A2B RID: 18987
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04004A2C RID: 18988
			private static readonly IntPtr NativeFieldInfoPtr__intrigueCard_5__3;

			// Token: 0x04004A2D RID: 18989
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004A2E RID: 18990
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004A2F RID: 18991
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004A30 RID: 18992
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004A31 RID: 18993
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004A32 RID: 18994
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004A33 RID: 18995
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004A34 RID: 18996
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
