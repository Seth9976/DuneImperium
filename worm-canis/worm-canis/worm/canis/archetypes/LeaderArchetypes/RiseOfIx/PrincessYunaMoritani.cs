using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.LeaderArchetypes.RiseOfIx
{
	// Token: 0x0200012C RID: 300
	public class PrincessYunaMoritani : WormArchetype
	{
		// Token: 0x06001133 RID: 4403 RVA: 0x0009F2D8 File Offset: 0x0009D4D8
		// Note: this type is marked as 'beforefieldinit'.
		static PrincessYunaMoritani()
		{
			Il2CppClassPointerStore<PrincessYunaMoritani>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.LeaderArchetypes.RiseOfIx", "PrincessYunaMoritani");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrincessYunaMoritani>.NativeClassPtr);
			PrincessYunaMoritani.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrincessYunaMoritani>.NativeClassPtr, "archID");
			PrincessYunaMoritani.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrincessYunaMoritani>.NativeClassPtr, 100666232);
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x0009F330 File Offset: 0x0009D530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87544, XrefRangeEnd = 87651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrincessYunaMoritani()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrincessYunaMoritani>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrincessYunaMoritani.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x00008C2A File Offset: 0x00006E2A
		public PrincessYunaMoritani(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001136 RID: 4406 RVA: 0x0009F36C File Offset: 0x0009D56C
		// (set) Token: 0x06001137 RID: 4407 RVA: 0x00008C33 File Offset: 0x00006E33
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PrincessYunaMoritani.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PrincessYunaMoritani.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AE9 RID: 2793
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AEA RID: 2794
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
