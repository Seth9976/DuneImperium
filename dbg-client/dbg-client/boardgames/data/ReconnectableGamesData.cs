using System;
using Canis;
using Canis.messages;
using Canis.utils.ids;
using dwd.core.data.composition;
using dwd.core.data.readonlyWrappers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace boardgames.data
{
	// Token: 0x02000192 RID: 402
	public class ReconnectableGamesData : VersionedDataComponent
	{
		// Token: 0x060011E9 RID: 4585 RVA: 0x00056934 File Offset: 0x00054B34
		// Note: this type is marked as 'beforefieldinit'.
		static ReconnectableGamesData()
		{
			Il2CppClassPointerStore<ReconnectableGamesData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.data", "ReconnectableGamesData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReconnectableGamesData>.NativeClassPtr);
			ReconnectableGamesData.NativeFieldInfoPtr_Games = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReconnectableGamesData>.NativeClassPtr, "Games");
			ReconnectableGamesData.NativeFieldInfoPtr_games = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReconnectableGamesData>.NativeClassPtr, "games");
			ReconnectableGamesData.NativeFieldInfoPtr_gamesDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReconnectableGamesData>.NativeClassPtr, "gamesDict");
			ReconnectableGamesData.NativeMethodInfoPtr__ctor_Public_Void_List_1_SaveMetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReconnectableGamesData>.NativeClassPtr, 100665803);
			ReconnectableGamesData.NativeMethodInfoPtr_UpdateWith_Public_Void_List_1_SaveMetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReconnectableGamesData>.NativeClassPtr, 100665804);
			ReconnectableGamesData.NativeMethodInfoPtr_Remove_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReconnectableGamesData>.NativeClassPtr, 100665805);
			ReconnectableGamesData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReconnectableGamesData>.NativeClassPtr, 100665806);
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x000569F0 File Offset: 0x00054BF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 515415, RefRangeEnd = 515416, XrefRangeStart = 515392, XrefRangeEnd = 515415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReconnectableGamesData(List<SaveMetaData> games)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReconnectableGamesData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(games);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReconnectableGamesData.NativeMethodInfoPtr__ctor_Public_Void_List_1_SaveMetaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x00056A3C File Offset: 0x00054C3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 515602, RefRangeEnd = 515605, XrefRangeStart = 515416, XrefRangeEnd = 515602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateWith(List<SaveMetaData> newGames)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newGames);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReconnectableGamesData.NativeMethodInfoPtr_UpdateWith_Public_Void_List_1_SaveMetaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x00056A80 File Offset: 0x00054C80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 515610, RefRangeEnd = 515612, XrefRangeStart = 515605, XrefRangeEnd = 515610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(DataComposition game)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(game);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReconnectableGamesData.NativeMethodInfoPtr_Remove_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x00056AC4 File Offset: 0x00054CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515612, XrefRangeEnd = 515621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReconnectableGamesData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x0000A917 File Offset: 0x00008B17
		public ReconnectableGamesData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x060011EF RID: 4591 RVA: 0x00056B08 File Offset: 0x00054D08
		// (set) Token: 0x060011F0 RID: 4592 RVA: 0x0000A920 File Offset: 0x00008B20
		public unsafe ReadOnlyList<DataComposition> Games
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReconnectableGamesData.NativeFieldInfoPtr_Games);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyList<DataComposition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReconnectableGamesData.NativeFieldInfoPtr_Games), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x060011F1 RID: 4593 RVA: 0x00056B38 File Offset: 0x00054D38
		// (set) Token: 0x060011F2 RID: 4594 RVA: 0x0000A93F File Offset: 0x00008B3F
		public unsafe List<DataComposition> games
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReconnectableGamesData.NativeFieldInfoPtr_games);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DataComposition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReconnectableGamesData.NativeFieldInfoPtr_games), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x060011F3 RID: 4595 RVA: 0x00056B68 File Offset: 0x00054D68
		// (set) Token: 0x060011F4 RID: 4596 RVA: 0x0000A95E File Offset: 0x00008B5E
		public unsafe Dictionary<GameID, DataComposition> gamesDict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReconnectableGamesData.NativeFieldInfoPtr_gamesDict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<GameID, DataComposition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReconnectableGamesData.NativeFieldInfoPtr_gamesDict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AF8 RID: 2808
		private static readonly IntPtr NativeFieldInfoPtr_Games;

		// Token: 0x04000AF9 RID: 2809
		private static readonly IntPtr NativeFieldInfoPtr_games;

		// Token: 0x04000AFA RID: 2810
		private static readonly IntPtr NativeFieldInfoPtr_gamesDict;

		// Token: 0x04000AFB RID: 2811
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_SaveMetaData_0;

		// Token: 0x04000AFC RID: 2812
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWith_Public_Void_List_1_SaveMetaData_0;

		// Token: 0x04000AFD RID: 2813
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_DataComposition_0;

		// Token: 0x04000AFE RID: 2814
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0200037B RID: 891
		[ObfuscatedName("boardgames.data.ReconnectableGamesData+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060029CA RID: 10698 RVA: 0x000A5870 File Offset: 0x000A3A70
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ReconnectableGamesData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReconnectableGamesData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReconnectableGamesData.__c>.NativeClassPtr);
				ReconnectableGamesData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReconnectableGamesData.__c>.NativeClassPtr, "<>9");
				ReconnectableGamesData.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReconnectableGamesData.__c>.NativeClassPtr, "<>9__4_1");
				ReconnectableGamesData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReconnectableGamesData.__c>.NativeClassPtr, 100665808);
				ReconnectableGamesData.__c.NativeMethodInfoPtr__UpdateWith_b__4_1_Internal_Boolean_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReconnectableGamesData.__c>.NativeClassPtr, 100665809);
			}

			// Token: 0x060029CB RID: 10699 RVA: 0x000A58EC File Offset: 0x000A3AEC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReconnectableGamesData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReconnectableGamesData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029CC RID: 10700 RVA: 0x000A5928 File Offset: 0x000A3B28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515381, XrefRangeEnd = 515390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateWith_b__4_1(AccountIDUsernameMetadata n)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(n);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReconnectableGamesData.__c.NativeMethodInfoPtr__UpdateWith_b__4_1_Internal_Boolean_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060029CD RID: 10701 RVA: 0x000158D8 File Offset: 0x00013AD8
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BBE RID: 3006
			// (get) Token: 0x060029CE RID: 10702 RVA: 0x000A5978 File Offset: 0x000A3B78
			// (set) Token: 0x060029CF RID: 10703 RVA: 0x000158E1 File Offset: 0x00013AE1
			public unsafe static ReconnectableGamesData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReconnectableGamesData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReconnectableGamesData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReconnectableGamesData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BBF RID: 3007
			// (get) Token: 0x060029D0 RID: 10704 RVA: 0x000A59A0 File Offset: 0x000A3BA0
			// (set) Token: 0x060029D1 RID: 10705 RVA: 0x000158F3 File Offset: 0x00013AF3
			public unsafe static Func<AccountIDUsernameMetadata, bool> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReconnectableGamesData.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AccountIDUsernameMetadata, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReconnectableGamesData.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A19 RID: 6681
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001A1A RID: 6682
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x04001A1B RID: 6683
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001A1C RID: 6684
			private static readonly IntPtr NativeMethodInfoPtr__UpdateWith_b__4_1_Internal_Boolean_AccountIDUsernameMetadata_0;
		}

		// Token: 0x0200037C RID: 892
		[ObfuscatedName("boardgames.data.ReconnectableGamesData+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x060029D2 RID: 10706 RVA: 0x000A59C8 File Offset: 0x000A3BC8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<ReconnectableGamesData.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReconnectableGamesData>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReconnectableGamesData.__c__DisplayClass4_0>.NativeClassPtr);
				ReconnectableGamesData.__c__DisplayClass4_0.NativeFieldInfoPtr_creatorID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReconnectableGamesData.__c__DisplayClass4_0>.NativeClassPtr, "creatorID");
				ReconnectableGamesData.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReconnectableGamesData.__c__DisplayClass4_0>.NativeClassPtr, 100665810);
				ReconnectableGamesData.__c__DisplayClass4_0.NativeMethodInfoPtr__UpdateWith_b__0_Internal_Boolean_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReconnectableGamesData.__c__DisplayClass4_0>.NativeClassPtr, 100665811);
			}

			// Token: 0x060029D3 RID: 10707 RVA: 0x000A5A30 File Offset: 0x000A3C30
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReconnectableGamesData.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReconnectableGamesData.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029D4 RID: 10708 RVA: 0x000A5A6C File Offset: 0x000A3C6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515390, XrefRangeEnd = 515392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateWith_b__0(AccountIDUsernameMetadata n)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(n);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReconnectableGamesData.__c__DisplayClass4_0.NativeMethodInfoPtr__UpdateWith_b__0_Internal_Boolean_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060029D5 RID: 10709 RVA: 0x00015905 File Offset: 0x00013B05
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BC0 RID: 3008
			// (get) Token: 0x060029D6 RID: 10710 RVA: 0x000A5ABC File Offset: 0x000A3CBC
			// (set) Token: 0x060029D7 RID: 10711 RVA: 0x0001590E File Offset: 0x00013B0E
			public unsafe string creatorID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReconnectableGamesData.__c__DisplayClass4_0.NativeFieldInfoPtr_creatorID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReconnectableGamesData.__c__DisplayClass4_0.NativeFieldInfoPtr_creatorID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001A1D RID: 6685
			private static readonly IntPtr NativeFieldInfoPtr_creatorID;

			// Token: 0x04001A1E RID: 6686
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001A1F RID: 6687
			private static readonly IntPtr NativeMethodInfoPtr__UpdateWith_b__0_Internal_Boolean_AccountIDUsernameMetadata_0;
		}
	}
}
