using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TleilaxuArchetypes.Immortality
{
	// Token: 0x020000EB RID: 235
	public class Contaminator : WormArchetype
	{
		// Token: 0x06000FEE RID: 4078 RVA: 0x0009C31C File Offset: 0x0009A51C
		// Note: this type is marked as 'beforefieldinit'.
		static Contaminator()
		{
			Il2CppClassPointerStore<Contaminator>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TleilaxuArchetypes.Immortality", "Contaminator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Contaminator>.NativeClassPtr);
			Contaminator.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contaminator>.NativeClassPtr, "archID");
			Contaminator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contaminator>.NativeClassPtr, 100666102);
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x0009C374 File Offset: 0x0009A574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78548, XrefRangeEnd = 78730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Contaminator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Contaminator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contaminator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x0000854F File Offset: 0x0000674F
		public Contaminator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06000FF1 RID: 4081 RVA: 0x0009C3B0 File Offset: 0x0009A5B0
		// (set) Token: 0x06000FF2 RID: 4082 RVA: 0x00008558 File Offset: 0x00006758
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Contaminator.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Contaminator.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A67 RID: 2663
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000A68 RID: 2664
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
