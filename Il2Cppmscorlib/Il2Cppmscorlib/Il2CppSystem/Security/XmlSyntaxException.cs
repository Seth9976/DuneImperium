using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Security
{
	// Token: 0x0200021B RID: 539
	[Serializable]
	public sealed class XmlSyntaxException : SystemException
	{
		// Token: 0x060023D6 RID: 9174 RVA: 0x000C8E40 File Offset: 0x000C7040
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSyntaxException()
		{
			Il2CppClassPointerStore<XmlSyntaxException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security", "XmlSyntaxException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSyntaxException>.NativeClassPtr);
			XmlSyntaxException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSyntaxException>.NativeClassPtr, 100669348);
			XmlSyntaxException.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSyntaxException>.NativeClassPtr, 100669349);
			XmlSyntaxException.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSyntaxException>.NativeClassPtr, 100669350);
			XmlSyntaxException.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSyntaxException>.NativeClassPtr, 100669351);
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x000C8EC0 File Offset: 0x000C70C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 474436, RefRangeEnd = 474437, XrefRangeStart = 474436, XrefRangeEnd = 474437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSyntaxException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSyntaxException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSyntaxException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x000C8EFC File Offset: 0x000C70FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 474436, RefRangeEnd = 474437, XrefRangeStart = 474436, XrefRangeEnd = 474437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSyntaxException(int lineNumber)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSyntaxException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lineNumber;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSyntaxException.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x000C8F44 File Offset: 0x000C7144
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 474436, RefRangeEnd = 474437, XrefRangeStart = 474436, XrefRangeEnd = 474437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSyntaxException(int lineNumber, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSyntaxException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lineNumber;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSyntaxException.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x000C8FA0 File Offset: 0x000C71A0
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSyntaxException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSyntaxException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSyntaxException.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023DB RID: 9179 RVA: 0x0000B728 File Offset: 0x00009928
		public XmlSyntaxException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001F60 RID: 8032
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001F61 RID: 8033
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001F62 RID: 8034
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0;

		// Token: 0x04001F63 RID: 8035
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;
	}
}
