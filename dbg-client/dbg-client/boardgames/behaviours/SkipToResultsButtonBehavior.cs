using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace boardgames.behaviours
{
	// Token: 0x020002B2 RID: 690
	public class SkipToResultsButtonBehavior : MonoBehaviour
	{
		// Token: 0x060020A5 RID: 8357 RVA: 0x0008A48C File Offset: 0x0008868C
		// Note: this type is marked as 'beforefieldinit'.
		static SkipToResultsButtonBehavior()
		{
			Il2CppClassPointerStore<SkipToResultsButtonBehavior>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.behaviours", "SkipToResultsButtonBehavior");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkipToResultsButtonBehavior>.NativeClassPtr);
			SkipToResultsButtonBehavior.NativeFieldInfoPtr_OnReadyToSkip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkipToResultsButtonBehavior>.NativeClassPtr, "OnReadyToSkip");
			SkipToResultsButtonBehavior.NativeFieldInfoPtr_OnSkip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkipToResultsButtonBehavior>.NativeClassPtr, "OnSkip");
			SkipToResultsButtonBehavior.NativeFieldInfoPtr_skipValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkipToResultsButtonBehavior>.NativeClassPtr, "skipValid");
			SkipToResultsButtonBehavior.NativeFieldInfoPtr_skipTriggered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkipToResultsButtonBehavior>.NativeClassPtr, "skipTriggered");
			SkipToResultsButtonBehavior.NativeMethodInfoPtr_Event_SkipToResults_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipToResultsButtonBehavior>.NativeClassPtr, 100668719);
			SkipToResultsButtonBehavior.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipToResultsButtonBehavior>.NativeClassPtr, 100668720);
		}

		// Token: 0x060020A6 RID: 8358 RVA: 0x0008A534 File Offset: 0x00088734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542636, XrefRangeEnd = 542662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_SkipToResults()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkipToResultsButtonBehavior.NativeMethodInfoPtr_Event_SkipToResults_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x0008A570 File Offset: 0x00088770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542662, XrefRangeEnd = 542672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkipToResultsButtonBehavior()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkipToResultsButtonBehavior>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipToResultsButtonBehavior.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020A8 RID: 8360 RVA: 0x0001117C File Offset: 0x0000F37C
		public SkipToResultsButtonBehavior(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x060020A9 RID: 8361 RVA: 0x0008A5AC File Offset: 0x000887AC
		// (set) Token: 0x060020AA RID: 8362 RVA: 0x00011185 File Offset: 0x0000F385
		public unsafe UnityEvent OnReadyToSkip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipToResultsButtonBehavior.NativeFieldInfoPtr_OnReadyToSkip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipToResultsButtonBehavior.NativeFieldInfoPtr_OnReadyToSkip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x060020AB RID: 8363 RVA: 0x0008A5DC File Offset: 0x000887DC
		// (set) Token: 0x060020AC RID: 8364 RVA: 0x000111A4 File Offset: 0x0000F3A4
		public unsafe UnityEvent OnSkip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipToResultsButtonBehavior.NativeFieldInfoPtr_OnSkip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipToResultsButtonBehavior.NativeFieldInfoPtr_OnSkip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x060020AD RID: 8365 RVA: 0x0008A60C File Offset: 0x0008880C
		// (set) Token: 0x060020AE RID: 8366 RVA: 0x000111C3 File Offset: 0x0000F3C3
		public unsafe bool skipValid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipToResultsButtonBehavior.NativeFieldInfoPtr_skipValid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipToResultsButtonBehavior.NativeFieldInfoPtr_skipValid)) = value;
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x060020AF RID: 8367 RVA: 0x0008A634 File Offset: 0x00088834
		// (set) Token: 0x060020B0 RID: 8368 RVA: 0x000111DE File Offset: 0x0000F3DE
		public unsafe bool skipTriggered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipToResultsButtonBehavior.NativeFieldInfoPtr_skipTriggered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipToResultsButtonBehavior.NativeFieldInfoPtr_skipTriggered)) = value;
			}
		}

		// Token: 0x0400149B RID: 5275
		private static readonly IntPtr NativeFieldInfoPtr_OnReadyToSkip;

		// Token: 0x0400149C RID: 5276
		private static readonly IntPtr NativeFieldInfoPtr_OnSkip;

		// Token: 0x0400149D RID: 5277
		private static readonly IntPtr NativeFieldInfoPtr_skipValid;

		// Token: 0x0400149E RID: 5278
		private static readonly IntPtr NativeFieldInfoPtr_skipTriggered;

		// Token: 0x0400149F RID: 5279
		private static readonly IntPtr NativeMethodInfoPtr_Event_SkipToResults_Public_Virtual_New_Void_0;

		// Token: 0x040014A0 RID: 5280
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
