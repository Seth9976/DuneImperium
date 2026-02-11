using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001BE RID: 446
	public class SelectFirstChildOnce : MonoBehaviour
	{
		// Token: 0x060013A3 RID: 5027 RVA: 0x00053C74 File Offset: 0x00051E74
		// Note: this type is marked as 'beforefieldinit'.
		static SelectFirstChildOnce()
		{
			Il2CppClassPointerStore<SelectFirstChildOnce>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "SelectFirstChildOnce");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectFirstChildOnce>.NativeClassPtr);
			SelectFirstChildOnce.NativeMethodInfoPtr_OnTransformChildrenChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectFirstChildOnce>.NativeClassPtr, 100665990);
			SelectFirstChildOnce.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectFirstChildOnce>.NativeClassPtr, 100665991);
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x00053CCC File Offset: 0x00051ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713242, XrefRangeEnd = 713254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTransformChildrenChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectFirstChildOnce.NativeMethodInfoPtr_OnTransformChildrenChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x00053D00 File Offset: 0x00051F00
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectFirstChildOnce()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectFirstChildOnce>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectFirstChildOnce.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x0000C1B0 File Offset: 0x0000A3B0
		public SelectFirstChildOnce(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B61 RID: 2913
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformChildrenChanged_Private_Void_0;

		// Token: 0x04000B62 RID: 2914
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
