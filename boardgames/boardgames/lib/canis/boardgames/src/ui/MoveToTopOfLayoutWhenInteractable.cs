using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace lib.canis.boardgames.src.ui
{
	// Token: 0x02000035 RID: 53
	public class MoveToTopOfLayoutWhenInteractable : MonoBehaviour
	{
		// Token: 0x0600023A RID: 570 RVA: 0x000181C4 File Offset: 0x000163C4
		// Note: this type is marked as 'beforefieldinit'.
		static MoveToTopOfLayoutWhenInteractable()
		{
			Il2CppClassPointerStore<MoveToTopOfLayoutWhenInteractable>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lib.canis.boardgames.src.ui", "MoveToTopOfLayoutWhenInteractable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveToTopOfLayoutWhenInteractable>.NativeClassPtr);
			MoveToTopOfLayoutWhenInteractable.NativeFieldInfoPtr_Reverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveToTopOfLayoutWhenInteractable>.NativeClassPtr, "Reverse");
			MoveToTopOfLayoutWhenInteractable.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveToTopOfLayoutWhenInteractable>.NativeClassPtr, "button");
			MoveToTopOfLayoutWhenInteractable.NativeFieldInfoPtr_cachedInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveToTopOfLayoutWhenInteractable>.NativeClassPtr, "cachedInteractable");
			MoveToTopOfLayoutWhenInteractable.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveToTopOfLayoutWhenInteractable>.NativeClassPtr, 100663717);
			MoveToTopOfLayoutWhenInteractable.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveToTopOfLayoutWhenInteractable>.NativeClassPtr, 100663718);
			MoveToTopOfLayoutWhenInteractable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveToTopOfLayoutWhenInteractable>.NativeClassPtr, 100663719);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0001826C File Offset: 0x0001646C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984780, XrefRangeEnd = 984784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveToTopOfLayoutWhenInteractable.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x000182A0 File Offset: 0x000164A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984784, XrefRangeEnd = 984786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveToTopOfLayoutWhenInteractable.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x000182D4 File Offset: 0x000164D4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoveToTopOfLayoutWhenInteractable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveToTopOfLayoutWhenInteractable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveToTopOfLayoutWhenInteractable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002F6B File Offset: 0x0000116B
		public MoveToTopOfLayoutWhenInteractable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600023F RID: 575 RVA: 0x00018310 File Offset: 0x00016510
		// (set) Token: 0x06000240 RID: 576 RVA: 0x00002F74 File Offset: 0x00001174
		public unsafe bool Reverse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveToTopOfLayoutWhenInteractable.NativeFieldInfoPtr_Reverse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveToTopOfLayoutWhenInteractable.NativeFieldInfoPtr_Reverse)) = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00018338 File Offset: 0x00016538
		// (set) Token: 0x06000242 RID: 578 RVA: 0x00002F8F File Offset: 0x0000118F
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveToTopOfLayoutWhenInteractable.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveToTopOfLayoutWhenInteractable.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00018368 File Offset: 0x00016568
		// (set) Token: 0x06000244 RID: 580 RVA: 0x00002FAE File Offset: 0x000011AE
		public unsafe bool cachedInteractable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveToTopOfLayoutWhenInteractable.NativeFieldInfoPtr_cachedInteractable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveToTopOfLayoutWhenInteractable.NativeFieldInfoPtr_cachedInteractable)) = value;
			}
		}

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeFieldInfoPtr_Reverse;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeFieldInfoPtr_cachedInteractable;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
