using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000FA RID: 250
	[Serializable]
	public class TypeAccessException : TypeLoadException
	{
		// Token: 0x060010A0 RID: 4256 RVA: 0x000745B0 File Offset: 0x000727B0
		// Note: this type is marked as 'beforefieldinit'.
		static TypeAccessException()
		{
			Il2CppClassPointerStore<TypeAccessException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TypeAccessException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeAccessException>.NativeClassPtr);
			TypeAccessException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeAccessException>.NativeClassPtr, 100666212);
			TypeAccessException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeAccessException>.NativeClassPtr, 100666213);
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x00074608 File Offset: 0x00072808
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1327035, RefRangeEnd = 1327036, XrefRangeStart = 1327032, XrefRangeEnd = 1327035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeAccessException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeAccessException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeAccessException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x00074644 File Offset: 0x00072844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeAccessException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeAccessException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeAccessException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x00005D9A File Offset: 0x00003F9A
		public TypeAccessException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D97 RID: 3479
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000D98 RID: 3480
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
