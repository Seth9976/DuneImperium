using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Xml.XPath
{
	// Token: 0x020000AB RID: 171
	[Serializable]
	public class XPathException : SystemException
	{
		// Token: 0x060011FF RID: 4607 RVA: 0x00065860 File Offset: 0x00063A60
		// Note: this type is marked as 'beforefieldinit'.
		static XPathException()
		{
			Il2CppClassPointerStore<XPathException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.XPath", "XPathException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathException>.NativeClassPtr);
			XPathException.NativeFieldInfoPtr_res = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathException>.NativeClassPtr, "res");
			XPathException.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathException>.NativeClassPtr, "args");
			XPathException.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathException>.NativeClassPtr, "message");
			XPathException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathException>.NativeClassPtr, 100666269);
			XPathException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathException>.NativeClassPtr, 100666270);
			XPathException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathException>.NativeClassPtr, 100666271);
			XPathException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathException>.NativeClassPtr, 100666272);
			XPathException.NativeMethodInfoPtr_Create_Internal_Static_XPathException_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathException>.NativeClassPtr, 100666273);
			XPathException.NativeMethodInfoPtr_Create_Internal_Static_XPathException_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathException>.NativeClassPtr, 100666274);
			XPathException.NativeMethodInfoPtr_Create_Internal_Static_XPathException_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathException>.NativeClassPtr, 100666275);
			XPathException.NativeMethodInfoPtr__ctor_Private_Void_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathException>.NativeClassPtr, 100666276);
			XPathException.NativeMethodInfoPtr__ctor_Private_Void_String_Il2CppStringArray_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathException>.NativeClassPtr, 100666277);
			XPathException.NativeMethodInfoPtr_CreateMessage_Private_Static_String_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathException>.NativeClassPtr, 100666278);
			XPathException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathException>.NativeClassPtr, 100666279);
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x000659A8 File Offset: 0x00063BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383290, XrefRangeEnd = 383335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XPathException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XPathException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x00065A0C File Offset: 0x00063C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383335, XrefRangeEnd = 383348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x00065A70 File Offset: 0x00063C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383348, XrefRangeEnd = 383357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XPathException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XPathException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x00065AAC File Offset: 0x00063CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383357, XrefRangeEnd = 383364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XPathException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XPathException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x00065B0C File Offset: 0x00063D0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 383368, RefRangeEnd = 383369, XrefRangeStart = 383364, XrefRangeEnd = 383368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XPathException Create(string res)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathException.NativeMethodInfoPtr_Create_Internal_Static_XPathException_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XPathException>(intPtr3) : null;
			}
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x00065B50 File Offset: 0x00063D50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 383377, RefRangeEnd = 383378, XrefRangeStart = 383369, XrefRangeEnd = 383377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XPathException Create(string res, string arg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathException.NativeMethodInfoPtr_Create_Internal_Static_XPathException_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XPathException>(intPtr3) : null;
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x00065BA8 File Offset: 0x00063DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383378, XrefRangeEnd = 383387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XPathException Create(string res, string arg, string arg2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathException.NativeMethodInfoPtr_Create_Internal_Static_XPathException_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XPathException>(intPtr3) : null;
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x00065C10 File Offset: 0x00063E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383387, XrefRangeEnd = 383388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XPathException(string res, Il2CppStringArray args)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XPathException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathException.NativeMethodInfoPtr__ctor_Private_Void_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x00065C70 File Offset: 0x00063E70
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 383392, RefRangeEnd = 383398, XrefRangeStart = 383388, XrefRangeEnd = 383392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XPathException(string res, Il2CppStringArray args, Exception inner)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XPathException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathException.NativeMethodInfoPtr__ctor_Private_Void_String_Il2CppStringArray_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x00065CE0 File Offset: 0x00063EE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 383409, RefRangeEnd = 383411, XrefRangeStart = 383398, XrefRangeEnd = 383409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CreateMessage(string res, Il2CppStringArray args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathException.NativeMethodInfoPtr_CreateMessage_Private_Static_String_String_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x0600120A RID: 4618 RVA: 0x00065D30 File Offset: 0x00063F30
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383411, XrefRangeEnd = 383412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x00007AFF File Offset: 0x00005CFF
		public XPathException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x0600120C RID: 4620 RVA: 0x00065D74 File Offset: 0x00063F74
		// (set) Token: 0x0600120D RID: 4621 RVA: 0x00007B08 File Offset: 0x00005D08
		public unsafe string res
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathException.NativeFieldInfoPtr_res);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathException.NativeFieldInfoPtr_res), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x0600120E RID: 4622 RVA: 0x00065D9C File Offset: 0x00063F9C
		// (set) Token: 0x0600120F RID: 4623 RVA: 0x00007B27 File Offset: 0x00005D27
		public unsafe Il2CppStringArray args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathException.NativeFieldInfoPtr_args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathException.NativeFieldInfoPtr_args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001210 RID: 4624 RVA: 0x00065DCC File Offset: 0x00063FCC
		// (set) Token: 0x06001211 RID: 4625 RVA: 0x00007B46 File Offset: 0x00005D46
		public unsafe string message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathException.NativeFieldInfoPtr_message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathException.NativeFieldInfoPtr_message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000EAE RID: 3758
		private static readonly IntPtr NativeFieldInfoPtr_res;

		// Token: 0x04000EAF RID: 3759
		private static readonly IntPtr NativeFieldInfoPtr_args;

		// Token: 0x04000EB0 RID: 3760
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x04000EB1 RID: 3761
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000EB2 RID: 3762
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000EB3 RID: 3763
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000EB4 RID: 3764
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x04000EB5 RID: 3765
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_XPathException_String_0;

		// Token: 0x04000EB6 RID: 3766
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_XPathException_String_String_0;

		// Token: 0x04000EB7 RID: 3767
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_XPathException_String_String_String_0;

		// Token: 0x04000EB8 RID: 3768
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_Il2CppStringArray_0;

		// Token: 0x04000EB9 RID: 3769
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_Il2CppStringArray_Exception_0;

		// Token: 0x04000EBA RID: 3770
		private static readonly IntPtr NativeMethodInfoPtr_CreateMessage_Private_Static_String_String_Il2CppStringArray_0;

		// Token: 0x04000EBB RID: 3771
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;
	}
}
