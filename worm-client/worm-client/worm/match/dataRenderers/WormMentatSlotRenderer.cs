using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using voodoo;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x02000147 RID: 327
	public class WormMentatSlotRenderer : VersionedDataComponentObserver<WormMentatControllerData>
	{
		// Token: 0x06000EBA RID: 3770 RVA: 0x000446C0 File Offset: 0x000428C0
		// Note: this type is marked as 'beforefieldinit'.
		static WormMentatSlotRenderer()
		{
			Il2CppClassPointerStore<WormMentatSlotRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormMentatSlotRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMentatSlotRenderer>.NativeClassPtr);
			WormMentatSlotRenderer.NativeFieldInfoPtr_slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMentatSlotRenderer>.NativeClassPtr, "slot");
			WormMentatSlotRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMentatSlotRenderer>.NativeClassPtr, 100665282);
			WormMentatSlotRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMentatSlotRenderer>.NativeClassPtr, 100665283);
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x0004472C File Offset: 0x0004292C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706976, XrefRangeEnd = 706979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMentatSlotRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x00044768 File Offset: 0x00042968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706979, XrefRangeEnd = 706982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormMentatSlotRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMentatSlotRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMentatSlotRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x00009C43 File Offset: 0x00007E43
		public WormMentatSlotRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000EBE RID: 3774 RVA: 0x000447A4 File Offset: 0x000429A4
		// (set) Token: 0x06000EBF RID: 3775 RVA: 0x00009C4C File Offset: 0x00007E4C
		public unsafe GameObject slot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMentatSlotRenderer.NativeFieldInfoPtr_slot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMentatSlotRenderer.NativeFieldInfoPtr_slot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400087D RID: 2173
		private static readonly IntPtr NativeFieldInfoPtr_slot;

		// Token: 0x0400087E RID: 2174
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x0400087F RID: 2175
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
