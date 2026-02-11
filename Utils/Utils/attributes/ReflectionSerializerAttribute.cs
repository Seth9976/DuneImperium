using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Utils.attributes
{
	// Token: 0x02000040 RID: 64
	public class ReflectionSerializerAttribute : Attribute
	{
		// Token: 0x0600028F RID: 655 RVA: 0x00002BFE File Offset: 0x00000DFE
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionSerializerAttribute()
		{
			Il2CppClassPointerStore<ReflectionSerializerAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Utils.attributes", "ReflectionSerializerAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionSerializerAttribute>.NativeClassPtr);
			ReflectionSerializerAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionSerializerAttribute>.NativeClassPtr, 100663907);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000F250 File Offset: 0x0000D450
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionSerializerAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionSerializerAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionSerializerAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002C37 File Offset: 0x00000E37
		public ReflectionSerializerAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
