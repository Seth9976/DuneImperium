using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000ED RID: 237
	public class XmlElementWrapper : XmlNodeWrapper
	{
		// Token: 0x06001443 RID: 5187 RVA: 0x0006F1CC File Offset: 0x0006D3CC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlElementWrapper()
		{
			Il2CppClassPointerStore<XmlElementWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Converters", "XmlElementWrapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlElementWrapper>.NativeClassPtr);
			XmlElementWrapper.NativeFieldInfoPtr__element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlElementWrapper>.NativeClassPtr, "_element");
			XmlElementWrapper.NativeMethodInfoPtr__ctor_Public_Void_XmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementWrapper>.NativeClassPtr, 100667153);
			XmlElementWrapper.NativeMethodInfoPtr_SetAttributeNode_Public_Virtual_Final_New_Void_IXmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementWrapper>.NativeClassPtr, 100667154);
			XmlElementWrapper.NativeMethodInfoPtr_GetPrefixOfNamespace_Public_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementWrapper>.NativeClassPtr, 100667155);
			XmlElementWrapper.NativeMethodInfoPtr_get_IsEmpty_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementWrapper>.NativeClassPtr, 100667156);
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x0006F260 File Offset: 0x0006D460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlElementWrapper(XmlElement element)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlElementWrapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElementWrapper.NativeMethodInfoPtr__ctor_Public_Void_XmlElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x0006F2AC File Offset: 0x0006D4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765135, XrefRangeEnd = 765142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetAttributeNode(IXmlNode attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElementWrapper.NativeMethodInfoPtr_SetAttributeNode_Public_Virtual_Final_New_Void_IXmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x0006F2F0 File Offset: 0x0006D4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765142, XrefRangeEnd = 765143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetPrefixOfNamespace(string namespaceUri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElementWrapper.NativeMethodInfoPtr_GetPrefixOfNamespace_Public_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001447 RID: 5191 RVA: 0x0006F338 File Offset: 0x0006D538
		public unsafe virtual bool IsEmpty
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765143, XrefRangeEnd = 765145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElementWrapper.NativeMethodInfoPtr_get_IsEmpty_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x000082F8 File Offset: 0x000064F8
		public XmlElementWrapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001449 RID: 5193 RVA: 0x0006F374 File Offset: 0x0006D574
		// (set) Token: 0x0600144A RID: 5194 RVA: 0x00008301 File Offset: 0x00006501
		public unsafe XmlElement _element
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElementWrapper.NativeFieldInfoPtr__element);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElementWrapper.NativeFieldInfoPtr__element), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001068 RID: 4200
		private static readonly IntPtr NativeFieldInfoPtr__element;

		// Token: 0x04001069 RID: 4201
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlElement_0;

		// Token: 0x0400106A RID: 4202
		private static readonly IntPtr NativeMethodInfoPtr_SetAttributeNode_Public_Virtual_Final_New_Void_IXmlNode_0;

		// Token: 0x0400106B RID: 4203
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefixOfNamespace_Public_Virtual_Final_New_String_String_0;

		// Token: 0x0400106C RID: 4204
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmpty_Public_Virtual_Final_New_get_Boolean_0;
	}
}
