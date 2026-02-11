using System;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions.staged
{
	// Token: 0x0200020B RID: 523
	public static class IStagedActionsUtils : Object
	{
		// Token: 0x0600161F RID: 5663 RVA: 0x00072370 File Offset: 0x00070570
		// Note: this type is marked as 'beforefieldinit'.
		static IStagedActionsUtils()
		{
			Il2CppClassPointerStore<IStagedActionsUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.staged", "IStagedActionsUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IStagedActionsUtils>.NativeClassPtr);
			IStagedActionsUtils.NativeMethodInfoPtr_CommitChanges_Public_Static_IEnumerable_1_Action_IStagedAction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils>.NativeClassPtr, 100668322);
			IStagedActionsUtils.NativeMethodInfoPtr_RollbackChanges_Public_Static_IEnumerable_1_Action_IStagedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils>.NativeClassPtr, 100668323);
			IStagedActionsUtils.NativeMethodInfoPtr_StageChanges_Public_Static_IEnumerable_1_Action_IStagedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils>.NativeClassPtr, 100668324);
			IStagedActionsUtils.NativeMethodInfoPtr_MakeSerializedAction_Public_Static_SerializedAction_IStagedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils>.NativeClassPtr, 100668325);
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x000723F0 File Offset: 0x000705F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 593233, RefRangeEnd = 593234, XrefRangeStart = 593227, XrefRangeEnd = 593233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Action> CommitChanges(this IStagedAction stagedAction, bool skipCommittedCheck = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stagedAction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipCommittedCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils.NativeMethodInfoPtr_CommitChanges_Public_Static_IEnumerable_1_Action_IStagedAction_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x00072444 File Offset: 0x00070644
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 593241, RefRangeEnd = 593243, XrefRangeStart = 593234, XrefRangeEnd = 593241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Action> RollbackChanges(this IStagedAction stagedAction, Match match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stagedAction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils.NativeMethodInfoPtr_RollbackChanges_Public_Static_IEnumerable_1_Action_IStagedAction_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x0007249C File Offset: 0x0007069C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593243, XrefRangeEnd = 593250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Action> StageChanges(this IStagedAction stagedAction, Match match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stagedAction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils.NativeMethodInfoPtr_StageChanges_Public_Static_IEnumerable_1_Action_IStagedAction_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x000724F4 File Offset: 0x000706F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593250, XrefRangeEnd = 593255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SerializedAction MakeSerializedAction(this IStagedAction stagedAction, Match match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stagedAction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils.NativeMethodInfoPtr_MakeSerializedAction_Public_Static_SerializedAction_IStagedAction_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x0000AB11 File Offset: 0x00008D11
		public IStagedActionsUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E3E RID: 3646
		private static readonly IntPtr NativeMethodInfoPtr_CommitChanges_Public_Static_IEnumerable_1_Action_IStagedAction_Boolean_0;

		// Token: 0x04000E3F RID: 3647
		private static readonly IntPtr NativeMethodInfoPtr_RollbackChanges_Public_Static_IEnumerable_1_Action_IStagedAction_Match_0;

		// Token: 0x04000E40 RID: 3648
		private static readonly IntPtr NativeMethodInfoPtr_StageChanges_Public_Static_IEnumerable_1_Action_IStagedAction_Match_0;

		// Token: 0x04000E41 RID: 3649
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Public_Static_SerializedAction_IStagedAction_Match_0;

		// Token: 0x0200045A RID: 1114
		[ObfuscatedName("Canis.actions.staged.IStagedActionsUtils+<CommitChanges>d__0")]
		public sealed class _CommitChanges_d__0 : Object
		{
			// Token: 0x0600318F RID: 12687 RVA: 0x000CCB70 File Offset: 0x000CAD70
			// Note: this type is marked as 'beforefieldinit'.
			static _CommitChanges_d__0()
			{
				Il2CppClassPointerStore<IStagedActionsUtils._CommitChanges_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IStagedActionsUtils>.NativeClassPtr, "<CommitChanges>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IStagedActionsUtils._CommitChanges_d__0>.NativeClassPtr);
				IStagedActionsUtils._CommitChanges_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStagedActionsUtils._CommitChanges_d__0>.NativeClassPtr, "<>1__state");
				IStagedActionsUtils._CommitChanges_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStagedActionsUtils._CommitChanges_d__0>.NativeClassPtr, "<>2__current");
				IStagedActionsUtils._CommitChanges_d__0.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStagedActionsUtils._CommitChanges_d__0>.NativeClassPtr, "<>l__initialThreadId");
				IStagedActionsUtils._CommitChanges_d__0.NativeFieldInfoPtr_skipCommittedCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStagedActionsUtils._CommitChanges_d__0>.NativeClassPtr, "skipCommittedCheck");
				IStagedActionsUtils._CommitChanges_d__0.NativeFieldInfoPtr___3__skipCommittedCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStagedActionsUtils._CommitChanges_d__0>.NativeClassPtr, "<>3__skipCommittedCheck");
				IStagedActionsUtils._CommitChanges_d__0.NativeFieldInfoPtr_stagedAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStagedActionsUtils._CommitChanges_d__0>.NativeClassPtr, "stagedAction");
				IStagedActionsUtils._CommitChanges_d__0.NativeFieldInfoPtr___3__stagedAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStagedActionsUtils._CommitChanges_d__0>.NativeClassPtr, "<>3__stagedAction");
				IStagedActionsUtils._CommitChanges_d__0.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStagedActionsUtils._CommitChanges_d__0>.NativeClassPtr, "<>7__wrap1");
				IStagedActionsUtils._CommitChanges_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils._CommitChanges_d__0>.NativeClassPtr, 100668326);
				IStagedActionsUtils._CommitChanges_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils._CommitChanges_d__0>.NativeClassPtr, 100668327);
				IStagedActionsUtils._CommitChanges_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils._CommitChanges_d__0>.NativeClassPtr, 100668328);
				IStagedActionsUtils._CommitChanges_d__0.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils._CommitChanges_d__0>.NativeClassPtr, 100668329);
				IStagedActionsUtils._CommitChanges_d__0.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils._CommitChanges_d__0>.NativeClassPtr, 100668330);
				IStagedActionsUtils._CommitChanges_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils._CommitChanges_d__0>.NativeClassPtr, 100668331);
				IStagedActionsUtils._CommitChanges_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils._CommitChanges_d__0>.NativeClassPtr, 100668332);
				IStagedActionsUtils._CommitChanges_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils._CommitChanges_d__0>.NativeClassPtr, 100668333);
				IStagedActionsUtils._CommitChanges_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils._CommitChanges_d__0>.NativeClassPtr, 100668334);
				IStagedActionsUtils._CommitChanges_d__0.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils._CommitChanges_d__0>.NativeClassPtr, 100668335);
			}

			// Token: 0x06003190 RID: 12688 RVA: 0x000CCD04 File Offset: 0x000CAF04
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CommitChanges_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IStagedActionsUtils._CommitChanges_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils._CommitChanges_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003191 RID: 12689 RVA: 0x000CCD4C File Offset: 0x000CAF4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 592965, XrefRangeEnd = 592975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils._CommitChanges_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003192 RID: 12690 RVA: 0x000CCD80 File Offset: 0x000CAF80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 592975, XrefRangeEnd = 593024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils._CommitChanges_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003193 RID: 12691 RVA: 0x000CCDBC File Offset: 0x000CAFBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593024, XrefRangeEnd = 593027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils._CommitChanges_d__0.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003194 RID: 12692 RVA: 0x000CCDF0 File Offset: 0x000CAFF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593027, XrefRangeEnd = 593030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils._CommitChanges_d__0.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D17 RID: 3351
			// (get) Token: 0x06003195 RID: 12693 RVA: 0x000CCE24 File Offset: 0x000CB024
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils._CommitChanges_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06003196 RID: 12694 RVA: 0x000CCE64 File Offset: 0x000CB064
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593030, XrefRangeEnd = 593035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils._CommitChanges_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D18 RID: 3352
			// (get) Token: 0x06003197 RID: 12695 RVA: 0x000CCE98 File Offset: 0x000CB098
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils._CommitChanges_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003198 RID: 12696 RVA: 0x000CCED8 File Offset: 0x000CB0D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593035, XrefRangeEnd = 593043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils._CommitChanges_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06003199 RID: 12697 RVA: 0x000CCF18 File Offset: 0x000CB118
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils._CommitChanges_d__0.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600319A RID: 12698 RVA: 0x00017B57 File Offset: 0x00015D57
			public _CommitChanges_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D0F RID: 3343
			// (get) Token: 0x0600319B RID: 12699 RVA: 0x000CCF58 File Offset: 0x000CB158
			// (set) Token: 0x0600319C RID: 12700 RVA: 0x00017B60 File Offset: 0x00015D60
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._CommitChanges_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._CommitChanges_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D10 RID: 3344
			// (get) Token: 0x0600319D RID: 12701 RVA: 0x000CCF80 File Offset: 0x000CB180
			// (set) Token: 0x0600319E RID: 12702 RVA: 0x00017B7B File Offset: 0x00015D7B
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._CommitChanges_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._CommitChanges_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D11 RID: 3345
			// (get) Token: 0x0600319F RID: 12703 RVA: 0x000CCFB0 File Offset: 0x000CB1B0
			// (set) Token: 0x060031A0 RID: 12704 RVA: 0x00017B9A File Offset: 0x00015D9A
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._CommitChanges_d__0.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._CommitChanges_d__0.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000D12 RID: 3346
			// (get) Token: 0x060031A1 RID: 12705 RVA: 0x000CCFD8 File Offset: 0x000CB1D8
			// (set) Token: 0x060031A2 RID: 12706 RVA: 0x00017BB5 File Offset: 0x00015DB5
			public unsafe bool skipCommittedCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._CommitChanges_d__0.NativeFieldInfoPtr_skipCommittedCheck);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._CommitChanges_d__0.NativeFieldInfoPtr_skipCommittedCheck)) = value;
				}
			}

			// Token: 0x17000D13 RID: 3347
			// (get) Token: 0x060031A3 RID: 12707 RVA: 0x000CD000 File Offset: 0x000CB200
			// (set) Token: 0x060031A4 RID: 12708 RVA: 0x00017BD0 File Offset: 0x00015DD0
			public unsafe bool __3__skipCommittedCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._CommitChanges_d__0.NativeFieldInfoPtr___3__skipCommittedCheck);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._CommitChanges_d__0.NativeFieldInfoPtr___3__skipCommittedCheck)) = value;
				}
			}

			// Token: 0x17000D14 RID: 3348
			// (get) Token: 0x060031A5 RID: 12709 RVA: 0x000CD028 File Offset: 0x000CB228
			// (set) Token: 0x060031A6 RID: 12710 RVA: 0x00017BEB File Offset: 0x00015DEB
			public unsafe IStagedAction stagedAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._CommitChanges_d__0.NativeFieldInfoPtr_stagedAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStagedAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._CommitChanges_d__0.NativeFieldInfoPtr_stagedAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D15 RID: 3349
			// (get) Token: 0x060031A7 RID: 12711 RVA: 0x000CD058 File Offset: 0x000CB258
			// (set) Token: 0x060031A8 RID: 12712 RVA: 0x00017C0A File Offset: 0x00015E0A
			public unsafe IStagedAction __3__stagedAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._CommitChanges_d__0.NativeFieldInfoPtr___3__stagedAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStagedAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._CommitChanges_d__0.NativeFieldInfoPtr___3__stagedAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D16 RID: 3350
			// (get) Token: 0x060031A9 RID: 12713 RVA: 0x000CD088 File Offset: 0x000CB288
			// (set) Token: 0x060031AA RID: 12714 RVA: 0x00017C29 File Offset: 0x00015E29
			public unsafe IEnumerator<Action> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._CommitChanges_d__0.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._CommitChanges_d__0.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F02 RID: 7938
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001F03 RID: 7939
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001F04 RID: 7940
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001F05 RID: 7941
			private static readonly IntPtr NativeFieldInfoPtr_skipCommittedCheck;

			// Token: 0x04001F06 RID: 7942
			private static readonly IntPtr NativeFieldInfoPtr___3__skipCommittedCheck;

			// Token: 0x04001F07 RID: 7943
			private static readonly IntPtr NativeFieldInfoPtr_stagedAction;

			// Token: 0x04001F08 RID: 7944
			private static readonly IntPtr NativeFieldInfoPtr___3__stagedAction;

			// Token: 0x04001F09 RID: 7945
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001F0A RID: 7946
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001F0B RID: 7947
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001F0C RID: 7948
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001F0D RID: 7949
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001F0E RID: 7950
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04001F0F RID: 7951
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001F10 RID: 7952
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001F11 RID: 7953
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001F12 RID: 7954
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001F13 RID: 7955
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200045B RID: 1115
		[ObfuscatedName("Canis.actions.staged.IStagedActionsUtils+<RollbackChanges>d__1")]
		public sealed class _RollbackChanges_d__1 : Object
		{
			// Token: 0x060031AB RID: 12715 RVA: 0x000CD0B8 File Offset: 0x000CB2B8
			// Note: this type is marked as 'beforefieldinit'.
			static _RollbackChanges_d__1()
			{
				Il2CppClassPointerStore<IStagedActionsUtils._RollbackChanges_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IStagedActionsUtils>.NativeClassPtr, "<RollbackChanges>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IStagedActionsUtils._RollbackChanges_d__1>.NativeClassPtr);
				IStagedActionsUtils._RollbackChanges_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStagedActionsUtils._RollbackChanges_d__1>.NativeClassPtr, "<>1__state");
				IStagedActionsUtils._RollbackChanges_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStagedActionsUtils._RollbackChanges_d__1>.NativeClassPtr, "<>2__current");
				IStagedActionsUtils._RollbackChanges_d__1.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStagedActionsUtils._RollbackChanges_d__1>.NativeClassPtr, "<>l__initialThreadId");
				IStagedActionsUtils._RollbackChanges_d__1.NativeFieldInfoPtr_stagedAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStagedActionsUtils._RollbackChanges_d__1>.NativeClassPtr, "stagedAction");
				IStagedActionsUtils._RollbackChanges_d__1.NativeFieldInfoPtr___3__stagedAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStagedActionsUtils._RollbackChanges_d__1>.NativeClassPtr, "<>3__stagedAction");
				IStagedActionsUtils._RollbackChanges_d__1.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStagedActionsUtils._RollbackChanges_d__1>.NativeClassPtr, "match");
				IStagedActionsUtils._RollbackChanges_d__1.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStagedActionsUtils._RollbackChanges_d__1>.NativeClassPtr, "<>3__match");
				IStagedActionsUtils._RollbackChanges_d__1.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStagedActionsUtils._RollbackChanges_d__1>.NativeClassPtr, "<>7__wrap1");
				IStagedActionsUtils._RollbackChanges_d__1.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStagedActionsUtils._RollbackChanges_d__1>.NativeClassPtr, "<>7__wrap2");
				IStagedActionsUtils._RollbackChanges_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils._RollbackChanges_d__1>.NativeClassPtr, 100668336);
				IStagedActionsUtils._RollbackChanges_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils._RollbackChanges_d__1>.NativeClassPtr, 100668337);
				IStagedActionsUtils._RollbackChanges_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils._RollbackChanges_d__1>.NativeClassPtr, 100668338);
				IStagedActionsUtils._RollbackChanges_d__1.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils._RollbackChanges_d__1>.NativeClassPtr, 100668339);
				IStagedActionsUtils._RollbackChanges_d__1.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils._RollbackChanges_d__1>.NativeClassPtr, 100668340);
				IStagedActionsUtils._RollbackChanges_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils._RollbackChanges_d__1>.NativeClassPtr, 100668341);
				IStagedActionsUtils._RollbackChanges_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils._RollbackChanges_d__1>.NativeClassPtr, 100668342);
				IStagedActionsUtils._RollbackChanges_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils._RollbackChanges_d__1>.NativeClassPtr, 100668343);
				IStagedActionsUtils._RollbackChanges_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils._RollbackChanges_d__1>.NativeClassPtr, 100668344);
				IStagedActionsUtils._RollbackChanges_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils._RollbackChanges_d__1>.NativeClassPtr, 100668345);
			}

			// Token: 0x060031AC RID: 12716 RVA: 0x000CD260 File Offset: 0x000CB460
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RollbackChanges_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IStagedActionsUtils._RollbackChanges_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils._RollbackChanges_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060031AD RID: 12717 RVA: 0x000CD2A8 File Offset: 0x000CB4A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593043, XrefRangeEnd = 593053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils._RollbackChanges_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060031AE RID: 12718 RVA: 0x000CD2DC File Offset: 0x000CB4DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593053, XrefRangeEnd = 593091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils._RollbackChanges_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060031AF RID: 12719 RVA: 0x000CD318 File Offset: 0x000CB518
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593091, XrefRangeEnd = 593094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils._RollbackChanges_d__1.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060031B0 RID: 12720 RVA: 0x000CD34C File Offset: 0x000CB54C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593094, XrefRangeEnd = 593097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils._RollbackChanges_d__1.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D22 RID: 3362
			// (get) Token: 0x060031B1 RID: 12721 RVA: 0x000CD380 File Offset: 0x000CB580
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils._RollbackChanges_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x060031B2 RID: 12722 RVA: 0x000CD3C0 File Offset: 0x000CB5C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593097, XrefRangeEnd = 593102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils._RollbackChanges_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D23 RID: 3363
			// (get) Token: 0x060031B3 RID: 12723 RVA: 0x000CD3F4 File Offset: 0x000CB5F4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils._RollbackChanges_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060031B4 RID: 12724 RVA: 0x000CD434 File Offset: 0x000CB634
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593102, XrefRangeEnd = 593111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils._RollbackChanges_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x060031B5 RID: 12725 RVA: 0x000CD474 File Offset: 0x000CB674
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils._RollbackChanges_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060031B6 RID: 12726 RVA: 0x00017C48 File Offset: 0x00015E48
			public _RollbackChanges_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D19 RID: 3353
			// (get) Token: 0x060031B7 RID: 12727 RVA: 0x000CD4B4 File Offset: 0x000CB6B4
			// (set) Token: 0x060031B8 RID: 12728 RVA: 0x00017C51 File Offset: 0x00015E51
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._RollbackChanges_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._RollbackChanges_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D1A RID: 3354
			// (get) Token: 0x060031B9 RID: 12729 RVA: 0x000CD4DC File Offset: 0x000CB6DC
			// (set) Token: 0x060031BA RID: 12730 RVA: 0x00017C6C File Offset: 0x00015E6C
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._RollbackChanges_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._RollbackChanges_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D1B RID: 3355
			// (get) Token: 0x060031BB RID: 12731 RVA: 0x000CD50C File Offset: 0x000CB70C
			// (set) Token: 0x060031BC RID: 12732 RVA: 0x00017C8B File Offset: 0x00015E8B
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._RollbackChanges_d__1.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._RollbackChanges_d__1.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000D1C RID: 3356
			// (get) Token: 0x060031BD RID: 12733 RVA: 0x000CD534 File Offset: 0x000CB734
			// (set) Token: 0x060031BE RID: 12734 RVA: 0x00017CA6 File Offset: 0x00015EA6
			public unsafe IStagedAction stagedAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._RollbackChanges_d__1.NativeFieldInfoPtr_stagedAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStagedAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._RollbackChanges_d__1.NativeFieldInfoPtr_stagedAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D1D RID: 3357
			// (get) Token: 0x060031BF RID: 12735 RVA: 0x000CD564 File Offset: 0x000CB764
			// (set) Token: 0x060031C0 RID: 12736 RVA: 0x00017CC5 File Offset: 0x00015EC5
			public unsafe IStagedAction __3__stagedAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._RollbackChanges_d__1.NativeFieldInfoPtr___3__stagedAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStagedAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._RollbackChanges_d__1.NativeFieldInfoPtr___3__stagedAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D1E RID: 3358
			// (get) Token: 0x060031C1 RID: 12737 RVA: 0x000CD594 File Offset: 0x000CB794
			// (set) Token: 0x060031C2 RID: 12738 RVA: 0x00017CE4 File Offset: 0x00015EE4
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._RollbackChanges_d__1.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._RollbackChanges_d__1.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D1F RID: 3359
			// (get) Token: 0x060031C3 RID: 12739 RVA: 0x000CD5C4 File Offset: 0x000CB7C4
			// (set) Token: 0x060031C4 RID: 12740 RVA: 0x00017D03 File Offset: 0x00015F03
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._RollbackChanges_d__1.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._RollbackChanges_d__1.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D20 RID: 3360
			// (get) Token: 0x060031C5 RID: 12741 RVA: 0x000CD5F4 File Offset: 0x000CB7F4
			// (set) Token: 0x060031C6 RID: 12742 RVA: 0x00017D22 File Offset: 0x00015F22
			public unsafe IEnumerator<Staging> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._RollbackChanges_d__1.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Staging>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._RollbackChanges_d__1.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D21 RID: 3361
			// (get) Token: 0x060031C7 RID: 12743 RVA: 0x000CD624 File Offset: 0x000CB824
			// (set) Token: 0x060031C8 RID: 12744 RVA: 0x00017D41 File Offset: 0x00015F41
			public unsafe IEnumerator<Action> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._RollbackChanges_d__1.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._RollbackChanges_d__1.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F14 RID: 7956
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001F15 RID: 7957
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001F16 RID: 7958
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001F17 RID: 7959
			private static readonly IntPtr NativeFieldInfoPtr_stagedAction;

			// Token: 0x04001F18 RID: 7960
			private static readonly IntPtr NativeFieldInfoPtr___3__stagedAction;

			// Token: 0x04001F19 RID: 7961
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04001F1A RID: 7962
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04001F1B RID: 7963
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001F1C RID: 7964
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04001F1D RID: 7965
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001F1E RID: 7966
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001F1F RID: 7967
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001F20 RID: 7968
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001F21 RID: 7969
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04001F22 RID: 7970
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001F23 RID: 7971
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001F24 RID: 7972
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001F25 RID: 7973
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001F26 RID: 7974
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200045C RID: 1116
		[ObfuscatedName("Canis.actions.staged.IStagedActionsUtils+<StageChanges>d__2")]
		public sealed class _StageChanges_d__2 : Object
		{
			// Token: 0x060031C9 RID: 12745 RVA: 0x000CD654 File Offset: 0x000CB854
			// Note: this type is marked as 'beforefieldinit'.
			static _StageChanges_d__2()
			{
				Il2CppClassPointerStore<IStagedActionsUtils._StageChanges_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IStagedActionsUtils>.NativeClassPtr, "<StageChanges>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IStagedActionsUtils._StageChanges_d__2>.NativeClassPtr);
				IStagedActionsUtils._StageChanges_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStagedActionsUtils._StageChanges_d__2>.NativeClassPtr, "<>1__state");
				IStagedActionsUtils._StageChanges_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStagedActionsUtils._StageChanges_d__2>.NativeClassPtr, "<>2__current");
				IStagedActionsUtils._StageChanges_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStagedActionsUtils._StageChanges_d__2>.NativeClassPtr, "<>l__initialThreadId");
				IStagedActionsUtils._StageChanges_d__2.NativeFieldInfoPtr_stagedAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStagedActionsUtils._StageChanges_d__2>.NativeClassPtr, "stagedAction");
				IStagedActionsUtils._StageChanges_d__2.NativeFieldInfoPtr___3__stagedAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStagedActionsUtils._StageChanges_d__2>.NativeClassPtr, "<>3__stagedAction");
				IStagedActionsUtils._StageChanges_d__2.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStagedActionsUtils._StageChanges_d__2>.NativeClassPtr, "match");
				IStagedActionsUtils._StageChanges_d__2.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStagedActionsUtils._StageChanges_d__2>.NativeClassPtr, "<>3__match");
				IStagedActionsUtils._StageChanges_d__2.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStagedActionsUtils._StageChanges_d__2>.NativeClassPtr, "<>7__wrap1");
				IStagedActionsUtils._StageChanges_d__2.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStagedActionsUtils._StageChanges_d__2>.NativeClassPtr, "<>7__wrap2");
				IStagedActionsUtils._StageChanges_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils._StageChanges_d__2>.NativeClassPtr, 100668346);
				IStagedActionsUtils._StageChanges_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils._StageChanges_d__2>.NativeClassPtr, 100668347);
				IStagedActionsUtils._StageChanges_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils._StageChanges_d__2>.NativeClassPtr, 100668348);
				IStagedActionsUtils._StageChanges_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils._StageChanges_d__2>.NativeClassPtr, 100668349);
				IStagedActionsUtils._StageChanges_d__2.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils._StageChanges_d__2>.NativeClassPtr, 100668350);
				IStagedActionsUtils._StageChanges_d__2.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils._StageChanges_d__2>.NativeClassPtr, 100668351);
				IStagedActionsUtils._StageChanges_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils._StageChanges_d__2>.NativeClassPtr, 100668352);
				IStagedActionsUtils._StageChanges_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils._StageChanges_d__2>.NativeClassPtr, 100668353);
				IStagedActionsUtils._StageChanges_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils._StageChanges_d__2>.NativeClassPtr, 100668354);
				IStagedActionsUtils._StageChanges_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils._StageChanges_d__2>.NativeClassPtr, 100668355);
				IStagedActionsUtils._StageChanges_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedActionsUtils._StageChanges_d__2>.NativeClassPtr, 100668356);
			}

			// Token: 0x060031CA RID: 12746 RVA: 0x000CD810 File Offset: 0x000CBA10
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _StageChanges_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IStagedActionsUtils._StageChanges_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils._StageChanges_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060031CB RID: 12747 RVA: 0x000CD858 File Offset: 0x000CBA58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593111, XrefRangeEnd = 593131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils._StageChanges_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060031CC RID: 12748 RVA: 0x000CD88C File Offset: 0x000CBA8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593131, XrefRangeEnd = 593204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils._StageChanges_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060031CD RID: 12749 RVA: 0x000CD8C8 File Offset: 0x000CBAC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593204, XrefRangeEnd = 593207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils._StageChanges_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060031CE RID: 12750 RVA: 0x000CD8FC File Offset: 0x000CBAFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593207, XrefRangeEnd = 593210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils._StageChanges_d__2.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060031CF RID: 12751 RVA: 0x000CD930 File Offset: 0x000CBB30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593210, XrefRangeEnd = 593213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils._StageChanges_d__2.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D2D RID: 3373
			// (get) Token: 0x060031D0 RID: 12752 RVA: 0x000CD964 File Offset: 0x000CBB64
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils._StageChanges_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x060031D1 RID: 12753 RVA: 0x000CD9A4 File Offset: 0x000CBBA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593213, XrefRangeEnd = 593218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils._StageChanges_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D2E RID: 3374
			// (get) Token: 0x060031D2 RID: 12754 RVA: 0x000CD9D8 File Offset: 0x000CBBD8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils._StageChanges_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060031D3 RID: 12755 RVA: 0x000CDA18 File Offset: 0x000CBC18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593218, XrefRangeEnd = 593227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils._StageChanges_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x060031D4 RID: 12756 RVA: 0x000CDA58 File Offset: 0x000CBC58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStagedActionsUtils._StageChanges_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060031D5 RID: 12757 RVA: 0x00017D60 File Offset: 0x00015F60
			public _StageChanges_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D24 RID: 3364
			// (get) Token: 0x060031D6 RID: 12758 RVA: 0x000CDA98 File Offset: 0x000CBC98
			// (set) Token: 0x060031D7 RID: 12759 RVA: 0x00017D69 File Offset: 0x00015F69
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._StageChanges_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._StageChanges_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D25 RID: 3365
			// (get) Token: 0x060031D8 RID: 12760 RVA: 0x000CDAC0 File Offset: 0x000CBCC0
			// (set) Token: 0x060031D9 RID: 12761 RVA: 0x00017D84 File Offset: 0x00015F84
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._StageChanges_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._StageChanges_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D26 RID: 3366
			// (get) Token: 0x060031DA RID: 12762 RVA: 0x000CDAF0 File Offset: 0x000CBCF0
			// (set) Token: 0x060031DB RID: 12763 RVA: 0x00017DA3 File Offset: 0x00015FA3
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._StageChanges_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._StageChanges_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000D27 RID: 3367
			// (get) Token: 0x060031DC RID: 12764 RVA: 0x000CDB18 File Offset: 0x000CBD18
			// (set) Token: 0x060031DD RID: 12765 RVA: 0x00017DBE File Offset: 0x00015FBE
			public unsafe IStagedAction stagedAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._StageChanges_d__2.NativeFieldInfoPtr_stagedAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStagedAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._StageChanges_d__2.NativeFieldInfoPtr_stagedAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D28 RID: 3368
			// (get) Token: 0x060031DE RID: 12766 RVA: 0x000CDB48 File Offset: 0x000CBD48
			// (set) Token: 0x060031DF RID: 12767 RVA: 0x00017DDD File Offset: 0x00015FDD
			public unsafe IStagedAction __3__stagedAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._StageChanges_d__2.NativeFieldInfoPtr___3__stagedAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStagedAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._StageChanges_d__2.NativeFieldInfoPtr___3__stagedAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D29 RID: 3369
			// (get) Token: 0x060031E0 RID: 12768 RVA: 0x000CDB78 File Offset: 0x000CBD78
			// (set) Token: 0x060031E1 RID: 12769 RVA: 0x00017DFC File Offset: 0x00015FFC
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._StageChanges_d__2.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._StageChanges_d__2.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D2A RID: 3370
			// (get) Token: 0x060031E2 RID: 12770 RVA: 0x000CDBA8 File Offset: 0x000CBDA8
			// (set) Token: 0x060031E3 RID: 12771 RVA: 0x00017E1B File Offset: 0x0001601B
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._StageChanges_d__2.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._StageChanges_d__2.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D2B RID: 3371
			// (get) Token: 0x060031E4 RID: 12772 RVA: 0x000CDBD8 File Offset: 0x000CBDD8
			// (set) Token: 0x060031E5 RID: 12773 RVA: 0x00017E3A File Offset: 0x0001603A
			public unsafe IEnumerator<Staging> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._StageChanges_d__2.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Staging>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._StageChanges_d__2.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D2C RID: 3372
			// (get) Token: 0x060031E6 RID: 12774 RVA: 0x000CDC08 File Offset: 0x000CBE08
			// (set) Token: 0x060031E7 RID: 12775 RVA: 0x00017E59 File Offset: 0x00016059
			public unsafe IEnumerator<Action> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._StageChanges_d__2.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStagedActionsUtils._StageChanges_d__2.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F27 RID: 7975
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001F28 RID: 7976
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001F29 RID: 7977
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001F2A RID: 7978
			private static readonly IntPtr NativeFieldInfoPtr_stagedAction;

			// Token: 0x04001F2B RID: 7979
			private static readonly IntPtr NativeFieldInfoPtr___3__stagedAction;

			// Token: 0x04001F2C RID: 7980
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04001F2D RID: 7981
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04001F2E RID: 7982
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001F2F RID: 7983
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04001F30 RID: 7984
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001F31 RID: 7985
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001F32 RID: 7986
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001F33 RID: 7987
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001F34 RID: 7988
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04001F35 RID: 7989
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

			// Token: 0x04001F36 RID: 7990
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001F37 RID: 7991
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001F38 RID: 7992
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001F39 RID: 7993
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001F3A RID: 7994
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
