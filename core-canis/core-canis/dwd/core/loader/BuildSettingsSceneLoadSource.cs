using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace dwd.core.loader
{
	// Token: 0x0200017B RID: 379
	public class BuildSettingsSceneLoadSource : SceneLoadSource
	{
		// Token: 0x060015AA RID: 5546 RVA: 0x0006AAD0 File Offset: 0x00068CD0
		// Note: this type is marked as 'beforefieldinit'.
		static BuildSettingsSceneLoadSource()
		{
			Il2CppClassPointerStore<BuildSettingsSceneLoadSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader", "BuildSettingsSceneLoadSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildSettingsSceneLoadSource>.NativeClassPtr);
			BuildSettingsSceneLoadSource.NativeMethodInfoPtr_LoadSceneSync_Public_Virtual_Task_String_LoadSceneMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildSettingsSceneLoadSource>.NativeClassPtr, 100666573);
			BuildSettingsSceneLoadSource.NativeMethodInfoPtr_LoadSceneAsync_Public_Virtual_Task_1_AsyncOperation_String_LoadSceneMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildSettingsSceneLoadSource>.NativeClassPtr, 100666574);
			BuildSettingsSceneLoadSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildSettingsSceneLoadSource>.NativeClassPtr, 100666575);
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x0006AB3C File Offset: 0x00068D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876986, XrefRangeEnd = 876998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task LoadSceneSync(string scene, LoadSceneMode mode, bool preserveInMemory)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildSettingsSceneLoadSource.NativeMethodInfoPtr_LoadSceneSync_Public_Virtual_Task_String_LoadSceneMode_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x0006ABB4 File Offset: 0x00068DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876998, XrefRangeEnd = 877008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<AsyncOperation> LoadSceneAsync(string scene, LoadSceneMode mode, bool preserveInMemory)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildSettingsSceneLoadSource.NativeMethodInfoPtr_LoadSceneAsync_Public_Virtual_Task_1_AsyncOperation_String_LoadSceneMode_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<AsyncOperation>>(intPtr3) : null;
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x0006AC2C File Offset: 0x00068E2C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 338035, RefRangeEnd = 338045, XrefRangeStart = 338035, XrefRangeEnd = 338045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildSettingsSceneLoadSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildSettingsSceneLoadSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildSettingsSceneLoadSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x0000988E File Offset: 0x00007A8E
		public BuildSettingsSceneLoadSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F63 RID: 3939
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneSync_Public_Virtual_Task_String_LoadSceneMode_Boolean_0;

		// Token: 0x04000F64 RID: 3940
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsync_Public_Virtual_Task_1_AsyncOperation_String_LoadSceneMode_Boolean_0;

		// Token: 0x04000F65 RID: 3941
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
