using System;
using canis.archetypes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using worm.canis.data.enums;

namespace worm.canis.archetypes
{
	// Token: 0x020000E7 RID: 231
	public static class WormArchetypeExtensions : Object
	{
		// Token: 0x06000FC2 RID: 4034 RVA: 0x0009B700 File Offset: 0x00099900
		// Note: this type is marked as 'beforefieldinit'.
		static WormArchetypeExtensions()
		{
			Il2CppClassPointerStore<WormArchetypeExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes", "WormArchetypeExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormArchetypeExtensions>.NativeClassPtr);
			WormArchetypeExtensions.NativeMethodInfoPtr_IsSpaceArchetype_Public_Static_Boolean_Archetype_Nullable_1_AgentIcons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeExtensions>.NativeClassPtr, 100666064);
			WormArchetypeExtensions.NativeMethodInfoPtr_IsImperiumArchetype_Public_Static_Boolean_Archetype_Nullable_1_ImperiumTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeExtensions>.NativeClassPtr, 100666065);
			WormArchetypeExtensions.NativeMethodInfoPtr_IsIntrigueArchetype_Public_Static_Boolean_Archetype_Nullable_1_IntrigueTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeExtensions>.NativeClassPtr, 100666066);
			WormArchetypeExtensions.NativeMethodInfoPtr_IsConflictArchetype_Public_Static_Boolean_Archetype_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeExtensions>.NativeClassPtr, 100666067);
			WormArchetypeExtensions.NativeMethodInfoPtr_IsLeaderArchetype_Public_Static_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeExtensions>.NativeClassPtr, 100666068);
			WormArchetypeExtensions.NativeMethodInfoPtr_IsHagalArchetype_Public_Static_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeExtensions>.NativeClassPtr, 100666069);
			WormArchetypeExtensions.NativeMethodInfoPtr_IsTechTileArchetype_Public_Static_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeExtensions>.NativeClassPtr, 100666070);
			WormArchetypeExtensions.NativeMethodInfoPtr_IsTleilaxuArchetype_Public_Static_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeExtensions>.NativeClassPtr, 100666071);
			WormArchetypeExtensions.NativeMethodInfoPtr_IsImperiumOrTleilaxuArchetype_Public_Static_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeExtensions>.NativeClassPtr, 100666072);
			WormArchetypeExtensions.NativeMethodInfoPtr_IsInSet_Public_Static_Boolean_Archetype_Set_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeExtensions>.NativeClassPtr, 100666073);
			WormArchetypeExtensions.NativeMethodInfoPtr_IsInSets_Public_Static_Boolean_Archetype_IEnumerable_1_Set_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeExtensions>.NativeClassPtr, 100666074);
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x0009B80C File Offset: 0x00099A0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77870, RefRangeEnd = 77871, XrefRangeStart = 77856, XrefRangeEnd = 77870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSpaceArchetype(this Archetype arch, Nullable<AgentIcons> actionIcon = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(actionIcon));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeExtensions.NativeMethodInfoPtr_IsSpaceArchetype_Public_Static_Boolean_Archetype_Nullable_1_AgentIcons_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x0009B864 File Offset: 0x00099A64
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 77884, RefRangeEnd = 77891, XrefRangeStart = 77871, XrefRangeEnd = 77884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsImperiumArchetype(this Archetype arch, Nullable<ImperiumTypes> imperiumType = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(imperiumType));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeExtensions.NativeMethodInfoPtr_IsImperiumArchetype_Public_Static_Boolean_Archetype_Nullable_1_ImperiumTypes_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x0009B8BC File Offset: 0x00099ABC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 77908, RefRangeEnd = 77918, XrefRangeStart = 77891, XrefRangeEnd = 77908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsIntrigueArchetype(this Archetype arch, Nullable<IntrigueTypes> intrigueType = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(intrigueType));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeExtensions.NativeMethodInfoPtr_IsIntrigueArchetype_Public_Static_Boolean_Archetype_Nullable_1_IntrigueTypes_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x0009B914 File Offset: 0x00099B14
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 77931, RefRangeEnd = 77941, XrefRangeStart = 77918, XrefRangeEnd = 77931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsConflictArchetype(this Archetype arch, Nullable<int> conflictLevel = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(conflictLevel));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeExtensions.NativeMethodInfoPtr_IsConflictArchetype_Public_Static_Boolean_Archetype_Nullable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x0009B96C File Offset: 0x00099B6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77948, RefRangeEnd = 77949, XrefRangeStart = 77941, XrefRangeEnd = 77948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLeaderArchetype(this Archetype arch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeExtensions.NativeMethodInfoPtr_IsLeaderArchetype_Public_Static_Boolean_Archetype_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x0009B9B0 File Offset: 0x00099BB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77956, RefRangeEnd = 77957, XrefRangeStart = 77949, XrefRangeEnd = 77956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsHagalArchetype(this Archetype arch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeExtensions.NativeMethodInfoPtr_IsHagalArchetype_Public_Static_Boolean_Archetype_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x0009B9F4 File Offset: 0x00099BF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77964, RefRangeEnd = 77965, XrefRangeStart = 77957, XrefRangeEnd = 77964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsTechTileArchetype(this Archetype arch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeExtensions.NativeMethodInfoPtr_IsTechTileArchetype_Public_Static_Boolean_Archetype_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x0009BA38 File Offset: 0x00099C38
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 77972, RefRangeEnd = 77978, XrefRangeStart = 77965, XrefRangeEnd = 77972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsTleilaxuArchetype(this Archetype arch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeExtensions.NativeMethodInfoPtr_IsTleilaxuArchetype_Public_Static_Boolean_Archetype_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x0009BA7C File Offset: 0x00099C7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 77979, RefRangeEnd = 77981, XrefRangeStart = 77978, XrefRangeEnd = 77979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsImperiumOrTleilaxuArchetype(this Archetype arch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeExtensions.NativeMethodInfoPtr_IsImperiumOrTleilaxuArchetype_Public_Static_Boolean_Archetype_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x0009BAC0 File Offset: 0x00099CC0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 77998, RefRangeEnd = 78005, XrefRangeStart = 77981, XrefRangeEnd = 77998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsInSet(this Archetype arch, Set checkSet)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkSet;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeExtensions.NativeMethodInfoPtr_IsInSet_Public_Static_Boolean_Archetype_Set_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x0009BB10 File Offset: 0x00099D10
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 78028, RefRangeEnd = 78032, XrefRangeStart = 78005, XrefRangeEnd = 78028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsInSets(this Archetype arch, IEnumerable<Set> setList)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeExtensions.NativeMethodInfoPtr_IsInSets_Public_Static_Boolean_Archetype_IEnumerable_1_Set_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x000084B2 File Offset: 0x000066B2
		public WormArchetypeExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeMethodInfoPtr_IsSpaceArchetype_Public_Static_Boolean_Archetype_Nullable_1_AgentIcons_0;

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeMethodInfoPtr_IsImperiumArchetype_Public_Static_Boolean_Archetype_Nullable_1_ImperiumTypes_0;

		// Token: 0x04000A4B RID: 2635
		private static readonly IntPtr NativeMethodInfoPtr_IsIntrigueArchetype_Public_Static_Boolean_Archetype_Nullable_1_IntrigueTypes_0;

		// Token: 0x04000A4C RID: 2636
		private static readonly IntPtr NativeMethodInfoPtr_IsConflictArchetype_Public_Static_Boolean_Archetype_Nullable_1_Int32_0;

		// Token: 0x04000A4D RID: 2637
		private static readonly IntPtr NativeMethodInfoPtr_IsLeaderArchetype_Public_Static_Boolean_Archetype_0;

		// Token: 0x04000A4E RID: 2638
		private static readonly IntPtr NativeMethodInfoPtr_IsHagalArchetype_Public_Static_Boolean_Archetype_0;

		// Token: 0x04000A4F RID: 2639
		private static readonly IntPtr NativeMethodInfoPtr_IsTechTileArchetype_Public_Static_Boolean_Archetype_0;

		// Token: 0x04000A50 RID: 2640
		private static readonly IntPtr NativeMethodInfoPtr_IsTleilaxuArchetype_Public_Static_Boolean_Archetype_0;

		// Token: 0x04000A51 RID: 2641
		private static readonly IntPtr NativeMethodInfoPtr_IsImperiumOrTleilaxuArchetype_Public_Static_Boolean_Archetype_0;

		// Token: 0x04000A52 RID: 2642
		private static readonly IntPtr NativeMethodInfoPtr_IsInSet_Public_Static_Boolean_Archetype_Set_0;

		// Token: 0x04000A53 RID: 2643
		private static readonly IntPtr NativeMethodInfoPtr_IsInSets_Public_Static_Boolean_Archetype_IEnumerable_1_Set_0;
	}
}
