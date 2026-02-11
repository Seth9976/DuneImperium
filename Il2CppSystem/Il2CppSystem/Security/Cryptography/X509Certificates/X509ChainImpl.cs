using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000D5 RID: 213
	public class X509ChainImpl : Object
	{
		// Token: 0x06000E0F RID: 3599 RVA: 0x000511C0 File Offset: 0x0004F3C0
		// Note: this type is marked as 'beforefieldinit'.
		static X509ChainImpl()
		{
			Il2CppClassPointerStore<X509ChainImpl>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509ChainImpl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509ChainImpl>.NativeClassPtr);
			X509ChainImpl.NativeMethodInfoPtr_get_IsValid_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImpl>.NativeClassPtr, 100665347);
			X509ChainImpl.NativeMethodInfoPtr_ThrowIfContextInvalid_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImpl>.NativeClassPtr, 100665348);
			X509ChainImpl.NativeMethodInfoPtr_get_ChainElements_Public_Abstract_Virtual_New_get_X509ChainElementCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImpl>.NativeClassPtr, 100665349);
			X509ChainImpl.NativeMethodInfoPtr_get_ChainPolicy_Public_Abstract_Virtual_New_get_X509ChainPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImpl>.NativeClassPtr, 100665350);
			X509ChainImpl.NativeMethodInfoPtr_get_ChainStatus_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_X509ChainStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImpl>.NativeClassPtr, 100665351);
			X509ChainImpl.NativeMethodInfoPtr_Build_Public_Abstract_Virtual_New_Boolean_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImpl>.NativeClassPtr, 100665352);
			X509ChainImpl.NativeMethodInfoPtr_AddStatus_Public_Abstract_Virtual_New_Void_X509ChainStatusFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImpl>.NativeClassPtr, 100665353);
			X509ChainImpl.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImpl>.NativeClassPtr, 100665354);
			X509ChainImpl.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImpl>.NativeClassPtr, 100665355);
			X509ChainImpl.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImpl>.NativeClassPtr, 100665356);
			X509ChainImpl.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImpl>.NativeClassPtr, 100665357);
			X509ChainImpl.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImpl>.NativeClassPtr, 100665358);
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000E10 RID: 3600 RVA: 0x000512E0 File Offset: 0x0004F4E0
		public unsafe virtual bool IsValid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImpl.NativeMethodInfoPtr_get_IsValid_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x00051328 File Offset: 0x0004F528
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 454659, RefRangeEnd = 454662, XrefRangeStart = 454659, XrefRangeEnd = 454659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfContextInvalid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImpl.NativeMethodInfoPtr_ThrowIfContextInvalid_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000E12 RID: 3602 RVA: 0x0005135C File Offset: 0x0004F55C
		public unsafe virtual X509ChainElementCollection ChainElements
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImpl.NativeMethodInfoPtr_get_ChainElements_Public_Abstract_Virtual_New_get_X509ChainElementCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509ChainElementCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000E13 RID: 3603 RVA: 0x000513A8 File Offset: 0x0004F5A8
		public unsafe virtual X509ChainPolicy ChainPolicy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImpl.NativeMethodInfoPtr_get_ChainPolicy_Public_Abstract_Virtual_New_get_X509ChainPolicy_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509ChainPolicy>(intPtr3) : null;
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000E14 RID: 3604 RVA: 0x000513F4 File Offset: 0x0004F5F4
		public unsafe virtual Il2CppReferenceArray<X509ChainStatus> ChainStatus
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImpl.NativeMethodInfoPtr_get_ChainStatus_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_X509ChainStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<X509ChainStatus>>(intPtr3) : null;
			}
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x00051440 File Offset: 0x0004F640
		[CallerCount(0)]
		public unsafe virtual bool Build(X509Certificate2 certificate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImpl.NativeMethodInfoPtr_Build_Public_Abstract_Virtual_New_Boolean_X509Certificate2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x00051498 File Offset: 0x0004F698
		[CallerCount(0)]
		public unsafe virtual void AddStatus(X509ChainStatusFlags errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errorCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImpl.NativeMethodInfoPtr_AddStatus_Public_Abstract_Virtual_New_Void_X509ChainStatusFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x000514E4 File Offset: 0x0004F6E4
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImpl.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x00051520 File Offset: 0x0004F720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454662, XrefRangeEnd = 454666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImpl.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x00051554 File Offset: 0x0004F754
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImpl.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x000515A0 File Offset: 0x0004F7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454666, XrefRangeEnd = 454669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImpl.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x000515DC File Offset: 0x0004F7DC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ChainImpl()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ChainImpl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImpl.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x00007142 File Offset: 0x00005342
		public X509ChainImpl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B95 RID: 2965
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000B96 RID: 2966
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfContextInvalid_Protected_Void_0;

		// Token: 0x04000B97 RID: 2967
		private static readonly IntPtr NativeMethodInfoPtr_get_ChainElements_Public_Abstract_Virtual_New_get_X509ChainElementCollection_0;

		// Token: 0x04000B98 RID: 2968
		private static readonly IntPtr NativeMethodInfoPtr_get_ChainPolicy_Public_Abstract_Virtual_New_get_X509ChainPolicy_0;

		// Token: 0x04000B99 RID: 2969
		private static readonly IntPtr NativeMethodInfoPtr_get_ChainStatus_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_X509ChainStatus_0;

		// Token: 0x04000B9A RID: 2970
		private static readonly IntPtr NativeMethodInfoPtr_Build_Public_Abstract_Virtual_New_Boolean_X509Certificate2_0;

		// Token: 0x04000B9B RID: 2971
		private static readonly IntPtr NativeMethodInfoPtr_AddStatus_Public_Abstract_Virtual_New_Void_X509ChainStatusFlags_0;

		// Token: 0x04000B9C RID: 2972
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000B9D RID: 2973
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000B9E RID: 2974
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04000B9F RID: 2975
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000BA0 RID: 2976
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
