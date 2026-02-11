using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.iap.store
{
	// Token: 0x0200001B RID: 27
	public class ReceiptAlreadyFulfilled : NetworkMessageEvent
	{
		// Token: 0x060001D3 RID: 467 RVA: 0x00002B2C File Offset: 0x00000D2C
		// Note: this type is marked as 'beforefieldinit'.
		static ReceiptAlreadyFulfilled()
		{
			Il2CppClassPointerStore<ReceiptAlreadyFulfilled>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing.dll", "dwd.iap.store", "ReceiptAlreadyFulfilled");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceiptAlreadyFulfilled>.NativeClassPtr);
			ReceiptAlreadyFulfilled.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceiptAlreadyFulfilled>.NativeClassPtr, 100663713);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000AA34 File Offset: 0x00008C34
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReceiptAlreadyFulfilled()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReceiptAlreadyFulfilled>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceiptAlreadyFulfilled.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002B65 File Offset: 0x00000D65
		public ReceiptAlreadyFulfilled(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
