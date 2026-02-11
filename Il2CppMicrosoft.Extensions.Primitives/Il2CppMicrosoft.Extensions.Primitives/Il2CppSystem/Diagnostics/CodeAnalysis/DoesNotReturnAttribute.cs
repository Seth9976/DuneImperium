using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.CodeAnalysis
{
	// Token: 0x02000007 RID: 7
	public sealed class DoesNotReturnAttribute : Attribute
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00002126 File Offset: 0x00000326
		// Note: this type is marked as 'beforefieldinit'.
		static DoesNotReturnAttribute()
		{
			Il2CppClassPointerStore<DoesNotReturnAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Primitives.dll", "System.Diagnostics.CodeAnalysis", "DoesNotReturnAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoesNotReturnAttribute>.NativeClassPtr);
			DoesNotReturnAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoesNotReturnAttribute>.NativeClassPtr, 100663303);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002630 File Offset: 0x00000830
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoesNotReturnAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoesNotReturnAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoesNotReturnAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000215F File Offset: 0x0000035F
		public DoesNotReturnAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
