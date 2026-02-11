using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Versioning
{
	// Token: 0x02000311 RID: 785
	public sealed class NonVersionableAttribute : Attribute
	{
		// Token: 0x06003068 RID: 12392 RVA: 0x00010973 File Offset: 0x0000EB73
		// Note: this type is marked as 'beforefieldinit'.
		static NonVersionableAttribute()
		{
			Il2CppClassPointerStore<NonVersionableAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Versioning", "NonVersionableAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NonVersionableAttribute>.NativeClassPtr);
			NonVersionableAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonVersionableAttribute>.NativeClassPtr, 100670941);
		}

		// Token: 0x06003069 RID: 12393 RVA: 0x000F74AC File Offset: 0x000F56AC
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

		// Token: 0x0600306A RID: 12394 RVA: 0x000109AC File Offset: 0x0000EBAC
		public NonVersionableAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002809 RID: 10249
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
