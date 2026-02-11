using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x02000206 RID: 518
	public class WormMenuButtons : MonoBehaviour
	{
		// Token: 0x060016EB RID: 5867 RVA: 0x0005D9A0 File Offset: 0x0005BBA0
		// Note: this type is marked as 'beforefieldinit'.
		static WormMenuButtons()
		{
			Il2CppClassPointerStore<WormMenuButtons>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormMenuButtons");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMenuButtons>.NativeClassPtr);
			WormMenuButtons.NativeFieldInfoPtr_disableOnLeaderSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMenuButtons>.NativeClassPtr, "disableOnLeaderSelection");
			WormMenuButtons.NativeFieldInfoPtr_disableOnGameResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMenuButtons>.NativeClassPtr, "disableOnGameResults");
			WormMenuButtons.NativeMethodInfoPtr_SetOnLeaderSelection_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMenuButtons>.NativeClassPtr, 100666481);
			WormMenuButtons.NativeMethodInfoPtr_SetOnGameResults_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMenuButtons>.NativeClassPtr, 100666482);
			WormMenuButtons.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMenuButtons>.NativeClassPtr, 100666483);
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x0005DA34 File Offset: 0x0005BC34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 716972, RefRangeEnd = 716974, XrefRangeStart = 716970, XrefRangeEnd = 716972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOnLeaderSelection(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref on;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMenuButtons.NativeMethodInfoPtr_SetOnLeaderSelection_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x0005DA74 File Offset: 0x0005BC74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 716976, RefRangeEnd = 716977, XrefRangeStart = 716974, XrefRangeEnd = 716976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOnGameResults(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref on;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMenuButtons.NativeMethodInfoPtr_SetOnGameResults_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x0005DAB4 File Offset: 0x0005BCB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716977, XrefRangeEnd = 716985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormMenuButtons()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMenuButtons>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMenuButtons.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x0000DC42 File Offset: 0x0000BE42
		public WormMenuButtons(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x060016F0 RID: 5872 RVA: 0x0005DAF0 File Offset: 0x0005BCF0
		// (set) Token: 0x060016F1 RID: 5873 RVA: 0x0000DC4B File Offset: 0x0000BE4B
		public unsafe Il2CppReferenceArray<GameObject> disableOnLeaderSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMenuButtons.NativeFieldInfoPtr_disableOnLeaderSelection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMenuButtons.NativeFieldInfoPtr_disableOnLeaderSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x060016F2 RID: 5874 RVA: 0x0005DB20 File Offset: 0x0005BD20
		// (set) Token: 0x060016F3 RID: 5875 RVA: 0x0000DC6A File Offset: 0x0000BE6A
		public unsafe Il2CppReferenceArray<GameObject> disableOnGameResults
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMenuButtons.NativeFieldInfoPtr_disableOnGameResults);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMenuButtons.NativeFieldInfoPtr_disableOnGameResults), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D4B RID: 3403
		private static readonly IntPtr NativeFieldInfoPtr_disableOnLeaderSelection;

		// Token: 0x04000D4C RID: 3404
		private static readonly IntPtr NativeFieldInfoPtr_disableOnGameResults;

		// Token: 0x04000D4D RID: 3405
		private static readonly IntPtr NativeMethodInfoPtr_SetOnLeaderSelection_Public_Void_Boolean_0;

		// Token: 0x04000D4E RID: 3406
		private static readonly IntPtr NativeMethodInfoPtr_SetOnGameResults_Public_Void_Boolean_0;

		// Token: 0x04000D4F RID: 3407
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
