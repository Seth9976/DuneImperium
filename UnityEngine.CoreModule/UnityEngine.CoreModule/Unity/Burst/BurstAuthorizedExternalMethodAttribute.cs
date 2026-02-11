using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Burst
{
	// Token: 0x02000055 RID: 85
	public class BurstAuthorizedExternalMethodAttribute : Attribute
	{
		// Token: 0x060002E4 RID: 740 RVA: 0x000037A6 File Offset: 0x000019A6
		// Note: this type is marked as 'beforefieldinit'.
		static BurstAuthorizedExternalMethodAttribute()
		{
			Il2CppClassPointerStore<BurstAuthorizedExternalMethodAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Burst", "BurstAuthorizedExternalMethodAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstAuthorizedExternalMethodAttribute>.NativeClassPtr);
			BurstAuthorizedExternalMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstAuthorizedExternalMethodAttribute>.NativeClassPtr, 100663568);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0001E3E0 File Offset: 0x0001C5E0
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BurstAuthorizedExternalMethodAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstAuthorizedExternalMethodAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstAuthorizedExternalMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x000037DF File Offset: 0x000019DF
		public BurstAuthorizedExternalMethodAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
