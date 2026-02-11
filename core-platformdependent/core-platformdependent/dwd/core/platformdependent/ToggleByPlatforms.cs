using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.platformdependent
{
	// Token: 0x0200002A RID: 42
	public class ToggleByPlatforms : MonoBehaviour
	{
		// Token: 0x0600015F RID: 351 RVA: 0x00007200 File Offset: 0x00005400
		// Note: this type is marked as 'beforefieldinit'.
		static ToggleByPlatforms()
		{
			Il2CppClassPointerStore<ToggleByPlatforms>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core.platformdependent", "ToggleByPlatforms");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleByPlatforms>.NativeClassPtr);
			ToggleByPlatforms.NativeFieldInfoPtr_platforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleByPlatforms>.NativeClassPtr, "platforms");
			ToggleByPlatforms.NativeFieldInfoPtr_enabledObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleByPlatforms>.NativeClassPtr, "enabledObject");
			ToggleByPlatforms.NativeFieldInfoPtr_disableInstead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleByPlatforms>.NativeClassPtr, "disableInstead");
			ToggleByPlatforms.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleByPlatforms>.NativeClassPtr, 100663457);
			ToggleByPlatforms.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleByPlatforms>.NativeClassPtr, 100663458);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00007294 File Offset: 0x00005494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239881, XrefRangeEnd = 1239890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleByPlatforms.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x000072C8 File Offset: 0x000054C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239890, XrefRangeEnd = 1239898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToggleByPlatforms()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleByPlatforms>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleByPlatforms.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002A39 File Offset: 0x00000C39
		public ToggleByPlatforms(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00007304 File Offset: 0x00005504
		// (set) Token: 0x06000164 RID: 356 RVA: 0x00002A42 File Offset: 0x00000C42
		public unsafe List<RuntimePlatform> platforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleByPlatforms.NativeFieldInfoPtr_platforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RuntimePlatform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleByPlatforms.NativeFieldInfoPtr_platforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00007334 File Offset: 0x00005534
		// (set) Token: 0x06000166 RID: 358 RVA: 0x00002A61 File Offset: 0x00000C61
		public unsafe GameObject enabledObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleByPlatforms.NativeFieldInfoPtr_enabledObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleByPlatforms.NativeFieldInfoPtr_enabledObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00007364 File Offset: 0x00005564
		// (set) Token: 0x06000168 RID: 360 RVA: 0x00002A80 File Offset: 0x00000C80
		public unsafe bool disableInstead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleByPlatforms.NativeFieldInfoPtr_disableInstead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleByPlatforms.NativeFieldInfoPtr_disableInstead)) = value;
			}
		}

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeFieldInfoPtr_platforms;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeFieldInfoPtr_enabledObject;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeFieldInfoPtr_disableInstead;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
