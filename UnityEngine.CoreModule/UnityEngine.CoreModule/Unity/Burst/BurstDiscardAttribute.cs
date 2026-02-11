using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Burst
{
	// Token: 0x02000056 RID: 86
	public class BurstDiscardAttribute : Attribute
	{
		// Token: 0x060002E7 RID: 743 RVA: 0x000037E8 File Offset: 0x000019E8
		// Note: this type is marked as 'beforefieldinit'.
		static BurstDiscardAttribute()
		{
			Il2CppClassPointerStore<BurstDiscardAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Burst", "BurstDiscardAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstDiscardAttribute>.NativeClassPtr);
			BurstDiscardAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstDiscardAttribute>.NativeClassPtr, 100663569);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0001E41C File Offset: 0x0001C61C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BurstDiscardAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstDiscardAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstDiscardAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00003821 File Offset: 0x00001A21
		public BurstDiscardAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
