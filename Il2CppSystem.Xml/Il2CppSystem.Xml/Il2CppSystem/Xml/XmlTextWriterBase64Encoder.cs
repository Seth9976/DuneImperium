using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200000A RID: 10
	public class XmlTextWriterBase64Encoder : Base64Encoder
	{
		// Token: 0x06000032 RID: 50 RVA: 0x00016A74 File Offset: 0x00014C74
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTextWriterBase64Encoder()
		{
			Il2CppClassPointerStore<XmlTextWriterBase64Encoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlTextWriterBase64Encoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextWriterBase64Encoder>.NativeClassPtr);
			XmlTextWriterBase64Encoder.NativeFieldInfoPtr_xmlTextEncoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriterBase64Encoder>.NativeClassPtr, "xmlTextEncoder");
			XmlTextWriterBase64Encoder.NativeMethodInfoPtr__ctor_Internal_Void_XmlTextEncoder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriterBase64Encoder>.NativeClassPtr, 100663309);
			XmlTextWriterBase64Encoder.NativeMethodInfoPtr_WriteChars_Internal_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriterBase64Encoder>.NativeClassPtr, 100663310);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00016AE0 File Offset: 0x00014CE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 362202, RefRangeEnd = 362205, XrefRangeStart = 362202, XrefRangeEnd = 362205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextWriterBase64Encoder(XmlTextEncoder xmlTextEncoder)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextWriterBase64Encoder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlTextEncoder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriterBase64Encoder.NativeMethodInfoPtr__ctor_Internal_Void_XmlTextEncoder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00016B2C File Offset: 0x00014D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362206, XrefRangeEnd = 362208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteChars(Il2CppStructArray<char> chars, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriterBase64Encoder.NativeMethodInfoPtr_WriteChars_Internal_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000223C File Offset: 0x0000043C
		public XmlTextWriterBase64Encoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00016B98 File Offset: 0x00014D98
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00002245 File Offset: 0x00000445
		public unsafe XmlTextEncoder xmlTextEncoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriterBase64Encoder.NativeFieldInfoPtr_xmlTextEncoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextEncoder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriterBase64Encoder.NativeFieldInfoPtr_xmlTextEncoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_xmlTextEncoder;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlTextEncoder_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_WriteChars_Internal_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;
	}
}
