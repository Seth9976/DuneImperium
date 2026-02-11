using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TechTileArchetypes.RiseOfIx
{
	// Token: 0x020000FE RID: 254
	public class DetonationDevices : WormArchetype
	{
		// Token: 0x0600104D RID: 4173 RVA: 0x0009D110 File Offset: 0x0009B310
		// Note: this type is marked as 'beforefieldinit'.
		static DetonationDevices()
		{
			Il2CppClassPointerStore<DetonationDevices>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TechTileArchetypes.RiseOfIx", "DetonationDevices");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DetonationDevices>.NativeClassPtr);
			DetonationDevices.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetonationDevices>.NativeClassPtr, "archID");
			DetonationDevices.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetonationDevices>.NativeClassPtr, 100666140);
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x0009D168 File Offset: 0x0009B368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81779, XrefRangeEnd = 81861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DetonationDevices()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DetonationDevices>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetonationDevices.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x00008750 File Offset: 0x00006950
		public DetonationDevices(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06001050 RID: 4176 RVA: 0x0009D1A4 File Offset: 0x0009B3A4
		// (set) Token: 0x06001051 RID: 4177 RVA: 0x00008759 File Offset: 0x00006959
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DetonationDevices.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DetonationDevices.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A8D RID: 2701
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000A8E RID: 2702
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
