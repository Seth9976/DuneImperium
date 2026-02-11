using System;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions
{
	// Token: 0x020001D3 RID: 467
	public class RunFirstAbilityOfTarget : Action
	{
		// Token: 0x0600139E RID: 5022 RVA: 0x00068C10 File Offset: 0x00066E10
		// Note: this type is marked as 'beforefieldinit'.
		static RunFirstAbilityOfTarget()
		{
			Il2CppClassPointerStore<RunFirstAbilityOfTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "RunFirstAbilityOfTarget");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunFirstAbilityOfTarget>.NativeClassPtr);
			RunFirstAbilityOfTarget.NativeMethodInfoPtr__ctor_Public_Void_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFirstAbilityOfTarget>.NativeClassPtr, 100667571);
			RunFirstAbilityOfTarget.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFirstAbilityOfTarget>.NativeClassPtr, 100667572);
			RunFirstAbilityOfTarget.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFirstAbilityOfTarget>.NativeClassPtr, 100667573);
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x00068C7C File Offset: 0x00066E7C
		[CallerCount(191)]
		[CachedScanResults(RefRangeStart = 51381, RefRangeEnd = 51572, XrefRangeStart = 51381, XrefRangeEnd = 51572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunFirstAbilityOfTarget(Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunFirstAbilityOfTarget>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunFirstAbilityOfTarget.NativeMethodInfoPtr__ctor_Public_Void_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x00068CC8 File Offset: 0x00066EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587297, XrefRangeEnd = 587303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunFirstAbilityOfTarget.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x00068D14 File Offset: 0x00066F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587303, XrefRangeEnd = 587307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunFirstAbilityOfTarget.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x00009907 File Offset: 0x00007B07
		public RunFirstAbilityOfTarget(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CB7 RID: 3255
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_0;

		// Token: 0x04000CB8 RID: 3256
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04000CB9 RID: 3257
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x0200040B RID: 1035
		[ObfuscatedName("Canis.actions.RunFirstAbilityOfTarget+<execute>d__1")]
		public sealed class _execute_d__1 : Object
		{
			// Token: 0x06002CD8 RID: 11480 RVA: 0x000BDD40 File Offset: 0x000BBF40
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__1()
			{
				Il2CppClassPointerStore<RunFirstAbilityOfTarget._execute_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunFirstAbilityOfTarget>.NativeClassPtr, "<execute>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunFirstAbilityOfTarget._execute_d__1>.NativeClassPtr);
				RunFirstAbilityOfTarget._execute_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunFirstAbilityOfTarget._execute_d__1>.NativeClassPtr, "<>1__state");
				RunFirstAbilityOfTarget._execute_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunFirstAbilityOfTarget._execute_d__1>.NativeClassPtr, "<>2__current");
				RunFirstAbilityOfTarget._execute_d__1.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunFirstAbilityOfTarget._execute_d__1>.NativeClassPtr, "<>l__initialThreadId");
				RunFirstAbilityOfTarget._execute_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunFirstAbilityOfTarget._execute_d__1>.NativeClassPtr, "<>4__this");
				RunFirstAbilityOfTarget._execute_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFirstAbilityOfTarget._execute_d__1>.NativeClassPtr, 100667574);
				RunFirstAbilityOfTarget._execute_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFirstAbilityOfTarget._execute_d__1>.NativeClassPtr, 100667575);
				RunFirstAbilityOfTarget._execute_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFirstAbilityOfTarget._execute_d__1>.NativeClassPtr, 100667576);
				RunFirstAbilityOfTarget._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFirstAbilityOfTarget._execute_d__1>.NativeClassPtr, 100667577);
				RunFirstAbilityOfTarget._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFirstAbilityOfTarget._execute_d__1>.NativeClassPtr, 100667578);
				RunFirstAbilityOfTarget._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFirstAbilityOfTarget._execute_d__1>.NativeClassPtr, 100667579);
				RunFirstAbilityOfTarget._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFirstAbilityOfTarget._execute_d__1>.NativeClassPtr, 100667580);
				RunFirstAbilityOfTarget._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFirstAbilityOfTarget._execute_d__1>.NativeClassPtr, 100667581);
			}

			// Token: 0x06002CD9 RID: 11481 RVA: 0x000BDE5C File Offset: 0x000BC05C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunFirstAbilityOfTarget._execute_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunFirstAbilityOfTarget._execute_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002CDA RID: 11482 RVA: 0x000BDEA4 File Offset: 0x000BC0A4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunFirstAbilityOfTarget._execute_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CDB RID: 11483 RVA: 0x000BDED8 File Offset: 0x000BC0D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587240, XrefRangeEnd = 587290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunFirstAbilityOfTarget._execute_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B94 RID: 2964
			// (get) Token: 0x06002CDC RID: 11484 RVA: 0x000BDF14 File Offset: 0x000BC114
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunFirstAbilityOfTarget._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002CDD RID: 11485 RVA: 0x000BDF54 File Offset: 0x000BC154
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587290, XrefRangeEnd = 587295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunFirstAbilityOfTarget._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B95 RID: 2965
			// (get) Token: 0x06002CDE RID: 11486 RVA: 0x000BDF88 File Offset: 0x000BC188
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunFirstAbilityOfTarget._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002CDF RID: 11487 RVA: 0x000BDFC8 File Offset: 0x000BC1C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587295, XrefRangeEnd = 587297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunFirstAbilityOfTarget._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06002CE0 RID: 11488 RVA: 0x000BE008 File Offset: 0x000BC208
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunFirstAbilityOfTarget._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002CE1 RID: 11489 RVA: 0x000156C4 File Offset: 0x000138C4
			public _execute_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B90 RID: 2960
			// (get) Token: 0x06002CE2 RID: 11490 RVA: 0x000BE048 File Offset: 0x000BC248
			// (set) Token: 0x06002CE3 RID: 11491 RVA: 0x000156CD File Offset: 0x000138CD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFirstAbilityOfTarget._execute_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFirstAbilityOfTarget._execute_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B91 RID: 2961
			// (get) Token: 0x06002CE4 RID: 11492 RVA: 0x000BE070 File Offset: 0x000BC270
			// (set) Token: 0x06002CE5 RID: 11493 RVA: 0x000156E8 File Offset: 0x000138E8
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFirstAbilityOfTarget._execute_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFirstAbilityOfTarget._execute_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B92 RID: 2962
			// (get) Token: 0x06002CE6 RID: 11494 RVA: 0x000BE0A0 File Offset: 0x000BC2A0
			// (set) Token: 0x06002CE7 RID: 11495 RVA: 0x00015707 File Offset: 0x00013907
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFirstAbilityOfTarget._execute_d__1.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFirstAbilityOfTarget._execute_d__1.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000B93 RID: 2963
			// (get) Token: 0x06002CE8 RID: 11496 RVA: 0x000BE0C8 File Offset: 0x000BC2C8
			// (set) Token: 0x06002CE9 RID: 11497 RVA: 0x00015722 File Offset: 0x00013922
			public unsafe RunFirstAbilityOfTarget __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFirstAbilityOfTarget._execute_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunFirstAbilityOfTarget>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFirstAbilityOfTarget._execute_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C0E RID: 7182
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001C0F RID: 7183
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001C10 RID: 7184
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001C11 RID: 7185
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001C12 RID: 7186
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001C13 RID: 7187
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C14 RID: 7188
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001C15 RID: 7189
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001C16 RID: 7190
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C17 RID: 7191
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001C18 RID: 7192
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001C19 RID: 7193
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
