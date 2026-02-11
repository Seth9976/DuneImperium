using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000FE RID: 254
	public class XAttributeWrapper : XObjectWrapper
	{
		// Token: 0x060014FB RID: 5371 RVA: 0x00072810 File Offset: 0x00070A10
		// Note: this type is marked as 'beforefieldinit'.
		static XAttributeWrapper()
		{
			Il2CppClassPointerStore<XAttributeWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Converters", "XAttributeWrapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XAttributeWrapper>.NativeClassPtr);
			XAttributeWrapper.NativeMethodInfoPtr_get_Attribute_Private_get_XAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XAttributeWrapper>.NativeClassPtr, 100667283);
			XAttributeWrapper.NativeMethodInfoPtr__ctor_Public_Void_XAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XAttributeWrapper>.NativeClassPtr, 100667284);
			XAttributeWrapper.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XAttributeWrapper>.NativeClassPtr, 100667285);
			XAttributeWrapper.NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XAttributeWrapper>.NativeClassPtr, 100667286);
			XAttributeWrapper.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XAttributeWrapper>.NativeClassPtr, 100667287);
			XAttributeWrapper.NativeMethodInfoPtr_get_NamespaceUri_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XAttributeWrapper>.NativeClassPtr, 100667288);
			XAttributeWrapper.NativeMethodInfoPtr_get_ParentNode_Public_Virtual_get_IXmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XAttributeWrapper>.NativeClassPtr, 100667289);
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x060014FC RID: 5372 RVA: 0x000728CC File Offset: 0x00070ACC
		public unsafe XAttribute Attribute
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 765618, RefRangeEnd = 765619, XrefRangeStart = 765616, XrefRangeEnd = 765618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XAttributeWrapper.NativeMethodInfoPtr_get_Attribute_Private_get_XAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x0007290C File Offset: 0x00070B0C
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XAttributeWrapper(XAttribute attribute)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XAttributeWrapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XAttributeWrapper.NativeMethodInfoPtr__ctor_Public_Void_XAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x060014FE RID: 5374 RVA: 0x00072958 File Offset: 0x00070B58
		// (set) Token: 0x060014FF RID: 5375 RVA: 0x0007299C File Offset: 0x00070B9C
		public unsafe override string Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765619, XrefRangeEnd = 765621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XAttributeWrapper.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765621, XrefRangeEnd = 765628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XAttributeWrapper.NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001500 RID: 5376 RVA: 0x000729EC File Offset: 0x00070BEC
		public unsafe override string LocalName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765628, XrefRangeEnd = 765630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XAttributeWrapper.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06001501 RID: 5377 RVA: 0x00072A30 File Offset: 0x00070C30
		public unsafe override string NamespaceUri
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765630, XrefRangeEnd = 765635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XAttributeWrapper.NativeMethodInfoPtr_get_NamespaceUri_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001502 RID: 5378 RVA: 0x00072A74 File Offset: 0x00070C74
		public unsafe override IXmlNode ParentNode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765635, XrefRangeEnd = 765641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XAttributeWrapper.NativeMethodInfoPtr_get_ParentNode_Public_Virtual_get_IXmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x000084C7 File Offset: 0x000066C7
		public XAttributeWrapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010F4 RID: 4340
		private static readonly IntPtr NativeMethodInfoPtr_get_Attribute_Private_get_XAttribute_0;

		// Token: 0x040010F5 RID: 4341
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XAttribute_0;

		// Token: 0x040010F6 RID: 4342
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0;

		// Token: 0x040010F7 RID: 4343
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0;

		// Token: 0x040010F8 RID: 4344
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0;

		// Token: 0x040010F9 RID: 4345
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceUri_Public_Virtual_get_String_0;

		// Token: 0x040010FA RID: 4346
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentNode_Public_Virtual_get_IXmlNode_0;
	}
}
