using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.InteropServices;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000147 RID: 327
	[Serializable]
	public class Win32Exception : ExternalException
	{
		// Token: 0x06001435 RID: 5173 RVA: 0x0006A95C File Offset: 0x00068B5C
		// Note: this type is marked as 'beforefieldinit'.
		static Win32Exception()
		{
			Il2CppClassPointerStore<Win32Exception>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "Win32Exception");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr);
			Win32Exception.NativeFieldInfoPtr_nativeErrorCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, "nativeErrorCode");
			Win32Exception.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, 100666315);
			Win32Exception.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, 100666316);
			Win32Exception.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, 100666317);
			Win32Exception.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, 100666318);
			Win32Exception.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, 100666319);
			Win32Exception.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, 100666320);
			Win32Exception.NativeMethodInfoPtr_get_NativeErrorCode_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, 100666321);
			Win32Exception.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, 100666322);
			Win32Exception.NativeMethodInfoPtr_GetErrorMessage_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr, 100666323);
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x0006AA54 File Offset: 0x00068C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 465797, XrefRangeEnd = 465803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Win32Exception()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Exception.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x0006AA90 File Offset: 0x00068C90
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 465805, RefRangeEnd = 465819, XrefRangeStart = 465803, XrefRangeEnd = 465805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Win32Exception(int error)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Exception.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x0006AAD8 File Offset: 0x00068CD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 465820, RefRangeEnd = 465822, XrefRangeStart = 465819, XrefRangeEnd = 465820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Win32Exception(int error, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Exception.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x0006AB34 File Offset: 0x00068D34
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 465827, RefRangeEnd = 465830, XrefRangeStart = 465822, XrefRangeEnd = 465827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Win32Exception(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Exception.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x0006AB80 File Offset: 0x00068D80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 465835, RefRangeEnd = 465838, XrefRangeStart = 465830, XrefRangeEnd = 465835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Win32Exception(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Exception.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x0006ABE0 File Offset: 0x00068DE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 465842, RefRangeEnd = 465845, XrefRangeStart = 465838, XrefRangeEnd = 465842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Win32Exception(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32Exception>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Exception.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x0600143C RID: 5180 RVA: 0x0006AC44 File Offset: 0x00068E44
		public unsafe int NativeErrorCode
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 311826, RefRangeEnd = 311839, XrefRangeStart = 311826, XrefRangeEnd = 311839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Exception.NativeMethodInfoPtr_get_NativeErrorCode_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x0006AC80 File Offset: 0x00068E80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 465849, RefRangeEnd = 465850, XrefRangeStart = 465845, XrefRangeEnd = 465849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Win32Exception.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x0006ACE4 File Offset: 0x00068EE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 465933, RefRangeEnd = 465935, XrefRangeStart = 465850, XrefRangeEnd = 465933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetErrorMessage(int error)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Exception.NativeMethodInfoPtr_GetErrorMessage_Internal_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x00009049 File Offset: 0x00007249
		public Win32Exception(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06001440 RID: 5184 RVA: 0x0006AD1C File Offset: 0x00068F1C
		// (set) Token: 0x06001441 RID: 5185 RVA: 0x00009052 File Offset: 0x00007252
		public unsafe int nativeErrorCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32Exception.NativeFieldInfoPtr_nativeErrorCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32Exception.NativeFieldInfoPtr_nativeErrorCode)) = value;
			}
		}

		// Token: 0x04000FEB RID: 4075
		private static readonly IntPtr NativeFieldInfoPtr_nativeErrorCode;

		// Token: 0x04000FEC RID: 4076
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000FED RID: 4077
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000FEE RID: 4078
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0;

		// Token: 0x04000FEF RID: 4079
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000FF0 RID: 4080
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x04000FF1 RID: 4081
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000FF2 RID: 4082
		private static readonly IntPtr NativeMethodInfoPtr_get_NativeErrorCode_Public_get_Int32_0;

		// Token: 0x04000FF3 RID: 4083
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000FF4 RID: 4084
		private static readonly IntPtr NativeMethodInfoPtr_GetErrorMessage_Internal_Static_String_Int32_0;
	}
}
