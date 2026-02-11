using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000318 RID: 792
	[Serializable]
	public class SerializationException : SystemException
	{
		// Token: 0x0600308B RID: 12427 RVA: 0x000F7AFC File Offset: 0x000F5CFC
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationException()
		{
			Il2CppClassPointerStore<SerializationException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SerializationException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationException>.NativeClassPtr);
			SerializationException.NativeFieldInfoPtr_s_nullMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationException>.NativeClassPtr, "s_nullMessage");
			SerializationException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationException>.NativeClassPtr, 100670955);
			SerializationException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationException>.NativeClassPtr, 100670956);
			SerializationException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationException>.NativeClassPtr, 100670957);
			SerializationException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationException>.NativeClassPtr, 100670958);
		}

		// Token: 0x0600308C RID: 12428 RVA: 0x000F7B90 File Offset: 0x000F5D90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1384462, RefRangeEnd = 1384465, XrefRangeStart = 1384457, XrefRangeEnd = 1384462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600308D RID: 12429 RVA: 0x000F7BCC File Offset: 0x000F5DCC
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 1384466, RefRangeEnd = 1384492, XrefRangeStart = 1384465, XrefRangeEnd = 1384466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600308E RID: 12430 RVA: 0x000F7C18 File Offset: 0x000F5E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384492, XrefRangeEnd = 1384493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600308F RID: 12431 RVA: 0x000F7C78 File Offset: 0x000F5E78
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003090 RID: 12432 RVA: 0x00010AD2 File Offset: 0x0000ECD2
		public SerializationException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06003091 RID: 12433 RVA: 0x000F7CDC File Offset: 0x000F5EDC
		// (set) Token: 0x06003092 RID: 12434 RVA: 0x00010ADB File Offset: 0x0000ECDB
		public unsafe static string s_nullMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SerializationException.NativeFieldInfoPtr_s_nullMessage, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SerializationException.NativeFieldInfoPtr_s_nullMessage, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400281A RID: 10266
		private static readonly IntPtr NativeFieldInfoPtr_s_nullMessage;

		// Token: 0x0400281B RID: 10267
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400281C RID: 10268
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400281D RID: 10269
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x0400281E RID: 10270
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
