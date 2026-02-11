using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace canis.archetypes
{
	// Token: 0x0200000E RID: 14
	public static class ArchetypeIDUtils : Object
	{
		// Token: 0x06000084 RID: 132 RVA: 0x0001B0CC File Offset: 0x000192CC
		// Note: this type is marked as 'beforefieldinit'.
		static ArchetypeIDUtils()
		{
			Il2CppClassPointerStore<ArchetypeIDUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "canis.archetypes", "ArchetypeIDUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchetypeIDUtils>.NativeClassPtr);
			ArchetypeIDUtils.NativeMethodInfoPtr_Lookup_Public_Static_Archetype_ArchetypeID_Archetypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeIDUtils>.NativeClassPtr, 100663320);
			ArchetypeIDUtils.NativeMethodInfoPtr_Lookup_Public_Static_Archetype_ArchetypeID_IHasArchetypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeIDUtils>.NativeClassPtr, 100663321);
			ArchetypeIDUtils.NativeMethodInfoPtr_TryLookup_Public_Static_Boolean_ArchetypeID_Archetypes_byref_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeIDUtils>.NativeClassPtr, 100663322);
			ArchetypeIDUtils.NativeMethodInfoPtr_TryLookup_Public_Static_Boolean_ArchetypeID_IHasArchetypes_byref_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeIDUtils>.NativeClassPtr, 100663323);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0001B14C File Offset: 0x0001934C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543036, XrefRangeEnd = 543040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Archetype Lookup(this ArchetypeID archetypeID, Archetypes archetypes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archetypeID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(archetypes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeIDUtils.NativeMethodInfoPtr_Lookup_Public_Static_Archetype_ArchetypeID_Archetypes_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Archetype>(intPtr3) : null;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0001B1A4 File Offset: 0x000193A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543040, XrefRangeEnd = 543047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Archetype Lookup(this ArchetypeID archetypeID, IHasArchetypes ha)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archetypeID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ha);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeIDUtils.NativeMethodInfoPtr_Lookup_Public_Static_Archetype_ArchetypeID_IHasArchetypes_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Archetype>(intPtr3) : null;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0001B1FC File Offset: 0x000193FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543047, XrefRangeEnd = 543058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryLookup(this ArchetypeID archetypeID, Archetypes archetypes, out Archetype archetype)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archetypeID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(archetypes);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArchetypeIDUtils.NativeMethodInfoPtr_TryLookup_Public_Static_Boolean_ArchetypeID_Archetypes_byref_Archetype_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			archetype = ((intPtr4 == 0) ? null : new Archetype(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0001B274 File Offset: 0x00019474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543058, XrefRangeEnd = 543073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryLookup(this ArchetypeID archetypeID, IHasArchetypes ha, out Archetype archetype)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archetypeID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ha);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArchetypeIDUtils.NativeMethodInfoPtr_TryLookup_Public_Static_Boolean_ArchetypeID_IHasArchetypes_byref_Archetype_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			archetype = ((intPtr4 == 0) ? null : new Archetype(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000024D2 File Offset: 0x000006D2
		public ArchetypeIDUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_Lookup_Public_Static_Archetype_ArchetypeID_Archetypes_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_Lookup_Public_Static_Archetype_ArchetypeID_IHasArchetypes_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_TryLookup_Public_Static_Boolean_ArchetypeID_Archetypes_byref_Archetype_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_TryLookup_Public_Static_Boolean_ArchetypeID_IHasArchetypes_byref_Archetype_0;
	}
}
