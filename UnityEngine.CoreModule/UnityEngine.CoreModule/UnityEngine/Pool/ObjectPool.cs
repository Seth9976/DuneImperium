using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Pool
{
	// Token: 0x020001D4 RID: 468
	public class ObjectPool<T> : Object where T : class
	{
		// Token: 0x06002113 RID: 8467 RVA: 0x00091DFC File Offset: 0x0008FFFC
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectPool()
		{
			Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Pool", "ObjectPool`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr);
			ObjectPool<T>.NativeFieldInfoPtr_m_List = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, "m_List");
			ObjectPool<T>.NativeFieldInfoPtr_m_CreateFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, "m_CreateFunc");
			ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnGet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, "m_ActionOnGet");
			ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnRelease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, "m_ActionOnRelease");
			ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, "m_ActionOnDestroy");
			ObjectPool<T>.NativeFieldInfoPtr_m_MaxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, "m_MaxSize");
			ObjectPool<T>.NativeFieldInfoPtr_m_CollectionCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, "m_CollectionCheck");
			ObjectPool<T>.NativeFieldInfoPtr__CountAll_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, "<CountAll>k__BackingField");
			ObjectPool<T>.NativeMethodInfoPtr_get_CountAll_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100667762);
			ObjectPool<T>.NativeMethodInfoPtr_set_CountAll_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100667763);
			ObjectPool<T>.NativeMethodInfoPtr_get_CountInactive_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100667764);
			ObjectPool<T>.NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_Action_1_T_Action_1_T_Action_1_T_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100667765);
			ObjectPool<T>.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100667766);
			ObjectPool<T>.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_PooledObject_1_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100667767);
			ObjectPool<T>.NativeMethodInfoPtr_Release_Public_Virtual_Final_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100667768);
			ObjectPool<T>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100667769);
			ObjectPool<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100667770);
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06002114 RID: 8468 RVA: 0x00091FBC File Offset: 0x000901BC
		// (set) Token: 0x06002115 RID: 8469 RVA: 0x00091FF8 File Offset: 0x000901F8
		public unsafe int CountAll
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_get_CountAll_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_set_CountAll_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06002116 RID: 8470 RVA: 0x00092038 File Offset: 0x00090238
		public unsafe virtual int CountInactive
		{
			[CallerCount(39)]
			[CachedScanResults(RefRangeStart = 320461, RefRangeEnd = 320500, XrefRangeStart = 320461, XrefRangeEnd = 320500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_get_CountInactive_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x00092074 File Offset: 0x00090274
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 680708, RefRangeEnd = 680726, XrefRangeStart = 680684, XrefRangeEnd = 680708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectPool(Func<T> createFunc, Action<T> actionOnGet = null, Action<T> actionOnRelease = null, Action<T> actionOnDestroy = null, bool collectionCheck = true, int defaultCapacity = 10, int maxSize = 10000)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(createFunc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actionOnGet);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actionOnRelease);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actionOnDestroy);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref collectionCheck;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultCapacity;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_Action_1_T_Action_1_T_Action_1_T_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002118 RID: 8472 RVA: 0x00092120 File Offset: 0x00090320
		[CallerCount(51)]
		[CachedScanResults(RefRangeStart = 680729, RefRangeEnd = 680780, XrefRangeStart = 680726, XrefRangeEnd = 680729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x0009215C File Offset: 0x0009035C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 680785, RefRangeEnd = 680792, XrefRangeStart = 680780, XrefRangeEnd = 680785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PooledObject<T> Get(out T v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					intPtr = 0;
					intPtr2 = &intPtr;
				}
				else
				{
					intPtr2 = ref v;
				}
				ptr2 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_PooledObject_1_T_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					v = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return new PooledObject<T>(intPtr3);
			}
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x000921E4 File Offset: 0x000903E4
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 680792, RefRangeEnd = 680832, XrefRangeStart = 680792, XrefRangeEnd = 680792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Release(T element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = element;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref element;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_Release_Public_Virtual_Final_New_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x0009225C File Offset: 0x0009045C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 680839, RefRangeEnd = 680841, XrefRangeStart = 680832, XrefRangeEnd = 680839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x00092290 File Offset: 0x00090490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680841, XrefRangeEnd = 680842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x0000CA34 File Offset: 0x0000AC34
		public ObjectPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x0600211E RID: 8478 RVA: 0x000922C4 File Offset: 0x000904C4
		// (set) Token: 0x0600211F RID: 8479 RVA: 0x0000CA3D File Offset: 0x0000AC3D
		public unsafe List<T> m_List
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_List);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_List), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06002120 RID: 8480 RVA: 0x000922F4 File Offset: 0x000904F4
		// (set) Token: 0x06002121 RID: 8481 RVA: 0x0000CA5C File Offset: 0x0000AC5C
		public unsafe Func<T> m_CreateFunc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_CreateFunc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_CreateFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06002122 RID: 8482 RVA: 0x00092324 File Offset: 0x00090524
		// (set) Token: 0x06002123 RID: 8483 RVA: 0x0000CA7B File Offset: 0x0000AC7B
		public unsafe Action<T> m_ActionOnGet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnGet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnGet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06002124 RID: 8484 RVA: 0x00092354 File Offset: 0x00090554
		// (set) Token: 0x06002125 RID: 8485 RVA: 0x0000CA9A File Offset: 0x0000AC9A
		public unsafe Action<T> m_ActionOnRelease
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnRelease);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnRelease), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06002126 RID: 8486 RVA: 0x00092384 File Offset: 0x00090584
		// (set) Token: 0x06002127 RID: 8487 RVA: 0x0000CAB9 File Offset: 0x0000ACB9
		public unsafe Action<T> m_ActionOnDestroy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnDestroy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnDestroy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06002128 RID: 8488 RVA: 0x000923B4 File Offset: 0x000905B4
		// (set) Token: 0x06002129 RID: 8489 RVA: 0x0000CAD8 File Offset: 0x0000ACD8
		public unsafe int m_MaxSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_MaxSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_MaxSize)) = value;
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x0600212A RID: 8490 RVA: 0x000923DC File Offset: 0x000905DC
		// (set) Token: 0x0600212B RID: 8491 RVA: 0x0000CAF3 File Offset: 0x0000ACF3
		public unsafe bool m_CollectionCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_CollectionCheck);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_CollectionCheck)) = value;
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x0600212C RID: 8492 RVA: 0x00092404 File Offset: 0x00090604
		// (set) Token: 0x0600212D RID: 8493 RVA: 0x0000CB0E File Offset: 0x0000AD0E
		public unsafe int _CountAll_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr__CountAll_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr__CountAll_k__BackingField)) = value;
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x0600212E RID: 8494 RVA: 0x0009242C File Offset: 0x0009062C
		public int CountActive
		{
			get
			{
				return this.CountAll - this.CountInactive;
			}
		}

		// Token: 0x04001C41 RID: 7233
		private static readonly IntPtr NativeFieldInfoPtr_m_List;

		// Token: 0x04001C42 RID: 7234
		private static readonly IntPtr NativeFieldInfoPtr_m_CreateFunc;

		// Token: 0x04001C43 RID: 7235
		private static readonly IntPtr NativeFieldInfoPtr_m_ActionOnGet;

		// Token: 0x04001C44 RID: 7236
		private static readonly IntPtr NativeFieldInfoPtr_m_ActionOnRelease;

		// Token: 0x04001C45 RID: 7237
		private static readonly IntPtr NativeFieldInfoPtr_m_ActionOnDestroy;

		// Token: 0x04001C46 RID: 7238
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxSize;

		// Token: 0x04001C47 RID: 7239
		private static readonly IntPtr NativeFieldInfoPtr_m_CollectionCheck;

		// Token: 0x04001C48 RID: 7240
		private static readonly IntPtr NativeFieldInfoPtr__CountAll_k__BackingField;

		// Token: 0x04001C49 RID: 7241
		private static readonly IntPtr NativeMethodInfoPtr_get_CountAll_Public_get_Int32_0;

		// Token: 0x04001C4A RID: 7242
		private static readonly IntPtr NativeMethodInfoPtr_set_CountAll_Private_set_Void_Int32_0;

		// Token: 0x04001C4B RID: 7243
		private static readonly IntPtr NativeMethodInfoPtr_get_CountInactive_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001C4C RID: 7244
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_Action_1_T_Action_1_T_Action_1_T_Boolean_Int32_Int32_0;

		// Token: 0x04001C4D RID: 7245
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_T_0;

		// Token: 0x04001C4E RID: 7246
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_PooledObject_1_T_byref_T_0;

		// Token: 0x04001C4F RID: 7247
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_Final_New_Void_T_0;

		// Token: 0x04001C50 RID: 7248
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001C51 RID: 7249
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}
