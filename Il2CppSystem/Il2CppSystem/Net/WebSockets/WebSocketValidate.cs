using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Net.WebSockets
{
	// Token: 0x02000253 RID: 595
	public static class WebSocketValidate : Object
	{
		// Token: 0x060027EE RID: 10222 RVA: 0x000B6328 File Offset: 0x000B4528
		// Note: this type is marked as 'beforefieldinit'.
		static WebSocketValidate()
		{
			Il2CppClassPointerStore<WebSocketValidate>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.WebSockets", "WebSocketValidate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebSocketValidate>.NativeClassPtr);
			WebSocketValidate.NativeMethodInfoPtr_ThrowIfInvalidState_Internal_Static_Void_WebSocketState_Boolean_Il2CppStructArray_1_WebSocketState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketValidate>.NativeClassPtr, 100669250);
			WebSocketValidate.NativeMethodInfoPtr_ValidateSubprotocol_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketValidate>.NativeClassPtr, 100669251);
			WebSocketValidate.NativeMethodInfoPtr_ValidateCloseStatus_Internal_Static_Void_WebSocketCloseStatus_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketValidate>.NativeClassPtr, 100669252);
			WebSocketValidate.NativeMethodInfoPtr_ValidateArraySegment_Internal_Static_Void_ArraySegment_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketValidate>.NativeClassPtr, 100669253);
		}

		// Token: 0x060027EF RID: 10223 RVA: 0x000B63A8 File Offset: 0x000B45A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 492784, RefRangeEnd = 492788, XrefRangeStart = 492781, XrefRangeEnd = 492784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowIfInvalidState(WebSocketState currentState, bool isDisposed, Il2CppStructArray<WebSocketState> validStates)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref currentState;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDisposed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(validStates);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketValidate.NativeMethodInfoPtr_ThrowIfInvalidState_Internal_Static_Void_WebSocketState_Boolean_Il2CppStructArray_1_WebSocketState_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x000B63FC File Offset: 0x000B45FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 492812, RefRangeEnd = 492813, XrefRangeStart = 492788, XrefRangeEnd = 492812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateSubprotocol(string subProtocol)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(subProtocol);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketValidate.NativeMethodInfoPtr_ValidateSubprotocol_Internal_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x000B6434 File Offset: 0x000B4634
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 492816, RefRangeEnd = 492818, XrefRangeStart = 492813, XrefRangeEnd = 492816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateCloseStatus(WebSocketCloseStatus closeStatus, string statusDescription)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref closeStatus;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(statusDescription);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketValidate.NativeMethodInfoPtr_ValidateCloseStatus_Internal_Static_Void_WebSocketCloseStatus_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027F2 RID: 10226 RVA: 0x000B6478 File Offset: 0x000B4678
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 492832, RefRangeEnd = 492834, XrefRangeStart = 492818, XrefRangeEnd = 492832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateArraySegment(ArraySegment<byte> arraySegment, string parameterName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(arraySegment));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parameterName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketValidate.NativeMethodInfoPtr_ValidateArraySegment_Internal_Static_Void_ArraySegment_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027F3 RID: 10227 RVA: 0x000113D2 File Offset: 0x0000F5D2
		public WebSocketValidate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001FB2 RID: 8114
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfInvalidState_Internal_Static_Void_WebSocketState_Boolean_Il2CppStructArray_1_WebSocketState_0;

		// Token: 0x04001FB3 RID: 8115
		private static readonly IntPtr NativeMethodInfoPtr_ValidateSubprotocol_Internal_Static_Void_String_0;

		// Token: 0x04001FB4 RID: 8116
		private static readonly IntPtr NativeMethodInfoPtr_ValidateCloseStatus_Internal_Static_Void_WebSocketCloseStatus_String_0;

		// Token: 0x04001FB5 RID: 8117
		private static readonly IntPtr NativeMethodInfoPtr_ValidateArraySegment_Internal_Static_Void_ArraySegment_1_Byte_String_0;
	}
}
