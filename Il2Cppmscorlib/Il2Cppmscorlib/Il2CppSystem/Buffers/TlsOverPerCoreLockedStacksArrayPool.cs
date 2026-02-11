using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;

namespace Il2CppSystem.Buffers
{
	// Token: 0x02000516 RID: 1302
	public sealed class TlsOverPerCoreLockedStacksArrayPool<T> : ArrayPool<T>
	{
		// Token: 0x06004F9A RID: 20378 RVA: 0x00172898 File Offset: 0x00170A98
		// Note: this type is marked as 'beforefieldinit'.
		static TlsOverPerCoreLockedStacksArrayPool()
		{
			Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Buffers", "TlsOverPerCoreLockedStacksArrayPool`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr);
			TlsOverPerCoreLockedStacksArrayPool<T>.NativeFieldInfoPtr__bucketArraySizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, "_bucketArraySizes");
			TlsOverPerCoreLockedStacksArrayPool<T>.NativeFieldInfoPtr__buckets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, "_buckets");
			TlsOverPerCoreLockedStacksArrayPool<T>.NativeFieldInfoPtr_t_tlsBuckets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, "t_tlsBuckets");
			TlsOverPerCoreLockedStacksArrayPool<T>.NativeFieldInfoPtr__callbackCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, "_callbackCreated");
			TlsOverPerCoreLockedStacksArrayPool<T>.NativeFieldInfoPtr_s_trimBuffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, "s_trimBuffers");
			TlsOverPerCoreLockedStacksArrayPool<T>.NativeFieldInfoPtr_s_allTlsBuckets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, "s_allTlsBuckets");
			TlsOverPerCoreLockedStacksArrayPool<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, 100675302);
			TlsOverPerCoreLockedStacksArrayPool<T>.NativeMethodInfoPtr_CreatePerCoreLockedStacks_Private_PerCoreLockedStacks_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, 100675303);
			TlsOverPerCoreLockedStacksArrayPool<T>.NativeMethodInfoPtr_get_Id_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, 100675304);
			TlsOverPerCoreLockedStacksArrayPool<T>.NativeMethodInfoPtr_Rent_Public_Virtual_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, 100675305);
			TlsOverPerCoreLockedStacksArrayPool<T>.NativeMethodInfoPtr_Return_Public_Virtual_Void_Il2CppArrayBase_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, 100675306);
			TlsOverPerCoreLockedStacksArrayPool<T>.NativeMethodInfoPtr_Trim_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, 100675307);
			TlsOverPerCoreLockedStacksArrayPool<T>.NativeMethodInfoPtr_Gen2GcCallbackFunc_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, 100675308);
			TlsOverPerCoreLockedStacksArrayPool<T>.NativeMethodInfoPtr_GetMemoryPressure_Private_Static_MemoryPressure_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, 100675309);
			TlsOverPerCoreLockedStacksArrayPool<T>.NativeMethodInfoPtr_GetTrimBuffers_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, 100675310);
		}

		// Token: 0x06004F9B RID: 20379 RVA: 0x00172A30 File Offset: 0x00170C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426657, XrefRangeEnd = 1426670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TlsOverPerCoreLockedStacksArrayPool()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TlsOverPerCoreLockedStacksArrayPool<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F9C RID: 20380 RVA: 0x00172A6C File Offset: 0x00170C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426670, XrefRangeEnd = 1426674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks CreatePerCoreLockedStacks(int bucketIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bucketIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TlsOverPerCoreLockedStacksArrayPool<T>.NativeMethodInfoPtr_CreatePerCoreLockedStacks_Private_PerCoreLockedStacks_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks>(intPtr3) : null;
			}
		}

		// Token: 0x17001461 RID: 5217
		// (get) Token: 0x06004F9D RID: 20381 RVA: 0x00172AB8 File Offset: 0x00170CB8
		public unsafe int Id
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TlsOverPerCoreLockedStacksArrayPool<T>.NativeMethodInfoPtr_get_Id_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004F9E RID: 20382 RVA: 0x00172AF4 File Offset: 0x00170CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426674, XrefRangeEnd = 1426687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppArrayBase<T> Rent(int minimumLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minimumLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TlsOverPerCoreLockedStacksArrayPool<T>.NativeMethodInfoPtr_Rent_Public_Virtual_Il2CppArrayBase_1_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x06004F9F RID: 20383 RVA: 0x00172B38 File Offset: 0x00170D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426687, XrefRangeEnd = 1426706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Return(Il2CppArrayBase<T> array, bool clearArray = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearArray;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TlsOverPerCoreLockedStacksArrayPool<T>.NativeMethodInfoPtr_Return_Public_Virtual_Void_Il2CppArrayBase_1_T_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FA0 RID: 20384 RVA: 0x00172B88 File Offset: 0x00170D88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1426764, RefRangeEnd = 1426765, XrefRangeStart = 1426706, XrefRangeEnd = 1426764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Trim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TlsOverPerCoreLockedStacksArrayPool<T>.NativeMethodInfoPtr_Trim_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004FA1 RID: 20385 RVA: 0x00172BC4 File Offset: 0x00170DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426765, XrefRangeEnd = 1426796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Gen2GcCallbackFunc(Object target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TlsOverPerCoreLockedStacksArrayPool<T>.NativeMethodInfoPtr_Gen2GcCallbackFunc_Private_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004FA2 RID: 20386 RVA: 0x00172C08 File Offset: 0x00170E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426796, XrefRangeEnd = 1426800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TlsOverPerCoreLockedStacksArrayPool<T>.MemoryPressure GetMemoryPressure()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TlsOverPerCoreLockedStacksArrayPool<T>.NativeMethodInfoPtr_GetMemoryPressure_Private_Static_MemoryPressure_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004FA3 RID: 20387 RVA: 0x00172C38 File Offset: 0x00170E38
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetTrimBuffers()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TlsOverPerCoreLockedStacksArrayPool<T>.NativeMethodInfoPtr_GetTrimBuffers_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004FA4 RID: 20388 RVA: 0x0001C922 File Offset: 0x0001AB22
		public TlsOverPerCoreLockedStacksArrayPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700145B RID: 5211
		// (get) Token: 0x06004FA5 RID: 20389 RVA: 0x00172C68 File Offset: 0x00170E68
		// (set) Token: 0x06004FA6 RID: 20390 RVA: 0x0001C92B File Offset: 0x0001AB2B
		public unsafe Il2CppStructArray<int> _bucketArraySizes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TlsOverPerCoreLockedStacksArrayPool<T>.NativeFieldInfoPtr__bucketArraySizes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TlsOverPerCoreLockedStacksArrayPool<T>.NativeFieldInfoPtr__bucketArraySizes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700145C RID: 5212
		// (get) Token: 0x06004FA7 RID: 20391 RVA: 0x00172C98 File Offset: 0x00170E98
		// (set) Token: 0x06004FA8 RID: 20392 RVA: 0x0001C94A File Offset: 0x0001AB4A
		public unsafe Il2CppReferenceArray<TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks> _buckets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TlsOverPerCoreLockedStacksArrayPool<T>.NativeFieldInfoPtr__buckets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TlsOverPerCoreLockedStacksArrayPool<T>.NativeFieldInfoPtr__buckets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700145D RID: 5213
		// (get) Token: 0x06004FA9 RID: 20393 RVA: 0x00172CC8 File Offset: 0x00170EC8
		// (set) Token: 0x06004FAA RID: 20394 RVA: 0x0001C969 File Offset: 0x0001AB69
		public unsafe static Il2CppReferenceArray<Il2CppArrayBase<T>> t_tlsBuckets
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TlsOverPerCoreLockedStacksArrayPool<T>.NativeFieldInfoPtr_t_tlsBuckets, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppArrayBase<T>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TlsOverPerCoreLockedStacksArrayPool<T>.NativeFieldInfoPtr_t_tlsBuckets, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700145E RID: 5214
		// (get) Token: 0x06004FAB RID: 20395 RVA: 0x00172CF0 File Offset: 0x00170EF0
		// (set) Token: 0x06004FAC RID: 20396 RVA: 0x0001C97B File Offset: 0x0001AB7B
		public unsafe int _callbackCreated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TlsOverPerCoreLockedStacksArrayPool<T>.NativeFieldInfoPtr__callbackCreated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TlsOverPerCoreLockedStacksArrayPool<T>.NativeFieldInfoPtr__callbackCreated)) = value;
			}
		}

		// Token: 0x1700145F RID: 5215
		// (get) Token: 0x06004FAD RID: 20397 RVA: 0x00172D18 File Offset: 0x00170F18
		// (set) Token: 0x06004FAE RID: 20398 RVA: 0x0001C996 File Offset: 0x0001AB96
		public unsafe static bool s_trimBuffers
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TlsOverPerCoreLockedStacksArrayPool<T>.NativeFieldInfoPtr_s_trimBuffers, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TlsOverPerCoreLockedStacksArrayPool<T>.NativeFieldInfoPtr_s_trimBuffers, (void*)(&value));
			}
		}

		// Token: 0x17001460 RID: 5216
		// (get) Token: 0x06004FAF RID: 20399 RVA: 0x00172D34 File Offset: 0x00170F34
		// (set) Token: 0x06004FB0 RID: 20400 RVA: 0x0001C9A4 File Offset: 0x0001ABA4
		public unsafe static ConditionalWeakTable<Il2CppReferenceArray<Il2CppArrayBase<T>>, Object> s_allTlsBuckets
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TlsOverPerCoreLockedStacksArrayPool<T>.NativeFieldInfoPtr_s_allTlsBuckets, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConditionalWeakTable<Il2CppReferenceArray<Il2CppArrayBase<T>>, Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TlsOverPerCoreLockedStacksArrayPool<T>.NativeFieldInfoPtr_s_allTlsBuckets, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040040E1 RID: 16609
		private static readonly IntPtr NativeFieldInfoPtr__bucketArraySizes;

		// Token: 0x040040E2 RID: 16610
		private static readonly IntPtr NativeFieldInfoPtr__buckets;

		// Token: 0x040040E3 RID: 16611
		private static readonly IntPtr NativeFieldInfoPtr_t_tlsBuckets;

		// Token: 0x040040E4 RID: 16612
		private static readonly IntPtr NativeFieldInfoPtr__callbackCreated;

		// Token: 0x040040E5 RID: 16613
		private static readonly IntPtr NativeFieldInfoPtr_s_trimBuffers;

		// Token: 0x040040E6 RID: 16614
		private static readonly IntPtr NativeFieldInfoPtr_s_allTlsBuckets;

		// Token: 0x040040E7 RID: 16615
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040040E8 RID: 16616
		private static readonly IntPtr NativeMethodInfoPtr_CreatePerCoreLockedStacks_Private_PerCoreLockedStacks_T_Int32_0;

		// Token: 0x040040E9 RID: 16617
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Private_get_Int32_0;

		// Token: 0x040040EA RID: 16618
		private static readonly IntPtr NativeMethodInfoPtr_Rent_Public_Virtual_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x040040EB RID: 16619
		private static readonly IntPtr NativeMethodInfoPtr_Return_Public_Virtual_Void_Il2CppArrayBase_1_T_Boolean_0;

		// Token: 0x040040EC RID: 16620
		private static readonly IntPtr NativeMethodInfoPtr_Trim_Public_Boolean_0;

		// Token: 0x040040ED RID: 16621
		private static readonly IntPtr NativeMethodInfoPtr_Gen2GcCallbackFunc_Private_Static_Boolean_Object_0;

		// Token: 0x040040EE RID: 16622
		private static readonly IntPtr NativeMethodInfoPtr_GetMemoryPressure_Private_Static_MemoryPressure_T_0;

		// Token: 0x040040EF RID: 16623
		private static readonly IntPtr NativeMethodInfoPtr_GetTrimBuffers_Private_Static_Boolean_0;

		// Token: 0x02000711 RID: 1809
		public enum MemoryPressure
		{
			// Token: 0x04004E03 RID: 19971
			Low,
			// Token: 0x04004E04 RID: 19972
			Medium,
			// Token: 0x04004E05 RID: 19973
			High
		}

		// Token: 0x02000712 RID: 1810
		public sealed class PerCoreLockedStacks : Object
		{
			// Token: 0x06006007 RID: 24583 RVA: 0x001B1860 File Offset: 0x001AFA60
			// Note: this type is marked as 'beforefieldinit'.
			static PerCoreLockedStacks()
			{
				Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, "PerCoreLockedStacks"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks>.NativeClassPtr);
				TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks.NativeFieldInfoPtr__perCoreStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks>.NativeClassPtr, "_perCoreStacks");
				TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks>.NativeClassPtr, 100675312);
				TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks.NativeMethodInfoPtr_TryPush_Public_Void_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks>.NativeClassPtr, 100675313);
				TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks.NativeMethodInfoPtr_TryPop_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks>.NativeClassPtr, 100675314);
				TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks.NativeMethodInfoPtr_Trim_Public_Boolean_UInt32_Int32_MemoryPressure_T_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks>.NativeClassPtr, 100675315);
			}

			// Token: 0x06006008 RID: 24584 RVA: 0x001B192C File Offset: 0x001AFB2C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1426590, RefRangeEnd = 1426592, XrefRangeStart = 1426542, XrefRangeEnd = 1426590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PerCoreLockedStacks()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006009 RID: 24585 RVA: 0x001B1968 File Offset: 0x001AFB68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426592, XrefRangeEnd = 1426598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void TryPush(Il2CppArrayBase<T> array)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks.NativeMethodInfoPtr_TryPush_Public_Void_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600600A RID: 24586 RVA: 0x001B19AC File Offset: 0x001AFBAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426598, XrefRangeEnd = 1426605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppArrayBase<T> TryPop()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks.NativeMethodInfoPtr_TryPop_Public_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}

			// Token: 0x0600600B RID: 24587 RVA: 0x001B19E4 File Offset: 0x001AFBE4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1426607, RefRangeEnd = 1426608, XrefRangeStart = 1426605, XrefRangeEnd = 1426607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Trim(uint tickCount, int id, TlsOverPerCoreLockedStacksArrayPool<T>.MemoryPressure pressure, Il2CppStructArray<int> bucketSizes)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref tickCount;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pressure;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bucketSizes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks.NativeMethodInfoPtr_Trim_Public_Boolean_UInt32_Int32_MemoryPressure_T_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600600C RID: 24588 RVA: 0x00023175 File Offset: 0x00021375
			public PerCoreLockedStacks(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018D6 RID: 6358
			// (get) Token: 0x0600600D RID: 24589 RVA: 0x001B1A5C File Offset: 0x001AFC5C
			// (set) Token: 0x0600600E RID: 24590 RVA: 0x0002317E File Offset: 0x0002137E
			public unsafe Il2CppReferenceArray<TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack> _perCoreStacks
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks.NativeFieldInfoPtr__perCoreStacks);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks.NativeFieldInfoPtr__perCoreStacks), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004E06 RID: 19974
			private static readonly IntPtr NativeFieldInfoPtr__perCoreStacks;

			// Token: 0x04004E07 RID: 19975
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004E08 RID: 19976
			private static readonly IntPtr NativeMethodInfoPtr_TryPush_Public_Void_Il2CppArrayBase_1_T_0;

			// Token: 0x04004E09 RID: 19977
			private static readonly IntPtr NativeMethodInfoPtr_TryPop_Public_Il2CppArrayBase_1_T_0;

			// Token: 0x04004E0A RID: 19978
			private static readonly IntPtr NativeMethodInfoPtr_Trim_Public_Boolean_UInt32_Int32_MemoryPressure_T_Il2CppStructArray_1_Int32_0;
		}

		// Token: 0x02000713 RID: 1811
		public sealed class LockedStack : Object
		{
			// Token: 0x0600600F RID: 24591 RVA: 0x001B1A8C File Offset: 0x001AFC8C
			// Note: this type is marked as 'beforefieldinit'.
			static LockedStack()
			{
				Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, "LockedStack"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack>.NativeClassPtr);
				TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack.NativeFieldInfoPtr__arrays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack>.NativeClassPtr, "_arrays");
				TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack>.NativeClassPtr, "_count");
				TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack.NativeFieldInfoPtr__firstStackItemMS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack>.NativeClassPtr, "_firstStackItemMS");
				TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack.NativeMethodInfoPtr_TryPush_Public_Boolean_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack>.NativeClassPtr, 100675316);
				TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack.NativeMethodInfoPtr_TryPop_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack>.NativeClassPtr, 100675317);
				TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack.NativeMethodInfoPtr_Trim_Public_Void_UInt32_Int32_MemoryPressure_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack>.NativeClassPtr, 100675318);
				TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack>.NativeClassPtr, 100675319);
			}

			// Token: 0x06006010 RID: 24592 RVA: 0x001B1B80 File Offset: 0x001AFD80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426608, XrefRangeEnd = 1426615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TryPush(Il2CppArrayBase<T> array)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack.NativeMethodInfoPtr_TryPush_Public_Boolean_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006011 RID: 24593 RVA: 0x001B1BD0 File Offset: 0x001AFDD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426615, XrefRangeEnd = 1426618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppArrayBase<T> TryPop()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack.NativeMethodInfoPtr_TryPop_Public_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}

			// Token: 0x06006012 RID: 24594 RVA: 0x001B1C08 File Offset: 0x001AFE08
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1426631, RefRangeEnd = 1426632, XrefRangeStart = 1426618, XrefRangeEnd = 1426631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Trim(uint tickCount, int id, TlsOverPerCoreLockedStacksArrayPool<T>.MemoryPressure pressure, int bucketSize)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref tickCount;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pressure;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bucketSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack.NativeMethodInfoPtr_Trim_Public_Void_UInt32_Int32_MemoryPressure_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006013 RID: 24595 RVA: 0x001B1C70 File Offset: 0x001AFE70
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1426654, RefRangeEnd = 1426657, XrefRangeStart = 1426632, XrefRangeEnd = 1426654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LockedStack()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006014 RID: 24596 RVA: 0x0002319D File Offset: 0x0002139D
			public LockedStack(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018D7 RID: 6359
			// (get) Token: 0x06006015 RID: 24597 RVA: 0x001B1CAC File Offset: 0x001AFEAC
			// (set) Token: 0x06006016 RID: 24598 RVA: 0x000231A6 File Offset: 0x000213A6
			public unsafe Il2CppReferenceArray<Il2CppArrayBase<T>> _arrays
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack.NativeFieldInfoPtr__arrays);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppArrayBase<T>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack.NativeFieldInfoPtr__arrays), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018D8 RID: 6360
			// (get) Token: 0x06006017 RID: 24599 RVA: 0x001B1CDC File Offset: 0x001AFEDC
			// (set) Token: 0x06006018 RID: 24600 RVA: 0x000231C5 File Offset: 0x000213C5
			public unsafe int _count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack.NativeFieldInfoPtr__count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack.NativeFieldInfoPtr__count)) = value;
				}
			}

			// Token: 0x170018D9 RID: 6361
			// (get) Token: 0x06006019 RID: 24601 RVA: 0x001B1D04 File Offset: 0x001AFF04
			// (set) Token: 0x0600601A RID: 24602 RVA: 0x000231E0 File Offset: 0x000213E0
			public unsafe uint _firstStackItemMS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack.NativeFieldInfoPtr__firstStackItemMS);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack.NativeFieldInfoPtr__firstStackItemMS)) = value;
				}
			}

			// Token: 0x04004E0B RID: 19979
			private static readonly IntPtr NativeFieldInfoPtr__arrays;

			// Token: 0x04004E0C RID: 19980
			private static readonly IntPtr NativeFieldInfoPtr__count;

			// Token: 0x04004E0D RID: 19981
			private static readonly IntPtr NativeFieldInfoPtr__firstStackItemMS;

			// Token: 0x04004E0E RID: 19982
			private static readonly IntPtr NativeMethodInfoPtr_TryPush_Public_Boolean_Il2CppArrayBase_1_T_0;

			// Token: 0x04004E0F RID: 19983
			private static readonly IntPtr NativeMethodInfoPtr_TryPop_Public_Il2CppArrayBase_1_T_0;

			// Token: 0x04004E10 RID: 19984
			private static readonly IntPtr NativeMethodInfoPtr_Trim_Public_Void_UInt32_Int32_MemoryPressure_T_Int32_0;

			// Token: 0x04004E11 RID: 19985
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
