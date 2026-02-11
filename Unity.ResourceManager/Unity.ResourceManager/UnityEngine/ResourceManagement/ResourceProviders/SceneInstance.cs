using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.SceneManagement;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	// Token: 0x0200003C RID: 60
	public sealed class SceneInstance : ValueType
	{
		// Token: 0x06000321 RID: 801 RVA: 0x00010F70 File Offset: 0x0000F170
		// Note: this type is marked as 'beforefieldinit'.
		static SceneInstance()
		{
			Il2CppClassPointerStore<SceneInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.ResourceProviders", "SceneInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneInstance>.NativeClassPtr);
			SceneInstance.NativeFieldInfoPtr_m_Scene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneInstance>.NativeClassPtr, "m_Scene");
			SceneInstance.NativeFieldInfoPtr_m_Operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneInstance>.NativeClassPtr, "m_Operation");
			SceneInstance.NativeMethodInfoPtr_get_Scene_Public_get_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneInstance>.NativeClassPtr, 100663809);
			SceneInstance.NativeMethodInfoPtr_set_Scene_Internal_set_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneInstance>.NativeClassPtr, 100663810);
			SceneInstance.NativeMethodInfoPtr_Activate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneInstance>.NativeClassPtr, 100663811);
			SceneInstance.NativeMethodInfoPtr_ActivateAsync_Public_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneInstance>.NativeClassPtr, 100663812);
			SceneInstance.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneInstance>.NativeClassPtr, 100663813);
			SceneInstance.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneInstance>.NativeClassPtr, 100663814);
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000322 RID: 802 RVA: 0x00011040 File Offset: 0x0000F240
		// (set) Token: 0x06000323 RID: 803 RVA: 0x00011084 File Offset: 0x0000F284
		public unsafe Scene Scene
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneInstance.NativeMethodInfoPtr_get_Scene_Public_get_Scene_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 320163, RefRangeEnd = 320170, XrefRangeStart = 320163, XrefRangeEnd = 320170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneInstance.NativeMethodInfoPtr_set_Scene_Internal_set_Void_Scene_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000324 RID: 804 RVA: 0x000110C8 File Offset: 0x0000F2C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140672, XrefRangeEnd = 1140674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneInstance.NativeMethodInfoPtr_Activate_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00011100 File Offset: 0x0000F300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140674, XrefRangeEnd = 1140675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperation ActivateAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneInstance.NativeMethodInfoPtr_ActivateAsync_Public_AsyncOperation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00011144 File Offset: 0x0000F344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140675, XrefRangeEnd = 1140676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneInstance.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00011188 File Offset: 0x0000F388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140676, XrefRangeEnd = 1140683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneInstance.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0000341A File Offset: 0x0000161A
		public SceneInstance(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00003423 File Offset: 0x00001623
		public SceneInstance()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneInstance>.NativeClassPtr))
		{
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600032A RID: 810 RVA: 0x000111DC File Offset: 0x0000F3DC
		// (set) Token: 0x0600032B RID: 811 RVA: 0x00003435 File Offset: 0x00001635
		public unsafe Scene m_Scene
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneInstance.NativeFieldInfoPtr_m_Scene);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneInstance.NativeFieldInfoPtr_m_Scene)) = value;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600032C RID: 812 RVA: 0x00011204 File Offset: 0x0000F404
		// (set) Token: 0x0600032D RID: 813 RVA: 0x00003450 File Offset: 0x00001650
		public unsafe AsyncOperation m_Operation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneInstance.NativeFieldInfoPtr_m_Operation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneInstance.NativeFieldInfoPtr_m_Operation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeFieldInfoPtr_m_Scene;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeFieldInfoPtr_m_Operation;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_get_Scene_Public_get_Scene_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_set_Scene_Internal_set_Void_Scene_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Void_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_ActivateAsync_Public_AsyncOperation_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
	}
}
