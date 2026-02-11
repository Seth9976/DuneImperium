using System;
using canis.Networking.game.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Canis.match
{
	// Token: 0x02000097 RID: 151
	public static class MakesMatchHistoryExtensions : Object
	{
		// Token: 0x06000792 RID: 1938 RVA: 0x00004E7E File Offset: 0x0000307E
		// Note: this type is marked as 'beforefieldinit'.
		static MakesMatchHistoryExtensions()
		{
			Il2CppClassPointerStore<MakesMatchHistoryExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.match", "MakesMatchHistoryExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MakesMatchHistoryExtensions>.NativeClassPtr);
			MakesMatchHistoryExtensions.NativeMethodInfoPtr_MakeMatchHistory_Public_Static_MatchHistoryEntry_TGameResults_String_String_Func_2_TGameResults_Dictionary_2_String_String_Dictionary_2_String_String_Boolean_AccountID_Func_2_TGameResults_Boolean_Func_2_TGameResults_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MakesMatchHistoryExtensions>.NativeClassPtr, 100664849);
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00038254 File Offset: 0x00036454
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 557982, RefRangeEnd = 557983, XrefRangeStart = 557880, XrefRangeEnd = 557982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MatchHistoryEntry MakeMatchHistory<TGameResults, TGameResultsEntry>(this TGameResults results, string client, string matchType, Func<TGameResults, Dictionary<string, string>> makeFilters, Dictionary<string, string> gameProperties = null, bool createAIPlayerData = true, AccountID overrideWinnerAccountID = null, Func<TGameResults, bool> shouldIgnoreMatchHistory = null, Func<TGameResults, bool> shouldIgnorePlayerStats = null) where TGameResults : DBGGameResults where TGameResultsEntry : DBGGameResultsEntry
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TGameResults).IsValueType)
				{
					TGameResults tgameResults = results;
					intPtr = ((tgameResults is string) ? IL2CPP.ManagedStringToIl2Cpp(tgameResults as string) : IL2CPP.Il2CppObjectBaseToPtr(tgameResults as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref results;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(client);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(matchType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(makeFilters);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameProperties);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createAIPlayerData;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overrideWinnerAccountID);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(shouldIgnoreMatchHistory);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(shouldIgnorePlayerStats);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MakesMatchHistoryExtensions.MethodInfoStoreGeneric_MakeMatchHistory_Public_Static_MatchHistoryEntry_TGameResults_String_String_Func_2_TGameResults_Dictionary_2_String_String_Dictionary_2_String_String_Boolean_AccountID_Func_2_TGameResults_Boolean_Func_2_TGameResults_Boolean_0<TGameResults, TGameResultsEntry>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<MatchHistoryEntry>(intPtr4) : null;
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00004EB7 File Offset: 0x000030B7
		public MakesMatchHistoryExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeMethodInfoPtr_MakeMatchHistory_Public_Static_MatchHistoryEntry_TGameResults_String_String_Func_2_TGameResults_Dictionary_2_String_String_Dictionary_2_String_String_Boolean_AccountID_Func_2_TGameResults_Boolean_Func_2_TGameResults_Boolean_0;

		// Token: 0x020002DB RID: 731
		[ObfuscatedName("Canis.match.MakesMatchHistoryExtensions+<>c__0`2")]
		[Serializable]
		public sealed class __c__0<TGameResults, TGameResultsEntry> : Object where TGameResults : DBGGameResults where TGameResultsEntry : DBGGameResultsEntry
		{
			// Token: 0x06001EAA RID: 7850 RVA: 0x0008E31C File Offset: 0x0008C51C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__0()
			{
				Il2CppClassPointerStore<MakesMatchHistoryExtensions.__c__0<TGameResults, TGameResultsEntry>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MakesMatchHistoryExtensions>.NativeClassPtr, "<>c__0`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGameResults>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGameResultsEntry>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MakesMatchHistoryExtensions.__c__0<TGameResults, TGameResultsEntry>>.NativeClassPtr);
				MakesMatchHistoryExtensions.__c__0<TGameResults, TGameResultsEntry>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MakesMatchHistoryExtensions.__c__0<TGameResults, TGameResultsEntry>>.NativeClassPtr, "<>9");
				MakesMatchHistoryExtensions.__c__0<TGameResults, TGameResultsEntry>.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MakesMatchHistoryExtensions.__c__0<TGameResults, TGameResultsEntry>>.NativeClassPtr, "<>9__0_0");
				MakesMatchHistoryExtensions.__c__0<TGameResults, TGameResultsEntry>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MakesMatchHistoryExtensions.__c__0<TGameResults, TGameResultsEntry>>.NativeClassPtr, 100664851);
				MakesMatchHistoryExtensions.__c__0<TGameResults, TGameResultsEntry>.NativeMethodInfoPtr__MakeMatchHistory_b__0_0_Internal_Boolean_TGameResultsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MakesMatchHistoryExtensions.__c__0<TGameResults, TGameResultsEntry>>.NativeClassPtr, 100664852);
			}

			// Token: 0x06001EAB RID: 7851 RVA: 0x0008E3E4 File Offset: 0x0008C5E4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MakesMatchHistoryExtensions.__c__0<TGameResults, TGameResultsEntry>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MakesMatchHistoryExtensions.__c__0<TGameResults, TGameResultsEntry>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EAC RID: 7852 RVA: 0x0008E420 File Offset: 0x0008C620
			[CallerCount(0)]
			public unsafe bool _MakeMatchHistory_b__0_0(TGameResultsEntry p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TGameResultsEntry).IsValueType)
					{
						TGameResultsEntry tgameResultsEntry = p;
						intPtr = ((tgameResultsEntry is string) ? IL2CPP.ManagedStringToIl2Cpp(tgameResultsEntry as string) : IL2CPP.Il2CppObjectBaseToPtr(tgameResultsEntry as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref p;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MakesMatchHistoryExtensions.__c__0<TGameResults, TGameResultsEntry>.NativeMethodInfoPtr__MakeMatchHistory_b__0_0_Internal_Boolean_TGameResultsEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06001EAD RID: 7853 RVA: 0x0000EBBE File Offset: 0x0000CDBE
			public __c__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700072E RID: 1838
			// (get) Token: 0x06001EAE RID: 7854 RVA: 0x0008E4A4 File Offset: 0x0008C6A4
			// (set) Token: 0x06001EAF RID: 7855 RVA: 0x0000EBC7 File Offset: 0x0000CDC7
			public unsafe static MakesMatchHistoryExtensions.__c__0<TGameResults, TGameResultsEntry> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MakesMatchHistoryExtensions.__c__0<TGameResults, TGameResultsEntry>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MakesMatchHistoryExtensions.__c__0<TGameResults, TGameResultsEntry>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MakesMatchHistoryExtensions.__c__0<TGameResults, TGameResultsEntry>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700072F RID: 1839
			// (get) Token: 0x06001EB0 RID: 7856 RVA: 0x0008E4CC File Offset: 0x0008C6CC
			// (set) Token: 0x06001EB1 RID: 7857 RVA: 0x0000EBD9 File Offset: 0x0000CDD9
			public unsafe static Func<TGameResultsEntry, bool> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MakesMatchHistoryExtensions.__c__0<TGameResults, TGameResultsEntry>.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TGameResultsEntry, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MakesMatchHistoryExtensions.__c__0<TGameResults, TGameResultsEntry>.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001362 RID: 4962
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001363 RID: 4963
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x04001364 RID: 4964
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001365 RID: 4965
			private static readonly IntPtr NativeMethodInfoPtr__MakeMatchHistory_b__0_0_Internal_Boolean_TGameResultsEntry_0;
		}

		// Token: 0x020002DC RID: 732
		private sealed class MethodInfoStoreGeneric_MakeMatchHistory_Public_Static_MatchHistoryEntry_TGameResults_String_String_Func_2_TGameResults_Dictionary_2_String_String_Dictionary_2_String_String_Boolean_AccountID_Func_2_TGameResults_Boolean_Func_2_TGameResults_Boolean_0<TGameResults, TGameResultsEntry>
		{
			// Token: 0x04001366 RID: 4966
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MakesMatchHistoryExtensions.NativeMethodInfoPtr_MakeMatchHistory_Public_Static_MatchHistoryEntry_TGameResults_String_String_Func_2_TGameResults_Dictionary_2_String_String_Dictionary_2_String_String_Boolean_AccountID_Func_2_TGameResults_Boolean_Func_2_TGameResults_Boolean_0, Il2CppClassPointerStore<MakesMatchHistoryExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGameResults>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGameResultsEntry>.NativeClassPtr))
			}))));
		}
	}
}
