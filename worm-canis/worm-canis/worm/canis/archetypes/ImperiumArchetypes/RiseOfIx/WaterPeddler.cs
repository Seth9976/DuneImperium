using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.RiseOfIx
{
	// Token: 0x02000191 RID: 401
	public class WaterPeddler : WormArchetype
	{
		// Token: 0x0600132C RID: 4908 RVA: 0x000A3D04 File Offset: 0x000A1F04
		// Note: this type is marked as 'beforefieldinit'.
		static WaterPeddler()
		{
			Il2CppClassPointerStore<WaterPeddler>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.RiseOfIx", "WaterPeddler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaterPeddler>.NativeClassPtr);
			WaterPeddler.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterPeddler>.NativeClassPtr, "archID");
			WaterPeddler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterPeddler>.NativeClassPtr, 100666434);
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x000A3D5C File Offset: 0x000A1F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101281, XrefRangeEnd = 101468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaterPeddler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaterPeddler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterPeddler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x000096D1 File Offset: 0x000078D1
		public WaterPeddler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x000A3D98 File Offset: 0x000A1F98
		// (set) Token: 0x06001330 RID: 4912 RVA: 0x000096DA File Offset: 0x000078DA
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WaterPeddler.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaterPeddler.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BB3 RID: 2995
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BB4 RID: 2996
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
