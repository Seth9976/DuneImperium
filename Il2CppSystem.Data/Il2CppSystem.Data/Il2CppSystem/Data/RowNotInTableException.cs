using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Data
{
	// Token: 0x02000014 RID: 20
	[Serializable]
	public class RowNotInTableException : DataException
	{
		// Token: 0x0600013C RID: 316 RVA: 0x0000D1AC File Offset: 0x0000B3AC
		// Note: this type is marked as 'beforefieldinit'.
		static RowNotInTableException()
		{
			Il2CppClassPointerStore<RowNotInTableException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "RowNotInTableException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RowNotInTableException>.NativeClassPtr);
			RowNotInTableException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RowNotInTableException>.NativeClassPtr, 100663483);
			RowNotInTableException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RowNotInTableException>.NativeClassPtr, 100663484);
			RowNotInTableException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RowNotInTableException>.NativeClassPtr, 100663485);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0000D218 File Offset: 0x0000B418
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RowNotInTableException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RowNotInTableException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RowNotInTableException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000D27C File Offset: 0x0000B47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888629, XrefRangeEnd = 888632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RowNotInTableException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RowNotInTableException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RowNotInTableException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0000D2B8 File Offset: 0x0000B4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888632, XrefRangeEnd = 888633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RowNotInTableException(string s)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RowNotInTableException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RowNotInTableException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0000266C File Offset: 0x0000086C
		public RowNotInTableException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
