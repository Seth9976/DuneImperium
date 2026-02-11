using System;
using Canis;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace boardgames.match.commands
{
	// Token: 0x02000291 RID: 657
	public class PlayOfflineMatch : PlayMatchCommand
	{
		// Token: 0x06001EE3 RID: 7907 RVA: 0x000849B0 File Offset: 0x00082BB0
		// Note: this type is marked as 'beforefieldinit'.
		static PlayOfflineMatch()
		{
			Il2CppClassPointerStore<PlayOfflineMatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.commands", "PlayOfflineMatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayOfflineMatch>.NativeClassPtr);
			PlayOfflineMatch.NativeFieldInfoPtr__matchInitData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayOfflineMatch>.NativeClassPtr, "<matchInitData>k__BackingField");
			PlayOfflineMatch.NativeFieldInfoPtr_isResume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayOfflineMatch>.NativeClassPtr, "isResume");
			PlayOfflineMatch.NativeMethodInfoPtr_get_matchInitData_Public_get_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayOfflineMatch>.NativeClassPtr, 100668424);
			PlayOfflineMatch.NativeMethodInfoPtr_get_GameID_Public_Virtual_get_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayOfflineMatch>.NativeClassPtr, 100668425);
			PlayOfflineMatch.NativeMethodInfoPtr__ctor_Public_Void_MatchInitData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayOfflineMatch>.NativeClassPtr, 100668426);
			PlayOfflineMatch.NativeMethodInfoPtr_establishMatchContext_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayOfflineMatch>.NativeClassPtr, 100668427);
			PlayOfflineMatch.NativeMethodInfoPtr_createGameData_Protected_Virtual_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayOfflineMatch>.NativeClassPtr, 100668428);
			PlayOfflineMatch.NativeMethodInfoPtr_createSpinnerData_Protected_Virtual_List_1_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayOfflineMatch>.NativeClassPtr, 100668429);
			PlayOfflineMatch.NativeMethodInfoPtr_setupSessionRelay_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayOfflineMatch>.NativeClassPtr, 100668430);
			PlayOfflineMatch.NativeMethodInfoPtr_handleLoadTimeout_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayOfflineMatch>.NativeClassPtr, 100668431);
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06001EE4 RID: 7908 RVA: 0x00084AA8 File Offset: 0x00082CA8
		public unsafe MatchInitData matchInitData
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayOfflineMatch.NativeMethodInfoPtr_get_matchInitData_Public_get_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr3) : null;
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06001EE5 RID: 7909 RVA: 0x00084AE8 File Offset: 0x00082CE8
		public unsafe override GameID GameID
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 372752, RefRangeEnd = 372755, XrefRangeStart = 372752, XrefRangeEnd = 372755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayOfflineMatch.NativeMethodInfoPtr_get_GameID_Public_Virtual_get_GameID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr3) : null;
			}
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x00084B34 File Offset: 0x00082D34
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 539891, RefRangeEnd = 539906, XrefRangeStart = 539891, XrefRangeEnd = 539906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayOfflineMatch(MatchInitData matchInitData, bool isResume)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayOfflineMatch>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchInitData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isResume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayOfflineMatch.NativeMethodInfoPtr__ctor_Public_Void_MatchInitData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x00084B90 File Offset: 0x00082D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540378, XrefRangeEnd = 540383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator establishMatchContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayOfflineMatch.NativeMethodInfoPtr_establishMatchContext_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x00084BDC File Offset: 0x00082DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540383, XrefRangeEnd = 540413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DataComposition createGameData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayOfflineMatch.NativeMethodInfoPtr_createGameData_Protected_Virtual_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x00084C28 File Offset: 0x00082E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540413, XrefRangeEnd = 540428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<DataComponent> createSpinnerData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayOfflineMatch.NativeMethodInfoPtr_createSpinnerData_Protected_Virtual_List_1_DataComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DataComponent>>(intPtr3) : null;
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x00084C74 File Offset: 0x00082E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540428, XrefRangeEnd = 540433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator setupSessionRelay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayOfflineMatch.NativeMethodInfoPtr_setupSessionRelay_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x00084CC0 File Offset: 0x00082EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540433, XrefRangeEnd = 540438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator handleLoadTimeout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayOfflineMatch.NativeMethodInfoPtr_handleLoadTimeout_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x00010408 File Offset: 0x0000E608
		public PlayOfflineMatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06001EED RID: 7917 RVA: 0x00084D0C File Offset: 0x00082F0C
		// (set) Token: 0x06001EEE RID: 7918 RVA: 0x00010411 File Offset: 0x0000E611
		public unsafe MatchInitData _matchInitData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayOfflineMatch.NativeFieldInfoPtr__matchInitData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayOfflineMatch.NativeFieldInfoPtr__matchInitData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06001EEF RID: 7919 RVA: 0x00084D3C File Offset: 0x00082F3C
		// (set) Token: 0x06001EF0 RID: 7920 RVA: 0x00010430 File Offset: 0x0000E630
		public unsafe bool isResume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayOfflineMatch.NativeFieldInfoPtr_isResume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayOfflineMatch.NativeFieldInfoPtr_isResume)) = value;
			}
		}

		// Token: 0x04001385 RID: 4997
		private static readonly IntPtr NativeFieldInfoPtr__matchInitData_k__BackingField;

		// Token: 0x04001386 RID: 4998
		private static readonly IntPtr NativeFieldInfoPtr_isResume;

		// Token: 0x04001387 RID: 4999
		private static readonly IntPtr NativeMethodInfoPtr_get_matchInitData_Public_get_MatchInitData_0;

		// Token: 0x04001388 RID: 5000
		private static readonly IntPtr NativeMethodInfoPtr_get_GameID_Public_Virtual_get_GameID_0;

		// Token: 0x04001389 RID: 5001
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MatchInitData_Boolean_0;

		// Token: 0x0400138A RID: 5002
		private static readonly IntPtr NativeMethodInfoPtr_establishMatchContext_Protected_Virtual_IEnumerator_0;

		// Token: 0x0400138B RID: 5003
		private static readonly IntPtr NativeMethodInfoPtr_createGameData_Protected_Virtual_DataComposition_0;

		// Token: 0x0400138C RID: 5004
		private static readonly IntPtr NativeMethodInfoPtr_createSpinnerData_Protected_Virtual_List_1_DataComponent_0;

		// Token: 0x0400138D RID: 5005
		private static readonly IntPtr NativeMethodInfoPtr_setupSessionRelay_Protected_Virtual_IEnumerator_0;

		// Token: 0x0400138E RID: 5006
		private static readonly IntPtr NativeMethodInfoPtr_handleLoadTimeout_Protected_Virtual_IEnumerator_0;

		// Token: 0x0200048A RID: 1162
		[ObfuscatedName("boardgames.match.commands.PlayOfflineMatch+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600370F RID: 14095 RVA: 0x000CCF9C File Offset: 0x000CB19C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PlayOfflineMatch.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayOfflineMatch>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayOfflineMatch.__c>.NativeClassPtr);
				PlayOfflineMatch.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayOfflineMatch.__c>.NativeClassPtr, "<>9");
				PlayOfflineMatch.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayOfflineMatch.__c>.NativeClassPtr, "<>9__7_0");
				PlayOfflineMatch.__c.NativeFieldInfoPtr___9__7_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayOfflineMatch.__c>.NativeClassPtr, "<>9__7_2");
				PlayOfflineMatch.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayOfflineMatch.__c>.NativeClassPtr, 100668433);
				PlayOfflineMatch.__c.NativeMethodInfoPtr__establishMatchContext_b__7_0_Internal_Boolean_PlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayOfflineMatch.__c>.NativeClassPtr, 100668434);
				PlayOfflineMatch.__c.NativeMethodInfoPtr__establishMatchContext_b__7_2_Internal_Boolean_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayOfflineMatch.__c>.NativeClassPtr, 100668435);
			}

			// Token: 0x06003710 RID: 14096 RVA: 0x000CD040 File Offset: 0x000CB240
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayOfflineMatch.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayOfflineMatch.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003711 RID: 14097 RVA: 0x000CD07C File Offset: 0x000CB27C
			[CallerCount(0)]
			public unsafe bool _establishMatchContext_b__7_0(PlayerMatchInitData p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayOfflineMatch.__c.NativeMethodInfoPtr__establishMatchContext_b__7_0_Internal_Boolean_PlayerMatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003712 RID: 14098 RVA: 0x000CD0CC File Offset: 0x000CB2CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540210, XrefRangeEnd = 540211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _establishMatchContext_b__7_2(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayOfflineMatch.__c.NativeMethodInfoPtr__establishMatchContext_b__7_2_Internal_Boolean_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003713 RID: 14099 RVA: 0x0001C54D File Offset: 0x0001A74D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001036 RID: 4150
			// (get) Token: 0x06003714 RID: 14100 RVA: 0x000CD11C File Offset: 0x000CB31C
			// (set) Token: 0x06003715 RID: 14101 RVA: 0x0001C556 File Offset: 0x0001A756
			public unsafe static PlayOfflineMatch.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayOfflineMatch.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayOfflineMatch.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayOfflineMatch.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001037 RID: 4151
			// (get) Token: 0x06003716 RID: 14102 RVA: 0x000CD144 File Offset: 0x000CB344
			// (set) Token: 0x06003717 RID: 14103 RVA: 0x0001C568 File Offset: 0x0001A768
			public unsafe static Func<PlayerMatchInitData, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayOfflineMatch.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerMatchInitData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayOfflineMatch.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001038 RID: 4152
			// (get) Token: 0x06003718 RID: 14104 RVA: 0x000CD16C File Offset: 0x000CB36C
			// (set) Token: 0x06003719 RID: 14105 RVA: 0x0001C57A File Offset: 0x0001A77A
			public unsafe static Func<Command, bool> __9__7_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayOfflineMatch.__c.NativeFieldInfoPtr___9__7_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Command, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayOfflineMatch.__c.NativeFieldInfoPtr___9__7_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021E0 RID: 8672
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040021E1 RID: 8673
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x040021E2 RID: 8674
			private static readonly IntPtr NativeFieldInfoPtr___9__7_2;

			// Token: 0x040021E3 RID: 8675
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040021E4 RID: 8676
			private static readonly IntPtr NativeMethodInfoPtr__establishMatchContext_b__7_0_Internal_Boolean_PlayerMatchInitData_0;

			// Token: 0x040021E5 RID: 8677
			private static readonly IntPtr NativeMethodInfoPtr__establishMatchContext_b__7_2_Internal_Boolean_Command_0;
		}

		// Token: 0x0200048B RID: 1163
		[ObfuscatedName("boardgames.match.commands.PlayOfflineMatch+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x0600371A RID: 14106 RVA: 0x000CD194 File Offset: 0x000CB394
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<PlayOfflineMatch.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayOfflineMatch>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayOfflineMatch.__c__DisplayClass7_0>.NativeClassPtr);
				PlayOfflineMatch.__c__DisplayClass7_0.NativeFieldInfoPtr_selectionPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayOfflineMatch.__c__DisplayClass7_0>.NativeClassPtr, "selectionPlayers");
				PlayOfflineMatch.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayOfflineMatch.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				PlayOfflineMatch.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayOfflineMatch.__c__DisplayClass7_0>.NativeClassPtr, 100668436);
				PlayOfflineMatch.__c__DisplayClass7_0.NativeMethodInfoPtr__establishMatchContext_b__1_Internal_Int32_PlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayOfflineMatch.__c__DisplayClass7_0>.NativeClassPtr, 100668437);
			}

			// Token: 0x0600371B RID: 14107 RVA: 0x000CD210 File Offset: 0x000CB410
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayOfflineMatch.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayOfflineMatch.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600371C RID: 14108 RVA: 0x000CD24C File Offset: 0x000CB44C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540211, XrefRangeEnd = 540218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _establishMatchContext_b__1(PlayerMatchInitData hp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(hp);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayOfflineMatch.__c__DisplayClass7_0.NativeMethodInfoPtr__establishMatchContext_b__1_Internal_Int32_PlayerMatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600371D RID: 14109 RVA: 0x0001C58C File Offset: 0x0001A78C
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001039 RID: 4153
			// (get) Token: 0x0600371E RID: 14110 RVA: 0x000CD29C File Offset: 0x000CB49C
			// (set) Token: 0x0600371F RID: 14111 RVA: 0x0001C595 File Offset: 0x0001A795
			public unsafe IEnumerable<AccountID> selectionPlayers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayOfflineMatch.__c__DisplayClass7_0.NativeFieldInfoPtr_selectionPlayers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<AccountID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayOfflineMatch.__c__DisplayClass7_0.NativeFieldInfoPtr_selectionPlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700103A RID: 4154
			// (get) Token: 0x06003720 RID: 14112 RVA: 0x000CD2CC File Offset: 0x000CB4CC
			// (set) Token: 0x06003721 RID: 14113 RVA: 0x0001C5B4 File Offset: 0x0001A7B4
			public unsafe PlayOfflineMatch __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayOfflineMatch.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayOfflineMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayOfflineMatch.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021E6 RID: 8678
			private static readonly IntPtr NativeFieldInfoPtr_selectionPlayers;

			// Token: 0x040021E7 RID: 8679
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040021E8 RID: 8680
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040021E9 RID: 8681
			private static readonly IntPtr NativeMethodInfoPtr__establishMatchContext_b__1_Internal_Int32_PlayerMatchInitData_0;
		}

		// Token: 0x0200048C RID: 1164
		[ObfuscatedName("boardgames.match.commands.PlayOfflineMatch+<establishMatchContext>d__7")]
		public sealed class _establishMatchContext_d__7 : Object
		{
			// Token: 0x06003722 RID: 14114 RVA: 0x000CD2FC File Offset: 0x000CB4FC
			// Note: this type is marked as 'beforefieldinit'.
			static _establishMatchContext_d__7()
			{
				Il2CppClassPointerStore<PlayOfflineMatch._establishMatchContext_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayOfflineMatch>.NativeClassPtr, "<establishMatchContext>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayOfflineMatch._establishMatchContext_d__7>.NativeClassPtr);
				PlayOfflineMatch._establishMatchContext_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayOfflineMatch._establishMatchContext_d__7>.NativeClassPtr, "<>1__state");
				PlayOfflineMatch._establishMatchContext_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayOfflineMatch._establishMatchContext_d__7>.NativeClassPtr, "<>2__current");
				PlayOfflineMatch._establishMatchContext_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayOfflineMatch._establishMatchContext_d__7>.NativeClassPtr, "<>4__this");
				PlayOfflineMatch._establishMatchContext_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayOfflineMatch._establishMatchContext_d__7>.NativeClassPtr, 100668438);
				PlayOfflineMatch._establishMatchContext_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayOfflineMatch._establishMatchContext_d__7>.NativeClassPtr, 100668439);
				PlayOfflineMatch._establishMatchContext_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayOfflineMatch._establishMatchContext_d__7>.NativeClassPtr, 100668440);
				PlayOfflineMatch._establishMatchContext_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayOfflineMatch._establishMatchContext_d__7>.NativeClassPtr, 100668441);
				PlayOfflineMatch._establishMatchContext_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayOfflineMatch._establishMatchContext_d__7>.NativeClassPtr, 100668442);
				PlayOfflineMatch._establishMatchContext_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayOfflineMatch._establishMatchContext_d__7>.NativeClassPtr, 100668443);
			}

			// Token: 0x06003723 RID: 14115 RVA: 0x000CD3DC File Offset: 0x000CB5DC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _establishMatchContext_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayOfflineMatch._establishMatchContext_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayOfflineMatch._establishMatchContext_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003724 RID: 14116 RVA: 0x000CD424 File Offset: 0x000CB624
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayOfflineMatch._establishMatchContext_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003725 RID: 14117 RVA: 0x000CD458 File Offset: 0x000CB658
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540218, XrefRangeEnd = 540317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayOfflineMatch._establishMatchContext_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700103E RID: 4158
			// (get) Token: 0x06003726 RID: 14118 RVA: 0x000CD494 File Offset: 0x000CB694
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayOfflineMatch._establishMatchContext_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003727 RID: 14119 RVA: 0x000CD4D4 File Offset: 0x000CB6D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540317, XrefRangeEnd = 540322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayOfflineMatch._establishMatchContext_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700103F RID: 4159
			// (get) Token: 0x06003728 RID: 14120 RVA: 0x000CD508 File Offset: 0x000CB708
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayOfflineMatch._establishMatchContext_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003729 RID: 14121 RVA: 0x0001C5D3 File Offset: 0x0001A7D3
			public _establishMatchContext_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700103B RID: 4155
			// (get) Token: 0x0600372A RID: 14122 RVA: 0x000CD548 File Offset: 0x000CB748
			// (set) Token: 0x0600372B RID: 14123 RVA: 0x0001C5DC File Offset: 0x0001A7DC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayOfflineMatch._establishMatchContext_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayOfflineMatch._establishMatchContext_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700103C RID: 4156
			// (get) Token: 0x0600372C RID: 14124 RVA: 0x000CD570 File Offset: 0x000CB770
			// (set) Token: 0x0600372D RID: 14125 RVA: 0x0001C5F7 File Offset: 0x0001A7F7
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayOfflineMatch._establishMatchContext_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayOfflineMatch._establishMatchContext_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700103D RID: 4157
			// (get) Token: 0x0600372E RID: 14126 RVA: 0x000CD5A0 File Offset: 0x000CB7A0
			// (set) Token: 0x0600372F RID: 14127 RVA: 0x0001C616 File Offset: 0x0001A816
			public unsafe PlayOfflineMatch __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayOfflineMatch._establishMatchContext_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayOfflineMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayOfflineMatch._establishMatchContext_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021EA RID: 8682
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040021EB RID: 8683
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040021EC RID: 8684
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040021ED RID: 8685
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040021EE RID: 8686
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040021EF RID: 8687
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040021F0 RID: 8688
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040021F1 RID: 8689
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040021F2 RID: 8690
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200048D RID: 1165
		[ObfuscatedName("boardgames.match.commands.PlayOfflineMatch+<handleLoadTimeout>d__11")]
		public sealed class _handleLoadTimeout_d__11 : Object
		{
			// Token: 0x06003730 RID: 14128 RVA: 0x000CD5D0 File Offset: 0x000CB7D0
			// Note: this type is marked as 'beforefieldinit'.
			static _handleLoadTimeout_d__11()
			{
				Il2CppClassPointerStore<PlayOfflineMatch._handleLoadTimeout_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayOfflineMatch>.NativeClassPtr, "<handleLoadTimeout>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayOfflineMatch._handleLoadTimeout_d__11>.NativeClassPtr);
				PlayOfflineMatch._handleLoadTimeout_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayOfflineMatch._handleLoadTimeout_d__11>.NativeClassPtr, "<>1__state");
				PlayOfflineMatch._handleLoadTimeout_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayOfflineMatch._handleLoadTimeout_d__11>.NativeClassPtr, "<>2__current");
				PlayOfflineMatch._handleLoadTimeout_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayOfflineMatch._handleLoadTimeout_d__11>.NativeClassPtr, "<>4__this");
				PlayOfflineMatch._handleLoadTimeout_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayOfflineMatch._handleLoadTimeout_d__11>.NativeClassPtr, 100668444);
				PlayOfflineMatch._handleLoadTimeout_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayOfflineMatch._handleLoadTimeout_d__11>.NativeClassPtr, 100668445);
				PlayOfflineMatch._handleLoadTimeout_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayOfflineMatch._handleLoadTimeout_d__11>.NativeClassPtr, 100668446);
				PlayOfflineMatch._handleLoadTimeout_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayOfflineMatch._handleLoadTimeout_d__11>.NativeClassPtr, 100668447);
				PlayOfflineMatch._handleLoadTimeout_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayOfflineMatch._handleLoadTimeout_d__11>.NativeClassPtr, 100668448);
				PlayOfflineMatch._handleLoadTimeout_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayOfflineMatch._handleLoadTimeout_d__11>.NativeClassPtr, 100668449);
			}

			// Token: 0x06003731 RID: 14129 RVA: 0x000CD6B0 File Offset: 0x000CB8B0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _handleLoadTimeout_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayOfflineMatch._handleLoadTimeout_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayOfflineMatch._handleLoadTimeout_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003732 RID: 14130 RVA: 0x000CD6F8 File Offset: 0x000CB8F8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayOfflineMatch._handleLoadTimeout_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003733 RID: 14131 RVA: 0x000CD72C File Offset: 0x000CB92C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540322, XrefRangeEnd = 540330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayOfflineMatch._handleLoadTimeout_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001043 RID: 4163
			// (get) Token: 0x06003734 RID: 14132 RVA: 0x000CD768 File Offset: 0x000CB968
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayOfflineMatch._handleLoadTimeout_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003735 RID: 14133 RVA: 0x000CD7A8 File Offset: 0x000CB9A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540330, XrefRangeEnd = 540335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayOfflineMatch._handleLoadTimeout_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001044 RID: 4164
			// (get) Token: 0x06003736 RID: 14134 RVA: 0x000CD7DC File Offset: 0x000CB9DC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayOfflineMatch._handleLoadTimeout_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003737 RID: 14135 RVA: 0x0001C635 File Offset: 0x0001A835
			public _handleLoadTimeout_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001040 RID: 4160
			// (get) Token: 0x06003738 RID: 14136 RVA: 0x000CD81C File Offset: 0x000CBA1C
			// (set) Token: 0x06003739 RID: 14137 RVA: 0x0001C63E File Offset: 0x0001A83E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayOfflineMatch._handleLoadTimeout_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayOfflineMatch._handleLoadTimeout_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001041 RID: 4161
			// (get) Token: 0x0600373A RID: 14138 RVA: 0x000CD844 File Offset: 0x000CBA44
			// (set) Token: 0x0600373B RID: 14139 RVA: 0x0001C659 File Offset: 0x0001A859
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayOfflineMatch._handleLoadTimeout_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayOfflineMatch._handleLoadTimeout_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001042 RID: 4162
			// (get) Token: 0x0600373C RID: 14140 RVA: 0x000CD874 File Offset: 0x000CBA74
			// (set) Token: 0x0600373D RID: 14141 RVA: 0x0001C678 File Offset: 0x0001A878
			public unsafe PlayOfflineMatch __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayOfflineMatch._handleLoadTimeout_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayOfflineMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayOfflineMatch._handleLoadTimeout_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021F3 RID: 8691
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040021F4 RID: 8692
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040021F5 RID: 8693
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040021F6 RID: 8694
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040021F7 RID: 8695
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040021F8 RID: 8696
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040021F9 RID: 8697
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040021FA RID: 8698
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040021FB RID: 8699
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200048E RID: 1166
		[ObfuscatedName("boardgames.match.commands.PlayOfflineMatch+<setupSessionRelay>d__10")]
		public sealed class _setupSessionRelay_d__10 : Object
		{
			// Token: 0x0600373E RID: 14142 RVA: 0x000CD8A4 File Offset: 0x000CBAA4
			// Note: this type is marked as 'beforefieldinit'.
			static _setupSessionRelay_d__10()
			{
				Il2CppClassPointerStore<PlayOfflineMatch._setupSessionRelay_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayOfflineMatch>.NativeClassPtr, "<setupSessionRelay>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayOfflineMatch._setupSessionRelay_d__10>.NativeClassPtr);
				PlayOfflineMatch._setupSessionRelay_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayOfflineMatch._setupSessionRelay_d__10>.NativeClassPtr, "<>1__state");
				PlayOfflineMatch._setupSessionRelay_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayOfflineMatch._setupSessionRelay_d__10>.NativeClassPtr, "<>2__current");
				PlayOfflineMatch._setupSessionRelay_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayOfflineMatch._setupSessionRelay_d__10>.NativeClassPtr, "<>4__this");
				PlayOfflineMatch._setupSessionRelay_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayOfflineMatch._setupSessionRelay_d__10>.NativeClassPtr, 100668450);
				PlayOfflineMatch._setupSessionRelay_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayOfflineMatch._setupSessionRelay_d__10>.NativeClassPtr, 100668451);
				PlayOfflineMatch._setupSessionRelay_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayOfflineMatch._setupSessionRelay_d__10>.NativeClassPtr, 100668452);
				PlayOfflineMatch._setupSessionRelay_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayOfflineMatch._setupSessionRelay_d__10>.NativeClassPtr, 100668453);
				PlayOfflineMatch._setupSessionRelay_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayOfflineMatch._setupSessionRelay_d__10>.NativeClassPtr, 100668454);
				PlayOfflineMatch._setupSessionRelay_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayOfflineMatch._setupSessionRelay_d__10>.NativeClassPtr, 100668455);
			}

			// Token: 0x0600373F RID: 14143 RVA: 0x000CD984 File Offset: 0x000CBB84
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _setupSessionRelay_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayOfflineMatch._setupSessionRelay_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayOfflineMatch._setupSessionRelay_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003740 RID: 14144 RVA: 0x000CD9CC File Offset: 0x000CBBCC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayOfflineMatch._setupSessionRelay_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003741 RID: 14145 RVA: 0x000CDA00 File Offset: 0x000CBC00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540335, XrefRangeEnd = 540373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayOfflineMatch._setupSessionRelay_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001048 RID: 4168
			// (get) Token: 0x06003742 RID: 14146 RVA: 0x000CDA3C File Offset: 0x000CBC3C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayOfflineMatch._setupSessionRelay_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003743 RID: 14147 RVA: 0x000CDA7C File Offset: 0x000CBC7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540373, XrefRangeEnd = 540378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayOfflineMatch._setupSessionRelay_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001049 RID: 4169
			// (get) Token: 0x06003744 RID: 14148 RVA: 0x000CDAB0 File Offset: 0x000CBCB0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayOfflineMatch._setupSessionRelay_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003745 RID: 14149 RVA: 0x0001C697 File Offset: 0x0001A897
			public _setupSessionRelay_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001045 RID: 4165
			// (get) Token: 0x06003746 RID: 14150 RVA: 0x000CDAF0 File Offset: 0x000CBCF0
			// (set) Token: 0x06003747 RID: 14151 RVA: 0x0001C6A0 File Offset: 0x0001A8A0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayOfflineMatch._setupSessionRelay_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayOfflineMatch._setupSessionRelay_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001046 RID: 4166
			// (get) Token: 0x06003748 RID: 14152 RVA: 0x000CDB18 File Offset: 0x000CBD18
			// (set) Token: 0x06003749 RID: 14153 RVA: 0x0001C6BB File Offset: 0x0001A8BB
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayOfflineMatch._setupSessionRelay_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayOfflineMatch._setupSessionRelay_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001047 RID: 4167
			// (get) Token: 0x0600374A RID: 14154 RVA: 0x000CDB48 File Offset: 0x000CBD48
			// (set) Token: 0x0600374B RID: 14155 RVA: 0x0001C6DA File Offset: 0x0001A8DA
			public unsafe PlayOfflineMatch __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayOfflineMatch._setupSessionRelay_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayOfflineMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayOfflineMatch._setupSessionRelay_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021FC RID: 8700
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040021FD RID: 8701
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040021FE RID: 8702
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040021FF RID: 8703
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002200 RID: 8704
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002201 RID: 8705
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002202 RID: 8706
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002203 RID: 8707
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002204 RID: 8708
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
