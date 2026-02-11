using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000092 RID: 146
	[Serializable]
	public class FieldAccessException : MemberAccessException
	{
		// Token: 0x06000A0E RID: 2574 RVA: 0x00053480 File Offset: 0x00051680
		// Note: this type is marked as 'beforefieldinit'.
		static FieldAccessException()
		{
			Il2CppClassPointerStore<FieldAccessException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "FieldAccessException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FieldAccessException>.NativeClassPtr);
			FieldAccessException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldAccessException>.NativeClassPtr, 100665053);
			FieldAccessException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldAccessException>.NativeClassPtr, 100665054);
			FieldAccessException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldAccessException>.NativeClassPtr, 100665055);
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x000534EC File Offset: 0x000516EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1304612, XrefRangeEnd = 1304615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FieldAccessException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldAccessException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldAccessException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x00053528 File Offset: 0x00051728
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1304616, RefRangeEnd = 1304617, XrefRangeStart = 1304615, XrefRangeEnd = 1304616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FieldAccessException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldAccessException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldAccessException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x00053574 File Offset: 0x00051774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FieldAccessException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldAccessException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldAccessException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x0000478C File Offset: 0x0000298C
		public FieldAccessException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
