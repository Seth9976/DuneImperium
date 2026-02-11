using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;
using voodoo;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x02000164 RID: 356
	public class WormSpiceCostRenderer : VersionedDataComponentObserver<WormSpiceCostData>
	{
		// Token: 0x06000FEF RID: 4079 RVA: 0x00047F60 File Offset: 0x00046160
		// Note: this type is marked as 'beforefieldinit'.
		static WormSpiceCostRenderer()
		{
			Il2CppClassPointerStore<WormSpiceCostRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormSpiceCostRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSpiceCostRenderer>.NativeClassPtr);
			WormSpiceCostRenderer.NativeFieldInfoPtr_showDefaultCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpiceCostRenderer>.NativeClassPtr, "showDefaultCost");
			WormSpiceCostRenderer.NativeFieldInfoPtr_showReducedCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpiceCostRenderer>.NativeClassPtr, "showReducedCost");
			WormSpiceCostRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpiceCostRenderer>.NativeClassPtr, 100665468);
			WormSpiceCostRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpiceCostRenderer>.NativeClassPtr, 100665469);
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x00047FE0 File Offset: 0x000461E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708830, XrefRangeEnd = 708839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSpiceCostRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x0004801C File Offset: 0x0004621C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708839, XrefRangeEnd = 708854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSpiceCostRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSpiceCostRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpiceCostRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x0000A628 File Offset: 0x00008828
		public WormSpiceCostRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x00048058 File Offset: 0x00046258
		// (set) Token: 0x06000FF4 RID: 4084 RVA: 0x0000A631 File Offset: 0x00008831
		public unsafe UnityEvent<string> showDefaultCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpiceCostRenderer.NativeFieldInfoPtr_showDefaultCost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpiceCostRenderer.NativeFieldInfoPtr_showDefaultCost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000FF5 RID: 4085 RVA: 0x00048088 File Offset: 0x00046288
		// (set) Token: 0x06000FF6 RID: 4086 RVA: 0x0000A650 File Offset: 0x00008850
		public unsafe UnityEvent<string> showReducedCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpiceCostRenderer.NativeFieldInfoPtr_showReducedCost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpiceCostRenderer.NativeFieldInfoPtr_showReducedCost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400092C RID: 2348
		private static readonly IntPtr NativeFieldInfoPtr_showDefaultCost;

		// Token: 0x0400092D RID: 2349
		private static readonly IntPtr NativeFieldInfoPtr_showReducedCost;

		// Token: 0x0400092E RID: 2350
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x0400092F RID: 2351
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
