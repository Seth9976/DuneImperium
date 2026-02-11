using System;
using Canis.json.events;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.iap.store
{
	// Token: 0x02000020 RID: 32
	public class PurchaseFailure : NetworkMessageEvent
	{
		// Token: 0x060001EB RID: 491 RVA: 0x0000AE00 File Offset: 0x00009000
		// Note: this type is marked as 'beforefieldinit'.
		static PurchaseFailure()
		{
			Il2CppClassPointerStore<PurchaseFailure>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing.dll", "dwd.iap.store", "PurchaseFailure");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PurchaseFailure>.NativeClassPtr);
			PurchaseFailure.NativeFieldInfoPtr_Error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchaseFailure>.NativeClassPtr, "Error");
			PurchaseFailure.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseFailure>.NativeClassPtr, 100663721);
			PurchaseFailure.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseFailure>.NativeClassPtr, 100663722);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000AE6C File Offset: 0x0000906C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202350, XrefRangeEnd = 1202356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PurchaseFailure.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000AEB0 File Offset: 0x000090B0
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PurchaseFailure()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PurchaseFailure>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseFailure.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00002C28 File Offset: 0x00000E28
		public PurchaseFailure(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001EF RID: 495 RVA: 0x0000AEEC File Offset: 0x000090EC
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x00002C31 File Offset: 0x00000E31
		public unsafe LocalizableText Error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseFailure.NativeFieldInfoPtr_Error);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizableText>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseFailure.NativeFieldInfoPtr_Error), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeFieldInfoPtr_Error;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
