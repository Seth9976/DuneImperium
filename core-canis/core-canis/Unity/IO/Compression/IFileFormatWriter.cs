using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Unity.IO.Compression
{
	// Token: 0x0200006E RID: 110
	public class IFileFormatWriter : Il2CppObjectBase
	{
		// Token: 0x06000831 RID: 2097 RVA: 0x00033EB8 File Offset: 0x000320B8
		// Note: this type is marked as 'beforefieldinit'.
		static IFileFormatWriter()
		{
			Il2CppClassPointerStore<IFileFormatWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "Unity.IO.Compression", "IFileFormatWriter");
			IFileFormatWriter.NativeMethodInfoPtr_GetHeader_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFileFormatWriter>.NativeClassPtr, 100664495);
			IFileFormatWriter.NativeMethodInfoPtr_UpdateWithBytesRead_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFileFormatWriter>.NativeClassPtr, 100664496);
			IFileFormatWriter.NativeMethodInfoPtr_GetFooter_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFileFormatWriter>.NativeClassPtr, 100664497);
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00033F1C File Offset: 0x0003211C
		[CallerCount(0)]
		public unsafe virtual Il2CppStructArray<byte> GetHeader()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFileFormatWriter.NativeMethodInfoPtr_GetHeader_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00033F68 File Offset: 0x00032168
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFileFormatWriter.NativeMethodInfoPtr_UpdateWithBytesRead_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00033FD4 File Offset: 0x000321D4
		[CallerCount(0)]
		public unsafe virtual Il2CppStructArray<byte> GetFooter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFileFormatWriter.NativeMethodInfoPtr_GetFooter_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00004B6B File Offset: 0x00002D6B
		public IFileFormatWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeMethodInfoPtr_GetHeader_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWithBytesRead_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000624 RID: 1572
		private static readonly IntPtr NativeMethodInfoPtr_GetFooter_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0;
	}
}
