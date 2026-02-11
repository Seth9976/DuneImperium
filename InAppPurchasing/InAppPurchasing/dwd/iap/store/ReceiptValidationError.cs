using System;
using Canis.json.events;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.iap.store
{
	// Token: 0x0200001D RID: 29
	public class ReceiptValidationError : NetworkMessageEvent
	{
		// Token: 0x060001D9 RID: 473 RVA: 0x0000AAAC File Offset: 0x00008CAC
		// Note: this type is marked as 'beforefieldinit'.
		static ReceiptValidationError()
		{
			Il2CppClassPointerStore<ReceiptValidationError>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing.dll", "dwd.iap.store", "ReceiptValidationError");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceiptValidationError>.NativeClassPtr);
			ReceiptValidationError.NativeFieldInfoPtr_Error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceiptValidationError>.NativeClassPtr, "Error");
			ReceiptValidationError.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceiptValidationError>.NativeClassPtr, 100663715);
			ReceiptValidationError.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceiptValidationError>.NativeClassPtr, 100663716);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000AB18 File Offset: 0x00008D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202334, XrefRangeEnd = 1202338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReceiptValidationError.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000AB5C File Offset: 0x00008D5C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReceiptValidationError()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReceiptValidationError>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceiptValidationError.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002BB0 File Offset: 0x00000DB0
		public ReceiptValidationError(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001DD RID: 477 RVA: 0x0000AB98 File Offset: 0x00008D98
		// (set) Token: 0x060001DE RID: 478 RVA: 0x00002BB9 File Offset: 0x00000DB9
		public unsafe LocalizableText Error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceiptValidationError.NativeFieldInfoPtr_Error);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizableText>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceiptValidationError.NativeFieldInfoPtr_Error), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeFieldInfoPtr_Error;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
