using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x0200025E RID: 606
	public class NativePagedList<T> : Object where T : new()
	{
		// Token: 0x06002C8B RID: 11403 RVA: 0x000BFE38 File Offset: 0x000BE038
		// Note: this type is marked as 'beforefieldinit'.
		static NativePagedList()
		{
			Il2CppClassPointerStore<NativePagedList<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "NativePagedList`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativePagedList<T>>.NativeClassPtr);
			NativePagedList<T>.NativeFieldInfoPtr_k_PoolCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePagedList<T>>.NativeClassPtr, "k_PoolCapacity");
			NativePagedList<T>.NativeFieldInfoPtr_m_Pages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePagedList<T>>.NativeClassPtr, "m_Pages");
			NativePagedList<T>.NativeFieldInfoPtr_m_CurrentPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePagedList<T>>.NativeClassPtr, "m_CurrentPage");
			NativePagedList<T>.NativeFieldInfoPtr_m_CurrentPageCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePagedList<T>>.NativeClassPtr, "m_CurrentPageCount");
			NativePagedList<T>.NativeFieldInfoPtr_m_Enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePagedList<T>>.NativeClassPtr, "m_Enumerator");
			NativePagedList<T>.NativeFieldInfoPtr__disposed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePagedList<T>>.NativeClassPtr, "<disposed>k__BackingField");
			NativePagedList<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePagedList<T>>.NativeClassPtr, 100669873);
			NativePagedList<T>.NativeMethodInfoPtr_Add_Public_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePagedList<T>>.NativeClassPtr, 100669874);
			NativePagedList<T>.NativeMethodInfoPtr_GetPages_Public_List_1_NativeSlice_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePagedList<T>>.NativeClassPtr, 100669875);
			NativePagedList<T>.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePagedList<T>>.NativeClassPtr, 100669876);
			NativePagedList<T>.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePagedList<T>>.NativeClassPtr, 100669877);
			NativePagedList<T>.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePagedList<T>>.NativeClassPtr, 100669878);
			NativePagedList<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePagedList<T>>.NativeClassPtr, 100669879);
			NativePagedList<T>.NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePagedList<T>>.NativeClassPtr, 100669880);
		}

		// Token: 0x06002C8C RID: 11404 RVA: 0x000BFFBC File Offset: 0x000BE1BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 350453, RefRangeEnd = 350455, XrefRangeStart = 350439, XrefRangeEnd = 350453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativePagedList(int poolCapacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativePagedList<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref poolCapacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativePagedList<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C8D RID: 11405 RVA: 0x000C0004 File Offset: 0x000BE204
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350460, RefRangeEnd = 350461, XrefRangeStart = 350455, XrefRangeEnd = 350460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(ref T data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(data);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativePagedList<T>.NativeMethodInfoPtr_Add_Public_Void_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				data = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			}
		}

		// Token: 0x06002C8E RID: 11406 RVA: 0x000C0060 File Offset: 0x000BE260
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350470, RefRangeEnd = 350471, XrefRangeStart = 350461, XrefRangeEnd = 350470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<NativeSlice<T>> GetPages()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativePagedList<T>.NativeMethodInfoPtr_GetPages_Public_List_1_NativeSlice_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NativeSlice<T>>>(intPtr3) : null;
		}

		// Token: 0x06002C8F RID: 11407 RVA: 0x000C00A0 File Offset: 0x000BE2A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 350476, RefRangeEnd = 350479, XrefRangeStart = 350471, XrefRangeEnd = 350476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativePagedList<T>.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x06002C90 RID: 11408 RVA: 0x000C00D4 File Offset: 0x000BE2D4
		// (set) Token: 0x06002C91 RID: 11409 RVA: 0x000C0110 File Offset: 0x000BE310
		public unsafe bool disposed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativePagedList<T>.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativePagedList<T>.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002C92 RID: 11410 RVA: 0x000C0150 File Offset: 0x000BE350
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 350495, RefRangeEnd = 350498, XrefRangeStart = 350479, XrefRangeEnd = 350495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativePagedList<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C93 RID: 11411 RVA: 0x000C0184 File Offset: 0x000BE384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350498, XrefRangeEnd = 350501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativePagedList<T>.NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C94 RID: 11412 RVA: 0x0001214F File Offset: 0x0001034F
		public NativePagedList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x06002C95 RID: 11413 RVA: 0x000C01C4 File Offset: 0x000BE3C4
		// (set) Token: 0x06002C96 RID: 11414 RVA: 0x00012158 File Offset: 0x00010358
		public unsafe int k_PoolCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativePagedList<T>.NativeFieldInfoPtr_k_PoolCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativePagedList<T>.NativeFieldInfoPtr_k_PoolCapacity)) = value;
			}
		}

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x06002C97 RID: 11415 RVA: 0x000C01EC File Offset: 0x000BE3EC
		// (set) Token: 0x06002C98 RID: 11416 RVA: 0x00012173 File Offset: 0x00010373
		public unsafe List<NativeArray<T>> m_Pages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativePagedList<T>.NativeFieldInfoPtr_m_Pages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NativeArray<T>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativePagedList<T>.NativeFieldInfoPtr_m_Pages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x06002C99 RID: 11417 RVA: 0x000C021C File Offset: 0x000BE41C
		// (set) Token: 0x06002C9A RID: 11418 RVA: 0x00012192 File Offset: 0x00010392
		public NativeArray<T> m_CurrentPage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativePagedList<T>.NativeFieldInfoPtr_m_CurrentPage);
				return new NativeArray<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativePagedList<T>.NativeFieldInfoPtr_m_CurrentPage), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x06002C9B RID: 11419 RVA: 0x000C024C File Offset: 0x000BE44C
		// (set) Token: 0x06002C9C RID: 11420 RVA: 0x000121C0 File Offset: 0x000103C0
		public unsafe int m_CurrentPageCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativePagedList<T>.NativeFieldInfoPtr_m_CurrentPageCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativePagedList<T>.NativeFieldInfoPtr_m_CurrentPageCount)) = value;
			}
		}

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x06002C9D RID: 11421 RVA: 0x000C0274 File Offset: 0x000BE474
		// (set) Token: 0x06002C9E RID: 11422 RVA: 0x000121DB File Offset: 0x000103DB
		public unsafe List<NativeSlice<T>> m_Enumerator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativePagedList<T>.NativeFieldInfoPtr_m_Enumerator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NativeSlice<T>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativePagedList<T>.NativeFieldInfoPtr_m_Enumerator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x06002C9F RID: 11423 RVA: 0x000C02A4 File Offset: 0x000BE4A4
		// (set) Token: 0x06002CA0 RID: 11424 RVA: 0x000121FA File Offset: 0x000103FA
		public unsafe bool _disposed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativePagedList<T>.NativeFieldInfoPtr__disposed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativePagedList<T>.NativeFieldInfoPtr__disposed_k__BackingField)) = value;
			}
		}

		// Token: 0x06002CA1 RID: 11425 RVA: 0x00012215 File Offset: 0x00010415
		public void Add(T data)
		{
			this.Add(ref data);
		}

		// Token: 0x04001FEA RID: 8170
		private static readonly IntPtr NativeFieldInfoPtr_k_PoolCapacity;

		// Token: 0x04001FEB RID: 8171
		private static readonly IntPtr NativeFieldInfoPtr_m_Pages;

		// Token: 0x04001FEC RID: 8172
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentPage;

		// Token: 0x04001FED RID: 8173
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentPageCount;

		// Token: 0x04001FEE RID: 8174
		private static readonly IntPtr NativeFieldInfoPtr_m_Enumerator;

		// Token: 0x04001FEF RID: 8175
		private static readonly IntPtr NativeFieldInfoPtr__disposed_k__BackingField;

		// Token: 0x04001FF0 RID: 8176
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001FF1 RID: 8177
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_byref_T_0;

		// Token: 0x04001FF2 RID: 8178
		private static readonly IntPtr NativeMethodInfoPtr_GetPages_Public_List_1_NativeSlice_1_T_0;

		// Token: 0x04001FF3 RID: 8179
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04001FF4 RID: 8180
		private static readonly IntPtr NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0;

		// Token: 0x04001FF5 RID: 8181
		private static readonly IntPtr NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0;

		// Token: 0x04001FF6 RID: 8182
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001FF7 RID: 8183
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0;
	}
}
