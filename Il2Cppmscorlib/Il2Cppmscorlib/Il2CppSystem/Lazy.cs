using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;

namespace Il2CppSystem
{
	// Token: 0x020000BD RID: 189
	[Serializable]
	public class Lazy<T> : Object
	{
		// Token: 0x06000C54 RID: 3156 RVA: 0x0005EBB8 File Offset: 0x0005CDB8
		// Note: this type is marked as 'beforefieldinit'.
		static Lazy()
		{
			Il2CppClassPointerStore<Lazy<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Lazy`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lazy<T>>.NativeClassPtr);
			Lazy<T>.NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lazy<T>>.NativeClassPtr, "_state");
			Lazy<T>.NativeFieldInfoPtr__factory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lazy<T>>.NativeClassPtr, "_factory");
			Lazy<T>.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lazy<T>>.NativeClassPtr, "_value");
			Lazy<T>.NativeMethodInfoPtr_CreateViaDefaultConstructor_Private_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lazy<T>>.NativeClassPtr, 100665445);
			Lazy<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lazy<T>>.NativeClassPtr, 100665446);
			Lazy<T>.NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lazy<T>>.NativeClassPtr, 100665447);
			Lazy<T>.NativeMethodInfoPtr__ctor_Private_Void_Func_1_T_LazyThreadSafetyMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lazy<T>>.NativeClassPtr, 100665448);
			Lazy<T>.NativeMethodInfoPtr_ViaConstructor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lazy<T>>.NativeClassPtr, 100665449);
			Lazy<T>.NativeMethodInfoPtr_ViaFactory_Private_Void_LazyThreadSafetyMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lazy<T>>.NativeClassPtr, 100665450);
			Lazy<T>.NativeMethodInfoPtr_ExecutionAndPublication_Private_Void_LazyHelper_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lazy<T>>.NativeClassPtr, 100665451);
			Lazy<T>.NativeMethodInfoPtr_PublicationOnly_Private_Void_LazyHelper_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lazy<T>>.NativeClassPtr, 100665452);
			Lazy<T>.NativeMethodInfoPtr_PublicationOnlyViaConstructor_Private_Void_LazyHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lazy<T>>.NativeClassPtr, 100665453);
			Lazy<T>.NativeMethodInfoPtr_PublicationOnlyViaFactory_Private_Void_LazyHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lazy<T>>.NativeClassPtr, 100665454);
			Lazy<T>.NativeMethodInfoPtr_PublicationOnlyWaitForOtherThreadToPublish_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lazy<T>>.NativeClassPtr, 100665455);
			Lazy<T>.NativeMethodInfoPtr_CreateValue_Private_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lazy<T>>.NativeClassPtr, 100665456);
			Lazy<T>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lazy<T>>.NativeClassPtr, 100665457);
			Lazy<T>.NativeMethodInfoPtr_get_IsValueCreated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lazy<T>>.NativeClassPtr, 100665458);
			Lazy<T>.NativeMethodInfoPtr_get_Value_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lazy<T>>.NativeClassPtr, 100665459);
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x0005ED8C File Offset: 0x0005CF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310000, XrefRangeEnd = 1310012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T CreateViaDefaultConstructor()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lazy<T>.NativeMethodInfoPtr_CreateViaDefaultConstructor_Private_Static_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x0005EDBC File Offset: 0x0005CFBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310012, XrefRangeEnd = 1310046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Lazy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lazy<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lazy<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x0005EDF8 File Offset: 0x0005CFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310046, XrefRangeEnd = 1310059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Lazy(Func<T> valueFactory)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lazy<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(valueFactory);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lazy<T>.NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x0005EE44 File Offset: 0x0005D044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310059, XrefRangeEnd = 1310072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Lazy(Func<T> valueFactory, LazyThreadSafetyMode mode, bool useDefaultConstructor)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lazy<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(valueFactory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useDefaultConstructor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lazy<T>.NativeMethodInfoPtr__ctor_Private_Void_Func_1_T_LazyThreadSafetyMode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x0005EEAC File Offset: 0x0005D0AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310072, XrefRangeEnd = 1310085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ViaConstructor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lazy<T>.NativeMethodInfoPtr_ViaConstructor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x0005EEE0 File Offset: 0x0005D0E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1310088, RefRangeEnd = 1310090, XrefRangeStart = 1310085, XrefRangeEnd = 1310088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ViaFactory(LazyThreadSafetyMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lazy<T>.NativeMethodInfoPtr_ViaFactory_Private_Void_LazyThreadSafetyMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x0005EF20 File Offset: 0x0005D120
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1310102, RefRangeEnd = 1310104, XrefRangeStart = 1310090, XrefRangeEnd = 1310102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecutionAndPublication(LazyHelper executionAndPublication, bool useDefaultConstructor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionAndPublication);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useDefaultConstructor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lazy<T>.NativeMethodInfoPtr_ExecutionAndPublication_Private_Void_LazyHelper_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x0005EF70 File Offset: 0x0005D170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310104, XrefRangeEnd = 1310113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PublicationOnly(LazyHelper publicationOnly, T possibleValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(publicationOnly);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = possibleValue;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref possibleValue;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Lazy<T>.NativeMethodInfoPtr_PublicationOnly_Private_Void_LazyHelper_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x0005EFFC File Offset: 0x0005D1FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310113, XrefRangeEnd = 1310117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PublicationOnlyViaConstructor(LazyHelper initializer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(initializer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lazy<T>.NativeMethodInfoPtr_PublicationOnlyViaConstructor_Private_Void_LazyHelper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x0005F040 File Offset: 0x0005D240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310117, XrefRangeEnd = 1310121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PublicationOnlyViaFactory(LazyHelper initializer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(initializer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lazy<T>.NativeMethodInfoPtr_PublicationOnlyViaFactory_Private_Void_LazyHelper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x0005F084 File Offset: 0x0005D284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310121, XrefRangeEnd = 1310127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PublicationOnlyWaitForOtherThreadToPublish()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lazy<T>.NativeMethodInfoPtr_PublicationOnlyWaitForOtherThreadToPublish_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x0005F0B8 File Offset: 0x0005D2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310127, XrefRangeEnd = 1310157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T CreateValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lazy<T>.NativeMethodInfoPtr_CreateValue_Private_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x0005F0F4 File Offset: 0x0005D2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310157, XrefRangeEnd = 1310164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lazy<T>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000C62 RID: 3170 RVA: 0x0005F138 File Offset: 0x0005D338
		public unsafe bool IsValueCreated
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310164, XrefRangeEnd = 1310165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lazy<T>.NativeMethodInfoPtr_get_IsValueCreated_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000C63 RID: 3171 RVA: 0x0005F174 File Offset: 0x0005D374
		public unsafe T Value
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1310166, RefRangeEnd = 1310169, XrefRangeStart = 1310165, XrefRangeEnd = 1310166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lazy<T>.NativeMethodInfoPtr_get_Value_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x00005145 File Offset: 0x00003345
		public Lazy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000C65 RID: 3173 RVA: 0x0005F1B0 File Offset: 0x0005D3B0
		// (set) Token: 0x06000C66 RID: 3174 RVA: 0x0000514E File Offset: 0x0000334E
		public unsafe LazyHelper _state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lazy<T>.NativeFieldInfoPtr__state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LazyHelper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lazy<T>.NativeFieldInfoPtr__state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000C67 RID: 3175 RVA: 0x0005F1E0 File Offset: 0x0005D3E0
		// (set) Token: 0x06000C68 RID: 3176 RVA: 0x0000516D File Offset: 0x0000336D
		public unsafe Func<T> _factory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lazy<T>.NativeFieldInfoPtr__factory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lazy<T>.NativeFieldInfoPtr__factory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000C69 RID: 3177 RVA: 0x0005F210 File Offset: 0x0005D410
		// (set) Token: 0x06000C6A RID: 3178 RVA: 0x0005F238 File Offset: 0x0005D438
		public unsafe T _value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lazy<T>.NativeFieldInfoPtr__value);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lazy<T>.NativeFieldInfoPtr__value);
				Type typeFromHandle = typeof(T);
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

		// Token: 0x04000A24 RID: 2596
		private static readonly IntPtr NativeFieldInfoPtr__state;

		// Token: 0x04000A25 RID: 2597
		private static readonly IntPtr NativeFieldInfoPtr__factory;

		// Token: 0x04000A26 RID: 2598
		private static readonly IntPtr NativeFieldInfoPtr__value;

		// Token: 0x04000A27 RID: 2599
		private static readonly IntPtr NativeMethodInfoPtr_CreateViaDefaultConstructor_Private_Static_T_0;

		// Token: 0x04000A28 RID: 2600
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000A29 RID: 2601
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_0;

		// Token: 0x04000A2A RID: 2602
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Func_1_T_LazyThreadSafetyMode_Boolean_0;

		// Token: 0x04000A2B RID: 2603
		private static readonly IntPtr NativeMethodInfoPtr_ViaConstructor_Private_Void_0;

		// Token: 0x04000A2C RID: 2604
		private static readonly IntPtr NativeMethodInfoPtr_ViaFactory_Private_Void_LazyThreadSafetyMode_0;

		// Token: 0x04000A2D RID: 2605
		private static readonly IntPtr NativeMethodInfoPtr_ExecutionAndPublication_Private_Void_LazyHelper_Boolean_0;

		// Token: 0x04000A2E RID: 2606
		private static readonly IntPtr NativeMethodInfoPtr_PublicationOnly_Private_Void_LazyHelper_T_0;

		// Token: 0x04000A2F RID: 2607
		private static readonly IntPtr NativeMethodInfoPtr_PublicationOnlyViaConstructor_Private_Void_LazyHelper_0;

		// Token: 0x04000A30 RID: 2608
		private static readonly IntPtr NativeMethodInfoPtr_PublicationOnlyViaFactory_Private_Void_LazyHelper_0;

		// Token: 0x04000A31 RID: 2609
		private static readonly IntPtr NativeMethodInfoPtr_PublicationOnlyWaitForOtherThreadToPublish_Private_Void_0;

		// Token: 0x04000A32 RID: 2610
		private static readonly IntPtr NativeMethodInfoPtr_CreateValue_Private_T_0;

		// Token: 0x04000A33 RID: 2611
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValueCreated_Public_get_Boolean_0;

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_T_0;
	}
}
