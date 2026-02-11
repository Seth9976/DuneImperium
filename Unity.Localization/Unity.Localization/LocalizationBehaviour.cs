using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.Localization
{
	// Token: 0x0200001C RID: 28
	public class LocalizationBehaviour : ComponentSingleton<LocalizationBehaviour>
	{
		// Token: 0x0600017F RID: 383 RVA: 0x0000EC58 File Offset: 0x0000CE58
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizationBehaviour()
		{
			Il2CppClassPointerStore<LocalizationBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization", "LocalizationBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizationBehaviour>.NativeClassPtr);
			LocalizationBehaviour.NativeFieldInfoPtr_m_ReleaseQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationBehaviour>.NativeClassPtr, "m_ReleaseQueue");
			LocalizationBehaviour.NativeFieldInfoPtr_k_MaxMsPerUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationBehaviour>.NativeClassPtr, "k_MaxMsPerUpdate");
			LocalizationBehaviour.NativeFieldInfoPtr_k_DisableThrottling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationBehaviour>.NativeClassPtr, "k_DisableThrottling");
			LocalizationBehaviour.NativeMethodInfoPtr_GetGameObjectName_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationBehaviour>.NativeClassPtr, 100663577);
			LocalizationBehaviour.NativeMethodInfoPtr_ReleaseNextFrame_Public_Static_Void_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationBehaviour>.NativeClassPtr, 100663578);
			LocalizationBehaviour.NativeMethodInfoPtr_TimeSinceStartupMs_Private_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationBehaviour>.NativeClassPtr, 100663579);
			LocalizationBehaviour.NativeMethodInfoPtr_DoReleaseNextFrame_Private_Void_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationBehaviour>.NativeClassPtr, 100663580);
			LocalizationBehaviour.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationBehaviour>.NativeClassPtr, 100663581);
			LocalizationBehaviour.NativeMethodInfoPtr_ForceRelease_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationBehaviour>.NativeClassPtr, 100663582);
			LocalizationBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationBehaviour>.NativeClassPtr, 100663583);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000ED50 File Offset: 0x0000CF50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066453, XrefRangeEnd = 1066455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetGameObjectName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizationBehaviour.NativeMethodInfoPtr_GetGameObjectName_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0000ED94 File Offset: 0x0000CF94
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1066466, RefRangeEnd = 1066469, XrefRangeStart = 1066455, XrefRangeEnd = 1066466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseNextFrame(AsyncOperationHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationBehaviour.NativeMethodInfoPtr_ReleaseNextFrame_Public_Static_Void_AsyncOperationHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000EDD0 File Offset: 0x0000CFD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long TimeSinceStartupMs()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationBehaviour.NativeMethodInfoPtr_TimeSinceStartupMs_Private_Static_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000EE00 File Offset: 0x0000D000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066469, XrefRangeEnd = 1066477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoReleaseNextFrame(AsyncOperationHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationBehaviour.NativeMethodInfoPtr_DoReleaseNextFrame_Private_Void_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000EE48 File Offset: 0x0000D048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066477, XrefRangeEnd = 1066491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationBehaviour.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0000EE7C File Offset: 0x0000D07C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066491, XrefRangeEnd = 1066517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ForceRelease()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationBehaviour.NativeMethodInfoPtr_ForceRelease_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0000EEA4 File Offset: 0x0000D0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066517, XrefRangeEnd = 1066527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizationBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizationBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000029E7 File Offset: 0x00000BE7
		public LocalizationBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000188 RID: 392 RVA: 0x0000EEE0 File Offset: 0x0000D0E0
		// (set) Token: 0x06000189 RID: 393 RVA: 0x000029F0 File Offset: 0x00000BF0
		public unsafe Queue<ValueTuple<int, AsyncOperationHandle>> m_ReleaseQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationBehaviour.NativeFieldInfoPtr_m_ReleaseQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<ValueTuple<int, AsyncOperationHandle>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationBehaviour.NativeFieldInfoPtr_m_ReleaseQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600018A RID: 394 RVA: 0x0000EF10 File Offset: 0x0000D110
		// (set) Token: 0x0600018B RID: 395 RVA: 0x00002A0F File Offset: 0x00000C0F
		public unsafe static long k_MaxMsPerUpdate
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(LocalizationBehaviour.NativeFieldInfoPtr_k_MaxMsPerUpdate, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalizationBehaviour.NativeFieldInfoPtr_k_MaxMsPerUpdate, (void*)(&value));
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600018C RID: 396 RVA: 0x0000EF2C File Offset: 0x0000D12C
		// (set) Token: 0x0600018D RID: 397 RVA: 0x00002A1D File Offset: 0x00000C1D
		public unsafe static bool k_DisableThrottling
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(LocalizationBehaviour.NativeFieldInfoPtr_k_DisableThrottling, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalizationBehaviour.NativeFieldInfoPtr_k_DisableThrottling, (void*)(&value));
			}
		}

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeFieldInfoPtr_m_ReleaseQueue;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeFieldInfoPtr_k_MaxMsPerUpdate;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeFieldInfoPtr_k_DisableThrottling;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_GetGameObjectName_Protected_Virtual_String_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseNextFrame_Public_Static_Void_AsyncOperationHandle_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_TimeSinceStartupMs_Private_Static_Int64_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_DoReleaseNextFrame_Private_Void_AsyncOperationHandle_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_ForceRelease_Public_Static_Void_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
