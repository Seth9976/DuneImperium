using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.context;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.actions.RiseOfIx
{
	// Token: 0x020002AD RID: 685
	public class AddImperiumToBottom : global::Canis.actions.Action
	{
		// Token: 0x06001C47 RID: 7239 RVA: 0x000C6C68 File Offset: 0x000C4E68
		// Note: this type is marked as 'beforefieldinit'.
		static AddImperiumToBottom()
		{
			Il2CppClassPointerStore<AddImperiumToBottom>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.RiseOfIx", "AddImperiumToBottom");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddImperiumToBottom>.NativeClassPtr);
			AddImperiumToBottom.NativeFieldInfoPtr_archetypeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddImperiumToBottom>.NativeClassPtr, "archetypeID");
			AddImperiumToBottom.NativeMethodInfoPtr__ctor_Public_Void_ArchetypeID_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddImperiumToBottom>.NativeClassPtr, 100669098);
			AddImperiumToBottom.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddImperiumToBottom>.NativeClassPtr, 100669099);
			AddImperiumToBottom.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddImperiumToBottom>.NativeClassPtr, 100669100);
			AddImperiumToBottom.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddImperiumToBottom>.NativeClassPtr, 100669101);
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x000C6CFC File Offset: 0x000C4EFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 150847, RefRangeEnd = 150848, XrefRangeStart = 150835, XrefRangeEnd = 150847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddImperiumToBottom(ArchetypeID archetypeID, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddImperiumToBottom>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archetypeID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddImperiumToBottom.NativeMethodInfoPtr__ctor_Public_Void_ArchetypeID_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x000C6D5C File Offset: 0x000C4F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150848, XrefRangeEnd = 150854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddImperiumToBottom.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x000C6DA8 File Offset: 0x000C4FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150854, XrefRangeEnd = 150860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> undo(Context undoContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddImperiumToBottom.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x000C6E04 File Offset: 0x000C5004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150860, XrefRangeEnd = 150865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddImperiumToBottom.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x0000BFDF File Offset: 0x0000A1DF
		public AddImperiumToBottom(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06001C4D RID: 7245 RVA: 0x000C6E60 File Offset: 0x000C5060
		// (set) Token: 0x06001C4E RID: 7246 RVA: 0x0000BFE8 File Offset: 0x0000A1E8
		public unsafe ArchetypeID archetypeID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom.NativeFieldInfoPtr_archetypeID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom.NativeFieldInfoPtr_archetypeID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001173 RID: 4467
		private static readonly IntPtr NativeFieldInfoPtr_archetypeID;

		// Token: 0x04001174 RID: 4468
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ArchetypeID_Match_0;

		// Token: 0x04001175 RID: 4469
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04001176 RID: 4470
		private static readonly IntPtr NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0;

		// Token: 0x04001177 RID: 4471
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x020006FD RID: 1789
		[ObfuscatedName("worm.canis.actions.RiseOfIx.AddImperiumToBottom+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x06006134 RID: 24884 RVA: 0x001DBC80 File Offset: 0x001D9E80
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<AddImperiumToBottom._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddImperiumToBottom>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddImperiumToBottom._execute_d__2>.NativeClassPtr);
				AddImperiumToBottom._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddImperiumToBottom._execute_d__2>.NativeClassPtr, "<>1__state");
				AddImperiumToBottom._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddImperiumToBottom._execute_d__2>.NativeClassPtr, "<>2__current");
				AddImperiumToBottom._execute_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddImperiumToBottom._execute_d__2>.NativeClassPtr, "<>l__initialThreadId");
				AddImperiumToBottom._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddImperiumToBottom._execute_d__2>.NativeClassPtr, "<>4__this");
				AddImperiumToBottom._execute_d__2.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddImperiumToBottom._execute_d__2>.NativeClassPtr, "<player>5__2");
				AddImperiumToBottom._execute_d__2.NativeFieldInfoPtr__wormMatch_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddImperiumToBottom._execute_d__2>.NativeClassPtr, "<wormMatch>5__3");
				AddImperiumToBottom._execute_d__2.NativeFieldInfoPtr__copy_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddImperiumToBottom._execute_d__2>.NativeClassPtr, "<copy>5__4");
				AddImperiumToBottom._execute_d__2.NativeFieldInfoPtr__sequenceHelper_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddImperiumToBottom._execute_d__2>.NativeClassPtr, "<sequenceHelper>5__5");
				AddImperiumToBottom._execute_d__2.NativeFieldInfoPtr___7__wrap5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddImperiumToBottom._execute_d__2>.NativeClassPtr, "<>7__wrap5");
				AddImperiumToBottom._execute_d__2.NativeFieldInfoPtr__actionContext_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddImperiumToBottom._execute_d__2>.NativeClassPtr, "<actionContext>5__7");
				AddImperiumToBottom._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddImperiumToBottom._execute_d__2>.NativeClassPtr, 100669102);
				AddImperiumToBottom._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddImperiumToBottom._execute_d__2>.NativeClassPtr, 100669103);
				AddImperiumToBottom._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddImperiumToBottom._execute_d__2>.NativeClassPtr, 100669104);
				AddImperiumToBottom._execute_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddImperiumToBottom._execute_d__2>.NativeClassPtr, 100669105);
				AddImperiumToBottom._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddImperiumToBottom._execute_d__2>.NativeClassPtr, 100669106);
				AddImperiumToBottom._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddImperiumToBottom._execute_d__2>.NativeClassPtr, 100669107);
				AddImperiumToBottom._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddImperiumToBottom._execute_d__2>.NativeClassPtr, 100669108);
				AddImperiumToBottom._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddImperiumToBottom._execute_d__2>.NativeClassPtr, 100669109);
				AddImperiumToBottom._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddImperiumToBottom._execute_d__2>.NativeClassPtr, 100669110);
			}

			// Token: 0x06006135 RID: 24885 RVA: 0x001DBE28 File Offset: 0x001DA028
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddImperiumToBottom._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddImperiumToBottom._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006136 RID: 24886 RVA: 0x001DBE70 File Offset: 0x001DA070
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150659, XrefRangeEnd = 150664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddImperiumToBottom._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006137 RID: 24887 RVA: 0x001DBEA4 File Offset: 0x001DA0A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150664, XrefRangeEnd = 150803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddImperiumToBottom._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006138 RID: 24888 RVA: 0x001DBEE0 File Offset: 0x001DA0E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150803, XrefRangeEnd = 150806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddImperiumToBottom._execute_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170019E1 RID: 6625
			// (get) Token: 0x06006139 RID: 24889 RVA: 0x001DBF14 File Offset: 0x001DA114
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddImperiumToBottom._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600613A RID: 24890 RVA: 0x001DBF54 File Offset: 0x001DA154
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150806, XrefRangeEnd = 150811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddImperiumToBottom._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170019E2 RID: 6626
			// (get) Token: 0x0600613B RID: 24891 RVA: 0x001DBF88 File Offset: 0x001DA188
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddImperiumToBottom._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600613C RID: 24892 RVA: 0x001DBFC8 File Offset: 0x001DA1C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150811, XrefRangeEnd = 150813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddImperiumToBottom._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600613D RID: 24893 RVA: 0x001DC008 File Offset: 0x001DA208
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddImperiumToBottom._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600613E RID: 24894 RVA: 0x000254B7 File Offset: 0x000236B7
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170019D7 RID: 6615
			// (get) Token: 0x0600613F RID: 24895 RVA: 0x001DC048 File Offset: 0x001DA248
			// (set) Token: 0x06006140 RID: 24896 RVA: 0x000254C0 File Offset: 0x000236C0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170019D8 RID: 6616
			// (get) Token: 0x06006141 RID: 24897 RVA: 0x001DC070 File Offset: 0x001DA270
			// (set) Token: 0x06006142 RID: 24898 RVA: 0x000254DB File Offset: 0x000236DB
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019D9 RID: 6617
			// (get) Token: 0x06006143 RID: 24899 RVA: 0x001DC0A0 File Offset: 0x001DA2A0
			// (set) Token: 0x06006144 RID: 24900 RVA: 0x000254FA File Offset: 0x000236FA
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom._execute_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom._execute_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170019DA RID: 6618
			// (get) Token: 0x06006145 RID: 24901 RVA: 0x001DC0C8 File Offset: 0x001DA2C8
			// (set) Token: 0x06006146 RID: 24902 RVA: 0x00025515 File Offset: 0x00023715
			public unsafe AddImperiumToBottom __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddImperiumToBottom>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019DB RID: 6619
			// (get) Token: 0x06006147 RID: 24903 RVA: 0x001DC0F8 File Offset: 0x001DA2F8
			// (set) Token: 0x06006148 RID: 24904 RVA: 0x00025534 File Offset: 0x00023734
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom._execute_d__2.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom._execute_d__2.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019DC RID: 6620
			// (get) Token: 0x06006149 RID: 24905 RVA: 0x001DC128 File Offset: 0x001DA328
			// (set) Token: 0x0600614A RID: 24906 RVA: 0x00025553 File Offset: 0x00023753
			public unsafe WormMatch _wormMatch_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom._execute_d__2.NativeFieldInfoPtr__wormMatch_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom._execute_d__2.NativeFieldInfoPtr__wormMatch_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019DD RID: 6621
			// (get) Token: 0x0600614B RID: 24907 RVA: 0x001DC158 File Offset: 0x001DA358
			// (set) Token: 0x0600614C RID: 24908 RVA: 0x00025572 File Offset: 0x00023772
			public unsafe Entity _copy_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom._execute_d__2.NativeFieldInfoPtr__copy_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom._execute_d__2.NativeFieldInfoPtr__copy_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019DE RID: 6622
			// (get) Token: 0x0600614D RID: 24909 RVA: 0x001DC188 File Offset: 0x001DA388
			// (set) Token: 0x0600614E RID: 24910 RVA: 0x00025591 File Offset: 0x00023791
			public unsafe SequenceHelper _sequenceHelper_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom._execute_d__2.NativeFieldInfoPtr__sequenceHelper_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom._execute_d__2.NativeFieldInfoPtr__sequenceHelper_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019DF RID: 6623
			// (get) Token: 0x0600614F RID: 24911 RVA: 0x001DC1B8 File Offset: 0x001DA3B8
			// (set) Token: 0x06006150 RID: 24912 RVA: 0x000255B0 File Offset: 0x000237B0
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom._execute_d__2.NativeFieldInfoPtr___7__wrap5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom._execute_d__2.NativeFieldInfoPtr___7__wrap5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019E0 RID: 6624
			// (get) Token: 0x06006151 RID: 24913 RVA: 0x001DC1E8 File Offset: 0x001DA3E8
			// (set) Token: 0x06006152 RID: 24914 RVA: 0x000255CF File Offset: 0x000237CF
			public unsafe Context _actionContext_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom._execute_d__2.NativeFieldInfoPtr__actionContext_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom._execute_d__2.NativeFieldInfoPtr__actionContext_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003F00 RID: 16128
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003F01 RID: 16129
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003F02 RID: 16130
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003F03 RID: 16131
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003F04 RID: 16132
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04003F05 RID: 16133
			private static readonly IntPtr NativeFieldInfoPtr__wormMatch_5__3;

			// Token: 0x04003F06 RID: 16134
			private static readonly IntPtr NativeFieldInfoPtr__copy_5__4;

			// Token: 0x04003F07 RID: 16135
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__5;

			// Token: 0x04003F08 RID: 16136
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap5;

			// Token: 0x04003F09 RID: 16137
			private static readonly IntPtr NativeFieldInfoPtr__actionContext_5__7;

			// Token: 0x04003F0A RID: 16138
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003F0B RID: 16139
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003F0C RID: 16140
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003F0D RID: 16141
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003F0E RID: 16142
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003F0F RID: 16143
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003F10 RID: 16144
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003F11 RID: 16145
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003F12 RID: 16146
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020006FE RID: 1790
		[ObfuscatedName("worm.canis.actions.RiseOfIx.AddImperiumToBottom+<undo>d__3")]
		public sealed class _undo_d__3 : Object
		{
			// Token: 0x06006153 RID: 24915 RVA: 0x001DC218 File Offset: 0x001DA418
			// Note: this type is marked as 'beforefieldinit'.
			static _undo_d__3()
			{
				Il2CppClassPointerStore<AddImperiumToBottom._undo_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddImperiumToBottom>.NativeClassPtr, "<undo>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddImperiumToBottom._undo_d__3>.NativeClassPtr);
				AddImperiumToBottom._undo_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddImperiumToBottom._undo_d__3>.NativeClassPtr, "<>1__state");
				AddImperiumToBottom._undo_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddImperiumToBottom._undo_d__3>.NativeClassPtr, "<>2__current");
				AddImperiumToBottom._undo_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddImperiumToBottom._undo_d__3>.NativeClassPtr, "<>l__initialThreadId");
				AddImperiumToBottom._undo_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddImperiumToBottom._undo_d__3>.NativeClassPtr, "<>4__this");
				AddImperiumToBottom._undo_d__3.NativeFieldInfoPtr__wormPlayer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddImperiumToBottom._undo_d__3>.NativeClassPtr, "<wormPlayer>5__2");
				AddImperiumToBottom._undo_d__3.NativeFieldInfoPtr__card_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddImperiumToBottom._undo_d__3>.NativeClassPtr, "<card>5__3");
				AddImperiumToBottom._undo_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddImperiumToBottom._undo_d__3>.NativeClassPtr, 100669111);
				AddImperiumToBottom._undo_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddImperiumToBottom._undo_d__3>.NativeClassPtr, 100669112);
				AddImperiumToBottom._undo_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddImperiumToBottom._undo_d__3>.NativeClassPtr, 100669113);
				AddImperiumToBottom._undo_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddImperiumToBottom._undo_d__3>.NativeClassPtr, 100669114);
				AddImperiumToBottom._undo_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddImperiumToBottom._undo_d__3>.NativeClassPtr, 100669115);
				AddImperiumToBottom._undo_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddImperiumToBottom._undo_d__3>.NativeClassPtr, 100669116);
				AddImperiumToBottom._undo_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddImperiumToBottom._undo_d__3>.NativeClassPtr, 100669117);
				AddImperiumToBottom._undo_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddImperiumToBottom._undo_d__3>.NativeClassPtr, 100669118);
			}

			// Token: 0x06006154 RID: 24916 RVA: 0x001DC35C File Offset: 0x001DA55C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _undo_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddImperiumToBottom._undo_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddImperiumToBottom._undo_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006155 RID: 24917 RVA: 0x001DC3A4 File Offset: 0x001DA5A4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddImperiumToBottom._undo_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006156 RID: 24918 RVA: 0x001DC3D8 File Offset: 0x001DA5D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150813, XrefRangeEnd = 150828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddImperiumToBottom._undo_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170019E9 RID: 6633
			// (get) Token: 0x06006157 RID: 24919 RVA: 0x001DC414 File Offset: 0x001DA614
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddImperiumToBottom._undo_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006158 RID: 24920 RVA: 0x001DC454 File Offset: 0x001DA654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150828, XrefRangeEnd = 150833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddImperiumToBottom._undo_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170019EA RID: 6634
			// (get) Token: 0x06006159 RID: 24921 RVA: 0x001DC488 File Offset: 0x001DA688
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddImperiumToBottom._undo_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600615A RID: 24922 RVA: 0x001DC4C8 File Offset: 0x001DA6C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150833, XrefRangeEnd = 150835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddImperiumToBottom._undo_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600615B RID: 24923 RVA: 0x001DC508 File Offset: 0x001DA708
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddImperiumToBottom._undo_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600615C RID: 24924 RVA: 0x000255EE File Offset: 0x000237EE
			public _undo_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170019E3 RID: 6627
			// (get) Token: 0x0600615D RID: 24925 RVA: 0x001DC548 File Offset: 0x001DA748
			// (set) Token: 0x0600615E RID: 24926 RVA: 0x000255F7 File Offset: 0x000237F7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom._undo_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom._undo_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170019E4 RID: 6628
			// (get) Token: 0x0600615F RID: 24927 RVA: 0x001DC570 File Offset: 0x001DA770
			// (set) Token: 0x06006160 RID: 24928 RVA: 0x00025612 File Offset: 0x00023812
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom._undo_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom._undo_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019E5 RID: 6629
			// (get) Token: 0x06006161 RID: 24929 RVA: 0x001DC5A0 File Offset: 0x001DA7A0
			// (set) Token: 0x06006162 RID: 24930 RVA: 0x00025631 File Offset: 0x00023831
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom._undo_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom._undo_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170019E6 RID: 6630
			// (get) Token: 0x06006163 RID: 24931 RVA: 0x001DC5C8 File Offset: 0x001DA7C8
			// (set) Token: 0x06006164 RID: 24932 RVA: 0x0002564C File Offset: 0x0002384C
			public unsafe AddImperiumToBottom __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom._undo_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddImperiumToBottom>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom._undo_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019E7 RID: 6631
			// (get) Token: 0x06006165 RID: 24933 RVA: 0x001DC5F8 File Offset: 0x001DA7F8
			// (set) Token: 0x06006166 RID: 24934 RVA: 0x0002566B File Offset: 0x0002386B
			public unsafe WormPlayer _wormPlayer_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom._undo_d__3.NativeFieldInfoPtr__wormPlayer_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom._undo_d__3.NativeFieldInfoPtr__wormPlayer_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019E8 RID: 6632
			// (get) Token: 0x06006167 RID: 24935 RVA: 0x001DC628 File Offset: 0x001DA828
			// (set) Token: 0x06006168 RID: 24936 RVA: 0x0002568A File Offset: 0x0002388A
			public unsafe WormImperiumPlayable _card_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom._undo_d__3.NativeFieldInfoPtr__card_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddImperiumToBottom._undo_d__3.NativeFieldInfoPtr__card_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003F13 RID: 16147
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003F14 RID: 16148
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003F15 RID: 16149
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003F16 RID: 16150
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003F17 RID: 16151
			private static readonly IntPtr NativeFieldInfoPtr__wormPlayer_5__2;

			// Token: 0x04003F18 RID: 16152
			private static readonly IntPtr NativeFieldInfoPtr__card_5__3;

			// Token: 0x04003F19 RID: 16153
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003F1A RID: 16154
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003F1B RID: 16155
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003F1C RID: 16156
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003F1D RID: 16157
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003F1E RID: 16158
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003F1F RID: 16159
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003F20 RID: 16160
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
