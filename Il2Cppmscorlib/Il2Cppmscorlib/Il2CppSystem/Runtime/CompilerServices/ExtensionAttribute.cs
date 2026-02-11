using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003B4 RID: 948
	public sealed class ExtensionAttribute : Attribute
	{
		// Token: 0x06003907 RID: 14599 RVA: 0x0001500D File Offset: 0x0001320D
		// Note: this type is marked as 'beforefieldinit'.
		static ExtensionAttribute()
		{
			Il2CppClassPointerStore<ExtensionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "ExtensionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExtensionAttribute>.NativeClassPtr);
			ExtensionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtensionAttribute>.NativeClassPtr, 100671812);
		}

		// Token: 0x06003908 RID: 14600 RVA: 0x00114D08 File Offset: 0x00112F08
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExtensionAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExtensionAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtensionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003909 RID: 14601 RVA: 0x00015046 File Offset: 0x00013246
		public ExtensionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002E79 RID: 11897
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
