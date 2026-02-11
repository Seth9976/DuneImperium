using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Networking.service
{
	// Token: 0x02000059 RID: 89
	public class PingMsg : NetworkMessageEvent
	{
		// Token: 0x060002DD RID: 733 RVA: 0x00003DF3 File Offset: 0x00001FF3
		// Note: this type is marked as 'beforefieldinit'.
		static PingMsg()
		{
			Il2CppClassPointerStore<PingMsg>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.service", "PingMsg");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PingMsg>.NativeClassPtr);
			PingMsg.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PingMsg>.NativeClassPtr, 100663440);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0000D26C File Offset: 0x0000B46C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PingMsg()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PingMsg>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PingMsg.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00003E2C File Offset: 0x0000202C
		public PingMsg(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
