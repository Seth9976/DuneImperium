using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.NetworkInformation
{
	// Token: 0x0200021F RID: 543
	public class Win32NetworkInterface : Object
	{
		// Token: 0x06002471 RID: 9329 RVA: 0x000A89CC File Offset: 0x000A6BCC
		// Note: this type is marked as 'beforefieldinit'.
		static Win32NetworkInterface()
		{
			Il2CppClassPointerStore<Win32NetworkInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "Win32NetworkInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32NetworkInterface>.NativeClassPtr);
			Win32NetworkInterface.NativeFieldInfoPtr_fixedInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32NetworkInterface>.NativeClassPtr, "fixedInfo");
			Win32NetworkInterface.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32NetworkInterface>.NativeClassPtr, "initialized");
			Win32NetworkInterface.NativeMethodInfoPtr_GetNetworkParams_Private_Static_Int32_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32NetworkInterface>.NativeClassPtr, 100668737);
			Win32NetworkInterface.NativeMethodInfoPtr_MultiByteToWideChar_Private_Static_Int32_UInt32_UInt32_ptr_Byte_Int32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32NetworkInterface>.NativeClassPtr, 100668738);
			Win32NetworkInterface.NativeMethodInfoPtr_get_FixedInfo_Public_Static_get_Win32_FIXED_INFO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32NetworkInterface>.NativeClassPtr, 100668739);
			Win32NetworkInterface.NativeMethodInfoPtr_Method_Internal_Static_String_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32NetworkInterface>.NativeClassPtr, 100668740);
		}

		// Token: 0x06002472 RID: 9330 RVA: 0x000A8A74 File Offset: 0x000A6C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486999, XrefRangeEnd = 487002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetNetworkParams(IntPtr ptr, ref int size)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32NetworkInterface.NativeMethodInfoPtr_GetNetworkParams_Private_Static_Int32_IntPtr_byref_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002473 RID: 9331 RVA: 0x000A8AC0 File Offset: 0x000A6CC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 487005, RefRangeEnd = 487007, XrefRangeStart = 487002, XrefRangeEnd = 487005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int MultiByteToWideChar(uint CodePage, uint dwFlags, byte* lpMultiByteStr, int cbMultiByte, char* lpWideCharStr, int cchWideChar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref CodePage;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dwFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = lpMultiByteStr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbMultiByte;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = lpWideCharStr;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchWideChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32NetworkInterface.NativeMethodInfoPtr_MultiByteToWideChar_Private_Static_Int32_UInt32_UInt32_ptr_Byte_Int32_ptr_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x06002474 RID: 9332 RVA: 0x000A8B44 File Offset: 0x000A6D44
		public unsafe static Win32_FIXED_INFO FixedInfo
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 487035, RefRangeEnd = 487036, XrefRangeStart = 487007, XrefRangeEnd = 487035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32NetworkInterface.NativeMethodInfoPtr_get_FixedInfo_Public_Static_get_Win32_FIXED_INFO_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Win32_FIXED_INFO(intPtr);
			}
		}

		// Token: 0x06002475 RID: 9333 RVA: 0x000A8B70 File Offset: 0x000A6D70
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 487045, RefRangeEnd = 487048, XrefRangeStart = 487036, XrefRangeEnd = 487045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Method_Internal_Static_String_ptr_Byte_0(byte* bytes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = bytes;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32NetworkInterface.NativeMethodInfoPtr_Method_Internal_Static_String_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002476 RID: 9334 RVA: 0x0000FC29 File Offset: 0x0000DE29
		public Win32NetworkInterface(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x06002477 RID: 9335 RVA: 0x000A8BA8 File Offset: 0x000A6DA8
		// (set) Token: 0x06002478 RID: 9336 RVA: 0x0000FC32 File Offset: 0x0000DE32
		public unsafe static Win32_FIXED_INFO fixedInfo
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(Win32NetworkInterface.NativeFieldInfoPtr_fixedInfo, intPtr);
				return new Win32_FIXED_INFO(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Win32NetworkInterface.NativeFieldInfoPtr_fixedInfo, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x06002479 RID: 9337 RVA: 0x000A8BE4 File Offset: 0x000A6DE4
		// (set) Token: 0x0600247A RID: 9338 RVA: 0x0000FC49 File Offset: 0x0000DE49
		public unsafe static bool initialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Win32NetworkInterface.NativeFieldInfoPtr_initialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Win32NetworkInterface.NativeFieldInfoPtr_initialized, (void*)(&value));
			}
		}

		// Token: 0x04001C47 RID: 7239
		private static readonly IntPtr NativeFieldInfoPtr_fixedInfo;

		// Token: 0x04001C48 RID: 7240
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x04001C49 RID: 7241
		private static readonly IntPtr NativeMethodInfoPtr_GetNetworkParams_Private_Static_Int32_IntPtr_byref_Int32_0;

		// Token: 0x04001C4A RID: 7242
		private static readonly IntPtr NativeMethodInfoPtr_MultiByteToWideChar_Private_Static_Int32_UInt32_UInt32_ptr_Byte_Int32_ptr_Char_Int32_0;

		// Token: 0x04001C4B RID: 7243
		private static readonly IntPtr NativeMethodInfoPtr_get_FixedInfo_Public_Static_get_Win32_FIXED_INFO_0;

		// Token: 0x04001C4C RID: 7244
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_String_ptr_Byte_0;
	}
}
