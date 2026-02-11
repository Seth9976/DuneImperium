using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000379 RID: 889
	[Serializable]
	public class ExternalException : SystemException
	{
		// Token: 0x0600375E RID: 14174 RVA: 0x0010F0C0 File Offset: 0x0010D2C0
		// Note: this type is marked as 'beforefieldinit'.
		static ExternalException()
		{
			Il2CppClassPointerStore<ExternalException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "ExternalException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExternalException>.NativeClassPtr);
			ExternalException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalException>.NativeClassPtr, 100671595);
			ExternalException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalException>.NativeClassPtr, 100671596);
			ExternalException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalException>.NativeClassPtr, 100671597);
			ExternalException.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalException>.NativeClassPtr, 100671598);
			ExternalException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalException>.NativeClassPtr, 100671599);
			ExternalException.NativeMethodInfoPtr_get_ErrorCode_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalException>.NativeClassPtr, 100671600);
			ExternalException.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalException>.NativeClassPtr, 100671601);
		}

		// Token: 0x0600375F RID: 14175 RVA: 0x0010F17C File Offset: 0x0010D37C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1391207, RefRangeEnd = 1391208, XrefRangeStart = 1391204, XrefRangeEnd = 1391207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExternalException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExternalException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003760 RID: 14176 RVA: 0x0010F1B8 File Offset: 0x0010D3B8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1391209, RefRangeEnd = 1391213, XrefRangeStart = 1391208, XrefRangeEnd = 1391209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExternalException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExternalException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003761 RID: 14177 RVA: 0x0010F204 File Offset: 0x0010D404
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1391214, RefRangeEnd = 1391215, XrefRangeStart = 1391213, XrefRangeEnd = 1391214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExternalException(string message, Exception inner)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExternalException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003762 RID: 14178 RVA: 0x0010F264 File Offset: 0x0010D464
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 1391216, RefRangeEnd = 1391240, XrefRangeStart = 1391215, XrefRangeEnd = 1391216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExternalException(string message, int errorCode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExternalException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalException.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003763 RID: 14179 RVA: 0x0010F2C0 File Offset: 0x0010D4C0
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExternalException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExternalException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x06003764 RID: 14180 RVA: 0x0010F324 File Offset: 0x0010D524
		public unsafe virtual int ErrorCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExternalException.NativeMethodInfoPtr_get_ErrorCode_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003765 RID: 14181 RVA: 0x0010F36C File Offset: 0x0010D56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391240, XrefRangeEnd = 1391262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExternalException.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003766 RID: 14182 RVA: 0x000143F8 File Offset: 0x000125F8
		public ExternalException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002CFC RID: 11516
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002CFD RID: 11517
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04002CFE RID: 11518
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x04002CFF RID: 11519
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;

		// Token: 0x04002D00 RID: 11520
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04002D01 RID: 11521
		private static readonly IntPtr NativeMethodInfoPtr_get_ErrorCode_Public_Virtual_New_get_Int32_0;

		// Token: 0x04002D02 RID: 11522
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
