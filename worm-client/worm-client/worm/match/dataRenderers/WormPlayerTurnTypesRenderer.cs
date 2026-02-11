using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using voodoo;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x02000152 RID: 338
	public class WormPlayerTurnTypesRenderer : VersionedDataComponentObserver<WormPlayerTurnTypesData>
	{
		// Token: 0x06000F1C RID: 3868 RVA: 0x00045894 File Offset: 0x00043A94
		// Note: this type is marked as 'beforefieldinit'.
		static WormPlayerTurnTypesRenderer()
		{
			Il2CppClassPointerStore<WormPlayerTurnTypesRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormPlayerTurnTypesRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerTurnTypesRenderer>.NativeClassPtr);
			WormPlayerTurnTypesRenderer.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerTurnTypesRenderer>.NativeClassPtr, "animator");
			WormPlayerTurnTypesRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerTurnTypesRenderer>.NativeClassPtr, 100665338);
			WormPlayerTurnTypesRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerTurnTypesRenderer>.NativeClassPtr, 100665339);
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x00045900 File Offset: 0x00043B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707376, XrefRangeEnd = 707400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayerTurnTypesRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x0004593C File Offset: 0x00043B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707400, XrefRangeEnd = 707403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayerTurnTypesRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerTurnTypesRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerTurnTypesRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x00009F37 File Offset: 0x00008137
		public WormPlayerTurnTypesRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000F20 RID: 3872 RVA: 0x00045978 File Offset: 0x00043B78
		// (set) Token: 0x06000F21 RID: 3873 RVA: 0x00009F40 File Offset: 0x00008140
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerTurnTypesRenderer.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerTurnTypesRenderer.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008B3 RID: 2227
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x040008B4 RID: 2228
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x040008B5 RID: 2229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
