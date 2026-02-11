using System;
using Canis.boardgames;
using Canis.messages;
using Canis.utils.ids;
using dwd.core.data.providers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Networking.game.messages.observer;

namespace boardgames.match.behaviours
{
	// Token: 0x02000285 RID: 645
	public class ObserversProvider : DataProvider
	{
		// Token: 0x06001E36 RID: 7734 RVA: 0x00082378 File Offset: 0x00080578
		// Note: this type is marked as 'beforefieldinit'.
		static ObserversProvider()
		{
			Il2CppClassPointerStore<ObserversProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.behaviours", "ObserversProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObserversProvider>.NativeClassPtr);
			ObserversProvider.NativeFieldInfoPtr_observersByObservedAccount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserversProvider>.NativeClassPtr, "observersByObservedAccount");
			ObserversProvider.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserversProvider>.NativeClassPtr, "match");
			ObserversProvider.NativeMethodInfoPtr_get_TotalObserverCount_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversProvider>.NativeClassPtr, 100668248);
			ObserversProvider.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversProvider>.NativeClassPtr, 100668249);
			ObserversProvider.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversProvider>.NativeClassPtr, 100668250);
			ObserversProvider.NativeMethodInfoPtr_GetObserversForAccountID_Public_IReadOnlyList_1_AccountIDUsernameMetadata_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversProvider>.NativeClassPtr, 100668251);
			ObserversProvider.NativeMethodInfoPtr_SetAllowObservers_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversProvider>.NativeClassPtr, 100668252);
			ObserversProvider.NativeMethodInfoPtr_HandleObserverList_Private_Void_ObserverList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversProvider>.NativeClassPtr, 100668253);
			ObserversProvider.NativeMethodInfoPtr_HandleObserverJoined_Private_Void_ObserverJoined_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversProvider>.NativeClassPtr, 100668254);
			ObserversProvider.NativeMethodInfoPtr_HandleObserverLeft_Private_Void_ObserverLeft_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversProvider>.NativeClassPtr, 100668255);
			ObserversProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversProvider>.NativeClassPtr, 100668256);
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06001E37 RID: 7735 RVA: 0x00082484 File Offset: 0x00080684
		public unsafe ulong TotalObserverCount
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 538571, RefRangeEnd = 538578, XrefRangeStart = 538550, XrefRangeEnd = 538571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserversProvider.NativeMethodInfoPtr_get_TotalObserverCount_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x000824C0 File Offset: 0x000806C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538578, XrefRangeEnd = 538583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserversProvider.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x00082500 File Offset: 0x00080700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538583, XrefRangeEnd = 538614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserversProvider.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x00082534 File Offset: 0x00080734
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 538621, RefRangeEnd = 538622, XrefRangeStart = 538614, XrefRangeEnd = 538621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IReadOnlyList<AccountIDUsernameMetadata> GetObserversForAccountID(AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserversProvider.NativeMethodInfoPtr_GetObserversForAccountID_Public_IReadOnlyList_1_AccountIDUsernameMetadata_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<AccountIDUsernameMetadata>>(intPtr3) : null;
			}
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x00082584 File Offset: 0x00080784
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 538631, RefRangeEnd = 538632, XrefRangeStart = 538622, XrefRangeEnd = 538631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAllowObservers(bool allow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allow;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserversProvider.NativeMethodInfoPtr_SetAllowObservers_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x000825C4 File Offset: 0x000807C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538632, XrefRangeEnd = 538666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleObserverList(ObserverList message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserversProvider.NativeMethodInfoPtr_HandleObserverList_Private_Void_ObserverList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x00082608 File Offset: 0x00080808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538666, XrefRangeEnd = 538698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleObserverJoined(ObserverJoined message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserversProvider.NativeMethodInfoPtr_HandleObserverJoined_Private_Void_ObserverJoined_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x0008264C File Offset: 0x0008084C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538698, XrefRangeEnd = 538735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleObserverLeft(ObserverLeft message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserversProvider.NativeMethodInfoPtr_HandleObserverLeft_Private_Void_ObserverLeft_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x00082690 File Offset: 0x00080890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538735, XrefRangeEnd = 538743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObserversProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObserversProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserversProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x0000FF40 File Offset: 0x0000E140
		public ObserversProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06001E41 RID: 7745 RVA: 0x000826CC File Offset: 0x000808CC
		// (set) Token: 0x06001E42 RID: 7746 RVA: 0x0000FF49 File Offset: 0x0000E149
		public unsafe Dictionary<AccountID, List<AccountIDUsernameMetadata>> observersByObservedAccount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversProvider.NativeFieldInfoPtr_observersByObservedAccount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, List<AccountIDUsernameMetadata>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversProvider.NativeFieldInfoPtr_observersByObservedAccount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06001E43 RID: 7747 RVA: 0x000826FC File Offset: 0x000808FC
		// (set) Token: 0x06001E44 RID: 7748 RVA: 0x0000FF68 File Offset: 0x0000E168
		public unsafe CanisMatch match
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversProvider.NativeFieldInfoPtr_match);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanisMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversProvider.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001314 RID: 4884
		private static readonly IntPtr NativeFieldInfoPtr_observersByObservedAccount;

		// Token: 0x04001315 RID: 4885
		private static readonly IntPtr NativeFieldInfoPtr_match;

		// Token: 0x04001316 RID: 4886
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalObserverCount_Public_get_UInt64_0;

		// Token: 0x04001317 RID: 4887
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x04001318 RID: 4888
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001319 RID: 4889
		private static readonly IntPtr NativeMethodInfoPtr_GetObserversForAccountID_Public_IReadOnlyList_1_AccountIDUsernameMetadata_AccountID_0;

		// Token: 0x0400131A RID: 4890
		private static readonly IntPtr NativeMethodInfoPtr_SetAllowObservers_Public_Void_Boolean_0;

		// Token: 0x0400131B RID: 4891
		private static readonly IntPtr NativeMethodInfoPtr_HandleObserverList_Private_Void_ObserverList_0;

		// Token: 0x0400131C RID: 4892
		private static readonly IntPtr NativeMethodInfoPtr_HandleObserverJoined_Private_Void_ObserverJoined_0;

		// Token: 0x0400131D RID: 4893
		private static readonly IntPtr NativeMethodInfoPtr_HandleObserverLeft_Private_Void_ObserverLeft_0;

		// Token: 0x0400131E RID: 4894
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000476 RID: 1142
		[ObfuscatedName("boardgames.match.behaviours.ObserversProvider+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003607 RID: 13831 RVA: 0x000C9DA4 File Offset: 0x000C7FA4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ObserversProvider.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObserversProvider>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObserversProvider.__c>.NativeClassPtr);
				ObserversProvider.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserversProvider.__c>.NativeClassPtr, "<>9");
				ObserversProvider.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserversProvider.__c>.NativeClassPtr, "<>9__1_0");
				ObserversProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversProvider.__c>.NativeClassPtr, 100668258);
				ObserversProvider.__c.NativeMethodInfoPtr__get_TotalObserverCount_b__1_0_Internal_UInt64_KeyValuePair_2_AccountID_List_1_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversProvider.__c>.NativeClassPtr, 100668259);
			}

			// Token: 0x06003608 RID: 13832 RVA: 0x000C9E20 File Offset: 0x000C8020
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObserversProvider.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserversProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003609 RID: 13833 RVA: 0x000C9E5C File Offset: 0x000C805C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538497, XrefRangeEnd = 538499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ulong _get_TotalObserverCount_b__1_0(KeyValuePair<AccountID, List<AccountIDUsernameMetadata>> kvp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserversProvider.__c.NativeMethodInfoPtr__get_TotalObserverCount_b__1_0_Internal_UInt64_KeyValuePair_2_AccountID_List_1_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600360A RID: 13834 RVA: 0x0001BD96 File Offset: 0x00019F96
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FDB RID: 4059
			// (get) Token: 0x0600360B RID: 13835 RVA: 0x000C9EB0 File Offset: 0x000C80B0
			// (set) Token: 0x0600360C RID: 13836 RVA: 0x0001BD9F File Offset: 0x00019F9F
			public unsafe static ObserversProvider.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ObserversProvider.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObserversProvider.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ObserversProvider.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FDC RID: 4060
			// (get) Token: 0x0600360D RID: 13837 RVA: 0x000C9ED8 File Offset: 0x000C80D8
			// (set) Token: 0x0600360E RID: 13838 RVA: 0x0001BDB1 File Offset: 0x00019FB1
			public unsafe static Func<KeyValuePair<AccountID, List<AccountIDUsernameMetadata>>, ulong> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ObserversProvider.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<AccountID, List<AccountIDUsernameMetadata>>, ulong>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ObserversProvider.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002141 RID: 8513
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002142 RID: 8514
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04002143 RID: 8515
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002144 RID: 8516
			private static readonly IntPtr NativeMethodInfoPtr__get_TotalObserverCount_b__1_0_Internal_UInt64_KeyValuePair_2_AccountID_List_1_AccountIDUsernameMetadata_0;
		}

		// Token: 0x02000477 RID: 1143
		[ObfuscatedName("boardgames.match.behaviours.ObserversProvider+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x0600360F RID: 13839 RVA: 0x000C9F00 File Offset: 0x000C8100
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<ObserversProvider.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObserversProvider>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObserversProvider.__c__DisplayClass10_0>.NativeClassPtr);
				ObserversProvider.__c__DisplayClass10_0.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserversProvider.__c__DisplayClass10_0>.NativeClassPtr, "message");
				ObserversProvider.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversProvider.__c__DisplayClass10_0>.NativeClassPtr, 100668260);
				ObserversProvider.__c__DisplayClass10_0.NativeMethodInfoPtr__HandleObserverLeft_b__0_Internal_Boolean_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversProvider.__c__DisplayClass10_0>.NativeClassPtr, 100668261);
			}

			// Token: 0x06003610 RID: 13840 RVA: 0x000C9F68 File Offset: 0x000C8168
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObserversProvider.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserversProvider.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003611 RID: 13841 RVA: 0x000C9FA4 File Offset: 0x000C81A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538499, XrefRangeEnd = 538504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HandleObserverLeft_b__0(AccountIDUsernameMetadata o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserversProvider.__c__DisplayClass10_0.NativeMethodInfoPtr__HandleObserverLeft_b__0_Internal_Boolean_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003612 RID: 13842 RVA: 0x0001BDC3 File Offset: 0x00019FC3
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FDD RID: 4061
			// (get) Token: 0x06003613 RID: 13843 RVA: 0x000C9FF4 File Offset: 0x000C81F4
			// (set) Token: 0x06003614 RID: 13844 RVA: 0x0001BDCC File Offset: 0x00019FCC
			public unsafe ObserverLeft message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversProvider.__c__DisplayClass10_0.NativeFieldInfoPtr_message);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObserverLeft>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversProvider.__c__DisplayClass10_0.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002145 RID: 8517
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x04002146 RID: 8518
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002147 RID: 8519
			private static readonly IntPtr NativeMethodInfoPtr__HandleObserverLeft_b__0_Internal_Boolean_AccountIDUsernameMetadata_0;
		}

		// Token: 0x02000478 RID: 1144
		[ObfuscatedName("boardgames.match.behaviours.ObserversProvider+<Start>d__4")]
		public sealed class _Start_d__4 : Object
		{
			// Token: 0x06003615 RID: 13845 RVA: 0x000CA024 File Offset: 0x000C8224
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__4()
			{
				Il2CppClassPointerStore<ObserversProvider._Start_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObserversProvider>.NativeClassPtr, "<Start>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObserversProvider._Start_d__4>.NativeClassPtr);
				ObserversProvider._Start_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserversProvider._Start_d__4>.NativeClassPtr, "<>1__state");
				ObserversProvider._Start_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserversProvider._Start_d__4>.NativeClassPtr, "<>2__current");
				ObserversProvider._Start_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserversProvider._Start_d__4>.NativeClassPtr, "<>4__this");
				ObserversProvider._Start_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversProvider._Start_d__4>.NativeClassPtr, 100668262);
				ObserversProvider._Start_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversProvider._Start_d__4>.NativeClassPtr, 100668263);
				ObserversProvider._Start_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversProvider._Start_d__4>.NativeClassPtr, 100668264);
				ObserversProvider._Start_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversProvider._Start_d__4>.NativeClassPtr, 100668265);
				ObserversProvider._Start_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversProvider._Start_d__4>.NativeClassPtr, 100668266);
				ObserversProvider._Start_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversProvider._Start_d__4>.NativeClassPtr, 100668267);
			}

			// Token: 0x06003616 RID: 13846 RVA: 0x000CA104 File Offset: 0x000C8304
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObserversProvider._Start_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserversProvider._Start_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003617 RID: 13847 RVA: 0x000CA14C File Offset: 0x000C834C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserversProvider._Start_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003618 RID: 13848 RVA: 0x000CA180 File Offset: 0x000C8380
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538504, XrefRangeEnd = 538545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserversProvider._Start_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000FE1 RID: 4065
			// (get) Token: 0x06003619 RID: 13849 RVA: 0x000CA1BC File Offset: 0x000C83BC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserversProvider._Start_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600361A RID: 13850 RVA: 0x000CA1FC File Offset: 0x000C83FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538545, XrefRangeEnd = 538550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserversProvider._Start_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000FE2 RID: 4066
			// (get) Token: 0x0600361B RID: 13851 RVA: 0x000CA230 File Offset: 0x000C8430
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserversProvider._Start_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600361C RID: 13852 RVA: 0x0001BDEB File Offset: 0x00019FEB
			public _Start_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FDE RID: 4062
			// (get) Token: 0x0600361D RID: 13853 RVA: 0x000CA270 File Offset: 0x000C8470
			// (set) Token: 0x0600361E RID: 13854 RVA: 0x0001BDF4 File Offset: 0x00019FF4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversProvider._Start_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversProvider._Start_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000FDF RID: 4063
			// (get) Token: 0x0600361F RID: 13855 RVA: 0x000CA298 File Offset: 0x000C8498
			// (set) Token: 0x06003620 RID: 13856 RVA: 0x0001BE0F File Offset: 0x0001A00F
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversProvider._Start_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversProvider._Start_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FE0 RID: 4064
			// (get) Token: 0x06003621 RID: 13857 RVA: 0x000CA2C8 File Offset: 0x000C84C8
			// (set) Token: 0x06003622 RID: 13858 RVA: 0x0001BE2E File Offset: 0x0001A02E
			public unsafe ObserversProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversProvider._Start_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObserversProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversProvider._Start_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002148 RID: 8520
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002149 RID: 8521
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400214A RID: 8522
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400214B RID: 8523
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400214C RID: 8524
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400214D RID: 8525
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400214E RID: 8526
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400214F RID: 8527
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002150 RID: 8528
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
