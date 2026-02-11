using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200003C RID: 60
	public class XmlAsyncCheckReaderWithLineInfo : XmlAsyncCheckReader
	{
		// Token: 0x060003C2 RID: 962 RVA: 0x00025930 File Offset: 0x00023B30
		// Note: this type is marked as 'beforefieldinit'.
		static XmlAsyncCheckReaderWithLineInfo()
		{
			Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlAsyncCheckReaderWithLineInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfo>.NativeClassPtr);
			XmlAsyncCheckReaderWithLineInfo.NativeFieldInfoPtr_readerAsIXmlLineInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfo>.NativeClassPtr, "readerAsIXmlLineInfo");
			XmlAsyncCheckReaderWithLineInfo.NativeMethodInfoPtr__ctor_Public_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfo>.NativeClassPtr, 100663850);
			XmlAsyncCheckReaderWithLineInfo.NativeMethodInfoPtr_HasLineInfo_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfo>.NativeClassPtr, 100663851);
			XmlAsyncCheckReaderWithLineInfo.NativeMethodInfoPtr_get_LineNumber_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfo>.NativeClassPtr, 100663852);
			XmlAsyncCheckReaderWithLineInfo.NativeMethodInfoPtr_get_LinePosition_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfo>.NativeClassPtr, 100663853);
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x000259C4 File Offset: 0x00023BC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 365094, RefRangeEnd = 365095, XrefRangeStart = 365084, XrefRangeEnd = 365094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAsyncCheckReaderWithLineInfo(XmlReader reader)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAsyncCheckReaderWithLineInfo.NativeMethodInfoPtr__ctor_Public_Void_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00025A10 File Offset: 0x00023C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365095, XrefRangeEnd = 365099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool HasLineInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAsyncCheckReaderWithLineInfo.NativeMethodInfoPtr_HasLineInfo_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x00025A58 File Offset: 0x00023C58
		public unsafe virtual int LineNumber
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365099, XrefRangeEnd = 365103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAsyncCheckReaderWithLineInfo.NativeMethodInfoPtr_get_LineNumber_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x00025AA0 File Offset: 0x00023CA0
		public unsafe virtual int LinePosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365103, XrefRangeEnd = 365107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAsyncCheckReaderWithLineInfo.NativeMethodInfoPtr_get_LinePosition_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00003434 File Offset: 0x00001634
		public XmlAsyncCheckReaderWithLineInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x00025AE8 File Offset: 0x00023CE8
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x0000343D File Offset: 0x0000163D
		public unsafe IXmlLineInfo readerAsIXmlLineInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAsyncCheckReaderWithLineInfo.NativeFieldInfoPtr_readerAsIXmlLineInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXmlLineInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAsyncCheckReaderWithLineInfo.NativeFieldInfoPtr_readerAsIXmlLineInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeFieldInfoPtr_readerAsIXmlLineInfo;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlReader_0;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeMethodInfoPtr_HasLineInfo_Public_Virtual_New_Boolean_0;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumber_Public_Virtual_New_get_Int32_0;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePosition_Public_Virtual_New_get_Int32_0;
	}
}
