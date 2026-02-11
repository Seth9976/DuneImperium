using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x0200011A RID: 282
	[Serializable]
	public class AppDomainUnloadedException : SystemException
	{
		// Token: 0x0600129B RID: 4763 RVA: 0x0007F400 File Offset: 0x0007D600
		// Note: this type is marked as 'beforefieldinit'.
		static AppDomainUnloadedException()
		{
			Il2CppClassPointerStore<AppDomainUnloadedException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "AppDomainUnloadedException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppDomainUnloadedException>.NativeClassPtr);
			AppDomainUnloadedException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomainUnloadedException>.NativeClassPtr, 100666549);
			AppDomainUnloadedException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomainUnloadedException>.NativeClassPtr, 100666550);
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x0007F458 File Offset: 0x0007D658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1334770, XrefRangeEnd = 1334776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppDomainUnloadedException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppDomainUnloadedException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomainUnloadedException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x0007F494 File Offset: 0x0007D694
		[CallerCount(66)]
		[CachedScanResults(RefRangeStart = 1318224, RefRangeEnd = 1318290, XrefRangeStart = 1318224, XrefRangeEnd = 1318290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppDomainUnloadedException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppDomainUnloadedException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomainUnloadedException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x0000617D File Offset: 0x0000437D
		public AppDomainUnloadedException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FE3 RID: 4067
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000FE4 RID: 4068
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
