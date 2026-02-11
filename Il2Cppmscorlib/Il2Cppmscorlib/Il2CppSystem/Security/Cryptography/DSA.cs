using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000242 RID: 578
	public class DSA : AsymmetricAlgorithm
	{
		// Token: 0x060025DE RID: 9694 RVA: 0x000D0824 File Offset: 0x000CEA24
		// Note: this type is marked as 'beforefieldinit'.
		static DSA()
		{
			Il2CppClassPointerStore<DSA>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "DSA");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DSA>.NativeClassPtr);
			DSA.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSA>.NativeClassPtr, 100669621);
			DSA.NativeMethodInfoPtr_Create_Public_Static_DSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSA>.NativeClassPtr, 100669622);
			DSA.NativeMethodInfoPtr_VerifySignature_Public_Abstract_Virtual_New_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSA>.NativeClassPtr, 100669623);
			DSA.NativeMethodInfoPtr_FromXmlString_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSA>.NativeClassPtr, 100669624);
			DSA.NativeMethodInfoPtr_ToXmlString_Public_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSA>.NativeClassPtr, 100669625);
			DSA.NativeMethodInfoPtr_ExportParameters_Public_Abstract_Virtual_New_DSAParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSA>.NativeClassPtr, 100669626);
			DSA.NativeMethodInfoPtr_ImportParameters_Public_Abstract_Virtual_New_Void_DSAParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSA>.NativeClassPtr, 100669627);
		}

		// Token: 0x060025DF RID: 9695 RVA: 0x000D08E0 File Offset: 0x000CEAE0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DSA()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DSA>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSA.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025E0 RID: 9696 RVA: 0x000D091C File Offset: 0x000CEB1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1371825, RefRangeEnd = 1371826, XrefRangeStart = 1371821, XrefRangeEnd = 1371825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DSA Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSA.NativeMethodInfoPtr_Create_Public_Static_DSA_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DSA>(intPtr3) : null;
		}

		// Token: 0x060025E1 RID: 9697 RVA: 0x000D0950 File Offset: 0x000CEB50
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DSA.NativeMethodInfoPtr_VerifySignature_Public_Abstract_Virtual_New_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025E2 RID: 9698 RVA: 0x000D09BC File Offset: 0x000CEBBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371826, XrefRangeEnd = 1371894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FromXmlString(string xmlString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DSA.NativeMethodInfoPtr_FromXmlString_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025E3 RID: 9699 RVA: 0x000D0A0C File Offset: 0x000CEC0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371894, XrefRangeEnd = 1371971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToXmlString(bool includePrivateParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includePrivateParameters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DSA.NativeMethodInfoPtr_ToXmlString_Public_Virtual_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060025E4 RID: 9700 RVA: 0x000D0A5C File Offset: 0x000CEC5C
		[CallerCount(0)]
		public unsafe virtual DSAParameters ExportParameters(bool includePrivateParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includePrivateParameters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DSA.NativeMethodInfoPtr_ExportParameters_Public_Abstract_Virtual_New_DSAParameters_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new DSAParameters(intPtr);
			}
		}

		// Token: 0x060025E5 RID: 9701 RVA: 0x000D0AAC File Offset: 0x000CECAC
		[CallerCount(0)]
		public unsafe virtual void ImportParameters(DSAParameters parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parameters));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DSA.NativeMethodInfoPtr_ImportParameters_Public_Abstract_Virtual_New_Void_DSAParameters_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025E6 RID: 9702 RVA: 0x0000C490 File Offset: 0x0000A690
		public DSA(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040020E6 RID: 8422
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040020E7 RID: 8423
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_DSA_0;

		// Token: 0x040020E8 RID: 8424
		private static readonly IntPtr NativeMethodInfoPtr_VerifySignature_Public_Abstract_Virtual_New_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x040020E9 RID: 8425
		private static readonly IntPtr NativeMethodInfoPtr_FromXmlString_Public_Virtual_Void_String_0;

		// Token: 0x040020EA RID: 8426
		private static readonly IntPtr NativeMethodInfoPtr_ToXmlString_Public_Virtual_String_Boolean_0;

		// Token: 0x040020EB RID: 8427
		private static readonly IntPtr NativeMethodInfoPtr_ExportParameters_Public_Abstract_Virtual_New_DSAParameters_Boolean_0;

		// Token: 0x040020EC RID: 8428
		private static readonly IntPtr NativeMethodInfoPtr_ImportParameters_Public_Abstract_Virtual_New_Void_DSAParameters_0;
	}
}
