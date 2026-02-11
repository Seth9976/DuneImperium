using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000024 RID: 36
	public class IDtdParser : Il2CppObjectBase
	{
		// Token: 0x06000288 RID: 648 RVA: 0x0001FB60 File Offset: 0x0001DD60
		// Note: this type is marked as 'beforefieldinit'.
		static IDtdParser()
		{
			Il2CppClassPointerStore<IDtdParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IDtdParser");
			IDtdParser.NativeMethodInfoPtr_ParseInternalDtd_Public_Abstract_Virtual_New_IDtdInfo_IDtdParserAdapter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParser>.NativeClassPtr, 100663637);
			IDtdParser.NativeMethodInfoPtr_ParseFreeFloatingDtd_Public_Abstract_Virtual_New_IDtdInfo_String_String_String_String_String_IDtdParserAdapter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParser>.NativeClassPtr, 100663638);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
		[CallerCount(0)]
		public unsafe virtual IDtdInfo ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(adapter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref saveInternalSubset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParser.NativeMethodInfoPtr_ParseInternalDtd_Public_Abstract_Virtual_New_IDtdInfo_IDtdParserAdapter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdInfo>(intPtr3) : null;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0001FC1C File Offset: 0x0001DE1C
		[CallerCount(0)]
		public unsafe virtual IDtdInfo ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(docTypeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(publicId);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(systemId);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(internalSubset);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(adapter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParser.NativeMethodInfoPtr_ParseFreeFloatingDtd_Public_Abstract_Virtual_New_IDtdInfo_String_String_String_String_String_IDtdParserAdapter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdInfo>(intPtr3) : null;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00002FBA File Offset: 0x000011BA
		public IDtdParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_ParseInternalDtd_Public_Abstract_Virtual_New_IDtdInfo_IDtdParserAdapter_Boolean_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr_ParseFreeFloatingDtd_Public_Abstract_Virtual_New_IDtdInfo_String_String_String_String_String_IDtdParserAdapter_0;
	}
}
