using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	public class WritableAttribute : Attribute
	{
		// Token: 0x0600000E RID: 14 RVA: 0x000020F8 File Offset: 0x000002F8
		// Note: this type is marked as 'beforefieldinit'.
		static WritableAttribute()
		{
			Il2CppClassPointerStore<WritableAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine", "WritableAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WritableAttribute>.NativeClassPtr);
			WritableAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WritableAttribute>.NativeClassPtr, 100663299);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000029B8 File Offset: 0x00000BB8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WritableAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WritableAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WritableAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002131 File Offset: 0x00000331
		public WritableAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
