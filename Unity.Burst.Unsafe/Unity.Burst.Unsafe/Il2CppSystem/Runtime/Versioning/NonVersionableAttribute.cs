using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Versioning
{
	// Token: 0x02000003 RID: 3
	public sealed class NonVersionableAttribute : Attribute
	{
		// Token: 0x06000026 RID: 38 RVA: 0x00002059 File Offset: 0x00000259
		// Note: this type is marked as 'beforefieldinit'.
		static NonVersionableAttribute()
		{
			Il2CppClassPointerStore<NonVersionableAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.Unsafe.dll", "System.Runtime.Versioning", "NonVersionableAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NonVersionableAttribute>.NativeClassPtr);
			NonVersionableAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonVersionableAttribute>.NativeClassPtr, 100663332);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002FD0 File Offset: 0x000011D0
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NonVersionableAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NonVersionableAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonVersionableAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002092 File Offset: 0x00000292
		public NonVersionableAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
