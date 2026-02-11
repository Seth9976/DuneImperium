using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200002A RID: 42
	public class IncrementalReadDecoder : Object
	{
		// Token: 0x060002BB RID: 699 RVA: 0x00020B34 File Offset: 0x0001ED34
		// Note: this type is marked as 'beforefieldinit'.
		static IncrementalReadDecoder()
		{
			Il2CppClassPointerStore<IncrementalReadDecoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IncrementalReadDecoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncrementalReadDecoder>.NativeClassPtr);
			IncrementalReadDecoder.NativeMethodInfoPtr_get_IsFull_Internal_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementalReadDecoder>.NativeClassPtr, 100663673);
			IncrementalReadDecoder.NativeMethodInfoPtr_Decode_Internal_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementalReadDecoder>.NativeClassPtr, 100663674);
			IncrementalReadDecoder.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementalReadDecoder>.NativeClassPtr, 100663675);
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060002BC RID: 700 RVA: 0x00020BA0 File Offset: 0x0001EDA0
		public unsafe virtual bool IsFull
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncrementalReadDecoder.NativeMethodInfoPtr_get_IsFull_Internal_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00020BE8 File Offset: 0x0001EDE8
		[CallerCount(0)]
		public unsafe virtual int Decode(Il2CppStructArray<char> chars, int startPos, int len)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncrementalReadDecoder.NativeMethodInfoPtr_Decode_Internal_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00020C5C File Offset: 0x0001EE5C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IncrementalReadDecoder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncrementalReadDecoder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementalReadDecoder.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00003017 File Offset: 0x00001217
		public IncrementalReadDecoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFull_Internal_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Internal_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
