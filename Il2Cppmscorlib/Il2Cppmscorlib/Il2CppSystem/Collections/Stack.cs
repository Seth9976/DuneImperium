using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections
{
	// Token: 0x020004CC RID: 1228
	[Serializable]
	public class Stack : Object
	{
		// Token: 0x06004B43 RID: 19267 RVA: 0x0015BC18 File Offset: 0x00159E18
		// Note: this type is marked as 'beforefieldinit'.
		static Stack()
		{
			Il2CppClassPointerStore<Stack>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "Stack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stack>.NativeClassPtr);
			Stack.NativeFieldInfoPtr__array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack>.NativeClassPtr, "_array");
			Stack.NativeFieldInfoPtr__size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack>.NativeClassPtr, "_size");
			Stack.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack>.NativeClassPtr, "_version");
			Stack.NativeFieldInfoPtr__syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack>.NativeClassPtr, "_syncRoot");
			Stack.NativeFieldInfoPtr__defaultCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack>.NativeClassPtr, "_defaultCapacity");
			Stack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack>.NativeClassPtr, 100674341);
			Stack.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack>.NativeClassPtr, 100674342);
			Stack.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack>.NativeClassPtr, 100674343);
			Stack.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack>.NativeClassPtr, 100674344);
			Stack.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack>.NativeClassPtr, 100674345);
			Stack.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack>.NativeClassPtr, 100674346);
			Stack.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack>.NativeClassPtr, 100674347);
			Stack.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack>.NativeClassPtr, 100674348);
			Stack.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack>.NativeClassPtr, 100674349);
			Stack.NativeMethodInfoPtr_Peek_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack>.NativeClassPtr, 100674350);
			Stack.NativeMethodInfoPtr_Pop_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack>.NativeClassPtr, 100674351);
			Stack.NativeMethodInfoPtr_Push_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack>.NativeClassPtr, 100674352);
		}

		// Token: 0x06004B44 RID: 19268 RVA: 0x0015BD9C File Offset: 0x00159F9C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1415672, RefRangeEnd = 1415688, XrefRangeStart = 1415667, XrefRangeEnd = 1415672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stack()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B45 RID: 19269 RVA: 0x0015BDD8 File Offset: 0x00159FD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1415693, RefRangeEnd = 1415695, XrefRangeStart = 1415688, XrefRangeEnd = 1415693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stack(int initialCapacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stack>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialCapacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001352 RID: 4946
		// (get) Token: 0x06004B46 RID: 19270 RVA: 0x0015BE20 File Offset: 0x0015A020
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stack.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001353 RID: 4947
		// (get) Token: 0x06004B47 RID: 19271 RVA: 0x0015BE68 File Offset: 0x0015A068
		public unsafe virtual bool IsSynchronized
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stack.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001354 RID: 4948
		// (get) Token: 0x06004B48 RID: 19272 RVA: 0x0015BEB0 File Offset: 0x0015A0B0
		public unsafe virtual Object SyncRoot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415695, XrefRangeEnd = 1415700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stack.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004B49 RID: 19273 RVA: 0x0015BEFC File Offset: 0x0015A0FC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1415701, RefRangeEnd = 1415715, XrefRangeStart = 1415700, XrefRangeEnd = 1415701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stack.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B4A RID: 19274 RVA: 0x0015BF38 File Offset: 0x0015A138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415715, XrefRangeEnd = 1415724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stack.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06004B4B RID: 19275 RVA: 0x0015BF84 File Offset: 0x0015A184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415724, XrefRangeEnd = 1415730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Array array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stack.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B4C RID: 19276 RVA: 0x0015BFE0 File Offset: 0x0015A1E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415730, XrefRangeEnd = 1415736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stack.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004B4D RID: 19277 RVA: 0x0015C02C File Offset: 0x0015A22C
		[CallerCount(0)]
		public unsafe virtual Object Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stack.NativeMethodInfoPtr_Peek_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06004B4E RID: 19278 RVA: 0x0015C078 File Offset: 0x0015A278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415736, XrefRangeEnd = 1415737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stack.NativeMethodInfoPtr_Pop_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06004B4F RID: 19279 RVA: 0x0015C0C4 File Offset: 0x0015A2C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415737, XrefRangeEnd = 1415744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Push(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stack.NativeMethodInfoPtr_Push_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B50 RID: 19280 RVA: 0x0001B879 File Offset: 0x00019A79
		public Stack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700134D RID: 4941
		// (get) Token: 0x06004B51 RID: 19281 RVA: 0x0015C114 File Offset: 0x0015A314
		// (set) Token: 0x06004B52 RID: 19282 RVA: 0x0001B882 File Offset: 0x00019A82
		public unsafe Il2CppReferenceArray<Object> _array
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.NativeFieldInfoPtr__array);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.NativeFieldInfoPtr__array), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700134E RID: 4942
		// (get) Token: 0x06004B53 RID: 19283 RVA: 0x0015C144 File Offset: 0x0015A344
		// (set) Token: 0x06004B54 RID: 19284 RVA: 0x0001B8A1 File Offset: 0x00019AA1
		public unsafe int _size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.NativeFieldInfoPtr__size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.NativeFieldInfoPtr__size)) = value;
			}
		}

		// Token: 0x1700134F RID: 4943
		// (get) Token: 0x06004B55 RID: 19285 RVA: 0x0015C16C File Offset: 0x0015A36C
		// (set) Token: 0x06004B56 RID: 19286 RVA: 0x0001B8BC File Offset: 0x00019ABC
		public unsafe int _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.NativeFieldInfoPtr__version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.NativeFieldInfoPtr__version)) = value;
			}
		}

		// Token: 0x17001350 RID: 4944
		// (get) Token: 0x06004B57 RID: 19287 RVA: 0x0015C194 File Offset: 0x0015A394
		// (set) Token: 0x06004B58 RID: 19288 RVA: 0x0001B8D7 File Offset: 0x00019AD7
		public unsafe Object _syncRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.NativeFieldInfoPtr__syncRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.NativeFieldInfoPtr__syncRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001351 RID: 4945
		// (get) Token: 0x06004B59 RID: 19289 RVA: 0x0015C1C4 File Offset: 0x0015A3C4
		// (set) Token: 0x06004B5A RID: 19290 RVA: 0x0001B8F6 File Offset: 0x00019AF6
		public unsafe static int _defaultCapacity
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Stack.NativeFieldInfoPtr__defaultCapacity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Stack.NativeFieldInfoPtr__defaultCapacity, (void*)(&value));
			}
		}

		// Token: 0x04003D9D RID: 15773
		private static readonly IntPtr NativeFieldInfoPtr__array;

		// Token: 0x04003D9E RID: 15774
		private static readonly IntPtr NativeFieldInfoPtr__size;

		// Token: 0x04003D9F RID: 15775
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x04003DA0 RID: 15776
		private static readonly IntPtr NativeFieldInfoPtr__syncRoot;

		// Token: 0x04003DA1 RID: 15777
		private static readonly IntPtr NativeFieldInfoPtr__defaultCapacity;

		// Token: 0x04003DA2 RID: 15778
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003DA3 RID: 15779
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04003DA4 RID: 15780
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;

		// Token: 0x04003DA5 RID: 15781
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04003DA6 RID: 15782
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0;

		// Token: 0x04003DA7 RID: 15783
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0;

		// Token: 0x04003DA8 RID: 15784
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0;

		// Token: 0x04003DA9 RID: 15785
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0;

		// Token: 0x04003DAA RID: 15786
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0;

		// Token: 0x04003DAB RID: 15787
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Virtual_New_Object_0;

		// Token: 0x04003DAC RID: 15788
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Public_Virtual_New_Object_0;

		// Token: 0x04003DAD RID: 15789
		private static readonly IntPtr NativeMethodInfoPtr_Push_Public_Virtual_New_Void_Object_0;

		// Token: 0x020006EA RID: 1770
		[Serializable]
		public class StackEnumerator : Object
		{
			// Token: 0x06005E04 RID: 24068 RVA: 0x001A912C File Offset: 0x001A732C
			// Note: this type is marked as 'beforefieldinit'.
			static StackEnumerator()
			{
				Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stack>.NativeClassPtr, "StackEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr);
				Stack.StackEnumerator.NativeFieldInfoPtr__stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr, "_stack");
				Stack.StackEnumerator.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr, "_index");
				Stack.StackEnumerator.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr, "_version");
				Stack.StackEnumerator.NativeFieldInfoPtr__currentElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr, "_currentElement");
				Stack.StackEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_Stack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr, 100674353);
				Stack.StackEnumerator.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr, 100674354);
				Stack.StackEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr, 100674355);
				Stack.StackEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr, 100674356);
				Stack.StackEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr, 100674357);
			}

			// Token: 0x06005E05 RID: 24069 RVA: 0x001A920C File Offset: 0x001A740C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415654, XrefRangeEnd = 1415658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StackEnumerator(Stack stack)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stack);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack.StackEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_Stack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005E06 RID: 24070 RVA: 0x001A9258 File Offset: 0x001A7458
			[CallerCount(105)]
			[CachedScanResults(RefRangeStart = 1172447, RefRangeEnd = 1172552, XrefRangeStart = 1172447, XrefRangeEnd = 1172552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Object Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack.StackEnumerator.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x06005E07 RID: 24071 RVA: 0x001A9298 File Offset: 0x001A7498
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415658, XrefRangeEnd = 1415659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stack.StackEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700182A RID: 6186
			// (get) Token: 0x06005E08 RID: 24072 RVA: 0x001A92E0 File Offset: 0x001A74E0
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stack.StackEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005E09 RID: 24073 RVA: 0x001A932C File Offset: 0x001A752C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415659, XrefRangeEnd = 1415667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stack.StackEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005E0A RID: 24074 RVA: 0x00022589 File Offset: 0x00020789
			public StackEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001826 RID: 6182
			// (get) Token: 0x06005E0B RID: 24075 RVA: 0x001A9368 File Offset: 0x001A7568
			// (set) Token: 0x06005E0C RID: 24076 RVA: 0x00022592 File Offset: 0x00020792
			public unsafe Stack _stack
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.StackEnumerator.NativeFieldInfoPtr__stack);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.StackEnumerator.NativeFieldInfoPtr__stack), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001827 RID: 6183
			// (get) Token: 0x06005E0D RID: 24077 RVA: 0x001A9398 File Offset: 0x001A7598
			// (set) Token: 0x06005E0E RID: 24078 RVA: 0x000225B1 File Offset: 0x000207B1
			public unsafe int _index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.StackEnumerator.NativeFieldInfoPtr__index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.StackEnumerator.NativeFieldInfoPtr__index)) = value;
				}
			}

			// Token: 0x17001828 RID: 6184
			// (get) Token: 0x06005E0F RID: 24079 RVA: 0x001A93C0 File Offset: 0x001A75C0
			// (set) Token: 0x06005E10 RID: 24080 RVA: 0x000225CC File Offset: 0x000207CC
			public unsafe int _version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.StackEnumerator.NativeFieldInfoPtr__version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.StackEnumerator.NativeFieldInfoPtr__version)) = value;
				}
			}

			// Token: 0x17001829 RID: 6185
			// (get) Token: 0x06005E11 RID: 24081 RVA: 0x001A93E8 File Offset: 0x001A75E8
			// (set) Token: 0x06005E12 RID: 24082 RVA: 0x000225E7 File Offset: 0x000207E7
			public unsafe Object _currentElement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.StackEnumerator.NativeFieldInfoPtr__currentElement);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.StackEnumerator.NativeFieldInfoPtr__currentElement), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004CA5 RID: 19621
			private static readonly IntPtr NativeFieldInfoPtr__stack;

			// Token: 0x04004CA6 RID: 19622
			private static readonly IntPtr NativeFieldInfoPtr__index;

			// Token: 0x04004CA7 RID: 19623
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x04004CA8 RID: 19624
			private static readonly IntPtr NativeFieldInfoPtr__currentElement;

			// Token: 0x04004CA9 RID: 19625
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Stack_0;

			// Token: 0x04004CAA RID: 19626
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

			// Token: 0x04004CAB RID: 19627
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_New_Boolean_0;

			// Token: 0x04004CAC RID: 19628
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_New_get_Object_0;

			// Token: 0x04004CAD RID: 19629
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0;
		}

		// Token: 0x020006EB RID: 1771
		public class StackDebugView : Object
		{
			// Token: 0x06005E13 RID: 24083 RVA: 0x00022606 File Offset: 0x00020806
			// Note: this type is marked as 'beforefieldinit'.
			static StackDebugView()
			{
				Il2CppClassPointerStore<Stack.StackDebugView>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stack>.NativeClassPtr, "StackDebugView");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stack.StackDebugView>.NativeClassPtr);
			}

			// Token: 0x06005E14 RID: 24084 RVA: 0x00022626 File Offset: 0x00020826
			public StackDebugView(IntPtr pointer)
				: base(pointer)
			{
			}
		}
	}
}
