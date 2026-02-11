using System;
using Canis.utils.ids;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.lib.canis.core_canis.data.composition
{
	// Token: 0x020001C1 RID: 449
	public class ArchetypeIDDataComponent : VersionedDataComponent
	{
		// Token: 0x0600191F RID: 6431 RVA: 0x00077C44 File Offset: 0x00075E44
		// Note: this type is marked as 'beforefieldinit'.
		static ArchetypeIDDataComponent()
		{
			Il2CppClassPointerStore<ArchetypeIDDataComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.lib.canis.core_canis.data.composition", "ArchetypeIDDataComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchetypeIDDataComponent>.NativeClassPtr);
			ArchetypeIDDataComponent.NativeFieldInfoPtr__archetypeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeIDDataComponent>.NativeClassPtr, "_archetypeID");
			ArchetypeIDDataComponent.NativeMethodInfoPtr_get_ArchetypeID_Public_get_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeIDDataComponent>.NativeClassPtr, 100667286);
			ArchetypeIDDataComponent.NativeMethodInfoPtr__ctor_Public_Void_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeIDDataComponent>.NativeClassPtr, 100667287);
			ArchetypeIDDataComponent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeIDDataComponent>.NativeClassPtr, 100667288);
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06001920 RID: 6432 RVA: 0x00077CC4 File Offset: 0x00075EC4
		public unsafe ArchetypeID ArchetypeID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeIDDataComponent.NativeMethodInfoPtr_get_ArchetypeID_Public_get_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
			}
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x00077D04 File Offset: 0x00075F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880946, XrefRangeEnd = 880949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArchetypeIDDataComponent(ArchetypeID id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchetypeIDDataComponent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeIDDataComponent.NativeMethodInfoPtr__ctor_Public_Void_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x00077D50 File Offset: 0x00075F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880949, XrefRangeEnd = 880952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeIDDataComponent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x0000B0BC File Offset: 0x000092BC
		public ArchetypeIDDataComponent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06001924 RID: 6436 RVA: 0x00077D94 File Offset: 0x00075F94
		// (set) Token: 0x06001925 RID: 6437 RVA: 0x0000B0C5 File Offset: 0x000092C5
		public unsafe ArchetypeID _archetypeID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeIDDataComponent.NativeFieldInfoPtr__archetypeID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeIDDataComponent.NativeFieldInfoPtr__archetypeID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011B1 RID: 4529
		private static readonly IntPtr NativeFieldInfoPtr__archetypeID;

		// Token: 0x040011B2 RID: 4530
		private static readonly IntPtr NativeMethodInfoPtr_get_ArchetypeID_Public_get_ArchetypeID_0;

		// Token: 0x040011B3 RID: 4531
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ArchetypeID_0;

		// Token: 0x040011B4 RID: 4532
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
