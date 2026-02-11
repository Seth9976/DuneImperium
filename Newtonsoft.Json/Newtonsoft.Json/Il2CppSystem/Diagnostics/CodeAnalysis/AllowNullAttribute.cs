using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.CodeAnalysis
{
	// Token: 0x02000009 RID: 9
	public sealed class AllowNullAttribute : Attribute
	{
		// Token: 0x0600001E RID: 30 RVA: 0x000021C8 File Offset: 0x000003C8
		// Note: this type is marked as 'beforefieldinit'.
		static AllowNullAttribute()
		{
			Il2CppClassPointerStore<AllowNullAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "System.Diagnostics.CodeAnalysis", "AllowNullAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllowNullAttribute>.NativeClassPtr);
			AllowNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllowNullAttribute>.NativeClassPtr, 100663306);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000122C8 File Offset: 0x000104C8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AllowNullAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AllowNullAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllowNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002201 File Offset: 0x00000401
		public AllowNullAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
