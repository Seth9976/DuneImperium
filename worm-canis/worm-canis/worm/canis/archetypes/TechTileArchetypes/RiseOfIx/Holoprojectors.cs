using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TechTileArchetypes.RiseOfIx
{
	// Token: 0x02000101 RID: 257
	public class Holoprojectors : WormArchetype
	{
		// Token: 0x0600105C RID: 4188 RVA: 0x0009D344 File Offset: 0x0009B544
		// Note: this type is marked as 'beforefieldinit'.
		static Holoprojectors()
		{
			Il2CppClassPointerStore<Holoprojectors>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TechTileArchetypes.RiseOfIx", "Holoprojectors");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Holoprojectors>.NativeClassPtr);
			Holoprojectors.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Holoprojectors>.NativeClassPtr, "archID");
			Holoprojectors.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Holoprojectors>.NativeClassPtr, 100666146);
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x0009D39C File Offset: 0x0009B59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82109, XrefRangeEnd = 82217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Holoprojectors()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Holoprojectors>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Holoprojectors.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x000087A1 File Offset: 0x000069A1
		public Holoprojectors(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x0600105F RID: 4191 RVA: 0x0009D3D8 File Offset: 0x0009B5D8
		// (set) Token: 0x06001060 RID: 4192 RVA: 0x000087AA File Offset: 0x000069AA
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Holoprojectors.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Holoprojectors.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A93 RID: 2707
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000A94 RID: 2708
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
