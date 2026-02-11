using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dwd.iap.store
{
	// Token: 0x0200001A RID: 26
	public class IIAPStoreBehaviour : Il2CppObjectBase
	{
		// Token: 0x060001CD RID: 461 RVA: 0x0000A880 File Offset: 0x00008A80
		// Note: this type is marked as 'beforefieldinit'.
		static IIAPStoreBehaviour()
		{
			Il2CppClassPointerStore<IIAPStoreBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing.dll", "dwd.iap.store", "IIAPStoreBehaviour");
			IIAPStoreBehaviour.NativeMethodInfoPtr_get_Client_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IIAPStoreBehaviour>.NativeClassPtr, 100663709);
			IIAPStoreBehaviour.NativeMethodInfoPtr_get_CommerceURL_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IIAPStoreBehaviour>.NativeClassPtr, 100663710);
			IIAPStoreBehaviour.NativeMethodInfoPtr_get_AnonymousClaimToken_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IIAPStoreBehaviour>.NativeClassPtr, 100663711);
			IIAPStoreBehaviour.NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_IEnumerator_String_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IIAPStoreBehaviour>.NativeClassPtr, 100663712);
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001CE RID: 462 RVA: 0x0000A8F8 File Offset: 0x00008AF8
		public unsafe virtual string Client
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IIAPStoreBehaviour.NativeMethodInfoPtr_get_Client_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001CF RID: 463 RVA: 0x0000A93C File Offset: 0x00008B3C
		public unsafe virtual string CommerceURL
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IIAPStoreBehaviour.NativeMethodInfoPtr_get_CommerceURL_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x0000A980 File Offset: 0x00008B80
		public unsafe virtual string AnonymousClaimToken
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IIAPStoreBehaviour.NativeMethodInfoPtr_get_AnonymousClaimToken_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000A9C4 File Offset: 0x00008BC4
		[CallerCount(0)]
		public unsafe virtual IEnumerator Purchase(string id, Action onPurchase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onPurchase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IIAPStoreBehaviour.NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_IEnumerator_String_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00002B23 File Offset: 0x00000D23
		public IIAPStoreBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_get_Client_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_get_CommerceURL_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_get_AnonymousClaimToken_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_IEnumerator_String_Action_0;
	}
}
