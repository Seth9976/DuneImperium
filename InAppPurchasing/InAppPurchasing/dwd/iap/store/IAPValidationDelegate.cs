using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.iap.store
{
	// Token: 0x02000018 RID: 24
	public class IAPValidationDelegate : Object
	{
		// Token: 0x060001C3 RID: 451 RVA: 0x0000A5D8 File Offset: 0x000087D8
		// Note: this type is marked as 'beforefieldinit'.
		static IAPValidationDelegate()
		{
			Il2CppClassPointerStore<IAPValidationDelegate>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing.dll", "dwd.iap.store", "IAPValidationDelegate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAPValidationDelegate>.NativeClassPtr);
			IAPValidationDelegate.NativeMethodInfoPtr_validatePurchase_Public_Virtual_New_ValidateIAPCommand_IAPProduct_IAPStoreModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPValidationDelegate>.NativeClassPtr, 100663703);
			IAPValidationDelegate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPValidationDelegate>.NativeClassPtr, 100663704);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000A630 File Offset: 0x00008830
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ValidateIAPCommand validatePurchase(IAPProduct product, IAPStoreModel model)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(model);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAPValidationDelegate.NativeMethodInfoPtr_validatePurchase_Public_Virtual_New_ValidateIAPCommand_IAPProduct_IAPStoreModel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValidateIAPCommand>(intPtr3) : null;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000A6A0 File Offset: 0x000088A0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAPValidationDelegate()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPValidationDelegate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPValidationDelegate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002B11 File Offset: 0x00000D11
		public IAPValidationDelegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_validatePurchase_Public_Virtual_New_ValidateIAPCommand_IAPProduct_IAPStoreModel_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
