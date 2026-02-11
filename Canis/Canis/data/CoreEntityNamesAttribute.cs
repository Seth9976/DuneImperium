using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.data
{
	// Token: 0x0200014E RID: 334
	public class CoreEntityNamesAttribute : Attribute
	{
		// Token: 0x06000ECE RID: 3790 RVA: 0x000076C0 File Offset: 0x000058C0
		// Note: this type is marked as 'beforefieldinit'.
		static CoreEntityNamesAttribute()
		{
			Il2CppClassPointerStore<CoreEntityNamesAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.data", "CoreEntityNamesAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoreEntityNamesAttribute>.NativeClassPtr);
			CoreEntityNamesAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreEntityNamesAttribute>.NativeClassPtr, 100666513);
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x00057EB4 File Offset: 0x000560B4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CoreEntityNamesAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoreEntityNamesAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreEntityNamesAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x000076F9 File Offset: 0x000058F9
		public CoreEntityNamesAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009F9 RID: 2553
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
