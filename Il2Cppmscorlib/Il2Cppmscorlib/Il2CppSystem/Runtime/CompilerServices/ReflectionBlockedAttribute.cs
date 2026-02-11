using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003CE RID: 974
	public class ReflectionBlockedAttribute : Attribute
	{
		// Token: 0x0600399D RID: 14749 RVA: 0x000155FC File Offset: 0x000137FC
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionBlockedAttribute()
		{
			Il2CppClassPointerStore<ReflectionBlockedAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "ReflectionBlockedAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionBlockedAttribute>.NativeClassPtr);
			ReflectionBlockedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionBlockedAttribute>.NativeClassPtr, 100671893);
		}

		// Token: 0x0600399E RID: 14750 RVA: 0x001167FC File Offset: 0x001149FC
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionBlockedAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionBlockedAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionBlockedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600399F RID: 14751 RVA: 0x00015635 File Offset: 0x00013835
		public ReflectionBlockedAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002EC2 RID: 11970
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
