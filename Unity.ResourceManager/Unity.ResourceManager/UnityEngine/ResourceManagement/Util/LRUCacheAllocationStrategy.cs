using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.ResourceManagement.Util
{
	// Token: 0x02000022 RID: 34
	public class LRUCacheAllocationStrategy : Object
	{
		// Token: 0x060001CC RID: 460 RVA: 0x0000C0DC File Offset: 0x0000A2DC
		// Note: this type is marked as 'beforefieldinit'.
		static LRUCacheAllocationStrategy()
		{
			Il2CppClassPointerStore<LRUCacheAllocationStrategy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.Util", "LRUCacheAllocationStrategy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LRUCacheAllocationStrategy>.NativeClassPtr);
			LRUCacheAllocationStrategy.NativeFieldInfoPtr_m_poolMaxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LRUCacheAllocationStrategy>.NativeClassPtr, "m_poolMaxSize");
			LRUCacheAllocationStrategy.NativeFieldInfoPtr_m_poolInitialCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LRUCacheAllocationStrategy>.NativeClassPtr, "m_poolInitialCapacity");
			LRUCacheAllocationStrategy.NativeFieldInfoPtr_m_poolCacheMaxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LRUCacheAllocationStrategy>.NativeClassPtr, "m_poolCacheMaxSize");
			LRUCacheAllocationStrategy.NativeFieldInfoPtr_m_poolCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LRUCacheAllocationStrategy>.NativeClassPtr, "m_poolCache");
			LRUCacheAllocationStrategy.NativeFieldInfoPtr_m_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LRUCacheAllocationStrategy>.NativeClassPtr, "m_cache");
			LRUCacheAllocationStrategy.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LRUCacheAllocationStrategy>.NativeClassPtr, 100663623);
			LRUCacheAllocationStrategy.NativeMethodInfoPtr_GetPool_Private_List_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LRUCacheAllocationStrategy>.NativeClassPtr, 100663624);
			LRUCacheAllocationStrategy.NativeMethodInfoPtr_ReleasePool_Private_Void_List_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LRUCacheAllocationStrategy>.NativeClassPtr, 100663625);
			LRUCacheAllocationStrategy.NativeMethodInfoPtr_New_Public_Virtual_Final_New_Object_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LRUCacheAllocationStrategy>.NativeClassPtr, 100663626);
			LRUCacheAllocationStrategy.NativeMethodInfoPtr_Release_Public_Virtual_Final_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LRUCacheAllocationStrategy>.NativeClassPtr, 100663627);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0000C1D4 File Offset: 0x0000A3D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1138770, RefRangeEnd = 1138771, XrefRangeStart = 1138744, XrefRangeEnd = 1138770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LRUCacheAllocationStrategy(int poolMaxSize, int poolCapacity, int poolCacheMaxSize, int initialPoolCacheCapacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LRUCacheAllocationStrategy>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref poolMaxSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref poolCapacity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref poolCacheMaxSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialPoolCacheCapacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LRUCacheAllocationStrategy.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0000C248 File Offset: 0x0000A448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138771, XrefRangeEnd = 1138780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Object> GetPool()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LRUCacheAllocationStrategy.NativeMethodInfoPtr_GetPool_Private_List_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Object>>(intPtr3) : null;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000C288 File Offset: 0x0000A488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138780, XrefRangeEnd = 1138784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleasePool(List<Object> pool)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pool);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LRUCacheAllocationStrategy.NativeMethodInfoPtr_ReleasePool_Private_Void_List_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000C2CC File Offset: 0x0000A4CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138784, XrefRangeEnd = 1138792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object New(Type type, int typeHash)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref typeHash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LRUCacheAllocationStrategy.NativeMethodInfoPtr_New_Public_Virtual_Final_New_Object_Type_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000C32C File Offset: 0x0000A52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138792, XrefRangeEnd = 1138816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Release(int typeHash, Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeHash;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LRUCacheAllocationStrategy.NativeMethodInfoPtr_Release_Public_Virtual_Final_New_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00002B55 File Offset: 0x00000D55
		public LRUCacheAllocationStrategy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x0000C37C File Offset: 0x0000A57C
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00002B5E File Offset: 0x00000D5E
		public unsafe int m_poolMaxSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LRUCacheAllocationStrategy.NativeFieldInfoPtr_m_poolMaxSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LRUCacheAllocationStrategy.NativeFieldInfoPtr_m_poolMaxSize)) = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x0000C3A4 File Offset: 0x0000A5A4
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00002B79 File Offset: 0x00000D79
		public unsafe int m_poolInitialCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LRUCacheAllocationStrategy.NativeFieldInfoPtr_m_poolInitialCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LRUCacheAllocationStrategy.NativeFieldInfoPtr_m_poolInitialCapacity)) = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x0000C3CC File Offset: 0x0000A5CC
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x00002B94 File Offset: 0x00000D94
		public unsafe int m_poolCacheMaxSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LRUCacheAllocationStrategy.NativeFieldInfoPtr_m_poolCacheMaxSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LRUCacheAllocationStrategy.NativeFieldInfoPtr_m_poolCacheMaxSize)) = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x0000C3F4 File Offset: 0x0000A5F4
		// (set) Token: 0x060001DA RID: 474 RVA: 0x00002BAF File Offset: 0x00000DAF
		public unsafe List<List<Object>> m_poolCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LRUCacheAllocationStrategy.NativeFieldInfoPtr_m_poolCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<List<Object>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LRUCacheAllocationStrategy.NativeFieldInfoPtr_m_poolCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0000C424 File Offset: 0x0000A624
		// (set) Token: 0x060001DC RID: 476 RVA: 0x00002BCE File Offset: 0x00000DCE
		public unsafe Dictionary<int, List<Object>> m_cache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LRUCacheAllocationStrategy.NativeFieldInfoPtr_m_cache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, List<Object>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LRUCacheAllocationStrategy.NativeFieldInfoPtr_m_cache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeFieldInfoPtr_m_poolMaxSize;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeFieldInfoPtr_m_poolInitialCapacity;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeFieldInfoPtr_m_poolCacheMaxSize;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeFieldInfoPtr_m_poolCache;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeFieldInfoPtr_m_cache;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_GetPool_Private_List_1_Object_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_ReleasePool_Private_Void_List_1_Object_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Virtual_Final_New_Object_Type_Int32_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_Final_New_Void_Int32_Object_0;
	}
}
