using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.IO
{
	// Token: 0x02000528 RID: 1320
	[Serializable]
	public class PathTooLongException : IOException
	{
		// Token: 0x06005076 RID: 20598 RVA: 0x00176860 File Offset: 0x00174A60
		// Note: this type is marked as 'beforefieldinit'.
		static PathTooLongException()
		{
			Il2CppClassPointerStore<PathTooLongException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "PathTooLongException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathTooLongException>.NativeClassPtr);
			PathTooLongException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathTooLongException>.NativeClassPtr, 100675464);
			PathTooLongException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathTooLongException>.NativeClassPtr, 100675465);
			PathTooLongException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathTooLongException>.NativeClassPtr, 100675466);
		}

		// Token: 0x06005077 RID: 20599 RVA: 0x001768CC File Offset: 0x00174ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427980, XrefRangeEnd = 1427983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathTooLongException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathTooLongException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathTooLongException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005078 RID: 20600 RVA: 0x00176908 File Offset: 0x00174B08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1427984, RefRangeEnd = 1427987, XrefRangeStart = 1427983, XrefRangeEnd = 1427984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathTooLongException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathTooLongException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathTooLongException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005079 RID: 20601 RVA: 0x00176954 File Offset: 0x00174B54
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathTooLongException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathTooLongException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathTooLongException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600507A RID: 20602 RVA: 0x0001CBE2 File Offset: 0x0001ADE2
		public PathTooLongException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040041A9 RID: 16809
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040041AA RID: 16810
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040041AB RID: 16811
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
