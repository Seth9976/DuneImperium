using System;
using dwd.core.data.composition;
using dwd.core.direBytes;
using dwd.core.settings;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace boardgames.behaviours
{
	// Token: 0x020002A3 RID: 675
	public class DirebytesButtonBehaviour : MonoBehaviour
	{
		// Token: 0x06002016 RID: 8214 RVA: 0x000888BC File Offset: 0x00086ABC
		// Note: this type is marked as 'beforefieldinit'.
		static DirebytesButtonBehaviour()
		{
			Il2CppClassPointerStore<DirebytesButtonBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.behaviours", "DirebytesButtonBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirebytesButtonBehaviour>.NativeClassPtr);
			DirebytesButtonBehaviour.NativeFieldInfoPtr_Delimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirebytesButtonBehaviour>.NativeClassPtr, "Delimiter");
			DirebytesButtonBehaviour.NativeFieldInfoPtr_newPip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirebytesButtonBehaviour>.NativeClassPtr, "newPip");
			DirebytesButtonBehaviour.NativeFieldInfoPtr_mainMenuAnimationDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirebytesButtonBehaviour>.NativeClassPtr, "mainMenuAnimationDelay");
			DirebytesButtonBehaviour.NativeFieldInfoPtr_direbytesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirebytesButtonBehaviour>.NativeClassPtr, "direbytesProvider");
			DirebytesButtonBehaviour.NativeFieldInfoPtr_seenAlertHashes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirebytesButtonBehaviour>.NativeClassPtr, "seenAlertHashes");
			DirebytesButtonBehaviour.NativeFieldInfoPtr_seenTileHashes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirebytesButtonBehaviour>.NativeClassPtr, "seenTileHashes");
			DirebytesButtonBehaviour.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirebytesButtonBehaviour>.NativeClassPtr, 100668627);
			DirebytesButtonBehaviour.NativeMethodInfoPtr_LoadSeenListFromPref_Private_Static_Void_List_1_Int32_ISettingDefinition_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirebytesButtonBehaviour>.NativeClassPtr, 100668628);
			DirebytesButtonBehaviour.NativeMethodInfoPtr_Seen_Private_Static_Boolean_List_1_Int32_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirebytesButtonBehaviour>.NativeClassPtr, 100668629);
			DirebytesButtonBehaviour.NativeMethodInfoPtr_saveSeen_Private_Static_Void_IEnumerable_1_DataComposition_IWritableSetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirebytesButtonBehaviour>.NativeClassPtr, 100668630);
			DirebytesButtonBehaviour.NativeMethodInfoPtr_OpenDirebytesPrompt_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirebytesButtonBehaviour>.NativeClassPtr, 100668631);
			DirebytesButtonBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirebytesButtonBehaviour>.NativeClassPtr, 100668632);
			DirebytesButtonBehaviour.NativeMethodInfoPtr__Start_b__6_0_Private_Boolean_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirebytesButtonBehaviour>.NativeClassPtr, 100668633);
			DirebytesButtonBehaviour.NativeMethodInfoPtr__Start_b__6_1_Private_Boolean_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirebytesButtonBehaviour>.NativeClassPtr, 100668634);
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x00088A04 File Offset: 0x00086C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541931, XrefRangeEnd = 541936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirebytesButtonBehaviour.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x00088A44 File Offset: 0x00086C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541936, XrefRangeEnd = 541961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadSeenListFromPref(List<int> hashes, ISettingDefinition<string> pref)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hashes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pref);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirebytesButtonBehaviour.NativeMethodInfoPtr_LoadSeenListFromPref_Private_Static_Void_List_1_Int32_ISettingDefinition_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x00088A8C File Offset: 0x00086C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541961, XrefRangeEnd = 541969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Seen(List<int> hashes, DataComposition tile)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hashes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirebytesButtonBehaviour.NativeMethodInfoPtr_Seen_Private_Static_Boolean_List_1_Int32_DataComposition_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x00088AE0 File Offset: 0x00086CE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 542000, RefRangeEnd = 542001, XrefRangeStart = 541969, XrefRangeEnd = 542000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void saveSeen(IEnumerable<DataComposition> data, IWritableSetting<string> pref)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pref);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirebytesButtonBehaviour.NativeMethodInfoPtr_saveSeen_Private_Static_Void_IEnumerable_1_DataComposition_IWritableSetting_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x00088B28 File Offset: 0x00086D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542001, XrefRangeEnd = 542042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenDirebytesPrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirebytesButtonBehaviour.NativeMethodInfoPtr_OpenDirebytesPrompt_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x00088B5C File Offset: 0x00086D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542042, XrefRangeEnd = 542055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DirebytesButtonBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirebytesButtonBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirebytesButtonBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x00088B98 File Offset: 0x00086D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542055, XrefRangeEnd = 542062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Start_b__6_0(DataComposition t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirebytesButtonBehaviour.NativeMethodInfoPtr__Start_b__6_0_Private_Boolean_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x00088BE8 File Offset: 0x00086DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542062, XrefRangeEnd = 542069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Start_b__6_1(DataComposition a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirebytesButtonBehaviour.NativeMethodInfoPtr__Start_b__6_1_Private_Boolean_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x00010D93 File Offset: 0x0000EF93
		public DirebytesButtonBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06002020 RID: 8224 RVA: 0x00088C38 File Offset: 0x00086E38
		// (set) Token: 0x06002021 RID: 8225 RVA: 0x00010D9C File Offset: 0x0000EF9C
		public unsafe static char Delimiter
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(DirebytesButtonBehaviour.NativeFieldInfoPtr_Delimiter, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DirebytesButtonBehaviour.NativeFieldInfoPtr_Delimiter, (void*)(&value));
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06002022 RID: 8226 RVA: 0x00088C54 File Offset: 0x00086E54
		// (set) Token: 0x06002023 RID: 8227 RVA: 0x00010DAA File Offset: 0x0000EFAA
		public unsafe GameObject newPip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirebytesButtonBehaviour.NativeFieldInfoPtr_newPip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirebytesButtonBehaviour.NativeFieldInfoPtr_newPip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06002024 RID: 8228 RVA: 0x00088C84 File Offset: 0x00086E84
		// (set) Token: 0x06002025 RID: 8229 RVA: 0x00010DC9 File Offset: 0x0000EFC9
		public unsafe float mainMenuAnimationDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirebytesButtonBehaviour.NativeFieldInfoPtr_mainMenuAnimationDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirebytesButtonBehaviour.NativeFieldInfoPtr_mainMenuAnimationDelay)) = value;
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06002026 RID: 8230 RVA: 0x00088CAC File Offset: 0x00086EAC
		// (set) Token: 0x06002027 RID: 8231 RVA: 0x00010DE4 File Offset: 0x0000EFE4
		public unsafe DireBytesProvider direbytesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirebytesButtonBehaviour.NativeFieldInfoPtr_direbytesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DireBytesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirebytesButtonBehaviour.NativeFieldInfoPtr_direbytesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06002028 RID: 8232 RVA: 0x00088CDC File Offset: 0x00086EDC
		// (set) Token: 0x06002029 RID: 8233 RVA: 0x00010E03 File Offset: 0x0000F003
		public unsafe List<int> seenAlertHashes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirebytesButtonBehaviour.NativeFieldInfoPtr_seenAlertHashes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirebytesButtonBehaviour.NativeFieldInfoPtr_seenAlertHashes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x0600202A RID: 8234 RVA: 0x00088D0C File Offset: 0x00086F0C
		// (set) Token: 0x0600202B RID: 8235 RVA: 0x00010E22 File Offset: 0x0000F022
		public unsafe List<int> seenTileHashes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirebytesButtonBehaviour.NativeFieldInfoPtr_seenTileHashes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirebytesButtonBehaviour.NativeFieldInfoPtr_seenTileHashes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001447 RID: 5191
		private static readonly IntPtr NativeFieldInfoPtr_Delimiter;

		// Token: 0x04001448 RID: 5192
		private static readonly IntPtr NativeFieldInfoPtr_newPip;

		// Token: 0x04001449 RID: 5193
		private static readonly IntPtr NativeFieldInfoPtr_mainMenuAnimationDelay;

		// Token: 0x0400144A RID: 5194
		private static readonly IntPtr NativeFieldInfoPtr_direbytesProvider;

		// Token: 0x0400144B RID: 5195
		private static readonly IntPtr NativeFieldInfoPtr_seenAlertHashes;

		// Token: 0x0400144C RID: 5196
		private static readonly IntPtr NativeFieldInfoPtr_seenTileHashes;

		// Token: 0x0400144D RID: 5197
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x0400144E RID: 5198
		private static readonly IntPtr NativeMethodInfoPtr_LoadSeenListFromPref_Private_Static_Void_List_1_Int32_ISettingDefinition_1_String_0;

		// Token: 0x0400144F RID: 5199
		private static readonly IntPtr NativeMethodInfoPtr_Seen_Private_Static_Boolean_List_1_Int32_DataComposition_0;

		// Token: 0x04001450 RID: 5200
		private static readonly IntPtr NativeMethodInfoPtr_saveSeen_Private_Static_Void_IEnumerable_1_DataComposition_IWritableSetting_1_String_0;

		// Token: 0x04001451 RID: 5201
		private static readonly IntPtr NativeMethodInfoPtr_OpenDirebytesPrompt_Public_Void_0;

		// Token: 0x04001452 RID: 5202
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001453 RID: 5203
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__6_0_Private_Boolean_DataComposition_0;

		// Token: 0x04001454 RID: 5204
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__6_1_Private_Boolean_DataComposition_0;

		// Token: 0x0200049B RID: 1179
		[ObfuscatedName("boardgames.behaviours.DirebytesButtonBehaviour+<>O")]
		public static class __O : global::Il2CppSystem.Object
		{
			// Token: 0x060037FC RID: 14332 RVA: 0x0001CC97 File Offset: 0x0001AE97
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<DirebytesButtonBehaviour.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DirebytesButtonBehaviour>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirebytesButtonBehaviour.__O>.NativeClassPtr);
				DirebytesButtonBehaviour.__O.NativeFieldInfoPtr__0___Parse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirebytesButtonBehaviour.__O>.NativeClassPtr, "<0>__Parse");
			}

			// Token: 0x060037FD RID: 14333 RVA: 0x0001CCCB File Offset: 0x0001AECB
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700108A RID: 4234
			// (get) Token: 0x060037FE RID: 14334 RVA: 0x000CFC48 File Offset: 0x000CDE48
			// (set) Token: 0x060037FF RID: 14335 RVA: 0x0001CCD4 File Offset: 0x0001AED4
			public unsafe static Func<string, int> _0___Parse
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DirebytesButtonBehaviour.__O.NativeFieldInfoPtr__0___Parse, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DirebytesButtonBehaviour.__O.NativeFieldInfoPtr__0___Parse, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400226F RID: 8815
			private static readonly IntPtr NativeFieldInfoPtr__0___Parse;
		}

		// Token: 0x0200049C RID: 1180
		[ObfuscatedName("boardgames.behaviours.DirebytesButtonBehaviour+<Start>d__6")]
		public sealed class _Start_d__6 : global::Il2CppSystem.Object
		{
			// Token: 0x06003800 RID: 14336 RVA: 0x000CFC70 File Offset: 0x000CDE70
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__6()
			{
				Il2CppClassPointerStore<DirebytesButtonBehaviour._Start_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DirebytesButtonBehaviour>.NativeClassPtr, "<Start>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirebytesButtonBehaviour._Start_d__6>.NativeClassPtr);
				DirebytesButtonBehaviour._Start_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirebytesButtonBehaviour._Start_d__6>.NativeClassPtr, "<>1__state");
				DirebytesButtonBehaviour._Start_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirebytesButtonBehaviour._Start_d__6>.NativeClassPtr, "<>2__current");
				DirebytesButtonBehaviour._Start_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirebytesButtonBehaviour._Start_d__6>.NativeClassPtr, "<>4__this");
				DirebytesButtonBehaviour._Start_d__6.NativeFieldInfoPtr__alert_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirebytesButtonBehaviour._Start_d__6>.NativeClassPtr, "<alert>5__2");
				DirebytesButtonBehaviour._Start_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirebytesButtonBehaviour._Start_d__6>.NativeClassPtr, 100668635);
				DirebytesButtonBehaviour._Start_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirebytesButtonBehaviour._Start_d__6>.NativeClassPtr, 100668636);
				DirebytesButtonBehaviour._Start_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirebytesButtonBehaviour._Start_d__6>.NativeClassPtr, 100668637);
				DirebytesButtonBehaviour._Start_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirebytesButtonBehaviour._Start_d__6>.NativeClassPtr, 100668638);
				DirebytesButtonBehaviour._Start_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirebytesButtonBehaviour._Start_d__6>.NativeClassPtr, 100668639);
				DirebytesButtonBehaviour._Start_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirebytesButtonBehaviour._Start_d__6>.NativeClassPtr, 100668640);
			}

			// Token: 0x06003801 RID: 14337 RVA: 0x000CFD64 File Offset: 0x000CDF64
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirebytesButtonBehaviour._Start_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirebytesButtonBehaviour._Start_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003802 RID: 14338 RVA: 0x000CFDAC File Offset: 0x000CDFAC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirebytesButtonBehaviour._Start_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003803 RID: 14339 RVA: 0x000CFDE0 File Offset: 0x000CDFE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541896, XrefRangeEnd = 541926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirebytesButtonBehaviour._Start_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700108F RID: 4239
			// (get) Token: 0x06003804 RID: 14340 RVA: 0x000CFE1C File Offset: 0x000CE01C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirebytesButtonBehaviour._Start_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003805 RID: 14341 RVA: 0x000CFE5C File Offset: 0x000CE05C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541926, XrefRangeEnd = 541931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirebytesButtonBehaviour._Start_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001090 RID: 4240
			// (get) Token: 0x06003806 RID: 14342 RVA: 0x000CFE90 File Offset: 0x000CE090
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirebytesButtonBehaviour._Start_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003807 RID: 14343 RVA: 0x0001CCE6 File Offset: 0x0001AEE6
			public _Start_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700108B RID: 4235
			// (get) Token: 0x06003808 RID: 14344 RVA: 0x000CFED0 File Offset: 0x000CE0D0
			// (set) Token: 0x06003809 RID: 14345 RVA: 0x0001CCEF File Offset: 0x0001AEEF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirebytesButtonBehaviour._Start_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirebytesButtonBehaviour._Start_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700108C RID: 4236
			// (get) Token: 0x0600380A RID: 14346 RVA: 0x000CFEF8 File Offset: 0x000CE0F8
			// (set) Token: 0x0600380B RID: 14347 RVA: 0x0001CD0A File Offset: 0x0001AF0A
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirebytesButtonBehaviour._Start_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirebytesButtonBehaviour._Start_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700108D RID: 4237
			// (get) Token: 0x0600380C RID: 14348 RVA: 0x000CFF28 File Offset: 0x000CE128
			// (set) Token: 0x0600380D RID: 14349 RVA: 0x0001CD29 File Offset: 0x0001AF29
			public unsafe DirebytesButtonBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirebytesButtonBehaviour._Start_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DirebytesButtonBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirebytesButtonBehaviour._Start_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700108E RID: 4238
			// (get) Token: 0x0600380E RID: 14350 RVA: 0x000CFF58 File Offset: 0x000CE158
			// (set) Token: 0x0600380F RID: 14351 RVA: 0x0001CD48 File Offset: 0x0001AF48
			public unsafe DataComposition _alert_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirebytesButtonBehaviour._Start_d__6.NativeFieldInfoPtr__alert_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirebytesButtonBehaviour._Start_d__6.NativeFieldInfoPtr__alert_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002270 RID: 8816
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002271 RID: 8817
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002272 RID: 8818
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002273 RID: 8819
			private static readonly IntPtr NativeFieldInfoPtr__alert_5__2;

			// Token: 0x04002274 RID: 8820
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002275 RID: 8821
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002276 RID: 8822
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002277 RID: 8823
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002278 RID: 8824
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002279 RID: 8825
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
