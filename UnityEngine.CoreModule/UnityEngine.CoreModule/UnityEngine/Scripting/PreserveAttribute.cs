using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Scripting
{
	// Token: 0x020001BA RID: 442
	public class PreserveAttribute : Attribute
	{
		// Token: 0x06002026 RID: 8230 RVA: 0x0000C2DF File Offset: 0x0000A4DF
		// Note: this type is marked as 'beforefieldinit'.
		static PreserveAttribute()
		{
			Il2CppClassPointerStore<PreserveAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Scripting", "PreserveAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreserveAttribute>.NativeClassPtr);
			PreserveAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreserveAttribute>.NativeClassPtr, 100667677);
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x0008F584 File Offset: 0x0008D784
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

		// Token: 0x06002028 RID: 8232 RVA: 0x0000C318 File Offset: 0x0000A518
		public PreserveAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001BBC RID: 7100
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
