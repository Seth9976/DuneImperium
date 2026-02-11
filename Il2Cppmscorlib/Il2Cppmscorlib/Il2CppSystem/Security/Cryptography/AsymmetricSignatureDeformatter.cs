using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000235 RID: 565
	public class AsymmetricSignatureDeformatter : Object
	{
		// Token: 0x0600257A RID: 9594 RVA: 0x000CF220 File Offset: 0x000CD420
		// Note: this type is marked as 'beforefieldinit'.
		static AsymmetricSignatureDeformatter()
		{
			Il2CppClassPointerStore<AsymmetricSignatureDeformatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "AsymmetricSignatureDeformatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsymmetricSignatureDeformatter>.NativeClassPtr);
			AsymmetricSignatureDeformatter.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricSignatureDeformatter>.NativeClassPtr, 100669577);
			AsymmetricSignatureDeformatter.NativeMethodInfoPtr_SetKey_Public_Abstract_Virtual_New_Void_AsymmetricAlgorithm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricSignatureDeformatter>.NativeClassPtr, 100669578);
			AsymmetricSignatureDeformatter.NativeMethodInfoPtr_SetHashAlgorithm_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricSignatureDeformatter>.NativeClassPtr, 100669579);
			AsymmetricSignatureDeformatter.NativeMethodInfoPtr_VerifySignature_Public_Abstract_Virtual_New_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricSignatureDeformatter>.NativeClassPtr, 100669580);
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x000CF2A0 File Offset: 0x000CD4A0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsymmetricSignatureDeformatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsymmetricSignatureDeformatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricSignatureDeformatter.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600257C RID: 9596 RVA: 0x000CF2DC File Offset: 0x000CD4DC
		[CallerCount(0)]
		public unsafe virtual void SetKey(AsymmetricAlgorithm key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsymmetricSignatureDeformatter.NativeMethodInfoPtr_SetKey_Public_Abstract_Virtual_New_Void_AsymmetricAlgorithm_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600257D RID: 9597 RVA: 0x000CF32C File Offset: 0x000CD52C
		[CallerCount(0)]
		public unsafe virtual void SetHashAlgorithm(string strName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsymmetricSignatureDeformatter.NativeMethodInfoPtr_SetHashAlgorithm_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600257E RID: 9598 RVA: 0x000CF37C File Offset: 0x000CD57C
		[CallerCount(0)]
		public unsafe virtual bool VerifySignature(Il2CppStructArray<byte> rgbHash, Il2CppStructArray<byte> rgbSignature)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsymmetricSignatureDeformatter.NativeMethodInfoPtr_VerifySignature_Public_Abstract_Virtual_New_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600257F RID: 9599 RVA: 0x0000C1F3 File Offset: 0x0000A3F3
		public AsymmetricSignatureDeformatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002093 RID: 8339
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002094 RID: 8340
		private static readonly IntPtr NativeMethodInfoPtr_SetKey_Public_Abstract_Virtual_New_Void_AsymmetricAlgorithm_0;

		// Token: 0x04002095 RID: 8341
		private static readonly IntPtr NativeMethodInfoPtr_SetHashAlgorithm_Public_Abstract_Virtual_New_Void_String_0;

		// Token: 0x04002096 RID: 8342
		private static readonly IntPtr NativeMethodInfoPtr_VerifySignature_Public_Abstract_Virtual_New_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;
	}
}
