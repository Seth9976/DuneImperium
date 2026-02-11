using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.CodeAnalysis
{
	// Token: 0x020000AC RID: 172
	public sealed class ExcludeFromCodeCoverageAttribute : Attribute
	{
		// Token: 0x06000C71 RID: 3185 RVA: 0x00006A6C File Offset: 0x00004C6C
		// Note: this type is marked as 'beforefieldinit'.
		static ExcludeFromCodeCoverageAttribute()
		{
			Il2CppClassPointerStore<ExcludeFromCodeCoverageAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Diagnostics.CodeAnalysis", "ExcludeFromCodeCoverageAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExcludeFromCodeCoverageAttribute>.NativeClassPtr);
			ExcludeFromCodeCoverageAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExcludeFromCodeCoverageAttribute>.NativeClassPtr, 100665070);
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x0004A410 File Offset: 0x00048610
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExcludeFromCodeCoverageAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExcludeFromCodeCoverageAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExcludeFromCodeCoverageAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x00006AA5 File Offset: 0x00004CA5
		public ExcludeFromCodeCoverageAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009C7 RID: 2503
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
