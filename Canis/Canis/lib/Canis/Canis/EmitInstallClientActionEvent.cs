using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.entities;
using Canis.tutorialScripts;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Networking.clientevents;

namespace lib.canis.Canis
{
	// Token: 0x02000018 RID: 24
	public class EmitInstallClientActionEvent : global::Canis.actions.Action
	{
		// Token: 0x060000DD RID: 221 RVA: 0x0001C8DC File Offset: 0x0001AADC
		// Note: this type is marked as 'beforefieldinit'.
		static EmitInstallClientActionEvent()
		{
			Il2CppClassPointerStore<EmitInstallClientActionEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "lib.canis.Canis", "EmitInstallClientActionEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmitInstallClientActionEvent>.NativeClassPtr);
			EmitInstallClientActionEvent.NativeFieldInfoPtr_tutorialActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitInstallClientActionEvent>.NativeClassPtr, "tutorialActions");
			EmitInstallClientActionEvent.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitInstallClientActionEvent>.NativeClassPtr, "player");
			EmitInstallClientActionEvent.NativeFieldInfoPtr_clientEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitInstallClientActionEvent>.NativeClassPtr, "clientEvent");
			EmitInstallClientActionEvent.NativeFieldInfoPtr_responseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitInstallClientActionEvent>.NativeClassPtr, "responseID");
			EmitInstallClientActionEvent.NativeMethodInfoPtr__ctor_Public_Void_Match_TutorialAction_ClientEvent_ClientEventResponseID_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitInstallClientActionEvent>.NativeClassPtr, 100663423);
			EmitInstallClientActionEvent.NativeMethodInfoPtr__ctor_Public_Void_Match_List_1_TutorialAction_ClientEvent_ClientEventResponseID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitInstallClientActionEvent>.NativeClassPtr, 100663424);
			EmitInstallClientActionEvent.NativeMethodInfoPtr__ctor_Public_Void_SerializedEmitInstallClientActionEvent_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitInstallClientActionEvent>.NativeClassPtr, 100663425);
			EmitInstallClientActionEvent.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitInstallClientActionEvent>.NativeClassPtr, 100663426);
			EmitInstallClientActionEvent.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitInstallClientActionEvent>.NativeClassPtr, 100663427);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0001C9C0 File Offset: 0x0001ABC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543893, XrefRangeEnd = 543907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmitInstallClientActionEvent(Match m, TutorialAction ta, ClientEvent clientEvent, ClientEventResponseID responseID, PlayerEntity player = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmitInstallClientActionEvent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ta);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clientEvent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responseID);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitInstallClientActionEvent.NativeMethodInfoPtr__ctor_Public_Void_Match_TutorialAction_ClientEvent_ClientEventResponseID_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0001CA58 File Offset: 0x0001AC58
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 543911, RefRangeEnd = 543915, XrefRangeStart = 543907, XrefRangeEnd = 543911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmitInstallClientActionEvent(Match m, List<TutorialAction> tas, ClientEvent clientEvent, ClientEventResponseID responseID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmitInstallClientActionEvent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tas);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clientEvent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responseID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitInstallClientActionEvent.NativeMethodInfoPtr__ctor_Public_Void_Match_List_1_TutorialAction_ClientEvent_ClientEventResponseID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0001CADC File Offset: 0x0001ACDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543915, XrefRangeEnd = 543929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmitInstallClientActionEvent(SerializedEmitInstallClientActionEvent serialized, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmitInstallClientActionEvent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitInstallClientActionEvent.NativeMethodInfoPtr__ctor_Public_Void_SerializedEmitInstallClientActionEvent_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0001CB3C File Offset: 0x0001AD3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543929, XrefRangeEnd = 543935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmitInstallClientActionEvent.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0001CB88 File Offset: 0x0001AD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543935, XrefRangeEnd = 543943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmitInstallClientActionEvent.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000026E8 File Offset: 0x000008E8
		public EmitInstallClientActionEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x0001CBE4 File Offset: 0x0001ADE4
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x000026F1 File Offset: 0x000008F1
		public unsafe List<TutorialAction> tutorialActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitInstallClientActionEvent.NativeFieldInfoPtr_tutorialActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TutorialAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitInstallClientActionEvent.NativeFieldInfoPtr_tutorialActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x0001CC14 File Offset: 0x0001AE14
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x00002710 File Offset: 0x00000910
		public unsafe PlayerEntity player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitInstallClientActionEvent.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitInstallClientActionEvent.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x0001CC44 File Offset: 0x0001AE44
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x0000272F File Offset: 0x0000092F
		public unsafe ClientEvent clientEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitInstallClientActionEvent.NativeFieldInfoPtr_clientEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitInstallClientActionEvent.NativeFieldInfoPtr_clientEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000EA RID: 234 RVA: 0x0001CC74 File Offset: 0x0001AE74
		// (set) Token: 0x060000EB RID: 235 RVA: 0x0000274E File Offset: 0x0000094E
		public unsafe ClientEventResponseID responseID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitInstallClientActionEvent.NativeFieldInfoPtr_responseID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitInstallClientActionEvent.NativeFieldInfoPtr_responseID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeFieldInfoPtr_tutorialActions;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeFieldInfoPtr_clientEvent;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeFieldInfoPtr_responseID;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_TutorialAction_ClientEvent_ClientEventResponseID_PlayerEntity_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_List_1_TutorialAction_ClientEvent_ClientEventResponseID_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEmitInstallClientActionEvent_Match_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x02000240 RID: 576
		[ObfuscatedName("lib.canis.Canis.EmitInstallClientActionEvent+<execute>d__7")]
		public sealed class _execute_d__7 : Object
		{
			// Token: 0x0600183D RID: 6205 RVA: 0x00079D14 File Offset: 0x00077F14
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__7()
			{
				Il2CppClassPointerStore<EmitInstallClientActionEvent._execute_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EmitInstallClientActionEvent>.NativeClassPtr, "<execute>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmitInstallClientActionEvent._execute_d__7>.NativeClassPtr);
				EmitInstallClientActionEvent._execute_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitInstallClientActionEvent._execute_d__7>.NativeClassPtr, "<>1__state");
				EmitInstallClientActionEvent._execute_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitInstallClientActionEvent._execute_d__7>.NativeClassPtr, "<>2__current");
				EmitInstallClientActionEvent._execute_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitInstallClientActionEvent._execute_d__7>.NativeClassPtr, "<>l__initialThreadId");
				EmitInstallClientActionEvent._execute_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitInstallClientActionEvent._execute_d__7>.NativeClassPtr, "<>4__this");
				EmitInstallClientActionEvent._execute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitInstallClientActionEvent._execute_d__7>.NativeClassPtr, 100663428);
				EmitInstallClientActionEvent._execute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitInstallClientActionEvent._execute_d__7>.NativeClassPtr, 100663429);
				EmitInstallClientActionEvent._execute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitInstallClientActionEvent._execute_d__7>.NativeClassPtr, 100663430);
				EmitInstallClientActionEvent._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitInstallClientActionEvent._execute_d__7>.NativeClassPtr, 100663431);
				EmitInstallClientActionEvent._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitInstallClientActionEvent._execute_d__7>.NativeClassPtr, 100663432);
				EmitInstallClientActionEvent._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitInstallClientActionEvent._execute_d__7>.NativeClassPtr, 100663433);
				EmitInstallClientActionEvent._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitInstallClientActionEvent._execute_d__7>.NativeClassPtr, 100663434);
				EmitInstallClientActionEvent._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitInstallClientActionEvent._execute_d__7>.NativeClassPtr, 100663435);
			}

			// Token: 0x0600183E RID: 6206 RVA: 0x00079E30 File Offset: 0x00078030
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmitInstallClientActionEvent._execute_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitInstallClientActionEvent._execute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600183F RID: 6207 RVA: 0x00079E78 File Offset: 0x00078078
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitInstallClientActionEvent._execute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001840 RID: 6208 RVA: 0x00079EAC File Offset: 0x000780AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543834, XrefRangeEnd = 543886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitInstallClientActionEvent._execute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000550 RID: 1360
			// (get) Token: 0x06001841 RID: 6209 RVA: 0x00079EE8 File Offset: 0x000780E8
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitInstallClientActionEvent._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06001842 RID: 6210 RVA: 0x00079F28 File Offset: 0x00078128
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543886, XrefRangeEnd = 543891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitInstallClientActionEvent._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000551 RID: 1361
			// (get) Token: 0x06001843 RID: 6211 RVA: 0x00079F5C File Offset: 0x0007815C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitInstallClientActionEvent._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001844 RID: 6212 RVA: 0x00079F9C File Offset: 0x0007819C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543891, XrefRangeEnd = 543893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitInstallClientActionEvent._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06001845 RID: 6213 RVA: 0x00079FDC File Offset: 0x000781DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitInstallClientActionEvent._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001846 RID: 6214 RVA: 0x0000B9B9 File Offset: 0x00009BB9
			public _execute_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700054C RID: 1356
			// (get) Token: 0x06001847 RID: 6215 RVA: 0x0007A01C File Offset: 0x0007821C
			// (set) Token: 0x06001848 RID: 6216 RVA: 0x0000B9C2 File Offset: 0x00009BC2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitInstallClientActionEvent._execute_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitInstallClientActionEvent._execute_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700054D RID: 1357
			// (get) Token: 0x06001849 RID: 6217 RVA: 0x0007A044 File Offset: 0x00078244
			// (set) Token: 0x0600184A RID: 6218 RVA: 0x0000B9DD File Offset: 0x00009BDD
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitInstallClientActionEvent._execute_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitInstallClientActionEvent._execute_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700054E RID: 1358
			// (get) Token: 0x0600184B RID: 6219 RVA: 0x0007A074 File Offset: 0x00078274
			// (set) Token: 0x0600184C RID: 6220 RVA: 0x0000B9FC File Offset: 0x00009BFC
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitInstallClientActionEvent._execute_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitInstallClientActionEvent._execute_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700054F RID: 1359
			// (get) Token: 0x0600184D RID: 6221 RVA: 0x0007A09C File Offset: 0x0007829C
			// (set) Token: 0x0600184E RID: 6222 RVA: 0x0000BA17 File Offset: 0x00009C17
			public unsafe EmitInstallClientActionEvent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitInstallClientActionEvent._execute_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmitInstallClientActionEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitInstallClientActionEvent._execute_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000F83 RID: 3971
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000F84 RID: 3972
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000F85 RID: 3973
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000F86 RID: 3974
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000F87 RID: 3975
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000F88 RID: 3976
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F89 RID: 3977
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000F8A RID: 3978
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04000F8B RID: 3979
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F8C RID: 3980
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000F8D RID: 3981
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04000F8E RID: 3982
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
