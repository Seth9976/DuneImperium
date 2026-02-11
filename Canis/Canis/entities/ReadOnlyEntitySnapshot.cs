using System;
using Canis.attributes;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.entities
{
	// Token: 0x020000DB RID: 219
	public class ReadOnlyEntitySnapshot : EntitySnapshot
	{
		// Token: 0x06000A1C RID: 2588 RVA: 0x000444F8 File Offset: 0x000426F8
		// Note: this type is marked as 'beforefieldinit'.
		static ReadOnlyEntitySnapshot()
		{
			Il2CppClassPointerStore<ReadOnlyEntitySnapshot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "ReadOnlyEntitySnapshot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOnlyEntitySnapshot>.NativeClassPtr);
			ReadOnlyEntitySnapshot.NativeFieldInfoPtr_sourceEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyEntitySnapshot>.NativeClassPtr, "sourceEntity");
			ReadOnlyEntitySnapshot.NativeMethodInfoPtr__ctor_Public_Void_Entity_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyEntitySnapshot>.NativeClassPtr, 100665436);
			ReadOnlyEntitySnapshot.NativeMethodInfoPtr_get_EntityID_Public_Virtual_get_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyEntitySnapshot>.NativeClassPtr, 100665437);
			ReadOnlyEntitySnapshot.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyEntitySnapshot>.NativeClassPtr, 100665438);
			ReadOnlyEntitySnapshot.NativeMethodInfoPtr_get_Parent_Public_Virtual_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyEntitySnapshot>.NativeClassPtr, 100665439);
			ReadOnlyEntitySnapshot.NativeMethodInfoPtr_get_OwningPlayer_Public_Virtual_get_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyEntitySnapshot>.NativeClassPtr, 100665440);
			ReadOnlyEntitySnapshot.NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyEntitySnapshot>.NativeClassPtr, 100665441);
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x000445B4 File Offset: 0x000427B4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 558839, RefRangeEnd = 558843, XrefRangeStart = 558839, XrefRangeEnd = 558843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyEntitySnapshot(Entity source, Match match)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyEntitySnapshot>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyEntitySnapshot.NativeMethodInfoPtr__ctor_Public_Void_Entity_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x00044614 File Offset: 0x00042814
		public unsafe override EntityID EntityID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReadOnlyEntitySnapshot.NativeMethodInfoPtr_get_EntityID_Public_Virtual_get_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x00044660 File Offset: 0x00042860
		public unsafe override string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReadOnlyEntitySnapshot.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x000446A4 File Offset: 0x000428A4
		public unsafe override Entity Parent
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 565624, RefRangeEnd = 565625, XrefRangeStart = 565624, XrefRangeEnd = 565624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReadOnlyEntitySnapshot.NativeMethodInfoPtr_get_Parent_Public_Virtual_get_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x000446F0 File Offset: 0x000428F0
		public unsafe override PlayerEntity OwningPlayer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 565625, RefRangeEnd = 565626, XrefRangeStart = 565625, XrefRangeEnd = 565625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReadOnlyEntitySnapshot.NativeMethodInfoPtr_get_OwningPlayer_Public_Virtual_get_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x0004473C File Offset: 0x0004293C
		public unsafe override ReadOnlyAttributes Attributes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565626, XrefRangeEnd = 565628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReadOnlyEntitySnapshot.NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_ReadOnlyAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x00005C3F File Offset: 0x00003E3F
		public ReadOnlyEntitySnapshot(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x00044788 File Offset: 0x00042988
		// (set) Token: 0x06000A25 RID: 2597 RVA: 0x00005C48 File Offset: 0x00003E48
		public unsafe Entity sourceEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyEntitySnapshot.NativeFieldInfoPtr_sourceEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyEntitySnapshot.NativeFieldInfoPtr_sourceEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006E7 RID: 1767
		private static readonly IntPtr NativeFieldInfoPtr_sourceEntity;

		// Token: 0x040006E8 RID: 1768
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_Match_0;

		// Token: 0x040006E9 RID: 1769
		private static readonly IntPtr NativeMethodInfoPtr_get_EntityID_Public_Virtual_get_EntityID_0;

		// Token: 0x040006EA RID: 1770
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x040006EB RID: 1771
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_Virtual_get_Entity_0;

		// Token: 0x040006EC RID: 1772
		private static readonly IntPtr NativeMethodInfoPtr_get_OwningPlayer_Public_Virtual_get_PlayerEntity_0;

		// Token: 0x040006ED RID: 1773
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_ReadOnlyAttributes_0;
	}
}
