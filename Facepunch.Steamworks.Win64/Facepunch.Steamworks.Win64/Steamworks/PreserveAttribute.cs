using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020000C5 RID: 197
	public class PreserveAttribute : Attribute
	{
		// Token: 0x06000C9F RID: 3231 RVA: 0x0000324E File Offset: 0x0000144E
		// Note: this type is marked as 'beforefieldinit'.
		static PreserveAttribute()
		{
			Il2CppClassPointerStore<PreserveAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "PreserveAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreserveAttribute>.NativeClassPtr);
			PreserveAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreserveAttribute>.NativeClassPtr, 100666398);
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x0005346C File Offset: 0x0005166C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PreserveAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreserveAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreserveAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x00003287 File Offset: 0x00001487
		public PreserveAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001328 RID: 4904
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
