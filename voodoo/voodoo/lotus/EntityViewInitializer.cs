using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace lotus
{
	// Token: 0x02000055 RID: 85
	public class EntityViewInitializer : MonoBehaviour
	{
		// Token: 0x06000515 RID: 1301 RVA: 0x00019FB4 File Offset: 0x000181B4
		// Note: this type is marked as 'beforefieldinit'.
		static EntityViewInitializer()
		{
			Il2CppClassPointerStore<EntityViewInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "EntityViewInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityViewInitializer>.NativeClassPtr);
			EntityViewInitializer.NativeFieldInfoPtr_views = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityViewInitializer>.NativeClassPtr, "views");
			EntityViewInitializer.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityViewInitializer>.NativeClassPtr, 100663917);
			EntityViewInitializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityViewInitializer>.NativeClassPtr, 100663918);
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0001A020 File Offset: 0x00018220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111260, XrefRangeEnd = 1111284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityViewInitializer.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x0001A054 File Offset: 0x00018254
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityViewInitializer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityViewInitializer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityViewInitializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00004875 File Offset: 0x00002A75
		public EntityViewInitializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x0001A090 File Offset: 0x00018290
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x0000487E File Offset: 0x00002A7E
		public unsafe List<EntityView> views
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityViewInitializer.NativeFieldInfoPtr_views);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityView>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityViewInitializer.NativeFieldInfoPtr_views), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeFieldInfoPtr_views;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
