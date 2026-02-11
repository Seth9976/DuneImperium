using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security.X509
{
	// Token: 0x0200000D RID: 13
	public class X509Chain : Object
	{
		// Token: 0x0600011E RID: 286 RVA: 0x00008B38 File Offset: 0x00006D38
		// Note: this type is marked as 'beforefieldinit'.
		static X509Chain()
		{
			Il2CppClassPointerStore<X509Chain>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.X509", "X509Chain");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Chain>.NativeClassPtr);
			X509Chain.NativeFieldInfoPtr_roots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, "roots");
			X509Chain.NativeFieldInfoPtr_certs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, "certs");
			X509Chain.NativeFieldInfoPtr__root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, "_root");
			X509Chain.NativeFieldInfoPtr__chain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, "_chain");
			X509Chain.NativeFieldInfoPtr__status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, "_status");
			X509Chain.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, 100663483);
			X509Chain.NativeMethodInfoPtr_get_TrustAnchors_Public_get_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, 100663484);
			X509Chain.NativeMethodInfoPtr_LoadCertificates_Public_Void_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, 100663485);
			X509Chain.NativeMethodInfoPtr_Build_Public_Boolean_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, 100663486);
			X509Chain.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, 100663487);
			X509Chain.NativeMethodInfoPtr_IsValid_Private_Boolean_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, 100663488);
			X509Chain.NativeMethodInfoPtr_FindCertificateParent_Private_X509Certificate_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, 100663489);
			X509Chain.NativeMethodInfoPtr_FindCertificateRoot_Private_X509Certificate_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, 100663490);
			X509Chain.NativeMethodInfoPtr_IsTrusted_Private_Boolean_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, 100663491);
			X509Chain.NativeMethodInfoPtr_IsParent_Private_Boolean_X509Certificate_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, 100663492);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00008C94 File Offset: 0x00006E94
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1147848, RefRangeEnd = 1147852, XrefRangeStart = 1147842, XrefRangeEnd = 1147848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Chain()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Chain>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Chain.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00008CD0 File Offset: 0x00006ED0
		public unsafe X509CertificateCollection TrustAnchors
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1147853, RefRangeEnd = 1147857, XrefRangeStart = 1147852, XrefRangeEnd = 1147853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Chain.NativeMethodInfoPtr_get_TrustAnchors_Public_get_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00008D10 File Offset: 0x00006F10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1147859, RefRangeEnd = 1147861, XrefRangeStart = 1147857, XrefRangeEnd = 1147859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadCertificates(X509CertificateCollection collection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Chain.NativeMethodInfoPtr_LoadCertificates_Public_Void_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00008D54 File Offset: 0x00006F54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1147903, RefRangeEnd = 1147905, XrefRangeStart = 1147861, XrefRangeEnd = 1147903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Build(X509Certificate leaf)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(leaf);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Chain.NativeMethodInfoPtr_Build_Public_Boolean_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00008DA4 File Offset: 0x00006FA4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1147908, RefRangeEnd = 1147912, XrefRangeStart = 1147905, XrefRangeEnd = 1147908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Chain.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00008DD8 File Offset: 0x00006FD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1147929, RefRangeEnd = 1147932, XrefRangeStart = 1147912, XrefRangeEnd = 1147929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid(X509Certificate cert)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cert);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Chain.NativeMethodInfoPtr_IsValid_Private_Boolean_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00008E28 File Offset: 0x00007028
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1147947, RefRangeEnd = 1147948, XrefRangeStart = 1147932, XrefRangeEnd = 1147947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate FindCertificateParent(X509Certificate child)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Chain.NativeMethodInfoPtr_FindCertificateParent_Private_X509Certificate_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00008E78 File Offset: 0x00007078
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1147959, RefRangeEnd = 1147960, XrefRangeStart = 1147948, XrefRangeEnd = 1147959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate FindCertificateRoot(X509Certificate potentialRoot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(potentialRoot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Chain.NativeMethodInfoPtr_FindCertificateRoot_Private_X509Certificate_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00008EC8 File Offset: 0x000070C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147960, XrefRangeEnd = 1147962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTrusted(X509Certificate potentialTrusted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(potentialTrusted);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Chain.NativeMethodInfoPtr_IsTrusted_Private_Boolean_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00008F18 File Offset: 0x00007118
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1147973, RefRangeEnd = 1147977, XrefRangeStart = 1147962, XrefRangeEnd = 1147973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsParent(X509Certificate child, X509Certificate parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Chain.NativeMethodInfoPtr_IsParent_Private_Boolean_X509Certificate_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000027AB File Offset: 0x000009AB
		public X509Chain(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00008F78 File Offset: 0x00007178
		// (set) Token: 0x0600012B RID: 299 RVA: 0x000027B4 File Offset: 0x000009B4
		public unsafe X509CertificateCollection roots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Chain.NativeFieldInfoPtr_roots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Chain.NativeFieldInfoPtr_roots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00008FA8 File Offset: 0x000071A8
		// (set) Token: 0x0600012D RID: 301 RVA: 0x000027D3 File Offset: 0x000009D3
		public unsafe X509CertificateCollection certs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Chain.NativeFieldInfoPtr_certs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Chain.NativeFieldInfoPtr_certs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00008FD8 File Offset: 0x000071D8
		// (set) Token: 0x0600012F RID: 303 RVA: 0x000027F2 File Offset: 0x000009F2
		public unsafe X509Certificate _root
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Chain.NativeFieldInfoPtr__root);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Chain.NativeFieldInfoPtr__root), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00009008 File Offset: 0x00007208
		// (set) Token: 0x06000131 RID: 305 RVA: 0x00002811 File Offset: 0x00000A11
		public unsafe X509CertificateCollection _chain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Chain.NativeFieldInfoPtr__chain);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Chain.NativeFieldInfoPtr__chain), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00009038 File Offset: 0x00007238
		// (set) Token: 0x06000133 RID: 307 RVA: 0x00002830 File Offset: 0x00000A30
		public unsafe X509ChainStatusFlags _status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Chain.NativeFieldInfoPtr__status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Chain.NativeFieldInfoPtr__status)) = value;
			}
		}

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeFieldInfoPtr_roots;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeFieldInfoPtr_certs;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeFieldInfoPtr__root;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeFieldInfoPtr__chain;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeFieldInfoPtr__status;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_get_TrustAnchors_Public_get_X509CertificateCollection_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_LoadCertificates_Public_Void_X509CertificateCollection_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_Build_Public_Boolean_X509Certificate_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Private_Boolean_X509Certificate_0;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr_FindCertificateParent_Private_X509Certificate_X509Certificate_0;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr_FindCertificateRoot_Private_X509Certificate_X509Certificate_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_IsTrusted_Private_Boolean_X509Certificate_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_IsParent_Private_Boolean_X509Certificate_X509Certificate_0;
	}
}
