using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Util.Store
{
	// Token: 0x02000004 RID: 4
	public class NullDataStore : Object
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00004E68 File Offset: 0x00003068
		// Note: this type is marked as 'beforefieldinit'.
		static NullDataStore()
		{
			Il2CppClassPointerStore<NullDataStore>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.dll", "Google.Apis.Util.Store", "NullDataStore");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullDataStore>.NativeClassPtr);
			NullDataStore.NativeFieldInfoPtr_s_completedTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NullDataStore>.NativeClassPtr, "s_completedTask");
			NullDataStore.NativeMethodInfoPtr_CompletedTask_Private_Static_Task_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullDataStore>.NativeClassPtr, 100663306);
			NullDataStore.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullDataStore>.NativeClassPtr, 100663307);
			NullDataStore.NativeMethodInfoPtr_ClearAsync_Public_Virtual_Final_New_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullDataStore>.NativeClassPtr, 100663308);
			NullDataStore.NativeMethodInfoPtr_DeleteAsync_Public_Virtual_Final_New_Task_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullDataStore>.NativeClassPtr, 100663309);
			NullDataStore.NativeMethodInfoPtr_GetAsync_Public_Virtual_Final_New_Task_1_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullDataStore>.NativeClassPtr, 100663310);
			NullDataStore.NativeMethodInfoPtr_StoreAsync_Public_Virtual_Final_New_Task_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullDataStore>.NativeClassPtr, 100663311);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00004F24 File Offset: 0x00003124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195481, XrefRangeEnd = 1195486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<T> CompletedTask<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullDataStore.MethodInfoStoreGeneric_CompletedTask_Private_Static_Task_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00004F58 File Offset: 0x00003158
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NullDataStore()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullDataStore>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullDataStore.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00004F94 File Offset: 0x00003194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195486, XrefRangeEnd = 1195490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task ClearAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullDataStore.NativeMethodInfoPtr_ClearAsync_Public_Virtual_Final_New_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00004FD4 File Offset: 0x000031D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195490, XrefRangeEnd = 1195494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task DeleteAsync<T>(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullDataStore.MethodInfoStoreGeneric_DeleteAsync_Public_Virtual_Final_New_Task_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00005024 File Offset: 0x00003224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195494, XrefRangeEnd = 1195503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<T> GetAsync<T>(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullDataStore.MethodInfoStoreGeneric_GetAsync_Public_Virtual_Final_New_Task_1_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00005074 File Offset: 0x00003274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195503, XrefRangeEnd = 1195507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task StoreAsync<T>(string key, T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NullDataStore.MethodInfoStoreGeneric_StoreAsync_Public_Virtual_Final_New_Task_String_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<Task>(intPtr4) : null;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000209C File Offset: 0x0000029C
		public NullDataStore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000019 RID: 25 RVA: 0x0000510C File Offset: 0x0000330C
		// (set) Token: 0x0600001A RID: 26 RVA: 0x000020A5 File Offset: 0x000002A5
		public unsafe static Task s_completedTask
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NullDataStore.NativeFieldInfoPtr_s_completedTask, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NullDataStore.NativeFieldInfoPtr_s_completedTask, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_s_completedTask;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_CompletedTask_Private_Static_Task_1_T_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_ClearAsync_Public_Virtual_Final_New_Task_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_DeleteAsync_Public_Virtual_Final_New_Task_String_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_GetAsync_Public_Virtual_Final_New_Task_1_T_String_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_StoreAsync_Public_Virtual_Final_New_Task_String_T_0;

		// Token: 0x0200001F RID: 31
		private sealed class MethodInfoStoreGeneric_CompletedTask_Private_Static_Task_1_T_0<T>
		{
			// Token: 0x04000159 RID: 345
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NullDataStore.NativeMethodInfoPtr_CompletedTask_Private_Static_Task_1_T_0, Il2CppClassPointerStore<NullDataStore>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000020 RID: 32
		private sealed class MethodInfoStoreGeneric_DeleteAsync_Public_Virtual_Final_New_Task_String_0<T>
		{
			// Token: 0x0400015A RID: 346
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NullDataStore.NativeMethodInfoPtr_DeleteAsync_Public_Virtual_Final_New_Task_String_0, Il2CppClassPointerStore<NullDataStore>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000021 RID: 33
		private sealed class MethodInfoStoreGeneric_GetAsync_Public_Virtual_Final_New_Task_1_T_String_0<T>
		{
			// Token: 0x0400015B RID: 347
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NullDataStore.NativeMethodInfoPtr_GetAsync_Public_Virtual_Final_New_Task_1_T_String_0, Il2CppClassPointerStore<NullDataStore>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000022 RID: 34
		private sealed class MethodInfoStoreGeneric_StoreAsync_Public_Virtual_Final_New_Task_String_T_0<T>
		{
			// Token: 0x0400015C RID: 348
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NullDataStore.NativeMethodInfoPtr_StoreAsync_Public_Virtual_Final_New_Task_String_T_0, Il2CppClassPointerStore<NullDataStore>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
