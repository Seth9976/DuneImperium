using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x0200012F RID: 303
	public sealed class BitHelper : Object
	{
		// Token: 0x060011B9 RID: 4537 RVA: 0x0005CB74 File Offset: 0x0005AD74
		// Note: this type is marked as 'beforefieldinit'.
		static BitHelper()
		{
			Il2CppClassPointerStore<BitHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Collections.Generic", "BitHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitHelper>.NativeClassPtr);
			BitHelper.NativeFieldInfoPtr__length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitHelper>.NativeClassPtr, "_length");
			BitHelper.NativeFieldInfoPtr__arrayPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitHelper>.NativeClassPtr, "_arrayPtr");
			BitHelper.NativeFieldInfoPtr__array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitHelper>.NativeClassPtr, "_array");
			BitHelper.NativeFieldInfoPtr__useStackAlloc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitHelper>.NativeClassPtr, "_useStackAlloc");
			BitHelper.NativeMethodInfoPtr__ctor_Internal_Void_ptr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitHelper>.NativeClassPtr, 100666664);
			BitHelper.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitHelper>.NativeClassPtr, 100666665);
			BitHelper.NativeMethodInfoPtr_MarkBit_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitHelper>.NativeClassPtr, 100666666);
			BitHelper.NativeMethodInfoPtr_IsMarked_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitHelper>.NativeClassPtr, 100666667);
			BitHelper.NativeMethodInfoPtr_ToIntArrayLength_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitHelper>.NativeClassPtr, 100666668);
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x0005CC58 File Offset: 0x0005AE58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1031311, RefRangeEnd = 1031313, XrefRangeStart = 1031310, XrefRangeEnd = 1031311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BitHelper(int* bitArrayPtr, int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BitHelper>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = bitArrayPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitHelper.NativeMethodInfoPtr__ctor_Internal_Void_ptr_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x0005CCAC File Offset: 0x0005AEAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1031315, RefRangeEnd = 1031317, XrefRangeStart = 1031313, XrefRangeEnd = 1031315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BitHelper(Il2CppStructArray<int> bitArray, int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BitHelper>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bitArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitHelper.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x0005CD08 File Offset: 0x0005AF08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1031317, RefRangeEnd = 1031319, XrefRangeStart = 1031317, XrefRangeEnd = 1031317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkBit(int bitPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bitPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitHelper.NativeMethodInfoPtr_MarkBit_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x0005CD48 File Offset: 0x0005AF48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1031319, RefRangeEnd = 1031321, XrefRangeStart = 1031319, XrefRangeEnd = 1031319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMarked(int bitPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bitPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitHelper.NativeMethodInfoPtr_IsMarked_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x0005CD94 File Offset: 0x0005AF94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1031321, RefRangeEnd = 1031323, XrefRangeStart = 1031321, XrefRangeEnd = 1031321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToIntArrayLength(int n)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitHelper.NativeMethodInfoPtr_ToIntArrayLength_Internal_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x000075E6 File Offset: 0x000057E6
		public BitHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x0005CDD4 File Offset: 0x0005AFD4
		// (set) Token: 0x060011C1 RID: 4545 RVA: 0x000075EF File Offset: 0x000057EF
		public unsafe int _length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitHelper.NativeFieldInfoPtr__length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitHelper.NativeFieldInfoPtr__length)) = value;
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x060011C2 RID: 4546 RVA: 0x0005CDFC File Offset: 0x0005AFFC
		// (set) Token: 0x060011C3 RID: 4547 RVA: 0x0000760A File Offset: 0x0000580A
		public unsafe int* _arrayPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitHelper.NativeFieldInfoPtr__arrayPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitHelper.NativeFieldInfoPtr__arrayPtr)) = value;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x060011C4 RID: 4548 RVA: 0x0005CE20 File Offset: 0x0005B020
		// (set) Token: 0x060011C5 RID: 4549 RVA: 0x00007625 File Offset: 0x00005825
		public unsafe Il2CppStructArray<int> _array
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitHelper.NativeFieldInfoPtr__array);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitHelper.NativeFieldInfoPtr__array), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x060011C6 RID: 4550 RVA: 0x0005CE50 File Offset: 0x0005B050
		// (set) Token: 0x060011C7 RID: 4551 RVA: 0x00007644 File Offset: 0x00005844
		public unsafe bool _useStackAlloc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitHelper.NativeFieldInfoPtr__useStackAlloc);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitHelper.NativeFieldInfoPtr__useStackAlloc)) = value;
			}
		}

		// Token: 0x04000CBF RID: 3263
		private static readonly IntPtr NativeFieldInfoPtr__length;

		// Token: 0x04000CC0 RID: 3264
		private static readonly IntPtr NativeFieldInfoPtr__arrayPtr;

		// Token: 0x04000CC1 RID: 3265
		private static readonly IntPtr NativeFieldInfoPtr__array;

		// Token: 0x04000CC2 RID: 3266
		private static readonly IntPtr NativeFieldInfoPtr__useStackAlloc;

		// Token: 0x04000CC3 RID: 3267
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ptr_Int32_Int32_0;

		// Token: 0x04000CC4 RID: 3268
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x04000CC5 RID: 3269
		private static readonly IntPtr NativeMethodInfoPtr_MarkBit_Internal_Void_Int32_0;

		// Token: 0x04000CC6 RID: 3270
		private static readonly IntPtr NativeMethodInfoPtr_IsMarked_Internal_Boolean_Int32_0;

		// Token: 0x04000CC7 RID: 3271
		private static readonly IntPtr NativeMethodInfoPtr_ToIntArrayLength_Internal_Static_Int32_Int32_0;
	}
}
