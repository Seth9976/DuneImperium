using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Unity.Mathematics
{
	// Token: 0x0200003C RID: 60
	public class DoNotNormalizeAttribute : PropertyAttribute
	{
		// Token: 0x06001F20 RID: 7968 RVA: 0x00002899 File Offset: 0x00000A99
		// Note: this type is marked as 'beforefieldinit'.
		static DoNotNormalizeAttribute()
		{
			Il2CppClassPointerStore<DoNotNormalizeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "DoNotNormalizeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoNotNormalizeAttribute>.NativeClassPtr);
			DoNotNormalizeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoNotNormalizeAttribute>.NativeClassPtr, 100671030);
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x000A20AC File Offset: 0x000A02AC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoNotNormalizeAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoNotNormalizeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoNotNormalizeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x000028D2 File Offset: 0x00000AD2
		public DoNotNormalizeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001F9A RID: 8090
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
