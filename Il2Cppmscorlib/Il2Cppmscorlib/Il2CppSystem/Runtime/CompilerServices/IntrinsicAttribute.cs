using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003BB RID: 955
	public sealed class IntrinsicAttribute : Attribute
	{
		// Token: 0x06003924 RID: 14628 RVA: 0x00015193 File Offset: 0x00013393
		// Note: this type is marked as 'beforefieldinit'.
		static IntrinsicAttribute()
		{
			Il2CppClassPointerStore<IntrinsicAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "IntrinsicAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntrinsicAttribute>.NativeClassPtr);
			IntrinsicAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntrinsicAttribute>.NativeClassPtr, 100671828);
		}

		// Token: 0x06003925 RID: 14629 RVA: 0x00115130 File Offset: 0x00113330
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntrinsicAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntrinsicAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntrinsicAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003926 RID: 14630 RVA: 0x000151CC File Offset: 0x000133CC
		public IntrinsicAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002E85 RID: 11909
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
