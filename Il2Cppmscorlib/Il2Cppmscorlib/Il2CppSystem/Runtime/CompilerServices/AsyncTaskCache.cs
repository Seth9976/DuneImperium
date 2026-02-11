using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003D2 RID: 978
	public static class AsyncTaskCache : Object
	{
		// Token: 0x060039D3 RID: 14803 RVA: 0x001175E4 File Offset: 0x001157E4
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncTaskCache()
		{
			Il2CppClassPointerStore<AsyncTaskCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "AsyncTaskCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncTaskCache>.NativeClassPtr);
			AsyncTaskCache.NativeFieldInfoPtr_TrueTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncTaskCache>.NativeClassPtr, "TrueTask");
			AsyncTaskCache.NativeFieldInfoPtr_FalseTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncTaskCache>.NativeClassPtr, "FalseTask");
			AsyncTaskCache.NativeFieldInfoPtr_Int32Tasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncTaskCache>.NativeClassPtr, "Int32Tasks");
			AsyncTaskCache.NativeMethodInfoPtr_CreateInt32Tasks_Private_Static_Il2CppReferenceArray_1_Task_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskCache>.NativeClassPtr, 100671922);
			AsyncTaskCache.NativeMethodInfoPtr_CreateCacheableTask_Internal_Static_Task_1_TResult_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskCache>.NativeClassPtr, 100671923);
		}

		// Token: 0x060039D4 RID: 14804 RVA: 0x00117678 File Offset: 0x00115878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1395474, XrefRangeEnd = 1395486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Task<int>> CreateInt32Tasks()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncTaskCache.NativeMethodInfoPtr_CreateInt32Tasks_Private_Static_Il2CppReferenceArray_1_Task_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Task<int>>>(intPtr3) : null;
		}

		// Token: 0x060039D5 RID: 14805 RVA: 0x001176AC File Offset: 0x001158AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1395490, RefRangeEnd = 1395491, XrefRangeStart = 1395486, XrefRangeEnd = 1395490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> CreateCacheableTask<TResult>(TResult result)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TResult).IsValueType)
				{
					TResult tresult = result;
					intPtr = ((tresult is string) ? IL2CPP.ManagedStringToIl2Cpp(tresult as string) : IL2CPP.Il2CppObjectBaseToPtr(tresult as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref result;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AsyncTaskCache.MethodInfoStoreGeneric_CreateCacheableTask_Internal_Static_Task_1_TResult_TResult_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr4) : null;
			}
		}

		// Token: 0x060039D6 RID: 14806 RVA: 0x0001579A File Offset: 0x0001399A
		public AsyncTaskCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x060039D7 RID: 14807 RVA: 0x00117728 File Offset: 0x00115928
		// (set) Token: 0x060039D8 RID: 14808 RVA: 0x000157A3 File Offset: 0x000139A3
		public unsafe static Task<bool> TrueTask
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AsyncTaskCache.NativeFieldInfoPtr_TrueTask, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AsyncTaskCache.NativeFieldInfoPtr_TrueTask, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x060039D9 RID: 14809 RVA: 0x00117750 File Offset: 0x00115950
		// (set) Token: 0x060039DA RID: 14810 RVA: 0x000157B5 File Offset: 0x000139B5
		public unsafe static Task<bool> FalseTask
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AsyncTaskCache.NativeFieldInfoPtr_FalseTask, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AsyncTaskCache.NativeFieldInfoPtr_FalseTask, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x060039DB RID: 14811 RVA: 0x00117778 File Offset: 0x00115978
		// (set) Token: 0x060039DC RID: 14812 RVA: 0x000157C7 File Offset: 0x000139C7
		public unsafe static Il2CppReferenceArray<Task<int>> Int32Tasks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AsyncTaskCache.NativeFieldInfoPtr_Int32Tasks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Task<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AsyncTaskCache.NativeFieldInfoPtr_Int32Tasks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002EE5 RID: 12005
		private static readonly IntPtr NativeFieldInfoPtr_TrueTask;

		// Token: 0x04002EE6 RID: 12006
		private static readonly IntPtr NativeFieldInfoPtr_FalseTask;

		// Token: 0x04002EE7 RID: 12007
		private static readonly IntPtr NativeFieldInfoPtr_Int32Tasks;

		// Token: 0x04002EE8 RID: 12008
		private static readonly IntPtr NativeMethodInfoPtr_CreateInt32Tasks_Private_Static_Il2CppReferenceArray_1_Task_1_Int32_0;

		// Token: 0x04002EE9 RID: 12009
		private static readonly IntPtr NativeMethodInfoPtr_CreateCacheableTask_Internal_Static_Task_1_TResult_TResult_0;

		// Token: 0x02000698 RID: 1688
		private sealed class MethodInfoStoreGeneric_CreateCacheableTask_Internal_Static_Task_1_TResult_TResult_0<TResult>
		{
			// Token: 0x04004ACF RID: 19151
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AsyncTaskCache.NativeMethodInfoPtr_CreateCacheableTask_Internal_Static_Task_1_TResult_TResult_0, Il2CppClassPointerStore<AsyncTaskCache>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}
	}
}
