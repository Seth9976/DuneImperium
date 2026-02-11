using System;
using Canis;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace canis.archetypes
{
	// Token: 0x0200000F RID: 15
	public class Archetypes : Object
	{
		// Token: 0x0600008A RID: 138 RVA: 0x0001B2EC File Offset: 0x000194EC
		// Note: this type is marked as 'beforefieldinit'.
		static Archetypes()
		{
			Il2CppClassPointerStore<Archetypes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "canis.archetypes", "Archetypes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Archetypes>.NativeClassPtr);
			Archetypes.NativeFieldInfoPtr_archetypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Archetypes>.NativeClassPtr, "archetypes");
			Archetypes.NativeMethodInfoPtr_AllArchetypes_Public_Abstract_Virtual_New_IEnumerable_1_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetypes>.NativeClassPtr, 100663324);
			Archetypes.NativeMethodInfoPtr_Get_Public_Archetype_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetypes>.NativeClassPtr, 100663325);
			Archetypes.NativeMethodInfoPtr_HasKey_Public_Boolean_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetypes>.NativeClassPtr, 100663326);
			Archetypes.NativeMethodInfoPtr_Configure_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetypes>.NativeClassPtr, 100663327);
			Archetypes.NativeMethodInfoPtr_ConfigureArchetype_Protected_Virtual_New_Void_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetypes>.NativeClassPtr, 100663328);
			Archetypes.NativeMethodInfoPtr_CreateEntity_Public_Abstract_Virtual_New_Entity_ArchetypeID_Match_PlayerEntity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetypes>.NativeClassPtr, 100663329);
			Archetypes.NativeMethodInfoPtr_CreateEntity_Public_Abstract_Virtual_New_Entity_Archetype_Match_PlayerEntity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetypes>.NativeClassPtr, 100663330);
			Archetypes.NativeMethodInfoPtr_DeserializeEntity_Public_Abstract_Virtual_New_Entity_ArchetypeID_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetypes>.NativeClassPtr, 100663331);
			Archetypes.NativeMethodInfoPtr_CreateEntities_Public_Abstract_Virtual_New_Void_Archetype_Match_PlayerEntity_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetypes>.NativeClassPtr, 100663332);
			Archetypes.NativeMethodInfoPtr_CreateEntities_Public_Abstract_Virtual_New_Void_ArchetypeID_Match_PlayerEntity_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetypes>.NativeClassPtr, 100663333);
			Archetypes.NativeMethodInfoPtr_CreateEntity_Public_Entity_Match_ArchetypeID_Entity_PlayerEntity_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetypes>.NativeClassPtr, 100663334);
			Archetypes.NativeMethodInfoPtr_CreateEntity_Public_Entity_Match_Archetype_Entity_PlayerEntity_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetypes>.NativeClassPtr, 100663335);
			Archetypes.NativeMethodInfoPtr_CreateArchetypesFromSheet_Public_Virtual_New_IEnumerable_1_Archetype_String_IList_1_IList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetypes>.NativeClassPtr, 100663336);
			Archetypes.NativeMethodInfoPtr_CreateGenericArchetypes_Public_Virtual_New_IEnumerable_1_Archetype_IList_1_IList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetypes>.NativeClassPtr, 100663337);
			Archetypes.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetypes>.NativeClassPtr, 100663338);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0001B45C File Offset: 0x0001965C
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Archetype> AllArchetypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Archetypes.NativeMethodInfoPtr_AllArchetypes_Public_Abstract_Virtual_New_IEnumerable_1_Archetype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Archetype>>(intPtr3) : null;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0001B4A8 File Offset: 0x000196A8
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 543154, RefRangeEnd = 543187, XrefRangeStart = 543150, XrefRangeEnd = 543154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Archetype Get(ArchetypeID archetypeID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archetypeID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Archetypes.NativeMethodInfoPtr_Get_Public_Archetype_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Archetype>(intPtr3) : null;
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0001B4F8 File Offset: 0x000196F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543187, XrefRangeEnd = 543191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasKey(ArchetypeID archetypeID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archetypeID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Archetypes.NativeMethodInfoPtr_HasKey_Public_Boolean_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0001B548 File Offset: 0x00019748
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 543211, RefRangeEnd = 543215, XrefRangeStart = 543191, XrefRangeEnd = 543211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Configure()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Archetypes.NativeMethodInfoPtr_Configure_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0001B584 File Offset: 0x00019784
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ConfigureArchetype(Archetype archetype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archetype);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Archetypes.NativeMethodInfoPtr_ConfigureArchetype_Protected_Virtual_New_Void_Archetype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0001B5D4 File Offset: 0x000197D4
		[CallerCount(0)]
		public unsafe virtual Entity CreateEntity(ArchetypeID archID, Match m, PlayerEntity player, Entity parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Archetypes.NativeMethodInfoPtr_CreateEntity_Public_Abstract_Virtual_New_Entity_ArchetypeID_Match_PlayerEntity_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0001B668 File Offset: 0x00019868
		[CallerCount(0)]
		public unsafe virtual Entity CreateEntity(Archetype arch, Match m, PlayerEntity player, Entity parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Archetypes.NativeMethodInfoPtr_CreateEntity_Public_Abstract_Virtual_New_Entity_Archetype_Match_PlayerEntity_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0001B6FC File Offset: 0x000198FC
		[CallerCount(0)]
		public unsafe virtual Entity DeserializeEntity(ArchetypeID archID, SerializedEntity se, Match m, Entity parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(se);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Archetypes.NativeMethodInfoPtr_DeserializeEntity_Public_Abstract_Virtual_New_Entity_ArchetypeID_SerializedEntity_Match_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0001B790 File Offset: 0x00019990
		[CallerCount(0)]
		public unsafe virtual void CreateEntities(Archetype arch, Match m, PlayerEntity player, Entity parent, int num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref num;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Archetypes.NativeMethodInfoPtr_CreateEntities_Public_Abstract_Virtual_New_Void_Archetype_Match_PlayerEntity_Entity_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0001B824 File Offset: 0x00019A24
		[CallerCount(0)]
		public unsafe virtual void CreateEntities(ArchetypeID archID, Match m, PlayerEntity player, Entity parent, int num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref num;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Archetypes.NativeMethodInfoPtr_CreateEntities_Public_Abstract_Virtual_New_Void_ArchetypeID_Match_PlayerEntity_Entity_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0001B8B8 File Offset: 0x00019AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543215, XrefRangeEnd = 543225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entity CreateEntity(Match m, ArchetypeID archetypeID, Entity parent, PlayerEntity player = null, Nullable<int> positionInParent = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(archetypeID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(positionInParent));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Archetypes.NativeMethodInfoPtr_CreateEntity_Public_Entity_Match_ArchetypeID_Entity_PlayerEntity_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0001B958 File Offset: 0x00019B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543225, XrefRangeEnd = 543232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entity CreateEntity(Match m, Archetype archetype, Entity parent, PlayerEntity player = null, Nullable<int> positionInParent = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(archetype);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(positionInParent));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Archetypes.NativeMethodInfoPtr_CreateEntity_Public_Entity_Match_Archetype_Entity_PlayerEntity_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0001B9F8 File Offset: 0x00019BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543232, XrefRangeEnd = 543237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<Archetype> CreateArchetypesFromSheet(string sheet, IList<IList<Object>> values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sheet);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Archetypes.NativeMethodInfoPtr_CreateArchetypesFromSheet_Public_Virtual_New_IEnumerable_1_Archetype_String_IList_1_IList_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Archetype>>(intPtr3) : null;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0001BA68 File Offset: 0x00019C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543237, XrefRangeEnd = 543243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<Archetype> CreateGenericArchetypes(IList<IList<Object>> values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Archetypes.NativeMethodInfoPtr_CreateGenericArchetypes_Public_Virtual_New_IEnumerable_1_Archetype_IList_1_IList_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Archetype>>(intPtr3) : null;
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0001BAC4 File Offset: 0x00019CC4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 543251, RefRangeEnd = 543255, XrefRangeStart = 543243, XrefRangeEnd = 543251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Archetypes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Archetypes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Archetypes.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000024DB File Offset: 0x000006DB
		public Archetypes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600009B RID: 155 RVA: 0x0001BB00 File Offset: 0x00019D00
		// (set) Token: 0x0600009C RID: 156 RVA: 0x000024E4 File Offset: 0x000006E4
		public unsafe Dictionary<ArchetypeID, Archetype> archetypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Archetypes.NativeFieldInfoPtr_archetypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ArchetypeID, Archetype>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Archetypes.NativeFieldInfoPtr_archetypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr_archetypes;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_AllArchetypes_Public_Abstract_Virtual_New_IEnumerable_1_Archetype_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Archetype_ArchetypeID_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_HasKey_Public_Boolean_ArchetypeID_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Virtual_New_Void_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureArchetype_Protected_Virtual_New_Void_Archetype_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntity_Public_Abstract_Virtual_New_Entity_ArchetypeID_Match_PlayerEntity_Entity_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntity_Public_Abstract_Virtual_New_Entity_Archetype_Match_PlayerEntity_Entity_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeEntity_Public_Abstract_Virtual_New_Entity_ArchetypeID_SerializedEntity_Match_Entity_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntities_Public_Abstract_Virtual_New_Void_Archetype_Match_PlayerEntity_Entity_Int32_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntities_Public_Abstract_Virtual_New_Void_ArchetypeID_Match_PlayerEntity_Entity_Int32_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntity_Public_Entity_Match_ArchetypeID_Entity_PlayerEntity_Nullable_1_Int32_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntity_Public_Entity_Match_Archetype_Entity_PlayerEntity_Nullable_1_Int32_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_CreateArchetypesFromSheet_Public_Virtual_New_IEnumerable_1_Archetype_String_IList_1_IList_1_Object_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_CreateGenericArchetypes_Public_Virtual_New_IEnumerable_1_Archetype_IList_1_IList_1_Object_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000237 RID: 567
		[ObfuscatedName("canis.archetypes.Archetypes+<CreateArchetypesFromSheet>d__13")]
		public sealed class _CreateArchetypesFromSheet_d__13 : Object
		{
			// Token: 0x0600178D RID: 6029 RVA: 0x00077B80 File Offset: 0x00075D80
			// Note: this type is marked as 'beforefieldinit'.
			static _CreateArchetypesFromSheet_d__13()
			{
				Il2CppClassPointerStore<Archetypes._CreateArchetypesFromSheet_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Archetypes>.NativeClassPtr, "<CreateArchetypesFromSheet>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Archetypes._CreateArchetypesFromSheet_d__13>.NativeClassPtr);
				Archetypes._CreateArchetypesFromSheet_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Archetypes._CreateArchetypesFromSheet_d__13>.NativeClassPtr, "<>1__state");
				Archetypes._CreateArchetypesFromSheet_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Archetypes._CreateArchetypesFromSheet_d__13>.NativeClassPtr, "<>2__current");
				Archetypes._CreateArchetypesFromSheet_d__13.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Archetypes._CreateArchetypesFromSheet_d__13>.NativeClassPtr, "<>l__initialThreadId");
				Archetypes._CreateArchetypesFromSheet_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetypes._CreateArchetypesFromSheet_d__13>.NativeClassPtr, 100663339);
				Archetypes._CreateArchetypesFromSheet_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetypes._CreateArchetypesFromSheet_d__13>.NativeClassPtr, 100663340);
				Archetypes._CreateArchetypesFromSheet_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetypes._CreateArchetypesFromSheet_d__13>.NativeClassPtr, 100663341);
				Archetypes._CreateArchetypesFromSheet_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_canis_archetypes_Archetype__get_Current_Private_Virtual_Final_New_get_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetypes._CreateArchetypesFromSheet_d__13>.NativeClassPtr, 100663342);
				Archetypes._CreateArchetypesFromSheet_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetypes._CreateArchetypesFromSheet_d__13>.NativeClassPtr, 100663343);
				Archetypes._CreateArchetypesFromSheet_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetypes._CreateArchetypesFromSheet_d__13>.NativeClassPtr, 100663344);
				Archetypes._CreateArchetypesFromSheet_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_canis_archetypes_Archetype__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetypes._CreateArchetypesFromSheet_d__13>.NativeClassPtr, 100663345);
				Archetypes._CreateArchetypesFromSheet_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetypes._CreateArchetypesFromSheet_d__13>.NativeClassPtr, 100663346);
			}

			// Token: 0x0600178E RID: 6030 RVA: 0x00077C88 File Offset: 0x00075E88
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CreateArchetypesFromSheet_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Archetypes._CreateArchetypesFromSheet_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Archetypes._CreateArchetypesFromSheet_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600178F RID: 6031 RVA: 0x00077CD0 File Offset: 0x00075ED0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Archetypes._CreateArchetypesFromSheet_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001790 RID: 6032 RVA: 0x00077D04 File Offset: 0x00075F04
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Archetypes._CreateArchetypesFromSheet_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000511 RID: 1297
			// (get) Token: 0x06001791 RID: 6033 RVA: 0x00077D40 File Offset: 0x00075F40
			public unsafe Archetype System.Collections.Generic.IEnumerator<canis.archetypes.Archetype>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Archetypes._CreateArchetypesFromSheet_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_canis_archetypes_Archetype__get_Current_Private_Virtual_Final_New_get_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Archetype>(intPtr3) : null;
				}
			}

			// Token: 0x06001792 RID: 6034 RVA: 0x00077D80 File Offset: 0x00075F80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543073, XrefRangeEnd = 543078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Archetypes._CreateArchetypesFromSheet_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000512 RID: 1298
			// (get) Token: 0x06001793 RID: 6035 RVA: 0x00077DB4 File Offset: 0x00075FB4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Archetypes._CreateArchetypesFromSheet_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001794 RID: 6036 RVA: 0x00077DF4 File Offset: 0x00075FF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543078, XrefRangeEnd = 543080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Archetype> System_Collections_Generic_IEnumerable_canis_archetypes_Archetype__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Archetypes._CreateArchetypesFromSheet_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_canis_archetypes_Archetype__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Archetype>>(intPtr3) : null;
			}

			// Token: 0x06001795 RID: 6037 RVA: 0x00077E34 File Offset: 0x00076034
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Archetypes._CreateArchetypesFromSheet_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001796 RID: 6038 RVA: 0x0000B3E4 File Offset: 0x000095E4
			public _CreateArchetypesFromSheet_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700050E RID: 1294
			// (get) Token: 0x06001797 RID: 6039 RVA: 0x00077E74 File Offset: 0x00076074
			// (set) Token: 0x06001798 RID: 6040 RVA: 0x0000B3ED File Offset: 0x000095ED
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Archetypes._CreateArchetypesFromSheet_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Archetypes._CreateArchetypesFromSheet_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700050F RID: 1295
			// (get) Token: 0x06001799 RID: 6041 RVA: 0x00077E9C File Offset: 0x0007609C
			// (set) Token: 0x0600179A RID: 6042 RVA: 0x0000B408 File Offset: 0x00009608
			public unsafe Archetype __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Archetypes._CreateArchetypesFromSheet_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Archetype>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Archetypes._CreateArchetypesFromSheet_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000510 RID: 1296
			// (get) Token: 0x0600179B RID: 6043 RVA: 0x00077ECC File Offset: 0x000760CC
			// (set) Token: 0x0600179C RID: 6044 RVA: 0x0000B427 File Offset: 0x00009627
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Archetypes._CreateArchetypesFromSheet_d__13.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Archetypes._CreateArchetypesFromSheet_d__13.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x04000F15 RID: 3861
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000F16 RID: 3862
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000F17 RID: 3863
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000F18 RID: 3864
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000F19 RID: 3865
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F1A RID: 3866
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000F1B RID: 3867
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_canis_archetypes_Archetype__get_Current_Private_Virtual_Final_New_get_Archetype_0;

			// Token: 0x04000F1C RID: 3868
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F1D RID: 3869
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000F1E RID: 3870
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_canis_archetypes_Archetype__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Archetype_0;

			// Token: 0x04000F1F RID: 3871
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000238 RID: 568
		[ObfuscatedName("canis.archetypes.Archetypes+<CreateGenericArchetypes>d__14")]
		public sealed class _CreateGenericArchetypes_d__14 : Object
		{
			// Token: 0x0600179D RID: 6045 RVA: 0x00077EF4 File Offset: 0x000760F4
			// Note: this type is marked as 'beforefieldinit'.
			static _CreateGenericArchetypes_d__14()
			{
				Il2CppClassPointerStore<Archetypes._CreateGenericArchetypes_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Archetypes>.NativeClassPtr, "<CreateGenericArchetypes>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Archetypes._CreateGenericArchetypes_d__14>.NativeClassPtr);
				Archetypes._CreateGenericArchetypes_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Archetypes._CreateGenericArchetypes_d__14>.NativeClassPtr, "<>1__state");
				Archetypes._CreateGenericArchetypes_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Archetypes._CreateGenericArchetypes_d__14>.NativeClassPtr, "<>2__current");
				Archetypes._CreateGenericArchetypes_d__14.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Archetypes._CreateGenericArchetypes_d__14>.NativeClassPtr, "<>l__initialThreadId");
				Archetypes._CreateGenericArchetypes_d__14.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Archetypes._CreateGenericArchetypes_d__14>.NativeClassPtr, "values");
				Archetypes._CreateGenericArchetypes_d__14.NativeFieldInfoPtr___3__values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Archetypes._CreateGenericArchetypes_d__14>.NativeClassPtr, "<>3__values");
				Archetypes._CreateGenericArchetypes_d__14.NativeFieldInfoPtr__header_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Archetypes._CreateGenericArchetypes_d__14>.NativeClassPtr, "<header>5__2");
				Archetypes._CreateGenericArchetypes_d__14.NativeFieldInfoPtr__headerMap_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Archetypes._CreateGenericArchetypes_d__14>.NativeClassPtr, "<headerMap>5__3");
				Archetypes._CreateGenericArchetypes_d__14.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Archetypes._CreateGenericArchetypes_d__14>.NativeClassPtr, "<>7__wrap3");
				Archetypes._CreateGenericArchetypes_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetypes._CreateGenericArchetypes_d__14>.NativeClassPtr, 100663347);
				Archetypes._CreateGenericArchetypes_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetypes._CreateGenericArchetypes_d__14>.NativeClassPtr, 100663348);
				Archetypes._CreateGenericArchetypes_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetypes._CreateGenericArchetypes_d__14>.NativeClassPtr, 100663349);
				Archetypes._CreateGenericArchetypes_d__14.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetypes._CreateGenericArchetypes_d__14>.NativeClassPtr, 100663350);
				Archetypes._CreateGenericArchetypes_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_canis_archetypes_Archetype__get_Current_Private_Virtual_Final_New_get_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetypes._CreateGenericArchetypes_d__14>.NativeClassPtr, 100663351);
				Archetypes._CreateGenericArchetypes_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetypes._CreateGenericArchetypes_d__14>.NativeClassPtr, 100663352);
				Archetypes._CreateGenericArchetypes_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetypes._CreateGenericArchetypes_d__14>.NativeClassPtr, 100663353);
				Archetypes._CreateGenericArchetypes_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_canis_archetypes_Archetype__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetypes._CreateGenericArchetypes_d__14>.NativeClassPtr, 100663354);
				Archetypes._CreateGenericArchetypes_d__14.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archetypes._CreateGenericArchetypes_d__14>.NativeClassPtr, 100663355);
			}

			// Token: 0x0600179E RID: 6046 RVA: 0x00078074 File Offset: 0x00076274
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CreateGenericArchetypes_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Archetypes._CreateGenericArchetypes_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Archetypes._CreateGenericArchetypes_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600179F RID: 6047 RVA: 0x000780BC File Offset: 0x000762BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543080, XrefRangeEnd = 543085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Archetypes._CreateGenericArchetypes_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017A0 RID: 6048 RVA: 0x000780F0 File Offset: 0x000762F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543085, XrefRangeEnd = 543134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Archetypes._CreateGenericArchetypes_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060017A1 RID: 6049 RVA: 0x0007812C File Offset: 0x0007632C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543134, XrefRangeEnd = 543137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Archetypes._CreateGenericArchetypes_d__14.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700051B RID: 1307
			// (get) Token: 0x060017A2 RID: 6050 RVA: 0x00078160 File Offset: 0x00076360
			public unsafe Archetype System.Collections.Generic.IEnumerator<canis.archetypes.Archetype>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Archetypes._CreateGenericArchetypes_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_canis_archetypes_Archetype__get_Current_Private_Virtual_Final_New_get_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Archetype>(intPtr3) : null;
				}
			}

			// Token: 0x060017A3 RID: 6051 RVA: 0x000781A0 File Offset: 0x000763A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543137, XrefRangeEnd = 543142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Archetypes._CreateGenericArchetypes_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700051C RID: 1308
			// (get) Token: 0x060017A4 RID: 6052 RVA: 0x000781D4 File Offset: 0x000763D4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Archetypes._CreateGenericArchetypes_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060017A5 RID: 6053 RVA: 0x00078214 File Offset: 0x00076414
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543142, XrefRangeEnd = 543150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Archetype> System_Collections_Generic_IEnumerable_canis_archetypes_Archetype__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Archetypes._CreateGenericArchetypes_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_canis_archetypes_Archetype__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Archetype>>(intPtr3) : null;
			}

			// Token: 0x060017A6 RID: 6054 RVA: 0x00078254 File Offset: 0x00076454
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Archetypes._CreateGenericArchetypes_d__14.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060017A7 RID: 6055 RVA: 0x0000B442 File Offset: 0x00009642
			public _CreateGenericArchetypes_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000513 RID: 1299
			// (get) Token: 0x060017A8 RID: 6056 RVA: 0x00078294 File Offset: 0x00076494
			// (set) Token: 0x060017A9 RID: 6057 RVA: 0x0000B44B File Offset: 0x0000964B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Archetypes._CreateGenericArchetypes_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Archetypes._CreateGenericArchetypes_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000514 RID: 1300
			// (get) Token: 0x060017AA RID: 6058 RVA: 0x000782BC File Offset: 0x000764BC
			// (set) Token: 0x060017AB RID: 6059 RVA: 0x0000B466 File Offset: 0x00009666
			public unsafe Archetype __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Archetypes._CreateGenericArchetypes_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Archetype>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Archetypes._CreateGenericArchetypes_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000515 RID: 1301
			// (get) Token: 0x060017AC RID: 6060 RVA: 0x000782EC File Offset: 0x000764EC
			// (set) Token: 0x060017AD RID: 6061 RVA: 0x0000B485 File Offset: 0x00009685
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Archetypes._CreateGenericArchetypes_d__14.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Archetypes._CreateGenericArchetypes_d__14.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000516 RID: 1302
			// (get) Token: 0x060017AE RID: 6062 RVA: 0x00078314 File Offset: 0x00076514
			// (set) Token: 0x060017AF RID: 6063 RVA: 0x0000B4A0 File Offset: 0x000096A0
			public unsafe IList<IList<Object>> values
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Archetypes._CreateGenericArchetypes_d__14.NativeFieldInfoPtr_values);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<IList<Object>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Archetypes._CreateGenericArchetypes_d__14.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000517 RID: 1303
			// (get) Token: 0x060017B0 RID: 6064 RVA: 0x00078344 File Offset: 0x00076544
			// (set) Token: 0x060017B1 RID: 6065 RVA: 0x0000B4BF File Offset: 0x000096BF
			public unsafe IList<IList<Object>> __3__values
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Archetypes._CreateGenericArchetypes_d__14.NativeFieldInfoPtr___3__values);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<IList<Object>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Archetypes._CreateGenericArchetypes_d__14.NativeFieldInfoPtr___3__values), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000518 RID: 1304
			// (get) Token: 0x060017B2 RID: 6066 RVA: 0x00078374 File Offset: 0x00076574
			// (set) Token: 0x060017B3 RID: 6067 RVA: 0x0000B4DE File Offset: 0x000096DE
			public unsafe bool _header_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Archetypes._CreateGenericArchetypes_d__14.NativeFieldInfoPtr__header_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Archetypes._CreateGenericArchetypes_d__14.NativeFieldInfoPtr__header_5__2)) = value;
				}
			}

			// Token: 0x17000519 RID: 1305
			// (get) Token: 0x060017B4 RID: 6068 RVA: 0x0007839C File Offset: 0x0007659C
			// (set) Token: 0x060017B5 RID: 6069 RVA: 0x0000B4F9 File Offset: 0x000096F9
			public unsafe Dictionary<int, string> _headerMap_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Archetypes._CreateGenericArchetypes_d__14.NativeFieldInfoPtr__headerMap_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Archetypes._CreateGenericArchetypes_d__14.NativeFieldInfoPtr__headerMap_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700051A RID: 1306
			// (get) Token: 0x060017B6 RID: 6070 RVA: 0x000783CC File Offset: 0x000765CC
			// (set) Token: 0x060017B7 RID: 6071 RVA: 0x0000B518 File Offset: 0x00009718
			public unsafe IEnumerator<IList<Object>> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Archetypes._CreateGenericArchetypes_d__14.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<IList<Object>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Archetypes._CreateGenericArchetypes_d__14.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000F20 RID: 3872
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000F21 RID: 3873
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000F22 RID: 3874
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000F23 RID: 3875
			private static readonly IntPtr NativeFieldInfoPtr_values;

			// Token: 0x04000F24 RID: 3876
			private static readonly IntPtr NativeFieldInfoPtr___3__values;

			// Token: 0x04000F25 RID: 3877
			private static readonly IntPtr NativeFieldInfoPtr__header_5__2;

			// Token: 0x04000F26 RID: 3878
			private static readonly IntPtr NativeFieldInfoPtr__headerMap_5__3;

			// Token: 0x04000F27 RID: 3879
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04000F28 RID: 3880
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000F29 RID: 3881
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F2A RID: 3882
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000F2B RID: 3883
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000F2C RID: 3884
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_canis_archetypes_Archetype__get_Current_Private_Virtual_Final_New_get_Archetype_0;

			// Token: 0x04000F2D RID: 3885
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F2E RID: 3886
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000F2F RID: 3887
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_canis_archetypes_Archetype__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Archetype_0;

			// Token: 0x04000F30 RID: 3888
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
