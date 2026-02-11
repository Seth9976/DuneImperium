using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x020000C1 RID: 193
	public class AtlasAllocatorDynamic : Object
	{
		// Token: 0x06000DE0 RID: 3552 RVA: 0x00040630 File Offset: 0x0003E830
		// Note: this type is marked as 'beforefieldinit'.
		static AtlasAllocatorDynamic()
		{
			Il2CppClassPointerStore<AtlasAllocatorDynamic>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "AtlasAllocatorDynamic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AtlasAllocatorDynamic>.NativeClassPtr);
			AtlasAllocatorDynamic.NativeFieldInfoPtr_m_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasAllocatorDynamic>.NativeClassPtr, "m_Width");
			AtlasAllocatorDynamic.NativeFieldInfoPtr_m_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasAllocatorDynamic>.NativeClassPtr, "m_Height");
			AtlasAllocatorDynamic.NativeFieldInfoPtr_m_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasAllocatorDynamic>.NativeClassPtr, "m_Pool");
			AtlasAllocatorDynamic.NativeFieldInfoPtr_m_Root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasAllocatorDynamic>.NativeClassPtr, "m_Root");
			AtlasAllocatorDynamic.NativeFieldInfoPtr_m_NodeFromID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasAllocatorDynamic>.NativeClassPtr, "m_NodeFromID");
			AtlasAllocatorDynamic.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasAllocatorDynamic>.NativeClassPtr, 100665296);
			AtlasAllocatorDynamic.NativeMethodInfoPtr_Allocate_Public_Boolean_byref_Vector4_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasAllocatorDynamic>.NativeClassPtr, 100665297);
			AtlasAllocatorDynamic.NativeMethodInfoPtr_Release_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasAllocatorDynamic>.NativeClassPtr, 100665298);
			AtlasAllocatorDynamic.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasAllocatorDynamic>.NativeClassPtr, 100665299);
			AtlasAllocatorDynamic.NativeMethodInfoPtr_DebugStringFromRoot_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasAllocatorDynamic>.NativeClassPtr, 100665300);
			AtlasAllocatorDynamic.NativeMethodInfoPtr_DebugStringFromNode_Private_Void_byref_String_Int16_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasAllocatorDynamic>.NativeClassPtr, 100665301);
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x0004073C File Offset: 0x0003E93C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 973408, RefRangeEnd = 973410, XrefRangeStart = 973390, XrefRangeEnd = 973408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AtlasAllocatorDynamic(int width, int height, int capacityAllocations)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AtlasAllocatorDynamic>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacityAllocations;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasAllocatorDynamic.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x000407A0 File Offset: 0x0003E9A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 973414, RefRangeEnd = 973416, XrefRangeStart = 973410, XrefRangeEnd = 973414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Allocate(out Vector4 result, int key, int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &result;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasAllocatorDynamic.NativeMethodInfoPtr_Allocate_Public_Boolean_byref_Vector4_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x00040814 File Offset: 0x0003EA14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973416, XrefRangeEnd = 973423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release(int key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasAllocatorDynamic.NativeMethodInfoPtr_Release_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x00040854 File Offset: 0x0003EA54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973423, XrefRangeEnd = 973429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasAllocatorDynamic.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x00040888 File Offset: 0x0003EA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973429, XrefRangeEnd = 973432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string DebugStringFromRoot(int depthMax = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depthMax;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasAllocatorDynamic.NativeMethodInfoPtr_DebugStringFromRoot_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x000408CC File Offset: 0x0003EACC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 973479, RefRangeEnd = 973482, XrefRangeStart = 973432, XrefRangeEnd = 973479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DebugStringFromNode(ref string res, short n, int depthCurrent = 0, int depthMax = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.ManagedStringToIl2Cpp(res);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthCurrent;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthMax;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AtlasAllocatorDynamic.NativeMethodInfoPtr_DebugStringFromNode_Private_Void_byref_String_Int16_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			res = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x000080A1 File Offset: 0x000062A1
		public AtlasAllocatorDynamic(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000DE8 RID: 3560 RVA: 0x00040948 File Offset: 0x0003EB48
		// (set) Token: 0x06000DE9 RID: 3561 RVA: 0x000080AA File Offset: 0x000062AA
		public unsafe int m_Width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasAllocatorDynamic.NativeFieldInfoPtr_m_Width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasAllocatorDynamic.NativeFieldInfoPtr_m_Width)) = value;
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000DEA RID: 3562 RVA: 0x00040970 File Offset: 0x0003EB70
		// (set) Token: 0x06000DEB RID: 3563 RVA: 0x000080C5 File Offset: 0x000062C5
		public unsafe int m_Height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasAllocatorDynamic.NativeFieldInfoPtr_m_Height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasAllocatorDynamic.NativeFieldInfoPtr_m_Height)) = value;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000DEC RID: 3564 RVA: 0x00040998 File Offset: 0x0003EB98
		// (set) Token: 0x06000DED RID: 3565 RVA: 0x000080E0 File Offset: 0x000062E0
		public unsafe AtlasAllocatorDynamic.AtlasNodePool m_Pool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasAllocatorDynamic.NativeFieldInfoPtr_m_Pool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AtlasAllocatorDynamic.AtlasNodePool>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasAllocatorDynamic.NativeFieldInfoPtr_m_Pool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000DEE RID: 3566 RVA: 0x000409C8 File Offset: 0x0003EBC8
		// (set) Token: 0x06000DEF RID: 3567 RVA: 0x000080FF File Offset: 0x000062FF
		public unsafe short m_Root
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasAllocatorDynamic.NativeFieldInfoPtr_m_Root);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasAllocatorDynamic.NativeFieldInfoPtr_m_Root)) = value;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000DF0 RID: 3568 RVA: 0x000409F0 File Offset: 0x0003EBF0
		// (set) Token: 0x06000DF1 RID: 3569 RVA: 0x0000811A File Offset: 0x0000631A
		public unsafe Dictionary<int, short> m_NodeFromID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasAllocatorDynamic.NativeFieldInfoPtr_m_NodeFromID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, short>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasAllocatorDynamic.NativeFieldInfoPtr_m_NodeFromID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A69 RID: 2665
		private static readonly IntPtr NativeFieldInfoPtr_m_Width;

		// Token: 0x04000A6A RID: 2666
		private static readonly IntPtr NativeFieldInfoPtr_m_Height;

		// Token: 0x04000A6B RID: 2667
		private static readonly IntPtr NativeFieldInfoPtr_m_Pool;

		// Token: 0x04000A6C RID: 2668
		private static readonly IntPtr NativeFieldInfoPtr_m_Root;

		// Token: 0x04000A6D RID: 2669
		private static readonly IntPtr NativeFieldInfoPtr_m_NodeFromID;

		// Token: 0x04000A6E RID: 2670
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x04000A6F RID: 2671
		private static readonly IntPtr NativeMethodInfoPtr_Allocate_Public_Boolean_byref_Vector4_Int32_Int32_Int32_0;

		// Token: 0x04000A70 RID: 2672
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_Int32_0;

		// Token: 0x04000A71 RID: 2673
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

		// Token: 0x04000A72 RID: 2674
		private static readonly IntPtr NativeMethodInfoPtr_DebugStringFromRoot_Public_String_Int32_0;

		// Token: 0x04000A73 RID: 2675
		private static readonly IntPtr NativeMethodInfoPtr_DebugStringFromNode_Private_Void_byref_String_Int16_Int32_Int32_0;

		// Token: 0x020001EE RID: 494
		public class AtlasNodePool : Object
		{
			// Token: 0x06001A4B RID: 6731 RVA: 0x0006CC34 File Offset: 0x0006AE34
			// Note: this type is marked as 'beforefieldinit'.
			static AtlasNodePool()
			{
				Il2CppClassPointerStore<AtlasAllocatorDynamic.AtlasNodePool>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AtlasAllocatorDynamic>.NativeClassPtr, "AtlasNodePool");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AtlasAllocatorDynamic.AtlasNodePool>.NativeClassPtr);
				AtlasAllocatorDynamic.AtlasNodePool.NativeFieldInfoPtr_m_Nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasAllocatorDynamic.AtlasNodePool>.NativeClassPtr, "m_Nodes");
				AtlasAllocatorDynamic.AtlasNodePool.NativeFieldInfoPtr_m_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasAllocatorDynamic.AtlasNodePool>.NativeClassPtr, "m_Next");
				AtlasAllocatorDynamic.AtlasNodePool.NativeFieldInfoPtr_m_FreelistHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasAllocatorDynamic.AtlasNodePool>.NativeClassPtr, "m_FreelistHead");
				AtlasAllocatorDynamic.AtlasNodePool.NativeMethodInfoPtr__ctor_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasAllocatorDynamic.AtlasNodePool>.NativeClassPtr, 100665302);
				AtlasAllocatorDynamic.AtlasNodePool.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasAllocatorDynamic.AtlasNodePool>.NativeClassPtr, 100665303);
				AtlasAllocatorDynamic.AtlasNodePool.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasAllocatorDynamic.AtlasNodePool>.NativeClassPtr, 100665304);
				AtlasAllocatorDynamic.AtlasNodePool.NativeMethodInfoPtr_AtlasNodeCreate_Public_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasAllocatorDynamic.AtlasNodePool>.NativeClassPtr, 100665305);
				AtlasAllocatorDynamic.AtlasNodePool.NativeMethodInfoPtr_AtlasNodeFree_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasAllocatorDynamic.AtlasNodePool>.NativeClassPtr, 100665306);
			}

			// Token: 0x06001A4C RID: 6732 RVA: 0x0006CD00 File Offset: 0x0006AF00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973351, XrefRangeEnd = 973356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AtlasNodePool(short capacity)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AtlasAllocatorDynamic.AtlasNodePool>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref capacity;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasAllocatorDynamic.AtlasNodePool.NativeMethodInfoPtr__ctor_Public_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A4D RID: 6733 RVA: 0x0006CD48 File Offset: 0x0006AF48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973356, XrefRangeEnd = 973357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasAllocatorDynamic.AtlasNodePool.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A4E RID: 6734 RVA: 0x0006CD7C File Offset: 0x0006AF7C
			[CallerCount(0)]
			public unsafe void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasAllocatorDynamic.AtlasNodePool.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A4F RID: 6735 RVA: 0x0006CDB0 File Offset: 0x0006AFB0
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 973359, RefRangeEnd = 973365, XrefRangeStart = 973357, XrefRangeEnd = 973359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe short AtlasNodeCreate(short parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref parent;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasAllocatorDynamic.AtlasNodePool.NativeMethodInfoPtr_AtlasNodeCreate_Public_Int16_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A50 RID: 6736 RVA: 0x0006CDFC File Offset: 0x0006AFFC
			[CallerCount(0)]
			public unsafe void AtlasNodeFree(short index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasAllocatorDynamic.AtlasNodePool.NativeMethodInfoPtr_AtlasNodeFree_Public_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A51 RID: 6737 RVA: 0x0000D3BF File Offset: 0x0000B5BF
			public AtlasNodePool(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000764 RID: 1892
			// (get) Token: 0x06001A52 RID: 6738 RVA: 0x0006CE3C File Offset: 0x0006B03C
			// (set) Token: 0x06001A53 RID: 6739 RVA: 0x0000D3C8 File Offset: 0x0000B5C8
			public unsafe Il2CppStructArray<AtlasAllocatorDynamic.AtlasNode> m_Nodes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasAllocatorDynamic.AtlasNodePool.NativeFieldInfoPtr_m_Nodes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<AtlasAllocatorDynamic.AtlasNode>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasAllocatorDynamic.AtlasNodePool.NativeFieldInfoPtr_m_Nodes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000765 RID: 1893
			// (get) Token: 0x06001A54 RID: 6740 RVA: 0x0006CE6C File Offset: 0x0006B06C
			// (set) Token: 0x06001A55 RID: 6741 RVA: 0x0000D3E7 File Offset: 0x0000B5E7
			public unsafe short m_Next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasAllocatorDynamic.AtlasNodePool.NativeFieldInfoPtr_m_Next);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasAllocatorDynamic.AtlasNodePool.NativeFieldInfoPtr_m_Next)) = value;
				}
			}

			// Token: 0x17000766 RID: 1894
			// (get) Token: 0x06001A56 RID: 6742 RVA: 0x0006CE94 File Offset: 0x0006B094
			// (set) Token: 0x06001A57 RID: 6743 RVA: 0x0000D402 File Offset: 0x0000B602
			public unsafe short m_FreelistHead
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasAllocatorDynamic.AtlasNodePool.NativeFieldInfoPtr_m_FreelistHead);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasAllocatorDynamic.AtlasNodePool.NativeFieldInfoPtr_m_FreelistHead)) = value;
				}
			}

			// Token: 0x04001326 RID: 4902
			private static readonly IntPtr NativeFieldInfoPtr_m_Nodes;

			// Token: 0x04001327 RID: 4903
			private static readonly IntPtr NativeFieldInfoPtr_m_Next;

			// Token: 0x04001328 RID: 4904
			private static readonly IntPtr NativeFieldInfoPtr_m_FreelistHead;

			// Token: 0x04001329 RID: 4905
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int16_0;

			// Token: 0x0400132A RID: 4906
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

			// Token: 0x0400132B RID: 4907
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

			// Token: 0x0400132C RID: 4908
			private static readonly IntPtr NativeMethodInfoPtr_AtlasNodeCreate_Public_Int16_Int16_0;

			// Token: 0x0400132D RID: 4909
			private static readonly IntPtr NativeMethodInfoPtr_AtlasNodeFree_Public_Void_Int16_0;
		}

		// Token: 0x020001EF RID: 495
		[StructLayout(2)]
		public struct AtlasNode
		{
			// Token: 0x06001A58 RID: 6744 RVA: 0x0006CEBC File Offset: 0x0006B0BC
			// Note: this type is marked as 'beforefieldinit'.
			static AtlasNode()
			{
				Il2CppClassPointerStore<AtlasAllocatorDynamic.AtlasNode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AtlasAllocatorDynamic>.NativeClassPtr, "AtlasNode");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AtlasAllocatorDynamic.AtlasNode>.NativeClassPtr);
				AtlasAllocatorDynamic.AtlasNode.NativeFieldInfoPtr_m_Self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasAllocatorDynamic.AtlasNode>.NativeClassPtr, "m_Self");
				AtlasAllocatorDynamic.AtlasNode.NativeFieldInfoPtr_m_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasAllocatorDynamic.AtlasNode>.NativeClassPtr, "m_Parent");
				AtlasAllocatorDynamic.AtlasNode.NativeFieldInfoPtr_m_LeftChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasAllocatorDynamic.AtlasNode>.NativeClassPtr, "m_LeftChild");
				AtlasAllocatorDynamic.AtlasNode.NativeFieldInfoPtr_m_RightChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasAllocatorDynamic.AtlasNode>.NativeClassPtr, "m_RightChild");
				AtlasAllocatorDynamic.AtlasNode.NativeFieldInfoPtr_m_FreelistNext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasAllocatorDynamic.AtlasNode>.NativeClassPtr, "m_FreelistNext");
				AtlasAllocatorDynamic.AtlasNode.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasAllocatorDynamic.AtlasNode>.NativeClassPtr, "m_Flags");
				AtlasAllocatorDynamic.AtlasNode.NativeFieldInfoPtr_m_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasAllocatorDynamic.AtlasNode>.NativeClassPtr, "m_Rect");
				AtlasAllocatorDynamic.AtlasNode.NativeMethodInfoPtr__ctor_Public_Void_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasAllocatorDynamic.AtlasNode>.NativeClassPtr, 100665307);
				AtlasAllocatorDynamic.AtlasNode.NativeMethodInfoPtr_IsOccupied_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasAllocatorDynamic.AtlasNode>.NativeClassPtr, 100665308);
				AtlasAllocatorDynamic.AtlasNode.NativeMethodInfoPtr_SetIsOccupied_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasAllocatorDynamic.AtlasNode>.NativeClassPtr, 100665309);
				AtlasAllocatorDynamic.AtlasNode.NativeMethodInfoPtr_ClearIsOccupied_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasAllocatorDynamic.AtlasNode>.NativeClassPtr, 100665310);
				AtlasAllocatorDynamic.AtlasNode.NativeMethodInfoPtr_IsLeafNode_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasAllocatorDynamic.AtlasNode>.NativeClassPtr, 100665311);
				AtlasAllocatorDynamic.AtlasNode.NativeMethodInfoPtr_Allocate_Public_Int16_AtlasNodePool_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasAllocatorDynamic.AtlasNode>.NativeClassPtr, 100665312);
				AtlasAllocatorDynamic.AtlasNode.NativeMethodInfoPtr_ReleaseChildren_Public_Void_AtlasNodePool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasAllocatorDynamic.AtlasNode>.NativeClassPtr, 100665313);
				AtlasAllocatorDynamic.AtlasNode.NativeMethodInfoPtr_ReleaseAndMerge_Public_Void_AtlasNodePool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasAllocatorDynamic.AtlasNode>.NativeClassPtr, 100665314);
				AtlasAllocatorDynamic.AtlasNode.NativeMethodInfoPtr_IsMergeNeeded_Public_Boolean_AtlasNodePool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasAllocatorDynamic.AtlasNode>.NativeClassPtr, 100665315);
			}

			// Token: 0x06001A59 RID: 6745 RVA: 0x0006D028 File Offset: 0x0006B228
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973365, XrefRangeEnd = 973367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AtlasNode(short self, short parent)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref self;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parent;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasAllocatorDynamic.AtlasNode.NativeMethodInfoPtr__ctor_Public_Void_Int16_Int16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A5A RID: 6746 RVA: 0x0006D068 File Offset: 0x0006B268
			[CallerCount(0)]
			public unsafe bool IsOccupied()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasAllocatorDynamic.AtlasNode.NativeMethodInfoPtr_IsOccupied_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001A5B RID: 6747 RVA: 0x0006D098 File Offset: 0x0006B298
			[CallerCount(0)]
			public unsafe void SetIsOccupied()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasAllocatorDynamic.AtlasNode.NativeMethodInfoPtr_SetIsOccupied_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A5C RID: 6748 RVA: 0x0006D0C0 File Offset: 0x0006B2C0
			[CallerCount(0)]
			public unsafe void ClearIsOccupied()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasAllocatorDynamic.AtlasNode.NativeMethodInfoPtr_ClearIsOccupied_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A5D RID: 6749 RVA: 0x0006D0E8 File Offset: 0x0006B2E8
			[CallerCount(0)]
			public unsafe bool IsLeafNode()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasAllocatorDynamic.AtlasNode.NativeMethodInfoPtr_IsLeafNode_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001A5E RID: 6750 RVA: 0x0006D118 File Offset: 0x0006B318
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 973377, RefRangeEnd = 973382, XrefRangeStart = 973367, XrefRangeEnd = 973377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe short Allocate(AtlasAllocatorDynamic.AtlasNodePool pool, int width, int height)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(pool);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasAllocatorDynamic.AtlasNode.NativeMethodInfoPtr_Allocate_Public_Int16_AtlasNodePool_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001A5F RID: 6751 RVA: 0x0006D178 File Offset: 0x0006B378
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 973384, RefRangeEnd = 973387, XrefRangeStart = 973382, XrefRangeEnd = 973384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ReleaseChildren(AtlasAllocatorDynamic.AtlasNodePool pool)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(pool);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasAllocatorDynamic.AtlasNode.NativeMethodInfoPtr_ReleaseChildren_Public_Void_AtlasNodePool_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A60 RID: 6752 RVA: 0x0006D1B0 File Offset: 0x0006B3B0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 973388, RefRangeEnd = 973390, XrefRangeStart = 973387, XrefRangeEnd = 973388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ReleaseAndMerge(AtlasAllocatorDynamic.AtlasNodePool pool)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(pool);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasAllocatorDynamic.AtlasNode.NativeMethodInfoPtr_ReleaseAndMerge_Public_Void_AtlasNodePool_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A61 RID: 6753 RVA: 0x0006D1E8 File Offset: 0x0006B3E8
			[CallerCount(0)]
			public unsafe bool IsMergeNeeded(AtlasAllocatorDynamic.AtlasNodePool pool)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(pool);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasAllocatorDynamic.AtlasNode.NativeMethodInfoPtr_IsMergeNeeded_Public_Boolean_AtlasNodePool_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A62 RID: 6754 RVA: 0x0000D41D File Offset: 0x0000B61D
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AtlasAllocatorDynamic.AtlasNode>.NativeClassPtr, ref this));
			}

			// Token: 0x0400132E RID: 4910
			private static readonly IntPtr NativeFieldInfoPtr_m_Self;

			// Token: 0x0400132F RID: 4911
			private static readonly IntPtr NativeFieldInfoPtr_m_Parent;

			// Token: 0x04001330 RID: 4912
			private static readonly IntPtr NativeFieldInfoPtr_m_LeftChild;

			// Token: 0x04001331 RID: 4913
			private static readonly IntPtr NativeFieldInfoPtr_m_RightChild;

			// Token: 0x04001332 RID: 4914
			private static readonly IntPtr NativeFieldInfoPtr_m_FreelistNext;

			// Token: 0x04001333 RID: 4915
			private static readonly IntPtr NativeFieldInfoPtr_m_Flags;

			// Token: 0x04001334 RID: 4916
			private static readonly IntPtr NativeFieldInfoPtr_m_Rect;

			// Token: 0x04001335 RID: 4917
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int16_Int16_0;

			// Token: 0x04001336 RID: 4918
			private static readonly IntPtr NativeMethodInfoPtr_IsOccupied_Public_Boolean_0;

			// Token: 0x04001337 RID: 4919
			private static readonly IntPtr NativeMethodInfoPtr_SetIsOccupied_Public_Void_0;

			// Token: 0x04001338 RID: 4920
			private static readonly IntPtr NativeMethodInfoPtr_ClearIsOccupied_Public_Void_0;

			// Token: 0x04001339 RID: 4921
			private static readonly IntPtr NativeMethodInfoPtr_IsLeafNode_Public_Boolean_0;

			// Token: 0x0400133A RID: 4922
			private static readonly IntPtr NativeMethodInfoPtr_Allocate_Public_Int16_AtlasNodePool_Int32_Int32_0;

			// Token: 0x0400133B RID: 4923
			private static readonly IntPtr NativeMethodInfoPtr_ReleaseChildren_Public_Void_AtlasNodePool_0;

			// Token: 0x0400133C RID: 4924
			private static readonly IntPtr NativeMethodInfoPtr_ReleaseAndMerge_Public_Void_AtlasNodePool_0;

			// Token: 0x0400133D RID: 4925
			private static readonly IntPtr NativeMethodInfoPtr_IsMergeNeeded_Public_Boolean_AtlasNodePool_0;

			// Token: 0x0400133E RID: 4926
			[FieldOffset(0)]
			public short m_Self;

			// Token: 0x0400133F RID: 4927
			[FieldOffset(2)]
			public short m_Parent;

			// Token: 0x04001340 RID: 4928
			[FieldOffset(4)]
			public short m_LeftChild;

			// Token: 0x04001341 RID: 4929
			[FieldOffset(6)]
			public short m_RightChild;

			// Token: 0x04001342 RID: 4930
			[FieldOffset(8)]
			public short m_FreelistNext;

			// Token: 0x04001343 RID: 4931
			[FieldOffset(10)]
			public ushort m_Flags;

			// Token: 0x04001344 RID: 4932
			[FieldOffset(16)]
			public Vector4 m_Rect;

			// Token: 0x0200023C RID: 572
			public enum AtlasNodeFlags : uint
			{
				// Token: 0x04001458 RID: 5208
				IsOccupied = 1U
			}
		}
	}
}
