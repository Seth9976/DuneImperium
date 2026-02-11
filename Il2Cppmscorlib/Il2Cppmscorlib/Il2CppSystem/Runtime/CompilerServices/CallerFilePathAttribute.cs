using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003AC RID: 940
	public sealed class CallerFilePathAttribute : Attribute
	{
		// Token: 0x060038E1 RID: 14561 RVA: 0x00014E64 File Offset: 0x00013064
		// Note: this type is marked as 'beforefieldinit'.
		static CallerFilePathAttribute()
		{
			Il2CppClassPointerStore<CallerFilePathAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "CallerFilePathAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallerFilePathAttribute>.NativeClassPtr);
			CallerFilePathAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallerFilePathAttribute>.NativeClassPtr, 100671790);
		}

		// Token: 0x060038E2 RID: 14562 RVA: 0x001146C8 File Offset: 0x001128C8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallerFilePathAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallerFilePathAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallerFilePathAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038E3 RID: 14563 RVA: 0x00014E9D File Offset: 0x0001309D
		public CallerFilePathAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002E69 RID: 11881
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
