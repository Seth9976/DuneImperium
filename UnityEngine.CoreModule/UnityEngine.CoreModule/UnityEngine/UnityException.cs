using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.Serialization;

namespace UnityEngine
{
	// Token: 0x0200014F RID: 335
	[Serializable]
	public class UnityException : Exception
	{
		// Token: 0x0600192E RID: 6446 RVA: 0x000762A8 File Offset: 0x000744A8
		// Note: this type is marked as 'beforefieldinit'.
		static UnityException()
		{
			Il2CppClassPointerStore<UnityException>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "UnityException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityException>.NativeClassPtr);
			UnityException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityException>.NativeClassPtr, 100666765);
			UnityException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityException>.NativeClassPtr, 100666766);
			UnityException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityException>.NativeClassPtr, 100666767);
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x00076314 File Offset: 0x00074514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 667321, XrefRangeEnd = 667327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x00076350 File Offset: 0x00074550
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 667331, RefRangeEnd = 667335, XrefRangeStart = 667327, XrefRangeEnd = 667331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x0007639C File Offset: 0x0007459C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 667335, XrefRangeEnd = 667339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x00009D65 File Offset: 0x00007F65
		public UnityException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400166E RID: 5742
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400166F RID: 5743
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001670 RID: 5744
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001671 RID: 5745
		public const int Result = -2147467261;
	}
}
