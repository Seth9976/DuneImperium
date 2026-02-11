using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.RiseOfIx
{
	// Token: 0x0200017D RID: 381
	public class EsmarTuek : WormArchetype
	{
		// Token: 0x060012C8 RID: 4808 RVA: 0x000A2E54 File Offset: 0x000A1054
		// Note: this type is marked as 'beforefieldinit'.
		static EsmarTuek()
		{
			Il2CppClassPointerStore<EsmarTuek>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.RiseOfIx", "EsmarTuek");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EsmarTuek>.NativeClassPtr);
			EsmarTuek.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EsmarTuek>.NativeClassPtr, "archID");
			EsmarTuek.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EsmarTuek>.NativeClassPtr, 100666394);
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x000A2EAC File Offset: 0x000A10AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97187, XrefRangeEnd = 97408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EsmarTuek()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EsmarTuek>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EsmarTuek.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x000094B5 File Offset: 0x000076B5
		public EsmarTuek(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x060012CB RID: 4811 RVA: 0x000A2EE8 File Offset: 0x000A10E8
		// (set) Token: 0x060012CC RID: 4812 RVA: 0x000094BE File Offset: 0x000076BE
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EsmarTuek.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EsmarTuek.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B8B RID: 2955
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B8C RID: 2956
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
