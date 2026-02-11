using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Internal
{
	// Token: 0x0200000D RID: 13
	public static class InputUnsafeUtility : Object
	{
		// Token: 0x0600008A RID: 138 RVA: 0x00003FE8 File Offset: 0x000021E8
		// Note: this type is marked as 'beforefieldinit'.
		static InputUnsafeUtility()
		{
			Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputLegacyModule.dll", "UnityEngine.Internal", "InputUnsafeUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr);
			InputUnsafeUtility.NativeMethodInfoPtr_GetKeyString_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr, 100663370);
			InputUnsafeUtility.NativeMethodInfoPtr_GetKeyString__Unmanaged_Internal_Static_Boolean_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr, 100663371);
			InputUnsafeUtility.NativeMethodInfoPtr_GetKeyUpString__Unmanaged_Internal_Static_Boolean_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr, 100663372);
			InputUnsafeUtility.NativeMethodInfoPtr_GetKeyDownString_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr, 100663373);
			InputUnsafeUtility.NativeMethodInfoPtr_GetKeyDownString__Unmanaged_Internal_Static_Boolean_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr, 100663374);
			InputUnsafeUtility.NativeMethodInfoPtr_GetAxis_Internal_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr, 100663375);
			InputUnsafeUtility.NativeMethodInfoPtr_GetAxis__Unmanaged_Internal_Static_Single_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr, 100663376);
			InputUnsafeUtility.NativeMethodInfoPtr_GetAxisRaw_Internal_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr, 100663377);
			InputUnsafeUtility.NativeMethodInfoPtr_GetAxisRaw__Unmanaged_Internal_Static_Single_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr, 100663378);
			InputUnsafeUtility.NativeMethodInfoPtr_GetButton_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr, 100663379);
			InputUnsafeUtility.NativeMethodInfoPtr_GetButton__Unmanaged_Internal_Static_Boolean_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr, 100663380);
			InputUnsafeUtility.NativeMethodInfoPtr_GetButtonDown_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr, 100663381);
			InputUnsafeUtility.NativeMethodInfoPtr_GetButtonDown__Unmanaged_Internal_Static_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr, 100663382);
			InputUnsafeUtility.NativeMethodInfoPtr_GetButtonUp_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr, 100663383);
			InputUnsafeUtility.NativeMethodInfoPtr_GetButtonUp__Unmanaged_Internal_Static_Boolean_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr, 100663384);
			InputUnsafeUtility.GetKeyUpStringDelegateField = IL2CPP.ResolveICall<InputUnsafeUtility.GetKeyUpStringDelegate>("UnityEngine.Internal.InputUnsafeUtility::GetKeyUpString");
			InputUnsafeUtility.IsJoystickPreconfiguredDelegateField = IL2CPP.ResolveICall<InputUnsafeUtility.IsJoystickPreconfiguredDelegate>("UnityEngine.Internal.InputUnsafeUtility::IsJoystickPreconfigured");
			InputUnsafeUtility.IsJoystickPreconfigured__UnmanagedDelegateField = IL2CPP.ResolveICall<InputUnsafeUtility.IsJoystickPreconfigured__UnmanagedDelegate>("UnityEngine.Internal.InputUnsafeUtility::IsJoystickPreconfigured__Unmanaged");
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00004174 File Offset: 0x00002374
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1266972, RefRangeEnd = 1266973, XrefRangeStart = 1266972, XrefRangeEnd = 1266973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetKeyString(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputUnsafeUtility.NativeMethodInfoPtr_GetKeyString_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000041B8 File Offset: 0x000023B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267391, XrefRangeEnd = 1267393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetKeyString__Unmanaged(byte* name, int nameLen)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameLen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputUnsafeUtility.NativeMethodInfoPtr_GetKeyString__Unmanaged_Internal_Static_Boolean_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00004204 File Offset: 0x00002404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267393, XrefRangeEnd = 1267395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetKeyUpString__Unmanaged(byte* name, int nameLen)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameLen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputUnsafeUtility.NativeMethodInfoPtr_GetKeyUpString__Unmanaged_Internal_Static_Boolean_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00004250 File Offset: 0x00002450
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1266975, RefRangeEnd = 1266977, XrefRangeStart = 1266975, XrefRangeEnd = 1266977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetKeyDownString(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputUnsafeUtility.NativeMethodInfoPtr_GetKeyDownString_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00004294 File Offset: 0x00002494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267395, XrefRangeEnd = 1267397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetKeyDownString__Unmanaged(byte* name, int nameLen)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameLen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputUnsafeUtility.NativeMethodInfoPtr_GetKeyDownString__Unmanaged_Internal_Static_Boolean_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000042E0 File Offset: 0x000024E0
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1266767, RefRangeEnd = 1266782, XrefRangeStart = 1266767, XrefRangeEnd = 1266782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetAxis(string axisName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(axisName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputUnsafeUtility.NativeMethodInfoPtr_GetAxis_Internal_Static_Single_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00004324 File Offset: 0x00002524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267397, XrefRangeEnd = 1267399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetAxis__Unmanaged(byte* axisName, int axisNameLen)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = axisName;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisNameLen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputUnsafeUtility.NativeMethodInfoPtr_GetAxis__Unmanaged_Internal_Static_Single_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00004370 File Offset: 0x00002570
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1266784, RefRangeEnd = 1266798, XrefRangeStart = 1266784, XrefRangeEnd = 1266798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetAxisRaw(string axisName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(axisName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputUnsafeUtility.NativeMethodInfoPtr_GetAxisRaw_Internal_Static_Single_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000043B4 File Offset: 0x000025B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267399, XrefRangeEnd = 1267401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetAxisRaw__Unmanaged(byte* axisName, int axisNameLen)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = axisName;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisNameLen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputUnsafeUtility.NativeMethodInfoPtr_GetAxisRaw__Unmanaged_Internal_Static_Single_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00004400 File Offset: 0x00002600
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1266800, RefRangeEnd = 1266802, XrefRangeStart = 1266800, XrefRangeEnd = 1266802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetButton(string buttonName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(buttonName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputUnsafeUtility.NativeMethodInfoPtr_GetButton_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00004444 File Offset: 0x00002644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267401, XrefRangeEnd = 1267403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetButton__Unmanaged(byte* buttonName, int buttonNameLen)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = buttonName;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buttonNameLen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputUnsafeUtility.NativeMethodInfoPtr_GetButton__Unmanaged_Internal_Static_Boolean_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00004490 File Offset: 0x00002690
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1266804, RefRangeEnd = 1266807, XrefRangeStart = 1266804, XrefRangeEnd = 1266807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetButtonDown(string buttonName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(buttonName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputUnsafeUtility.NativeMethodInfoPtr_GetButtonDown_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000044D4 File Offset: 0x000026D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267403, XrefRangeEnd = 1267405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte GetButtonDown__Unmanaged(byte* buttonName, int buttonNameLen)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = buttonName;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buttonNameLen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputUnsafeUtility.NativeMethodInfoPtr_GetButtonDown__Unmanaged_Internal_Static_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00004520 File Offset: 0x00002720
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1266809, RefRangeEnd = 1266811, XrefRangeStart = 1266809, XrefRangeEnd = 1266811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetButtonUp(string buttonName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(buttonName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputUnsafeUtility.NativeMethodInfoPtr_GetButtonUp_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00004564 File Offset: 0x00002764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267405, XrefRangeEnd = 1267407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetButtonUp__Unmanaged(byte* buttonName, int buttonNameLen)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = buttonName;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buttonNameLen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputUnsafeUtility.NativeMethodInfoPtr_GetButtonUp__Unmanaged_Internal_Static_Boolean_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000022CB File Offset: 0x000004CB
		public InputUnsafeUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000022D4 File Offset: 0x000004D4
		public static bool GetKeyUpString(string name)
		{
			return InputUnsafeUtility.GetKeyUpStringDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000022E6 File Offset: 0x000004E6
		public static bool IsJoystickPreconfigured(string joystickName)
		{
			return InputUnsafeUtility.IsJoystickPreconfiguredDelegateField(IL2CPP.ManagedStringToIl2Cpp(joystickName));
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000022F8 File Offset: 0x000004F8
		public unsafe static bool IsJoystickPreconfigured__Unmanaged(byte* joystickName, int joystickNameLen)
		{
			return InputUnsafeUtility.IsJoystickPreconfigured__UnmanagedDelegateField(joystickName, joystickNameLen);
		}

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyString_Internal_Static_Boolean_String_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyString__Unmanaged_Internal_Static_Boolean_ptr_Byte_Int32_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyUpString__Unmanaged_Internal_Static_Boolean_ptr_Byte_Int32_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyDownString_Internal_Static_Boolean_String_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyDownString__Unmanaged_Internal_Static_Boolean_ptr_Byte_Int32_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_GetAxis_Internal_Static_Single_String_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_GetAxis__Unmanaged_Internal_Static_Single_ptr_Byte_Int32_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisRaw_Internal_Static_Single_String_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisRaw__Unmanaged_Internal_Static_Single_ptr_Byte_Int32_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_GetButton_Internal_Static_Boolean_String_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_GetButton__Unmanaged_Internal_Static_Boolean_ptr_Byte_Int32_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonDown_Internal_Static_Boolean_String_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonDown__Unmanaged_Internal_Static_Byte_ptr_Byte_Int32_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonUp_Internal_Static_Boolean_String_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonUp__Unmanaged_Internal_Static_Boolean_ptr_Byte_Int32_0;

		// Token: 0x040000BF RID: 191
		private static readonly InputUnsafeUtility.GetKeyUpStringDelegate GetKeyUpStringDelegateField;

		// Token: 0x040000C0 RID: 192
		private static readonly InputUnsafeUtility.IsJoystickPreconfiguredDelegate IsJoystickPreconfiguredDelegateField;

		// Token: 0x040000C1 RID: 193
		private static readonly InputUnsafeUtility.IsJoystickPreconfigured__UnmanagedDelegate IsJoystickPreconfigured__UnmanagedDelegateField;

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x060000FF RID: 255
		private delegate bool GetKeyUpStringDelegate(IntPtr name);

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x06000101 RID: 257
		private delegate bool IsJoystickPreconfiguredDelegate(IntPtr joystickName);

		// Token: 0x0200002A RID: 42
		// (Invoke) Token: 0x06000103 RID: 259
		private delegate bool IsJoystickPreconfigured__UnmanagedDelegate(IntPtr joystickName, int joystickNameLen);
	}
}
