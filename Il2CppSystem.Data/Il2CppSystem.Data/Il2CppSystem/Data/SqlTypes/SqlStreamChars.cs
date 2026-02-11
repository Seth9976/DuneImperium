using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.IO;

namespace Il2CppSystem.Data.SqlTypes
{
	// Token: 0x020000A1 RID: 161
	public class SqlStreamChars : Object
	{
		// Token: 0x060010A3 RID: 4259 RVA: 0x0004F384 File Offset: 0x0004D584
		// Note: this type is marked as 'beforefieldinit'.
		static SqlStreamChars()
		{
			Il2CppClassPointerStore<SqlStreamChars>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data.SqlTypes", "SqlStreamChars");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SqlStreamChars>.NativeClassPtr);
			SqlStreamChars.NativeMethodInfoPtr_get_Length_Public_Abstract_Virtual_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlStreamChars>.NativeClassPtr, 100665970);
			SqlStreamChars.NativeMethodInfoPtr_get_Position_Public_Abstract_Virtual_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlStreamChars>.NativeClassPtr, 100665971);
			SqlStreamChars.NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlStreamChars>.NativeClassPtr, 100665972);
			SqlStreamChars.NativeMethodInfoPtr_Seek_Public_Abstract_Virtual_New_Int64_Int64_SeekOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlStreamChars>.NativeClassPtr, 100665973);
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x060010A4 RID: 4260 RVA: 0x0004F404 File Offset: 0x0004D604
		public unsafe virtual long Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SqlStreamChars.NativeMethodInfoPtr_get_Length_Public_Abstract_Virtual_New_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x060010A5 RID: 4261 RVA: 0x0004F44C File Offset: 0x0004D64C
		public unsafe virtual long Position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SqlStreamChars.NativeMethodInfoPtr_get_Position_Public_Abstract_Virtual_New_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x0004F494 File Offset: 0x0004D694
		[CallerCount(0)]
		public unsafe virtual int Read(Il2CppStructArray<char> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SqlStreamChars.NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x0004F508 File Offset: 0x0004D708
		[CallerCount(0)]
		public unsafe virtual long Seek(long offset, SeekOrigin origin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SqlStreamChars.NativeMethodInfoPtr_Seek_Public_Abstract_Virtual_New_Int64_Int64_SeekOrigin_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x00006F11 File Offset: 0x00005111
		public SqlStreamChars(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DD4 RID: 3540
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Abstract_Virtual_New_get_Int64_0;

		// Token: 0x04000DD5 RID: 3541
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Abstract_Virtual_New_get_Int64_0;

		// Token: 0x04000DD6 RID: 3542
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000DD7 RID: 3543
		private static readonly IntPtr NativeMethodInfoPtr_Seek_Public_Abstract_Virtual_New_Int64_Int64_SeekOrigin_0;
	}
}
