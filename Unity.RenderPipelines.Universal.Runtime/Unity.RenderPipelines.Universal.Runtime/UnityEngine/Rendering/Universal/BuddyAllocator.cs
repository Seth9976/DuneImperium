using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000088 RID: 136
	public sealed class BuddyAllocator : ValueType
	{
		// Token: 0x06000C39 RID: 3129 RVA: 0x00040538 File Offset: 0x0003E738
		// Note: this type is marked as 'beforefieldinit'.
		static BuddyAllocator()
		{
			Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "BuddyAllocator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr);
			BuddyAllocator.NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, "m_Data");
			BuddyAllocator.NativeFieldInfoPtr_m_ActiveFreeMaskCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, "m_ActiveFreeMaskCounts");
			BuddyAllocator.NativeFieldInfoPtr_m_FreeMasksStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, "m_FreeMasksStorage");
			BuddyAllocator.NativeFieldInfoPtr_m_FreeMaskIndicesStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, "m_FreeMaskIndicesStorage");
			BuddyAllocator.NativeFieldInfoPtr_m_Allocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, "m_Allocator");
			BuddyAllocator.NativeMethodInfoPtr_get_header_Private_get_byref_Header_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664962);
			BuddyAllocator.NativeMethodInfoPtr_get_freeMaskCounts_Private_get_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664963);
			BuddyAllocator.NativeMethodInfoPtr_get_freeMasksStorage_Private_get_NativeArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664964);
			BuddyAllocator.NativeMethodInfoPtr_FreeMasks_Private_NativeArray_1_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664965);
			BuddyAllocator.NativeMethodInfoPtr_get_freeMaskIndicesStorage_Private_get_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664966);
			BuddyAllocator.NativeMethodInfoPtr_FreeMaskIndices_Private_NativeArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664967);
			BuddyAllocator.NativeMethodInfoPtr_get_levelCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664968);
			BuddyAllocator.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664969);
			BuddyAllocator.NativeMethodInfoPtr_TryAllocate_Public_Boolean_Int32_byref_BuddyAllocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664970);
			BuddyAllocator.NativeMethodInfoPtr_Free_Public_Void_BuddyAllocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664971);
			BuddyAllocator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664972);
			BuddyAllocator.NativeMethodInfoPtr_GetNativeArray_Private_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664973);
			BuddyAllocator.NativeMethodInfoPtr_LevelOffset_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664974);
			BuddyAllocator.NativeMethodInfoPtr_LevelLength_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664975);
			BuddyAllocator.NativeMethodInfoPtr_LevelOffset64_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664976);
			BuddyAllocator.NativeMethodInfoPtr_LevelLength64_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664977);
			BuddyAllocator.NativeMethodInfoPtr_AllocateRange_Private_Static_ValueTuple_2_Int32_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664978);
			BuddyAllocator.NativeMethodInfoPtr_AlignForward_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664979);
			BuddyAllocator.NativeMethodInfoPtr_PtrAdd_Private_Static_ptr_Void_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664980);
			BuddyAllocator.NativeMethodInfoPtr_Pow2_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664981);
			BuddyAllocator.NativeMethodInfoPtr_Pow2N_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664982);
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000C3A RID: 3130 RVA: 0x00040770 File Offset: 0x0003E970
		public unsafe ref BuddyAllocator.Header header
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 611691, RefRangeEnd = 611693, XrefRangeStart = 611690, XrefRangeEnd = 611691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuddyAllocator.NativeMethodInfoPtr_get_header_Private_get_byref_Header_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000C3B RID: 3131 RVA: 0x000407A8 File Offset: 0x0003E9A8
		public unsafe NativeArray<int> freeMaskCounts
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611693, XrefRangeEnd = 611696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuddyAllocator.NativeMethodInfoPtr_get_freeMaskCounts_Private_get_NativeArray_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new NativeArray<int>(intPtr);
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000C3C RID: 3132 RVA: 0x000407E4 File Offset: 0x0003E9E4
		public unsafe NativeArray<ulong> freeMasksStorage
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611696, XrefRangeEnd = 611699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuddyAllocator.NativeMethodInfoPtr_get_freeMasksStorage_Private_get_NativeArray_1_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new NativeArray<ulong>(intPtr);
			}
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00040820 File Offset: 0x0003EA20
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 611707, RefRangeEnd = 611711, XrefRangeStart = 611699, XrefRangeEnd = 611707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeArray<ulong> FreeMasks(int level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuddyAllocator.NativeMethodInfoPtr_FreeMasks_Private_NativeArray_1_UInt64_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new NativeArray<ulong>(intPtr);
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x0004086C File Offset: 0x0003EA6C
		public unsafe NativeArray<int> freeMaskIndicesStorage
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611711, XrefRangeEnd = 611714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuddyAllocator.NativeMethodInfoPtr_get_freeMaskIndicesStorage_Private_get_NativeArray_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new NativeArray<int>(intPtr);
			}
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x000408A8 File Offset: 0x0003EAA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 611722, RefRangeEnd = 611725, XrefRangeStart = 611714, XrefRangeEnd = 611722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeArray<int> FreeMaskIndices(int level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuddyAllocator.NativeMethodInfoPtr_FreeMaskIndices_Private_NativeArray_1_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new NativeArray<int>(intPtr);
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x000408F4 File Offset: 0x0003EAF4
		public unsafe int levelCount
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 611726, RefRangeEnd = 611730, XrefRangeStart = 611725, XrefRangeEnd = 611726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuddyAllocator.NativeMethodInfoPtr_get_levelCount_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x00040938 File Offset: 0x0003EB38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 611745, RefRangeEnd = 611746, XrefRangeStart = 611730, XrefRangeEnd = 611745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuddyAllocator(int levelCount, int branchingOrder, Allocator allocator = Allocator.Persistent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref levelCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref branchingOrder;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuddyAllocator.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Allocator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x000409A0 File Offset: 0x0003EBA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 611757, RefRangeEnd = 611758, XrefRangeStart = 611746, XrefRangeEnd = 611757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAllocate(int requestedLevel, out BuddyAllocation allocation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref requestedLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &allocation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuddyAllocator.NativeMethodInfoPtr_TryAllocate_Public_Boolean_Int32_byref_BuddyAllocation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x000409FC File Offset: 0x0003EBFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 611769, RefRangeEnd = 611771, XrefRangeStart = 611758, XrefRangeEnd = 611769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Free(BuddyAllocation allocation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allocation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuddyAllocator.NativeMethodInfoPtr_Free_Public_Void_BuddyAllocation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x00040A40 File Offset: 0x0003EC40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611771, XrefRangeEnd = 611772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuddyAllocator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x00040A78 File Offset: 0x0003EC78
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 611775, RefRangeEnd = 611783, XrefRangeStart = 611772, XrefRangeEnd = 611775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeArray<T> GetNativeArray<T>(int offset, int length) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuddyAllocator.MethodInfoStoreGeneric_GetNativeArray_Private_NativeArray_1_T_Int32_Int32_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new NativeArray<T>(intPtr);
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x00040AD0 File Offset: 0x0003ECD0
		[CallerCount(0)]
		public unsafe static int LevelOffset(int level, int branchingOrder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref branchingOrder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuddyAllocator.NativeMethodInfoPtr_LevelOffset_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x00040B1C File Offset: 0x0003ED1C
		[CallerCount(0)]
		public unsafe static int LevelLength(int level, int branchingOrder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref branchingOrder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuddyAllocator.NativeMethodInfoPtr_LevelLength_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x00040B68 File Offset: 0x0003ED68
		[CallerCount(0)]
		public unsafe static int LevelOffset64(int level, int branchingOrder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref branchingOrder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuddyAllocator.NativeMethodInfoPtr_LevelOffset64_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x00040BB4 File Offset: 0x0003EDB4
		[CallerCount(0)]
		public unsafe static int LevelLength64(int level, int branchingOrder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref branchingOrder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuddyAllocator.NativeMethodInfoPtr_LevelLength64_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x00040C00 File Offset: 0x0003EE00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 611789, RefRangeEnd = 611791, XrefRangeStart = 611783, XrefRangeEnd = 611789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ValueTuple<int, int> AllocateRange<T>(int length, ref int dataSize) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dataSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuddyAllocator.MethodInfoStoreGeneric_AllocateRange_Private_Static_ValueTuple_2_Int32_Int32_Int32_byref_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<int, int>(intPtr);
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x00040C48 File Offset: 0x0003EE48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 611791, RefRangeEnd = 611794, XrefRangeStart = 611791, XrefRangeEnd = 611791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int AlignForward(int offset, int alignment)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuddyAllocator.NativeMethodInfoPtr_AlignForward_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x00040C94 File Offset: 0x0003EE94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 611797, RefRangeEnd = 611798, XrefRangeStart = 611794, XrefRangeEnd = 611797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* PtrAdd(void* ptr, int bytes)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bytes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuddyAllocator.NativeMethodInfoPtr_PtrAdd_Private_Static_ptr_Void_ptr_Void_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x00040CD4 File Offset: 0x0003EED4
		[CallerCount(0)]
		public unsafe static int Pow2(int n)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuddyAllocator.NativeMethodInfoPtr_Pow2_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x00040D14 File Offset: 0x0003EF14
		[CallerCount(0)]
		public unsafe static int Pow2N(int x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuddyAllocator.NativeMethodInfoPtr_Pow2N_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x00007887 File Offset: 0x00005A87
		public BuddyAllocator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x00007890 File Offset: 0x00005A90
		public BuddyAllocator()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr))
		{
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000C51 RID: 3153 RVA: 0x00040D60 File Offset: 0x0003EF60
		// (set) Token: 0x06000C52 RID: 3154 RVA: 0x000078A2 File Offset: 0x00005AA2
		public unsafe void* m_Data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuddyAllocator.NativeFieldInfoPtr_m_Data);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuddyAllocator.NativeFieldInfoPtr_m_Data)) = value;
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000C53 RID: 3155 RVA: 0x00040D84 File Offset: 0x0003EF84
		// (set) Token: 0x06000C54 RID: 3156 RVA: 0x000078BD File Offset: 0x00005ABD
		public ValueTuple<int, int> m_ActiveFreeMaskCounts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuddyAllocator.NativeFieldInfoPtr_m_ActiveFreeMaskCounts);
				return new ValueTuple<int, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<int, int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuddyAllocator.NativeFieldInfoPtr_m_ActiveFreeMaskCounts), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<int, int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x00040DB4 File Offset: 0x0003EFB4
		// (set) Token: 0x06000C56 RID: 3158 RVA: 0x000078EB File Offset: 0x00005AEB
		public ValueTuple<int, int> m_FreeMasksStorage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuddyAllocator.NativeFieldInfoPtr_m_FreeMasksStorage);
				return new ValueTuple<int, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<int, int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuddyAllocator.NativeFieldInfoPtr_m_FreeMasksStorage), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<int, int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x00040DE4 File Offset: 0x0003EFE4
		// (set) Token: 0x06000C58 RID: 3160 RVA: 0x00007919 File Offset: 0x00005B19
		public ValueTuple<int, int> m_FreeMaskIndicesStorage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuddyAllocator.NativeFieldInfoPtr_m_FreeMaskIndicesStorage);
				return new ValueTuple<int, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<int, int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuddyAllocator.NativeFieldInfoPtr_m_FreeMaskIndicesStorage), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<int, int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x00040E14 File Offset: 0x0003F014
		// (set) Token: 0x06000C5A RID: 3162 RVA: 0x00007947 File Offset: 0x00005B47
		public unsafe Allocator m_Allocator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuddyAllocator.NativeFieldInfoPtr_m_Allocator);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuddyAllocator.NativeFieldInfoPtr_m_Allocator)) = value;
			}
		}

		// Token: 0x0400090C RID: 2316
		private static readonly IntPtr NativeFieldInfoPtr_m_Data;

		// Token: 0x0400090D RID: 2317
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveFreeMaskCounts;

		// Token: 0x0400090E RID: 2318
		private static readonly IntPtr NativeFieldInfoPtr_m_FreeMasksStorage;

		// Token: 0x0400090F RID: 2319
		private static readonly IntPtr NativeFieldInfoPtr_m_FreeMaskIndicesStorage;

		// Token: 0x04000910 RID: 2320
		private static readonly IntPtr NativeFieldInfoPtr_m_Allocator;

		// Token: 0x04000911 RID: 2321
		private static readonly IntPtr NativeMethodInfoPtr_get_header_Private_get_byref_Header_0;

		// Token: 0x04000912 RID: 2322
		private static readonly IntPtr NativeMethodInfoPtr_get_freeMaskCounts_Private_get_NativeArray_1_Int32_0;

		// Token: 0x04000913 RID: 2323
		private static readonly IntPtr NativeMethodInfoPtr_get_freeMasksStorage_Private_get_NativeArray_1_UInt64_0;

		// Token: 0x04000914 RID: 2324
		private static readonly IntPtr NativeMethodInfoPtr_FreeMasks_Private_NativeArray_1_UInt64_Int32_0;

		// Token: 0x04000915 RID: 2325
		private static readonly IntPtr NativeMethodInfoPtr_get_freeMaskIndicesStorage_Private_get_NativeArray_1_Int32_0;

		// Token: 0x04000916 RID: 2326
		private static readonly IntPtr NativeMethodInfoPtr_FreeMaskIndices_Private_NativeArray_1_Int32_Int32_0;

		// Token: 0x04000917 RID: 2327
		private static readonly IntPtr NativeMethodInfoPtr_get_levelCount_Public_get_Int32_0;

		// Token: 0x04000918 RID: 2328
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Allocator_0;

		// Token: 0x04000919 RID: 2329
		private static readonly IntPtr NativeMethodInfoPtr_TryAllocate_Public_Boolean_Int32_byref_BuddyAllocation_0;

		// Token: 0x0400091A RID: 2330
		private static readonly IntPtr NativeMethodInfoPtr_Free_Public_Void_BuddyAllocation_0;

		// Token: 0x0400091B RID: 2331
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400091C RID: 2332
		private static readonly IntPtr NativeMethodInfoPtr_GetNativeArray_Private_NativeArray_1_T_Int32_Int32_0;

		// Token: 0x0400091D RID: 2333
		private static readonly IntPtr NativeMethodInfoPtr_LevelOffset_Private_Static_Int32_Int32_Int32_0;

		// Token: 0x0400091E RID: 2334
		private static readonly IntPtr NativeMethodInfoPtr_LevelLength_Private_Static_Int32_Int32_Int32_0;

		// Token: 0x0400091F RID: 2335
		private static readonly IntPtr NativeMethodInfoPtr_LevelOffset64_Private_Static_Int32_Int32_Int32_0;

		// Token: 0x04000920 RID: 2336
		private static readonly IntPtr NativeMethodInfoPtr_LevelLength64_Private_Static_Int32_Int32_Int32_0;

		// Token: 0x04000921 RID: 2337
		private static readonly IntPtr NativeMethodInfoPtr_AllocateRange_Private_Static_ValueTuple_2_Int32_Int32_Int32_byref_Int32_0;

		// Token: 0x04000922 RID: 2338
		private static readonly IntPtr NativeMethodInfoPtr_AlignForward_Private_Static_Int32_Int32_Int32_0;

		// Token: 0x04000923 RID: 2339
		private static readonly IntPtr NativeMethodInfoPtr_PtrAdd_Private_Static_ptr_Void_ptr_Void_Int32_0;

		// Token: 0x04000924 RID: 2340
		private static readonly IntPtr NativeMethodInfoPtr_Pow2_Private_Static_Int32_Int32_0;

		// Token: 0x04000925 RID: 2341
		private static readonly IntPtr NativeMethodInfoPtr_Pow2N_Private_Static_Int32_Int32_Int32_0;

		// Token: 0x0200019B RID: 411
		[StructLayout(2)]
		public struct Header
		{
			// Token: 0x06001E3B RID: 7739 RVA: 0x00079A84 File Offset: 0x00077C84
			// Note: this type is marked as 'beforefieldinit'.
			static Header()
			{
				Il2CppClassPointerStore<BuddyAllocator.Header>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, "Header");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuddyAllocator.Header>.NativeClassPtr);
				BuddyAllocator.Header.NativeFieldInfoPtr_branchingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuddyAllocator.Header>.NativeClassPtr, "branchingOrder");
				BuddyAllocator.Header.NativeFieldInfoPtr_levelCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuddyAllocator.Header>.NativeClassPtr, "levelCount");
				BuddyAllocator.Header.NativeFieldInfoPtr_allocationCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuddyAllocator.Header>.NativeClassPtr, "allocationCount");
				BuddyAllocator.Header.NativeFieldInfoPtr_freeAllocationIdsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuddyAllocator.Header>.NativeClassPtr, "freeAllocationIdsCount");
			}

			// Token: 0x06001E3C RID: 7740 RVA: 0x00011566 File Offset: 0x0000F766
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuddyAllocator.Header>.NativeClassPtr, ref this));
			}

			// Token: 0x040015BB RID: 5563
			private static readonly IntPtr NativeFieldInfoPtr_branchingOrder;

			// Token: 0x040015BC RID: 5564
			private static readonly IntPtr NativeFieldInfoPtr_levelCount;

			// Token: 0x040015BD RID: 5565
			private static readonly IntPtr NativeFieldInfoPtr_allocationCount;

			// Token: 0x040015BE RID: 5566
			private static readonly IntPtr NativeFieldInfoPtr_freeAllocationIdsCount;

			// Token: 0x040015BF RID: 5567
			[FieldOffset(0)]
			public int branchingOrder;

			// Token: 0x040015C0 RID: 5568
			[FieldOffset(4)]
			public int levelCount;

			// Token: 0x040015C1 RID: 5569
			[FieldOffset(8)]
			public int allocationCount;

			// Token: 0x040015C2 RID: 5570
			[FieldOffset(12)]
			public int freeAllocationIdsCount;
		}

		// Token: 0x0200019C RID: 412
		private sealed class MethodInfoStoreGeneric_GetNativeArray_Private_NativeArray_1_T_Int32_Int32_0<T>
		{
			// Token: 0x040015C3 RID: 5571
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BuddyAllocator.NativeMethodInfoPtr_GetNativeArray_Private_NativeArray_1_T_Int32_Int32_0, Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200019D RID: 413
		private sealed class MethodInfoStoreGeneric_AllocateRange_Private_Static_ValueTuple_2_Int32_Int32_Int32_byref_Int32_0<T>
		{
			// Token: 0x040015C4 RID: 5572
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BuddyAllocator.NativeMethodInfoPtr_AllocateRange_Private_Static_ValueTuple_2_Int32_Int32_Int32_byref_Int32_0, Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
