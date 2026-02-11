using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000014 RID: 20
	public class ByteStack : Object
	{
		// Token: 0x060001AB RID: 427 RVA: 0x0001C1B0 File Offset: 0x0001A3B0
		// Note: this type is marked as 'beforefieldinit'.
		static ByteStack()
		{
			Il2CppClassPointerStore<ByteStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "ByteStack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ByteStack>.NativeClassPtr);
			ByteStack.NativeFieldInfoPtr_stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByteStack>.NativeClassPtr, "stack");
			ByteStack.NativeFieldInfoPtr_growthRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByteStack>.NativeClassPtr, "growthRate");
			ByteStack.NativeFieldInfoPtr_top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByteStack>.NativeClassPtr, "top");
			ByteStack.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByteStack>.NativeClassPtr, "size");
			ByteStack.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteStack>.NativeClassPtr, 100663521);
			ByteStack.NativeMethodInfoPtr_Push_Public_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteStack>.NativeClassPtr, 100663522);
			ByteStack.NativeMethodInfoPtr_Pop_Public_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteStack>.NativeClassPtr, 100663523);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0001C26C File Offset: 0x0001A46C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364147, XrefRangeEnd = 364152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ByteStack(int growthRate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ByteStack>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref growthRate;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteStack.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0001C2B4 File Offset: 0x0001A4B4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 364157, RefRangeEnd = 364161, XrefRangeStart = 364152, XrefRangeEnd = 364157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push(byte data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref data;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteStack.NativeMethodInfoPtr_Push_Public_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0001C2F4 File Offset: 0x0001A4F4
		[CallerCount(0)]
		public unsafe byte Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteStack.NativeMethodInfoPtr_Pop_Public_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002B0F File Offset: 0x00000D0F
		public ByteStack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x0001C330 File Offset: 0x0001A530
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00002B18 File Offset: 0x00000D18
		public unsafe Il2CppStructArray<byte> stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteStack.NativeFieldInfoPtr_stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteStack.NativeFieldInfoPtr_stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x0001C360 File Offset: 0x0001A560
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00002B37 File Offset: 0x00000D37
		public unsafe int growthRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteStack.NativeFieldInfoPtr_growthRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteStack.NativeFieldInfoPtr_growthRate)) = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x0001C388 File Offset: 0x0001A588
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00002B52 File Offset: 0x00000D52
		public unsafe int top
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteStack.NativeFieldInfoPtr_top);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteStack.NativeFieldInfoPtr_top)) = value;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x0001C3B0 File Offset: 0x0001A5B0
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00002B6D File Offset: 0x00000D6D
		public unsafe int size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteStack.NativeFieldInfoPtr_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteStack.NativeFieldInfoPtr_size)) = value;
			}
		}

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeFieldInfoPtr_stack;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeFieldInfoPtr_growthRate;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeFieldInfoPtr_top;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr_Push_Public_Void_Byte_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Public_Byte_0;
	}
}
