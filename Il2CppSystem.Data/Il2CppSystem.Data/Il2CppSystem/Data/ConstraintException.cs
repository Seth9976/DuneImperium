using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Data
{
	// Token: 0x0200000D RID: 13
	[Serializable]
	public class ConstraintException : DataException
	{
		// Token: 0x06000119 RID: 281 RVA: 0x0000C844 File Offset: 0x0000AA44
		// Note: this type is marked as 'beforefieldinit'.
		static ConstraintException()
		{
			Il2CppClassPointerStore<ConstraintException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "ConstraintException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstraintException>.NativeClassPtr);
			ConstraintException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintException>.NativeClassPtr, 100663462);
			ConstraintException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintException>.NativeClassPtr, 100663463);
			ConstraintException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintException>.NativeClassPtr, 100663464);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000C8B0 File Offset: 0x0000AAB0
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstraintException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstraintException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstraintException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000C914 File Offset: 0x0000AB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888601, XrefRangeEnd = 888604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstraintException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstraintException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstraintException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000C950 File Offset: 0x0000AB50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888604, XrefRangeEnd = 888605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstraintException(string s)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstraintException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstraintException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000262D File Offset: 0x0000082D
		public ConstraintException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
