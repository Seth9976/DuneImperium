using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.iap.store
{
	// Token: 0x0200001C RID: 28
	public class ReceiptInvalid : NetworkMessageEvent
	{
		// Token: 0x060001D6 RID: 470 RVA: 0x00002B6E File Offset: 0x00000D6E
		// Note: this type is marked as 'beforefieldinit'.
		static ReceiptInvalid()
		{
			Il2CppClassPointerStore<ReceiptInvalid>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing.dll", "dwd.iap.store", "ReceiptInvalid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceiptInvalid>.NativeClassPtr);
			ReceiptInvalid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceiptInvalid>.NativeClassPtr, 100663714);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000AA70 File Offset: 0x00008C70
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReceiptInvalid()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReceiptInvalid>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceiptInvalid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002BA7 File Offset: 0x00000DA7
		public ReceiptInvalid(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
