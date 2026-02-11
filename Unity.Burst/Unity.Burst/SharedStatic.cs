using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Burst
{
	// Token: 0x02000017 RID: 23
	public sealed class SharedStatic<T> : ValueType where T : new()
	{
		// Token: 0x060001E1 RID: 481 RVA: 0x00009318 File Offset: 0x00007518
		// Note: this type is marked as 'beforefieldinit'.
		static SharedStatic()
		{
			Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst", "SharedStatic`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr);
			SharedStatic<T>.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr, "_buffer");
			SharedStatic<T>.NativeFieldInfoPtr_DefaultAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr, "DefaultAlignment");
			SharedStatic<T>.NativeMethodInfoPtr__ctor_Private_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr, 100663517);
			SharedStatic<T>.NativeMethodInfoPtr_get_Data_Public_get_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr, 100663518);
			SharedStatic<T>.NativeMethodInfoPtr_get_UnsafeDataPointer_Public_get_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr, 100663519);
			SharedStatic<T>.NativeMethodInfoPtr_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr, 100663520);
			SharedStatic<T>.NativeMethodInfoPtr_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr, 100663521);
			SharedStatic<T>.NativeMethodInfoPtr_GetOrCreateUnsafe_Public_Static_SharedStatic_1_T_UInt32_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr, 100663522);
			SharedStatic<T>.NativeMethodInfoPtr_GetOrCreatePartiallyUnsafeWithHashCode_Public_Static_SharedStatic_1_T_UInt32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr, 100663523);
			SharedStatic<T>.NativeMethodInfoPtr_GetOrCreatePartiallyUnsafeWithSubHashCode_Public_Static_SharedStatic_1_T_UInt32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr, 100663524);
			SharedStatic<T>.NativeMethodInfoPtr_GetOrCreate_Public_Static_SharedStatic_1_T_Type_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr, 100663525);
			SharedStatic<T>.NativeMethodInfoPtr_GetOrCreate_Public_Static_SharedStatic_1_T_Type_Type_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr, 100663526);
			SharedStatic<T>.NativeMethodInfoPtr_CheckIf_T_IsUnmanagedOrThrow_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr, 100663527);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00009488 File Offset: 0x00007688
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 315640, RefRangeEnd = 315684, XrefRangeStart = 315640, XrefRangeEnd = 315684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SharedStatic(void* buffer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = buffer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedStatic<T>.NativeMethodInfoPtr__ctor_Private_Void_ptr_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x000094D4 File Offset: 0x000076D4
		public unsafe ref T Data
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052478, XrefRangeEnd = 1052480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedStatic<T>.NativeMethodInfoPtr_get_Data_Public_get_byref_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x0000950C File Offset: 0x0000770C
		public unsafe void* UnsafeDataPointer
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedStatic<T>.NativeMethodInfoPtr_get_UnsafeDataPointer_Public_get_ptr_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00009544 File Offset: 0x00007744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052480, XrefRangeEnd = 1052488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SharedStatic<T> GetOrCreate<TContext>(uint alignment = 0U)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alignment;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedStatic<TContext>.MethodInfoStoreGeneric_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SharedStatic<T>(intPtr);
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000957C File Offset: 0x0000777C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052488, XrefRangeEnd = 1052491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SharedStatic<T> GetOrCreate<TContext, TSubContext>(uint alignment = 0U)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alignment;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedStatic<TContext>.MethodInfoStoreGeneric_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0<TSubContext>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SharedStatic<T>(intPtr);
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x000095B4 File Offset: 0x000077B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052491, XrefRangeEnd = 1052495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SharedStatic<T> GetOrCreateUnsafe(uint alignment, long hashCode, long subHashCode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alignment;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref subHashCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedStatic<T>.NativeMethodInfoPtr_GetOrCreateUnsafe_Public_Static_SharedStatic_1_T_UInt32_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new SharedStatic<T>(intPtr);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00009608 File Offset: 0x00007808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052495, XrefRangeEnd = 1052500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SharedStatic<T> GetOrCreatePartiallyUnsafeWithHashCode<TSubContext>(uint alignment, long hashCode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alignment;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedStatic<TSubContext>.MethodInfoStoreGeneric_GetOrCreatePartiallyUnsafeWithHashCode_Public_Static_SharedStatic_1_T_UInt32_Int64_0.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new SharedStatic<T>(intPtr);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00009650 File Offset: 0x00007850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052500, XrefRangeEnd = 1052505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SharedStatic<T> GetOrCreatePartiallyUnsafeWithSubHashCode<TContext>(uint alignment, long subHashCode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alignment;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref subHashCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedStatic<TContext>.MethodInfoStoreGeneric_GetOrCreatePartiallyUnsafeWithSubHashCode_Public_Static_SharedStatic_1_T_UInt32_Int64_0.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new SharedStatic<T>(intPtr);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00009698 File Offset: 0x00007898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052505, XrefRangeEnd = 1052508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SharedStatic<T> GetOrCreate(Type contextType, uint alignment = 0U)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(contextType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedStatic<T>.NativeMethodInfoPtr_GetOrCreate_Public_Static_SharedStatic_1_T_Type_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new SharedStatic<T>(intPtr);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x000096E4 File Offset: 0x000078E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052508, XrefRangeEnd = 1052512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SharedStatic<T> GetOrCreate(Type contextType, Type subContextType, uint alignment = 0U)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(contextType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subContextType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedStatic<T>.NativeMethodInfoPtr_GetOrCreate_Public_Static_SharedStatic_1_T_Type_Type_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new SharedStatic<T>(intPtr);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00009740 File Offset: 0x00007940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052512, XrefRangeEnd = 1052514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckIf_T_IsUnmanagedOrThrow()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedStatic<T>.NativeMethodInfoPtr_CheckIf_T_IsUnmanagedOrThrow_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002C69 File Offset: 0x00000E69
		public SharedStatic(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00002C72 File Offset: 0x00000E72
		public SharedStatic()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedStatic<T>>.NativeClassPtr))
		{
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001EF RID: 495 RVA: 0x00009768 File Offset: 0x00007968
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x00002C84 File Offset: 0x00000E84
		public unsafe void* _buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedStatic<T>.NativeFieldInfoPtr__buffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedStatic<T>.NativeFieldInfoPtr__buffer)) = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x0000978C File Offset: 0x0000798C
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x00002C9F File Offset: 0x00000E9F
		public unsafe static uint DefaultAlignment
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(SharedStatic<T>.NativeFieldInfoPtr_DefaultAlignment, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SharedStatic<T>.NativeFieldInfoPtr_DefaultAlignment, (void*)(&value));
			}
		}

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeFieldInfoPtr__buffer;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeFieldInfoPtr_DefaultAlignment;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_ptr_Void_0;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_get_byref_T_0;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeMethodInfoPtr_get_UnsafeDataPointer_Public_get_ptr_Void_0;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreateUnsafe_Public_Static_SharedStatic_1_T_UInt32_Int64_Int64_0;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreatePartiallyUnsafeWithHashCode_Public_Static_SharedStatic_1_T_UInt32_Int64_0;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreatePartiallyUnsafeWithSubHashCode_Public_Static_SharedStatic_1_T_UInt32_Int64_0;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreate_Public_Static_SharedStatic_1_T_Type_UInt32_0;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreate_Public_Static_SharedStatic_1_T_Type_Type_UInt32_0;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeMethodInfoPtr_CheckIf_T_IsUnmanagedOrThrow_Private_Static_Void_0;

		// Token: 0x02000043 RID: 67
		private sealed class MethodInfoStoreGeneric_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0
		{
			// Token: 0x040004CD RID: 1229
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SharedStatic<TContext>.NativeMethodInfoPtr_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0, Il2CppClassPointerStore<SharedStatic<TContext>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TContext>.NativeClassPtr)) }))));
		}

		// Token: 0x02000044 RID: 68
		private sealed class MethodInfoStoreGeneric_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0<TSubContext>
		{
			// Token: 0x040004CE RID: 1230
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SharedStatic<TContext>.NativeMethodInfoPtr_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0, Il2CppClassPointerStore<SharedStatic<TContext>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TContext>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSubContext>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000045 RID: 69
		private sealed class MethodInfoStoreGeneric_GetOrCreatePartiallyUnsafeWithHashCode_Public_Static_SharedStatic_1_T_UInt32_Int64_0
		{
			// Token: 0x040004CF RID: 1231
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SharedStatic<TSubContext>.NativeMethodInfoPtr_GetOrCreatePartiallyUnsafeWithHashCode_Public_Static_SharedStatic_1_T_UInt32_Int64_0, Il2CppClassPointerStore<SharedStatic<TSubContext>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSubContext>.NativeClassPtr)) }))));
		}

		// Token: 0x02000046 RID: 70
		private sealed class MethodInfoStoreGeneric_GetOrCreatePartiallyUnsafeWithSubHashCode_Public_Static_SharedStatic_1_T_UInt32_Int64_0
		{
			// Token: 0x040004D0 RID: 1232
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SharedStatic<TContext>.NativeMethodInfoPtr_GetOrCreatePartiallyUnsafeWithSubHashCode_Public_Static_SharedStatic_1_T_UInt32_Int64_0, Il2CppClassPointerStore<SharedStatic<TContext>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TContext>.NativeClassPtr)) }))));
		}
	}
}
