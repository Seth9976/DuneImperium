using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal.LibTessDotNet
{
	// Token: 0x0200010E RID: 270
	public class PriorityHeap<TValue> : Object where TValue : class
	{
		// Token: 0x06001679 RID: 5753 RVA: 0x00060680 File Offset: 0x0005E880
		// Note: this type is marked as 'beforefieldinit'.
		static PriorityHeap()
		{
			Il2CppClassPointerStore<PriorityHeap<TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.LibTessDotNet", "PriorityHeap`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PriorityHeap<TValue>>.NativeClassPtr);
			PriorityHeap<TValue>.NativeFieldInfoPtr__leq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityHeap<TValue>>.NativeClassPtr, "_leq");
			PriorityHeap<TValue>.NativeFieldInfoPtr__nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityHeap<TValue>>.NativeClassPtr, "_nodes");
			PriorityHeap<TValue>.NativeFieldInfoPtr__handles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityHeap<TValue>>.NativeClassPtr, "_handles");
			PriorityHeap<TValue>.NativeFieldInfoPtr__size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityHeap<TValue>>.NativeClassPtr, "_size");
			PriorityHeap<TValue>.NativeFieldInfoPtr__max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityHeap<TValue>>.NativeClassPtr, "_max");
			PriorityHeap<TValue>.NativeFieldInfoPtr__freeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityHeap<TValue>>.NativeClassPtr, "_freeList");
			PriorityHeap<TValue>.NativeFieldInfoPtr__initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityHeap<TValue>>.NativeClassPtr, "_initialized");
			PriorityHeap<TValue>.NativeMethodInfoPtr_get_Empty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityHeap<TValue>>.NativeClassPtr, 100665940);
			PriorityHeap<TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_LessOrEqual_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityHeap<TValue>>.NativeClassPtr, 100665941);
			PriorityHeap<TValue>.NativeMethodInfoPtr_FloatDown_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityHeap<TValue>>.NativeClassPtr, 100665942);
			PriorityHeap<TValue>.NativeMethodInfoPtr_FloatUp_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityHeap<TValue>>.NativeClassPtr, 100665943);
			PriorityHeap<TValue>.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityHeap<TValue>>.NativeClassPtr, 100665944);
			PriorityHeap<TValue>.NativeMethodInfoPtr_Insert_Public_PQHandle_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityHeap<TValue>>.NativeClassPtr, 100665945);
			PriorityHeap<TValue>.NativeMethodInfoPtr_ExtractMin_Public_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityHeap<TValue>>.NativeClassPtr, 100665946);
			PriorityHeap<TValue>.NativeMethodInfoPtr_Minimum_Public_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityHeap<TValue>>.NativeClassPtr, 100665947);
			PriorityHeap<TValue>.NativeMethodInfoPtr_Remove_Public_Void_PQHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityHeap<TValue>>.NativeClassPtr, 100665948);
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x0600167A RID: 5754 RVA: 0x0006082C File Offset: 0x0005EA2C
		public unsafe bool Empty
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 623558, RefRangeEnd = 623560, XrefRangeStart = 623558, XrefRangeEnd = 623558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityHeap<TValue>.NativeMethodInfoPtr_get_Empty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x00060868 File Offset: 0x0005EA68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 623578, RefRangeEnd = 623579, XrefRangeStart = 623560, XrefRangeEnd = 623578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PriorityHeap(int initialSize, PriorityHeap<TValue>.LessOrEqual leq)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PriorityHeap<TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(leq);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityHeap<TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_LessOrEqual_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x000608C4 File Offset: 0x0005EAC4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 623580, RefRangeEnd = 623584, XrefRangeStart = 623579, XrefRangeEnd = 623580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FloatDown(int curr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref curr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityHeap<TValue>.NativeMethodInfoPtr_FloatDown_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x00060904 File Offset: 0x0005EB04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 623585, RefRangeEnd = 623587, XrefRangeStart = 623584, XrefRangeEnd = 623585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FloatUp(int curr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref curr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityHeap<TValue>.NativeMethodInfoPtr_FloatUp_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x00060944 File Offset: 0x0005EB44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623587, XrefRangeEnd = 623588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityHeap<TValue>.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x00060978 File Offset: 0x0005EB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623588, XrefRangeEnd = 623601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PQHandle Insert(TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TValue).IsValueType)
				{
					TValue tvalue = value;
					intPtr = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PriorityHeap<TValue>.NativeMethodInfoPtr_Insert_Public_PQHandle_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x000609FC File Offset: 0x0005EBFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623601, XrefRangeEnd = 623602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TValue ExtractMin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityHeap<TValue>.NativeMethodInfoPtr_ExtractMin_Public_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x00060A38 File Offset: 0x0005EC38
		[CallerCount(0)]
		public unsafe TValue Minimum()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityHeap<TValue>.NativeMethodInfoPtr_Minimum_Public_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x00060A74 File Offset: 0x0005EC74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623602, XrefRangeEnd = 623605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(PQHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityHeap<TValue>.NativeMethodInfoPtr_Remove_Public_Void_PQHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x0000CF8E File Offset: 0x0000B18E
		public PriorityHeap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06001684 RID: 5764 RVA: 0x00060AB4 File Offset: 0x0005ECB4
		// (set) Token: 0x06001685 RID: 5765 RVA: 0x0000CF97 File Offset: 0x0000B197
		public unsafe PriorityHeap<TValue>.LessOrEqual _leq
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityHeap<TValue>.NativeFieldInfoPtr__leq);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PriorityHeap<TValue>.LessOrEqual>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityHeap<TValue>.NativeFieldInfoPtr__leq), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06001686 RID: 5766 RVA: 0x00060AE4 File Offset: 0x0005ECE4
		// (set) Token: 0x06001687 RID: 5767 RVA: 0x0000CFB6 File Offset: 0x0000B1B6
		public unsafe Il2CppStructArray<int> _nodes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityHeap<TValue>.NativeFieldInfoPtr__nodes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityHeap<TValue>.NativeFieldInfoPtr__nodes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06001688 RID: 5768 RVA: 0x00060B14 File Offset: 0x0005ED14
		// (set) Token: 0x06001689 RID: 5769 RVA: 0x0000CFD5 File Offset: 0x0000B1D5
		public unsafe Il2CppReferenceArray<PriorityHeap<TValue>.HandleElem> _handles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityHeap<TValue>.NativeFieldInfoPtr__handles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PriorityHeap<TValue>.HandleElem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityHeap<TValue>.NativeFieldInfoPtr__handles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x0600168A RID: 5770 RVA: 0x00060B44 File Offset: 0x0005ED44
		// (set) Token: 0x0600168B RID: 5771 RVA: 0x0000CFF4 File Offset: 0x0000B1F4
		public unsafe int _size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityHeap<TValue>.NativeFieldInfoPtr__size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityHeap<TValue>.NativeFieldInfoPtr__size)) = value;
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x0600168C RID: 5772 RVA: 0x00060B6C File Offset: 0x0005ED6C
		// (set) Token: 0x0600168D RID: 5773 RVA: 0x0000D00F File Offset: 0x0000B20F
		public unsafe int _max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityHeap<TValue>.NativeFieldInfoPtr__max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityHeap<TValue>.NativeFieldInfoPtr__max)) = value;
			}
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x0600168E RID: 5774 RVA: 0x00060B94 File Offset: 0x0005ED94
		// (set) Token: 0x0600168F RID: 5775 RVA: 0x0000D02A File Offset: 0x0000B22A
		public unsafe int _freeList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityHeap<TValue>.NativeFieldInfoPtr__freeList);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityHeap<TValue>.NativeFieldInfoPtr__freeList)) = value;
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06001690 RID: 5776 RVA: 0x00060BBC File Offset: 0x0005EDBC
		// (set) Token: 0x06001691 RID: 5777 RVA: 0x0000D045 File Offset: 0x0000B245
		public unsafe bool _initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityHeap<TValue>.NativeFieldInfoPtr__initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityHeap<TValue>.NativeFieldInfoPtr__initialized)) = value;
			}
		}

		// Token: 0x0400105A RID: 4186
		private static readonly IntPtr NativeFieldInfoPtr__leq;

		// Token: 0x0400105B RID: 4187
		private static readonly IntPtr NativeFieldInfoPtr__nodes;

		// Token: 0x0400105C RID: 4188
		private static readonly IntPtr NativeFieldInfoPtr__handles;

		// Token: 0x0400105D RID: 4189
		private static readonly IntPtr NativeFieldInfoPtr__size;

		// Token: 0x0400105E RID: 4190
		private static readonly IntPtr NativeFieldInfoPtr__max;

		// Token: 0x0400105F RID: 4191
		private static readonly IntPtr NativeFieldInfoPtr__freeList;

		// Token: 0x04001060 RID: 4192
		private static readonly IntPtr NativeFieldInfoPtr__initialized;

		// Token: 0x04001061 RID: 4193
		private static readonly IntPtr NativeMethodInfoPtr_get_Empty_Public_get_Boolean_0;

		// Token: 0x04001062 RID: 4194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_LessOrEqual_TValue_0;

		// Token: 0x04001063 RID: 4195
		private static readonly IntPtr NativeMethodInfoPtr_FloatDown_Private_Void_Int32_0;

		// Token: 0x04001064 RID: 4196
		private static readonly IntPtr NativeMethodInfoPtr_FloatUp_Private_Void_Int32_0;

		// Token: 0x04001065 RID: 4197
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

		// Token: 0x04001066 RID: 4198
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_PQHandle_TValue_0;

		// Token: 0x04001067 RID: 4199
		private static readonly IntPtr NativeMethodInfoPtr_ExtractMin_Public_TValue_0;

		// Token: 0x04001068 RID: 4200
		private static readonly IntPtr NativeMethodInfoPtr_Minimum_Public_TValue_0;

		// Token: 0x04001069 RID: 4201
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_PQHandle_0;

		// Token: 0x020001DE RID: 478
		public sealed class LessOrEqual : MulticastDelegate
		{
			// Token: 0x06002164 RID: 8548 RVA: 0x000814EC File Offset: 0x0007F6EC
			// Note: this type is marked as 'beforefieldinit'.
			static LessOrEqual()
			{
				Il2CppClassPointerStore<PriorityHeap<TValue>.LessOrEqual>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PriorityHeap<TValue>>.NativeClassPtr, "LessOrEqual"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) })).TypeHandle.value);
				PriorityHeap<TValue>.LessOrEqual.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityHeap<TValue>.LessOrEqual>.NativeClassPtr, 100665949);
				PriorityHeap<TValue>.LessOrEqual.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_TValue_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityHeap<TValue>.LessOrEqual>.NativeClassPtr, 100665950);
				PriorityHeap<TValue>.LessOrEqual.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TValue_TValue_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityHeap<TValue>.LessOrEqual>.NativeClassPtr, 100665951);
				PriorityHeap<TValue>.LessOrEqual.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityHeap<TValue>.LessOrEqual>.NativeClassPtr, 100665952);
			}

			// Token: 0x06002165 RID: 8549 RVA: 0x00081598 File Offset: 0x0007F798
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 622948, RefRangeEnd = 622956, XrefRangeStart = 622948, XrefRangeEnd = 622956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LessOrEqual(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PriorityHeap<TValue>.LessOrEqual>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityHeap<TValue>.LessOrEqual.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002166 RID: 8550 RVA: 0x000815F4 File Offset: 0x0007F7F4
			[CallerCount(0)]
			public unsafe bool Invoke(TValue lhs, TValue rhs)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TValue).IsValueType)
					{
						TValue tvalue = lhs;
						intPtr = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref lhs;
					}
					ptr2 = intPtr;
				}
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2;
				if (!typeof(TValue).IsValueType)
				{
					TValue tvalue2 = rhs;
					intPtr2 = ((tvalue2 is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue2 as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue2 as Il2CppObjectBase));
				}
				else
				{
					intPtr2 = ref rhs;
				}
				ptr3 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(PriorityHeap<TValue>.LessOrEqual.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_TValue_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}

			// Token: 0x06002167 RID: 8551 RVA: 0x000816C0 File Offset: 0x0007F8C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(TValue lhs, TValue rhs, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TValue).IsValueType)
					{
						TValue tvalue = lhs;
						intPtr = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref lhs;
					}
					ptr2 = intPtr;
				}
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2;
				if (!typeof(TValue).IsValueType)
				{
					TValue tvalue2 = rhs;
					intPtr2 = ((tvalue2 is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue2 as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue2 as Il2CppObjectBase));
				}
				else
				{
					intPtr2 = ref rhs;
				}
				ptr3 = intPtr2;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(PriorityHeap<TValue>.LessOrEqual.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TValue_TValue_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				IntPtr intPtr5 = intPtr3;
				return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
			}

			// Token: 0x06002168 RID: 8552 RVA: 0x000817B4 File Offset: 0x0007F9B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityHeap<TValue>.LessOrEqual.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002169 RID: 8553 RVA: 0x00013217 File Offset: 0x00011417
			public LessOrEqual(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600216A RID: 8554 RVA: 0x00013220 File Offset: 0x00011420
			public static implicit operator PriorityHeap<TValue>.LessOrEqual(Func<TValue, TValue, bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<PriorityHeap<TValue>.LessOrEqual>(A_0);
			}

			// Token: 0x0600216B RID: 8555 RVA: 0x00013228 File Offset: 0x00011428
			public static PriorityHeap<TValue>.LessOrEqual operator +(PriorityHeap<TValue>.LessOrEqual A_0, PriorityHeap<TValue>.LessOrEqual A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PriorityHeap<TValue>.LessOrEqual>();
			}

			// Token: 0x0600216C RID: 8556 RVA: 0x00013236 File Offset: 0x00011436
			public static PriorityHeap<TValue>.LessOrEqual operator -(PriorityHeap<TValue>.LessOrEqual A_0, PriorityHeap<TValue>.LessOrEqual A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PriorityHeap<TValue>.LessOrEqual>();
				}
				return delegate2;
			}

			// Token: 0x040017AE RID: 6062
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040017AF RID: 6063
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_TValue_TValue_0;

			// Token: 0x040017B0 RID: 6064
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TValue_TValue_AsyncCallback_Object_0;

			// Token: 0x040017B1 RID: 6065
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0;
		}

		// Token: 0x020001DF RID: 479
		public class HandleElem : Object
		{
			// Token: 0x0600216D RID: 8557 RVA: 0x00081804 File Offset: 0x0007FA04
			// Note: this type is marked as 'beforefieldinit'.
			static HandleElem()
			{
				Il2CppClassPointerStore<PriorityHeap<TValue>.HandleElem>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PriorityHeap<TValue>>.NativeClassPtr, "HandleElem"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PriorityHeap<TValue>.HandleElem>.NativeClassPtr);
				PriorityHeap<TValue>.HandleElem.NativeFieldInfoPtr__key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityHeap<TValue>.HandleElem>.NativeClassPtr, "_key");
				PriorityHeap<TValue>.HandleElem.NativeFieldInfoPtr__node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityHeap<TValue>.HandleElem>.NativeClassPtr, "_node");
				PriorityHeap<TValue>.HandleElem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityHeap<TValue>.HandleElem>.NativeClassPtr, 100665953);
			}

			// Token: 0x0600216E RID: 8558 RVA: 0x000818A8 File Offset: 0x0007FAA8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HandleElem()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PriorityHeap<TValue>.HandleElem>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityHeap<TValue>.HandleElem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600216F RID: 8559 RVA: 0x00013247 File Offset: 0x00011447
			public HandleElem(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C05 RID: 3077
			// (get) Token: 0x06002170 RID: 8560 RVA: 0x000818E4 File Offset: 0x0007FAE4
			// (set) Token: 0x06002171 RID: 8561 RVA: 0x0008190C File Offset: 0x0007FB0C
			public unsafe TValue _key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityHeap<TValue>.HandleElem.NativeFieldInfoPtr__key);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityHeap<TValue>.HandleElem.NativeFieldInfoPtr__key);
					Type typeFromHandle = typeof(TValue);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x17000C06 RID: 3078
			// (get) Token: 0x06002172 RID: 8562 RVA: 0x000819B4 File Offset: 0x0007FBB4
			// (set) Token: 0x06002173 RID: 8563 RVA: 0x00013250 File Offset: 0x00011450
			public unsafe int _node
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityHeap<TValue>.HandleElem.NativeFieldInfoPtr__node);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityHeap<TValue>.HandleElem.NativeFieldInfoPtr__node)) = value;
				}
			}

			// Token: 0x040017B2 RID: 6066
			private static readonly IntPtr NativeFieldInfoPtr__key;

			// Token: 0x040017B3 RID: 6067
			private static readonly IntPtr NativeFieldInfoPtr__node;

			// Token: 0x040017B4 RID: 6068
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
