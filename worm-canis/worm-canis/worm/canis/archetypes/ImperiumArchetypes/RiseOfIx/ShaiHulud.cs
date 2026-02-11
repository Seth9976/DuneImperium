using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.RiseOfIx
{
	// Token: 0x0200018D RID: 397
	public class ShaiHulud : WormArchetype
	{
		// Token: 0x06001318 RID: 4888 RVA: 0x000A3A14 File Offset: 0x000A1C14
		// Note: this type is marked as 'beforefieldinit'.
		static ShaiHulud()
		{
			Il2CppClassPointerStore<ShaiHulud>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.RiseOfIx", "ShaiHulud");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaiHulud>.NativeClassPtr);
			ShaiHulud.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaiHulud>.NativeClassPtr, "archID");
			ShaiHulud.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaiHulud>.NativeClassPtr, 100666426);
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x000A3A6C File Offset: 0x000A1C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100429, XrefRangeEnd = 100660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShaiHulud()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaiHulud>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaiHulud.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x00009665 File Offset: 0x00007865
		public ShaiHulud(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x0600131B RID: 4891 RVA: 0x000A3AA8 File Offset: 0x000A1CA8
		// (set) Token: 0x0600131C RID: 4892 RVA: 0x0000966E File Offset: 0x0000786E
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaiHulud.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaiHulud.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BAB RID: 2987
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BAC RID: 2988
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
