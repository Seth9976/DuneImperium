using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x0200015F RID: 351
	public class DispatchanEnvoy : WormArchetype
	{
		// Token: 0x06001232 RID: 4658 RVA: 0x000A184C File Offset: 0x0009FA4C
		// Note: this type is marked as 'beforefieldinit'.
		static DispatchanEnvoy()
		{
			Il2CppClassPointerStore<DispatchanEnvoy>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "DispatchanEnvoy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DispatchanEnvoy>.NativeClassPtr);
			DispatchanEnvoy.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DispatchanEnvoy>.NativeClassPtr, "archID");
			DispatchanEnvoy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchanEnvoy>.NativeClassPtr, 100666334);
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x000A18A4 File Offset: 0x0009FAA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93333, XrefRangeEnd = 93434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DispatchanEnvoy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DispatchanEnvoy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchanEnvoy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x0000918B File Offset: 0x0000738B
		public DispatchanEnvoy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001235 RID: 4661 RVA: 0x000A18E0 File Offset: 0x0009FAE0
		// (set) Token: 0x06001236 RID: 4662 RVA: 0x00009194 File Offset: 0x00007394
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DispatchanEnvoy.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DispatchanEnvoy.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B4F RID: 2895
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B50 RID: 2896
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
