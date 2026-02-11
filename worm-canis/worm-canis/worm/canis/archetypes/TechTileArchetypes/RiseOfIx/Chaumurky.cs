using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TechTileArchetypes.RiseOfIx
{
	// Token: 0x020000FD RID: 253
	public class Chaumurky : WormArchetype
	{
		// Token: 0x06001048 RID: 4168 RVA: 0x0009D054 File Offset: 0x0009B254
		// Note: this type is marked as 'beforefieldinit'.
		static Chaumurky()
		{
			Il2CppClassPointerStore<Chaumurky>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TechTileArchetypes.RiseOfIx", "Chaumurky");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Chaumurky>.NativeClassPtr);
			Chaumurky.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chaumurky>.NativeClassPtr, "archID");
			Chaumurky.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chaumurky>.NativeClassPtr, 100666138);
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x0009D0AC File Offset: 0x0009B2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81642, XrefRangeEnd = 81779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Chaumurky()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Chaumurky>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chaumurky.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x00008735 File Offset: 0x00006935
		public Chaumurky(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x0600104B RID: 4171 RVA: 0x0009D0E8 File Offset: 0x0009B2E8
		// (set) Token: 0x0600104C RID: 4172 RVA: 0x0000873E File Offset: 0x0000693E
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Chaumurky.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Chaumurky.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A8B RID: 2699
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000A8C RID: 2700
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
