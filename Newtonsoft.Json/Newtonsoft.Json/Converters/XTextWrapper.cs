using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000F9 RID: 249
	public class XTextWrapper : XObjectWrapper
	{
		// Token: 0x060014CC RID: 5324 RVA: 0x00071A8C File Offset: 0x0006FC8C
		// Note: this type is marked as 'beforefieldinit'.
		static XTextWrapper()
		{
			Il2CppClassPointerStore<XTextWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Converters", "XTextWrapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XTextWrapper>.NativeClassPtr);
			XTextWrapper.NativeMethodInfoPtr_get_Text_Private_get_XText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XTextWrapper>.NativeClassPtr, 100667250);
			XTextWrapper.NativeMethodInfoPtr__ctor_Public_Void_XText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XTextWrapper>.NativeClassPtr, 100667251);
			XTextWrapper.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XTextWrapper>.NativeClassPtr, 100667252);
			XTextWrapper.NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XTextWrapper>.NativeClassPtr, 100667253);
			XTextWrapper.NativeMethodInfoPtr_get_ParentNode_Public_Virtual_get_IXmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XTextWrapper>.NativeClassPtr, 100667254);
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x060014CD RID: 5325 RVA: 0x00071B20 File Offset: 0x0006FD20
		public unsafe XText Text
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 765432, RefRangeEnd = 765433, XrefRangeStart = 765430, XrefRangeEnd = 765432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XTextWrapper.NativeMethodInfoPtr_get_Text_Private_get_XText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XText>(intPtr3) : null;
			}
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x00071B60 File Offset: 0x0006FD60
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XTextWrapper(XText text)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XTextWrapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XTextWrapper.NativeMethodInfoPtr__ctor_Public_Void_XText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x060014CF RID: 5327 RVA: 0x00071BAC File Offset: 0x0006FDAC
		// (set) Token: 0x060014D0 RID: 5328 RVA: 0x00071BF0 File Offset: 0x0006FDF0
		public unsafe override string Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765433, XrefRangeEnd = 765435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XTextWrapper.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765435, XrefRangeEnd = 765442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XTextWrapper.NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x060014D1 RID: 5329 RVA: 0x00071C40 File Offset: 0x0006FE40
		public unsafe override IXmlNode ParentNode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765442, XrefRangeEnd = 765448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XTextWrapper.NativeMethodInfoPtr_get_ParentNode_Public_Virtual_get_IXmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x0000845C File Offset: 0x0000665C
		public XTextWrapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010D1 RID: 4305
		private static readonly IntPtr NativeMethodInfoPtr_get_Text_Private_get_XText_0;

		// Token: 0x040010D2 RID: 4306
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XText_0;

		// Token: 0x040010D3 RID: 4307
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0;

		// Token: 0x040010D4 RID: 4308
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0;

		// Token: 0x040010D5 RID: 4309
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentNode_Public_Virtual_get_IXmlNode_0;
	}
}
