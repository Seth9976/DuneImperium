using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.input
{
	// Token: 0x02000130 RID: 304
	public class ClickFXAnimator : MonoBehaviour
	{
		// Token: 0x06000D74 RID: 3444 RVA: 0x000480F8 File Offset: 0x000462F8
		// Note: this type is marked as 'beforefieldinit'.
		static ClickFXAnimator()
		{
			Il2CppClassPointerStore<ClickFXAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.input", "ClickFXAnimator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClickFXAnimator>.NativeClassPtr);
			ClickFXAnimator.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickFXAnimator>.NativeClassPtr, "animator");
			ClickFXAnimator.NativeFieldInfoPtr_tickleClickParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickFXAnimator>.NativeClassPtr, "tickleClickParam");
			ClickFXAnimator.NativeFieldInfoPtr_selectClickParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickFXAnimator>.NativeClassPtr, "selectClickParam");
			ClickFXAnimator.NativeMethodInfoPtr_HandleClickEvent_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickFXAnimator>.NativeClassPtr, 100665249);
			ClickFXAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickFXAnimator>.NativeClassPtr, 100665250);
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x0004818C File Offset: 0x0004638C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510816, XrefRangeEnd = 510819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleClickEvent(bool wasSelection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref wasSelection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickFXAnimator.NativeMethodInfoPtr_HandleClickEvent_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x000481CC File Offset: 0x000463CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510819, XrefRangeEnd = 510825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClickFXAnimator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClickFXAnimator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickFXAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x000087FD File Offset: 0x000069FD
		public ClickFXAnimator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000D78 RID: 3448 RVA: 0x00048208 File Offset: 0x00046408
		// (set) Token: 0x06000D79 RID: 3449 RVA: 0x00008806 File Offset: 0x00006A06
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickFXAnimator.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickFXAnimator.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000D7A RID: 3450 RVA: 0x00048238 File Offset: 0x00046438
		// (set) Token: 0x06000D7B RID: 3451 RVA: 0x00008825 File Offset: 0x00006A25
		public unsafe string tickleClickParam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickFXAnimator.NativeFieldInfoPtr_tickleClickParam);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickFXAnimator.NativeFieldInfoPtr_tickleClickParam), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000D7C RID: 3452 RVA: 0x00048260 File Offset: 0x00046460
		// (set) Token: 0x06000D7D RID: 3453 RVA: 0x00008844 File Offset: 0x00006A44
		public unsafe string selectClickParam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickFXAnimator.NativeFieldInfoPtr_selectClickParam);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickFXAnimator.NativeFieldInfoPtr_selectClickParam), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeFieldInfoPtr_tickleClickParam;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeFieldInfoPtr_selectClickParam;

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeMethodInfoPtr_HandleClickEvent_Public_Void_Boolean_0;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
