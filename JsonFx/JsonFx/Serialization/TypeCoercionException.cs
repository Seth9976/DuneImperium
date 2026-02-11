using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.Serialization;

namespace JsonFx.Serialization
{
	// Token: 0x02000010 RID: 16
	public class TypeCoercionException : ArgumentException
	{
		// Token: 0x060000A4 RID: 164 RVA: 0x00006000 File Offset: 0x00004200
		// Note: this type is marked as 'beforefieldinit'.
		static TypeCoercionException()
		{
			Il2CppClassPointerStore<TypeCoercionException>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Serialization", "TypeCoercionException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeCoercionException>.NativeClassPtr);
			TypeCoercionException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeCoercionException>.NativeClassPtr, 100663365);
			TypeCoercionException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeCoercionException>.NativeClassPtr, 100663366);
			TypeCoercionException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeCoercionException>.NativeClassPtr, 100663367);
			TypeCoercionException.NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeCoercionException>.NativeClassPtr, 100663368);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00006080 File Offset: 0x00004280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189814, XrefRangeEnd = 1189815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeCoercionException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeCoercionException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeCoercionException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000060BC File Offset: 0x000042BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 456364, RefRangeEnd = 456365, XrefRangeStart = 456364, XrefRangeEnd = 456365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeCoercionException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeCoercionException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeCoercionException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00006108 File Offset: 0x00004308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189815, XrefRangeEnd = 1189816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeCoercionException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeCoercionException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeCoercionException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00006168 File Offset: 0x00004368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeCoercionException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeCoercionException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeCoercionException.NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000242C File Offset: 0x0000062C
		public TypeCoercionException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0;
	}
}
