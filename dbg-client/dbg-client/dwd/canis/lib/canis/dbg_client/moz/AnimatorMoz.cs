using System;
using boardgames.moz;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

namespace dwd.canis.lib.canis.dbg_client.moz
{
	// Token: 0x02000052 RID: 82
	public class AnimatorMoz : BaseMoz
	{
		// Token: 0x0600032E RID: 814 RVA: 0x00027B20 File Offset: 0x00025D20
		// Note: this type is marked as 'beforefieldinit'.
		static AnimatorMoz()
		{
			Il2CppClassPointerStore<AnimatorMoz>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.lib.canis.dbg_client.moz", "AnimatorMoz");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorMoz>.NativeClassPtr);
			AnimatorMoz.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorMoz>.NativeClassPtr, "animator");
			AnimatorMoz.NativeFieldInfoPtr_mouseoverName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorMoz>.NativeClassPtr, "mouseoverName");
			AnimatorMoz.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorMoz>.NativeClassPtr, 100663806);
			AnimatorMoz.NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorMoz>.NativeClassPtr, 100663807);
			AnimatorMoz.NativeMethodInfoPtr_updateMoz_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorMoz>.NativeClassPtr, 100663808);
			AnimatorMoz.NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorMoz>.NativeClassPtr, 100663809);
			AnimatorMoz.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorMoz>.NativeClassPtr, 100663810);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00027BDC File Offset: 0x00025DDC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorMoz.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00027C10 File Offset: 0x00025E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499603, XrefRangeEnd = 499605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initMoz(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimatorMoz.NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00027C60 File Offset: 0x00025E60
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void updateMoz()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimatorMoz.NativeMethodInfoPtr_updateMoz_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00027C9C File Offset: 0x00025E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499605, XrefRangeEnd = 499607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void endMoz()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimatorMoz.NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00027CD8 File Offset: 0x00025ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499607, XrefRangeEnd = 499612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimatorMoz()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimatorMoz>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorMoz.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00003653 File Offset: 0x00001853
		public AnimatorMoz(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000335 RID: 821 RVA: 0x00027D14 File Offset: 0x00025F14
		// (set) Token: 0x06000336 RID: 822 RVA: 0x0000365C File Offset: 0x0000185C
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorMoz.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorMoz.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000337 RID: 823 RVA: 0x00027D44 File Offset: 0x00025F44
		// (set) Token: 0x06000338 RID: 824 RVA: 0x0000367B File Offset: 0x0000187B
		public unsafe string mouseoverName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorMoz.NativeFieldInfoPtr_mouseoverName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorMoz.NativeFieldInfoPtr_mouseoverName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeFieldInfoPtr_mouseoverName;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr_updateMoz_Protected_Virtual_Void_0;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
