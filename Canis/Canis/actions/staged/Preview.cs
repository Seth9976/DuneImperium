using System;
using System.Runtime.InteropServices;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions.staged
{
	// Token: 0x02000209 RID: 521
	public class Preview : Staging
	{
		// Token: 0x0600160E RID: 5646 RVA: 0x00071F44 File Offset: 0x00070144
		// Note: this type is marked as 'beforefieldinit'.
		static Preview()
		{
			Il2CppClassPointerStore<Preview>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.staged", "Preview");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Preview>.NativeClassPtr);
			Preview.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preview>.NativeClassPtr, "Message");
			Preview.NativeFieldInfoPtr_AccountIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preview>.NativeClassPtr, "AccountIDs");
			Preview.NativeMethodInfoPtr__ctor_Public_Void_GameMessage_AccountID_Il2CppReferenceArray_1_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preview>.NativeClassPtr, 100668303);
			Preview.NativeMethodInfoPtr_Apply_Public_Virtual_IEnumerable_1_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preview>.NativeClassPtr, 100668304);
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x00071FC4 File Offset: 0x000701C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 592949, XrefRangeEnd = 592958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Preview(GameMessage message, AccountID accountID, [Optional] Il2CppReferenceArray<AccountID> otherAccounts)
		{
			if (otherAccounts == null)
			{
				otherAccounts = new Il2CppReferenceArray<AccountID>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Preview>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(otherAccounts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preview.NativeMethodInfoPtr__ctor_Public_Void_GameMessage_AccountID_Il2CppReferenceArray_1_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x00072040 File Offset: 0x00070240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 592958, XrefRangeEnd = 592965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> Apply(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Preview.NativeMethodInfoPtr_Apply_Public_Virtual_IEnumerable_1_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
			}
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x0000AAB1 File Offset: 0x00008CB1
		public Preview(GameMessage message, AccountID accountID, params AccountID[] otherAccounts)
			: this(message, accountID, new Il2CppReferenceArray<AccountID>(otherAccounts))
		{
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x0000AAC1 File Offset: 0x00008CC1
		public Preview(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06001613 RID: 5651 RVA: 0x0007209C File Offset: 0x0007029C
		// (set) Token: 0x06001614 RID: 5652 RVA: 0x0000AACA File Offset: 0x00008CCA
		public unsafe GameMessage Message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preview.NativeFieldInfoPtr_Message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preview.NativeFieldInfoPtr_Message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06001615 RID: 5653 RVA: 0x000720CC File Offset: 0x000702CC
		// (set) Token: 0x06001616 RID: 5654 RVA: 0x0000AAE9 File Offset: 0x00008CE9
		public unsafe List<AccountID> AccountIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preview.NativeFieldInfoPtr_AccountIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AccountID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preview.NativeFieldInfoPtr_AccountIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E34 RID: 3636
		private static readonly IntPtr NativeFieldInfoPtr_Message;

		// Token: 0x04000E35 RID: 3637
		private static readonly IntPtr NativeFieldInfoPtr_AccountIDs;

		// Token: 0x04000E36 RID: 3638
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameMessage_AccountID_Il2CppReferenceArray_1_AccountID_0;

		// Token: 0x04000E37 RID: 3639
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_IEnumerable_1_Action_Match_0;

		// Token: 0x02000458 RID: 1112
		[ObfuscatedName("Canis.actions.staged.Preview+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x0600316C RID: 12652 RVA: 0x000CC4F8 File Offset: 0x000CA6F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<Preview.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Preview>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Preview.__c__DisplayClass3_0>.NativeClassPtr);
				Preview.__c__DisplayClass3_0.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preview.__c__DisplayClass3_0>.NativeClassPtr, "match");
				Preview.__c__DisplayClass3_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preview.__c__DisplayClass3_0>.NativeClassPtr, "<>9__0");
				Preview.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preview.__c__DisplayClass3_0>.NativeClassPtr, 100668305);
				Preview.__c__DisplayClass3_0.NativeMethodInfoPtr__Apply_b__0_Internal_IEnumerable_1_PlayerEntity_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preview.__c__DisplayClass3_0>.NativeClassPtr, 100668306);
			}

			// Token: 0x0600316D RID: 12653 RVA: 0x000CC574 File Offset: 0x000CA774
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Preview.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preview.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600316E RID: 12654 RVA: 0x000CC5B0 File Offset: 0x000CA7B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 592880, XrefRangeEnd = 592890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<PlayerEntity> _Apply_b__0(AccountID _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preview.__c__DisplayClass3_0.NativeMethodInfoPtr__Apply_b__0_Internal_IEnumerable_1_PlayerEntity_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
				}
			}

			// Token: 0x0600316F RID: 12655 RVA: 0x00017A17 File Offset: 0x00015C17
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D03 RID: 3331
			// (get) Token: 0x06003170 RID: 12656 RVA: 0x000CC600 File Offset: 0x000CA800
			// (set) Token: 0x06003171 RID: 12657 RVA: 0x00017A20 File Offset: 0x00015C20
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preview.__c__DisplayClass3_0.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preview.__c__DisplayClass3_0.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D04 RID: 3332
			// (get) Token: 0x06003172 RID: 12658 RVA: 0x000CC630 File Offset: 0x000CA830
			// (set) Token: 0x06003173 RID: 12659 RVA: 0x00017A3F File Offset: 0x00015C3F
			public unsafe Func<AccountID, IEnumerable<PlayerEntity>> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preview.__c__DisplayClass3_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AccountID, IEnumerable<PlayerEntity>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preview.__c__DisplayClass3_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001EED RID: 7917
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04001EEE RID: 7918
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04001EEF RID: 7919
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001EF0 RID: 7920
			private static readonly IntPtr NativeMethodInfoPtr__Apply_b__0_Internal_IEnumerable_1_PlayerEntity_AccountID_0;
		}

		// Token: 0x02000459 RID: 1113
		[ObfuscatedName("Canis.actions.staged.Preview+<Apply>d__3")]
		public sealed class _Apply_d__3 : Object
		{
			// Token: 0x06003174 RID: 12660 RVA: 0x000CC660 File Offset: 0x000CA860
			// Note: this type is marked as 'beforefieldinit'.
			static _Apply_d__3()
			{
				Il2CppClassPointerStore<Preview._Apply_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Preview>.NativeClassPtr, "<Apply>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Preview._Apply_d__3>.NativeClassPtr);
				Preview._Apply_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preview._Apply_d__3>.NativeClassPtr, "<>1__state");
				Preview._Apply_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preview._Apply_d__3>.NativeClassPtr, "<>2__current");
				Preview._Apply_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preview._Apply_d__3>.NativeClassPtr, "<>l__initialThreadId");
				Preview._Apply_d__3.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preview._Apply_d__3>.NativeClassPtr, "match");
				Preview._Apply_d__3.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preview._Apply_d__3>.NativeClassPtr, "<>3__match");
				Preview._Apply_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preview._Apply_d__3>.NativeClassPtr, "<>4__this");
				Preview._Apply_d__3.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preview._Apply_d__3>.NativeClassPtr, "<>8__1");
				Preview._Apply_d__3.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preview._Apply_d__3>.NativeClassPtr, "<>7__wrap1");
				Preview._Apply_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preview._Apply_d__3>.NativeClassPtr, 100668307);
				Preview._Apply_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preview._Apply_d__3>.NativeClassPtr, 100668308);
				Preview._Apply_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preview._Apply_d__3>.NativeClassPtr, 100668309);
				Preview._Apply_d__3.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preview._Apply_d__3>.NativeClassPtr, 100668310);
				Preview._Apply_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preview._Apply_d__3>.NativeClassPtr, 100668311);
				Preview._Apply_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preview._Apply_d__3>.NativeClassPtr, 100668312);
				Preview._Apply_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preview._Apply_d__3>.NativeClassPtr, 100668313);
				Preview._Apply_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preview._Apply_d__3>.NativeClassPtr, 100668314);
				Preview._Apply_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preview._Apply_d__3>.NativeClassPtr, 100668315);
			}

			// Token: 0x06003175 RID: 12661 RVA: 0x000CC7E0 File Offset: 0x000CA9E0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Apply_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Preview._Apply_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preview._Apply_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003176 RID: 12662 RVA: 0x000CC828 File Offset: 0x000CAA28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 592890, XrefRangeEnd = 592895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preview._Apply_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003177 RID: 12663 RVA: 0x000CC85C File Offset: 0x000CAA5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 592895, XrefRangeEnd = 592932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preview._Apply_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003178 RID: 12664 RVA: 0x000CC898 File Offset: 0x000CAA98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 592932, XrefRangeEnd = 592935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preview._Apply_d__3.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D0D RID: 3341
			// (get) Token: 0x06003179 RID: 12665 RVA: 0x000CC8CC File Offset: 0x000CAACC
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preview._Apply_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600317A RID: 12666 RVA: 0x000CC90C File Offset: 0x000CAB0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 592935, XrefRangeEnd = 592940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preview._Apply_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D0E RID: 3342
			// (get) Token: 0x0600317B RID: 12667 RVA: 0x000CC940 File Offset: 0x000CAB40
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preview._Apply_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600317C RID: 12668 RVA: 0x000CC980 File Offset: 0x000CAB80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 592940, XrefRangeEnd = 592949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preview._Apply_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x0600317D RID: 12669 RVA: 0x000CC9C0 File Offset: 0x000CABC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preview._Apply_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600317E RID: 12670 RVA: 0x00017A5E File Offset: 0x00015C5E
			public _Apply_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D05 RID: 3333
			// (get) Token: 0x0600317F RID: 12671 RVA: 0x000CCA00 File Offset: 0x000CAC00
			// (set) Token: 0x06003180 RID: 12672 RVA: 0x00017A67 File Offset: 0x00015C67
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preview._Apply_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preview._Apply_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D06 RID: 3334
			// (get) Token: 0x06003181 RID: 12673 RVA: 0x000CCA28 File Offset: 0x000CAC28
			// (set) Token: 0x06003182 RID: 12674 RVA: 0x00017A82 File Offset: 0x00015C82
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preview._Apply_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preview._Apply_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D07 RID: 3335
			// (get) Token: 0x06003183 RID: 12675 RVA: 0x000CCA58 File Offset: 0x000CAC58
			// (set) Token: 0x06003184 RID: 12676 RVA: 0x00017AA1 File Offset: 0x00015CA1
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preview._Apply_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preview._Apply_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000D08 RID: 3336
			// (get) Token: 0x06003185 RID: 12677 RVA: 0x000CCA80 File Offset: 0x000CAC80
			// (set) Token: 0x06003186 RID: 12678 RVA: 0x00017ABC File Offset: 0x00015CBC
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preview._Apply_d__3.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preview._Apply_d__3.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D09 RID: 3337
			// (get) Token: 0x06003187 RID: 12679 RVA: 0x000CCAB0 File Offset: 0x000CACB0
			// (set) Token: 0x06003188 RID: 12680 RVA: 0x00017ADB File Offset: 0x00015CDB
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preview._Apply_d__3.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preview._Apply_d__3.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D0A RID: 3338
			// (get) Token: 0x06003189 RID: 12681 RVA: 0x000CCAE0 File Offset: 0x000CACE0
			// (set) Token: 0x0600318A RID: 12682 RVA: 0x00017AFA File Offset: 0x00015CFA
			public unsafe Preview __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preview._Apply_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Preview>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preview._Apply_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D0B RID: 3339
			// (get) Token: 0x0600318B RID: 12683 RVA: 0x000CCB10 File Offset: 0x000CAD10
			// (set) Token: 0x0600318C RID: 12684 RVA: 0x00017B19 File Offset: 0x00015D19
			public unsafe Preview.__c__DisplayClass3_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preview._Apply_d__3.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Preview.__c__DisplayClass3_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preview._Apply_d__3.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D0C RID: 3340
			// (get) Token: 0x0600318D RID: 12685 RVA: 0x000CCB40 File Offset: 0x000CAD40
			// (set) Token: 0x0600318E RID: 12686 RVA: 0x00017B38 File Offset: 0x00015D38
			public unsafe IEnumerator<PlayerEntity> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preview._Apply_d__3.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayerEntity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preview._Apply_d__3.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001EF1 RID: 7921
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001EF2 RID: 7922
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001EF3 RID: 7923
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001EF4 RID: 7924
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04001EF5 RID: 7925
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04001EF6 RID: 7926
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001EF7 RID: 7927
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04001EF8 RID: 7928
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001EF9 RID: 7929
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001EFA RID: 7930
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001EFB RID: 7931
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001EFC RID: 7932
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001EFD RID: 7933
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001EFE RID: 7934
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001EFF RID: 7935
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001F00 RID: 7936
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001F01 RID: 7937
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
