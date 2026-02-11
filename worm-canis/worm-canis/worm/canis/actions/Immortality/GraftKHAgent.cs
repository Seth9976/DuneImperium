using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.actions.Immortality
{
	// Token: 0x020002E6 RID: 742
	public class GraftKHAgent : global::Canis.actions.Action
	{
		// Token: 0x06001E9A RID: 7834 RVA: 0x000D0358 File Offset: 0x000CE558
		// Note: this type is marked as 'beforefieldinit'.
		static GraftKHAgent()
		{
			Il2CppClassPointerStore<GraftKHAgent>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.Immortality", "GraftKHAgent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraftKHAgent>.NativeClassPtr);
			GraftKHAgent.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraftKHAgent>.NativeClassPtr, "player");
			GraftKHAgent.NativeFieldInfoPtr_KHAgent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraftKHAgent>.NativeClassPtr, "KHAgent");
			GraftKHAgent.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftKHAgent>.NativeClassPtr, 100670473);
			GraftKHAgent.NativeMethodInfoPtr__ctor_Public_Void_SerializedGraftKHAgent_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftKHAgent>.NativeClassPtr, 100670474);
			GraftKHAgent.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftKHAgent>.NativeClassPtr, 100670475);
			GraftKHAgent.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftKHAgent>.NativeClassPtr, 100670476);
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x000D0400 File Offset: 0x000CE600
		[CallerCount(106)]
		[CachedScanResults(RefRangeStart = 139275, RefRangeEnd = 139381, XrefRangeStart = 139275, XrefRangeEnd = 139381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraftKHAgent(WormPlayer player, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraftKHAgent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraftKHAgent.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x000D0460 File Offset: 0x000CE660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171558, XrefRangeEnd = 171567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraftKHAgent(SerializedGraftKHAgent serialized, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraftKHAgent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraftKHAgent.NativeMethodInfoPtr__ctor_Public_Void_SerializedGraftKHAgent_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x000D04C0 File Offset: 0x000CE6C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171567, XrefRangeEnd = 171573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraftKHAgent.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x000D050C File Offset: 0x000CE70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171573, XrefRangeEnd = 171579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraftKHAgent.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x0000CD7A File Offset: 0x0000AF7A
		public GraftKHAgent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06001EA0 RID: 7840 RVA: 0x000D0568 File Offset: 0x000CE768
		// (set) Token: 0x06001EA1 RID: 7841 RVA: 0x0000CD83 File Offset: 0x0000AF83
		public unsafe WormPlayer player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftKHAgent.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftKHAgent.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06001EA2 RID: 7842 RVA: 0x000D0598 File Offset: 0x000CE798
		// (set) Token: 0x06001EA3 RID: 7843 RVA: 0x0000CDA2 File Offset: 0x0000AFA2
		public unsafe WormAgent KHAgent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftKHAgent.NativeFieldInfoPtr_KHAgent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAgent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftKHAgent.NativeFieldInfoPtr_KHAgent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001348 RID: 4936
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04001349 RID: 4937
		private static readonly IntPtr NativeFieldInfoPtr_KHAgent;

		// Token: 0x0400134A RID: 4938
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0;

		// Token: 0x0400134B RID: 4939
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedGraftKHAgent_Match_0;

		// Token: 0x0400134C RID: 4940
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x0400134D RID: 4941
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x0200078B RID: 1931
		[ObfuscatedName("worm.canis.actions.Immortality.GraftKHAgent+<execute>d__4")]
		public sealed class _execute_d__4 : Object
		{
			// Token: 0x06006CF3 RID: 27891 RVA: 0x002004F8 File Offset: 0x001FE6F8
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__4()
			{
				Il2CppClassPointerStore<GraftKHAgent._execute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraftKHAgent>.NativeClassPtr, "<execute>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraftKHAgent._execute_d__4>.NativeClassPtr);
				GraftKHAgent._execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraftKHAgent._execute_d__4>.NativeClassPtr, "<>1__state");
				GraftKHAgent._execute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraftKHAgent._execute_d__4>.NativeClassPtr, "<>2__current");
				GraftKHAgent._execute_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraftKHAgent._execute_d__4>.NativeClassPtr, "<>l__initialThreadId");
				GraftKHAgent._execute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraftKHAgent._execute_d__4>.NativeClassPtr, "<>4__this");
				GraftKHAgent._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftKHAgent._execute_d__4>.NativeClassPtr, 100670477);
				GraftKHAgent._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftKHAgent._execute_d__4>.NativeClassPtr, 100670478);
				GraftKHAgent._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftKHAgent._execute_d__4>.NativeClassPtr, 100670479);
				GraftKHAgent._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftKHAgent._execute_d__4>.NativeClassPtr, 100670480);
				GraftKHAgent._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftKHAgent._execute_d__4>.NativeClassPtr, 100670481);
				GraftKHAgent._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftKHAgent._execute_d__4>.NativeClassPtr, 100670482);
				GraftKHAgent._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftKHAgent._execute_d__4>.NativeClassPtr, 100670483);
				GraftKHAgent._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraftKHAgent._execute_d__4>.NativeClassPtr, 100670484);
			}

			// Token: 0x06006CF4 RID: 27892 RVA: 0x00200614 File Offset: 0x001FE814
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraftKHAgent._execute_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraftKHAgent._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006CF5 RID: 27893 RVA: 0x0020065C File Offset: 0x001FE85C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraftKHAgent._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006CF6 RID: 27894 RVA: 0x00200690 File Offset: 0x001FE890
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171544, XrefRangeEnd = 171551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraftKHAgent._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001DCD RID: 7629
			// (get) Token: 0x06006CF7 RID: 27895 RVA: 0x002006CC File Offset: 0x001FE8CC
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraftKHAgent._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006CF8 RID: 27896 RVA: 0x0020070C File Offset: 0x001FE90C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171551, XrefRangeEnd = 171556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraftKHAgent._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001DCE RID: 7630
			// (get) Token: 0x06006CF9 RID: 27897 RVA: 0x00200740 File Offset: 0x001FE940
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraftKHAgent._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006CFA RID: 27898 RVA: 0x00200780 File Offset: 0x001FE980
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171556, XrefRangeEnd = 171558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraftKHAgent._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006CFB RID: 27899 RVA: 0x002007C0 File Offset: 0x001FE9C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraftKHAgent._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006CFC RID: 27900 RVA: 0x0002B3EE File Offset: 0x000295EE
			public _execute_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001DC9 RID: 7625
			// (get) Token: 0x06006CFD RID: 27901 RVA: 0x00200800 File Offset: 0x001FEA00
			// (set) Token: 0x06006CFE RID: 27902 RVA: 0x0002B3F7 File Offset: 0x000295F7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftKHAgent._execute_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftKHAgent._execute_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001DCA RID: 7626
			// (get) Token: 0x06006CFF RID: 27903 RVA: 0x00200828 File Offset: 0x001FEA28
			// (set) Token: 0x06006D00 RID: 27904 RVA: 0x0002B412 File Offset: 0x00029612
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftKHAgent._execute_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftKHAgent._execute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DCB RID: 7627
			// (get) Token: 0x06006D01 RID: 27905 RVA: 0x00200858 File Offset: 0x001FEA58
			// (set) Token: 0x06006D02 RID: 27906 RVA: 0x0002B431 File Offset: 0x00029631
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftKHAgent._execute_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftKHAgent._execute_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001DCC RID: 7628
			// (get) Token: 0x06006D03 RID: 27907 RVA: 0x00200880 File Offset: 0x001FEA80
			// (set) Token: 0x06006D04 RID: 27908 RVA: 0x0002B44C File Offset: 0x0002964C
			public unsafe GraftKHAgent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftKHAgent._execute_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraftKHAgent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraftKHAgent._execute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004665 RID: 18021
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004666 RID: 18022
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004667 RID: 18023
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004668 RID: 18024
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004669 RID: 18025
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400466A RID: 18026
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400466B RID: 18027
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400466C RID: 18028
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400466D RID: 18029
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400466E RID: 18030
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400466F RID: 18031
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004670 RID: 18032
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
