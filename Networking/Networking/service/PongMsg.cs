using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Networking.service
{
	// Token: 0x0200005A RID: 90
	public class PongMsg : NetworkMessageEvent
	{
		// Token: 0x060002E0 RID: 736 RVA: 0x00003E35 File Offset: 0x00002035
		// Note: this type is marked as 'beforefieldinit'.
		static PongMsg()
		{
			Il2CppClassPointerStore<PongMsg>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.service", "PongMsg");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PongMsg>.NativeClassPtr);
			PongMsg.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PongMsg>.NativeClassPtr, 100663441);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000D2A8 File Offset: 0x0000B4A8
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PongMsg()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PongMsg>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PongMsg.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00003E6E File Offset: 0x0000206E
		public PongMsg(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
