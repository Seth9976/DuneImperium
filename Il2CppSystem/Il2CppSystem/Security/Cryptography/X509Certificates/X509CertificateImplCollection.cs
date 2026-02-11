using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000D0 RID: 208
	public class X509CertificateImplCollection : Object
	{
		// Token: 0x06000DC7 RID: 3527 RVA: 0x0004FF40 File Offset: 0x0004E140
		// Note: this type is marked as 'beforefieldinit'.
		static X509CertificateImplCollection()
		{
			Il2CppClassPointerStore<X509CertificateImplCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509CertificateImplCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509CertificateImplCollection>.NativeClassPtr);
			X509CertificateImplCollection.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509CertificateImplCollection>.NativeClassPtr, "list");
			X509CertificateImplCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplCollection>.NativeClassPtr, 100665300);
			X509CertificateImplCollection.NativeMethodInfoPtr__ctor_Private_Void_X509CertificateImplCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplCollection>.NativeClassPtr, 100665301);
			X509CertificateImplCollection.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplCollection>.NativeClassPtr, 100665302);
			X509CertificateImplCollection.NativeMethodInfoPtr_get_Item_Public_get_X509CertificateImpl_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplCollection>.NativeClassPtr, 100665303);
			X509CertificateImplCollection.NativeMethodInfoPtr_Add_Public_Void_X509CertificateImpl_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplCollection>.NativeClassPtr, 100665304);
			X509CertificateImplCollection.NativeMethodInfoPtr_Clone_Public_X509CertificateImplCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplCollection>.NativeClassPtr, 100665305);
			X509CertificateImplCollection.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplCollection>.NativeClassPtr, 100665306);
			X509CertificateImplCollection.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplCollection>.NativeClassPtr, 100665307);
			X509CertificateImplCollection.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplCollection>.NativeClassPtr, 100665308);
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00050038 File Offset: 0x0004E238
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 454281, RefRangeEnd = 454282, XrefRangeStart = 454273, XrefRangeEnd = 454281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509CertificateImplCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509CertificateImplCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x00050074 File Offset: 0x0004E274
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 454309, RefRangeEnd = 454312, XrefRangeStart = 454282, XrefRangeEnd = 454309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509CertificateImplCollection(X509CertificateImplCollection other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509CertificateImplCollection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplCollection.NativeMethodInfoPtr__ctor_Private_Void_X509CertificateImplCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000DCA RID: 3530 RVA: 0x000500C0 File Offset: 0x0004E2C0
		public unsafe int Count
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 454313, RefRangeEnd = 454317, XrefRangeStart = 454312, XrefRangeEnd = 454313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplCollection.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000430 RID: 1072
		public unsafe X509CertificateImpl this[int index]
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 454321, RefRangeEnd = 454324, XrefRangeStart = 454317, XrefRangeEnd = 454321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplCollection.NativeMethodInfoPtr_get_Item_Public_get_X509CertificateImpl_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x00050148 File Offset: 0x0004E348
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 454330, RefRangeEnd = 454332, XrefRangeStart = 454324, XrefRangeEnd = 454330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(X509CertificateImpl impl, bool takeOwnership)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(impl);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref takeOwnership;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplCollection.NativeMethodInfoPtr_Add_Public_Void_X509CertificateImpl_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x00050198 File Offset: 0x0004E398
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 454336, RefRangeEnd = 454338, XrefRangeStart = 454332, XrefRangeEnd = 454336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509CertificateImplCollection Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplCollection.NativeMethodInfoPtr_Clone_Public_X509CertificateImplCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImplCollection>(intPtr3) : null;
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x000501D8 File Offset: 0x0004E3D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454338, XrefRangeEnd = 454342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplCollection.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x0005020C File Offset: 0x0004E40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454342, XrefRangeEnd = 454360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImplCollection.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x00050258 File Offset: 0x0004E458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454360, XrefRangeEnd = 454363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImplCollection.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00007021 File Offset: 0x00005221
		public X509CertificateImplCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000DD2 RID: 3538 RVA: 0x00050294 File Offset: 0x0004E494
		// (set) Token: 0x06000DD3 RID: 3539 RVA: 0x0000702A File Offset: 0x0000522A
		public unsafe List<X509CertificateImpl> list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509CertificateImplCollection.NativeFieldInfoPtr_list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<X509CertificateImpl>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509CertificateImplCollection.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B5F RID: 2911
		private static readonly IntPtr NativeFieldInfoPtr_list;

		// Token: 0x04000B60 RID: 2912
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000B61 RID: 2913
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_X509CertificateImplCollection_0;

		// Token: 0x04000B62 RID: 2914
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04000B63 RID: 2915
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_X509CertificateImpl_Int32_0;

		// Token: 0x04000B64 RID: 2916
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_X509CertificateImpl_Boolean_0;

		// Token: 0x04000B65 RID: 2917
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_X509CertificateImplCollection_0;

		// Token: 0x04000B66 RID: 2918
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000B67 RID: 2919
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04000B68 RID: 2920
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
	}
}
