using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TechTileArchetypes.RiseOfIx
{
	// Token: 0x02000100 RID: 256
	public class Flagship : WormArchetype
	{
		// Token: 0x06001057 RID: 4183 RVA: 0x0009D288 File Offset: 0x0009B488
		// Note: this type is marked as 'beforefieldinit'.
		static Flagship()
		{
			Il2CppClassPointerStore<Flagship>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TechTileArchetypes.RiseOfIx", "Flagship");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Flagship>.NativeClassPtr);
			Flagship.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flagship>.NativeClassPtr, "archID");
			Flagship.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flagship>.NativeClassPtr, 100666144);
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x0009D2E0 File Offset: 0x0009B4E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81992, XrefRangeEnd = 82109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Flagship()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Flagship>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Flagship.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x00008786 File Offset: 0x00006986
		public Flagship(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x0600105A RID: 4186 RVA: 0x0009D31C File Offset: 0x0009B51C
		// (set) Token: 0x0600105B RID: 4187 RVA: 0x0000878F File Offset: 0x0000698F
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Flagship.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Flagship.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A91 RID: 2705
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000A92 RID: 2706
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
