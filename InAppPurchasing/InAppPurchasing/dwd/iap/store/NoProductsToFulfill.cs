using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.iap.store
{
	// Token: 0x02000021 RID: 33
	public class NoProductsToFulfill : NetworkMessageEvent
	{
		// Token: 0x060001F1 RID: 497 RVA: 0x00002C50 File Offset: 0x00000E50
		// Note: this type is marked as 'beforefieldinit'.
		static NoProductsToFulfill()
		{
			Il2CppClassPointerStore<NoProductsToFulfill>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing.dll", "dwd.iap.store", "NoProductsToFulfill");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoProductsToFulfill>.NativeClassPtr);
			NoProductsToFulfill.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoProductsToFulfill>.NativeClassPtr, 100663723);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000AF1C File Offset: 0x0000911C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoProductsToFulfill()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoProductsToFulfill>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoProductsToFulfill.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002C89 File Offset: 0x00000E89
		public NoProductsToFulfill(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
