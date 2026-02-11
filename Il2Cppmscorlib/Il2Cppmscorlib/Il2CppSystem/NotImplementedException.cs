using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000CB RID: 203
	[Serializable]
	public class NotImplementedException : SystemException
	{
		// Token: 0x06000D0E RID: 3342 RVA: 0x00062500 File Offset: 0x00060700
		// Note: this type is marked as 'beforefieldinit'.
		static NotImplementedException()
		{
			Il2CppClassPointerStore<NotImplementedException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "NotImplementedException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotImplementedException>.NativeClassPtr);
			NotImplementedException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotImplementedException>.NativeClassPtr, 100665585);
			NotImplementedException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotImplementedException>.NativeClassPtr, 100665586);
			NotImplementedException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotImplementedException>.NativeClassPtr, 100665587);
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x0006256C File Offset: 0x0006076C
		[CallerCount(1980)]
		[CachedScanResults(RefRangeStart = 1311492, RefRangeEnd = 1313472, XrefRangeStart = 1311489, XrefRangeEnd = 1311492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotImplementedException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotImplementedException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotImplementedException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x000625A8 File Offset: 0x000607A8
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1313473, RefRangeEnd = 1313489, XrefRangeStart = 1313472, XrefRangeEnd = 1313473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotImplementedException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotImplementedException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotImplementedException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x000625F4 File Offset: 0x000607F4
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotImplementedException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotImplementedException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotImplementedException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x000052E6 File Offset: 0x000034E6
		public NotImplementedException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000ABB RID: 2747
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000ABC RID: 2748
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000ABD RID: 2749
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
