using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.SpaceArchetypes.BaseSet
{
	// Token: 0x02000120 RID: 288
	public class Secrets : WormArchetype
	{
		// Token: 0x060010F7 RID: 4343 RVA: 0x0009EA08 File Offset: 0x0009CC08
		// Note: this type is marked as 'beforefieldinit'.
		static Secrets()
		{
			Il2CppClassPointerStore<Secrets>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.SpaceArchetypes.BaseSet", "Secrets");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Secrets>.NativeClassPtr);
			Secrets.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Secrets>.NativeClassPtr, "archID");
			Secrets.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Secrets>.NativeClassPtr, 100666208);
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x0009EA60 File Offset: 0x0009CC60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86055, XrefRangeEnd = 86202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Secrets()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Secrets>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Secrets.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x00008AE6 File Offset: 0x00006CE6
		public Secrets(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x060010FA RID: 4346 RVA: 0x0009EA9C File Offset: 0x0009CC9C
		// (set) Token: 0x060010FB RID: 4347 RVA: 0x00008AEF File Offset: 0x00006CEF
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Secrets.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Secrets.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AD1 RID: 2769
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AD2 RID: 2770
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
