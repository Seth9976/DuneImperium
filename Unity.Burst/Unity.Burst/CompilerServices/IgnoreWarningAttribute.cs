using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Burst.CompilerServices
{
	// Token: 0x02000027 RID: 39
	public class IgnoreWarningAttribute : Attribute
	{
		// Token: 0x0600029A RID: 666 RVA: 0x00002DE0 File Offset: 0x00000FE0
		// Note: this type is marked as 'beforefieldinit'.
		static IgnoreWarningAttribute()
		{
			Il2CppClassPointerStore<IgnoreWarningAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst.CompilerServices", "IgnoreWarningAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IgnoreWarningAttribute>.NativeClassPtr);
			IgnoreWarningAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoreWarningAttribute>.NativeClassPtr, 100666937);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000E144 File Offset: 0x0000C344
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IgnoreWarningAttribute(int warning)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IgnoreWarningAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref warning;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IgnoreWarningAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00002E19 File Offset: 0x00001019
		public IgnoreWarningAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
	}
}
