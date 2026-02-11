using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001D7 RID: 471
	public class XmlSchemaSimpleContent : XmlSchemaContentModel
	{
		// Token: 0x060027B1 RID: 10161 RVA: 0x000B91F0 File Offset: 0x000B73F0
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaSimpleContent()
		{
			Il2CppClassPointerStore<XmlSchemaSimpleContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaSimpleContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaSimpleContent>.NativeClassPtr);
			XmlSchemaSimpleContent.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSimpleContent>.NativeClassPtr, "content");
			XmlSchemaSimpleContent.NativeMethodInfoPtr_get_Content_Public_Virtual_get_XmlSchemaContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleContent>.NativeClassPtr, 100669045);
			XmlSchemaSimpleContent.NativeMethodInfoPtr_set_Content_Public_Virtual_set_Void_XmlSchemaContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleContent>.NativeClassPtr, 100669046);
			XmlSchemaSimpleContent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleContent>.NativeClassPtr, 100669047);
		}

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x060027B2 RID: 10162 RVA: 0x000B9270 File Offset: 0x000B7470
		// (set) Token: 0x060027B3 RID: 10163 RVA: 0x000B92BC File Offset: 0x000B74BC
		public unsafe override XmlSchemaContent Content
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaSimpleContent.NativeMethodInfoPtr_get_Content_Public_Virtual_get_XmlSchemaContent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaContent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaSimpleContent.NativeMethodInfoPtr_set_Content_Public_Virtual_set_Void_XmlSchemaContent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060027B4 RID: 10164 RVA: 0x000B930C File Offset: 0x000B750C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaSimpleContent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaSimpleContent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleContent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027B5 RID: 10165 RVA: 0x00010CD1 File Offset: 0x0000EED1
		public XmlSchemaSimpleContent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x060027B6 RID: 10166 RVA: 0x000B9348 File Offset: 0x000B7548
		// (set) Token: 0x060027B7 RID: 10167 RVA: 0x00010CDA File Offset: 0x0000EEDA
		public unsafe XmlSchemaContent content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleContent.NativeFieldInfoPtr_content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleContent.NativeFieldInfoPtr_content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001DF2 RID: 7666
		private static readonly IntPtr NativeFieldInfoPtr_content;

		// Token: 0x04001DF3 RID: 7667
		private static readonly IntPtr NativeMethodInfoPtr_get_Content_Public_Virtual_get_XmlSchemaContent_0;

		// Token: 0x04001DF4 RID: 7668
		private static readonly IntPtr NativeMethodInfoPtr_set_Content_Public_Virtual_set_Void_XmlSchemaContent_0;

		// Token: 0x04001DF5 RID: 7669
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
