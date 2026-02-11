using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.IO
{
	// Token: 0x02000532 RID: 1330
	[Serializable]
	public class DriveNotFoundException : IOException
	{
		// Token: 0x06005180 RID: 20864 RVA: 0x0017B564 File Offset: 0x00179764
		// Note: this type is marked as 'beforefieldinit'.
		static DriveNotFoundException()
		{
			Il2CppClassPointerStore<DriveNotFoundException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "DriveNotFoundException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DriveNotFoundException>.NativeClassPtr);
			DriveNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DriveNotFoundException>.NativeClassPtr, 100675698);
			DriveNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DriveNotFoundException>.NativeClassPtr, 100675699);
			DriveNotFoundException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DriveNotFoundException>.NativeClassPtr, 100675700);
		}

		// Token: 0x06005181 RID: 20865 RVA: 0x0017B5D0 File Offset: 0x001797D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430090, XrefRangeEnd = 1430093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DriveNotFoundException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DriveNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DriveNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005182 RID: 20866 RVA: 0x0017B60C File Offset: 0x0017980C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1430094, RefRangeEnd = 1430095, XrefRangeStart = 1430093, XrefRangeEnd = 1430094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DriveNotFoundException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DriveNotFoundException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DriveNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005183 RID: 20867 RVA: 0x0017B658 File Offset: 0x00179858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DriveNotFoundException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DriveNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DriveNotFoundException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005184 RID: 20868 RVA: 0x0001D146 File Offset: 0x0001B346
		public DriveNotFoundException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04004278 RID: 17016
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004279 RID: 17017
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400427A RID: 17018
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
