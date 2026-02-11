using System;
using System.Runtime.InteropServices;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions
{
	// Token: 0x020001A5 RID: 421
	public class CustomChoiceActions : Action
	{
		// Token: 0x06001233 RID: 4659 RVA: 0x000631E0 File Offset: 0x000613E0
		// Note: this type is marked as 'beforefieldinit'.
		static CustomChoiceActions()
		{
			Il2CppClassPointerStore<CustomChoiceActions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "CustomChoiceActions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomChoiceActions>.NativeClassPtr);
			CustomChoiceActions.NativeFieldInfoPtr_responses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceActions>.NativeClassPtr, "responses");
			CustomChoiceActions.NativeMethodInfoPtr__ctor_Public_Void_Match_Il2CppReferenceArray_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceActions>.NativeClassPtr, 100667182);
			CustomChoiceActions.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceActions>.NativeClassPtr, 100667183);
			CustomChoiceActions.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceActions>.NativeClassPtr, 100667184);
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x00063260 File Offset: 0x00061460
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 584680, RefRangeEnd = 584707, XrefRangeStart = 584680, XrefRangeEnd = 584707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomChoiceActions(Match m, [Optional] Il2CppReferenceArray<Action> responses)
		{
			if (responses == null)
			{
				responses = new Il2CppReferenceArray<Action>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomChoiceActions>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responses);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceActions.NativeMethodInfoPtr__ctor_Public_Void_Match_Il2CppReferenceArray_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x000632CC File Offset: 0x000614CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585203, XrefRangeEnd = 585209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomChoiceActions.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x00063318 File Offset: 0x00061518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585209, XrefRangeEnd = 585231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomChoiceActions.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x00009004 File Offset: 0x00007204
		public CustomChoiceActions(Match m, params Action[] responses)
			: this(m, new Il2CppReferenceArray<Action>(responses))
		{
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x00009013 File Offset: 0x00007213
		public CustomChoiceActions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06001239 RID: 4665 RVA: 0x00063374 File Offset: 0x00061574
		// (set) Token: 0x0600123A RID: 4666 RVA: 0x0000901C File Offset: 0x0000721C
		public unsafe Il2CppReferenceArray<Action> responses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceActions.NativeFieldInfoPtr_responses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Action>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceActions.NativeFieldInfoPtr_responses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BE1 RID: 3041
		private static readonly IntPtr NativeFieldInfoPtr_responses;

		// Token: 0x04000BE2 RID: 3042
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_Il2CppReferenceArray_1_Action_0;

		// Token: 0x04000BE3 RID: 3043
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04000BE4 RID: 3044
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x020003E4 RID: 996
		[ObfuscatedName("Canis.actions.CustomChoiceActions+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06002A71 RID: 10865 RVA: 0x000B6168 File Offset: 0x000B4368
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<CustomChoiceActions.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomChoiceActions>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomChoiceActions.__c__DisplayClass3_0>.NativeClassPtr);
				CustomChoiceActions.__c__DisplayClass3_0.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceActions.__c__DisplayClass3_0>.NativeClassPtr, "match");
				CustomChoiceActions.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceActions.__c__DisplayClass3_0>.NativeClassPtr, 100667185);
				CustomChoiceActions.__c__DisplayClass3_0.NativeMethodInfoPtr__MakeSerializedAction_b__0_Internal_SerializedAction_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceActions.__c__DisplayClass3_0>.NativeClassPtr, 100667186);
			}

			// Token: 0x06002A72 RID: 10866 RVA: 0x000B61D0 File Offset: 0x000B43D0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomChoiceActions.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceActions.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A73 RID: 10867 RVA: 0x000B620C File Offset: 0x000B440C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SerializedAction _MakeSerializedAction_b__0(Action a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceActions.__c__DisplayClass3_0.NativeMethodInfoPtr__MakeSerializedAction_b__0_Internal_SerializedAction_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
				}
			}

			// Token: 0x06002A74 RID: 10868 RVA: 0x000144C9 File Offset: 0x000126C9
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AC5 RID: 2757
			// (get) Token: 0x06002A75 RID: 10869 RVA: 0x000B625C File Offset: 0x000B445C
			// (set) Token: 0x06002A76 RID: 10870 RVA: 0x000144D2 File Offset: 0x000126D2
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceActions.__c__DisplayClass3_0.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceActions.__c__DisplayClass3_0.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A85 RID: 6789
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04001A86 RID: 6790
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001A87 RID: 6791
			private static readonly IntPtr NativeMethodInfoPtr__MakeSerializedAction_b__0_Internal_SerializedAction_Action_0;
		}

		// Token: 0x020003E5 RID: 997
		[ObfuscatedName("Canis.actions.CustomChoiceActions+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x06002A77 RID: 10871 RVA: 0x000B628C File Offset: 0x000B448C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<CustomChoiceActions._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomChoiceActions>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomChoiceActions._execute_d__2>.NativeClassPtr);
				CustomChoiceActions._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceActions._execute_d__2>.NativeClassPtr, "<>1__state");
				CustomChoiceActions._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceActions._execute_d__2>.NativeClassPtr, "<>2__current");
				CustomChoiceActions._execute_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceActions._execute_d__2>.NativeClassPtr, "<>l__initialThreadId");
				CustomChoiceActions._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceActions._execute_d__2>.NativeClassPtr, "<>4__this");
				CustomChoiceActions._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceActions._execute_d__2>.NativeClassPtr, 100667187);
				CustomChoiceActions._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceActions._execute_d__2>.NativeClassPtr, 100667188);
				CustomChoiceActions._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceActions._execute_d__2>.NativeClassPtr, 100667189);
				CustomChoiceActions._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceActions._execute_d__2>.NativeClassPtr, 100667190);
				CustomChoiceActions._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceActions._execute_d__2>.NativeClassPtr, 100667191);
				CustomChoiceActions._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceActions._execute_d__2>.NativeClassPtr, 100667192);
				CustomChoiceActions._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceActions._execute_d__2>.NativeClassPtr, 100667193);
				CustomChoiceActions._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceActions._execute_d__2>.NativeClassPtr, 100667194);
			}

			// Token: 0x06002A78 RID: 10872 RVA: 0x000B63A8 File Offset: 0x000B45A8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomChoiceActions._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceActions._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002A79 RID: 10873 RVA: 0x000B63F0 File Offset: 0x000B45F0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceActions._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A7A RID: 10874 RVA: 0x000B6424 File Offset: 0x000B4624
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585193, XrefRangeEnd = 585196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceActions._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000ACA RID: 2762
			// (get) Token: 0x06002A7B RID: 10875 RVA: 0x000B6460 File Offset: 0x000B4660
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceActions._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002A7C RID: 10876 RVA: 0x000B64A0 File Offset: 0x000B46A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585196, XrefRangeEnd = 585201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceActions._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000ACB RID: 2763
			// (get) Token: 0x06002A7D RID: 10877 RVA: 0x000B64D4 File Offset: 0x000B46D4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceActions._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A7E RID: 10878 RVA: 0x000B6514 File Offset: 0x000B4714
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585201, XrefRangeEnd = 585203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceActions._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06002A7F RID: 10879 RVA: 0x000B6554 File Offset: 0x000B4754
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceActions._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002A80 RID: 10880 RVA: 0x000144F1 File Offset: 0x000126F1
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AC6 RID: 2758
			// (get) Token: 0x06002A81 RID: 10881 RVA: 0x000B6594 File Offset: 0x000B4794
			// (set) Token: 0x06002A82 RID: 10882 RVA: 0x000144FA File Offset: 0x000126FA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceActions._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceActions._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AC7 RID: 2759
			// (get) Token: 0x06002A83 RID: 10883 RVA: 0x000B65BC File Offset: 0x000B47BC
			// (set) Token: 0x06002A84 RID: 10884 RVA: 0x00014515 File Offset: 0x00012715
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceActions._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceActions._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AC8 RID: 2760
			// (get) Token: 0x06002A85 RID: 10885 RVA: 0x000B65EC File Offset: 0x000B47EC
			// (set) Token: 0x06002A86 RID: 10886 RVA: 0x00014534 File Offset: 0x00012734
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceActions._execute_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceActions._execute_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000AC9 RID: 2761
			// (get) Token: 0x06002A87 RID: 10887 RVA: 0x000B6614 File Offset: 0x000B4814
			// (set) Token: 0x06002A88 RID: 10888 RVA: 0x0001454F File Offset: 0x0001274F
			public unsafe CustomChoiceActions __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceActions._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomChoiceActions>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceActions._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A88 RID: 6792
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001A89 RID: 6793
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001A8A RID: 6794
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001A8B RID: 6795
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001A8C RID: 6796
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001A8D RID: 6797
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A8E RID: 6798
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001A8F RID: 6799
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001A90 RID: 6800
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A91 RID: 6801
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001A92 RID: 6802
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001A93 RID: 6803
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
