using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TechTileArchetypes.RiseOfIx
{
	// Token: 0x0200010A RID: 266
	public class SpySatellites : WormArchetype
	{
		// Token: 0x06001089 RID: 4233 RVA: 0x0009D9E0 File Offset: 0x0009BBE0
		// Note: this type is marked as 'beforefieldinit'.
		static SpySatellites()
		{
			Il2CppClassPointerStore<SpySatellites>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TechTileArchetypes.RiseOfIx", "SpySatellites");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpySatellites>.NativeClassPtr);
			SpySatellites.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpySatellites>.NativeClassPtr, "archID");
			SpySatellites.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpySatellites>.NativeClassPtr, 100666164);
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x0009DA38 File Offset: 0x0009BC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83154, XrefRangeEnd = 83269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpySatellites()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpySatellites>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpySatellites.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x00008894 File Offset: 0x00006A94
		public SpySatellites(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x0600108C RID: 4236 RVA: 0x0009DA74 File Offset: 0x0009BC74
		// (set) Token: 0x0600108D RID: 4237 RVA: 0x0000889D File Offset: 0x00006A9D
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SpySatellites.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpySatellites.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AA5 RID: 2725
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AA6 RID: 2726
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
