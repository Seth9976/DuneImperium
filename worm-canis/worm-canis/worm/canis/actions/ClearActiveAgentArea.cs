using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.context;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.actions
{
	// Token: 0x0200022E RID: 558
	public class ClearActiveAgentArea : global::Canis.actions.Action
	{
		// Token: 0x0600188A RID: 6282 RVA: 0x000B8640 File Offset: 0x000B6840
		// Note: this type is marked as 'beforefieldinit'.
		static ClearActiveAgentArea()
		{
			Il2CppClassPointerStore<ClearActiveAgentArea>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "ClearActiveAgentArea");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClearActiveAgentArea>.NativeClassPtr);
			ClearActiveAgentArea.NativeMethodInfoPtr__ctor_Public_Void_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearActiveAgentArea>.NativeClassPtr, 100667516);
			ClearActiveAgentArea.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearActiveAgentArea>.NativeClassPtr, 100667517);
			ClearActiveAgentArea.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearActiveAgentArea>.NativeClassPtr, 100667518);
			ClearActiveAgentArea.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearActiveAgentArea>.NativeClassPtr, 100667519);
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x000B86C0 File Offset: 0x000B68C0
		[CallerCount(191)]
		[CachedScanResults(RefRangeStart = 51381, RefRangeEnd = 51572, XrefRangeStart = 51381, XrefRangeEnd = 51572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClearActiveAgentArea(Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClearActiveAgentArea>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearActiveAgentArea.NativeMethodInfoPtr__ctor_Public_Void_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x000B870C File Offset: 0x000B690C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132387, XrefRangeEnd = 132393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClearActiveAgentArea.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x000B8758 File Offset: 0x000B6958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132393, XrefRangeEnd = 132400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> undo(Context undoContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClearActiveAgentArea.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x000B87B4 File Offset: 0x000B69B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132400, XrefRangeEnd = 132404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClearActiveAgentArea.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x0000A9CD File Offset: 0x00008BCD
		public ClearActiveAgentArea(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F2E RID: 3886
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_0;

		// Token: 0x04000F2F RID: 3887
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04000F30 RID: 3888
		private static readonly IntPtr NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0;

		// Token: 0x04000F31 RID: 3889
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x0200065B RID: 1627
		[ObfuscatedName("worm.canis.actions.ClearActiveAgentArea+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060052D6 RID: 21206 RVA: 0x001B1B78 File Offset: 0x001AFD78
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ClearActiveAgentArea.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClearActiveAgentArea>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClearActiveAgentArea.__c>.NativeClassPtr);
				ClearActiveAgentArea.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearActiveAgentArea.__c>.NativeClassPtr, "<>9");
				ClearActiveAgentArea.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearActiveAgentArea.__c>.NativeClassPtr, "<>9__1_0");
				ClearActiveAgentArea.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearActiveAgentArea.__c>.NativeClassPtr, 100667521);
				ClearActiveAgentArea.__c.NativeMethodInfoPtr__execute_b__1_0_Internal_EntityID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearActiveAgentArea.__c>.NativeClassPtr, 100667522);
			}

			// Token: 0x060052D7 RID: 21207 RVA: 0x001B1BF4 File Offset: 0x001AFDF4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClearActiveAgentArea.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearActiveAgentArea.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052D8 RID: 21208 RVA: 0x001B1C30 File Offset: 0x001AFE30
			[CallerCount(0)]
			public unsafe EntityID _execute_b__1_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearActiveAgentArea.__c.NativeMethodInfoPtr__execute_b__1_0_Internal_EntityID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x060052D9 RID: 21209 RVA: 0x0001CEE7 File Offset: 0x0001B0E7
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700148A RID: 5258
			// (get) Token: 0x060052DA RID: 21210 RVA: 0x001B1C80 File Offset: 0x001AFE80
			// (set) Token: 0x060052DB RID: 21211 RVA: 0x0001CEF0 File Offset: 0x0001B0F0
			public unsafe static ClearActiveAgentArea.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ClearActiveAgentArea.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClearActiveAgentArea.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ClearActiveAgentArea.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700148B RID: 5259
			// (get) Token: 0x060052DC RID: 21212 RVA: 0x001B1CA8 File Offset: 0x001AFEA8
			// (set) Token: 0x060052DD RID: 21213 RVA: 0x0001CF02 File Offset: 0x0001B102
			public unsafe static Func<Entity, EntityID> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ClearActiveAgentArea.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ClearActiveAgentArea.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003641 RID: 13889
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003642 RID: 13890
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04003643 RID: 13891
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003644 RID: 13892
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__1_0_Internal_EntityID_Entity_0;
		}

		// Token: 0x0200065C RID: 1628
		[ObfuscatedName("worm.canis.actions.ClearActiveAgentArea+<execute>d__1")]
		public sealed class _execute_d__1 : Object
		{
			// Token: 0x060052DE RID: 21214 RVA: 0x001B1CD0 File Offset: 0x001AFED0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__1()
			{
				Il2CppClassPointerStore<ClearActiveAgentArea._execute_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClearActiveAgentArea>.NativeClassPtr, "<execute>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClearActiveAgentArea._execute_d__1>.NativeClassPtr);
				ClearActiveAgentArea._execute_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearActiveAgentArea._execute_d__1>.NativeClassPtr, "<>1__state");
				ClearActiveAgentArea._execute_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearActiveAgentArea._execute_d__1>.NativeClassPtr, "<>2__current");
				ClearActiveAgentArea._execute_d__1.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearActiveAgentArea._execute_d__1>.NativeClassPtr, "<>l__initialThreadId");
				ClearActiveAgentArea._execute_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearActiveAgentArea._execute_d__1>.NativeClassPtr, "<>4__this");
				ClearActiveAgentArea._execute_d__1.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearActiveAgentArea._execute_d__1>.NativeClassPtr, "<player>5__2");
				ClearActiveAgentArea._execute_d__1.NativeFieldInfoPtr__wormMatch_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearActiveAgentArea._execute_d__1>.NativeClassPtr, "<wormMatch>5__3");
				ClearActiveAgentArea._execute_d__1.NativeFieldInfoPtr__targets_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearActiveAgentArea._execute_d__1>.NativeClassPtr, "<targets>5__4");
				ClearActiveAgentArea._execute_d__1.NativeFieldInfoPtr__childUndo_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearActiveAgentArea._execute_d__1>.NativeClassPtr, "<childUndo>5__5");
				ClearActiveAgentArea._execute_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearActiveAgentArea._execute_d__1>.NativeClassPtr, 100667523);
				ClearActiveAgentArea._execute_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearActiveAgentArea._execute_d__1>.NativeClassPtr, 100667524);
				ClearActiveAgentArea._execute_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearActiveAgentArea._execute_d__1>.NativeClassPtr, 100667525);
				ClearActiveAgentArea._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearActiveAgentArea._execute_d__1>.NativeClassPtr, 100667526);
				ClearActiveAgentArea._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearActiveAgentArea._execute_d__1>.NativeClassPtr, 100667527);
				ClearActiveAgentArea._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearActiveAgentArea._execute_d__1>.NativeClassPtr, 100667528);
				ClearActiveAgentArea._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearActiveAgentArea._execute_d__1>.NativeClassPtr, 100667529);
				ClearActiveAgentArea._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearActiveAgentArea._execute_d__1>.NativeClassPtr, 100667530);
			}

			// Token: 0x060052DF RID: 21215 RVA: 0x001B1E3C File Offset: 0x001B003C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClearActiveAgentArea._execute_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearActiveAgentArea._execute_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060052E0 RID: 21216 RVA: 0x001B1E84 File Offset: 0x001B0084
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearActiveAgentArea._execute_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052E1 RID: 21217 RVA: 0x001B1EB8 File Offset: 0x001B00B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132290, XrefRangeEnd = 132330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearActiveAgentArea._execute_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001494 RID: 5268
			// (get) Token: 0x060052E2 RID: 21218 RVA: 0x001B1EF4 File Offset: 0x001B00F4
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearActiveAgentArea._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060052E3 RID: 21219 RVA: 0x001B1F34 File Offset: 0x001B0134
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132330, XrefRangeEnd = 132335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearActiveAgentArea._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001495 RID: 5269
			// (get) Token: 0x060052E4 RID: 21220 RVA: 0x001B1F68 File Offset: 0x001B0168
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearActiveAgentArea._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060052E5 RID: 21221 RVA: 0x001B1FA8 File Offset: 0x001B01A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132335, XrefRangeEnd = 132337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearActiveAgentArea._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060052E6 RID: 21222 RVA: 0x001B1FE8 File Offset: 0x001B01E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearActiveAgentArea._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060052E7 RID: 21223 RVA: 0x0001CF14 File Offset: 0x0001B114
			public _execute_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700148C RID: 5260
			// (get) Token: 0x060052E8 RID: 21224 RVA: 0x001B2028 File Offset: 0x001B0228
			// (set) Token: 0x060052E9 RID: 21225 RVA: 0x0001CF1D File Offset: 0x0001B11D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearActiveAgentArea._execute_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearActiveAgentArea._execute_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700148D RID: 5261
			// (get) Token: 0x060052EA RID: 21226 RVA: 0x001B2050 File Offset: 0x001B0250
			// (set) Token: 0x060052EB RID: 21227 RVA: 0x0001CF38 File Offset: 0x0001B138
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearActiveAgentArea._execute_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearActiveAgentArea._execute_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700148E RID: 5262
			// (get) Token: 0x060052EC RID: 21228 RVA: 0x001B2080 File Offset: 0x001B0280
			// (set) Token: 0x060052ED RID: 21229 RVA: 0x0001CF57 File Offset: 0x0001B157
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearActiveAgentArea._execute_d__1.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearActiveAgentArea._execute_d__1.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700148F RID: 5263
			// (get) Token: 0x060052EE RID: 21230 RVA: 0x001B20A8 File Offset: 0x001B02A8
			// (set) Token: 0x060052EF RID: 21231 RVA: 0x0001CF72 File Offset: 0x0001B172
			public unsafe ClearActiveAgentArea __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearActiveAgentArea._execute_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClearActiveAgentArea>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearActiveAgentArea._execute_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001490 RID: 5264
			// (get) Token: 0x060052F0 RID: 21232 RVA: 0x001B20D8 File Offset: 0x001B02D8
			// (set) Token: 0x060052F1 RID: 21233 RVA: 0x0001CF91 File Offset: 0x0001B191
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearActiveAgentArea._execute_d__1.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearActiveAgentArea._execute_d__1.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001491 RID: 5265
			// (get) Token: 0x060052F2 RID: 21234 RVA: 0x001B2108 File Offset: 0x001B0308
			// (set) Token: 0x060052F3 RID: 21235 RVA: 0x0001CFB0 File Offset: 0x0001B1B0
			public unsafe WormMatch _wormMatch_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearActiveAgentArea._execute_d__1.NativeFieldInfoPtr__wormMatch_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearActiveAgentArea._execute_d__1.NativeFieldInfoPtr__wormMatch_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001492 RID: 5266
			// (get) Token: 0x060052F4 RID: 21236 RVA: 0x001B2138 File Offset: 0x001B0338
			// (set) Token: 0x060052F5 RID: 21237 RVA: 0x0001CFCF File Offset: 0x0001B1CF
			public unsafe Il2CppReferenceArray<Entity> _targets_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearActiveAgentArea._execute_d__1.NativeFieldInfoPtr__targets_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearActiveAgentArea._execute_d__1.NativeFieldInfoPtr__targets_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001493 RID: 5267
			// (get) Token: 0x060052F6 RID: 21238 RVA: 0x001B2168 File Offset: 0x001B0368
			// (set) Token: 0x060052F7 RID: 21239 RVA: 0x0001CFEE File Offset: 0x0001B1EE
			public unsafe UndoNode _childUndo_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearActiveAgentArea._execute_d__1.NativeFieldInfoPtr__childUndo_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearActiveAgentArea._execute_d__1.NativeFieldInfoPtr__childUndo_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003645 RID: 13893
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003646 RID: 13894
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003647 RID: 13895
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003648 RID: 13896
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003649 RID: 13897
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x0400364A RID: 13898
			private static readonly IntPtr NativeFieldInfoPtr__wormMatch_5__3;

			// Token: 0x0400364B RID: 13899
			private static readonly IntPtr NativeFieldInfoPtr__targets_5__4;

			// Token: 0x0400364C RID: 13900
			private static readonly IntPtr NativeFieldInfoPtr__childUndo_5__5;

			// Token: 0x0400364D RID: 13901
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400364E RID: 13902
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400364F RID: 13903
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003650 RID: 13904
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003651 RID: 13905
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003652 RID: 13906
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003653 RID: 13907
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003654 RID: 13908
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200065D RID: 1629
		[ObfuscatedName("worm.canis.actions.ClearActiveAgentArea+<undo>d__2")]
		public sealed class _undo_d__2 : Object
		{
			// Token: 0x060052F8 RID: 21240 RVA: 0x001B2198 File Offset: 0x001B0398
			// Note: this type is marked as 'beforefieldinit'.
			static _undo_d__2()
			{
				Il2CppClassPointerStore<ClearActiveAgentArea._undo_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClearActiveAgentArea>.NativeClassPtr, "<undo>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClearActiveAgentArea._undo_d__2>.NativeClassPtr);
				ClearActiveAgentArea._undo_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearActiveAgentArea._undo_d__2>.NativeClassPtr, "<>1__state");
				ClearActiveAgentArea._undo_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearActiveAgentArea._undo_d__2>.NativeClassPtr, "<>2__current");
				ClearActiveAgentArea._undo_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearActiveAgentArea._undo_d__2>.NativeClassPtr, "<>l__initialThreadId");
				ClearActiveAgentArea._undo_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearActiveAgentArea._undo_d__2>.NativeClassPtr, "<>4__this");
				ClearActiveAgentArea._undo_d__2.NativeFieldInfoPtr_undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearActiveAgentArea._undo_d__2>.NativeClassPtr, "undoContext");
				ClearActiveAgentArea._undo_d__2.NativeFieldInfoPtr___3__undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearActiveAgentArea._undo_d__2>.NativeClassPtr, "<>3__undoContext");
				ClearActiveAgentArea._undo_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearActiveAgentArea._undo_d__2>.NativeClassPtr, 100667531);
				ClearActiveAgentArea._undo_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearActiveAgentArea._undo_d__2>.NativeClassPtr, 100667532);
				ClearActiveAgentArea._undo_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearActiveAgentArea._undo_d__2>.NativeClassPtr, 100667533);
				ClearActiveAgentArea._undo_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearActiveAgentArea._undo_d__2>.NativeClassPtr, 100667534);
				ClearActiveAgentArea._undo_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearActiveAgentArea._undo_d__2>.NativeClassPtr, 100667535);
				ClearActiveAgentArea._undo_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearActiveAgentArea._undo_d__2>.NativeClassPtr, 100667536);
				ClearActiveAgentArea._undo_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearActiveAgentArea._undo_d__2>.NativeClassPtr, 100667537);
				ClearActiveAgentArea._undo_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearActiveAgentArea._undo_d__2>.NativeClassPtr, 100667538);
			}

			// Token: 0x060052F9 RID: 21241 RVA: 0x001B22DC File Offset: 0x001B04DC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _undo_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClearActiveAgentArea._undo_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearActiveAgentArea._undo_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060052FA RID: 21242 RVA: 0x001B2324 File Offset: 0x001B0524
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearActiveAgentArea._undo_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052FB RID: 21243 RVA: 0x001B2358 File Offset: 0x001B0558
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132337, XrefRangeEnd = 132373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearActiveAgentArea._undo_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700149C RID: 5276
			// (get) Token: 0x060052FC RID: 21244 RVA: 0x001B2394 File Offset: 0x001B0594
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearActiveAgentArea._undo_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060052FD RID: 21245 RVA: 0x001B23D4 File Offset: 0x001B05D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132373, XrefRangeEnd = 132378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearActiveAgentArea._undo_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700149D RID: 5277
			// (get) Token: 0x060052FE RID: 21246 RVA: 0x001B2408 File Offset: 0x001B0608
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearActiveAgentArea._undo_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060052FF RID: 21247 RVA: 0x001B2448 File Offset: 0x001B0648
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132378, XrefRangeEnd = 132387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearActiveAgentArea._undo_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005300 RID: 21248 RVA: 0x001B2488 File Offset: 0x001B0688
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearActiveAgentArea._undo_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005301 RID: 21249 RVA: 0x0001D00D File Offset: 0x0001B20D
			public _undo_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001496 RID: 5270
			// (get) Token: 0x06005302 RID: 21250 RVA: 0x001B24C8 File Offset: 0x001B06C8
			// (set) Token: 0x06005303 RID: 21251 RVA: 0x0001D016 File Offset: 0x0001B216
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearActiveAgentArea._undo_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearActiveAgentArea._undo_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001497 RID: 5271
			// (get) Token: 0x06005304 RID: 21252 RVA: 0x001B24F0 File Offset: 0x001B06F0
			// (set) Token: 0x06005305 RID: 21253 RVA: 0x0001D031 File Offset: 0x0001B231
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearActiveAgentArea._undo_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearActiveAgentArea._undo_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001498 RID: 5272
			// (get) Token: 0x06005306 RID: 21254 RVA: 0x001B2520 File Offset: 0x001B0720
			// (set) Token: 0x06005307 RID: 21255 RVA: 0x0001D050 File Offset: 0x0001B250
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearActiveAgentArea._undo_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearActiveAgentArea._undo_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001499 RID: 5273
			// (get) Token: 0x06005308 RID: 21256 RVA: 0x001B2548 File Offset: 0x001B0748
			// (set) Token: 0x06005309 RID: 21257 RVA: 0x0001D06B File Offset: 0x0001B26B
			public unsafe ClearActiveAgentArea __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearActiveAgentArea._undo_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClearActiveAgentArea>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearActiveAgentArea._undo_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700149A RID: 5274
			// (get) Token: 0x0600530A RID: 21258 RVA: 0x001B2578 File Offset: 0x001B0778
			// (set) Token: 0x0600530B RID: 21259 RVA: 0x0001D08A File Offset: 0x0001B28A
			public unsafe Context undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearActiveAgentArea._undo_d__2.NativeFieldInfoPtr_undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearActiveAgentArea._undo_d__2.NativeFieldInfoPtr_undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700149B RID: 5275
			// (get) Token: 0x0600530C RID: 21260 RVA: 0x001B25A8 File Offset: 0x001B07A8
			// (set) Token: 0x0600530D RID: 21261 RVA: 0x0001D0A9 File Offset: 0x0001B2A9
			public unsafe Context __3__undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearActiveAgentArea._undo_d__2.NativeFieldInfoPtr___3__undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearActiveAgentArea._undo_d__2.NativeFieldInfoPtr___3__undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003655 RID: 13909
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003656 RID: 13910
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003657 RID: 13911
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003658 RID: 13912
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003659 RID: 13913
			private static readonly IntPtr NativeFieldInfoPtr_undoContext;

			// Token: 0x0400365A RID: 13914
			private static readonly IntPtr NativeFieldInfoPtr___3__undoContext;

			// Token: 0x0400365B RID: 13915
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400365C RID: 13916
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400365D RID: 13917
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400365E RID: 13918
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400365F RID: 13919
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003660 RID: 13920
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003661 RID: 13921
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003662 RID: 13922
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
