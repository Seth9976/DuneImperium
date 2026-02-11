using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.IL2CPP.CompilerServices
{
	// Token: 0x02000003 RID: 3
	public class Il2CppEagerStaticClassConstructionAttribute : Attribute
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002059 File Offset: 0x00000259
		// Note: this type is marked as 'beforefieldinit'.
		static Il2CppEagerStaticClassConstructionAttribute()
		{
			Il2CppClassPointerStore<Il2CppEagerStaticClassConstructionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.IL2CPP.CompilerServices", "Il2CppEagerStaticClassConstructionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppEagerStaticClassConstructionAttribute>.NativeClassPtr);
			Il2CppEagerStaticClassConstructionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppEagerStaticClassConstructionAttribute>.NativeClassPtr, 100663299);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000333C File Offset: 0x0000153C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppEagerStaticClassConstructionAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppEagerStaticClassConstructionAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppEagerStaticClassConstructionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002092 File Offset: 0x00000292
		public Il2CppEagerStaticClassConstructionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
