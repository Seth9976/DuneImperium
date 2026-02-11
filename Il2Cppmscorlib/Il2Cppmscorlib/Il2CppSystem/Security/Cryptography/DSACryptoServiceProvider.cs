using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Cryptography;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000272 RID: 626
	public sealed class DSACryptoServiceProvider : DSA
	{
		// Token: 0x06002860 RID: 10336 RVA: 0x000D9C28 File Offset: 0x000D7E28
		// Note: this type is marked as 'beforefieldinit'.
		static DSACryptoServiceProvider()
		{
			Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "DSACryptoServiceProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr);
			DSACryptoServiceProvider.NativeFieldInfoPtr_store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, "store");
			DSACryptoServiceProvider.NativeFieldInfoPtr_persistKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, "persistKey");
			DSACryptoServiceProvider.NativeFieldInfoPtr_persisted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, "persisted");
			DSACryptoServiceProvider.NativeFieldInfoPtr_privateKeyExportable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, "privateKeyExportable");
			DSACryptoServiceProvider.NativeFieldInfoPtr_m_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, "m_disposed");
			DSACryptoServiceProvider.NativeFieldInfoPtr_dsa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, "dsa");
			DSACryptoServiceProvider.NativeFieldInfoPtr_useMachineKeyStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, "useMachineKeyStore");
			DSACryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, 100669931);
			DSACryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, 100669932);
			DSACryptoServiceProvider.NativeMethodInfoPtr_Common_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, 100669933);
			DSACryptoServiceProvider.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, 100669934);
			DSACryptoServiceProvider.NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, 100669935);
			DSACryptoServiceProvider.NativeMethodInfoPtr_get_PublicOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, 100669936);
			DSACryptoServiceProvider.NativeMethodInfoPtr_ExportParameters_Public_Virtual_DSAParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, 100669937);
			DSACryptoServiceProvider.NativeMethodInfoPtr_ImportParameters_Public_Virtual_Void_DSAParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, 100669938);
			DSACryptoServiceProvider.NativeMethodInfoPtr_VerifySignature_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, 100669939);
			DSACryptoServiceProvider.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, 100669940);
			DSACryptoServiceProvider.NativeMethodInfoPtr_OnKeyGenerated_Private_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, 100669941);
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x000D9DC0 File Offset: 0x000D7FC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1374772, RefRangeEnd = 1374774, XrefRangeStart = 1374770, XrefRangeEnd = 1374772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DSACryptoServiceProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSACryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x000D9DFC File Offset: 0x000D7FFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1374776, RefRangeEnd = 1374778, XrefRangeStart = 1374774, XrefRangeEnd = 1374776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DSACryptoServiceProvider(int dwKeySize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dwKeySize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSACryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002863 RID: 10339 RVA: 0x000D9E44 File Offset: 0x000D8044
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1374811, RefRangeEnd = 1374814, XrefRangeStart = 1374778, XrefRangeEnd = 1374811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Common(int dwKeySize, bool parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dwKeySize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSACryptoServiceProvider.NativeMethodInfoPtr_Common_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002864 RID: 10340 RVA: 0x000D9E90 File Offset: 0x000D8090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSACryptoServiceProvider.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06002865 RID: 10341 RVA: 0x000D9EC4 File Offset: 0x000D80C4
		public unsafe override int KeySize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1374814, XrefRangeEnd = 1374815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSACryptoServiceProvider.NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06002866 RID: 10342 RVA: 0x000D9F00 File Offset: 0x000D8100
		public unsafe bool PublicOnly
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1374817, RefRangeEnd = 1374818, XrefRangeStart = 1374815, XrefRangeEnd = 1374817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSACryptoServiceProvider.NativeMethodInfoPtr_get_PublicOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x000D9F3C File Offset: 0x000D813C
		[CallerCount(0)]
		public unsafe override DSAParameters ExportParameters(bool includePrivateParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includePrivateParameters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSACryptoServiceProvider.NativeMethodInfoPtr_ExportParameters_Public_Virtual_DSAParameters_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new DSAParameters(intPtr);
			}
		}

		// Token: 0x06002868 RID: 10344 RVA: 0x000D9F80 File Offset: 0x000D8180
		[CallerCount(0)]
		public unsafe override void ImportParameters(DSAParameters parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parameters));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSACryptoServiceProvider.NativeMethodInfoPtr_ImportParameters_Public_Virtual_Void_DSAParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002869 RID: 10345 RVA: 0x000D9FC8 File Offset: 0x000D81C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1374818, XrefRangeEnd = 1374819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool VerifySignature(Il2CppStructArray<byte> rgbHash, Il2CppStructArray<byte> rgbSignature)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbHash);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rgbSignature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSACryptoServiceProvider.NativeMethodInfoPtr_VerifySignature_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600286A RID: 10346 RVA: 0x000DA028 File Offset: 0x000D8228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSACryptoServiceProvider.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600286B RID: 10347 RVA: 0x000DA068 File Offset: 0x000D8268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1374819, XrefRangeEnd = 1374822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnKeyGenerated(Object sender, EventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSACryptoServiceProvider.NativeMethodInfoPtr_OnKeyGenerated_Private_Void_Object_EventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600286C RID: 10348 RVA: 0x0000D437 File Offset: 0x0000B637
		public DSACryptoServiceProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x0600286D RID: 10349 RVA: 0x000DA0BC File Offset: 0x000D82BC
		// (set) Token: 0x0600286E RID: 10350 RVA: 0x0000D440 File Offset: 0x0000B640
		public unsafe KeyPairPersistence store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KeyPairPersistence>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x0600286F RID: 10351 RVA: 0x000DA0EC File Offset: 0x000D82EC
		// (set) Token: 0x06002870 RID: 10352 RVA: 0x0000D45F File Offset: 0x0000B65F
		public unsafe bool persistKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_persistKey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_persistKey)) = value;
			}
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06002871 RID: 10353 RVA: 0x000DA114 File Offset: 0x000D8314
		// (set) Token: 0x06002872 RID: 10354 RVA: 0x0000D47A File Offset: 0x0000B67A
		public unsafe bool persisted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_persisted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_persisted)) = value;
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06002873 RID: 10355 RVA: 0x000DA13C File Offset: 0x000D833C
		// (set) Token: 0x06002874 RID: 10356 RVA: 0x0000D495 File Offset: 0x0000B695
		public unsafe bool privateKeyExportable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_privateKeyExportable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_privateKeyExportable)) = value;
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06002875 RID: 10357 RVA: 0x000DA164 File Offset: 0x000D8364
		// (set) Token: 0x06002876 RID: 10358 RVA: 0x0000D4B0 File Offset: 0x0000B6B0
		public unsafe bool m_disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_m_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_m_disposed)) = value;
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06002877 RID: 10359 RVA: 0x000DA18C File Offset: 0x000D838C
		// (set) Token: 0x06002878 RID: 10360 RVA: 0x0000D4CB File Offset: 0x0000B6CB
		public unsafe DSAManaged dsa
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_dsa);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DSAManaged>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_dsa), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06002879 RID: 10361 RVA: 0x000DA1BC File Offset: 0x000D83BC
		// (set) Token: 0x0600287A RID: 10362 RVA: 0x0000D4EA File Offset: 0x0000B6EA
		public unsafe static bool useMachineKeyStore
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DSACryptoServiceProvider.NativeFieldInfoPtr_useMachineKeyStore, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DSACryptoServiceProvider.NativeFieldInfoPtr_useMachineKeyStore, (void*)(&value));
			}
		}

		// Token: 0x04002290 RID: 8848
		private static readonly IntPtr NativeFieldInfoPtr_store;

		// Token: 0x04002291 RID: 8849
		private static readonly IntPtr NativeFieldInfoPtr_persistKey;

		// Token: 0x04002292 RID: 8850
		private static readonly IntPtr NativeFieldInfoPtr_persisted;

		// Token: 0x04002293 RID: 8851
		private static readonly IntPtr NativeFieldInfoPtr_privateKeyExportable;

		// Token: 0x04002294 RID: 8852
		private static readonly IntPtr NativeFieldInfoPtr_m_disposed;

		// Token: 0x04002295 RID: 8853
		private static readonly IntPtr NativeFieldInfoPtr_dsa;

		// Token: 0x04002296 RID: 8854
		private static readonly IntPtr NativeFieldInfoPtr_useMachineKeyStore;

		// Token: 0x04002297 RID: 8855
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002298 RID: 8856
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04002299 RID: 8857
		private static readonly IntPtr NativeMethodInfoPtr_Common_Private_Void_Int32_Boolean_0;

		// Token: 0x0400229A RID: 8858
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400229B RID: 8859
		private static readonly IntPtr NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0;

		// Token: 0x0400229C RID: 8860
		private static readonly IntPtr NativeMethodInfoPtr_get_PublicOnly_Public_get_Boolean_0;

		// Token: 0x0400229D RID: 8861
		private static readonly IntPtr NativeMethodInfoPtr_ExportParameters_Public_Virtual_DSAParameters_Boolean_0;

		// Token: 0x0400229E RID: 8862
		private static readonly IntPtr NativeMethodInfoPtr_ImportParameters_Public_Virtual_Void_DSAParameters_0;

		// Token: 0x0400229F RID: 8863
		private static readonly IntPtr NativeMethodInfoPtr_VerifySignature_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x040022A0 RID: 8864
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040022A1 RID: 8865
		private static readonly IntPtr NativeMethodInfoPtr_OnKeyGenerated_Private_Void_Object_EventArgs_0;
	}
}
