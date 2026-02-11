using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.Serialization;

namespace UnityEngine
{
	// Token: 0x02000150 RID: 336
	[Serializable]
	public class MissingReferenceException : Exception
	{
		// Token: 0x06001933 RID: 6451 RVA: 0x00076400 File Offset: 0x00074600
		// Note: this type is marked as 'beforefieldinit'.
		static MissingReferenceException()
		{
			Il2CppClassPointerStore<MissingReferenceException>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "MissingReferenceException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissingReferenceException>.NativeClassPtr);
			MissingReferenceException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingReferenceException>.NativeClassPtr, 100666768);
			MissingReferenceException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingReferenceException>.NativeClassPtr, 100666769);
			MissingReferenceException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingReferenceException>.NativeClassPtr, 100666770);
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x0007646C File Offset: 0x0007466C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 667339, XrefRangeEnd = 667345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingReferenceException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingReferenceException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingReferenceException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x000764A8 File Offset: 0x000746A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 667349, RefRangeEnd = 667350, XrefRangeStart = 667345, XrefRangeEnd = 667349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingReferenceException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingReferenceException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingReferenceException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x000764F4 File Offset: 0x000746F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 667350, XrefRangeEnd = 667354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingReferenceException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingReferenceException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingReferenceException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x00009D6E File Offset: 0x00007F6E
		public MissingReferenceException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001672 RID: 5746
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001673 RID: 5747
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001674 RID: 5748
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001675 RID: 5749
		public const int Result = -2147467261;
	}
}
