using System;
using Canis.attributes;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.archetypes
{
	// Token: 0x02000215 RID: 533
	[Serializable]
	public class SerializableArchetypeComponent : Object
	{
		// Token: 0x06001D39 RID: 7481 RVA: 0x000876FC File Offset: 0x000858FC
		// Note: this type is marked as 'beforefieldinit'.
		static SerializableArchetypeComponent()
		{
			Il2CppClassPointerStore<SerializableArchetypeComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.archetypes", "SerializableArchetypeComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableArchetypeComponent>.NativeClassPtr);
			SerializableArchetypeComponent.NativeFieldInfoPtr_ArchetypeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableArchetypeComponent>.NativeClassPtr, "ArchetypeID");
			SerializableArchetypeComponent.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableArchetypeComponent>.NativeClassPtr, "attributes");
			SerializableArchetypeComponent.NativeMethodInfoPtr_ToArchetypeComponent_Public_ArchetypeComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableArchetypeComponent>.NativeClassPtr, 100668001);
			SerializableArchetypeComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableArchetypeComponent>.NativeClassPtr, 100668002);
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x0008777C File Offset: 0x0008597C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886218, XrefRangeEnd = 886224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArchetypeComponent ToArchetypeComponent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableArchetypeComponent.NativeMethodInfoPtr_ToArchetypeComponent_Public_ArchetypeComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeComponent>(intPtr3) : null;
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x000877BC File Offset: 0x000859BC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializableArchetypeComponent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableArchetypeComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableArchetypeComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x0000C749 File Offset: 0x0000A949
		public SerializableArchetypeComponent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06001D3D RID: 7485 RVA: 0x000877F8 File Offset: 0x000859F8
		// (set) Token: 0x06001D3E RID: 7486 RVA: 0x0000C752 File Offset: 0x0000A952
		public unsafe ArchetypeID ArchetypeID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableArchetypeComponent.NativeFieldInfoPtr_ArchetypeID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableArchetypeComponent.NativeFieldInfoPtr_ArchetypeID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06001D3F RID: 7487 RVA: 0x00087828 File Offset: 0x00085A28
		// (set) Token: 0x06001D40 RID: 7488 RVA: 0x0000C771 File Offset: 0x0000A971
		public unsafe MutableAttributes attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableArchetypeComponent.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableArchetypeComponent.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400147A RID: 5242
		private static readonly IntPtr NativeFieldInfoPtr_ArchetypeID;

		// Token: 0x0400147B RID: 5243
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x0400147C RID: 5244
		private static readonly IntPtr NativeMethodInfoPtr_ToArchetypeComponent_Public_ArchetypeComponent_0;

		// Token: 0x0400147D RID: 5245
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
