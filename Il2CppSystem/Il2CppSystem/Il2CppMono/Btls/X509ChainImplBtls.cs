using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Btls
{
	// Token: 0x0200004D RID: 77
	public class X509ChainImplBtls : X509ChainImpl
	{
		// Token: 0x0600047A RID: 1146 RVA: 0x0002D528 File Offset: 0x0002B728
		// Note: this type is marked as 'beforefieldinit'.
		static X509ChainImplBtls()
		{
			Il2CppClassPointerStore<X509ChainImplBtls>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "X509ChainImplBtls");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509ChainImplBtls>.NativeClassPtr);
			X509ChainImplBtls.NativeFieldInfoPtr_storeCtx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplBtls>.NativeClassPtr, "storeCtx");
			X509ChainImplBtls.NativeFieldInfoPtr_chain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplBtls>.NativeClassPtr, "chain");
			X509ChainImplBtls.NativeFieldInfoPtr_untrustedChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplBtls>.NativeClassPtr, "untrustedChain");
			X509ChainImplBtls.NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplBtls>.NativeClassPtr, "elements");
			X509ChainImplBtls.NativeFieldInfoPtr_untrusted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplBtls>.NativeClassPtr, "untrusted");
			X509ChainImplBtls.NativeFieldInfoPtr_certificates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplBtls>.NativeClassPtr, "certificates");
			X509ChainImplBtls.NativeFieldInfoPtr_policy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplBtls>.NativeClassPtr, "policy");
			X509ChainImplBtls.NativeFieldInfoPtr_chainStatusList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplBtls>.NativeClassPtr, "chainStatusList");
			X509ChainImplBtls.NativeMethodInfoPtr__ctor_Internal_Void_MonoBtlsX509Chain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplBtls>.NativeClassPtr, 100664113);
			X509ChainImplBtls.NativeMethodInfoPtr__ctor_Internal_Void_MonoBtlsX509StoreCtx_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplBtls>.NativeClassPtr, 100664114);
			X509ChainImplBtls.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplBtls>.NativeClassPtr, 100664115);
			X509ChainImplBtls.NativeMethodInfoPtr_get_StoreCtx_Internal_get_MonoBtlsX509StoreCtx_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplBtls>.NativeClassPtr, 100664116);
			X509ChainImplBtls.NativeMethodInfoPtr_get_ChainElements_Public_Virtual_get_X509ChainElementCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplBtls>.NativeClassPtr, 100664117);
			X509ChainImplBtls.NativeMethodInfoPtr_get_ChainPolicy_Public_Virtual_get_X509ChainPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplBtls>.NativeClassPtr, 100664118);
			X509ChainImplBtls.NativeMethodInfoPtr_get_ChainStatus_Public_Virtual_get_Il2CppReferenceArray_1_X509ChainStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplBtls>.NativeClassPtr, 100664119);
			X509ChainImplBtls.NativeMethodInfoPtr_AddStatus_Public_Virtual_Void_X509ChainStatusFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplBtls>.NativeClassPtr, 100664120);
			X509ChainImplBtls.NativeMethodInfoPtr_Build_Public_Virtual_Boolean_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplBtls>.NativeClassPtr, 100664121);
			X509ChainImplBtls.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplBtls>.NativeClassPtr, 100664122);
			X509ChainImplBtls.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplBtls>.NativeClassPtr, 100664123);
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0002D6D4 File Offset: 0x0002B8D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 432828, RefRangeEnd = 432829, XrefRangeStart = 432805, XrefRangeEnd = 432828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ChainImplBtls(MonoBtlsX509Chain chain)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ChainImplBtls>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chain);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplBtls.NativeMethodInfoPtr__ctor_Internal_Void_MonoBtlsX509Chain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0002D720 File Offset: 0x0002B920
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 432909, RefRangeEnd = 432910, XrefRangeStart = 432829, XrefRangeEnd = 432909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ChainImplBtls(MonoBtlsX509StoreCtx storeCtx)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ChainImplBtls>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(storeCtx);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplBtls.NativeMethodInfoPtr__ctor_Internal_Void_MonoBtlsX509StoreCtx_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x0002D76C File Offset: 0x0002B96C
		public unsafe override bool IsValid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImplBtls.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x0002D7B4 File Offset: 0x0002B9B4
		public unsafe MonoBtlsX509StoreCtx StoreCtx
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432910, XrefRangeEnd = 432911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplBtls.NativeMethodInfoPtr_get_StoreCtx_Internal_get_MonoBtlsX509StoreCtx_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509StoreCtx>(intPtr3) : null;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x0002D7F4 File Offset: 0x0002B9F4
		public unsafe override X509ChainElementCollection ChainElements
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432911, XrefRangeEnd = 432943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImplBtls.NativeMethodInfoPtr_get_ChainElements_Public_Virtual_get_X509ChainElementCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509ChainElementCollection>(intPtr3) : null;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x0002D840 File Offset: 0x0002BA40
		public unsafe override X509ChainPolicy ChainPolicy
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImplBtls.NativeMethodInfoPtr_get_ChainPolicy_Public_Virtual_get_X509ChainPolicy_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509ChainPolicy>(intPtr3) : null;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x0002D88C File Offset: 0x0002BA8C
		public unsafe override Il2CppReferenceArray<X509ChainStatus> ChainStatus
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432943, XrefRangeEnd = 432949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImplBtls.NativeMethodInfoPtr_get_ChainStatus_Public_Virtual_get_Il2CppReferenceArray_1_X509ChainStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<X509ChainStatus>>(intPtr3) : null;
			}
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0002D8D8 File Offset: 0x0002BAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432949, XrefRangeEnd = 432960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddStatus(X509ChainStatusFlags errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errorCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImplBtls.NativeMethodInfoPtr_AddStatus_Public_Virtual_Void_X509ChainStatusFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0002D924 File Offset: 0x0002BB24
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImplBtls.NativeMethodInfoPtr_Build_Public_Virtual_Boolean_X509Certificate2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0002D97C File Offset: 0x0002BB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432960, XrefRangeEnd = 432965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImplBtls.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0002D9B8 File Offset: 0x0002BBB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432965, XrefRangeEnd = 432983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImplBtls.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00003623 File Offset: 0x00001823
		public X509ChainImplBtls(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x0002DA04 File Offset: 0x0002BC04
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x0000362C File Offset: 0x0000182C
		public unsafe MonoBtlsX509StoreCtx storeCtx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplBtls.NativeFieldInfoPtr_storeCtx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509StoreCtx>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplBtls.NativeFieldInfoPtr_storeCtx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x0002DA34 File Offset: 0x0002BC34
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x0000364B File Offset: 0x0000184B
		public unsafe MonoBtlsX509Chain chain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplBtls.NativeFieldInfoPtr_chain);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509Chain>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplBtls.NativeFieldInfoPtr_chain), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x0002DA64 File Offset: 0x0002BC64
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x0000366A File Offset: 0x0000186A
		public unsafe MonoBtlsX509Chain untrustedChain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplBtls.NativeFieldInfoPtr_untrustedChain);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509Chain>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplBtls.NativeFieldInfoPtr_untrustedChain), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x0002DA94 File Offset: 0x0002BC94
		// (set) Token: 0x0600048E RID: 1166 RVA: 0x00003689 File Offset: 0x00001889
		public unsafe X509ChainElementCollection elements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplBtls.NativeFieldInfoPtr_elements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509ChainElementCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplBtls.NativeFieldInfoPtr_elements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x0002DAC4 File Offset: 0x0002BCC4
		// (set) Token: 0x06000490 RID: 1168 RVA: 0x000036A8 File Offset: 0x000018A8
		public unsafe X509Certificate2Collection untrusted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplBtls.NativeFieldInfoPtr_untrusted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate2Collection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplBtls.NativeFieldInfoPtr_untrusted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x0002DAF4 File Offset: 0x0002BCF4
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x000036C7 File Offset: 0x000018C7
		public unsafe Il2CppReferenceArray<X509Certificate2> certificates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplBtls.NativeFieldInfoPtr_certificates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<X509Certificate2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplBtls.NativeFieldInfoPtr_certificates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x0002DB24 File Offset: 0x0002BD24
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x000036E6 File Offset: 0x000018E6
		public unsafe X509ChainPolicy policy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplBtls.NativeFieldInfoPtr_policy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509ChainPolicy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplBtls.NativeFieldInfoPtr_policy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x0002DB54 File Offset: 0x0002BD54
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x00003705 File Offset: 0x00001905
		public unsafe List<X509ChainStatus> chainStatusList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplBtls.NativeFieldInfoPtr_chainStatusList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<X509ChainStatus>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplBtls.NativeFieldInfoPtr_chainStatusList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeFieldInfoPtr_storeCtx;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeFieldInfoPtr_chain;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeFieldInfoPtr_untrustedChain;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeFieldInfoPtr_elements;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeFieldInfoPtr_untrusted;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeFieldInfoPtr_certificates;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeFieldInfoPtr_policy;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeFieldInfoPtr_chainStatusList;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_MonoBtlsX509Chain_0;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_MonoBtlsX509StoreCtx_0;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeMethodInfoPtr_get_StoreCtx_Internal_get_MonoBtlsX509StoreCtx_0;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeMethodInfoPtr_get_ChainElements_Public_Virtual_get_X509ChainElementCollection_0;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeMethodInfoPtr_get_ChainPolicy_Public_Virtual_get_X509ChainPolicy_0;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeMethodInfoPtr_get_ChainStatus_Public_Virtual_get_Il2CppReferenceArray_1_X509ChainStatus_0;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeMethodInfoPtr_AddStatus_Public_Virtual_Void_X509ChainStatusFlags_0;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeMethodInfoPtr_Build_Public_Virtual_Boolean_X509Certificate2_0;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;
	}
}
