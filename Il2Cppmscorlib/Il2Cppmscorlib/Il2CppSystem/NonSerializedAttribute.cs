using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000CA RID: 202
	public sealed class NonSerializedAttribute : Attribute
	{
		// Token: 0x06000D0B RID: 3339 RVA: 0x000052A4 File Offset: 0x000034A4
		// Note: this type is marked as 'beforefieldinit'.
		static NonSerializedAttribute()
		{
			Il2CppClassPointerStore<NonSerializedAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "NonSerializedAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NonSerializedAttribute>.NativeClassPtr);
			NonSerializedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonSerializedAttribute>.NativeClassPtr, 100665584);
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x000624C4 File Offset: 0x000606C4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NonSerializedAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NonSerializedAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonSerializedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x000052DD File Offset: 0x000034DD
		public NonSerializedAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000ABA RID: 2746
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
