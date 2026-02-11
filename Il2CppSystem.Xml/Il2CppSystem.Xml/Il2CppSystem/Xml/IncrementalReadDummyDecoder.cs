using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200002B RID: 43
	public class IncrementalReadDummyDecoder : IncrementalReadDecoder
	{
		// Token: 0x060002C0 RID: 704 RVA: 0x00020C98 File Offset: 0x0001EE98
		// Note: this type is marked as 'beforefieldinit'.
		static IncrementalReadDummyDecoder()
		{
			Il2CppClassPointerStore<IncrementalReadDummyDecoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IncrementalReadDummyDecoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncrementalReadDummyDecoder>.NativeClassPtr);
			IncrementalReadDummyDecoder.NativeMethodInfoPtr_get_IsFull_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementalReadDummyDecoder>.NativeClassPtr, 100663676);
			IncrementalReadDummyDecoder.NativeMethodInfoPtr_Decode_Internal_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementalReadDummyDecoder>.NativeClassPtr, 100663677);
			IncrementalReadDummyDecoder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementalReadDummyDecoder>.NativeClassPtr, 100663678);
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x00020D04 File Offset: 0x0001EF04
		public unsafe override bool IsFull
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncrementalReadDummyDecoder.NativeMethodInfoPtr_get_IsFull_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00020D4C File Offset: 0x0001EF4C
		[CallerCount(0)]
		public unsafe override int Decode(Il2CppStructArray<char> chars, int startPos, int len)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncrementalReadDummyDecoder.NativeMethodInfoPtr_Decode_Internal_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00020DC0 File Offset: 0x0001EFC0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IncrementalReadDummyDecoder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncrementalReadDummyDecoder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementalReadDummyDecoder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00003020 File Offset: 0x00001220
		public IncrementalReadDummyDecoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFull_Internal_Virtual_get_Boolean_0;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Internal_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
