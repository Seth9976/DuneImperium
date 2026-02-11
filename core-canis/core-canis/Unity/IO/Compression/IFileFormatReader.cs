using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Unity.IO.Compression
{
	// Token: 0x0200006F RID: 111
	public class IFileFormatReader : Il2CppObjectBase
	{
		// Token: 0x06000836 RID: 2102 RVA: 0x00034020 File Offset: 0x00032220
		// Note: this type is marked as 'beforefieldinit'.
		static IFileFormatReader()
		{
			Il2CppClassPointerStore<IFileFormatReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "Unity.IO.Compression", "IFileFormatReader");
			IFileFormatReader.NativeMethodInfoPtr_ReadHeader_Public_Abstract_Virtual_New_Boolean_InputBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFileFormatReader>.NativeClassPtr, 100664498);
			IFileFormatReader.NativeMethodInfoPtr_ReadFooter_Public_Abstract_Virtual_New_Boolean_InputBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFileFormatReader>.NativeClassPtr, 100664499);
			IFileFormatReader.NativeMethodInfoPtr_UpdateWithBytesRead_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFileFormatReader>.NativeClassPtr, 100664500);
			IFileFormatReader.NativeMethodInfoPtr_Validate_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFileFormatReader>.NativeClassPtr, 100664501);
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00034098 File Offset: 0x00032298
		[CallerCount(0)]
		public unsafe virtual bool ReadHeader(InputBuffer input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFileFormatReader.NativeMethodInfoPtr_ReadHeader_Public_Abstract_Virtual_New_Boolean_InputBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x000340F0 File Offset: 0x000322F0
		[CallerCount(0)]
		public unsafe virtual bool ReadFooter(InputBuffer input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFileFormatReader.NativeMethodInfoPtr_ReadFooter_Public_Abstract_Virtual_New_Boolean_InputBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00034148 File Offset: 0x00032348
		[CallerCount(0)]
		public unsafe virtual void UpdateWithBytesRead(Il2CppStructArray<byte> buffer, int offset, int bytesToCopy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bytesToCopy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFileFormatReader.NativeMethodInfoPtr_UpdateWithBytesRead_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x000341B4 File Offset: 0x000323B4
		[CallerCount(0)]
		public unsafe virtual void Validate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFileFormatReader.NativeMethodInfoPtr_Validate_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00004B74 File Offset: 0x00002D74
		public IFileFormatReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000625 RID: 1573
		private static readonly IntPtr NativeMethodInfoPtr_ReadHeader_Public_Abstract_Virtual_New_Boolean_InputBuffer_0;

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeMethodInfoPtr_ReadFooter_Public_Abstract_Virtual_New_Boolean_InputBuffer_0;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWithBytesRead_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Public_Abstract_Virtual_New_Void_0;
	}
}
