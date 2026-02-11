using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.CodeAnalysis
{
	// Token: 0x02000008 RID: 8
	public sealed class MaybeNullAttribute : Attribute
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00002186 File Offset: 0x00000386
		// Note: this type is marked as 'beforefieldinit'.
		static MaybeNullAttribute()
		{
			Il2CppClassPointerStore<MaybeNullAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "System.Diagnostics.CodeAnalysis", "MaybeNullAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaybeNullAttribute>.NativeClassPtr);
			MaybeNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaybeNullAttribute>.NativeClassPtr, 100663305);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0001228C File Offset: 0x0001048C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaybeNullAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaybeNullAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaybeNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000021BF File Offset: 0x000003BF
		public MaybeNullAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
