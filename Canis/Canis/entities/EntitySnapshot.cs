using System;
using Canis.attributes;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.entities
{
	// Token: 0x020000DA RID: 218
	public class EntitySnapshot : Object
	{
		// Token: 0x06000A12 RID: 2578 RVA: 0x0004425C File Offset: 0x0004245C
		// Note: this type is marked as 'beforefieldinit'.
		static EntitySnapshot()
		{
			Il2CppClassPointerStore<EntitySnapshot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "EntitySnapshot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntitySnapshot>.NativeClassPtr);
			EntitySnapshot.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitySnapshot>.NativeClassPtr, "match");
			EntitySnapshot.NativeMethodInfoPtr_get_EntityID_Public_Abstract_Virtual_New_get_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitySnapshot>.NativeClassPtr, 100665430);
			EntitySnapshot.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitySnapshot>.NativeClassPtr, 100665431);
			EntitySnapshot.NativeMethodInfoPtr_get_Parent_Public_Abstract_Virtual_New_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitySnapshot>.NativeClassPtr, 100665432);
			EntitySnapshot.NativeMethodInfoPtr_get_OwningPlayer_Public_Abstract_Virtual_New_get_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitySnapshot>.NativeClassPtr, 100665433);
			EntitySnapshot.NativeMethodInfoPtr_get_Attributes_Public_Abstract_Virtual_New_get_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitySnapshot>.NativeClassPtr, 100665434);
			EntitySnapshot.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitySnapshot>.NativeClassPtr, 100665435);
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x00044318 File Offset: 0x00042518
		public unsafe virtual EntityID EntityID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntitySnapshot.NativeMethodInfoPtr_get_EntityID_Public_Abstract_Virtual_New_get_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x00044364 File Offset: 0x00042564
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntitySnapshot.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x000443A8 File Offset: 0x000425A8
		public unsafe virtual Entity Parent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntitySnapshot.NativeMethodInfoPtr_get_Parent_Public_Abstract_Virtual_New_get_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x000443F4 File Offset: 0x000425F4
		public unsafe virtual PlayerEntity OwningPlayer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntitySnapshot.NativeMethodInfoPtr_get_OwningPlayer_Public_Abstract_Virtual_New_get_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x00044440 File Offset: 0x00042640
		public unsafe virtual ReadOnlyAttributes Attributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntitySnapshot.NativeMethodInfoPtr_get_Attributes_Public_Abstract_Virtual_New_get_ReadOnlyAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x0004448C File Offset: 0x0004268C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntitySnapshot()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntitySnapshot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitySnapshot.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00005C17 File Offset: 0x00003E17
		public EntitySnapshot(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x000444C8 File Offset: 0x000426C8
		// (set) Token: 0x06000A1B RID: 2587 RVA: 0x00005C20 File Offset: 0x00003E20
		public unsafe Match match
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitySnapshot.NativeFieldInfoPtr_match);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitySnapshot.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeFieldInfoPtr_match;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeMethodInfoPtr_get_EntityID_Public_Abstract_Virtual_New_get_EntityID_0;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_Abstract_Virtual_New_get_Entity_0;

		// Token: 0x040006E4 RID: 1764
		private static readonly IntPtr NativeMethodInfoPtr_get_OwningPlayer_Public_Abstract_Virtual_New_get_PlayerEntity_0;

		// Token: 0x040006E5 RID: 1765
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Abstract_Virtual_New_get_ReadOnlyAttributes_0;

		// Token: 0x040006E6 RID: 1766
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
