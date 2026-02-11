using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace dwd.core.loader
{
	// Token: 0x02000182 RID: 386
	public class SceneLoadSource : ScriptableObject
	{
		// Token: 0x060015EF RID: 5615 RVA: 0x0006C38C File Offset: 0x0006A58C
		// Note: this type is marked as 'beforefieldinit'.
		static SceneLoadSource()
		{
			Il2CppClassPointerStore<SceneLoadSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader", "SceneLoadSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneLoadSource>.NativeClassPtr);
			SceneLoadSource.NativeMethodInfoPtr_LoadSceneSync_Public_Abstract_Virtual_New_Task_String_LoadSceneMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLoadSource>.NativeClassPtr, 100666656);
			SceneLoadSource.NativeMethodInfoPtr_LoadSceneAsync_Public_Abstract_Virtual_New_Task_1_AsyncOperation_String_LoadSceneMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLoadSource>.NativeClassPtr, 100666657);
			SceneLoadSource.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLoadSource>.NativeClassPtr, 100666658);
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x0006C3F8 File Offset: 0x0006A5F8
		[CallerCount(0)]
		public unsafe virtual Task LoadSceneSync(string scene, LoadSceneMode mode, bool preserveInMemory)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(scene);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preserveInMemory;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneLoadSource.NativeMethodInfoPtr_LoadSceneSync_Public_Abstract_Virtual_New_Task_String_LoadSceneMode_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x0006C470 File Offset: 0x0006A670
		[CallerCount(0)]
		public unsafe virtual Task<AsyncOperation> LoadSceneAsync(string scene, LoadSceneMode mode, bool preserveInMemory)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(scene);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preserveInMemory;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneLoadSource.NativeMethodInfoPtr_LoadSceneAsync_Public_Abstract_Virtual_New_Task_1_AsyncOperation_String_LoadSceneMode_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<AsyncOperation>>(intPtr3) : null;
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x0006C4E8 File Offset: 0x0006A6E8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 338035, RefRangeEnd = 338045, XrefRangeStart = 338035, XrefRangeEnd = 338045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneLoadSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneLoadSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneLoadSource.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x00009964 File Offset: 0x00007B64
		public SceneLoadSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F99 RID: 3993
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneSync_Public_Abstract_Virtual_New_Task_String_LoadSceneMode_Boolean_0;

		// Token: 0x04000F9A RID: 3994
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsync_Public_Abstract_Virtual_New_Task_1_AsyncOperation_String_LoadSceneMode_Boolean_0;

		// Token: 0x04000F9B RID: 3995
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
