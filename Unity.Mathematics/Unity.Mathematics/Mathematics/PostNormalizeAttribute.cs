using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Unity.Mathematics
{
	// Token: 0x0200003B RID: 59
	public class PostNormalizeAttribute : PropertyAttribute
	{
		// Token: 0x06001F1D RID: 7965 RVA: 0x00002857 File Offset: 0x00000A57
		// Note: this type is marked as 'beforefieldinit'.
		static PostNormalizeAttribute()
		{
			Il2CppClassPointerStore<PostNormalizeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "PostNormalizeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostNormalizeAttribute>.NativeClassPtr);
			PostNormalizeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostNormalizeAttribute>.NativeClassPtr, 100671029);
		}

		// Token: 0x06001F1E RID: 7966 RVA: 0x000A2070 File Offset: 0x000A0270
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostNormalizeAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostNormalizeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostNormalizeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x00002890 File Offset: 0x00000A90
		public PostNormalizeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001F99 RID: 8089
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
