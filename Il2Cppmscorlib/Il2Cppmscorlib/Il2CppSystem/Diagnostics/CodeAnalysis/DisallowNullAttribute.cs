using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.CodeAnalysis
{
	// Token: 0x020004B0 RID: 1200
	public sealed class DisallowNullAttribute : Attribute
	{
		// Token: 0x06004A1E RID: 18974 RVA: 0x0001B2A1 File Offset: 0x000194A1
		// Note: this type is marked as 'beforefieldinit'.
		static DisallowNullAttribute()
		{
			Il2CppClassPointerStore<DisallowNullAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.CodeAnalysis", "DisallowNullAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisallowNullAttribute>.NativeClassPtr);
			DisallowNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisallowNullAttribute>.NativeClassPtr, 100674080);
		}

		// Token: 0x06004A1F RID: 18975 RVA: 0x00157024 File Offset: 0x00155224
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DisallowNullAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisallowNullAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisallowNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A20 RID: 18976 RVA: 0x0001B2DA File Offset: 0x000194DA
		public DisallowNullAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003CC5 RID: 15557
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
