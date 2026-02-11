using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000FA RID: 250
	public class XCommentWrapper : XObjectWrapper
	{
		// Token: 0x060014D3 RID: 5331 RVA: 0x00071C8C File Offset: 0x0006FE8C
		// Note: this type is marked as 'beforefieldinit'.
		static XCommentWrapper()
		{
			Il2CppClassPointerStore<XCommentWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Converters", "XCommentWrapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XCommentWrapper>.NativeClassPtr);
			XCommentWrapper.NativeMethodInfoPtr_get_Text_Private_get_XComment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XCommentWrapper>.NativeClassPtr, 100667255);
			XCommentWrapper.NativeMethodInfoPtr__ctor_Public_Void_XComment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XCommentWrapper>.NativeClassPtr, 100667256);
			XCommentWrapper.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XCommentWrapper>.NativeClassPtr, 100667257);
			XCommentWrapper.NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XCommentWrapper>.NativeClassPtr, 100667258);
			XCommentWrapper.NativeMethodInfoPtr_get_ParentNode_Public_Virtual_get_IXmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XCommentWrapper>.NativeClassPtr, 100667259);
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x060014D4 RID: 5332 RVA: 0x00071D20 File Offset: 0x0006FF20
		public unsafe XComment Text
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 765450, RefRangeEnd = 765451, XrefRangeStart = 765448, XrefRangeEnd = 765450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XCommentWrapper.NativeMethodInfoPtr_get_Text_Private_get_XComment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XComment>(intPtr3) : null;
			}
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x00071D60 File Offset: 0x0006FF60
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XCommentWrapper(XComment text)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XCommentWrapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XCommentWrapper.NativeMethodInfoPtr__ctor_Public_Void_XComment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x060014D6 RID: 5334 RVA: 0x00071DAC File Offset: 0x0006FFAC
		// (set) Token: 0x060014D7 RID: 5335 RVA: 0x00071DF0 File Offset: 0x0006FFF0
		public unsafe override string Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765451, XrefRangeEnd = 765453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XCommentWrapper.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765453, XrefRangeEnd = 765460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XCommentWrapper.NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x060014D8 RID: 5336 RVA: 0x00071E40 File Offset: 0x00070040
		public unsafe override IXmlNode ParentNode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765460, XrefRangeEnd = 765466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XCommentWrapper.NativeMethodInfoPtr_get_ParentNode_Public_Virtual_get_IXmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x00008465 File Offset: 0x00006665
		public XCommentWrapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010D6 RID: 4310
		private static readonly IntPtr NativeMethodInfoPtr_get_Text_Private_get_XComment_0;

		// Token: 0x040010D7 RID: 4311
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XComment_0;

		// Token: 0x040010D8 RID: 4312
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0;

		// Token: 0x040010D9 RID: 4313
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0;

		// Token: 0x040010DA RID: 4314
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentNode_Public_Virtual_get_IXmlNode_0;
	}
}
