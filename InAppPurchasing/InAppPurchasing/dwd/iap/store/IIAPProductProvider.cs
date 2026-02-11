using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.iap.store
{
	// Token: 0x02000019 RID: 25
	public class IIAPProductProvider : Il2CppObjectBase
	{
		// Token: 0x060001C7 RID: 455 RVA: 0x0000A6DC File Offset: 0x000088DC
		// Note: this type is marked as 'beforefieldinit'.
		static IIAPProductProvider()
		{
			Il2CppClassPointerStore<IIAPProductProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing.dll", "dwd.iap.store", "IIAPProductProvider");
			IIAPProductProvider.NativeMethodInfoPtr_get_CommerceURL_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IIAPProductProvider>.NativeClassPtr, 100663705);
			IIAPProductProvider.NativeMethodInfoPtr_get_AnonymousClaimToken_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IIAPProductProvider>.NativeClassPtr, 100663706);
			IIAPProductProvider.NativeMethodInfoPtr_get_Initialized_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IIAPProductProvider>.NativeClassPtr, 100663707);
			IIAPProductProvider.NativeMethodInfoPtr_GetProductsForInitialization_Public_Abstract_Virtual_New_IEnumerable_1_IAPProduct_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IIAPProductProvider>.NativeClassPtr, 100663708);
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x0000A754 File Offset: 0x00008954
		public unsafe virtual string CommerceURL
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IIAPProductProvider.NativeMethodInfoPtr_get_CommerceURL_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x0000A798 File Offset: 0x00008998
		public unsafe virtual string AnonymousClaimToken
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IIAPProductProvider.NativeMethodInfoPtr_get_AnonymousClaimToken_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001CA RID: 458 RVA: 0x0000A7DC File Offset: 0x000089DC
		public unsafe virtual bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IIAPProductProvider.NativeMethodInfoPtr_get_Initialized_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000A824 File Offset: 0x00008A24
		[CallerCount(0)]
		public unsafe virtual IEnumerable<IAPProduct> GetProductsForInitialization(string storeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(storeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IIAPProductProvider.NativeMethodInfoPtr_GetProductsForInitialization_Public_Abstract_Virtual_New_IEnumerable_1_IAPProduct_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAPProduct>>(intPtr3) : null;
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002B1A File Offset: 0x00000D1A
		public IIAPProductProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_get_CommerceURL_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_get_AnonymousClaimToken_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_GetProductsForInitialization_Public_Abstract_Virtual_New_IEnumerable_1_IAPProduct_String_0;
	}
}
