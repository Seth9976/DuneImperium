using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TleilaxuArchetypes.Immortality
{
	// Token: 0x020000ED RID: 237
	public class FaceDancer : WormArchetype
	{
		// Token: 0x06000FF8 RID: 4088 RVA: 0x0009C494 File Offset: 0x0009A694
		// Note: this type is marked as 'beforefieldinit'.
		static FaceDancer()
		{
			Il2CppClassPointerStore<FaceDancer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TleilaxuArchetypes.Immortality", "FaceDancer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FaceDancer>.NativeClassPtr);
			FaceDancer.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceDancer>.NativeClassPtr, "archID");
			FaceDancer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceDancer>.NativeClassPtr, 100666106);
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x0009C4EC File Offset: 0x0009A6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78932, XrefRangeEnd = 79134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FaceDancer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FaceDancer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceDancer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x00008585 File Offset: 0x00006785
		public FaceDancer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06000FFB RID: 4091 RVA: 0x0009C528 File Offset: 0x0009A728
		// (set) Token: 0x06000FFC RID: 4092 RVA: 0x0000858E File Offset: 0x0000678E
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FaceDancer.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FaceDancer.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A6B RID: 2667
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000A6C RID: 2668
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
