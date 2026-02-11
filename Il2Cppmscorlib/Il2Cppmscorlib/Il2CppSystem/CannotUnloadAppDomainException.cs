using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x0200011B RID: 283
	[Serializable]
	public class CannotUnloadAppDomainException : SystemException
	{
		// Token: 0x0600129F RID: 4767 RVA: 0x0007F4F8 File Offset: 0x0007D6F8
		// Note: this type is marked as 'beforefieldinit'.
		static CannotUnloadAppDomainException()
		{
			Il2CppClassPointerStore<CannotUnloadAppDomainException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "CannotUnloadAppDomainException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CannotUnloadAppDomainException>.NativeClassPtr);
			CannotUnloadAppDomainException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CannotUnloadAppDomainException>.NativeClassPtr, 100666551);
			CannotUnloadAppDomainException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CannotUnloadAppDomainException>.NativeClassPtr, 100666552);
			CannotUnloadAppDomainException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CannotUnloadAppDomainException>.NativeClassPtr, 100666553);
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x0007F564 File Offset: 0x0007D764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1334776, XrefRangeEnd = 1334782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CannotUnloadAppDomainException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CannotUnloadAppDomainException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CannotUnloadAppDomainException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x0007F5A0 File Offset: 0x0007D7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1334782, XrefRangeEnd = 1334786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CannotUnloadAppDomainException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CannotUnloadAppDomainException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CannotUnloadAppDomainException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x0007F5EC File Offset: 0x0007D7EC
		[CallerCount(66)]
		[CachedScanResults(RefRangeStart = 1318224, RefRangeEnd = 1318290, XrefRangeStart = 1318224, XrefRangeEnd = 1318290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CannotUnloadAppDomainException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CannotUnloadAppDomainException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CannotUnloadAppDomainException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x00006186 File Offset: 0x00004386
		public CannotUnloadAppDomainException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FE5 RID: 4069
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000FE6 RID: 4070
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000FE7 RID: 4071
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
