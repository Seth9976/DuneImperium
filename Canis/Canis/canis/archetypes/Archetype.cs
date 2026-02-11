using System;
using Canis;
using Canis.attributes;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace canis.archetypes
{
	// Token: 0x0200000D RID: 13
	[Serializable]
	public class Archetype : ObjectAttributes
	{
		// Token: 0x06000077 RID: 119 RVA: 0x0001AD3C File Offset: 0x00018F3C
		// Note: this type is marked as 'beforefieldinit'.
		static Archetype()
		{
			Il2CppClassPointerStore<Archetype>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "canis.archetypes", "Archetype");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Archetype>.NativeClassPtr);
			Archetype.NativeFieldInfoPtr_randomArchetypeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Archetype>.NativeClassPtr, "randomArchetypeID");
			Archetype.NativeFieldInfoPtr__archetypeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Archetype>.NativeClassPtr, "_archetypeId");
			Archetype.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetype>.NativeClassPtr, 100663313);
			Archetype.NativeMethodInfoPtr__ctor_Public_Void_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetype>.NativeClassPtr, 100663314);
			Archetype.NativeMethodInfoPtr__ctor_Protected_Void_SerializableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetype>.NativeClassPtr, 100663315);
			Archetype.NativeMethodInfoPtr__ctor_Protected_Void_ArchetypeID_SerializableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetype>.NativeClassPtr, 100663316);
			Archetype.NativeMethodInfoPtr_get_ArchetypeID_Public_Virtual_New_get_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetype>.NativeClassPtr, 100663317);
			Archetype.NativeMethodInfoPtr_get_AbilityIDsAttribute_Public_Virtual_New_get_AttributeDefinition_1_List_1_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetype>.NativeClassPtr, 100663318);
			Archetype.NativeMethodInfoPtr_Build_Public_Virtual_New_Entity_Match_PlayerEntity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetype>.NativeClassPtr, 100663319);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0001AE20 File Offset: 0x00019020
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 542985, RefRangeEnd = 543011, XrefRangeStart = 542979, XrefRangeEnd = 542985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Archetype()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Archetype>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Archetype.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0001AE5C File Offset: 0x0001905C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 543018, RefRangeEnd = 543019, XrefRangeStart = 543011, XrefRangeEnd = 543018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Archetype(ArchetypeID archID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Archetype>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Archetype.NativeMethodInfoPtr__ctor_Public_Void_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0001AEA8 File Offset: 0x000190A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543019, XrefRangeEnd = 543025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Archetype(SerializableAttributes attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Archetype>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Archetype.NativeMethodInfoPtr__ctor_Protected_Void_SerializableAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0001AEF4 File Offset: 0x000190F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543025, XrefRangeEnd = 543032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Archetype(ArchetypeID archID, SerializableAttributes attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Archetype>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Archetype.NativeMethodInfoPtr__ctor_Protected_Void_ArchetypeID_SerializableAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600007C RID: 124 RVA: 0x0001AF54 File Offset: 0x00019154
		public unsafe virtual ArchetypeID ArchetypeID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Archetype.NativeMethodInfoPtr_get_ArchetypeID_Public_Virtual_New_get_ArchetypeID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600007D RID: 125 RVA: 0x0001AFA0 File Offset: 0x000191A0
		public unsafe virtual AttributeDefinition<List<AbilityID>> AbilityIDsAttribute
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543032, XrefRangeEnd = 543036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Archetype.NativeMethodInfoPtr_get_AbilityIDsAttribute_Public_Virtual_New_get_AttributeDefinition_1_List_1_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<AbilityID>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0001AFEC File Offset: 0x000191EC
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Entity Build(Match m, PlayerEntity owner, Entity parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Archetype.NativeMethodInfoPtr_Build_Public_Virtual_New_Entity_Match_PlayerEntity_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000248B File Offset: 0x0000068B
		public Archetype(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0001B06C File Offset: 0x0001926C
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00002494 File Offset: 0x00000694
		public unsafe ArchetypeID randomArchetypeID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Archetype.NativeFieldInfoPtr_randomArchetypeID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Archetype.NativeFieldInfoPtr_randomArchetypeID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000082 RID: 130 RVA: 0x0001B09C File Offset: 0x0001929C
		// (set) Token: 0x06000083 RID: 131 RVA: 0x000024B3 File Offset: 0x000006B3
		public unsafe ArchetypeID _archetypeId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Archetype.NativeFieldInfoPtr__archetypeId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Archetype.NativeFieldInfoPtr__archetypeId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_randomArchetypeID;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeFieldInfoPtr__archetypeId;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ArchetypeID_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializableAttributes_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_ArchetypeID_SerializableAttributes_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_get_ArchetypeID_Public_Virtual_New_get_ArchetypeID_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_get_AbilityIDsAttribute_Public_Virtual_New_get_AttributeDefinition_1_List_1_AbilityID_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_Build_Public_Virtual_New_Entity_Match_PlayerEntity_Entity_0;
	}
}
