using System;
using boardgames.keyedLookup;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace boardgames.menus
{
	// Token: 0x020001A7 RID: 423
	public class OfflineMatches<T> : ScriptableObject where T : MatchInitData
	{
		// Token: 0x060012D7 RID: 4823 RVA: 0x0005A464 File Offset: 0x00058664
		// Note: this type is marked as 'beforefieldinit'.
		static OfflineMatches()
		{
			Il2CppClassPointerStore<OfflineMatches<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus", "OfflineMatches`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OfflineMatches<T>>.NativeClassPtr);
			OfflineMatches<T>.NativeFieldInfoPtr_matches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineMatches<T>>.NativeClassPtr, "matches");
			OfflineMatches<T>.NativeMethodInfoPtr_GetMatch_Public_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMatches<T>>.NativeClassPtr, 100666056);
			OfflineMatches<T>.NativeMethodInfoPtr_GetMatchesOfType_Public_List_1_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMatches<T>>.NativeClassPtr, 100666057);
			OfflineMatches<T>.NativeMethodInfoPtr_GetAllMatches_Public_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMatches<T>>.NativeClassPtr, 100666058);
			OfflineMatches<T>.NativeMethodInfoPtr_GetSavedGameMatchInitData_Public_Virtual_New_T_SaveMetaData_SaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMatches<T>>.NativeClassPtr, 100666059);
			OfflineMatches<T>.NativeMethodInfoPtr_ConfigureSavedGameMatchInitDataPlayers_Protected_Virtual_New_Void_List_1_PlayerInfoSaveData_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMatches<T>>.NativeClassPtr, 100666060);
			OfflineMatches<T>.NativeMethodInfoPtr_ContainsEntry_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMatches<T>>.NativeClassPtr, 100666061);
			OfflineMatches<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMatches<T>>.NativeClassPtr, 100666062);
			OfflineMatches<T>.NativeMethodInfoPtr__GetAllMatches_b__3_0_Private_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMatches<T>>.NativeClassPtr, 100666063);
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x0005A584 File Offset: 0x00058784
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 518365, RefRangeEnd = 518369, XrefRangeStart = 518333, XrefRangeEnd = 518365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetMatch(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMatches<T>.NativeMethodInfoPtr_GetMatch_Public_T_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x0005A5D0 File Offset: 0x000587D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 518384, RefRangeEnd = 518385, XrefRangeStart = 518369, XrefRangeEnd = 518384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<T> GetMatchesOfType(string type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMatches<T>.NativeMethodInfoPtr_GetMatchesOfType_Public_List_1_T_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
			}
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x0005A620 File Offset: 0x00058820
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 518390, RefRangeEnd = 518391, XrefRangeStart = 518385, XrefRangeEnd = 518390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<T> GetAllMatches()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMatches<T>.NativeMethodInfoPtr_GetAllMatches_Public_List_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x0005A660 File Offset: 0x00058860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518391, XrefRangeEnd = 518417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T GetSavedGameMatchInitData(SaveMetaData metaData, SaveData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(metaData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OfflineMatches<T>.NativeMethodInfoPtr_GetSavedGameMatchInitData_Public_Virtual_New_T_SaveMetaData_SaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x0005A6C8 File Offset: 0x000588C8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ConfigureSavedGameMatchInitDataPlayers(List<PlayerInfoSaveData> orderedPlayers, T matchInitData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(orderedPlayers);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = matchInitData;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref matchInitData;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OfflineMatches<T>.NativeMethodInfoPtr_ConfigureSavedGameMatchInitDataPlayers_Protected_Virtual_New_Void_List_1_PlayerInfoSaveData_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x0005A760 File Offset: 0x00058960
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 518418, RefRangeEnd = 518420, XrefRangeStart = 518417, XrefRangeEnd = 518418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsEntry(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMatches<T>.NativeMethodInfoPtr_ContainsEntry_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x0005A7B0 File Offset: 0x000589B0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 338035, RefRangeEnd = 338045, XrefRangeStart = 338035, XrefRangeEnd = 338045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OfflineMatches()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OfflineMatches<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMatches<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x0005A7EC File Offset: 0x000589EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518420, XrefRangeEnd = 518427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T _GetAllMatches_b__3_0(T _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = _;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref _;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(OfflineMatches<T>.NativeMethodInfoPtr__GetAllMatches_b__3_0_Private_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
			}
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x0000AE10 File Offset: 0x00009010
		public OfflineMatches(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x060012E1 RID: 4833 RVA: 0x0005A86C File Offset: 0x00058A6C
		// (set) Token: 0x060012E2 RID: 4834 RVA: 0x0000AE19 File Offset: 0x00009019
		public unsafe KeyedMatchInitDataLookup<T> matches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMatches<T>.NativeFieldInfoPtr_matches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KeyedMatchInitDataLookup<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMatches<T>.NativeFieldInfoPtr_matches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B98 RID: 2968
		private static readonly IntPtr NativeFieldInfoPtr_matches;

		// Token: 0x04000B99 RID: 2969
		private static readonly IntPtr NativeMethodInfoPtr_GetMatch_Public_T_String_0;

		// Token: 0x04000B9A RID: 2970
		private static readonly IntPtr NativeMethodInfoPtr_GetMatchesOfType_Public_List_1_T_String_0;

		// Token: 0x04000B9B RID: 2971
		private static readonly IntPtr NativeMethodInfoPtr_GetAllMatches_Public_List_1_T_0;

		// Token: 0x04000B9C RID: 2972
		private static readonly IntPtr NativeMethodInfoPtr_GetSavedGameMatchInitData_Public_Virtual_New_T_SaveMetaData_SaveData_0;

		// Token: 0x04000B9D RID: 2973
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureSavedGameMatchInitDataPlayers_Protected_Virtual_New_Void_List_1_PlayerInfoSaveData_T_0;

		// Token: 0x04000B9E RID: 2974
		private static readonly IntPtr NativeMethodInfoPtr_ContainsEntry_Public_Boolean_String_0;

		// Token: 0x04000B9F RID: 2975
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000BA0 RID: 2976
		private static readonly IntPtr NativeMethodInfoPtr__GetAllMatches_b__3_0_Private_T_T_0;

		// Token: 0x02000397 RID: 919
		[ObfuscatedName("boardgames.menus.OfflineMatches`1+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002B4D RID: 11085 RVA: 0x000AA008 File Offset: 0x000A8208
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<OfflineMatches<T>.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OfflineMatches<T>>.NativeClassPtr, "<>c__DisplayClass2_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OfflineMatches<T>.__c__DisplayClass2_0>.NativeClassPtr);
				OfflineMatches<T>.__c__DisplayClass2_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineMatches<T>.__c__DisplayClass2_0>.NativeClassPtr, "type");
				OfflineMatches<T>.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineMatches<T>.__c__DisplayClass2_0>.NativeClassPtr, "<>4__this");
				OfflineMatches<T>.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMatches<T>.__c__DisplayClass2_0>.NativeClassPtr, 100666064);
				OfflineMatches<T>.__c__DisplayClass2_0.NativeMethodInfoPtr__GetMatchesOfType_b__0_Internal_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMatches<T>.__c__DisplayClass2_0>.NativeClassPtr, 100666065);
				OfflineMatches<T>.__c__DisplayClass2_0.NativeMethodInfoPtr__GetMatchesOfType_b__1_Internal_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMatches<T>.__c__DisplayClass2_0>.NativeClassPtr, 100666066);
			}

			// Token: 0x06002B4E RID: 11086 RVA: 0x000AA0D4 File Offset: 0x000A82D4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OfflineMatches<T>.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMatches<T>.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B4F RID: 11087 RVA: 0x000AA110 File Offset: 0x000A8310
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518329, XrefRangeEnd = 518331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetMatchesOfType_b__0(T _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = _;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref _;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(OfflineMatches<T>.__c__DisplayClass2_0.NativeMethodInfoPtr__GetMatchesOfType_b__0_Internal_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06002B50 RID: 11088 RVA: 0x000AA194 File Offset: 0x000A8394
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518331, XrefRangeEnd = 518333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T _GetMatchesOfType_b__1(T _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = _;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref _;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(OfflineMatches<T>.__c__DisplayClass2_0.NativeMethodInfoPtr__GetMatchesOfType_b__1_Internal_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
				}
			}

			// Token: 0x06002B51 RID: 11089 RVA: 0x0001660A File Offset: 0x0001480A
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C43 RID: 3139
			// (get) Token: 0x06002B52 RID: 11090 RVA: 0x000AA214 File Offset: 0x000A8414
			// (set) Token: 0x06002B53 RID: 11091 RVA: 0x00016613 File Offset: 0x00014813
			public unsafe string type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMatches<T>.__c__DisplayClass2_0.NativeFieldInfoPtr_type);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMatches<T>.__c__DisplayClass2_0.NativeFieldInfoPtr_type), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000C44 RID: 3140
			// (get) Token: 0x06002B54 RID: 11092 RVA: 0x000AA23C File Offset: 0x000A843C
			// (set) Token: 0x06002B55 RID: 11093 RVA: 0x00016632 File Offset: 0x00014832
			public unsafe OfflineMatches<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMatches<T>.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OfflineMatches<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMatches<T>.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001AFD RID: 6909
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04001AFE RID: 6910
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001AFF RID: 6911
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001B00 RID: 6912
			private static readonly IntPtr NativeMethodInfoPtr__GetMatchesOfType_b__0_Internal_Boolean_T_0;

			// Token: 0x04001B01 RID: 6913
			private static readonly IntPtr NativeMethodInfoPtr__GetMatchesOfType_b__1_Internal_T_T_0;
		}
	}
}
