using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppMono.Security.X509.Extensions
{
	// Token: 0x02000015 RID: 21
	public class AuthorityKeyIdentifierExtension : X509Extension
	{
		// Token: 0x06000187 RID: 391 RVA: 0x0000A1D0 File Offset: 0x000083D0
		// Note: this type is marked as 'beforefieldinit'.
		static AuthorityKeyIdentifierExtension()
		{
			Il2CppClassPointerStore<AuthorityKeyIdentifierExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.X509.Extensions", "AuthorityKeyIdentifierExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthorityKeyIdentifierExtension>.NativeClassPtr);
			AuthorityKeyIdentifierExtension.NativeFieldInfoPtr_aki = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorityKeyIdentifierExtension>.NativeClassPtr, "aki");
			AuthorityKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_X509Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorityKeyIdentifierExtension>.NativeClassPtr, 100663550);
			AuthorityKeyIdentifierExtension.NativeMethodInfoPtr_Decode_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorityKeyIdentifierExtension>.NativeClassPtr, 100663551);
			AuthorityKeyIdentifierExtension.NativeMethodInfoPtr_Encode_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorityKeyIdentifierExtension>.NativeClassPtr, 100663552);
			AuthorityKeyIdentifierExtension.NativeMethodInfoPtr_get_Identifier_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorityKeyIdentifierExtension>.NativeClassPtr, 100663553);
			AuthorityKeyIdentifierExtension.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorityKeyIdentifierExtension>.NativeClassPtr, 100663554);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000A278 File Offset: 0x00008478
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1148566, RefRangeEnd = 1148567, XrefRangeStart = 1148565, XrefRangeEnd = 1148566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AuthorityKeyIdentifierExtension(X509Extension extension)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthorityKeyIdentifierExtension>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extension);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorityKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_X509Extension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000A2C4 File Offset: 0x000084C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148567, XrefRangeEnd = 1148577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Decode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AuthorityKeyIdentifierExtension.NativeMethodInfoPtr_Decode_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000A300 File Offset: 0x00008500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148577, XrefRangeEnd = 1148600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Encode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AuthorityKeyIdentifierExtension.NativeMethodInfoPtr_Encode_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0000A33C File Offset: 0x0000853C
		public unsafe Il2CppStructArray<byte> Identifier
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1148603, RefRangeEnd = 1148604, XrefRangeStart = 1148600, XrefRangeEnd = 1148603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorityKeyIdentifierExtension.NativeMethodInfoPtr_get_Identifier_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000A37C File Offset: 0x0000857C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148604, XrefRangeEnd = 1148625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AuthorityKeyIdentifierExtension.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002A72 File Offset: 0x00000C72
		public AuthorityKeyIdentifierExtension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600018E RID: 398 RVA: 0x0000A3C0 File Offset: 0x000085C0
		// (set) Token: 0x0600018F RID: 399 RVA: 0x00002A7B File Offset: 0x00000C7B
		public unsafe Il2CppStructArray<byte> aki
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorityKeyIdentifierExtension.NativeFieldInfoPtr_aki);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorityKeyIdentifierExtension.NativeFieldInfoPtr_aki), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeFieldInfoPtr_aki;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_X509Extension_0;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Protected_Virtual_Void_0;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Protected_Virtual_Void_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_get_Identifier_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
