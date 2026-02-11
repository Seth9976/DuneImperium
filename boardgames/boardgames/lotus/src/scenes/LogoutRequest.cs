using System;
using dwd.core.endorsement;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace lotus.src.scenes
{
	// Token: 0x020000F1 RID: 241
	public class LogoutRequest : Request
	{
		// Token: 0x06000B9F RID: 2975 RVA: 0x000074D1 File Offset: 0x000056D1
		// Note: this type is marked as 'beforefieldinit'.
		static LogoutRequest()
		{
			Il2CppClassPointerStore<LogoutRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus.src.scenes", "LogoutRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogoutRequest>.NativeClassPtr);
			LogoutRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogoutRequest>.NativeClassPtr, 100665161);
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x000362AC File Offset: 0x000344AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogoutRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogoutRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogoutRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x0000750A File Offset: 0x0000570A
		public LogoutRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
