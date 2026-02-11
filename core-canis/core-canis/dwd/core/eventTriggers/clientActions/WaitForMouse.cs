using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Networking.eventtriggers.clientactions;

namespace dwd.core.eventTriggers.clientActions
{
	// Token: 0x020001B6 RID: 438
	public sealed class WaitForMouse : ClientAction
	{
		// Token: 0x06001886 RID: 6278 RVA: 0x0000ACC2 File Offset: 0x00008EC2
		// Note: this type is marked as 'beforefieldinit'.
		static WaitForMouse()
		{
			Il2CppClassPointerStore<WaitForMouse>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.eventTriggers.clientActions", "WaitForMouse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForMouse>.NativeClassPtr);
			WaitForMouse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForMouse>.NativeClassPtr, 100667210);
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x00075A7C File Offset: 0x00073C7C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 542958, RefRangeEnd = 542962, XrefRangeStart = 542958, XrefRangeEnd = 542962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitForMouse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForMouse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForMouse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x0000ACFB File Offset: 0x00008EFB
		public WaitForMouse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400114D RID: 4429
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
