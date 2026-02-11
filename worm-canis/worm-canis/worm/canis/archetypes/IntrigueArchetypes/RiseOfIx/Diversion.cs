using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.RiseOfIx
{
	// Token: 0x0200013C RID: 316
	public class Diversion : WormArchetype
	{
		// Token: 0x06001183 RID: 4483 RVA: 0x0009FE98 File Offset: 0x0009E098
		// Note: this type is marked as 'beforefieldinit'.
		static Diversion()
		{
			Il2CppClassPointerStore<Diversion>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.RiseOfIx", "Diversion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Diversion>.NativeClassPtr);
			Diversion.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Diversion>.NativeClassPtr, "archID");
			Diversion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Diversion>.NativeClassPtr, 100666264);
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x0009FEF0 File Offset: 0x0009E0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89281, XrefRangeEnd = 89401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Diversion()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Diversion>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Diversion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x00008DDA File Offset: 0x00006FDA
		public Diversion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001186 RID: 4486 RVA: 0x0009FF2C File Offset: 0x0009E12C
		// (set) Token: 0x06001187 RID: 4487 RVA: 0x00008DE3 File Offset: 0x00006FE3
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Diversion.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Diversion.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B09 RID: 2825
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B0A RID: 2826
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
