using System;
using canis.archetypes;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.data.providers;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace lib.canis.boardgames.src.match
{
	// Token: 0x0200003B RID: 59
	public class ArchetypeProvider : DataProvider
	{
		// Token: 0x06000269 RID: 617 RVA: 0x00018B50 File Offset: 0x00016D50
		// Note: this type is marked as 'beforefieldinit'.
		static ArchetypeProvider()
		{
			Il2CppClassPointerStore<ArchetypeProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lib.canis.boardgames.src.match", "ArchetypeProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchetypeProvider>.NativeClassPtr);
			ArchetypeProvider.NativeFieldInfoPtr_entityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeProvider>.NativeClassPtr, "entityMap");
			ArchetypeProvider.NativeMethodInfoPtr_get_Item_Public_get_EntityComponent_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeProvider>.NativeClassPtr, 100663736);
			ArchetypeProvider.NativeMethodInfoPtr_get_AllArchetypes_Public_get_IEnumerable_1_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeProvider>.NativeClassPtr, 100663737);
			ArchetypeProvider.NativeMethodInfoPtr_TryGetValue_Public_Boolean_ArchetypeID_byref_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeProvider>.NativeClassPtr, 100663738);
			ArchetypeProvider.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeProvider>.NativeClassPtr, 100663739);
			ArchetypeProvider.NativeMethodInfoPtr_getArchetypes_Protected_Abstract_Virtual_New_IEnumerable_1_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeProvider>.NativeClassPtr, 100663740);
			ArchetypeProvider.NativeMethodInfoPtr_ingestArchetypes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeProvider>.NativeClassPtr, 100663741);
			ArchetypeProvider.NativeMethodInfoPtr_CreateEntity_Private_EntityComponent_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeProvider>.NativeClassPtr, 100663742);
			ArchetypeProvider.NativeMethodInfoPtr_Introduce_Private_Void_EntityComponent_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeProvider>.NativeClassPtr, 100663743);
			ArchetypeProvider.NativeMethodInfoPtr_introduce_Protected_Abstract_Virtual_New_Void_EntityComponent_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeProvider>.NativeClassPtr, 100663744);
			ArchetypeProvider.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeProvider>.NativeClassPtr, 100663745);
		}

		// Token: 0x17000095 RID: 149
		public unsafe EntityComponent this[ArchetypeID id]
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 984839, RefRangeEnd = 984851, XrefRangeStart = 984835, XrefRangeEnd = 984839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeProvider.NativeMethodInfoPtr_get_Item_Public_get_EntityComponent_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
				}
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00018CAC File Offset: 0x00016EAC
		public unsafe IEnumerable<Archetype> AllArchetypes
		{
			[CallerCount(41)]
			[CachedScanResults(RefRangeStart = 285957, RefRangeEnd = 285998, XrefRangeStart = 285957, XrefRangeEnd = 285998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeProvider.NativeMethodInfoPtr_get_AllArchetypes_Public_get_IEnumerable_1_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Archetype>>(intPtr3) : null;
			}
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00018CEC File Offset: 0x00016EEC
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 984855, RefRangeEnd = 984886, XrefRangeStart = 984851, XrefRangeEnd = 984855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValue(ArchetypeID id, out EntityComponent value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArchetypeProvider.NativeMethodInfoPtr_TryGetValue_Public_Boolean_ArchetypeID_byref_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new EntityComponent(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00018D5C File Offset: 0x00016F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984886, XrefRangeEnd = 984887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeProvider.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00018D98 File Offset: 0x00016F98
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Archetype> getArchetypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeProvider.NativeMethodInfoPtr_getArchetypes_Protected_Abstract_Virtual_New_IEnumerable_1_Archetype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Archetype>>(intPtr3) : null;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00018DE4 File Offset: 0x00016FE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 984916, RefRangeEnd = 984917, XrefRangeStart = 984887, XrefRangeEnd = 984916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ingestArchetypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeProvider.NativeMethodInfoPtr_ingestArchetypes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00018E18 File Offset: 0x00017018
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 984954, RefRangeEnd = 984955, XrefRangeStart = 984917, XrefRangeEnd = 984954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityComponent CreateEntity(Archetype archetype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archetype);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeProvider.NativeMethodInfoPtr_CreateEntity_Private_EntityComponent_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
			}
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00018E68 File Offset: 0x00017068
		[CallerCount(0)]
		public unsafe void Introduce(EntityComponent entity, ReadOnlyAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeProvider.NativeMethodInfoPtr_Introduce_Private_Void_EntityComponent_ReadOnlyAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00018EBC File Offset: 0x000170BC
		[CallerCount(0)]
		public unsafe virtual void introduce(EntityComponent entity, ReadOnlyAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeProvider.NativeMethodInfoPtr_introduce_Protected_Abstract_Virtual_New_Void_EntityComponent_ReadOnlyAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00018F1C File Offset: 0x0001711C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 875404, RefRangeEnd = 875407, XrefRangeStart = 875404, XrefRangeEnd = 875407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArchetypeProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchetypeProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeProvider.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00003091 File Offset: 0x00001291
		public ArchetypeProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00018F58 File Offset: 0x00017158
		// (set) Token: 0x06000276 RID: 630 RVA: 0x0000309A File Offset: 0x0000129A
		public unsafe Dictionary<ArchetypeID, EntityComponent> entityMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeProvider.NativeFieldInfoPtr_entityMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ArchetypeID, EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeProvider.NativeFieldInfoPtr_entityMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeFieldInfoPtr_entityMap;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_EntityComponent_ArchetypeID_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr_get_AllArchetypes_Public_get_IEnumerable_1_Archetype_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Boolean_ArchetypeID_byref_EntityComponent_0;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr_getArchetypes_Protected_Abstract_Virtual_New_IEnumerable_1_Archetype_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_ingestArchetypes_Private_Void_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntity_Private_EntityComponent_Archetype_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_Introduce_Private_Void_EntityComponent_ReadOnlyAttributes_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_introduce_Protected_Abstract_Virtual_New_Void_EntityComponent_ReadOnlyAttributes_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
