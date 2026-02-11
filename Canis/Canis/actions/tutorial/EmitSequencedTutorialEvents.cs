using System;
using Canis.entities;
using Canis.tutorialScripts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions.tutorial
{
	// Token: 0x020001F9 RID: 505
	public class EmitSequencedTutorialEvents : Action
	{
		// Token: 0x06001562 RID: 5474 RVA: 0x0006FCA0 File Offset: 0x0006DEA0
		// Note: this type is marked as 'beforefieldinit'.
		static EmitSequencedTutorialEvents()
		{
			Il2CppClassPointerStore<EmitSequencedTutorialEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.tutorial", "EmitSequencedTutorialEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmitSequencedTutorialEvents>.NativeClassPtr);
			EmitSequencedTutorialEvents.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitSequencedTutorialEvents>.NativeClassPtr, "player");
			EmitSequencedTutorialEvents.NativeFieldInfoPtr_SequenceHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitSequencedTutorialEvents>.NativeClassPtr, "SequenceHelper");
			EmitSequencedTutorialEvents.NativeFieldInfoPtr_TutorialActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitSequencedTutorialEvents>.NativeClassPtr, "TutorialActions");
			EmitSequencedTutorialEvents.NativeMethodInfoPtr__ctor_Public_Void_SequenceHelper_IEnumerable_1_TutorialAction_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitSequencedTutorialEvents>.NativeClassPtr, 100668119);
			EmitSequencedTutorialEvents.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitSequencedTutorialEvents>.NativeClassPtr, 100668120);
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x0006FD34 File Offset: 0x0006DF34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 591231, RefRangeEnd = 591232, XrefRangeStart = 591223, XrefRangeEnd = 591231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmitSequencedTutorialEvents(SequenceHelper sequenceHelper, IEnumerable<TutorialAction> tutorialActions, PlayerEntity player = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmitSequencedTutorialEvents>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequenceHelper);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tutorialActions);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitSequencedTutorialEvents.NativeMethodInfoPtr__ctor_Public_Void_SequenceHelper_IEnumerable_1_TutorialAction_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x0006FDA4 File Offset: 0x0006DFA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591232, XrefRangeEnd = 591238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmitSequencedTutorialEvents.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x0000A4F6 File Offset: 0x000086F6
		public EmitSequencedTutorialEvents(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06001566 RID: 5478 RVA: 0x0006FDF0 File Offset: 0x0006DFF0
		// (set) Token: 0x06001567 RID: 5479 RVA: 0x0000A4FF File Offset: 0x000086FF
		public unsafe PlayerEntity player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitSequencedTutorialEvents.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitSequencedTutorialEvents.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06001568 RID: 5480 RVA: 0x0006FE20 File Offset: 0x0006E020
		// (set) Token: 0x06001569 RID: 5481 RVA: 0x0000A51E File Offset: 0x0000871E
		public unsafe SequenceHelper SequenceHelper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitSequencedTutorialEvents.NativeFieldInfoPtr_SequenceHelper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitSequencedTutorialEvents.NativeFieldInfoPtr_SequenceHelper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x0600156A RID: 5482 RVA: 0x0006FE50 File Offset: 0x0006E050
		// (set) Token: 0x0600156B RID: 5483 RVA: 0x0000A53D File Offset: 0x0000873D
		public unsafe Il2CppReferenceArray<TutorialAction> TutorialActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitSequencedTutorialEvents.NativeFieldInfoPtr_TutorialActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TutorialAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitSequencedTutorialEvents.NativeFieldInfoPtr_TutorialActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DD7 RID: 3543
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04000DD8 RID: 3544
		private static readonly IntPtr NativeFieldInfoPtr_SequenceHelper;

		// Token: 0x04000DD9 RID: 3545
		private static readonly IntPtr NativeFieldInfoPtr_TutorialActions;

		// Token: 0x04000DDA RID: 3546
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceHelper_IEnumerable_1_TutorialAction_PlayerEntity_0;

		// Token: 0x04000DDB RID: 3547
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x02000445 RID: 1093
		[ObfuscatedName("Canis.actions.tutorial.EmitSequencedTutorialEvents+<execute>d__4")]
		public sealed class _execute_d__4 : Object
		{
			// Token: 0x0600301B RID: 12315 RVA: 0x000C831C File Offset: 0x000C651C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__4()
			{
				Il2CppClassPointerStore<EmitSequencedTutorialEvents._execute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EmitSequencedTutorialEvents>.NativeClassPtr, "<execute>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmitSequencedTutorialEvents._execute_d__4>.NativeClassPtr);
				EmitSequencedTutorialEvents._execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitSequencedTutorialEvents._execute_d__4>.NativeClassPtr, "<>1__state");
				EmitSequencedTutorialEvents._execute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitSequencedTutorialEvents._execute_d__4>.NativeClassPtr, "<>2__current");
				EmitSequencedTutorialEvents._execute_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitSequencedTutorialEvents._execute_d__4>.NativeClassPtr, "<>l__initialThreadId");
				EmitSequencedTutorialEvents._execute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitSequencedTutorialEvents._execute_d__4>.NativeClassPtr, "<>4__this");
				EmitSequencedTutorialEvents._execute_d__4.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitSequencedTutorialEvents._execute_d__4>.NativeClassPtr, "<>7__wrap1");
				EmitSequencedTutorialEvents._execute_d__4.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitSequencedTutorialEvents._execute_d__4>.NativeClassPtr, "<>7__wrap2");
				EmitSequencedTutorialEvents._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitSequencedTutorialEvents._execute_d__4>.NativeClassPtr, 100668121);
				EmitSequencedTutorialEvents._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitSequencedTutorialEvents._execute_d__4>.NativeClassPtr, 100668122);
				EmitSequencedTutorialEvents._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitSequencedTutorialEvents._execute_d__4>.NativeClassPtr, 100668123);
				EmitSequencedTutorialEvents._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitSequencedTutorialEvents._execute_d__4>.NativeClassPtr, 100668124);
				EmitSequencedTutorialEvents._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitSequencedTutorialEvents._execute_d__4>.NativeClassPtr, 100668125);
				EmitSequencedTutorialEvents._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitSequencedTutorialEvents._execute_d__4>.NativeClassPtr, 100668126);
				EmitSequencedTutorialEvents._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitSequencedTutorialEvents._execute_d__4>.NativeClassPtr, 100668127);
				EmitSequencedTutorialEvents._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitSequencedTutorialEvents._execute_d__4>.NativeClassPtr, 100668128);
			}

			// Token: 0x0600301C RID: 12316 RVA: 0x000C8460 File Offset: 0x000C6660
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmitSequencedTutorialEvents._execute_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitSequencedTutorialEvents._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600301D RID: 12317 RVA: 0x000C84A8 File Offset: 0x000C66A8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitSequencedTutorialEvents._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600301E RID: 12318 RVA: 0x000C84DC File Offset: 0x000C66DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591161, XrefRangeEnd = 591216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitSequencedTutorialEvents._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000C98 RID: 3224
			// (get) Token: 0x0600301F RID: 12319 RVA: 0x000C8518 File Offset: 0x000C6718
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitSequencedTutorialEvents._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06003020 RID: 12320 RVA: 0x000C8558 File Offset: 0x000C6758
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591216, XrefRangeEnd = 591221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitSequencedTutorialEvents._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C99 RID: 3225
			// (get) Token: 0x06003021 RID: 12321 RVA: 0x000C858C File Offset: 0x000C678C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitSequencedTutorialEvents._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003022 RID: 12322 RVA: 0x000C85CC File Offset: 0x000C67CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591221, XrefRangeEnd = 591223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitSequencedTutorialEvents._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06003023 RID: 12323 RVA: 0x000C860C File Offset: 0x000C680C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitSequencedTutorialEvents._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06003024 RID: 12324 RVA: 0x00016F95 File Offset: 0x00015195
			public _execute_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C92 RID: 3218
			// (get) Token: 0x06003025 RID: 12325 RVA: 0x000C864C File Offset: 0x000C684C
			// (set) Token: 0x06003026 RID: 12326 RVA: 0x00016F9E File Offset: 0x0001519E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitSequencedTutorialEvents._execute_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitSequencedTutorialEvents._execute_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C93 RID: 3219
			// (get) Token: 0x06003027 RID: 12327 RVA: 0x000C8674 File Offset: 0x000C6874
			// (set) Token: 0x06003028 RID: 12328 RVA: 0x00016FB9 File Offset: 0x000151B9
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitSequencedTutorialEvents._execute_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitSequencedTutorialEvents._execute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C94 RID: 3220
			// (get) Token: 0x06003029 RID: 12329 RVA: 0x000C86A4 File Offset: 0x000C68A4
			// (set) Token: 0x0600302A RID: 12330 RVA: 0x00016FD8 File Offset: 0x000151D8
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitSequencedTutorialEvents._execute_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitSequencedTutorialEvents._execute_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000C95 RID: 3221
			// (get) Token: 0x0600302B RID: 12331 RVA: 0x000C86CC File Offset: 0x000C68CC
			// (set) Token: 0x0600302C RID: 12332 RVA: 0x00016FF3 File Offset: 0x000151F3
			public unsafe EmitSequencedTutorialEvents __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitSequencedTutorialEvents._execute_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmitSequencedTutorialEvents>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitSequencedTutorialEvents._execute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C96 RID: 3222
			// (get) Token: 0x0600302D RID: 12333 RVA: 0x000C86FC File Offset: 0x000C68FC
			// (set) Token: 0x0600302E RID: 12334 RVA: 0x00017012 File Offset: 0x00015212
			public unsafe Il2CppReferenceArray<TutorialAction> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitSequencedTutorialEvents._execute_d__4.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TutorialAction>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitSequencedTutorialEvents._execute_d__4.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C97 RID: 3223
			// (get) Token: 0x0600302F RID: 12335 RVA: 0x000C872C File Offset: 0x000C692C
			// (set) Token: 0x06003030 RID: 12336 RVA: 0x00017031 File Offset: 0x00015231
			public unsafe int __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitSequencedTutorialEvents._execute_d__4.NativeFieldInfoPtr___7__wrap2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitSequencedTutorialEvents._execute_d__4.NativeFieldInfoPtr___7__wrap2)) = value;
				}
			}

			// Token: 0x04001E17 RID: 7703
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001E18 RID: 7704
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001E19 RID: 7705
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001E1A RID: 7706
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001E1B RID: 7707
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001E1C RID: 7708
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04001E1D RID: 7709
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001E1E RID: 7710
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001E1F RID: 7711
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001E20 RID: 7712
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001E21 RID: 7713
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001E22 RID: 7714
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001E23 RID: 7715
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001E24 RID: 7716
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
