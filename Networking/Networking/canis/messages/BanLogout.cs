using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Canis.messages
{
	// Token: 0x02000031 RID: 49
	public class BanLogout : NetworkMessageEvent
	{
		// Token: 0x060001A3 RID: 419 RVA: 0x000031C1 File Offset: 0x000013C1
		// Note: this type is marked as 'beforefieldinit'.
		static BanLogout()
		{
			Il2CppClassPointerStore<BanLogout>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages", "BanLogout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BanLogout>.NativeClassPtr);
			BanLogout.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BanLogout>.NativeClassPtr, 100663380);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000A284 File Offset: 0x00008484
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BanLogout()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BanLogout>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BanLogout.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000031FA File Offset: 0x000013FA
		public BanLogout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
