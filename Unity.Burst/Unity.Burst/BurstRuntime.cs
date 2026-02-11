using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Burst
{
	// Token: 0x02000010 RID: 16
	public static class BurstRuntime : Object
	{
		// Token: 0x06000174 RID: 372 RVA: 0x00007194 File Offset: 0x00005394
		// Note: this type is marked as 'beforefieldinit'.
		static BurstRuntime()
		{
			Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst", "BurstRuntime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr);
			BurstRuntime.NativeMethodInfoPtr_GetHashCode32_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, 100663419);
			BurstRuntime.NativeMethodInfoPtr_GetHashCode32_Public_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, 100663420);
			BurstRuntime.NativeMethodInfoPtr_GetHashCode64_Public_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, 100663421);
			BurstRuntime.NativeMethodInfoPtr_GetHashCode64_Public_Static_Int64_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, 100663422);
			BurstRuntime.NativeMethodInfoPtr_HashStringWithFNV1A32_Internal_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, 100663423);
			BurstRuntime.NativeMethodInfoPtr_HashStringWithFNV1A64_Internal_Static_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, 100663424);
			BurstRuntime.NativeMethodInfoPtr_LoadAdditionalLibrary_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, 100663425);
			BurstRuntime.NativeMethodInfoPtr_LoadAdditionalLibraryInternal_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, 100663426);
			BurstRuntime.NativeMethodInfoPtr_RuntimeLog_Internal_Static_Void_ptr_Byte_Int32_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, 100663427);
			BurstRuntime.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, 100663428);
			BurstRuntime.NativeMethodInfoPtr_PreventRequiredAttributeStrip_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, 100663429);
			BurstRuntime.NativeMethodInfoPtr_Log_Internal_Static_Void_ptr_Byte_Int32_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, 100663430);
			BurstRuntime.NativeMethodInfoPtr_GetUTF8LiteralPointer_Public_Static_ptr_Byte_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, 100663431);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x000072C8 File Offset: 0x000054C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051786, XrefRangeEnd = 1051789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetHashCode32<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstRuntime.MethodInfoStoreGeneric_GetHashCode32_Public_Static_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x000072F8 File Offset: 0x000054F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051789, XrefRangeEnd = 1051791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetHashCode32(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstRuntime.NativeMethodInfoPtr_GetHashCode32_Public_Static_Int32_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0000733C File Offset: 0x0000553C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 643959, RefRangeEnd = 643960, XrefRangeStart = 643959, XrefRangeEnd = 643960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetHashCode64<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstRuntime.MethodInfoStoreGeneric_GetHashCode64_Public_Static_Int64_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000736C File Offset: 0x0000556C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1051793, RefRangeEnd = 1051796, XrefRangeStart = 1051791, XrefRangeEnd = 1051793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetHashCode64(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstRuntime.NativeMethodInfoPtr_GetHashCode64_Public_Static_Int64_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x000073B0 File Offset: 0x000055B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051796, XrefRangeEnd = 1051798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int HashStringWithFNV1A32(string text)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstRuntime.NativeMethodInfoPtr_HashStringWithFNV1A32_Internal_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x000073F4 File Offset: 0x000055F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long HashStringWithFNV1A64(string text)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstRuntime.NativeMethodInfoPtr_HashStringWithFNV1A64_Internal_Static_Int64_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00007438 File Offset: 0x00005638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051798, XrefRangeEnd = 1051807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool LoadAdditionalLibrary(string pathToLibBurstGenerated)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pathToLibBurstGenerated);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstRuntime.NativeMethodInfoPtr_LoadAdditionalLibrary_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000747C File Offset: 0x0000567C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051807, XrefRangeEnd = 1051825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool LoadAdditionalLibraryInternal(string pathToLibBurstGenerated)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pathToLibBurstGenerated);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstRuntime.NativeMethodInfoPtr_LoadAdditionalLibraryInternal_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000074C0 File Offset: 0x000056C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051825, XrefRangeEnd = 1051826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RuntimeLog(byte* message, int logType, byte* fileName, int lineNumber)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = message;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = fileName;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstRuntime.NativeMethodInfoPtr_RuntimeLog_Internal_Static_Void_ptr_Byte_Int32_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0000751C File Offset: 0x0000571C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstRuntime.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00007544 File Offset: 0x00005744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051826, XrefRangeEnd = 1051846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PreventRequiredAttributeStrip()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstRuntime.NativeMethodInfoPtr_PreventRequiredAttributeStrip_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000756C File Offset: 0x0000576C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051846, XrefRangeEnd = 1051847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Log(byte* message, int logType, byte* fileName, int lineNumber)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = message;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = fileName;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstRuntime.NativeMethodInfoPtr_Log_Internal_Static_Void_ptr_Byte_Int32_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000075C8 File Offset: 0x000057C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051847, XrefRangeEnd = 1051853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte* GetUTF8LiteralPointer(string str, out int byteCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &byteCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstRuntime.NativeMethodInfoPtr_GetUTF8LiteralPointer_Public_Static_ptr_Byte_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002AF0 File Offset: 0x00000CF0
		public BurstRuntime(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode32_Public_Static_Int32_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode32_Public_Static_Int32_Type_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode64_Public_Static_Int64_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode64_Public_Static_Int64_Type_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_HashStringWithFNV1A32_Internal_Static_Int32_String_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_HashStringWithFNV1A64_Internal_Static_Int64_String_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_LoadAdditionalLibrary_Public_Static_Boolean_String_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_LoadAdditionalLibraryInternal_Internal_Static_Boolean_String_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_RuntimeLog_Internal_Static_Void_ptr_Byte_Int32_ptr_Byte_Int32_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_PreventRequiredAttributeStrip_Internal_Static_Void_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_Log_Internal_Static_Void_ptr_Byte_Int32_ptr_Byte_Int32_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF8LiteralPointer_Public_Static_ptr_Byte_String_byref_Int32_0;

		// Token: 0x02000034 RID: 52
		public sealed class HashCode32<T> : ValueType
		{
			// Token: 0x060002F0 RID: 752 RVA: 0x0000EE90 File Offset: 0x0000D090
			// Note: this type is marked as 'beforefieldinit'.
			static HashCode32()
			{
				Il2CppClassPointerStore<BurstRuntime.HashCode32<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, "HashCode32`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstRuntime.HashCode32<T>>.NativeClassPtr);
				BurstRuntime.HashCode32<T>.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstRuntime.HashCode32<T>>.NativeClassPtr, "Value");
			}

			// Token: 0x060002F1 RID: 753 RVA: 0x00003090 File Offset: 0x00001290
			public HashCode32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060002F2 RID: 754 RVA: 0x00003099 File Offset: 0x00001299
			public HashCode32()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstRuntime.HashCode32<T>>.NativeClassPtr))
			{
			}

			// Token: 0x170000E6 RID: 230
			// (get) Token: 0x060002F3 RID: 755 RVA: 0x0000EF0C File Offset: 0x0000D10C
			// (set) Token: 0x060002F4 RID: 756 RVA: 0x000030AB File Offset: 0x000012AB
			public unsafe static int Value
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(BurstRuntime.HashCode32<T>.NativeFieldInfoPtr_Value, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BurstRuntime.HashCode32<T>.NativeFieldInfoPtr_Value, (void*)(&value));
				}
			}

			// Token: 0x04000485 RID: 1157
			private static readonly IntPtr NativeFieldInfoPtr_Value;
		}

		// Token: 0x02000035 RID: 53
		public sealed class HashCode64<T> : ValueType
		{
			// Token: 0x060002F5 RID: 757 RVA: 0x0000EF28 File Offset: 0x0000D128
			// Note: this type is marked as 'beforefieldinit'.
			static HashCode64()
			{
				Il2CppClassPointerStore<BurstRuntime.HashCode64<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, "HashCode64`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstRuntime.HashCode64<T>>.NativeClassPtr);
				BurstRuntime.HashCode64<T>.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstRuntime.HashCode64<T>>.NativeClassPtr, "Value");
			}

			// Token: 0x060002F6 RID: 758 RVA: 0x000030B9 File Offset: 0x000012B9
			public HashCode64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060002F7 RID: 759 RVA: 0x000030C2 File Offset: 0x000012C2
			public HashCode64()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstRuntime.HashCode64<T>>.NativeClassPtr))
			{
			}

			// Token: 0x170000E7 RID: 231
			// (get) Token: 0x060002F8 RID: 760 RVA: 0x0000EFA4 File Offset: 0x0000D1A4
			// (set) Token: 0x060002F9 RID: 761 RVA: 0x000030D4 File Offset: 0x000012D4
			public unsafe static long Value
			{
				get
				{
					long num;
					IL2CPP.il2cpp_field_static_get_value(BurstRuntime.HashCode64<T>.NativeFieldInfoPtr_Value, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BurstRuntime.HashCode64<T>.NativeFieldInfoPtr_Value, (void*)(&value));
				}
			}

			// Token: 0x04000486 RID: 1158
			private static readonly IntPtr NativeFieldInfoPtr_Value;
		}

		// Token: 0x02000036 RID: 54
		public class PreserveAttribute : Attribute
		{
			// Token: 0x060002FA RID: 762 RVA: 0x000030E2 File Offset: 0x000012E2
			// Note: this type is marked as 'beforefieldinit'.
			static PreserveAttribute()
			{
				Il2CppClassPointerStore<BurstRuntime.PreserveAttribute>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, "PreserveAttribute");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstRuntime.PreserveAttribute>.NativeClassPtr);
				BurstRuntime.PreserveAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstRuntime.PreserveAttribute>.NativeClassPtr, 100663434);
			}

			// Token: 0x060002FB RID: 763 RVA: 0x0000EFC0 File Offset: 0x0000D1C0
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PreserveAttribute()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstRuntime.PreserveAttribute>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstRuntime.PreserveAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002FC RID: 764 RVA: 0x00003116 File Offset: 0x00001316
			public PreserveAttribute(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000487 RID: 1159
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000037 RID: 55
		private sealed class MethodInfoStoreGeneric_GetHashCode32_Public_Static_Int32_0<T>
		{
			// Token: 0x04000488 RID: 1160
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BurstRuntime.NativeMethodInfoPtr_GetHashCode32_Public_Static_Int32_0, Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000038 RID: 56
		private sealed class MethodInfoStoreGeneric_GetHashCode64_Public_Static_Int64_0<T>
		{
			// Token: 0x04000489 RID: 1161
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BurstRuntime.NativeMethodInfoPtr_GetHashCode64_Public_Static_Int64_0, Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
