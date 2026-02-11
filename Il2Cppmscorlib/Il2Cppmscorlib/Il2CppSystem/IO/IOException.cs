using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.IO
{
	// Token: 0x02000525 RID: 1317
	[Serializable]
	public class IOException : SystemException
	{
		// Token: 0x06005017 RID: 20503 RVA: 0x00174AC4 File Offset: 0x00172CC4
		// Note: this type is marked as 'beforefieldinit'.
		static IOException()
		{
			Il2CppClassPointerStore<IOException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "IOException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IOException>.NativeClassPtr);
			IOException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOException>.NativeClassPtr, 100675396);
			IOException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOException>.NativeClassPtr, 100675397);
			IOException.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOException>.NativeClassPtr, 100675398);
			IOException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOException>.NativeClassPtr, 100675399);
			IOException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOException>.NativeClassPtr, 100675400);
		}

		// Token: 0x06005018 RID: 20504 RVA: 0x00174B58 File Offset: 0x00172D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427368, XrefRangeEnd = 1427371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IOException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IOException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005019 RID: 20505 RVA: 0x00174B94 File Offset: 0x00172D94
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1427372, RefRangeEnd = 1427377, XrefRangeStart = 1427371, XrefRangeEnd = 1427372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IOException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IOException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600501A RID: 20506 RVA: 0x00174BE0 File Offset: 0x00172DE0
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 1391216, RefRangeEnd = 1391240, XrefRangeStart = 1391216, XrefRangeEnd = 1391240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IOException(string message, int hresult)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IOException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hresult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOException.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600501B RID: 20507 RVA: 0x00174C3C File Offset: 0x00172E3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1427378, RefRangeEnd = 1427380, XrefRangeStart = 1427377, XrefRangeEnd = 1427378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IOException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IOException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600501C RID: 20508 RVA: 0x00174C9C File Offset: 0x00172E9C
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IOException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IOException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600501D RID: 20509 RVA: 0x0001CAA3 File Offset: 0x0001ACA3
		public IOException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400415B RID: 16731
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400415C RID: 16732
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400415D RID: 16733
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;

		// Token: 0x0400415E RID: 16734
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x0400415F RID: 16735
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
