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

namespace dwd.canis.archetypes
{
	// Token: 0x0200004F RID: 79
	public class DefaultArchetypes : Archetypes
	{
		// Token: 0x06000301 RID: 769 RVA: 0x00026FE4 File Offset: 0x000251E4
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultArchetypes()
		{
			Il2CppClassPointerStore<DefaultArchetypes>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.archetypes", "DefaultArchetypes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultArchetypes>.NativeClassPtr);
			DefaultArchetypes.NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultArchetypes>.NativeClassPtr, "_instance");
			DefaultArchetypes.NativeFieldInfoPtr_Lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultArchetypes>.NativeClassPtr, "Lock");
			DefaultArchetypes.NativeFieldInfoPtr_archs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultArchetypes>.NativeClassPtr, "archs");
			DefaultArchetypes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultArchetypes>.NativeClassPtr, 100663776);
			DefaultArchetypes.NativeMethodInfoPtr_get_Instance_Public_Static_get_DefaultArchetypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultArchetypes>.NativeClassPtr, 100663777);
			DefaultArchetypes.NativeMethodInfoPtr_BaseConfigure_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultArchetypes>.NativeClassPtr, 100663778);
			DefaultArchetypes.NativeMethodInfoPtr_Configure_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultArchetypes>.NativeClassPtr, 100663779);
			DefaultArchetypes.NativeMethodInfoPtr_AllArchetypes_Public_Virtual_IEnumerable_1_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultArchetypes>.NativeClassPtr, 100663780);
			DefaultArchetypes.NativeMethodInfoPtr_CreateEntity_Public_Virtual_Entity_ArchetypeID_Match_PlayerEntity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultArchetypes>.NativeClassPtr, 100663781);
			DefaultArchetypes.NativeMethodInfoPtr_CreateEntity_Public_Virtual_Entity_Archetype_Match_PlayerEntity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultArchetypes>.NativeClassPtr, 100663782);
			DefaultArchetypes.NativeMethodInfoPtr_CreateEntities_Public_Virtual_Void_ArchetypeID_Match_PlayerEntity_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultArchetypes>.NativeClassPtr, 100663783);
			DefaultArchetypes.NativeMethodInfoPtr_DeserializeEntity_Public_Virtual_Entity_ArchetypeID_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultArchetypes>.NativeClassPtr, 100663784);
			DefaultArchetypes.NativeMethodInfoPtr_CreateEntities_Public_Virtual_Void_Archetype_Match_PlayerEntity_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultArchetypes>.NativeClassPtr, 100663785);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00027118 File Offset: 0x00025318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499374, XrefRangeEnd = 499379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultArchetypes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultArchetypes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultArchetypes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000303 RID: 771 RVA: 0x00027154 File Offset: 0x00025354
		public unsafe static DefaultArchetypes Instance
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 499406, RefRangeEnd = 499407, XrefRangeStart = 499379, XrefRangeEnd = 499406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultArchetypes.NativeMethodInfoPtr_get_Instance_Public_Static_get_DefaultArchetypes_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DefaultArchetypes>(intPtr3) : null;
			}
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00027188 File Offset: 0x00025388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BaseConfigure()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultArchetypes.NativeMethodInfoPtr_BaseConfigure_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000305 RID: 773 RVA: 0x000271BC File Offset: 0x000253BC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Configure()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultArchetypes.NativeMethodInfoPtr_Configure_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x000271F8 File Offset: 0x000253F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499407, XrefRangeEnd = 499413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Archetype> AllArchetypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultArchetypes.NativeMethodInfoPtr_AllArchetypes_Public_Virtual_IEnumerable_1_Archetype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Archetype>>(intPtr3) : null;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00027244 File Offset: 0x00025444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499413, XrefRangeEnd = 499414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultArchetypes.NativeMethodInfoPtr_CreateEntity_Public_Virtual_Entity_ArchetypeID_Match_PlayerEntity_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x000272D8 File Offset: 0x000254D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultArchetypes.NativeMethodInfoPtr_CreateEntity_Public_Virtual_Entity_Archetype_Match_PlayerEntity_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0002736C File Offset: 0x0002556C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499414, XrefRangeEnd = 499415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultArchetypes.NativeMethodInfoPtr_CreateEntities_Public_Virtual_Void_ArchetypeID_Match_PlayerEntity_Entity_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00027400 File Offset: 0x00025600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499415, XrefRangeEnd = 499419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultArchetypes.NativeMethodInfoPtr_DeserializeEntity_Public_Virtual_Entity_ArchetypeID_SerializedEntity_Match_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00027494 File Offset: 0x00025694
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultArchetypes.NativeMethodInfoPtr_CreateEntities_Public_Virtual_Void_Archetype_Match_PlayerEntity_Entity_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00003550 File Offset: 0x00001750
		public DefaultArchetypes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600030D RID: 781 RVA: 0x00027528 File Offset: 0x00025728
		// (set) Token: 0x0600030E RID: 782 RVA: 0x00003559 File Offset: 0x00001759
		public unsafe static DefaultArchetypes _instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DefaultArchetypes.NativeFieldInfoPtr__instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultArchetypes>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultArchetypes.NativeFieldInfoPtr__instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600030F RID: 783 RVA: 0x00027550 File Offset: 0x00025750
		// (set) Token: 0x06000310 RID: 784 RVA: 0x0000356B File Offset: 0x0000176B
		public unsafe static Object Lock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DefaultArchetypes.NativeFieldInfoPtr_Lock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultArchetypes.NativeFieldInfoPtr_Lock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000311 RID: 785 RVA: 0x00027578 File Offset: 0x00025778
		// (set) Token: 0x06000312 RID: 786 RVA: 0x0000357D File Offset: 0x0000177D
		public unsafe static Il2CppReferenceArray<Archetype> archs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DefaultArchetypes.NativeFieldInfoPtr_archs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Archetype>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultArchetypes.NativeFieldInfoPtr_archs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeFieldInfoPtr__instance;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeFieldInfoPtr_Lock;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeFieldInfoPtr_archs;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_DefaultArchetypes_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_BaseConfigure_Private_Void_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Virtual_Void_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_AllArchetypes_Public_Virtual_IEnumerable_1_Archetype_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntity_Public_Virtual_Entity_ArchetypeID_Match_PlayerEntity_Entity_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntity_Public_Virtual_Entity_Archetype_Match_PlayerEntity_Entity_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntities_Public_Virtual_Void_ArchetypeID_Match_PlayerEntity_Entity_Int32_0;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeEntity_Public_Virtual_Entity_ArchetypeID_SerializedEntity_Match_Entity_0;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntities_Public_Virtual_Void_Archetype_Match_PlayerEntity_Entity_Int32_0;

		// Token: 0x020002E8 RID: 744
		[ObfuscatedName("dwd.canis.archetypes.DefaultArchetypes+<AllArchetypes>d__8")]
		public sealed class _AllArchetypes_d__8 : Object
		{
			// Token: 0x06002311 RID: 8977 RVA: 0x0009161C File Offset: 0x0008F81C
			// Note: this type is marked as 'beforefieldinit'.
			static _AllArchetypes_d__8()
			{
				Il2CppClassPointerStore<DefaultArchetypes._AllArchetypes_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultArchetypes>.NativeClassPtr, "<AllArchetypes>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultArchetypes._AllArchetypes_d__8>.NativeClassPtr);
				DefaultArchetypes._AllArchetypes_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultArchetypes._AllArchetypes_d__8>.NativeClassPtr, "<>1__state");
				DefaultArchetypes._AllArchetypes_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultArchetypes._AllArchetypes_d__8>.NativeClassPtr, "<>2__current");
				DefaultArchetypes._AllArchetypes_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultArchetypes._AllArchetypes_d__8>.NativeClassPtr, "<>l__initialThreadId");
				DefaultArchetypes._AllArchetypes_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultArchetypes._AllArchetypes_d__8>.NativeClassPtr, "<>4__this");
				DefaultArchetypes._AllArchetypes_d__8.NativeFieldInfoPtr__sanityCheck_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultArchetypes._AllArchetypes_d__8>.NativeClassPtr, "<sanityCheck>5__2");
				DefaultArchetypes._AllArchetypes_d__8.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultArchetypes._AllArchetypes_d__8>.NativeClassPtr, "<>7__wrap2");
				DefaultArchetypes._AllArchetypes_d__8.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultArchetypes._AllArchetypes_d__8>.NativeClassPtr, "<>7__wrap3");
				DefaultArchetypes._AllArchetypes_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultArchetypes._AllArchetypes_d__8>.NativeClassPtr, 100663787);
				DefaultArchetypes._AllArchetypes_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultArchetypes._AllArchetypes_d__8>.NativeClassPtr, 100663788);
				DefaultArchetypes._AllArchetypes_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultArchetypes._AllArchetypes_d__8>.NativeClassPtr, 100663789);
				DefaultArchetypes._AllArchetypes_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_canis_archetypes_Archetype__get_Current_Private_Virtual_Final_New_get_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultArchetypes._AllArchetypes_d__8>.NativeClassPtr, 100663790);
				DefaultArchetypes._AllArchetypes_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultArchetypes._AllArchetypes_d__8>.NativeClassPtr, 100663791);
				DefaultArchetypes._AllArchetypes_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultArchetypes._AllArchetypes_d__8>.NativeClassPtr, 100663792);
				DefaultArchetypes._AllArchetypes_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_canis_archetypes_Archetype__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultArchetypes._AllArchetypes_d__8>.NativeClassPtr, 100663793);
				DefaultArchetypes._AllArchetypes_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultArchetypes._AllArchetypes_d__8>.NativeClassPtr, 100663794);
			}

			// Token: 0x06002312 RID: 8978 RVA: 0x00091774 File Offset: 0x0008F974
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AllArchetypes_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultArchetypes._AllArchetypes_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultArchetypes._AllArchetypes_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002313 RID: 8979 RVA: 0x000917BC File Offset: 0x0008F9BC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultArchetypes._AllArchetypes_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002314 RID: 8980 RVA: 0x000917F0 File Offset: 0x0008F9F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499346, XrefRangeEnd = 499367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultArchetypes._AllArchetypes_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000983 RID: 2435
			// (get) Token: 0x06002315 RID: 8981 RVA: 0x0009182C File Offset: 0x0008FA2C
			public unsafe Archetype System.Collections.Generic.IEnumerator<canis.archetypes.Archetype>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultArchetypes._AllArchetypes_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_canis_archetypes_Archetype__get_Current_Private_Virtual_Final_New_get_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Archetype>(intPtr3) : null;
				}
			}

			// Token: 0x06002316 RID: 8982 RVA: 0x0009186C File Offset: 0x0008FA6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499367, XrefRangeEnd = 499372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultArchetypes._AllArchetypes_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000984 RID: 2436
			// (get) Token: 0x06002317 RID: 8983 RVA: 0x000918A0 File Offset: 0x0008FAA0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultArchetypes._AllArchetypes_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002318 RID: 8984 RVA: 0x000918E0 File Offset: 0x0008FAE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499372, XrefRangeEnd = 499374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Archetype> System_Collections_Generic_IEnumerable_canis_archetypes_Archetype__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultArchetypes._AllArchetypes_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_canis_archetypes_Archetype__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Archetype>>(intPtr3) : null;
			}

			// Token: 0x06002319 RID: 8985 RVA: 0x00091920 File Offset: 0x0008FB20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultArchetypes._AllArchetypes_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600231A RID: 8986 RVA: 0x00012445 File Offset: 0x00010645
			public _AllArchetypes_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700097C RID: 2428
			// (get) Token: 0x0600231B RID: 8987 RVA: 0x00091960 File Offset: 0x0008FB60
			// (set) Token: 0x0600231C RID: 8988 RVA: 0x0001244E File Offset: 0x0001064E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultArchetypes._AllArchetypes_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultArchetypes._AllArchetypes_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700097D RID: 2429
			// (get) Token: 0x0600231D RID: 8989 RVA: 0x00091988 File Offset: 0x0008FB88
			// (set) Token: 0x0600231E RID: 8990 RVA: 0x00012469 File Offset: 0x00010669
			public unsafe Archetype __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultArchetypes._AllArchetypes_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Archetype>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultArchetypes._AllArchetypes_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700097E RID: 2430
			// (get) Token: 0x0600231F RID: 8991 RVA: 0x000919B8 File Offset: 0x0008FBB8
			// (set) Token: 0x06002320 RID: 8992 RVA: 0x00012488 File Offset: 0x00010688
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultArchetypes._AllArchetypes_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultArchetypes._AllArchetypes_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700097F RID: 2431
			// (get) Token: 0x06002321 RID: 8993 RVA: 0x000919E0 File Offset: 0x0008FBE0
			// (set) Token: 0x06002322 RID: 8994 RVA: 0x000124A3 File Offset: 0x000106A3
			public unsafe DefaultArchetypes __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultArchetypes._AllArchetypes_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultArchetypes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultArchetypes._AllArchetypes_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000980 RID: 2432
			// (get) Token: 0x06002323 RID: 8995 RVA: 0x00091A10 File Offset: 0x0008FC10
			// (set) Token: 0x06002324 RID: 8996 RVA: 0x000124C2 File Offset: 0x000106C2
			public unsafe HashSet<ArchetypeID> _sanityCheck_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultArchetypes._AllArchetypes_d__8.NativeFieldInfoPtr__sanityCheck_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultArchetypes._AllArchetypes_d__8.NativeFieldInfoPtr__sanityCheck_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000981 RID: 2433
			// (get) Token: 0x06002325 RID: 8997 RVA: 0x00091A40 File Offset: 0x0008FC40
			// (set) Token: 0x06002326 RID: 8998 RVA: 0x000124E1 File Offset: 0x000106E1
			public unsafe Il2CppReferenceArray<Archetype> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultArchetypes._AllArchetypes_d__8.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Archetype>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultArchetypes._AllArchetypes_d__8.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000982 RID: 2434
			// (get) Token: 0x06002327 RID: 8999 RVA: 0x00091A70 File Offset: 0x0008FC70
			// (set) Token: 0x06002328 RID: 9000 RVA: 0x00012500 File Offset: 0x00010700
			public unsafe int __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultArchetypes._AllArchetypes_d__8.NativeFieldInfoPtr___7__wrap3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultArchetypes._AllArchetypes_d__8.NativeFieldInfoPtr___7__wrap3)) = value;
				}
			}

			// Token: 0x0400160B RID: 5643
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400160C RID: 5644
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400160D RID: 5645
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400160E RID: 5646
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400160F RID: 5647
			private static readonly IntPtr NativeFieldInfoPtr__sanityCheck_5__2;

			// Token: 0x04001610 RID: 5648
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04001611 RID: 5649
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04001612 RID: 5650
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001613 RID: 5651
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001614 RID: 5652
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001615 RID: 5653
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_canis_archetypes_Archetype__get_Current_Private_Virtual_Final_New_get_Archetype_0;

			// Token: 0x04001616 RID: 5654
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001617 RID: 5655
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001618 RID: 5656
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_canis_archetypes_Archetype__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Archetype_0;

			// Token: 0x04001619 RID: 5657
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
