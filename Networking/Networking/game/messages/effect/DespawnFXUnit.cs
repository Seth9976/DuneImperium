using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Networking.game.messages.effect
{
	// Token: 0x020000B7 RID: 183
	public class DespawnFXUnit : FXUnitMessage
	{
		// Token: 0x06000602 RID: 1538 RVA: 0x00005C01 File Offset: 0x00003E01
		// Note: this type is marked as 'beforefieldinit'.
		static DespawnFXUnit()
		{
			Il2CppClassPointerStore<DespawnFXUnit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.game.messages.effect", "DespawnFXUnit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DespawnFXUnit>.NativeClassPtr);
			DespawnFXUnit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DespawnFXUnit>.NativeClassPtr, 100663666);
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00015C70 File Offset: 0x00013E70
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DespawnFXUnit()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DespawnFXUnit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DespawnFXUnit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00005C3A File Offset: 0x00003E3A
		public DespawnFXUnit(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
