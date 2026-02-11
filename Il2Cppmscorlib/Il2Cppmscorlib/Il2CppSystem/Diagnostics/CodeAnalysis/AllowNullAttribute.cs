using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.CodeAnalysis
{
	// Token: 0x020004AF RID: 1199
	public sealed class AllowNullAttribute : Attribute
	{
		// Token: 0x06004A1B RID: 18971 RVA: 0x0001B25F File Offset: 0x0001945F
		// Note: this type is marked as 'beforefieldinit'.
		static AllowNullAttribute()
		{
			Il2CppClassPointerStore<AllowNullAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.CodeAnalysis", "AllowNullAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllowNullAttribute>.NativeClassPtr);
			AllowNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllowNullAttribute>.NativeClassPtr, 100674079);
		}

		// Token: 0x06004A1C RID: 18972 RVA: 0x00156FE8 File Offset: 0x001551E8
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

		// Token: 0x06004A1D RID: 18973 RVA: 0x0001B298 File Offset: 0x00019498
		public AllowNullAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003CC4 RID: 15556
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
