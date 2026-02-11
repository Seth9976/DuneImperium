using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000084 RID: 132
	public class IXmlNamespaceResolver : Il2CppObjectBase
	{
		// Token: 0x06000F65 RID: 3941 RVA: 0x00059790 File Offset: 0x00057990
		// Note: this type is marked as 'beforefieldinit'.
		static IXmlNamespaceResolver()
		{
			Il2CppClassPointerStore<IXmlNamespaceResolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IXmlNamespaceResolver");
			IXmlNamespaceResolver.NativeMethodInfoPtr_GetNamespacesInScope_Public_Abstract_Virtual_New_IDictionary_2_String_String_XmlNamespaceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlNamespaceResolver>.NativeClassPtr, 100665832);
			IXmlNamespaceResolver.NativeMethodInfoPtr_LookupNamespace_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlNamespaceResolver>.NativeClassPtr, 100665833);
			IXmlNamespaceResolver.NativeMethodInfoPtr_LookupPrefix_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlNamespaceResolver>.NativeClassPtr, 100665834);
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x000597F4 File Offset: 0x000579F4
		[CallerCount(0)]
		public unsafe virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scope;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlNamespaceResolver.NativeMethodInfoPtr_GetNamespacesInScope_Public_Abstract_Virtual_New_IDictionary_2_String_String_XmlNamespaceScope_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x0005984C File Offset: 0x00057A4C
		[CallerCount(0)]
		public unsafe virtual string LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlNamespaceResolver.NativeMethodInfoPtr_LookupNamespace_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x000598A0 File Offset: 0x00057AA0
		[CallerCount(0)]
		public unsafe virtual string LookupPrefix(string namespaceName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlNamespaceResolver.NativeMethodInfoPtr_LookupPrefix_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x00006FC5 File Offset: 0x000051C5
		public IXmlNamespaceResolver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C80 RID: 3200
		private static readonly IntPtr NativeMethodInfoPtr_GetNamespacesInScope_Public_Abstract_Virtual_New_IDictionary_2_String_String_XmlNamespaceScope_0;

		// Token: 0x04000C81 RID: 3201
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Public_Abstract_Virtual_New_String_String_0;

		// Token: 0x04000C82 RID: 3202
		private static readonly IntPtr NativeMethodInfoPtr_LookupPrefix_Public_Abstract_Virtual_New_String_String_0;
	}
}
