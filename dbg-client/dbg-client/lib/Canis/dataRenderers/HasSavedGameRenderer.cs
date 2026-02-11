using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace lib.canis.dataRenderers
{
	// Token: 0x0200002F RID: 47
	public class HasSavedGameRenderer : VersionedSubscriber<SerializedMatchComponent>
	{
		// Token: 0x060001BF RID: 447 RVA: 0x000232E0 File Offset: 0x000214E0
		// Note: this type is marked as 'beforefieldinit'.
		static HasSavedGameRenderer()
		{
			Il2CppClassPointerStore<HasSavedGameRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lib.canis.dataRenderers", "HasSavedGameRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasSavedGameRenderer>.NativeClassPtr);
			HasSavedGameRenderer.NativeFieldInfoPtr_hasSavedGameIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasSavedGameRenderer>.NativeClassPtr, "hasSavedGameIcon");
			HasSavedGameRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasSavedGameRenderer>.NativeClassPtr, 100663594);
			HasSavedGameRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasSavedGameRenderer>.NativeClassPtr, 100663595);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0002334C File Offset: 0x0002154C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497868, XrefRangeEnd = 497875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HasSavedGameRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00023388 File Offset: 0x00021588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497875, XrefRangeEnd = 497878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HasSavedGameRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasSavedGameRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasSavedGameRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002BA5 File Offset: 0x00000DA5
		public HasSavedGameRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x000233C4 File Offset: 0x000215C4
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x00002BAE File Offset: 0x00000DAE
		public unsafe GameObject hasSavedGameIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasSavedGameRenderer.NativeFieldInfoPtr_hasSavedGameIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasSavedGameRenderer.NativeFieldInfoPtr_hasSavedGameIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeFieldInfoPtr_hasSavedGameIcon;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
