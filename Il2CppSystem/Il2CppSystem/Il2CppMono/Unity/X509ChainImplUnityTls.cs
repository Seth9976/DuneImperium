using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Unity
{
	// Token: 0x0200000F RID: 15
	public class X509ChainImplUnityTls : X509ChainImpl
	{
		// Token: 0x0600009F RID: 159 RVA: 0x0001D044 File Offset: 0x0001B244
		// Note: this type is marked as 'beforefieldinit'.
		static X509ChainImplUnityTls()
		{
			Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Unity", "X509ChainImplUnityTls");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr);
			X509ChainImplUnityTls.NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr, "elements");
			X509ChainImplUnityTls.NativeFieldInfoPtr_ownedList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr, "ownedList");
			X509ChainImplUnityTls.NativeFieldInfoPtr_nativeCertificateChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr, "nativeCertificateChain");
			X509ChainImplUnityTls.NativeFieldInfoPtr_policy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr, "policy");
			X509ChainImplUnityTls.NativeFieldInfoPtr_chainStatusList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr, "chainStatusList");
			X509ChainImplUnityTls.NativeFieldInfoPtr_reverseOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr, "reverseOrder");
			X509ChainImplUnityTls.NativeMethodInfoPtr__ctor_Internal_Void_unitytls_x509list_ref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr, 100663453);
			X509ChainImplUnityTls.NativeMethodInfoPtr__ctor_Internal_Void_ptr_unitytls_x509list_ptr_unitytls_errorstate_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr, 100663454);
			X509ChainImplUnityTls.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr, 100663455);
			X509ChainImplUnityTls.NativeMethodInfoPtr_get_NativeCertificateChain_Internal_get_unitytls_x509list_ref_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr, 100663456);
			X509ChainImplUnityTls.NativeMethodInfoPtr_get_ChainElements_Public_Virtual_get_X509ChainElementCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr, 100663457);
			X509ChainImplUnityTls.NativeMethodInfoPtr_AddStatus_Public_Virtual_Void_X509ChainStatusFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr, 100663458);
			X509ChainImplUnityTls.NativeMethodInfoPtr_get_ChainPolicy_Public_Virtual_get_X509ChainPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr, 100663459);
			X509ChainImplUnityTls.NativeMethodInfoPtr_get_ChainStatus_Public_Virtual_get_Il2CppReferenceArray_1_X509ChainStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr, 100663460);
			X509ChainImplUnityTls.NativeMethodInfoPtr_Build_Public_Virtual_Boolean_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr, 100663461);
			X509ChainImplUnityTls.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr, 100663462);
			X509ChainImplUnityTls.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr, 100663463);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0001D1C8 File Offset: 0x0001B3C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427525, XrefRangeEnd = 427532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ChainImplUnityTls(UnityTls.unitytls_x509list_ref nativeCertificateChain, bool reverseOrder = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nativeCertificateChain;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reverseOrder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplUnityTls.NativeMethodInfoPtr__ctor_Internal_Void_unitytls_x509list_ref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0001D220 File Offset: 0x0001B420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427532, XrefRangeEnd = 427540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ChainImplUnityTls(UnityTls.unitytls_x509list* ownedList, UnityTls.unitytls_errorstate* errorState, bool reverseOrder = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ChainImplUnityTls>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ownedList;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reverseOrder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplUnityTls.NativeMethodInfoPtr__ctor_Internal_Void_ptr_unitytls_x509list_ptr_unitytls_errorstate_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0001D284 File Offset: 0x0001B484
		public unsafe override bool IsValid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427540, XrefRangeEnd = 427541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImplUnityTls.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0001D2CC File Offset: 0x0001B4CC
		public unsafe UnityTls.unitytls_x509list_ref NativeCertificateChain
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplUnityTls.NativeMethodInfoPtr_get_NativeCertificateChain_Internal_get_unitytls_x509list_ref_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0001D308 File Offset: 0x0001B508
		public unsafe override X509ChainElementCollection ChainElements
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427541, XrefRangeEnd = 427575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImplUnityTls.NativeMethodInfoPtr_get_ChainElements_Public_Virtual_get_X509ChainElementCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509ChainElementCollection>(intPtr3) : null;
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0001D354 File Offset: 0x0001B554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427575, XrefRangeEnd = 427586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddStatus(X509ChainStatusFlags error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImplUnityTls.NativeMethodInfoPtr_AddStatus_Public_Virtual_Void_X509ChainStatusFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x0001D3A0 File Offset: 0x0001B5A0
		public unsafe override X509ChainPolicy ChainPolicy
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImplUnityTls.NativeMethodInfoPtr_get_ChainPolicy_Public_Virtual_get_X509ChainPolicy_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509ChainPolicy>(intPtr3) : null;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x0001D3EC File Offset: 0x0001B5EC
		public unsafe override Il2CppReferenceArray<X509ChainStatus> ChainStatus
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427586, XrefRangeEnd = 427592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImplUnityTls.NativeMethodInfoPtr_get_ChainStatus_Public_Virtual_get_Il2CppReferenceArray_1_X509ChainStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<X509ChainStatus>>(intPtr3) : null;
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0001D438 File Offset: 0x0001B638
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Build(X509Certificate2 certificate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImplUnityTls.NativeMethodInfoPtr_Build_Public_Virtual_Boolean_X509Certificate2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0001D490 File Offset: 0x0001B690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427592, XrefRangeEnd = 427596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImplUnityTls.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0001D4CC File Offset: 0x0001B6CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427596, XrefRangeEnd = 427597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImplUnityTls.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000023D5 File Offset: 0x000005D5
		public X509ChainImplUnityTls(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0001D518 File Offset: 0x0001B718
		// (set) Token: 0x060000AD RID: 173 RVA: 0x000023DE File Offset: 0x000005DE
		public unsafe X509ChainElementCollection elements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplUnityTls.NativeFieldInfoPtr_elements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509ChainElementCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplUnityTls.NativeFieldInfoPtr_elements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0001D548 File Offset: 0x0001B748
		// (set) Token: 0x060000AF RID: 175 RVA: 0x000023FD File Offset: 0x000005FD
		public unsafe UnityTls.unitytls_x509list* ownedList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplUnityTls.NativeFieldInfoPtr_ownedList);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplUnityTls.NativeFieldInfoPtr_ownedList)) = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x0001D56C File Offset: 0x0001B76C
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00002418 File Offset: 0x00000618
		public unsafe UnityTls.unitytls_x509list_ref nativeCertificateChain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplUnityTls.NativeFieldInfoPtr_nativeCertificateChain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplUnityTls.NativeFieldInfoPtr_nativeCertificateChain)) = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x0001D594 File Offset: 0x0001B794
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x00002433 File Offset: 0x00000633
		public unsafe X509ChainPolicy policy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplUnityTls.NativeFieldInfoPtr_policy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509ChainPolicy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplUnityTls.NativeFieldInfoPtr_policy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x0001D5C4 File Offset: 0x0001B7C4
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x00002452 File Offset: 0x00000652
		public unsafe List<X509ChainStatus> chainStatusList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplUnityTls.NativeFieldInfoPtr_chainStatusList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<X509ChainStatus>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplUnityTls.NativeFieldInfoPtr_chainStatusList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x0001D5F4 File Offset: 0x0001B7F4
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x00002471 File Offset: 0x00000671
		public unsafe bool reverseOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplUnityTls.NativeFieldInfoPtr_reverseOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplUnityTls.NativeFieldInfoPtr_reverseOrder)) = value;
			}
		}

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr_elements;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr_ownedList;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr_nativeCertificateChain;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr_policy;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr_chainStatusList;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_reverseOrder;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_unitytls_x509list_ref_Boolean_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ptr_unitytls_x509list_ptr_unitytls_errorstate_Boolean_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_get_NativeCertificateChain_Internal_get_unitytls_x509list_ref_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_get_ChainElements_Public_Virtual_get_X509ChainElementCollection_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_AddStatus_Public_Virtual_Void_X509ChainStatusFlags_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_get_ChainPolicy_Public_Virtual_get_X509ChainPolicy_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_get_ChainStatus_Public_Virtual_get_Il2CppReferenceArray_1_X509ChainStatus_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_Build_Public_Virtual_Boolean_X509Certificate2_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;
	}
}
