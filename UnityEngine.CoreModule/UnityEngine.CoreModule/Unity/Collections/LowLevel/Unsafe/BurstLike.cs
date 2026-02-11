using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000044 RID: 68
	public static class BurstLike : Object
	{
		// Token: 0x06000271 RID: 625 RVA: 0x0000334E File Offset: 0x0000154E
		// Note: this type is marked as 'beforefieldinit'.
		static BurstLike()
		{
			Il2CppClassPointerStore<BurstLike>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "BurstLike");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstLike>.NativeClassPtr);
			BurstLike.NativeFunctionCall_Int_IntPtr_IntPtrDelegateField = IL2CPP.ResolveICall<BurstLike.NativeFunctionCall_Int_IntPtr_IntPtrDelegate>("Unity.Collections.LowLevel.Unsafe.BurstLike::NativeFunctionCall_Int_IntPtr_IntPtr");
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00003382 File Offset: 0x00001582
		public BurstLike(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000338B File Offset: 0x0000158B
		public static int NativeFunctionCall_Int_IntPtr_IntPtr(IntPtr function, IntPtr p0, IntPtr p1, out int error)
		{
			return BurstLike.NativeFunctionCall_Int_IntPtr_IntPtrDelegateField(function, p0, p1, out error);
		}

		// Token: 0x040001DC RID: 476
		private static readonly BurstLike.NativeFunctionCall_Int_IntPtr_IntPtrDelegate NativeFunctionCall_Int_IntPtr_IntPtrDelegateField;

		// Token: 0x020003C9 RID: 969
		public sealed class SharedStatic<T> : ValueType where T : new()
		{
			// Token: 0x0600308A RID: 12426 RVA: 0x000B746C File Offset: 0x000B566C
			// Note: this type is marked as 'beforefieldinit'.
			static SharedStatic()
			{
				Il2CppClassPointerStore<BurstLike.SharedStatic<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstLike>.NativeClassPtr, "SharedStatic`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstLike.SharedStatic<T>>.NativeClassPtr);
				BurstLike.SharedStatic<T>.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstLike.SharedStatic<T>>.NativeClassPtr, "_buffer");
				BurstLike.SharedStatic<T>.NativeMethodInfoPtr__ctor_Private_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstLike.SharedStatic<T>>.NativeClassPtr, 100663508);
				BurstLike.SharedStatic<T>.NativeMethodInfoPtr_get_Data_Public_get_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstLike.SharedStatic<T>>.NativeClassPtr, 100663509);
				BurstLike.SharedStatic<T>.NativeMethodInfoPtr_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstLike.SharedStatic<T>>.NativeClassPtr, 100663510);
			}

			// Token: 0x0600308B RID: 12427 RVA: 0x000B7524 File Offset: 0x000B5724
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 315640, RefRangeEnd = 315684, XrefRangeStart = 315640, XrefRangeEnd = 315684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SharedStatic(void* buffer)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstLike.SharedStatic<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = buffer;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstLike.SharedStatic<T>.NativeMethodInfoPtr__ctor_Private_Void_ptr_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000A04 RID: 2564
			// (get) Token: 0x0600308C RID: 12428 RVA: 0x000B7570 File Offset: 0x000B5770
			public unsafe ref T Data
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 643931, RefRangeEnd = 643946, XrefRangeStart = 643930, XrefRangeEnd = 643931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstLike.SharedStatic<T>.NativeMethodInfoPtr_get_Data_Public_get_byref_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}

			// Token: 0x0600308D RID: 12429 RVA: 0x000B75A8 File Offset: 0x000B57A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643946, XrefRangeEnd = 643951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static BurstLike.SharedStatic<T> GetOrCreate<TContext>(uint alignment = 0U)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref alignment;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstLike.SharedStatic<TContext>.MethodInfoStoreGeneric_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0.Pointer, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new BurstLike.SharedStatic<T>(intPtr);
				}
			}

			// Token: 0x0600308E RID: 12430 RVA: 0x00013847 File Offset: 0x00011A47
			public SharedStatic(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600308F RID: 12431 RVA: 0x00013850 File Offset: 0x00011A50
			public SharedStatic()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstLike.SharedStatic<T>>.NativeClassPtr))
			{
			}

			// Token: 0x17000A03 RID: 2563
			// (get) Token: 0x06003090 RID: 12432 RVA: 0x000B75E0 File Offset: 0x000B57E0
			// (set) Token: 0x06003091 RID: 12433 RVA: 0x00013862 File Offset: 0x00011A62
			public unsafe void* _buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstLike.SharedStatic<T>.NativeFieldInfoPtr__buffer);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstLike.SharedStatic<T>.NativeFieldInfoPtr__buffer)) = value;
				}
			}

			// Token: 0x04002AFA RID: 11002
			private static readonly IntPtr NativeFieldInfoPtr__buffer;

			// Token: 0x04002AFB RID: 11003
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_ptr_Void_0;

			// Token: 0x04002AFC RID: 11004
			private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_get_byref_T_0;

			// Token: 0x04002AFD RID: 11005
			private static readonly IntPtr NativeMethodInfoPtr_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0;

			// Token: 0x02000BDF RID: 3039
			private sealed class MethodInfoStoreGeneric_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0
			{
				// Token: 0x04002DD3 RID: 11731
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BurstLike.SharedStatic<TContext>.NativeMethodInfoPtr_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0, Il2CppClassPointerStore<BurstLike.SharedStatic<TContext>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TContext>.NativeClassPtr)) }))));
			}
		}

		// Token: 0x020003CA RID: 970
		public static class SharedStatic : Object
		{
			// Token: 0x06003092 RID: 12434 RVA: 0x0001387D File Offset: 0x00011A7D
			// Note: this type is marked as 'beforefieldinit'.
			static SharedStatic()
			{
				Il2CppClassPointerStore<BurstLike.SharedStatic>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstLike>.NativeClassPtr, "SharedStatic");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstLike.SharedStatic>.NativeClassPtr);
				BurstLike.SharedStatic.NativeMethodInfoPtr_GetOrCreateSharedStaticInternal_Public_Static_ptr_Void_Int64_Int64_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstLike.SharedStatic>.NativeClassPtr, 100663511);
			}

			// Token: 0x06003093 RID: 12435 RVA: 0x000B7604 File Offset: 0x000B5804
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 643954, RefRangeEnd = 643956, XrefRangeStart = 643951, XrefRangeEnd = 643954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref getHashCode64;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref getSubHashCode64;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeOf;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignment;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstLike.SharedStatic.NativeMethodInfoPtr_GetOrCreateSharedStaticInternal_Public_Static_ptr_Void_Int64_Int64_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}

			// Token: 0x06003094 RID: 12436 RVA: 0x000138B1 File Offset: 0x00011AB1
			public SharedStatic(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002AFE RID: 11006
			private static readonly IntPtr NativeMethodInfoPtr_GetOrCreateSharedStaticInternal_Public_Static_ptr_Void_Int64_Int64_UInt32_UInt32_0;
		}

		// Token: 0x020003CB RID: 971
		// (Invoke) Token: 0x06003096 RID: 12438
		private delegate int NativeFunctionCall_Int_IntPtr_IntPtrDelegate(IntPtr function, IntPtr p0, IntPtr p1, [Out] IntPtr error);
	}
}
