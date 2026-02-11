using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppMono.Btls
{
	// Token: 0x02000029 RID: 41
	public class IMonoBtlsBioMono : Il2CppObjectBase
	{
		// Token: 0x06000253 RID: 595 RVA: 0x00023E50 File Offset: 0x00022050
		// Note: this type is marked as 'beforefieldinit'.
		static IMonoBtlsBioMono()
		{
			Il2CppClassPointerStore<IMonoBtlsBioMono>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "IMonoBtlsBioMono");
			IMonoBtlsBioMono.NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMonoBtlsBioMono>.NativeClassPtr, 100663710);
			IMonoBtlsBioMono.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMonoBtlsBioMono>.NativeClassPtr, 100663711);
			IMonoBtlsBioMono.NativeMethodInfoPtr_Flush_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMonoBtlsBioMono>.NativeClassPtr, 100663712);
			IMonoBtlsBioMono.NativeMethodInfoPtr_Close_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMonoBtlsBioMono>.NativeClassPtr, 100663713);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00023EC8 File Offset: 0x000220C8
		[CallerCount(0)]
		public unsafe virtual int Read(Il2CppStructArray<byte> buffer, int offset, int size, out bool wantMore)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &wantMore;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMonoBtlsBioMono.NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00023F4C File Offset: 0x0002214C
		[CallerCount(0)]
		public unsafe virtual bool Write(Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMonoBtlsBioMono.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00023FC0 File Offset: 0x000221C0
		[CallerCount(0)]
		public unsafe virtual void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMonoBtlsBioMono.NativeMethodInfoPtr_Flush_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00023FFC File Offset: 0x000221FC
		[CallerCount(0)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMonoBtlsBioMono.NativeMethodInfoPtr_Close_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002D95 File Offset: 0x00000F95
		public IMonoBtlsBioMono(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Boolean_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Abstract_Virtual_New_Void_0;
	}
}
