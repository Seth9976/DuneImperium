using System;
using dwd.core.endorsement;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace lotus.src.scenes
{
	// Token: 0x020000F0 RID: 240
	public class LogoutEndorser : SubscribableEndorser<LogoutRequest>
	{
		// Token: 0x06000B9C RID: 2972 RVA: 0x0000748F File Offset: 0x0000568F
		// Note: this type is marked as 'beforefieldinit'.
		static LogoutEndorser()
		{
			Il2CppClassPointerStore<LogoutEndorser>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus.src.scenes", "LogoutEndorser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogoutEndorser>.NativeClassPtr);
			LogoutEndorser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogoutEndorser>.NativeClassPtr, 100665160);
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x00036270 File Offset: 0x00034470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994947, XrefRangeEnd = 994950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogoutEndorser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogoutEndorser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogoutEndorser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x000074C8 File Offset: 0x000056C8
		public LogoutEndorser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
