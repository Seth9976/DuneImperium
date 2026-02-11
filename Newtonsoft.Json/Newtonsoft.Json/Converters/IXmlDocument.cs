using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000F1 RID: 241
	public class IXmlDocument : Il2CppObjectBase
	{
		// Token: 0x06001475 RID: 5237 RVA: 0x0006FE14 File Offset: 0x0006E014
		// Note: this type is marked as 'beforefieldinit'.
		static IXmlDocument()
		{
			Il2CppClassPointerStore<IXmlDocument>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Converters", "IXmlDocument");
			IXmlDocument.NativeMethodInfoPtr_CreateComment_Public_Abstract_Virtual_New_IXmlNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlDocument>.NativeClassPtr, 100667183);
			IXmlDocument.NativeMethodInfoPtr_CreateTextNode_Public_Abstract_Virtual_New_IXmlNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlDocument>.NativeClassPtr, 100667184);
			IXmlDocument.NativeMethodInfoPtr_CreateCDataSection_Public_Abstract_Virtual_New_IXmlNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlDocument>.NativeClassPtr, 100667185);
			IXmlDocument.NativeMethodInfoPtr_CreateWhitespace_Public_Abstract_Virtual_New_IXmlNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlDocument>.NativeClassPtr, 100667186);
			IXmlDocument.NativeMethodInfoPtr_CreateSignificantWhitespace_Public_Abstract_Virtual_New_IXmlNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlDocument>.NativeClassPtr, 100667187);
			IXmlDocument.NativeMethodInfoPtr_CreateXmlDeclaration_Public_Abstract_Virtual_New_IXmlNode_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlDocument>.NativeClassPtr, 100667188);
			IXmlDocument.NativeMethodInfoPtr_CreateXmlDocumentType_Public_Abstract_Virtual_New_IXmlNode_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlDocument>.NativeClassPtr, 100667189);
			IXmlDocument.NativeMethodInfoPtr_CreateProcessingInstruction_Public_Abstract_Virtual_New_IXmlNode_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlDocument>.NativeClassPtr, 100667190);
			IXmlDocument.NativeMethodInfoPtr_CreateElement_Public_Abstract_Virtual_New_IXmlElement_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlDocument>.NativeClassPtr, 100667191);
			IXmlDocument.NativeMethodInfoPtr_CreateElement_Public_Abstract_Virtual_New_IXmlElement_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlDocument>.NativeClassPtr, 100667192);
			IXmlDocument.NativeMethodInfoPtr_CreateAttribute_Public_Abstract_Virtual_New_IXmlNode_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlDocument>.NativeClassPtr, 100667193);
			IXmlDocument.NativeMethodInfoPtr_CreateAttribute_Public_Abstract_Virtual_New_IXmlNode_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlDocument>.NativeClassPtr, 100667194);
			IXmlDocument.NativeMethodInfoPtr_get_DocumentElement_Public_Abstract_Virtual_New_get_IXmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlDocument>.NativeClassPtr, 100667195);
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x0006FF40 File Offset: 0x0006E140
		[CallerCount(0)]
		public unsafe virtual IXmlNode CreateComment(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlDocument.NativeMethodInfoPtr_CreateComment_Public_Abstract_Virtual_New_IXmlNode_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x0006FF9C File Offset: 0x0006E19C
		[CallerCount(0)]
		public unsafe virtual IXmlNode CreateTextNode(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlDocument.NativeMethodInfoPtr_CreateTextNode_Public_Abstract_Virtual_New_IXmlNode_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x0006FFF8 File Offset: 0x0006E1F8
		[CallerCount(0)]
		public unsafe virtual IXmlNode CreateCDataSection(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlDocument.NativeMethodInfoPtr_CreateCDataSection_Public_Abstract_Virtual_New_IXmlNode_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x00070054 File Offset: 0x0006E254
		[CallerCount(0)]
		public unsafe virtual IXmlNode CreateWhitespace(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlDocument.NativeMethodInfoPtr_CreateWhitespace_Public_Abstract_Virtual_New_IXmlNode_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x000700B0 File Offset: 0x0006E2B0
		[CallerCount(0)]
		public unsafe virtual IXmlNode CreateSignificantWhitespace(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlDocument.NativeMethodInfoPtr_CreateSignificantWhitespace_Public_Abstract_Virtual_New_IXmlNode_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x0007010C File Offset: 0x0006E30C
		[CallerCount(0)]
		public unsafe virtual IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(version);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(encoding);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(standalone);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlDocument.NativeMethodInfoPtr_CreateXmlDeclaration_Public_Abstract_Virtual_New_IXmlNode_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x0007018C File Offset: 0x0006E38C
		[CallerCount(0)]
		public unsafe virtual IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(publicId);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(systemId);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(internalSubset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlDocument.NativeMethodInfoPtr_CreateXmlDocumentType_Public_Abstract_Virtual_New_IXmlNode_String_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x00070220 File Offset: 0x0006E420
		[CallerCount(0)]
		public unsafe virtual IXmlNode CreateProcessingInstruction(string target, string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlDocument.NativeMethodInfoPtr_CreateProcessingInstruction_Public_Abstract_Virtual_New_IXmlNode_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x00070290 File Offset: 0x0006E490
		[CallerCount(0)]
		public unsafe virtual IXmlElement CreateElement(string elementName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(elementName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlDocument.NativeMethodInfoPtr_CreateElement_Public_Abstract_Virtual_New_IXmlElement_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlElement>(intPtr3) : null;
			}
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x000702EC File Offset: 0x0006E4EC
		[CallerCount(0)]
		public unsafe virtual IXmlElement CreateElement(string qualifiedName, string namespaceUri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(qualifiedName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlDocument.NativeMethodInfoPtr_CreateElement_Public_Abstract_Virtual_New_IXmlElement_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlElement>(intPtr3) : null;
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x0007035C File Offset: 0x0006E55C
		[CallerCount(0)]
		public unsafe virtual IXmlNode CreateAttribute(string name, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlDocument.NativeMethodInfoPtr_CreateAttribute_Public_Abstract_Virtual_New_IXmlNode_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x000703CC File Offset: 0x0006E5CC
		[CallerCount(0)]
		public unsafe virtual IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(qualifiedName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceUri);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlDocument.NativeMethodInfoPtr_CreateAttribute_Public_Abstract_Virtual_New_IXmlNode_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001482 RID: 5250 RVA: 0x0007044C File Offset: 0x0006E64C
		public unsafe virtual IXmlElement DocumentElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlDocument.NativeMethodInfoPtr_get_DocumentElement_Public_Abstract_Virtual_New_get_IXmlElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlElement>(intPtr3) : null;
			}
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x000083D6 File Offset: 0x000065D6
		public IXmlDocument(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400108C RID: 4236
		private static readonly IntPtr NativeMethodInfoPtr_CreateComment_Public_Abstract_Virtual_New_IXmlNode_String_0;

		// Token: 0x0400108D RID: 4237
		private static readonly IntPtr NativeMethodInfoPtr_CreateTextNode_Public_Abstract_Virtual_New_IXmlNode_String_0;

		// Token: 0x0400108E RID: 4238
		private static readonly IntPtr NativeMethodInfoPtr_CreateCDataSection_Public_Abstract_Virtual_New_IXmlNode_String_0;

		// Token: 0x0400108F RID: 4239
		private static readonly IntPtr NativeMethodInfoPtr_CreateWhitespace_Public_Abstract_Virtual_New_IXmlNode_String_0;

		// Token: 0x04001090 RID: 4240
		private static readonly IntPtr NativeMethodInfoPtr_CreateSignificantWhitespace_Public_Abstract_Virtual_New_IXmlNode_String_0;

		// Token: 0x04001091 RID: 4241
		private static readonly IntPtr NativeMethodInfoPtr_CreateXmlDeclaration_Public_Abstract_Virtual_New_IXmlNode_String_String_String_0;

		// Token: 0x04001092 RID: 4242
		private static readonly IntPtr NativeMethodInfoPtr_CreateXmlDocumentType_Public_Abstract_Virtual_New_IXmlNode_String_String_String_String_0;

		// Token: 0x04001093 RID: 4243
		private static readonly IntPtr NativeMethodInfoPtr_CreateProcessingInstruction_Public_Abstract_Virtual_New_IXmlNode_String_String_0;

		// Token: 0x04001094 RID: 4244
		private static readonly IntPtr NativeMethodInfoPtr_CreateElement_Public_Abstract_Virtual_New_IXmlElement_String_0;

		// Token: 0x04001095 RID: 4245
		private static readonly IntPtr NativeMethodInfoPtr_CreateElement_Public_Abstract_Virtual_New_IXmlElement_String_String_0;

		// Token: 0x04001096 RID: 4246
		private static readonly IntPtr NativeMethodInfoPtr_CreateAttribute_Public_Abstract_Virtual_New_IXmlNode_String_String_0;

		// Token: 0x04001097 RID: 4247
		private static readonly IntPtr NativeMethodInfoPtr_CreateAttribute_Public_Abstract_Virtual_New_IXmlNode_String_String_String_0;

		// Token: 0x04001098 RID: 4248
		private static readonly IntPtr NativeMethodInfoPtr_get_DocumentElement_Public_Abstract_Virtual_New_get_IXmlElement_0;
	}
}
