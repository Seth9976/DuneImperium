using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x0200011F RID: 287
	[Serializable]
	public class OutOfMemoryException : SystemException
	{
		// Token: 0x060012CB RID: 4811 RVA: 0x0007FFC0 File Offset: 0x0007E1C0
		// Note: this type is marked as 'beforefieldinit'.
		static OutOfMemoryException()
		{
			Il2CppClassPointerStore<OutOfMemoryException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "OutOfMemoryException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutOfMemoryException>.NativeClassPtr);
			OutOfMemoryException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutOfMemoryException>.NativeClassPtr, 100666573);
			OutOfMemoryException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutOfMemoryException>.NativeClassPtr, 100666574);
			OutOfMemoryException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutOfMemoryException>.NativeClassPtr, 100666575);
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x0008002C File Offset: 0x0007E22C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1334998, RefRangeEnd = 1334999, XrefRangeStart = 1334992, XrefRangeEnd = 1334998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OutOfMemoryException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutOfMemoryException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutOfMemoryException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x00080068 File Offset: 0x0007E268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1334999, XrefRangeEnd = 1335003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OutOfMemoryException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutOfMemoryException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutOfMemoryException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x000800B4 File Offset: 0x0007E2B4
		[CallerCount(66)]
		[CachedScanResults(RefRangeStart = 1318224, RefRangeEnd = 1318290, XrefRangeStart = 1318224, XrefRangeEnd = 1318290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OutOfMemoryException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutOfMemoryException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutOfMemoryException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x0000627F File Offset: 0x0000447F
		public OutOfMemoryException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001002 RID: 4098
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001003 RID: 4099
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001004 RID: 4100
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
