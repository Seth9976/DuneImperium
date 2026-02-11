using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Xml
{
	// Token: 0x020000A0 RID: 160
	[Serializable]
	public class XmlException : SystemException
	{
		// Token: 0x06001161 RID: 4449 RVA: 0x00062CF4 File Offset: 0x00060EF4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlException()
		{
			Il2CppClassPointerStore<XmlException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlException>.NativeClassPtr);
			XmlException.NativeFieldInfoPtr_res = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlException>.NativeClassPtr, "res");
			XmlException.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlException>.NativeClassPtr, "args");
			XmlException.NativeFieldInfoPtr_lineNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlException>.NativeClassPtr, "lineNumber");
			XmlException.NativeFieldInfoPtr_linePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlException>.NativeClassPtr, "linePosition");
			XmlException.NativeFieldInfoPtr_sourceUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlException>.NativeClassPtr, "sourceUri");
			XmlException.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlException>.NativeClassPtr, "message");
			XmlException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100666180);
			XmlException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100666181);
			XmlException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100666182);
			XmlException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100666183);
			XmlException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100666184);
			XmlException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100666185);
			XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_Exception_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100666186);
			XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100666187);
			XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100666188);
			XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100666189);
			XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_String_IXmlLineInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100666190);
			XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_IXmlLineInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100666191);
			XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_IXmlLineInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100666192);
			XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100666193);
			XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_String_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100666194);
			XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100666195);
			XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100666196);
			XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Exception_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100666197);
			XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Exception_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100666198);
			XmlException.NativeMethodInfoPtr_FormatUserMessage_Private_Static_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100666199);
			XmlException.NativeMethodInfoPtr_CreateMessage_Private_Static_String_String_Il2CppStringArray_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100666200);
			XmlException.NativeMethodInfoPtr_BuildCharExceptionArgs_Internal_Static_Il2CppStringArray_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100666201);
			XmlException.NativeMethodInfoPtr_BuildCharExceptionArgs_Internal_Static_Il2CppStringArray_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100666202);
			XmlException.NativeMethodInfoPtr_BuildCharExceptionArgs_Internal_Static_Il2CppStringArray_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100666203);
			XmlException.NativeMethodInfoPtr_get_LineNumber_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100666204);
			XmlException.NativeMethodInfoPtr_get_LinePosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100666205);
			XmlException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100666206);
			XmlException.NativeMethodInfoPtr_get_ResString_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlException>.NativeClassPtr, 100666207);
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x00062FCC File Offset: 0x000611CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382107, XrefRangeEnd = 382181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x00063030 File Offset: 0x00061230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382181, XrefRangeEnd = 382203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x00063094 File Offset: 0x00061294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382203, XrefRangeEnd = 382204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x000630D0 File Offset: 0x000612D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 382205, RefRangeEnd = 382206, XrefRangeStart = 382204, XrefRangeEnd = 382205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x0006311C File Offset: 0x0006131C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382206, XrefRangeEnd = 382207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x0006317C File Offset: 0x0006137C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382207, XrefRangeEnd = 382208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlException(string message, Exception innerException, int lineNumber, int linePosition)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x000631F8 File Offset: 0x000613F8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 382233, RefRangeEnd = 382238, XrefRangeStart = 382208, XrefRangeEnd = 382233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlException(string message, Exception innerException, int lineNumber, int linePosition, string sourceUri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_Exception_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x00063284 File Offset: 0x00061484
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 382239, RefRangeEnd = 382244, XrefRangeStart = 382238, XrefRangeEnd = 382239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlException(string res, Il2CppStringArray args)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x000632E4 File Offset: 0x000614E4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 382249, RefRangeEnd = 382260, XrefRangeStart = 382244, XrefRangeEnd = 382249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlException(string res, string arg)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x00063344 File Offset: 0x00061544
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 382265, RefRangeEnd = 382267, XrefRangeStart = 382260, XrefRangeEnd = 382265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlException(string res, string arg, string sourceUri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x000633B4 File Offset: 0x000615B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 382278, RefRangeEnd = 382280, XrefRangeStart = 382267, XrefRangeEnd = 382278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlException(string res, string arg, IXmlLineInfo lineInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lineInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_String_IXmlLineInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x00063424 File Offset: 0x00061624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382280, XrefRangeEnd = 382287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlException(string res, Il2CppStringArray args, IXmlLineInfo lineInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lineInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_IXmlLineInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x00063494 File Offset: 0x00061694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382287, XrefRangeEnd = 382294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlException(string res, Il2CppStringArray args, IXmlLineInfo lineInfo, string sourceUri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lineInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_IXmlLineInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x00063518 File Offset: 0x00061718
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 382299, RefRangeEnd = 382303, XrefRangeStart = 382294, XrefRangeEnd = 382299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlException(string res, string arg, int lineNumber, int linePosition)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x00063594 File Offset: 0x00061794
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 382308, RefRangeEnd = 382313, XrefRangeStart = 382303, XrefRangeEnd = 382308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlException(string res, string arg, int lineNumber, int linePosition, string sourceUri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_String_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x00063620 File Offset: 0x00061820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382313, XrefRangeEnd = 382314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlException(string res, Il2CppStringArray args, int lineNumber, int linePosition)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x0006369C File Offset: 0x0006189C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 382315, RefRangeEnd = 382317, XrefRangeStart = 382314, XrefRangeEnd = 382315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlException(string res, Il2CppStringArray args, int lineNumber, int linePosition, string sourceUri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x00063728 File Offset: 0x00061928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382317, XrefRangeEnd = 382318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlException(string res, Il2CppStringArray args, Exception innerException, int lineNumber, int linePosition)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Exception_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x000637B4 File Offset: 0x000619B4
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 382323, RefRangeEnd = 382338, XrefRangeStart = 382318, XrefRangeEnd = 382323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlException(string res, Il2CppStringArray args, Exception innerException, int lineNumber, int linePosition, string sourceUri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Exception_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x00063854 File Offset: 0x00061A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382338, XrefRangeEnd = 382341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatUserMessage(string message, int lineNumber, int linePosition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr_FormatUserMessage_Private_Static_String_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x000638AC File Offset: 0x00061AAC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 382364, RefRangeEnd = 382368, XrefRangeStart = 382341, XrefRangeEnd = 382364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CreateMessage(string res, Il2CppStringArray args, int lineNumber, int linePosition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr_CreateMessage_Private_Static_String_String_Il2CppStringArray_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x00063918 File Offset: 0x00061B18
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 382373, RefRangeEnd = 382379, XrefRangeStart = 382368, XrefRangeEnd = 382373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray BuildCharExceptionArgs(string data, int invCharIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invCharIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr_BuildCharExceptionArgs_Internal_Static_Il2CppStringArray_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x0006396C File Offset: 0x00061B6C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 382383, RefRangeEnd = 382388, XrefRangeStart = 382379, XrefRangeEnd = 382383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray BuildCharExceptionArgs(Il2CppStructArray<char> data, int length, int invCharIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invCharIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr_BuildCharExceptionArgs_Internal_Static_Il2CppStringArray_Il2CppStructArray_1_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x000639CC File Offset: 0x00061BCC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 382427, RefRangeEnd = 382437, XrefRangeStart = 382388, XrefRangeEnd = 382427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray BuildCharExceptionArgs(char invChar, char nextChar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref invChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nextChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr_BuildCharExceptionArgs_Internal_Static_Il2CppStringArray_Char_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x0600117A RID: 4474 RVA: 0x00063A1C File Offset: 0x00061C1C
		public unsafe int LineNumber
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 315963, RefRangeEnd = 315964, XrefRangeStart = 315963, XrefRangeEnd = 315964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr_get_LineNumber_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x0600117B RID: 4475 RVA: 0x00063A58 File Offset: 0x00061C58
		public unsafe int LinePosition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 314558, RefRangeEnd = 314559, XrefRangeStart = 314558, XrefRangeEnd = 314559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr_get_LinePosition_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x0600117C RID: 4476 RVA: 0x00063A94 File Offset: 0x00061C94
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382437, XrefRangeEnd = 382438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x0600117D RID: 4477 RVA: 0x00063AD8 File Offset: 0x00061CD8
		public unsafe string ResString
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlException.NativeMethodInfoPtr_get_ResString_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x0000774A File Offset: 0x0000594A
		public XmlException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x0600117F RID: 4479 RVA: 0x00063B10 File Offset: 0x00061D10
		// (set) Token: 0x06001180 RID: 4480 RVA: 0x00007753 File Offset: 0x00005953
		public unsafe string res
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlException.NativeFieldInfoPtr_res);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlException.NativeFieldInfoPtr_res), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001181 RID: 4481 RVA: 0x00063B38 File Offset: 0x00061D38
		// (set) Token: 0x06001182 RID: 4482 RVA: 0x00007772 File Offset: 0x00005972
		public unsafe Il2CppStringArray args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlException.NativeFieldInfoPtr_args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlException.NativeFieldInfoPtr_args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001183 RID: 4483 RVA: 0x00063B68 File Offset: 0x00061D68
		// (set) Token: 0x06001184 RID: 4484 RVA: 0x00007791 File Offset: 0x00005991
		public unsafe int lineNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlException.NativeFieldInfoPtr_lineNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlException.NativeFieldInfoPtr_lineNumber)) = value;
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001185 RID: 4485 RVA: 0x00063B90 File Offset: 0x00061D90
		// (set) Token: 0x06001186 RID: 4486 RVA: 0x000077AC File Offset: 0x000059AC
		public unsafe int linePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlException.NativeFieldInfoPtr_linePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlException.NativeFieldInfoPtr_linePosition)) = value;
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001187 RID: 4487 RVA: 0x00063BB8 File Offset: 0x00061DB8
		// (set) Token: 0x06001188 RID: 4488 RVA: 0x000077C7 File Offset: 0x000059C7
		public unsafe string sourceUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlException.NativeFieldInfoPtr_sourceUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlException.NativeFieldInfoPtr_sourceUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001189 RID: 4489 RVA: 0x00063BE0 File Offset: 0x00061DE0
		// (set) Token: 0x0600118A RID: 4490 RVA: 0x000077E6 File Offset: 0x000059E6
		public unsafe string message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlException.NativeFieldInfoPtr_message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlException.NativeFieldInfoPtr_message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000E28 RID: 3624
		private static readonly IntPtr NativeFieldInfoPtr_res;

		// Token: 0x04000E29 RID: 3625
		private static readonly IntPtr NativeFieldInfoPtr_args;

		// Token: 0x04000E2A RID: 3626
		private static readonly IntPtr NativeFieldInfoPtr_lineNumber;

		// Token: 0x04000E2B RID: 3627
		private static readonly IntPtr NativeFieldInfoPtr_linePosition;

		// Token: 0x04000E2C RID: 3628
		private static readonly IntPtr NativeFieldInfoPtr_sourceUri;

		// Token: 0x04000E2D RID: 3629
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x04000E2E RID: 3630
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000E2F RID: 3631
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000E30 RID: 3632
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000E31 RID: 3633
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000E32 RID: 3634
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x04000E33 RID: 3635
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_Int32_Int32_0;

		// Token: 0x04000E34 RID: 3636
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Exception_Int32_Int32_String_0;

		// Token: 0x04000E35 RID: 3637
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_0;

		// Token: 0x04000E36 RID: 3638
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_0;

		// Token: 0x04000E37 RID: 3639
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_0;

		// Token: 0x04000E38 RID: 3640
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_IXmlLineInfo_0;

		// Token: 0x04000E39 RID: 3641
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_IXmlLineInfo_0;

		// Token: 0x04000E3A RID: 3642
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_IXmlLineInfo_String_0;

		// Token: 0x04000E3B RID: 3643
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_Int32_Int32_0;

		// Token: 0x04000E3C RID: 3644
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_Int32_Int32_String_0;

		// Token: 0x04000E3D RID: 3645
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Int32_Int32_0;

		// Token: 0x04000E3E RID: 3646
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Int32_Int32_String_0;

		// Token: 0x04000E3F RID: 3647
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Exception_Int32_Int32_0;

		// Token: 0x04000E40 RID: 3648
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Exception_Int32_Int32_String_0;

		// Token: 0x04000E41 RID: 3649
		private static readonly IntPtr NativeMethodInfoPtr_FormatUserMessage_Private_Static_String_String_Int32_Int32_0;

		// Token: 0x04000E42 RID: 3650
		private static readonly IntPtr NativeMethodInfoPtr_CreateMessage_Private_Static_String_String_Il2CppStringArray_Int32_Int32_0;

		// Token: 0x04000E43 RID: 3651
		private static readonly IntPtr NativeMethodInfoPtr_BuildCharExceptionArgs_Internal_Static_Il2CppStringArray_String_Int32_0;

		// Token: 0x04000E44 RID: 3652
		private static readonly IntPtr NativeMethodInfoPtr_BuildCharExceptionArgs_Internal_Static_Il2CppStringArray_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000E45 RID: 3653
		private static readonly IntPtr NativeMethodInfoPtr_BuildCharExceptionArgs_Internal_Static_Il2CppStringArray_Char_Char_0;

		// Token: 0x04000E46 RID: 3654
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumber_Public_get_Int32_0;

		// Token: 0x04000E47 RID: 3655
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePosition_Public_get_Int32_0;

		// Token: 0x04000E48 RID: 3656
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;

		// Token: 0x04000E49 RID: 3657
		private static readonly IntPtr NativeMethodInfoPtr_get_ResString_Internal_get_String_0;
	}
}
