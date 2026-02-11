using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000231 RID: 561
	public class HashAlgorithm : Object
	{
		// Token: 0x06002535 RID: 9525 RVA: 0x000CDFA4 File Offset: 0x000CC1A4
		// Note: this type is marked as 'beforefieldinit'.
		static HashAlgorithm()
		{
			Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "HashAlgorithm");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr);
			HashAlgorithm.NativeFieldInfoPtr__disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, "_disposed");
			HashAlgorithm.NativeFieldInfoPtr_HashSizeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, "HashSizeValue");
			HashAlgorithm.NativeFieldInfoPtr_HashValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, "HashValue");
			HashAlgorithm.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, "State");
			HashAlgorithm.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100669534);
			HashAlgorithm.NativeMethodInfoPtr_Create_Public_Static_HashAlgorithm_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100669535);
			HashAlgorithm.NativeMethodInfoPtr_get_HashSize_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100669536);
			HashAlgorithm.NativeMethodInfoPtr_get_Hash_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100669537);
			HashAlgorithm.NativeMethodInfoPtr_ComputeHash_Public_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100669538);
			HashAlgorithm.NativeMethodInfoPtr_TryComputeHash_Public_Boolean_ReadOnlySpan_1_Byte_Span_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100669539);
			HashAlgorithm.NativeMethodInfoPtr_ComputeHash_Public_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100669540);
			HashAlgorithm.NativeMethodInfoPtr_CaptureHashCodeAndReinitialize_Private_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100669541);
			HashAlgorithm.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100669542);
			HashAlgorithm.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100669543);
			HashAlgorithm.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100669544);
			HashAlgorithm.NativeMethodInfoPtr_get_InputBlockSize_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100669545);
			HashAlgorithm.NativeMethodInfoPtr_get_OutputBlockSize_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100669546);
			HashAlgorithm.NativeMethodInfoPtr_get_CanTransformMultipleBlocks_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100669547);
			HashAlgorithm.NativeMethodInfoPtr_TransformBlock_Public_Virtual_Final_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100669548);
			HashAlgorithm.NativeMethodInfoPtr_TransformFinalBlock_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100669549);
			HashAlgorithm.NativeMethodInfoPtr_ValidateTransformBlock_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100669550);
			HashAlgorithm.NativeMethodInfoPtr_HashCore_Protected_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100669551);
			HashAlgorithm.NativeMethodInfoPtr_HashFinal_Protected_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100669552);
			HashAlgorithm.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100669553);
			HashAlgorithm.NativeMethodInfoPtr_HashCore_Protected_Virtual_New_Void_ReadOnlySpan_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100669554);
			HashAlgorithm.NativeMethodInfoPtr_TryHashFinal_Protected_Virtual_New_Boolean_Span_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100669555);
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x000CE1DC File Offset: 0x000CC3DC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HashAlgorithm()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashAlgorithm.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x000CE218 File Offset: 0x000CC418
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1371331, RefRangeEnd = 1371334, XrefRangeStart = 1371328, XrefRangeEnd = 1371331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HashAlgorithm Create(string hashName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hashName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashAlgorithm.NativeMethodInfoPtr_Create_Public_Static_HashAlgorithm_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashAlgorithm>(intPtr3) : null;
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06002538 RID: 9528 RVA: 0x000CE25C File Offset: 0x000CC45C
		public unsafe virtual int HashSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HashAlgorithm.NativeMethodInfoPtr_get_HashSize_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06002539 RID: 9529 RVA: 0x000CE2A4 File Offset: 0x000CC4A4
		public unsafe virtual Il2CppStructArray<byte> Hash
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371334, XrefRangeEnd = 1371339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HashAlgorithm.NativeMethodInfoPtr_get_Hash_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x000CE2F0 File Offset: 0x000CC4F0
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 1371351, RefRangeEnd = 1371376, XrefRangeStart = 1371339, XrefRangeEnd = 1371351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> ComputeHash(Il2CppStructArray<byte> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashAlgorithm.NativeMethodInfoPtr_ComputeHash_Public_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x000CE340 File Offset: 0x000CC540
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1371378, RefRangeEnd = 1371380, XrefRangeStart = 1371376, XrefRangeEnd = 1371378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryComputeHash(ReadOnlySpan<byte> source, Span<byte> destination, out int bytesWritten)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(source));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bytesWritten;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashAlgorithm.NativeMethodInfoPtr_TryComputeHash_Public_Boolean_ReadOnlySpan_1_Byte_Span_1_Byte_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600253C RID: 9532 RVA: 0x000CE3B8 File Offset: 0x000CC5B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1371412, RefRangeEnd = 1371415, XrefRangeStart = 1371380, XrefRangeEnd = 1371412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> ComputeHash(Il2CppStructArray<byte> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashAlgorithm.NativeMethodInfoPtr_ComputeHash_Public_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x000CE424 File Offset: 0x000CC624
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1371419, RefRangeEnd = 1371423, XrefRangeStart = 1371415, XrefRangeEnd = 1371419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> CaptureHashCodeAndReinitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashAlgorithm.NativeMethodInfoPtr_CaptureHashCodeAndReinitialize_Private_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600253E RID: 9534 RVA: 0x000CE464 File Offset: 0x000CC664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1371427, RefRangeEnd = 1371428, XrefRangeStart = 1371423, XrefRangeEnd = 1371427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashAlgorithm.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x000CE498 File Offset: 0x000CC698
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1371431, RefRangeEnd = 1371435, XrefRangeStart = 1371428, XrefRangeEnd = 1371431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashAlgorithm.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x000CE4CC File Offset: 0x000CC6CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1371435, RefRangeEnd = 1371437, XrefRangeStart = 1371435, XrefRangeEnd = 1371435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HashAlgorithm.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06002541 RID: 9537 RVA: 0x000CE518 File Offset: 0x000CC718
		public unsafe virtual int InputBlockSize
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HashAlgorithm.NativeMethodInfoPtr_get_InputBlockSize_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06002542 RID: 9538 RVA: 0x000CE560 File Offset: 0x000CC760
		public unsafe virtual int OutputBlockSize
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HashAlgorithm.NativeMethodInfoPtr_get_OutputBlockSize_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06002543 RID: 9539 RVA: 0x000CE5A8 File Offset: 0x000CC7A8
		public unsafe virtual bool CanTransformMultipleBlocks
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HashAlgorithm.NativeMethodInfoPtr_get_CanTransformMultipleBlocks_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002544 RID: 9540 RVA: 0x000CE5F0 File Offset: 0x000CC7F0
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 1371439, RefRangeEnd = 1371466, XrefRangeStart = 1371437, XrefRangeEnd = 1371439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int TransformBlock(Il2CppStructArray<byte> inputBuffer, int inputOffset, int inputCount, Il2CppStructArray<byte> outputBuffer, int outputOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outputBuffer);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outputOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashAlgorithm.NativeMethodInfoPtr_TransformBlock_Public_Virtual_Final_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002545 RID: 9541 RVA: 0x000CE67C File Offset: 0x000CC87C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1371480, RefRangeEnd = 1371487, XrefRangeStart = 1371466, XrefRangeEnd = 1371480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> TransformFinalBlock(Il2CppStructArray<byte> inputBuffer, int inputOffset, int inputCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashAlgorithm.NativeMethodInfoPtr_TransformFinalBlock_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06002546 RID: 9542 RVA: 0x000CE6E8 File Offset: 0x000CC8E8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1371487, RefRangeEnd = 1371494, XrefRangeStart = 1371487, XrefRangeEnd = 1371487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateTransformBlock(Il2CppStructArray<byte> inputBuffer, int inputOffset, int inputCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashAlgorithm.NativeMethodInfoPtr_ValidateTransformBlock_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002547 RID: 9543 RVA: 0x000CE748 File Offset: 0x000CC948
		[CallerCount(0)]
		public unsafe virtual void HashCore(Il2CppStructArray<byte> array, int ibStart, int cbSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ibStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HashAlgorithm.NativeMethodInfoPtr_HashCore_Protected_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002548 RID: 9544 RVA: 0x000CE7B4 File Offset: 0x000CC9B4
		[CallerCount(0)]
		public unsafe virtual Il2CppStructArray<byte> HashFinal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HashAlgorithm.NativeMethodInfoPtr_HashFinal_Protected_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06002549 RID: 9545 RVA: 0x000CE800 File Offset: 0x000CCA00
		[CallerCount(0)]
		public unsafe virtual void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HashAlgorithm.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600254A RID: 9546 RVA: 0x000CE83C File Offset: 0x000CCA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371494, XrefRangeEnd = 1371510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HashCore(ReadOnlySpan<byte> source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(source));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HashAlgorithm.NativeMethodInfoPtr_HashCore_Protected_Virtual_New_Void_ReadOnlySpan_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x000CE890 File Offset: 0x000CCA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371510, XrefRangeEnd = 1371513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryHashFinal(Span<byte> destination, out int bytesWritten)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bytesWritten;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HashAlgorithm.NativeMethodInfoPtr_TryHashFinal_Protected_Virtual_New_Boolean_Span_1_Byte_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x0000C0D0 File Offset: 0x0000A2D0
		public HashAlgorithm(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x0600254D RID: 9549 RVA: 0x000CE8FC File Offset: 0x000CCAFC
		// (set) Token: 0x0600254E RID: 9550 RVA: 0x0000C0D9 File Offset: 0x0000A2D9
		public unsafe bool _disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashAlgorithm.NativeFieldInfoPtr__disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashAlgorithm.NativeFieldInfoPtr__disposed)) = value;
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x0600254F RID: 9551 RVA: 0x000CE924 File Offset: 0x000CCB24
		// (set) Token: 0x06002550 RID: 9552 RVA: 0x0000C0F4 File Offset: 0x0000A2F4
		public unsafe int HashSizeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashAlgorithm.NativeFieldInfoPtr_HashSizeValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashAlgorithm.NativeFieldInfoPtr_HashSizeValue)) = value;
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06002551 RID: 9553 RVA: 0x000CE94C File Offset: 0x000CCB4C
		// (set) Token: 0x06002552 RID: 9554 RVA: 0x0000C10F File Offset: 0x0000A30F
		public unsafe Il2CppStructArray<byte> HashValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashAlgorithm.NativeFieldInfoPtr_HashValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashAlgorithm.NativeFieldInfoPtr_HashValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06002553 RID: 9555 RVA: 0x000CE97C File Offset: 0x000CCB7C
		// (set) Token: 0x06002554 RID: 9556 RVA: 0x0000C12E File Offset: 0x0000A32E
		public unsafe int State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashAlgorithm.NativeFieldInfoPtr_State);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashAlgorithm.NativeFieldInfoPtr_State)) = value;
			}
		}

		// Token: 0x04002060 RID: 8288
		private static readonly IntPtr NativeFieldInfoPtr__disposed;

		// Token: 0x04002061 RID: 8289
		private static readonly IntPtr NativeFieldInfoPtr_HashSizeValue;

		// Token: 0x04002062 RID: 8290
		private static readonly IntPtr NativeFieldInfoPtr_HashValue;

		// Token: 0x04002063 RID: 8291
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x04002064 RID: 8292
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002065 RID: 8293
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_HashAlgorithm_String_0;

		// Token: 0x04002066 RID: 8294
		private static readonly IntPtr NativeMethodInfoPtr_get_HashSize_Public_Virtual_New_get_Int32_0;

		// Token: 0x04002067 RID: 8295
		private static readonly IntPtr NativeMethodInfoPtr_get_Hash_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002068 RID: 8296
		private static readonly IntPtr NativeMethodInfoPtr_ComputeHash_Public_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002069 RID: 8297
		private static readonly IntPtr NativeMethodInfoPtr_TryComputeHash_Public_Boolean_ReadOnlySpan_1_Byte_Span_1_Byte_byref_Int32_0;

		// Token: 0x0400206A RID: 8298
		private static readonly IntPtr NativeMethodInfoPtr_ComputeHash_Public_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400206B RID: 8299
		private static readonly IntPtr NativeMethodInfoPtr_CaptureHashCodeAndReinitialize_Private_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400206C RID: 8300
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400206D RID: 8301
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x0400206E RID: 8302
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x0400206F RID: 8303
		private static readonly IntPtr NativeMethodInfoPtr_get_InputBlockSize_Public_Virtual_New_get_Int32_0;

		// Token: 0x04002070 RID: 8304
		private static readonly IntPtr NativeMethodInfoPtr_get_OutputBlockSize_Public_Virtual_New_get_Int32_0;

		// Token: 0x04002071 RID: 8305
		private static readonly IntPtr NativeMethodInfoPtr_get_CanTransformMultipleBlocks_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04002072 RID: 8306
		private static readonly IntPtr NativeMethodInfoPtr_TransformBlock_Public_Virtual_Final_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04002073 RID: 8307
		private static readonly IntPtr NativeMethodInfoPtr_TransformFinalBlock_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002074 RID: 8308
		private static readonly IntPtr NativeMethodInfoPtr_ValidateTransformBlock_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002075 RID: 8309
		private static readonly IntPtr NativeMethodInfoPtr_HashCore_Protected_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002076 RID: 8310
		private static readonly IntPtr NativeMethodInfoPtr_HashFinal_Protected_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002077 RID: 8311
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04002078 RID: 8312
		private static readonly IntPtr NativeMethodInfoPtr_HashCore_Protected_Virtual_New_Void_ReadOnlySpan_1_Byte_0;

		// Token: 0x04002079 RID: 8313
		private static readonly IntPtr NativeMethodInfoPtr_TryHashFinal_Protected_Virtual_New_Boolean_Span_1_Byte_byref_Int32_0;
	}
}
