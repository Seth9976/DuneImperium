using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003C7 RID: 967
	[Serializable]
	public sealed class UnsafeValueTypeAttribute : Attribute
	{
		// Token: 0x06003959 RID: 14681 RVA: 0x000153D8 File Offset: 0x000135D8
		// Note: this type is marked as 'beforefieldinit'.
		static UnsafeValueTypeAttribute()
		{
			Il2CppClassPointerStore<UnsafeValueTypeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "UnsafeValueTypeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeValueTypeAttribute>.NativeClassPtr);
			UnsafeValueTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeValueTypeAttribute>.NativeClassPtr, 100671847);
		}

		// Token: 0x0600395A RID: 14682 RVA: 0x001159A8 File Offset: 0x00113BA8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnsafeValueTypeAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnsafeValueTypeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeValueTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600395B RID: 14683 RVA: 0x00015411 File Offset: 0x00013611
		public UnsafeValueTypeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002E9D RID: 11933
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
