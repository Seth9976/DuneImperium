using System;
using Canis.attributes;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.entities
{
	// Token: 0x020000DC RID: 220
	public class SerializedEntitySnapshot : EntitySnapshot
	{
		// Token: 0x06000A26 RID: 2598 RVA: 0x000447B8 File Offset: 0x000429B8
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedEntitySnapshot()
		{
			Il2CppClassPointerStore<SerializedEntitySnapshot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "SerializedEntitySnapshot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedEntitySnapshot>.NativeClassPtr);
			SerializedEntitySnapshot.NativeFieldInfoPtr_sourceEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedEntitySnapshot>.NativeClassPtr, "sourceEntity");
			SerializedEntitySnapshot.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedEntitySnapshot>.NativeClassPtr, 100665442);
			SerializedEntitySnapshot.NativeMethodInfoPtr_get_EntityID_Public_Virtual_get_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedEntitySnapshot>.NativeClassPtr, 100665443);
			SerializedEntitySnapshot.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedEntitySnapshot>.NativeClassPtr, 100665444);
			SerializedEntitySnapshot.NativeMethodInfoPtr_get_Parent_Public_Virtual_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedEntitySnapshot>.NativeClassPtr, 100665445);
			SerializedEntitySnapshot.NativeMethodInfoPtr_get_OwningPlayer_Public_Virtual_get_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedEntitySnapshot>.NativeClassPtr, 100665446);
			SerializedEntitySnapshot.NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedEntitySnapshot>.NativeClassPtr, 100665447);
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00044874 File Offset: 0x00042A74
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 558839, RefRangeEnd = 558843, XrefRangeStart = 558839, XrefRangeEnd = 558843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedEntitySnapshot(SerializedEntity source, Match match)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedEntitySnapshot>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedEntitySnapshot.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x000448D4 File Offset: 0x00042AD4
		public unsafe override EntityID EntityID
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 373350, RefRangeEnd = 373371, XrefRangeStart = 373350, XrefRangeEnd = 373371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedEntitySnapshot.NativeMethodInfoPtr_get_EntityID_Public_Virtual_get_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x00044920 File Offset: 0x00042B20
		public unsafe override string Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 565625, RefRangeEnd = 565626, XrefRangeStart = 565625, XrefRangeEnd = 565626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedEntitySnapshot.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x00044964 File Offset: 0x00042B64
		public unsafe override Entity Parent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565628, XrefRangeEnd = 565629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedEntitySnapshot.NativeMethodInfoPtr_get_Parent_Public_Virtual_get_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x000449B0 File Offset: 0x00042BB0
		public unsafe override PlayerEntity OwningPlayer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedEntitySnapshot.NativeMethodInfoPtr_get_OwningPlayer_Public_Virtual_get_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x000449FC File Offset: 0x00042BFC
		public unsafe override ReadOnlyAttributes Attributes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565629, XrefRangeEnd = 565633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedEntitySnapshot.NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_ReadOnlyAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00005C67 File Offset: 0x00003E67
		public SerializedEntitySnapshot(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x00044A48 File Offset: 0x00042C48
		// (set) Token: 0x06000A2F RID: 2607 RVA: 0x00005C70 File Offset: 0x00003E70
		public unsafe SerializedEntity sourceEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEntitySnapshot.NativeFieldInfoPtr_sourceEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEntitySnapshot.NativeFieldInfoPtr_sourceEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006EE RID: 1774
		private static readonly IntPtr NativeFieldInfoPtr_sourceEntity;

		// Token: 0x040006EF RID: 1775
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_0;

		// Token: 0x040006F0 RID: 1776
		private static readonly IntPtr NativeMethodInfoPtr_get_EntityID_Public_Virtual_get_EntityID_0;

		// Token: 0x040006F1 RID: 1777
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x040006F2 RID: 1778
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_Virtual_get_Entity_0;

		// Token: 0x040006F3 RID: 1779
		private static readonly IntPtr NativeMethodInfoPtr_get_OwningPlayer_Public_Virtual_get_PlayerEntity_0;

		// Token: 0x040006F4 RID: 1780
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_ReadOnlyAttributes_0;
	}
}
