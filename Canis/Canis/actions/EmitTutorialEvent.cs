using System;
using Canis.actions.serialized;
using Canis.attributes;
using Canis.entities;
using Canis.tutorialScripts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions
{
	// Token: 0x020001A9 RID: 425
	public class EmitTutorialEvent : Action
	{
		// Token: 0x0600124D RID: 4685 RVA: 0x00063764 File Offset: 0x00061964
		// Note: this type is marked as 'beforefieldinit'.
		static EmitTutorialEvent()
		{
			Il2CppClassPointerStore<EmitTutorialEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "EmitTutorialEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmitTutorialEvent>.NativeClassPtr);
			EmitTutorialEvent.NativeFieldInfoPtr_tutorialActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitTutorialEvent>.NativeClassPtr, "tutorialActions");
			EmitTutorialEvent.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitTutorialEvent>.NativeClassPtr, "player");
			EmitTutorialEvent.NativeMethodInfoPtr__ctor_Public_Void_Match_TutorialAction_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitTutorialEvent>.NativeClassPtr, 100667219);
			EmitTutorialEvent.NativeMethodInfoPtr__ctor_Public_Void_Match_List_1_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitTutorialEvent>.NativeClassPtr, 100667220);
			EmitTutorialEvent.NativeMethodInfoPtr__ctor_Public_Void_SerializedEmitTutorialEvent_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitTutorialEvent>.NativeClassPtr, 100667221);
			EmitTutorialEvent.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitTutorialEvent>.NativeClassPtr, 100667222);
			EmitTutorialEvent.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitTutorialEvent>.NativeClassPtr, 100667223);
			EmitTutorialEvent.NativeMethodInfoPtr__MakeSerializedAction_b__6_0_Private_SerializableAttributes_TutorialAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitTutorialEvent>.NativeClassPtr, 100667224);
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x00063834 File Offset: 0x00061A34
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 585366, RefRangeEnd = 585377, XrefRangeStart = 585353, XrefRangeEnd = 585366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmitTutorialEvent(Match m, TutorialAction ta, PlayerEntity player = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmitTutorialEvent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ta);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitTutorialEvent.NativeMethodInfoPtr__ctor_Public_Void_Match_TutorialAction_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x000638A4 File Offset: 0x00061AA4
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 584680, RefRangeEnd = 584707, XrefRangeStart = 584680, XrefRangeEnd = 584707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmitTutorialEvent(Match m, List<TutorialAction> tas)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmitTutorialEvent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tas);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitTutorialEvent.NativeMethodInfoPtr__ctor_Public_Void_Match_List_1_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x00063904 File Offset: 0x00061B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585377, XrefRangeEnd = 585401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmitTutorialEvent(SerializedEmitTutorialEvent serialized, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmitTutorialEvent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitTutorialEvent.NativeMethodInfoPtr__ctor_Public_Void_SerializedEmitTutorialEvent_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x00063964 File Offset: 0x00061B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585401, XrefRangeEnd = 585407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmitTutorialEvent.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x000639B0 File Offset: 0x00061BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585407, XrefRangeEnd = 585425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmitTutorialEvent.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x00063A0C File Offset: 0x00061C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585425, XrefRangeEnd = 585426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializableAttributes _MakeSerializedAction_b__6_0(TutorialAction ta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ta);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitTutorialEvent.NativeMethodInfoPtr__MakeSerializedAction_b__6_0_Private_SerializableAttributes_TutorialAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x000090B3 File Offset: 0x000072B3
		public EmitTutorialEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06001255 RID: 4693 RVA: 0x00063A5C File Offset: 0x00061C5C
		// (set) Token: 0x06001256 RID: 4694 RVA: 0x000090BC File Offset: 0x000072BC
		public unsafe List<TutorialAction> tutorialActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitTutorialEvent.NativeFieldInfoPtr_tutorialActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TutorialAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitTutorialEvent.NativeFieldInfoPtr_tutorialActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06001257 RID: 4695 RVA: 0x00063A8C File Offset: 0x00061C8C
		// (set) Token: 0x06001258 RID: 4696 RVA: 0x000090DB File Offset: 0x000072DB
		public unsafe PlayerEntity player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitTutorialEvent.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitTutorialEvent.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BEE RID: 3054
		private static readonly IntPtr NativeFieldInfoPtr_tutorialActions;

		// Token: 0x04000BEF RID: 3055
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04000BF0 RID: 3056
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_TutorialAction_PlayerEntity_0;

		// Token: 0x04000BF1 RID: 3057
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_List_1_TutorialAction_0;

		// Token: 0x04000BF2 RID: 3058
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEmitTutorialEvent_Match_0;

		// Token: 0x04000BF3 RID: 3059
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04000BF4 RID: 3060
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x04000BF5 RID: 3061
		private static readonly IntPtr NativeMethodInfoPtr__MakeSerializedAction_b__6_0_Private_SerializableAttributes_TutorialAction_0;

		// Token: 0x020003E9 RID: 1001
		[ObfuscatedName("Canis.actions.EmitTutorialEvent+<>O")]
		public static class __O : Object
		{
			// Token: 0x06002AB3 RID: 10931 RVA: 0x00014690 File Offset: 0x00012890
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<EmitTutorialEvent.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EmitTutorialEvent>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmitTutorialEvent.__O>.NativeClassPtr);
				EmitTutorialEvent.__O.NativeFieldInfoPtr__0___FromSerializedAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitTutorialEvent.__O>.NativeClassPtr, "<0>__FromSerializedAttributes");
			}

			// Token: 0x06002AB4 RID: 10932 RVA: 0x000146C4 File Offset: 0x000128C4
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AD9 RID: 2777
			// (get) Token: 0x06002AB5 RID: 10933 RVA: 0x000B6ED8 File Offset: 0x000B50D8
			// (set) Token: 0x06002AB6 RID: 10934 RVA: 0x000146CD File Offset: 0x000128CD
			public unsafe static Func<SerializableAttributes, TutorialAction> _0___FromSerializedAttributes
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EmitTutorialEvent.__O.NativeFieldInfoPtr__0___FromSerializedAttributes, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SerializableAttributes, TutorialAction>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EmitTutorialEvent.__O.NativeFieldInfoPtr__0___FromSerializedAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001AAF RID: 6831
			private static readonly IntPtr NativeFieldInfoPtr__0___FromSerializedAttributes;
		}

		// Token: 0x020003EA RID: 1002
		[ObfuscatedName("Canis.actions.EmitTutorialEvent+<execute>d__5")]
		public sealed class _execute_d__5 : Object
		{
			// Token: 0x06002AB7 RID: 10935 RVA: 0x000B6F00 File Offset: 0x000B5100
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__5()
			{
				Il2CppClassPointerStore<EmitTutorialEvent._execute_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EmitTutorialEvent>.NativeClassPtr, "<execute>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmitTutorialEvent._execute_d__5>.NativeClassPtr);
				EmitTutorialEvent._execute_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitTutorialEvent._execute_d__5>.NativeClassPtr, "<>1__state");
				EmitTutorialEvent._execute_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitTutorialEvent._execute_d__5>.NativeClassPtr, "<>2__current");
				EmitTutorialEvent._execute_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitTutorialEvent._execute_d__5>.NativeClassPtr, "<>l__initialThreadId");
				EmitTutorialEvent._execute_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitTutorialEvent._execute_d__5>.NativeClassPtr, "<>4__this");
				EmitTutorialEvent._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitTutorialEvent._execute_d__5>.NativeClassPtr, 100667225);
				EmitTutorialEvent._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitTutorialEvent._execute_d__5>.NativeClassPtr, 100667226);
				EmitTutorialEvent._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitTutorialEvent._execute_d__5>.NativeClassPtr, 100667227);
				EmitTutorialEvent._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitTutorialEvent._execute_d__5>.NativeClassPtr, 100667228);
				EmitTutorialEvent._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitTutorialEvent._execute_d__5>.NativeClassPtr, 100667229);
				EmitTutorialEvent._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitTutorialEvent._execute_d__5>.NativeClassPtr, 100667230);
				EmitTutorialEvent._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitTutorialEvent._execute_d__5>.NativeClassPtr, 100667231);
				EmitTutorialEvent._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitTutorialEvent._execute_d__5>.NativeClassPtr, 100667232);
			}

			// Token: 0x06002AB8 RID: 10936 RVA: 0x000B701C File Offset: 0x000B521C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmitTutorialEvent._execute_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitTutorialEvent._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002AB9 RID: 10937 RVA: 0x000B7064 File Offset: 0x000B5264
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitTutorialEvent._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002ABA RID: 10938 RVA: 0x000B7098 File Offset: 0x000B5298
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585310, XrefRangeEnd = 585346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitTutorialEvent._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000ADE RID: 2782
			// (get) Token: 0x06002ABB RID: 10939 RVA: 0x000B70D4 File Offset: 0x000B52D4
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitTutorialEvent._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002ABC RID: 10940 RVA: 0x000B7114 File Offset: 0x000B5314
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585346, XrefRangeEnd = 585351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitTutorialEvent._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000ADF RID: 2783
			// (get) Token: 0x06002ABD RID: 10941 RVA: 0x000B7148 File Offset: 0x000B5348
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitTutorialEvent._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002ABE RID: 10942 RVA: 0x000B7188 File Offset: 0x000B5388
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585351, XrefRangeEnd = 585353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitTutorialEvent._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06002ABF RID: 10943 RVA: 0x000B71C8 File Offset: 0x000B53C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitTutorialEvent._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002AC0 RID: 10944 RVA: 0x000146DF File Offset: 0x000128DF
			public _execute_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000ADA RID: 2778
			// (get) Token: 0x06002AC1 RID: 10945 RVA: 0x000B7208 File Offset: 0x000B5408
			// (set) Token: 0x06002AC2 RID: 10946 RVA: 0x000146E8 File Offset: 0x000128E8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitTutorialEvent._execute_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitTutorialEvent._execute_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000ADB RID: 2779
			// (get) Token: 0x06002AC3 RID: 10947 RVA: 0x000B7230 File Offset: 0x000B5430
			// (set) Token: 0x06002AC4 RID: 10948 RVA: 0x00014703 File Offset: 0x00012903
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitTutorialEvent._execute_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitTutorialEvent._execute_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ADC RID: 2780
			// (get) Token: 0x06002AC5 RID: 10949 RVA: 0x000B7260 File Offset: 0x000B5460
			// (set) Token: 0x06002AC6 RID: 10950 RVA: 0x00014722 File Offset: 0x00012922
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitTutorialEvent._execute_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitTutorialEvent._execute_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000ADD RID: 2781
			// (get) Token: 0x06002AC7 RID: 10951 RVA: 0x000B7288 File Offset: 0x000B5488
			// (set) Token: 0x06002AC8 RID: 10952 RVA: 0x0001473D File Offset: 0x0001293D
			public unsafe EmitTutorialEvent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitTutorialEvent._execute_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmitTutorialEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitTutorialEvent._execute_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001AB0 RID: 6832
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001AB1 RID: 6833
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001AB2 RID: 6834
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001AB3 RID: 6835
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001AB4 RID: 6836
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001AB5 RID: 6837
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001AB6 RID: 6838
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001AB7 RID: 6839
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001AB8 RID: 6840
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001AB9 RID: 6841
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001ABA RID: 6842
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001ABB RID: 6843
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
