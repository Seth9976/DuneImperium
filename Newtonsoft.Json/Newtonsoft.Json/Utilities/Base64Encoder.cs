using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000042 RID: 66
	public class Base64Encoder : Object
	{
		// Token: 0x0600062F RID: 1583 RVA: 0x0002FBC4 File Offset: 0x0002DDC4
		// Note: this type is marked as 'beforefieldinit'.
		static Base64Encoder()
		{
			Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "Base64Encoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr);
			Base64Encoder.NativeFieldInfoPtr_Base64LineSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr, "Base64LineSize");
			Base64Encoder.NativeFieldInfoPtr_LineSizeInBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr, "LineSizeInBytes");
			Base64Encoder.NativeFieldInfoPtr__charsLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr, "_charsLine");
			Base64Encoder.NativeFieldInfoPtr__writer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr, "_writer");
			Base64Encoder.NativeFieldInfoPtr__leftOverBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr, "_leftOverBytes");
			Base64Encoder.NativeFieldInfoPtr__leftOverBytesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr, "_leftOverBytesCount");
			Base64Encoder.NativeMethodInfoPtr__ctor_Public_Void_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr, 100664557);
			Base64Encoder.NativeMethodInfoPtr_ValidateEncode_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr, 100664558);
			Base64Encoder.NativeMethodInfoPtr_Encode_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr, 100664559);
			Base64Encoder.NativeMethodInfoPtr_StoreLeftOverBytes_Private_Void_Il2CppStructArray_1_Byte_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr, 100664560);
			Base64Encoder.NativeMethodInfoPtr_FulfillFromLeftover_Private_Boolean_Il2CppStructArray_1_Byte_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr, 100664561);
			Base64Encoder.NativeMethodInfoPtr_Flush_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr, 100664562);
			Base64Encoder.NativeMethodInfoPtr_WriteChars_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr, 100664563);
			Base64Encoder.NativeMethodInfoPtr_EncodeAsync_Public_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr, 100664564);
			Base64Encoder.NativeMethodInfoPtr_WriteCharsAsync_Private_Task_Il2CppStructArray_1_Char_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr, 100664565);
			Base64Encoder.NativeMethodInfoPtr_FlushAsync_Public_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr, 100664566);
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0002FD34 File Offset: 0x0002DF34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 739225, RefRangeEnd = 739226, XrefRangeStart = 739216, XrefRangeEnd = 739225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Base64Encoder(TextWriter writer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base64Encoder.NativeMethodInfoPtr__ctor_Public_Void_TextWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x0002FD80 File Offset: 0x0002DF80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 739226, RefRangeEnd = 739228, XrefRangeStart = 739226, XrefRangeEnd = 739226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateEncode(Il2CppStructArray<byte> buffer, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base64Encoder.NativeMethodInfoPtr_ValidateEncode_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x0002FDE0 File Offset: 0x0002DFE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 739230, RefRangeEnd = 739231, XrefRangeStart = 739228, XrefRangeEnd = 739230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Encode(Il2CppStructArray<byte> buffer, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base64Encoder.NativeMethodInfoPtr_Encode_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0002FE40 File Offset: 0x0002E040
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 739235, RefRangeEnd = 739236, XrefRangeStart = 739231, XrefRangeEnd = 739235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StoreLeftOverBytes(Il2CppStructArray<byte> buffer, int index, ref int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base64Encoder.NativeMethodInfoPtr_StoreLeftOverBytes_Private_Void_Il2CppStructArray_1_Byte_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x0002FEA0 File Offset: 0x0002E0A0
		[CallerCount(0)]
		public unsafe bool FulfillFromLeftover(Il2CppStructArray<byte> buffer, int index, ref int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base64Encoder.NativeMethodInfoPtr_FulfillFromLeftover_Private_Boolean_Il2CppStructArray_1_Byte_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0002FF0C File Offset: 0x0002E10C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 739240, RefRangeEnd = 739241, XrefRangeStart = 739236, XrefRangeEnd = 739240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base64Encoder.NativeMethodInfoPtr_Flush_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x0002FF40 File Offset: 0x0002E140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 739241, XrefRangeEnd = 739242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteChars(Il2CppStructArray<char> chars, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base64Encoder.NativeMethodInfoPtr_WriteChars_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0002FFA0 File Offset: 0x0002E1A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 739254, RefRangeEnd = 739255, XrefRangeStart = 739242, XrefRangeEnd = 739254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task EncodeAsync(Il2CppStructArray<byte> buffer, int index, int count, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base64Encoder.NativeMethodInfoPtr_EncodeAsync_Public_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00030024 File Offset: 0x0002E224
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 739259, RefRangeEnd = 739261, XrefRangeStart = 739255, XrefRangeEnd = 739259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task WriteCharsAsync(Il2CppStructArray<char> chars, int index, int count, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base64Encoder.NativeMethodInfoPtr_WriteCharsAsync_Private_Task_Il2CppStructArray_1_Char_Int32_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x000300A8 File Offset: 0x0002E2A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 739270, RefRangeEnd = 739271, XrefRangeStart = 739261, XrefRangeEnd = 739270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task FlushAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base64Encoder.NativeMethodInfoPtr_FlushAsync_Public_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00003DEA File Offset: 0x00001FEA
		public Base64Encoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600063B RID: 1595 RVA: 0x00030100 File Offset: 0x0002E300
		// (set) Token: 0x0600063C RID: 1596 RVA: 0x00003DF3 File Offset: 0x00001FF3
		public unsafe static int Base64LineSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Base64Encoder.NativeFieldInfoPtr_Base64LineSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Base64Encoder.NativeFieldInfoPtr_Base64LineSize, (void*)(&value));
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x0003011C File Offset: 0x0002E31C
		// (set) Token: 0x0600063E RID: 1598 RVA: 0x00003E01 File Offset: 0x00002001
		public unsafe static int LineSizeInBytes
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Base64Encoder.NativeFieldInfoPtr_LineSizeInBytes, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Base64Encoder.NativeFieldInfoPtr_LineSizeInBytes, (void*)(&value));
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x00030138 File Offset: 0x0002E338
		// (set) Token: 0x06000640 RID: 1600 RVA: 0x00003E0F File Offset: 0x0000200F
		public unsafe Il2CppStructArray<char> _charsLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder.NativeFieldInfoPtr__charsLine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder.NativeFieldInfoPtr__charsLine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x00030168 File Offset: 0x0002E368
		// (set) Token: 0x06000642 RID: 1602 RVA: 0x00003E2E File Offset: 0x0000202E
		public unsafe TextWriter _writer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder.NativeFieldInfoPtr__writer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder.NativeFieldInfoPtr__writer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x00030198 File Offset: 0x0002E398
		// (set) Token: 0x06000644 RID: 1604 RVA: 0x00003E4D File Offset: 0x0000204D
		public unsafe Il2CppStructArray<byte> _leftOverBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder.NativeFieldInfoPtr__leftOverBytes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder.NativeFieldInfoPtr__leftOverBytes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x000301C8 File Offset: 0x0002E3C8
		// (set) Token: 0x06000646 RID: 1606 RVA: 0x00003E6C File Offset: 0x0000206C
		public unsafe int _leftOverBytesCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder.NativeFieldInfoPtr__leftOverBytesCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder.NativeFieldInfoPtr__leftOverBytesCount)) = value;
			}
		}

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeFieldInfoPtr_Base64LineSize;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeFieldInfoPtr_LineSizeInBytes;

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeFieldInfoPtr__charsLine;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeFieldInfoPtr__writer;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeFieldInfoPtr__leftOverBytes;

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeFieldInfoPtr__leftOverBytesCount;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextWriter_0;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeMethodInfoPtr_ValidateEncode_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeMethodInfoPtr_StoreLeftOverBytes_Private_Void_Il2CppStructArray_1_Byte_Int32_byref_Int32_0;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeMethodInfoPtr_FulfillFromLeftover_Private_Boolean_Il2CppStructArray_1_Byte_Int32_byref_Int32_0;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Void_0;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeMethodInfoPtr_WriteChars_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeMethodInfoPtr_EncodeAsync_Public_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeMethodInfoPtr_WriteCharsAsync_Private_Task_Il2CppStructArray_1_Char_Int32_Int32_CancellationToken_0;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeMethodInfoPtr_FlushAsync_Public_Task_CancellationToken_0;

		// Token: 0x02000170 RID: 368
		[ObfuscatedName("Newtonsoft.Json.Utilities.Base64Encoder+<EncodeAsync>d__13")]
		public sealed class _EncodeAsync_d__13 : ValueType
		{
			// Token: 0x06001C1C RID: 7196 RVA: 0x00085354 File Offset: 0x00083554
			// Note: this type is marked as 'beforefieldinit'.
			static _EncodeAsync_d__13()
			{
				Il2CppClassPointerStore<Base64Encoder._EncodeAsync_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr, "<EncodeAsync>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Base64Encoder._EncodeAsync_d__13>.NativeClassPtr);
				Base64Encoder._EncodeAsync_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base64Encoder._EncodeAsync_d__13>.NativeClassPtr, "<>1__state");
				Base64Encoder._EncodeAsync_d__13.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base64Encoder._EncodeAsync_d__13>.NativeClassPtr, "<>t__builder");
				Base64Encoder._EncodeAsync_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base64Encoder._EncodeAsync_d__13>.NativeClassPtr, "<>4__this");
				Base64Encoder._EncodeAsync_d__13.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base64Encoder._EncodeAsync_d__13>.NativeClassPtr, "buffer");
				Base64Encoder._EncodeAsync_d__13.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base64Encoder._EncodeAsync_d__13>.NativeClassPtr, "index");
				Base64Encoder._EncodeAsync_d__13.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base64Encoder._EncodeAsync_d__13>.NativeClassPtr, "count");
				Base64Encoder._EncodeAsync_d__13.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base64Encoder._EncodeAsync_d__13>.NativeClassPtr, "cancellationToken");
				Base64Encoder._EncodeAsync_d__13.NativeFieldInfoPtr__num4_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base64Encoder._EncodeAsync_d__13>.NativeClassPtr, "<num4>5__2");
				Base64Encoder._EncodeAsync_d__13.NativeFieldInfoPtr__length_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base64Encoder._EncodeAsync_d__13>.NativeClassPtr, "<length>5__3");
				Base64Encoder._EncodeAsync_d__13.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base64Encoder._EncodeAsync_d__13>.NativeClassPtr, "<>u__1");
				Base64Encoder._EncodeAsync_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base64Encoder._EncodeAsync_d__13>.NativeClassPtr, 100664567);
				Base64Encoder._EncodeAsync_d__13.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base64Encoder._EncodeAsync_d__13>.NativeClassPtr, 100664568);
			}

			// Token: 0x06001C1D RID: 7197 RVA: 0x00085470 File Offset: 0x00083670
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 739173, XrefRangeEnd = 739212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base64Encoder._EncodeAsync_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C1E RID: 7198 RVA: 0x000854A8 File Offset: 0x000836A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 739212, XrefRangeEnd = 739216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base64Encoder._EncodeAsync_d__13.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C1F RID: 7199 RVA: 0x0000DD1B File Offset: 0x0000BF1B
			public _EncodeAsync_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001C20 RID: 7200 RVA: 0x0000DD24 File Offset: 0x0000BF24
			public _EncodeAsync_d__13()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Base64Encoder._EncodeAsync_d__13>.NativeClassPtr))
			{
			}

			// Token: 0x170007EE RID: 2030
			// (get) Token: 0x06001C21 RID: 7201 RVA: 0x000854F0 File Offset: 0x000836F0
			// (set) Token: 0x06001C22 RID: 7202 RVA: 0x0000DD36 File Offset: 0x0000BF36
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder._EncodeAsync_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder._EncodeAsync_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007EF RID: 2031
			// (get) Token: 0x06001C23 RID: 7203 RVA: 0x00085518 File Offset: 0x00083718
			// (set) Token: 0x06001C24 RID: 7204 RVA: 0x0000DD51 File Offset: 0x0000BF51
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder._EncodeAsync_d__13.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder._EncodeAsync_d__13.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007F0 RID: 2032
			// (get) Token: 0x06001C25 RID: 7205 RVA: 0x00085548 File Offset: 0x00083748
			// (set) Token: 0x06001C26 RID: 7206 RVA: 0x0000DD7F File Offset: 0x0000BF7F
			public unsafe Base64Encoder __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder._EncodeAsync_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Base64Encoder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder._EncodeAsync_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007F1 RID: 2033
			// (get) Token: 0x06001C27 RID: 7207 RVA: 0x00085578 File Offset: 0x00083778
			// (set) Token: 0x06001C28 RID: 7208 RVA: 0x0000DD9E File Offset: 0x0000BF9E
			public unsafe Il2CppStructArray<byte> buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder._EncodeAsync_d__13.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder._EncodeAsync_d__13.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007F2 RID: 2034
			// (get) Token: 0x06001C29 RID: 7209 RVA: 0x000855A8 File Offset: 0x000837A8
			// (set) Token: 0x06001C2A RID: 7210 RVA: 0x0000DDBD File Offset: 0x0000BFBD
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder._EncodeAsync_d__13.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder._EncodeAsync_d__13.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170007F3 RID: 2035
			// (get) Token: 0x06001C2B RID: 7211 RVA: 0x000855D0 File Offset: 0x000837D0
			// (set) Token: 0x06001C2C RID: 7212 RVA: 0x0000DDD8 File Offset: 0x0000BFD8
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder._EncodeAsync_d__13.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder._EncodeAsync_d__13.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x170007F4 RID: 2036
			// (get) Token: 0x06001C2D RID: 7213 RVA: 0x000855F8 File Offset: 0x000837F8
			// (set) Token: 0x06001C2E RID: 7214 RVA: 0x0000DDF3 File Offset: 0x0000BFF3
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder._EncodeAsync_d__13.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder._EncodeAsync_d__13.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007F5 RID: 2037
			// (get) Token: 0x06001C2F RID: 7215 RVA: 0x00085628 File Offset: 0x00083828
			// (set) Token: 0x06001C30 RID: 7216 RVA: 0x0000DE21 File Offset: 0x0000C021
			public unsafe int _num4_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder._EncodeAsync_d__13.NativeFieldInfoPtr__num4_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder._EncodeAsync_d__13.NativeFieldInfoPtr__num4_5__2)) = value;
				}
			}

			// Token: 0x170007F6 RID: 2038
			// (get) Token: 0x06001C31 RID: 7217 RVA: 0x00085650 File Offset: 0x00083850
			// (set) Token: 0x06001C32 RID: 7218 RVA: 0x0000DE3C File Offset: 0x0000C03C
			public unsafe int _length_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder._EncodeAsync_d__13.NativeFieldInfoPtr__length_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder._EncodeAsync_d__13.NativeFieldInfoPtr__length_5__3)) = value;
				}
			}

			// Token: 0x170007F7 RID: 2039
			// (get) Token: 0x06001C33 RID: 7219 RVA: 0x00085678 File Offset: 0x00083878
			// (set) Token: 0x06001C34 RID: 7220 RVA: 0x0000DE57 File Offset: 0x0000C057
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder._EncodeAsync_d__13.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder._EncodeAsync_d__13.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040014F0 RID: 5360
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040014F1 RID: 5361
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040014F2 RID: 5362
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040014F3 RID: 5363
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x040014F4 RID: 5364
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x040014F5 RID: 5365
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x040014F6 RID: 5366
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040014F7 RID: 5367
			private static readonly IntPtr NativeFieldInfoPtr__num4_5__2;

			// Token: 0x040014F8 RID: 5368
			private static readonly IntPtr NativeFieldInfoPtr__length_5__3;

			// Token: 0x040014F9 RID: 5369
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040014FA RID: 5370
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014FB RID: 5371
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
