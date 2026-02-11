using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001D7 RID: 471
	public class WormCardDropEffects : MonoBehaviour
	{
		// Token: 0x060014D3 RID: 5331 RVA: 0x000575A8 File Offset: 0x000557A8
		// Note: this type is marked as 'beforefieldinit'.
		static WormCardDropEffects()
		{
			Il2CppClassPointerStore<WormCardDropEffects>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormCardDropEffects");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCardDropEffects>.NativeClassPtr);
			WormCardDropEffects.NativeFieldInfoPtr_trashEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCardDropEffects>.NativeClassPtr, "trashEffect");
			WormCardDropEffects.NativeFieldInfoPtr_discardEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCardDropEffects>.NativeClassPtr, "discardEffect");
			WormCardDropEffects.NativeFieldInfoPtr_purchaseEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCardDropEffects>.NativeClassPtr, "purchaseEffect");
			WormCardDropEffects.NativeMethodInfoPtr_Event_SpawnTrashEffect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCardDropEffects>.NativeClassPtr, 100666153);
			WormCardDropEffects.NativeMethodInfoPtr_Event_SpawnDiscardEffect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCardDropEffects>.NativeClassPtr, 100666154);
			WormCardDropEffects.NativeMethodInfoPtr_Event_SpawnPurchaseEffect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCardDropEffects>.NativeClassPtr, 100666155);
			WormCardDropEffects.NativeMethodInfoPtr_SpawnEffect_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCardDropEffects>.NativeClassPtr, 100666156);
			WormCardDropEffects.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCardDropEffects>.NativeClassPtr, 100666157);
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x00057678 File Offset: 0x00055878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714519, XrefRangeEnd = 714520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SpawnTrashEffect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCardDropEffects.NativeMethodInfoPtr_Event_SpawnTrashEffect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x000576AC File Offset: 0x000558AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714520, XrefRangeEnd = 714521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SpawnDiscardEffect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCardDropEffects.NativeMethodInfoPtr_Event_SpawnDiscardEffect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x000576E0 File Offset: 0x000558E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714521, XrefRangeEnd = 714522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SpawnPurchaseEffect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCardDropEffects.NativeMethodInfoPtr_Event_SpawnPurchaseEffect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x00057714 File Offset: 0x00055914
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 714534, RefRangeEnd = 714537, XrefRangeStart = 714522, XrefRangeEnd = 714534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnEffect(GameObject effectRoot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(effectRoot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCardDropEffects.NativeMethodInfoPtr_SpawnEffect_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x00057758 File Offset: 0x00055958
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormCardDropEffects()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCardDropEffects>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCardDropEffects.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x0000CB83 File Offset: 0x0000AD83
		public WormCardDropEffects(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x060014DA RID: 5338 RVA: 0x00057794 File Offset: 0x00055994
		// (set) Token: 0x060014DB RID: 5339 RVA: 0x0000CB8C File Offset: 0x0000AD8C
		public unsafe GameObject trashEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardDropEffects.NativeFieldInfoPtr_trashEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardDropEffects.NativeFieldInfoPtr_trashEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x060014DC RID: 5340 RVA: 0x000577C4 File Offset: 0x000559C4
		// (set) Token: 0x060014DD RID: 5341 RVA: 0x0000CBAB File Offset: 0x0000ADAB
		public unsafe GameObject discardEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardDropEffects.NativeFieldInfoPtr_discardEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardDropEffects.NativeFieldInfoPtr_discardEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x060014DE RID: 5342 RVA: 0x000577F4 File Offset: 0x000559F4
		// (set) Token: 0x060014DF RID: 5343 RVA: 0x0000CBCA File Offset: 0x0000ADCA
		public unsafe GameObject purchaseEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardDropEffects.NativeFieldInfoPtr_purchaseEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardDropEffects.NativeFieldInfoPtr_purchaseEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C13 RID: 3091
		private static readonly IntPtr NativeFieldInfoPtr_trashEffect;

		// Token: 0x04000C14 RID: 3092
		private static readonly IntPtr NativeFieldInfoPtr_discardEffect;

		// Token: 0x04000C15 RID: 3093
		private static readonly IntPtr NativeFieldInfoPtr_purchaseEffect;

		// Token: 0x04000C16 RID: 3094
		private static readonly IntPtr NativeMethodInfoPtr_Event_SpawnTrashEffect_Public_Void_0;

		// Token: 0x04000C17 RID: 3095
		private static readonly IntPtr NativeMethodInfoPtr_Event_SpawnDiscardEffect_Public_Void_0;

		// Token: 0x04000C18 RID: 3096
		private static readonly IntPtr NativeMethodInfoPtr_Event_SpawnPurchaseEffect_Public_Void_0;

		// Token: 0x04000C19 RID: 3097
		private static readonly IntPtr NativeMethodInfoPtr_SpawnEffect_Private_Void_GameObject_0;

		// Token: 0x04000C1A RID: 3098
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
