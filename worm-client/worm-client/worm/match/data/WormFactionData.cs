using System;
using Canis.attributes;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using worm.canis.data.enums;

namespace worm.match.data
{
	// Token: 0x0200018A RID: 394
	public class WormFactionData : VersionedDataComponent
	{
		// Token: 0x060011AD RID: 4525 RVA: 0x0004D6D8 File Offset: 0x0004B8D8
		// Note: this type is marked as 'beforefieldinit'.
		static WormFactionData()
		{
			Il2CppClassPointerStore<WormFactionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormFactionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormFactionData>.NativeClassPtr);
			WormFactionData.NativeFieldInfoPtr_factionAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionData>.NativeClassPtr, "factionAttribute");
			WormFactionData.NativeMethodInfoPtr_get_Faction_Public_get_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionData>.NativeClassPtr, 100665732);
			WormFactionData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionData>.NativeClassPtr, 100665733);
			WormFactionData.NativeMethodInfoPtr__ctor_Public_Void_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionData>.NativeClassPtr, 100665734);
			WormFactionData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionData>.NativeClassPtr, 100665735);
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x060011AE RID: 4526 RVA: 0x0004D76C File Offset: 0x0004B96C
		public unsafe Factions Faction
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 711400, RefRangeEnd = 711415, XrefRangeStart = 711394, XrefRangeEnd = 711400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionData.NativeMethodInfoPtr_get_Faction_Public_get_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x060011AF RID: 4527 RVA: 0x0004D7A8 File Offset: 0x0004B9A8
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711415, XrefRangeEnd = 711419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormFactionData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x0004D7F0 File Offset: 0x0004B9F0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 711431, RefRangeEnd = 711440, XrefRangeStart = 711419, XrefRangeEnd = 711431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormFactionData(IHasAttributes attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFactionData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionData.NativeMethodInfoPtr__ctor_Public_Void_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x0004D83C File Offset: 0x0004BA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711440, XrefRangeEnd = 711449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormFactionData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x0000B3E6 File Offset: 0x000095E6
		public WormFactionData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x060011B3 RID: 4531 RVA: 0x0004D880 File Offset: 0x0004BA80
		// (set) Token: 0x060011B4 RID: 4532 RVA: 0x0000B3EF File Offset: 0x000095EF
		public unsafe IAttribute<Nullable<Factions>> factionAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionData.NativeFieldInfoPtr_factionAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<Factions>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionData.NativeFieldInfoPtr_factionAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A33 RID: 2611
		private static readonly IntPtr NativeFieldInfoPtr_factionAttribute;

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeMethodInfoPtr_get_Faction_Public_get_Factions_0;

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IHasAttributes_0;

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
