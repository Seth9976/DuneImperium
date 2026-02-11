using System;
using Canis.json.events;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.iap.store
{
	// Token: 0x0200001E RID: 30
	public class FailedToRetrieveAccessToken : NetworkMessageEvent
	{
		// Token: 0x060001DF RID: 479 RVA: 0x0000ABC8 File Offset: 0x00008DC8
		// Note: this type is marked as 'beforefieldinit'.
		static FailedToRetrieveAccessToken()
		{
			Il2CppClassPointerStore<FailedToRetrieveAccessToken>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing.dll", "dwd.iap.store", "FailedToRetrieveAccessToken");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FailedToRetrieveAccessToken>.NativeClassPtr);
			FailedToRetrieveAccessToken.NativeFieldInfoPtr_Error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FailedToRetrieveAccessToken>.NativeClassPtr, "Error");
			FailedToRetrieveAccessToken.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FailedToRetrieveAccessToken>.NativeClassPtr, 100663717);
			FailedToRetrieveAccessToken.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FailedToRetrieveAccessToken>.NativeClassPtr, 100663718);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000AC34 File Offset: 0x00008E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202338, XrefRangeEnd = 1202344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FailedToRetrieveAccessToken.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000AC78 File Offset: 0x00008E78
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FailedToRetrieveAccessToken()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FailedToRetrieveAccessToken>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FailedToRetrieveAccessToken.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002BD8 File Offset: 0x00000DD8
		public FailedToRetrieveAccessToken(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x0000ACB4 File Offset: 0x00008EB4
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x00002BE1 File Offset: 0x00000DE1
		public unsafe LocalizableText Error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FailedToRetrieveAccessToken.NativeFieldInfoPtr_Error);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizableText>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FailedToRetrieveAccessToken.NativeFieldInfoPtr_Error), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeFieldInfoPtr_Error;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
