using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000F4 RID: 244
	public class IXmlElement : Il2CppObjectBase
	{
		// Token: 0x06001491 RID: 5265 RVA: 0x00070818 File Offset: 0x0006EA18
		// Note: this type is marked as 'beforefieldinit'.
		static IXmlElement()
		{
			Il2CppClassPointerStore<IXmlElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Converters", "IXmlElement");
			IXmlElement.NativeMethodInfoPtr_SetAttributeNode_Public_Abstract_Virtual_New_Void_IXmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlElement>.NativeClassPtr, 100667205);
			IXmlElement.NativeMethodInfoPtr_GetPrefixOfNamespace_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlElement>.NativeClassPtr, 100667206);
			IXmlElement.NativeMethodInfoPtr_get_IsEmpty_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlElement>.NativeClassPtr, 100667207);
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x0007087C File Offset: 0x0006EA7C
		[CallerCount(0)]
		public unsafe virtual void SetAttributeNode(IXmlNode attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlElement.NativeMethodInfoPtr_SetAttributeNode_Public_Abstract_Virtual_New_Void_IXmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x000708CC File Offset: 0x0006EACC
		[CallerCount(0)]
		public unsafe virtual string GetPrefixOfNamespace(string namespaceUri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlElement.NativeMethodInfoPtr_GetPrefixOfNamespace_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001494 RID: 5268 RVA: 0x00070920 File Offset: 0x0006EB20
		public unsafe virtual bool IsEmpty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlElement.NativeMethodInfoPtr_get_IsEmpty_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x000083F1 File Offset: 0x000065F1
		public IXmlElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010A2 RID: 4258
		private static readonly IntPtr NativeMethodInfoPtr_SetAttributeNode_Public_Abstract_Virtual_New_Void_IXmlNode_0;

		// Token: 0x040010A3 RID: 4259
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefixOfNamespace_Public_Abstract_Virtual_New_String_String_0;

		// Token: 0x040010A4 RID: 4260
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmpty_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
