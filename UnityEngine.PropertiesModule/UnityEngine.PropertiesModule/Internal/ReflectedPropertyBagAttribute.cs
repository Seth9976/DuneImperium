using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Properties.Internal
{
	// Token: 0x02000032 RID: 50
	public class ReflectedPropertyBagAttribute : Attribute
	{
		// Token: 0x06000185 RID: 389 RVA: 0x00002CC2 File Offset: 0x00000EC2
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectedPropertyBagAttribute()
		{
			Il2CppClassPointerStore<ReflectedPropertyBagAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties.Internal", "ReflectedPropertyBagAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectedPropertyBagAttribute>.NativeClassPtr);
			ReflectedPropertyBagAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedPropertyBagAttribute>.NativeClassPtr, 100663532);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00007944 File Offset: 0x00005B44
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectedPropertyBagAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectedPropertyBagAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedPropertyBagAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002CFB File Offset: 0x00000EFB
		public ReflectedPropertyBagAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
