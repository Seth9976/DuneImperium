using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000094 RID: 148
	[Serializable]
	public class FormatException : SystemException
	{
		// Token: 0x06000A16 RID: 2582 RVA: 0x00053614 File Offset: 0x00051814
		// Note: this type is marked as 'beforefieldinit'.
		static FormatException()
		{
			Il2CppClassPointerStore<FormatException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "FormatException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormatException>.NativeClassPtr);
			FormatException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatException>.NativeClassPtr, 100665057);
			FormatException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatException>.NativeClassPtr, 100665058);
			FormatException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatException>.NativeClassPtr, 100665059);
			FormatException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatException>.NativeClassPtr, 100665060);
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x00053694 File Offset: 0x00051894
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1304620, RefRangeEnd = 1304623, XrefRangeStart = 1304617, XrefRangeEnd = 1304620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormatException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x000536D0 File Offset: 0x000518D0
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 1304624, RefRangeEnd = 1304650, XrefRangeStart = 1304623, XrefRangeEnd = 1304624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormatException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x0005371C File Offset: 0x0005191C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1304651, RefRangeEnd = 1304656, XrefRangeStart = 1304650, XrefRangeEnd = 1304651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormatException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x0005377C File Offset: 0x0005197C
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormatException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x000047D7 File Offset: 0x000029D7
		public FormatException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
