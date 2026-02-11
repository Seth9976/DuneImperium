using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Utils.attributes
{
	// Token: 0x0200003F RID: 63
	public class PreserveAttribute : Attribute
	{
		// Token: 0x0600028C RID: 652 RVA: 0x00002BBC File Offset: 0x00000DBC
		// Note: this type is marked as 'beforefieldinit'.
		static PreserveAttribute()
		{
			Il2CppClassPointerStore<PreserveAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Utils.attributes", "PreserveAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreserveAttribute>.NativeClassPtr);
			PreserveAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreserveAttribute>.NativeClassPtr, 100663906);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000F214 File Offset: 0x0000D414
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

		// Token: 0x0600028E RID: 654 RVA: 0x00002BF5 File Offset: 0x00000DF5
		public PreserveAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
