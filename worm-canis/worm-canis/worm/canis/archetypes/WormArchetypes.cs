using System;
using Canis;
using canis.archetypes;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.abilities;

namespace worm.canis.archetypes
{
	// Token: 0x020000E8 RID: 232
	public class WormArchetypes : Archetypes
	{
		// Token: 0x06000FCF RID: 4047 RVA: 0x0009BB64 File Offset: 0x00099D64
		// Note: this type is marked as 'beforefieldinit'.
		static WormArchetypes()
		{
			Il2CppClassPointerStore<WormArchetypes>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes", "WormArchetypes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormArchetypes>.NativeClassPtr);
			WormArchetypes.NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetypes>.NativeClassPtr, "_instance");
			WormArchetypes.NativeFieldInfoPtr_Lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetypes>.NativeClassPtr, "Lock");
			WormArchetypes.NativeFieldInfoPtr_AbilityFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetypes>.NativeClassPtr, "AbilityFactory");
			WormArchetypes.NativeFieldInfoPtr_archs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetypes>.NativeClassPtr, "archs");
			WormArchetypes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypes>.NativeClassPtr, 100666075);
			WormArchetypes.NativeMethodInfoPtr_get_Instance_Public_Static_get_WormArchetypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypes>.NativeClassPtr, 100666076);
			WormArchetypes.NativeMethodInfoPtr_BaseConfigure_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypes>.NativeClassPtr, 100666077);
			WormArchetypes.NativeMethodInfoPtr_Configure_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypes>.NativeClassPtr, 100666078);
			WormArchetypes.NativeMethodInfoPtr_get_Project_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypes>.NativeClassPtr, 100666079);
			WormArchetypes.NativeMethodInfoPtr_CreateEntity_Public_Virtual_Entity_ArchetypeID_Match_PlayerEntity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypes>.NativeClassPtr, 100666080);
			WormArchetypes.NativeMethodInfoPtr_CreateEntity_Public_Virtual_Entity_Archetype_Match_PlayerEntity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypes>.NativeClassPtr, 100666081);
			WormArchetypes.NativeMethodInfoPtr_CreateEntities_Public_Virtual_Void_ArchetypeID_Match_PlayerEntity_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypes>.NativeClassPtr, 100666082);
			WormArchetypes.NativeMethodInfoPtr_DeserializeEntity_Public_Virtual_Entity_ArchetypeID_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypes>.NativeClassPtr, 100666083);
			WormArchetypes.NativeMethodInfoPtr_CreateEntities_Public_Virtual_Void_Archetype_Match_PlayerEntity_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypes>.NativeClassPtr, 100666084);
			WormArchetypes.NativeMethodInfoPtr_AllArchetypes_Public_Virtual_IEnumerable_1_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypes>.NativeClassPtr, 100666085);
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x0009BCC0 File Offset: 0x00099EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78078, XrefRangeEnd = 78088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormArchetypes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormArchetypes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06000FD1 RID: 4049 RVA: 0x0009BCFC File Offset: 0x00099EFC
		public unsafe static WormArchetypes Instance
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 78120, RefRangeEnd = 78129, XrefRangeStart = 78088, XrefRangeEnd = 78120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypes.NativeMethodInfoPtr_get_Instance_Public_Static_get_WormArchetypes_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormArchetypes>(intPtr3) : null;
			}
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x0009BD30 File Offset: 0x00099F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78129, XrefRangeEnd = 78130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BaseConfigure()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypes.NativeMethodInfoPtr_BaseConfigure_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x0009BD64 File Offset: 0x00099F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78130, XrefRangeEnd = 78132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Configure()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormArchetypes.NativeMethodInfoPtr_Configure_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x0009BDA0 File Offset: 0x00099FA0
		public unsafe static string Project
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78132, XrefRangeEnd = 78134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypes.NativeMethodInfoPtr_get_Project_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x0009BDCC File Offset: 0x00099FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78134, XrefRangeEnd = 78138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Entity CreateEntity(ArchetypeID archID, Match m, PlayerEntity player, Entity parent)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormArchetypes.NativeMethodInfoPtr_CreateEntity_Public_Virtual_Entity_ArchetypeID_Match_PlayerEntity_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x0009BE60 File Offset: 0x0009A060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78138, XrefRangeEnd = 78139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Entity CreateEntity(Archetype arch, Match m, PlayerEntity player, Entity parent)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormArchetypes.NativeMethodInfoPtr_CreateEntity_Public_Virtual_Entity_Archetype_Match_PlayerEntity_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x0009BEF4 File Offset: 0x0009A0F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78139, XrefRangeEnd = 78143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CreateEntities(ArchetypeID archID, Match m, PlayerEntity player, Entity parent, int num)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormArchetypes.NativeMethodInfoPtr_CreateEntities_Public_Virtual_Void_ArchetypeID_Match_PlayerEntity_Entity_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x0009BF88 File Offset: 0x0009A188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78143, XrefRangeEnd = 78195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Entity DeserializeEntity(ArchetypeID archID, SerializedEntity se, Match m, Entity parent)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormArchetypes.NativeMethodInfoPtr_DeserializeEntity_Public_Virtual_Entity_ArchetypeID_SerializedEntity_Match_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x0009C01C File Offset: 0x0009A21C
		[CallerCount(0)]
		public unsafe override void CreateEntities(Archetype arch, Match m, PlayerEntity player, Entity parent, int num)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormArchetypes.NativeMethodInfoPtr_CreateEntities_Public_Virtual_Void_Archetype_Match_PlayerEntity_Entity_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x0009C0B0 File Offset: 0x0009A2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78195, XrefRangeEnd = 78201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Archetype> AllArchetypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormArchetypes.NativeMethodInfoPtr_AllArchetypes_Public_Virtual_IEnumerable_1_Archetype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Archetype>>(intPtr3) : null;
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x000084BB File Offset: 0x000066BB
		public WormArchetypes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x0009C0FC File Offset: 0x0009A2FC
		// (set) Token: 0x06000FDD RID: 4061 RVA: 0x000084C4 File Offset: 0x000066C4
		public unsafe static WormArchetypes _instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormArchetypes.NativeFieldInfoPtr__instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormArchetypes>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormArchetypes.NativeFieldInfoPtr__instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x0009C124 File Offset: 0x0009A324
		// (set) Token: 0x06000FDF RID: 4063 RVA: 0x000084D6 File Offset: 0x000066D6
		public unsafe static Object Lock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormArchetypes.NativeFieldInfoPtr_Lock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormArchetypes.NativeFieldInfoPtr_Lock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x0009C14C File Offset: 0x0009A34C
		// (set) Token: 0x06000FE1 RID: 4065 RVA: 0x000084E8 File Offset: 0x000066E8
		public unsafe WormAbilityFactory AbilityFactory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypes.NativeFieldInfoPtr_AbilityFactory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAbilityFactory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypes.NativeFieldInfoPtr_AbilityFactory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x0009C17C File Offset: 0x0009A37C
		// (set) Token: 0x06000FE3 RID: 4067 RVA: 0x00008507 File Offset: 0x00006707
		public unsafe static Lazy<Il2CppReferenceArray<WormArchetype>> archs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormArchetypes.NativeFieldInfoPtr_archs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lazy<Il2CppReferenceArray<WormArchetype>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormArchetypes.NativeFieldInfoPtr_archs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A54 RID: 2644
		private static readonly IntPtr NativeFieldInfoPtr__instance;

		// Token: 0x04000A55 RID: 2645
		private static readonly IntPtr NativeFieldInfoPtr_Lock;

		// Token: 0x04000A56 RID: 2646
		private static readonly IntPtr NativeFieldInfoPtr_AbilityFactory;

		// Token: 0x04000A57 RID: 2647
		private static readonly IntPtr NativeFieldInfoPtr_archs;

		// Token: 0x04000A58 RID: 2648
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000A59 RID: 2649
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_WormArchetypes_0;

		// Token: 0x04000A5A RID: 2650
		private static readonly IntPtr NativeMethodInfoPtr_BaseConfigure_Private_Void_0;

		// Token: 0x04000A5B RID: 2651
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Virtual_Void_0;

		// Token: 0x04000A5C RID: 2652
		private static readonly IntPtr NativeMethodInfoPtr_get_Project_Public_Static_get_String_0;

		// Token: 0x04000A5D RID: 2653
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntity_Public_Virtual_Entity_ArchetypeID_Match_PlayerEntity_Entity_0;

		// Token: 0x04000A5E RID: 2654
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntity_Public_Virtual_Entity_Archetype_Match_PlayerEntity_Entity_0;

		// Token: 0x04000A5F RID: 2655
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntities_Public_Virtual_Void_ArchetypeID_Match_PlayerEntity_Entity_Int32_0;

		// Token: 0x04000A60 RID: 2656
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeEntity_Public_Virtual_Entity_ArchetypeID_SerializedEntity_Match_Entity_0;

		// Token: 0x04000A61 RID: 2657
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntities_Public_Virtual_Void_Archetype_Match_PlayerEntity_Entity_Int32_0;

		// Token: 0x04000A62 RID: 2658
		private static readonly IntPtr NativeMethodInfoPtr_AllArchetypes_Public_Virtual_IEnumerable_1_Archetype_0;

		// Token: 0x02000637 RID: 1591
		[ObfuscatedName("worm.canis.archetypes.WormArchetypes+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005035 RID: 20533 RVA: 0x001A9644 File Offset: 0x001A7844
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormArchetypes.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormArchetypes>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormArchetypes.__c>.NativeClassPtr);
				WormArchetypes.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetypes.__c>.NativeClassPtr, "<>9");
				WormArchetypes.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypes.__c>.NativeClassPtr, 100666088);
				WormArchetypes.__c.NativeMethodInfoPtr___cctor_b__17_0_Internal_Il2CppReferenceArray_1_WormArchetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypes.__c>.NativeClassPtr, 100666089);
			}

			// Token: 0x06005036 RID: 20534 RVA: 0x001A96AC File Offset: 0x001A78AC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormArchetypes.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypes.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005037 RID: 20535 RVA: 0x001A96E8 File Offset: 0x001A78E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78032, XrefRangeEnd = 78043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<WormArchetype> __cctor_b__17_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypes.__c.NativeMethodInfoPtr___cctor_b__17_0_Internal_Il2CppReferenceArray_1_WormArchetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WormArchetype>>(intPtr3) : null;
			}

			// Token: 0x06005038 RID: 20536 RVA: 0x0001BC00 File Offset: 0x00019E00
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170013BD RID: 5053
			// (get) Token: 0x06005039 RID: 20537 RVA: 0x001A9728 File Offset: 0x001A7928
			// (set) Token: 0x0600503A RID: 20538 RVA: 0x0001BC09 File Offset: 0x00019E09
			public unsafe static WormArchetypes.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormArchetypes.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormArchetypes.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormArchetypes.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040034A1 RID: 13473
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040034A2 RID: 13474
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040034A3 RID: 13475
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__17_0_Internal_Il2CppReferenceArray_1_WormArchetype_0;
		}

		// Token: 0x02000638 RID: 1592
		[ObfuscatedName("worm.canis.archetypes.WormArchetypes+<AllArchetypes>d__16")]
		public sealed class _AllArchetypes_d__16 : Object
		{
			// Token: 0x0600503B RID: 20539 RVA: 0x001A9750 File Offset: 0x001A7950
			// Note: this type is marked as 'beforefieldinit'.
			static _AllArchetypes_d__16()
			{
				Il2CppClassPointerStore<WormArchetypes._AllArchetypes_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormArchetypes>.NativeClassPtr, "<AllArchetypes>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormArchetypes._AllArchetypes_d__16>.NativeClassPtr);
				WormArchetypes._AllArchetypes_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetypes._AllArchetypes_d__16>.NativeClassPtr, "<>1__state");
				WormArchetypes._AllArchetypes_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetypes._AllArchetypes_d__16>.NativeClassPtr, "<>2__current");
				WormArchetypes._AllArchetypes_d__16.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetypes._AllArchetypes_d__16>.NativeClassPtr, "<>l__initialThreadId");
				WormArchetypes._AllArchetypes_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetypes._AllArchetypes_d__16>.NativeClassPtr, "<>4__this");
				WormArchetypes._AllArchetypes_d__16.NativeFieldInfoPtr__sanityCheck_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetypes._AllArchetypes_d__16>.NativeClassPtr, "<sanityCheck>5__2");
				WormArchetypes._AllArchetypes_d__16.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetypes._AllArchetypes_d__16>.NativeClassPtr, "<>7__wrap2");
				WormArchetypes._AllArchetypes_d__16.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetypes._AllArchetypes_d__16>.NativeClassPtr, "<>7__wrap3");
				WormArchetypes._AllArchetypes_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypes._AllArchetypes_d__16>.NativeClassPtr, 100666090);
				WormArchetypes._AllArchetypes_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypes._AllArchetypes_d__16>.NativeClassPtr, 100666091);
				WormArchetypes._AllArchetypes_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypes._AllArchetypes_d__16>.NativeClassPtr, 100666092);
				WormArchetypes._AllArchetypes_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_canis_archetypes_Archetype__get_Current_Private_Virtual_Final_New_get_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypes._AllArchetypes_d__16>.NativeClassPtr, 100666093);
				WormArchetypes._AllArchetypes_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypes._AllArchetypes_d__16>.NativeClassPtr, 100666094);
				WormArchetypes._AllArchetypes_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypes._AllArchetypes_d__16>.NativeClassPtr, 100666095);
				WormArchetypes._AllArchetypes_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_canis_archetypes_Archetype__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypes._AllArchetypes_d__16>.NativeClassPtr, 100666096);
				WormArchetypes._AllArchetypes_d__16.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypes._AllArchetypes_d__16>.NativeClassPtr, 100666097);
			}

			// Token: 0x0600503C RID: 20540 RVA: 0x001A98A8 File Offset: 0x001A7AA8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AllArchetypes_d__16(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormArchetypes._AllArchetypes_d__16>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypes._AllArchetypes_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600503D RID: 20541 RVA: 0x001A98F0 File Offset: 0x001A7AF0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypes._AllArchetypes_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600503E RID: 20542 RVA: 0x001A9924 File Offset: 0x001A7B24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78043, XrefRangeEnd = 78071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypes._AllArchetypes_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170013C5 RID: 5061
			// (get) Token: 0x0600503F RID: 20543 RVA: 0x001A9960 File Offset: 0x001A7B60
			public unsafe Archetype System.Collections.Generic.IEnumerator<canis.archetypes.Archetype>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypes._AllArchetypes_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_canis_archetypes_Archetype__get_Current_Private_Virtual_Final_New_get_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Archetype>(intPtr3) : null;
				}
			}

			// Token: 0x06005040 RID: 20544 RVA: 0x001A99A0 File Offset: 0x001A7BA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78071, XrefRangeEnd = 78076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypes._AllArchetypes_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170013C6 RID: 5062
			// (get) Token: 0x06005041 RID: 20545 RVA: 0x001A99D4 File Offset: 0x001A7BD4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypes._AllArchetypes_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005042 RID: 20546 RVA: 0x001A9A14 File Offset: 0x001A7C14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78076, XrefRangeEnd = 78078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Archetype> System_Collections_Generic_IEnumerable_canis_archetypes_Archetype__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypes._AllArchetypes_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_canis_archetypes_Archetype__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Archetype>>(intPtr3) : null;
			}

			// Token: 0x06005043 RID: 20547 RVA: 0x001A9A54 File Offset: 0x001A7C54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypes._AllArchetypes_d__16.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005044 RID: 20548 RVA: 0x0001BC1B File Offset: 0x00019E1B
			public _AllArchetypes_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170013BE RID: 5054
			// (get) Token: 0x06005045 RID: 20549 RVA: 0x001A9A94 File Offset: 0x001A7C94
			// (set) Token: 0x06005046 RID: 20550 RVA: 0x0001BC24 File Offset: 0x00019E24
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypes._AllArchetypes_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypes._AllArchetypes_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170013BF RID: 5055
			// (get) Token: 0x06005047 RID: 20551 RVA: 0x001A9ABC File Offset: 0x001A7CBC
			// (set) Token: 0x06005048 RID: 20552 RVA: 0x0001BC3F File Offset: 0x00019E3F
			public unsafe Archetype __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypes._AllArchetypes_d__16.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Archetype>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypes._AllArchetypes_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013C0 RID: 5056
			// (get) Token: 0x06005049 RID: 20553 RVA: 0x001A9AEC File Offset: 0x001A7CEC
			// (set) Token: 0x0600504A RID: 20554 RVA: 0x0001BC5E File Offset: 0x00019E5E
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypes._AllArchetypes_d__16.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypes._AllArchetypes_d__16.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170013C1 RID: 5057
			// (get) Token: 0x0600504B RID: 20555 RVA: 0x001A9B14 File Offset: 0x001A7D14
			// (set) Token: 0x0600504C RID: 20556 RVA: 0x0001BC79 File Offset: 0x00019E79
			public unsafe WormArchetypes __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypes._AllArchetypes_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormArchetypes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypes._AllArchetypes_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013C2 RID: 5058
			// (get) Token: 0x0600504D RID: 20557 RVA: 0x001A9B44 File Offset: 0x001A7D44
			// (set) Token: 0x0600504E RID: 20558 RVA: 0x0001BC98 File Offset: 0x00019E98
			public unsafe HashSet<ArchetypeID> _sanityCheck_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypes._AllArchetypes_d__16.NativeFieldInfoPtr__sanityCheck_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypes._AllArchetypes_d__16.NativeFieldInfoPtr__sanityCheck_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013C3 RID: 5059
			// (get) Token: 0x0600504F RID: 20559 RVA: 0x001A9B74 File Offset: 0x001A7D74
			// (set) Token: 0x06005050 RID: 20560 RVA: 0x0001BCB7 File Offset: 0x00019EB7
			public unsafe Il2CppReferenceArray<WormArchetype> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypes._AllArchetypes_d__16.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WormArchetype>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypes._AllArchetypes_d__16.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013C4 RID: 5060
			// (get) Token: 0x06005051 RID: 20561 RVA: 0x001A9BA4 File Offset: 0x001A7DA4
			// (set) Token: 0x06005052 RID: 20562 RVA: 0x0001BCD6 File Offset: 0x00019ED6
			public unsafe int __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypes._AllArchetypes_d__16.NativeFieldInfoPtr___7__wrap3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypes._AllArchetypes_d__16.NativeFieldInfoPtr___7__wrap3)) = value;
				}
			}

			// Token: 0x040034A4 RID: 13476
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040034A5 RID: 13477
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040034A6 RID: 13478
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040034A7 RID: 13479
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040034A8 RID: 13480
			private static readonly IntPtr NativeFieldInfoPtr__sanityCheck_5__2;

			// Token: 0x040034A9 RID: 13481
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x040034AA RID: 13482
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x040034AB RID: 13483
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040034AC RID: 13484
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040034AD RID: 13485
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040034AE RID: 13486
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_canis_archetypes_Archetype__get_Current_Private_Virtual_Final_New_get_Archetype_0;

			// Token: 0x040034AF RID: 13487
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040034B0 RID: 13488
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040034B1 RID: 13489
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_canis_archetypes_Archetype__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Archetype_0;

			// Token: 0x040034B2 RID: 13490
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
