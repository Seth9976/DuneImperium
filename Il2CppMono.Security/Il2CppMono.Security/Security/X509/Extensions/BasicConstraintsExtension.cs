using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppMono.Security.X509.Extensions
{
	// Token: 0x02000016 RID: 22
	public class BasicConstraintsExtension : X509Extension
	{
		// Token: 0x06000190 RID: 400 RVA: 0x0000A3F0 File Offset: 0x000085F0
		// Note: this type is marked as 'beforefieldinit'.
		static BasicConstraintsExtension()
		{
			Il2CppClassPointerStore<BasicConstraintsExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.X509.Extensions", "BasicConstraintsExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicConstraintsExtension>.NativeClassPtr);
			BasicConstraintsExtension.NativeFieldInfoPtr_cA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicConstraintsExtension>.NativeClassPtr, "cA");
			BasicConstraintsExtension.NativeFieldInfoPtr_pathLenConstraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicConstraintsExtension>.NativeClassPtr, "pathLenConstraint");
			BasicConstraintsExtension.NativeMethodInfoPtr__ctor_Public_Void_X509Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicConstraintsExtension>.NativeClassPtr, 100663555);
			BasicConstraintsExtension.NativeMethodInfoPtr_Decode_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicConstraintsExtension>.NativeClassPtr, 100663556);
			BasicConstraintsExtension.NativeMethodInfoPtr_Encode_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicConstraintsExtension>.NativeClassPtr, 100663557);
			BasicConstraintsExtension.NativeMethodInfoPtr_get_CertificateAuthority_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicConstraintsExtension>.NativeClassPtr, 100663558);
			BasicConstraintsExtension.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicConstraintsExtension>.NativeClassPtr, 100663559);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000A4AC File Offset: 0x000086AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1148566, RefRangeEnd = 1148567, XrefRangeStart = 1148566, XrefRangeEnd = 1148567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasicConstraintsExtension(X509Extension extension)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicConstraintsExtension>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extension);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicConstraintsExtension.NativeMethodInfoPtr__ctor_Public_Void_X509Extension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000A4F8 File Offset: 0x000086F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148625, XrefRangeEnd = 1148634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Decode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicConstraintsExtension.NativeMethodInfoPtr_Decode_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000A534 File Offset: 0x00008734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148634, XrefRangeEnd = 1148659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Encode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicConstraintsExtension.NativeMethodInfoPtr_Encode_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000194 RID: 404 RVA: 0x0000A570 File Offset: 0x00008770
		public unsafe bool CertificateAuthority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicConstraintsExtension.NativeMethodInfoPtr_get_CertificateAuthority_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000A5AC File Offset: 0x000087AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148659, XrefRangeEnd = 1148688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicConstraintsExtension.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002A9A File Offset: 0x00000C9A
		public BasicConstraintsExtension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000197 RID: 407 RVA: 0x0000A5F0 File Offset: 0x000087F0
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00002AA3 File Offset: 0x00000CA3
		public unsafe bool cA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicConstraintsExtension.NativeFieldInfoPtr_cA);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicConstraintsExtension.NativeFieldInfoPtr_cA)) = value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000199 RID: 409 RVA: 0x0000A618 File Offset: 0x00008818
		// (set) Token: 0x0600019A RID: 410 RVA: 0x00002ABE File Offset: 0x00000CBE
		public unsafe int pathLenConstraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicConstraintsExtension.NativeFieldInfoPtr_pathLenConstraint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicConstraintsExtension.NativeFieldInfoPtr_pathLenConstraint)) = value;
			}
		}

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeFieldInfoPtr_cA;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeFieldInfoPtr_pathLenConstraint;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_X509Extension_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Protected_Virtual_Void_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Protected_Virtual_Void_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_get_CertificateAuthority_Public_get_Boolean_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
