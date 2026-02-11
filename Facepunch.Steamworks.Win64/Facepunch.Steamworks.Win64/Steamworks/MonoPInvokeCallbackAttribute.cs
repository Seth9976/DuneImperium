using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020000C4 RID: 196
	public class MonoPInvokeCallbackAttribute : Attribute
	{
		// Token: 0x06000C9C RID: 3228 RVA: 0x0000320C File Offset: 0x0000140C
		// Note: this type is marked as 'beforefieldinit'.
		static MonoPInvokeCallbackAttribute()
		{
			Il2CppClassPointerStore<MonoPInvokeCallbackAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "MonoPInvokeCallbackAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoPInvokeCallbackAttribute>.NativeClassPtr);
			MonoPInvokeCallbackAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoPInvokeCallbackAttribute>.NativeClassPtr, 100666397);
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x00053430 File Offset: 0x00051630
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoPInvokeCallbackAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoPInvokeCallbackAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoPInvokeCallbackAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x00003245 File Offset: 0x00001445
		public MonoPInvokeCallbackAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001327 RID: 4903
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
