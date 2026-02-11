using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.Immortality
{
	// Token: 0x020001A0 RID: 416
	public class LisanalGaib : WormArchetype
	{
		// Token: 0x06001377 RID: 4983 RVA: 0x000A4808 File Offset: 0x000A2A08
		// Note: this type is marked as 'beforefieldinit'.
		static LisanalGaib()
		{
			Il2CppClassPointerStore<LisanalGaib>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.Immortality", "LisanalGaib");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LisanalGaib>.NativeClassPtr);
			LisanalGaib.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LisanalGaib>.NativeClassPtr, "archID");
			LisanalGaib.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LisanalGaib>.NativeClassPtr, 100666464);
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x000A4860 File Offset: 0x000A2A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104242, XrefRangeEnd = 104480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LisanalGaib()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LisanalGaib>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LisanalGaib.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x00009866 File Offset: 0x00007A66
		public LisanalGaib(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x0600137A RID: 4986 RVA: 0x000A489C File Offset: 0x000A2A9C
		// (set) Token: 0x0600137B RID: 4987 RVA: 0x0000986F File Offset: 0x00007A6F
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LisanalGaib.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LisanalGaib.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BD1 RID: 3025
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BD2 RID: 3026
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
