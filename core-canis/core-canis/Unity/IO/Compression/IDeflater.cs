using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Unity.IO.Compression
{
	// Token: 0x02000075 RID: 117
	public class IDeflater : Il2CppObjectBase
	{
		// Token: 0x060008B2 RID: 2226 RVA: 0x000359C4 File Offset: 0x00033BC4
		// Note: this type is marked as 'beforefieldinit'.
		static IDeflater()
		{
			Il2CppClassPointerStore<IDeflater>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "Unity.IO.Compression", "IDeflater");
			IDeflater.NativeMethodInfoPtr_NeedsInput_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDeflater>.NativeClassPtr, 100664543);
			IDeflater.NativeMethodInfoPtr_SetInput_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDeflater>.NativeClassPtr, 100664544);
			IDeflater.NativeMethodInfoPtr_GetDeflateOutput_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDeflater>.NativeClassPtr, 100664545);
			IDeflater.NativeMethodInfoPtr_Finish_Public_Abstract_Virtual_New_Boolean_Il2CppStructArray_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDeflater>.NativeClassPtr, 100664546);
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00035A3C File Offset: 0x00033C3C
		[CallerCount(0)]
		public unsafe virtual bool NeedsInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDeflater.NativeMethodInfoPtr_NeedsInput_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00035A84 File Offset: 0x00033C84
		[CallerCount(0)]
		public unsafe virtual void SetInput(Il2CppStructArray<byte> inputBuffer, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDeflater.NativeMethodInfoPtr_SetInput_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00035AF0 File Offset: 0x00033CF0
		[CallerCount(0)]
		public unsafe virtual int GetDeflateOutput(Il2CppStructArray<byte> outputBuffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outputBuffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDeflater.NativeMethodInfoPtr_GetDeflateOutput_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00035B48 File Offset: 0x00033D48
		[CallerCount(0)]
		public unsafe virtual bool Finish(Il2CppStructArray<byte> outputBuffer, out int bytesRead)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bytesRead;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDeflater.NativeMethodInfoPtr_Finish_Public_Abstract_Virtual_New_Boolean_Il2CppStructArray_1_Byte_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00004E9D File Offset: 0x0000309D
		public IDeflater(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000673 RID: 1651
		private static readonly IntPtr NativeMethodInfoPtr_NeedsInput_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000674 RID: 1652
		private static readonly IntPtr NativeMethodInfoPtr_SetInput_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000675 RID: 1653
		private static readonly IntPtr NativeMethodInfoPtr_GetDeflateOutput_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeMethodInfoPtr_Finish_Public_Abstract_Virtual_New_Boolean_Il2CppStructArray_1_Byte_byref_Int32_0;
	}
}
