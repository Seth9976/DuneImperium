using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000076 RID: 118
	[Serializable]
	public class ArrayTypeMismatchException : SystemException
	{
		// Token: 0x06000697 RID: 1687 RVA: 0x000438DC File Offset: 0x00041ADC
		// Note: this type is marked as 'beforefieldinit'.
		static ArrayTypeMismatchException()
		{
			Il2CppClassPointerStore<ArrayTypeMismatchException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ArrayTypeMismatchException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayTypeMismatchException>.NativeClassPtr);
			ArrayTypeMismatchException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTypeMismatchException>.NativeClassPtr, 100664396);
			ArrayTypeMismatchException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTypeMismatchException>.NativeClassPtr, 100664397);
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00043934 File Offset: 0x00041B34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1298895, RefRangeEnd = 1298897, XrefRangeStart = 1298892, XrefRangeEnd = 1298895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayTypeMismatchException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayTypeMismatchException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTypeMismatchException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00043970 File Offset: 0x00041B70
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayTypeMismatchException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayTypeMismatchException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTypeMismatchException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00004012 File Offset: 0x00002212
		public ArrayTypeMismatchException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
