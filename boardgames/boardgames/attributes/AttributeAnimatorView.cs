using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.attributes
{
	// Token: 0x0200015C RID: 348
	public class AttributeAnimatorView : AttributeView
	{
		// Token: 0x060011AC RID: 4524 RVA: 0x00047620 File Offset: 0x00045820
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeAnimatorView()
		{
			Il2CppClassPointerStore<AttributeAnimatorView>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.attributes", "AttributeAnimatorView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeAnimatorView>.NativeClassPtr);
			AttributeAnimatorView.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeAnimatorView>.NativeClassPtr, "animator");
			AttributeAnimatorView.NativeFieldInfoPtr_animParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeAnimatorView>.NativeClassPtr, "animParam");
			AttributeAnimatorView.NativeFieldInfoPtr_isTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeAnimatorView>.NativeClassPtr, "isTrigger");
			AttributeAnimatorView.NativeFieldInfoPtr_invert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeAnimatorView>.NativeClassPtr, "invert");
			AttributeAnimatorView.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeAnimatorView>.NativeClassPtr, 100665908);
			AttributeAnimatorView.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeAnimatorView>.NativeClassPtr, 100665909);
			AttributeAnimatorView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeAnimatorView>.NativeClassPtr, 100665910);
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x000476DC File Offset: 0x000458DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000339, XrefRangeEnd = 1000348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeAnimatorView.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x00047718 File Offset: 0x00045918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000348, XrefRangeEnd = 1000366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeAnimatorView.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x00047754 File Offset: 0x00045954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000366, XrefRangeEnd = 1000373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeAnimatorView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeAnimatorView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeAnimatorView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x0000A3E0 File Offset: 0x000085E0
		public AttributeAnimatorView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x060011B1 RID: 4529 RVA: 0x00047790 File Offset: 0x00045990
		// (set) Token: 0x060011B2 RID: 4530 RVA: 0x0000A3E9 File Offset: 0x000085E9
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeAnimatorView.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeAnimatorView.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x060011B3 RID: 4531 RVA: 0x000477C0 File Offset: 0x000459C0
		// (set) Token: 0x060011B4 RID: 4532 RVA: 0x0000A408 File Offset: 0x00008608
		public unsafe string animParam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeAnimatorView.NativeFieldInfoPtr_animParam);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeAnimatorView.NativeFieldInfoPtr_animParam), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x060011B5 RID: 4533 RVA: 0x000477E8 File Offset: 0x000459E8
		// (set) Token: 0x060011B6 RID: 4534 RVA: 0x0000A427 File Offset: 0x00008627
		public unsafe bool isTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeAnimatorView.NativeFieldInfoPtr_isTrigger);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeAnimatorView.NativeFieldInfoPtr_isTrigger)) = value;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x060011B7 RID: 4535 RVA: 0x00047810 File Offset: 0x00045A10
		// (set) Token: 0x060011B8 RID: 4536 RVA: 0x0000A442 File Offset: 0x00008642
		public unsafe bool invert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeAnimatorView.NativeFieldInfoPtr_invert);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeAnimatorView.NativeFieldInfoPtr_invert)) = value;
			}
		}

		// Token: 0x04000AC0 RID: 2752
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x04000AC1 RID: 2753
		private static readonly IntPtr NativeFieldInfoPtr_animParam;

		// Token: 0x04000AC2 RID: 2754
		private static readonly IntPtr NativeFieldInfoPtr_isTrigger;

		// Token: 0x04000AC3 RID: 2755
		private static readonly IntPtr NativeFieldInfoPtr_invert;

		// Token: 0x04000AC4 RID: 2756
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000AC5 RID: 2757
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000AC6 RID: 2758
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
