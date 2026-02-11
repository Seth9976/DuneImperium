using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200013C RID: 316
	public sealed class ExtensionOfNativeClassAttribute : Attribute
	{
		// Token: 0x0600184E RID: 6222 RVA: 0x00009A6B File Offset: 0x00007C6B
		// Note: this type is marked as 'beforefieldinit'.
		static ExtensionOfNativeClassAttribute()
		{
			Il2CppClassPointerStore<ExtensionOfNativeClassAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ExtensionOfNativeClassAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExtensionOfNativeClassAttribute>.NativeClassPtr);
			ExtensionOfNativeClassAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtensionOfNativeClassAttribute>.NativeClassPtr, 100666605);
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x00072384 File Offset: 0x00070584
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExtensionOfNativeClassAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExtensionOfNativeClassAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtensionOfNativeClassAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x00009AA4 File Offset: 0x00007CA4
		public ExtensionOfNativeClassAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040015B2 RID: 5554
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
