using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x0200024D RID: 589
	public class Page : Object
	{
		// Token: 0x06002BB7 RID: 11191 RVA: 0x000BD0C0 File Offset: 0x000BB2C0
		// Note: this type is marked as 'beforefieldinit'.
		static Page()
		{
			Il2CppClassPointerStore<Page>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "Page");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Page>.NativeClassPtr);
			Page.NativeFieldInfoPtr__disposed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page>.NativeClassPtr, "<disposed>k__BackingField");
			Page.NativeFieldInfoPtr_vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page>.NativeClassPtr, "vertices");
			Page.NativeFieldInfoPtr_indices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page>.NativeClassPtr, "indices");
			Page.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page>.NativeClassPtr, "next");
			Page.NativeFieldInfoPtr_framesEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page>.NativeClassPtr, "framesEmpty");
			Page.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Page>.NativeClassPtr, 100669792);
			Page.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Page>.NativeClassPtr, 100669793);
			Page.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Page>.NativeClassPtr, 100669794);
			Page.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Page>.NativeClassPtr, 100669795);
			Page.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Page>.NativeClassPtr, 100669796);
			Page.NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Page>.NativeClassPtr, 100669797);
		}

		// Token: 0x06002BB8 RID: 11192 RVA: 0x000BD1CC File Offset: 0x000BB3CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 349767, RefRangeEnd = 349769, XrefRangeStart = 349748, XrefRangeEnd = 349767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Page(uint vertexMaxCount, uint indexMaxCount, uint maxQueuedFrameCount, bool mockPage)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Page>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vertexMaxCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexMaxCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxQueuedFrameCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mockPage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Page.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x06002BB9 RID: 11193 RVA: 0x000BD240 File Offset: 0x000BB440
		// (set) Token: 0x06002BBA RID: 11194 RVA: 0x000BD27C File Offset: 0x000BB47C
		public unsafe bool disposed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Page.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Page.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002BBB RID: 11195 RVA: 0x000BD2BC File Offset: 0x000BB4BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349769, XrefRangeEnd = 349773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Page.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BBC RID: 11196 RVA: 0x000BD2F0 File Offset: 0x000BB4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349773, XrefRangeEnd = 349779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Page.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x06002BBD RID: 11197 RVA: 0x000BD33C File Offset: 0x000BB53C
		public unsafe bool isEmpty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Page.NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BBE RID: 11198 RVA: 0x00011AD9 File Offset: 0x0000FCD9
		public Page(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x06002BBF RID: 11199 RVA: 0x000BD378 File Offset: 0x000BB578
		// (set) Token: 0x06002BC0 RID: 11200 RVA: 0x00011AE2 File Offset: 0x0000FCE2
		public unsafe bool _disposed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr__disposed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr__disposed_k__BackingField)) = value;
			}
		}

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x06002BC1 RID: 11201 RVA: 0x000BD3A0 File Offset: 0x000BB5A0
		// (set) Token: 0x06002BC2 RID: 11202 RVA: 0x00011AFD File Offset: 0x0000FCFD
		public unsafe Page.DataSet<Vertex> vertices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_vertices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Page.DataSet<Vertex>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_vertices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x06002BC3 RID: 11203 RVA: 0x000BD3D0 File Offset: 0x000BB5D0
		// (set) Token: 0x06002BC4 RID: 11204 RVA: 0x00011B1C File Offset: 0x0000FD1C
		public unsafe Page.DataSet<ushort> indices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_indices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Page.DataSet<ushort>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_indices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x06002BC5 RID: 11205 RVA: 0x000BD400 File Offset: 0x000BB600
		// (set) Token: 0x06002BC6 RID: 11206 RVA: 0x00011B3B File Offset: 0x0000FD3B
		public unsafe Page next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Page>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x06002BC7 RID: 11207 RVA: 0x000BD430 File Offset: 0x000BB630
		// (set) Token: 0x06002BC8 RID: 11208 RVA: 0x00011B5A File Offset: 0x0000FD5A
		public unsafe int framesEmpty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_framesEmpty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_framesEmpty)) = value;
			}
		}

		// Token: 0x04001F1C RID: 7964
		private static readonly IntPtr NativeFieldInfoPtr__disposed_k__BackingField;

		// Token: 0x04001F1D RID: 7965
		private static readonly IntPtr NativeFieldInfoPtr_vertices;

		// Token: 0x04001F1E RID: 7966
		private static readonly IntPtr NativeFieldInfoPtr_indices;

		// Token: 0x04001F1F RID: 7967
		private static readonly IntPtr NativeFieldInfoPtr_next;

		// Token: 0x04001F20 RID: 7968
		private static readonly IntPtr NativeFieldInfoPtr_framesEmpty;

		// Token: 0x04001F21 RID: 7969
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_Boolean_0;

		// Token: 0x04001F22 RID: 7970
		private static readonly IntPtr NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0;

		// Token: 0x04001F23 RID: 7971
		private static readonly IntPtr NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0;

		// Token: 0x04001F24 RID: 7972
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001F25 RID: 7973
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04001F26 RID: 7974
		private static readonly IntPtr NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0;

		// Token: 0x0200054E RID: 1358
		public class DataSet<T> : Object where T : new()
		{
			// Token: 0x0600414B RID: 16715 RVA: 0x00101DC4 File Offset: 0x000FFFC4
			// Note: this type is marked as 'beforefieldinit'.
			static DataSet()
			{
				Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Page>.NativeClassPtr, "DataSet`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr);
				Page.DataSet<T>.NativeFieldInfoPtr__disposed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, "<disposed>k__BackingField");
				Page.DataSet<T>.NativeFieldInfoPtr_gpuData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, "gpuData");
				Page.DataSet<T>.NativeFieldInfoPtr_cpuData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, "cpuData");
				Page.DataSet<T>.NativeFieldInfoPtr_updateRanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, "updateRanges");
				Page.DataSet<T>.NativeFieldInfoPtr_allocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, "allocator");
				Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangePoolSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, "m_UpdateRangePoolSize");
				Page.DataSet<T>.NativeFieldInfoPtr_m_ElemStride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, "m_ElemStride");
				Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, "m_UpdateRangeMin");
				Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, "m_UpdateRangeMax");
				Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangesEnqueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, "m_UpdateRangesEnqueued");
				Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangesBatchStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, "m_UpdateRangesBatchStart");
				Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangesSaturated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, "m_UpdateRangesSaturated");
				Page.DataSet<T>.NativeMethodInfoPtr__ctor_Public_Void_GPUBufferType_UInt32_UInt32_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, 100669798);
				Page.DataSet<T>.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, 100669799);
				Page.DataSet<T>.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, 100669800);
				Page.DataSet<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, 100669801);
				Page.DataSet<T>.NativeMethodInfoPtr_Dispose_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, 100669802);
				Page.DataSet<T>.NativeMethodInfoPtr_RegisterUpdate_Public_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, 100669803);
				Page.DataSet<T>.NativeMethodInfoPtr_HasMappedBufferRange_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, 100669804);
				Page.DataSet<T>.NativeMethodInfoPtr_SendUpdates_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, 100669805);
				Page.DataSet<T>.NativeMethodInfoPtr_SendFullRange_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, 100669806);
				Page.DataSet<T>.NativeMethodInfoPtr_SendPartialRanges_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, 100669807);
				Page.DataSet<T>.NativeMethodInfoPtr_ResetUpdateState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr, 100669808);
			}

			// Token: 0x0600414C RID: 16716 RVA: 0x00101FF8 File Offset: 0x001001F8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 349663, RefRangeEnd = 349664, XrefRangeStart = 349648, XrefRangeEnd = 349663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DataSet(Utility.GPUBufferType bufferType, uint totalCount, uint maxQueuedFrameCount, uint updateRangePoolSize, bool mockBuffer)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Page.DataSet<T>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref bufferType;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalCount;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxQueuedFrameCount;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateRangePoolSize;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mockBuffer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Page.DataSet<T>.NativeMethodInfoPtr__ctor_Public_Void_GPUBufferType_UInt32_UInt32_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700139B RID: 5019
			// (get) Token: 0x0600414D RID: 16717 RVA: 0x00102078 File Offset: 0x00100278
			// (set) Token: 0x0600414E RID: 16718 RVA: 0x001020B4 File Offset: 0x001002B4
			public unsafe bool disposed
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Page.DataSet<T>.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Page.DataSet<T>.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x0600414F RID: 16719 RVA: 0x001020F4 File Offset: 0x001002F4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 349681, RefRangeEnd = 349682, XrefRangeStart = 349664, XrefRangeEnd = 349681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Page.DataSet<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004150 RID: 16720 RVA: 0x00102128 File Offset: 0x00100328
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349682, XrefRangeEnd = 349687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose(bool disposing)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref disposing;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Page.DataSet<T>.NativeMethodInfoPtr_Dispose_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004151 RID: 16721 RVA: 0x00102168 File Offset: 0x00100368
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 349703, RefRangeEnd = 349706, XrefRangeStart = 349687, XrefRangeEnd = 349703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void RegisterUpdate(uint start, uint size)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref start;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Page.DataSet<T>.NativeMethodInfoPtr_RegisterUpdate_Public_Void_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004152 RID: 16722 RVA: 0x001021B4 File Offset: 0x001003B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349706, XrefRangeEnd = 349726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool HasMappedBufferRange()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Page.DataSet<T>.NativeMethodInfoPtr_HasMappedBufferRange_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004153 RID: 16723 RVA: 0x001021F0 File Offset: 0x001003F0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 349735, RefRangeEnd = 349737, XrefRangeStart = 349726, XrefRangeEnd = 349735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SendUpdates()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Page.DataSet<T>.NativeMethodInfoPtr_SendUpdates_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004154 RID: 16724 RVA: 0x00102224 File Offset: 0x00100424
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349737, XrefRangeEnd = 349742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SendFullRange()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Page.DataSet<T>.NativeMethodInfoPtr_SendFullRange_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004155 RID: 16725 RVA: 0x00102258 File Offset: 0x00100458
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349742, XrefRangeEnd = 349748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SendPartialRanges()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Page.DataSet<T>.NativeMethodInfoPtr_SendPartialRanges_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004156 RID: 16726 RVA: 0x0010228C File Offset: 0x0010048C
			[CallerCount(0)]
			public unsafe void ResetUpdateState()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Page.DataSet<T>.NativeMethodInfoPtr_ResetUpdateState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004157 RID: 16727 RVA: 0x0001BA0A File Offset: 0x00019C0A
			public DataSet(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700138F RID: 5007
			// (get) Token: 0x06004158 RID: 16728 RVA: 0x001022C0 File Offset: 0x001004C0
			// (set) Token: 0x06004159 RID: 16729 RVA: 0x0001BA13 File Offset: 0x00019C13
			public unsafe bool _disposed_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr__disposed_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr__disposed_k__BackingField)) = value;
				}
			}

			// Token: 0x17001390 RID: 5008
			// (get) Token: 0x0600415A RID: 16730 RVA: 0x001022E8 File Offset: 0x001004E8
			// (set) Token: 0x0600415B RID: 16731 RVA: 0x0001BA2E File Offset: 0x00019C2E
			public unsafe Utility.GPUBuffer<T> gpuData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_gpuData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Utility.GPUBuffer<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_gpuData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001391 RID: 5009
			// (get) Token: 0x0600415C RID: 16732 RVA: 0x00102318 File Offset: 0x00100518
			// (set) Token: 0x0600415D RID: 16733 RVA: 0x0001BA4D File Offset: 0x00019C4D
			public NativeArray<T> cpuData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_cpuData);
					return new NativeArray<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_cpuData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001392 RID: 5010
			// (get) Token: 0x0600415E RID: 16734 RVA: 0x00102348 File Offset: 0x00100548
			// (set) Token: 0x0600415F RID: 16735 RVA: 0x0001BA7B File Offset: 0x00019C7B
			public NativeArray<GfxUpdateBufferRange> updateRanges
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_updateRanges);
					return new NativeArray<GfxUpdateBufferRange>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<GfxUpdateBufferRange>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_updateRanges), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<GfxUpdateBufferRange>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001393 RID: 5011
			// (get) Token: 0x06004160 RID: 16736 RVA: 0x00102378 File Offset: 0x00100578
			// (set) Token: 0x06004161 RID: 16737 RVA: 0x0001BAA9 File Offset: 0x00019CA9
			public unsafe GPUBufferAllocator allocator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_allocator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GPUBufferAllocator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_allocator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001394 RID: 5012
			// (get) Token: 0x06004162 RID: 16738 RVA: 0x001023A8 File Offset: 0x001005A8
			// (set) Token: 0x06004163 RID: 16739 RVA: 0x0001BAC8 File Offset: 0x00019CC8
			public unsafe uint m_UpdateRangePoolSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangePoolSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangePoolSize)) = value;
				}
			}

			// Token: 0x17001395 RID: 5013
			// (get) Token: 0x06004164 RID: 16740 RVA: 0x001023D0 File Offset: 0x001005D0
			// (set) Token: 0x06004165 RID: 16741 RVA: 0x0001BAE3 File Offset: 0x00019CE3
			public unsafe uint m_ElemStride
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_m_ElemStride);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_m_ElemStride)) = value;
				}
			}

			// Token: 0x17001396 RID: 5014
			// (get) Token: 0x06004166 RID: 16742 RVA: 0x001023F8 File Offset: 0x001005F8
			// (set) Token: 0x06004167 RID: 16743 RVA: 0x0001BAFE File Offset: 0x00019CFE
			public unsafe uint m_UpdateRangeMin
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangeMin);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangeMin)) = value;
				}
			}

			// Token: 0x17001397 RID: 5015
			// (get) Token: 0x06004168 RID: 16744 RVA: 0x00102420 File Offset: 0x00100620
			// (set) Token: 0x06004169 RID: 16745 RVA: 0x0001BB19 File Offset: 0x00019D19
			public unsafe uint m_UpdateRangeMax
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangeMax);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangeMax)) = value;
				}
			}

			// Token: 0x17001398 RID: 5016
			// (get) Token: 0x0600416A RID: 16746 RVA: 0x00102448 File Offset: 0x00100648
			// (set) Token: 0x0600416B RID: 16747 RVA: 0x0001BB34 File Offset: 0x00019D34
			public unsafe uint m_UpdateRangesEnqueued
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangesEnqueued);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangesEnqueued)) = value;
				}
			}

			// Token: 0x17001399 RID: 5017
			// (get) Token: 0x0600416C RID: 16748 RVA: 0x00102470 File Offset: 0x00100670
			// (set) Token: 0x0600416D RID: 16749 RVA: 0x0001BB4F File Offset: 0x00019D4F
			public unsafe uint m_UpdateRangesBatchStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangesBatchStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangesBatchStart)) = value;
				}
			}

			// Token: 0x1700139A RID: 5018
			// (get) Token: 0x0600416E RID: 16750 RVA: 0x00102498 File Offset: 0x00100698
			// (set) Token: 0x0600416F RID: 16751 RVA: 0x0001BB6A File Offset: 0x00019D6A
			public unsafe bool m_UpdateRangesSaturated
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangesSaturated);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Page.DataSet<T>.NativeFieldInfoPtr_m_UpdateRangesSaturated)) = value;
				}
			}

			// Token: 0x04002DEB RID: 11755
			private static readonly IntPtr NativeFieldInfoPtr__disposed_k__BackingField;

			// Token: 0x04002DEC RID: 11756
			private static readonly IntPtr NativeFieldInfoPtr_gpuData;

			// Token: 0x04002DED RID: 11757
			private static readonly IntPtr NativeFieldInfoPtr_cpuData;

			// Token: 0x04002DEE RID: 11758
			private static readonly IntPtr NativeFieldInfoPtr_updateRanges;

			// Token: 0x04002DEF RID: 11759
			private static readonly IntPtr NativeFieldInfoPtr_allocator;

			// Token: 0x04002DF0 RID: 11760
			private static readonly IntPtr NativeFieldInfoPtr_m_UpdateRangePoolSize;

			// Token: 0x04002DF1 RID: 11761
			private static readonly IntPtr NativeFieldInfoPtr_m_ElemStride;

			// Token: 0x04002DF2 RID: 11762
			private static readonly IntPtr NativeFieldInfoPtr_m_UpdateRangeMin;

			// Token: 0x04002DF3 RID: 11763
			private static readonly IntPtr NativeFieldInfoPtr_m_UpdateRangeMax;

			// Token: 0x04002DF4 RID: 11764
			private static readonly IntPtr NativeFieldInfoPtr_m_UpdateRangesEnqueued;

			// Token: 0x04002DF5 RID: 11765
			private static readonly IntPtr NativeFieldInfoPtr_m_UpdateRangesBatchStart;

			// Token: 0x04002DF6 RID: 11766
			private static readonly IntPtr NativeFieldInfoPtr_m_UpdateRangesSaturated;

			// Token: 0x04002DF7 RID: 11767
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GPUBufferType_UInt32_UInt32_UInt32_Boolean_0;

			// Token: 0x04002DF8 RID: 11768
			private static readonly IntPtr NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0;

			// Token: 0x04002DF9 RID: 11769
			private static readonly IntPtr NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0;

			// Token: 0x04002DFA RID: 11770
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x04002DFB RID: 11771
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_Boolean_0;

			// Token: 0x04002DFC RID: 11772
			private static readonly IntPtr NativeMethodInfoPtr_RegisterUpdate_Public_Void_UInt32_UInt32_0;

			// Token: 0x04002DFD RID: 11773
			private static readonly IntPtr NativeMethodInfoPtr_HasMappedBufferRange_Private_Boolean_0;

			// Token: 0x04002DFE RID: 11774
			private static readonly IntPtr NativeMethodInfoPtr_SendUpdates_Public_Void_0;

			// Token: 0x04002DFF RID: 11775
			private static readonly IntPtr NativeMethodInfoPtr_SendFullRange_Public_Void_0;

			// Token: 0x04002E00 RID: 11776
			private static readonly IntPtr NativeMethodInfoPtr_SendPartialRanges_Public_Void_0;

			// Token: 0x04002E01 RID: 11777
			private static readonly IntPtr NativeMethodInfoPtr_ResetUpdateState_Private_Void_0;
		}
	}
}
