using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.IO
{
	// Token: 0x0200051D RID: 1309
	[Serializable]
	public class EndOfStreamException : IOException
	{
		// Token: 0x06004FED RID: 20461 RVA: 0x00173FE0 File Offset: 0x001721E0
		// Note: this type is marked as 'beforefieldinit'.
		static EndOfStreamException()
		{
			Il2CppClassPointerStore<EndOfStreamException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "EndOfStreamException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndOfStreamException>.NativeClassPtr);
			EndOfStreamException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndOfStreamException>.NativeClassPtr, 100675370);
			EndOfStreamException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndOfStreamException>.NativeClassPtr, 100675371);
			EndOfStreamException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndOfStreamException>.NativeClassPtr, 100675372);
		}

		// Token: 0x06004FEE RID: 20462 RVA: 0x0017404C File Offset: 0x0017224C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427201, XrefRangeEnd = 1427204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EndOfStreamException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndOfStreamException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndOfStreamException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FEF RID: 20463 RVA: 0x00174088 File Offset: 0x00172288
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1427205, RefRangeEnd = 1427206, XrefRangeStart = 1427204, XrefRangeEnd = 1427205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EndOfStreamException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndOfStreamException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndOfStreamException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004FF0 RID: 20464 RVA: 0x001740D4 File Offset: 0x001722D4
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EndOfStreamException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndOfStreamException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndOfStreamException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FF1 RID: 20465 RVA: 0x0001CA03 File Offset: 0x0001AC03
		public EndOfStreamException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04004123 RID: 16675
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004124 RID: 16676
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04004125 RID: 16677
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
