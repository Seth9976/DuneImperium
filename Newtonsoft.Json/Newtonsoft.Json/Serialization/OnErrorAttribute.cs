using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200009B RID: 155
	public sealed class OnErrorAttribute : Attribute
	{
		// Token: 0x06000D6A RID: 3434 RVA: 0x000065B2 File Offset: 0x000047B2
		// Note: this type is marked as 'beforefieldinit'.
		static OnErrorAttribute()
		{
			Il2CppClassPointerStore<OnErrorAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "OnErrorAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnErrorAttribute>.NativeClassPtr);
			OnErrorAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnErrorAttribute>.NativeClassPtr, 100665741);
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x0004FD7C File Offset: 0x0004DF7C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnErrorAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnErrorAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnErrorAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x000065EB File Offset: 0x000047EB
		public OnErrorAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000ADA RID: 2778
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
