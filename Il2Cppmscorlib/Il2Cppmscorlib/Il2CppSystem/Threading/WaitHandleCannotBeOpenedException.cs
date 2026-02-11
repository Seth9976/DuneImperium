using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000193 RID: 403
	[Serializable]
	public class WaitHandleCannotBeOpenedException : ApplicationException
	{
		// Token: 0x06001A2C RID: 6700 RVA: 0x000A0C7C File Offset: 0x0009EE7C
		// Note: this type is marked as 'beforefieldinit'.
		static WaitHandleCannotBeOpenedException()
		{
			Il2CppClassPointerStore<WaitHandleCannotBeOpenedException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "WaitHandleCannotBeOpenedException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitHandleCannotBeOpenedException>.NativeClassPtr);
			WaitHandleCannotBeOpenedException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandleCannotBeOpenedException>.NativeClassPtr, 100667858);
			WaitHandleCannotBeOpenedException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandleCannotBeOpenedException>.NativeClassPtr, 100667859);
			WaitHandleCannotBeOpenedException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandleCannotBeOpenedException>.NativeClassPtr, 100667860);
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x000A0CE8 File Offset: 0x0009EEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351638, XrefRangeEnd = 1351641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitHandleCannotBeOpenedException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitHandleCannotBeOpenedException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandleCannotBeOpenedException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x000A0D24 File Offset: 0x0009EF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351641, XrefRangeEnd = 1351642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitHandleCannotBeOpenedException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitHandleCannotBeOpenedException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandleCannotBeOpenedException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x000A0D70 File Offset: 0x0009EF70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351642, XrefRangeEnd = 1351643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitHandleCannotBeOpenedException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitHandleCannotBeOpenedException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandleCannotBeOpenedException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x000085AB File Offset: 0x000067AB
		public WaitHandleCannotBeOpenedException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001836 RID: 6198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001837 RID: 6199
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001838 RID: 6200
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
