using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.CodeAnalysis
{
	// Token: 0x02000006 RID: 6
	public sealed class NotNullAttribute : Attribute
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00002120 File Offset: 0x00000320
		// Note: this type is marked as 'beforefieldinit'.
		static NotNullAttribute()
		{
			Il2CppClassPointerStore<NotNullAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "System.Diagnostics.CodeAnalysis", "NotNullAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotNullAttribute>.NativeClassPtr);
			NotNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotNullAttribute>.NativeClassPtr, 100663302);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00012138 File Offset: 0x00010338
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotNullAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotNullAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002159 File Offset: 0x00000359
		public NotNullAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
