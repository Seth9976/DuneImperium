using System;
using Canis.json.events;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.iap.store
{
	// Token: 0x0200001F RID: 31
	public class OfferRetrievalFailure : NetworkMessageEvent
	{
		// Token: 0x060001E5 RID: 485 RVA: 0x0000ACE4 File Offset: 0x00008EE4
		// Note: this type is marked as 'beforefieldinit'.
		static OfferRetrievalFailure()
		{
			Il2CppClassPointerStore<OfferRetrievalFailure>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing.dll", "dwd.iap.store", "OfferRetrievalFailure");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OfferRetrievalFailure>.NativeClassPtr);
			OfferRetrievalFailure.NativeFieldInfoPtr_Error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfferRetrievalFailure>.NativeClassPtr, "Error");
			OfferRetrievalFailure.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfferRetrievalFailure>.NativeClassPtr, 100663719);
			OfferRetrievalFailure.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfferRetrievalFailure>.NativeClassPtr, 100663720);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000AD50 File Offset: 0x00008F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202344, XrefRangeEnd = 1202350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OfferRetrievalFailure.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000AD94 File Offset: 0x00008F94
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OfferRetrievalFailure()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OfferRetrievalFailure>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfferRetrievalFailure.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002C00 File Offset: 0x00000E00
		public OfferRetrievalFailure(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x0000ADD0 File Offset: 0x00008FD0
		// (set) Token: 0x060001EA RID: 490 RVA: 0x00002C09 File Offset: 0x00000E09
		public unsafe LocalizableText Error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfferRetrievalFailure.NativeFieldInfoPtr_Error);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizableText>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfferRetrievalFailure.NativeFieldInfoPtr_Error), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeFieldInfoPtr_Error;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
