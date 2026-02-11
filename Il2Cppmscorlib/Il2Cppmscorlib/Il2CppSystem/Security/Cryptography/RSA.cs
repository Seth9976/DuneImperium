using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200025B RID: 603
	public class RSA : AsymmetricAlgorithm
	{
		// Token: 0x06002711 RID: 10001 RVA: 0x000D4D24 File Offset: 0x000D2F24
		// Note: this type is marked as 'beforefieldinit'.
		static RSA()
		{
			Il2CppClassPointerStore<RSA>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RSA");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSA>.NativeClassPtr);
			RSA.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSA>.NativeClassPtr, 100669753);
			RSA.NativeMethodInfoPtr_Create_Public_Static_RSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSA>.NativeClassPtr, 100669754);
			RSA.NativeMethodInfoPtr_DecryptValue_Public_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSA>.NativeClassPtr, 100669755);
			RSA.NativeMethodInfoPtr_EncryptValue_Public_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSA>.NativeClassPtr, 100669756);
			RSA.NativeMethodInfoPtr_FromXmlString_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSA>.NativeClassPtr, 100669757);
			RSA.NativeMethodInfoPtr_ToXmlString_Public_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSA>.NativeClassPtr, 100669758);
			RSA.NativeMethodInfoPtr_ExportParameters_Public_Abstract_Virtual_New_RSAParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSA>.NativeClassPtr, 100669759);
			RSA.NativeMethodInfoPtr_ImportParameters_Public_Abstract_Virtual_New_Void_RSAParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSA>.NativeClassPtr, 100669760);
		}

		// Token: 0x06002712 RID: 10002 RVA: 0x000D4DF4 File Offset: 0x000D2FF4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RSA()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSA>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSA.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002713 RID: 10003 RVA: 0x000D4E30 File Offset: 0x000D3030
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1372916, RefRangeEnd = 1372924, XrefRangeStart = 1372911, XrefRangeEnd = 1372916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RSA Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSA.NativeMethodInfoPtr_Create_Public_Static_RSA_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RSA>(intPtr3) : null;
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x000D4E64 File Offset: 0x000D3064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372924, XrefRangeEnd = 1372931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> DecryptValue(Il2CppStructArray<byte> rgb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RSA.NativeMethodInfoPtr_DecryptValue_Public_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x000D4EC0 File Offset: 0x000D30C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372931, XrefRangeEnd = 1372938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> EncryptValue(Il2CppStructArray<byte> rgb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RSA.NativeMethodInfoPtr_EncryptValue_Public_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x000D4F1C File Offset: 0x000D311C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372938, XrefRangeEnd = 1373008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FromXmlString(string xmlString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RSA.NativeMethodInfoPtr_FromXmlString_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x000D4F6C File Offset: 0x000D316C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373008, XrefRangeEnd = 1373080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToXmlString(bool includePrivateParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includePrivateParameters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RSA.NativeMethodInfoPtr_ToXmlString_Public_Virtual_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x000D4FBC File Offset: 0x000D31BC
		[CallerCount(0)]
		public unsafe virtual RSAParameters ExportParameters(bool includePrivateParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includePrivateParameters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RSA.NativeMethodInfoPtr_ExportParameters_Public_Abstract_Virtual_New_RSAParameters_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new RSAParameters(intPtr);
			}
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x000D500C File Offset: 0x000D320C
		[CallerCount(0)]
		public unsafe virtual void ImportParameters(RSAParameters parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parameters));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RSA.NativeMethodInfoPtr_ImportParameters_Public_Abstract_Virtual_New_Void_RSAParameters_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600271A RID: 10010 RVA: 0x0000CC76 File Offset: 0x0000AE76
		public RSA(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040021AA RID: 8618
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040021AB RID: 8619
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_RSA_0;

		// Token: 0x040021AC RID: 8620
		private static readonly IntPtr NativeMethodInfoPtr_DecryptValue_Public_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x040021AD RID: 8621
		private static readonly IntPtr NativeMethodInfoPtr_EncryptValue_Public_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x040021AE RID: 8622
		private static readonly IntPtr NativeMethodInfoPtr_FromXmlString_Public_Virtual_Void_String_0;

		// Token: 0x040021AF RID: 8623
		private static readonly IntPtr NativeMethodInfoPtr_ToXmlString_Public_Virtual_String_Boolean_0;

		// Token: 0x040021B0 RID: 8624
		private static readonly IntPtr NativeMethodInfoPtr_ExportParameters_Public_Abstract_Virtual_New_RSAParameters_Boolean_0;

		// Token: 0x040021B1 RID: 8625
		private static readonly IntPtr NativeMethodInfoPtr_ImportParameters_Public_Abstract_Virtual_New_Void_RSAParameters_0;
	}
}
