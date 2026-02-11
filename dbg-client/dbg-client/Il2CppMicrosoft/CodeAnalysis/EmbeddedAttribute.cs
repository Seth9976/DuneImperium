using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.CodeAnalysis
{
	// Token: 0x02000003 RID: 3
	public sealed class EmbeddedAttribute : Attribute
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002059 File Offset: 0x00000259
		// Note: this type is marked as 'beforefieldinit'.
		static EmbeddedAttribute()
		{
			Il2CppClassPointerStore<EmbeddedAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "Microsoft.CodeAnalysis", "EmbeddedAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmbeddedAttribute>.NativeClassPtr);
			EmbeddedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedAttribute>.NativeClassPtr, 100663303);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0001D70C File Offset: 0x0001B90C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmbeddedAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmbeddedAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmbeddedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002092 File Offset: 0x00000292
		public EmbeddedAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
