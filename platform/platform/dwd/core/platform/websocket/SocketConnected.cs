using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platform.websocket
{
	// Token: 0x02000016 RID: 22
	public class SocketConnected : TypedMessage
	{
		// Token: 0x06000123 RID: 291 RVA: 0x0000260D File Offset: 0x0000080D
		// Note: this type is marked as 'beforefieldinit'.
		static SocketConnected()
		{
			Il2CppClassPointerStore<SocketConnected>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket", "SocketConnected");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocketConnected>.NativeClassPtr);
			SocketConnected.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketConnected>.NativeClassPtr, 100663532);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000979C File Offset: 0x0000799C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketConnected()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketConnected>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketConnected.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002646 File Offset: 0x00000846
		public SocketConnected(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
