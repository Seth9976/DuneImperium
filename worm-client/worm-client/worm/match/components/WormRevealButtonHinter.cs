using System;
using boardgames.match.selection;
using Canis.utils.ids;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x0200020C RID: 524
	public class WormRevealButtonHinter : VersionedView<DBGSelectionResponder>
	{
		// Token: 0x06001734 RID: 5940 RVA: 0x0005E740 File Offset: 0x0005C940
		// Note: this type is marked as 'beforefieldinit'.
		static WormRevealButtonHinter()
		{
			Il2CppClassPointerStore<WormRevealButtonHinter>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormRevealButtonHinter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormRevealButtonHinter>.NativeClassPtr);
			WormRevealButtonHinter.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealButtonHinter>.NativeClassPtr, "animator");
			WormRevealButtonHinter.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealButtonHinter>.NativeClassPtr, "entities");
			WormRevealButtonHinter.NativeFieldInfoPtr_HintParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealButtonHinter>.NativeClassPtr, "HintParam");
			WormRevealButtonHinter.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealButtonHinter>.NativeClassPtr, 100666518);
			WormRevealButtonHinter.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealButtonHinter>.NativeClassPtr, 100666519);
			WormRevealButtonHinter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealButtonHinter>.NativeClassPtr, 100666520);
			WormRevealButtonHinter.NativeMethodInfoPtr__dirtyUpdate_b__4_0_Private_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealButtonHinter>.NativeClassPtr, 100666522);
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x0005E7FC File Offset: 0x0005C9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717217, XrefRangeEnd = 717233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormRevealButtonHinter.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x0005E838 File Offset: 0x0005CA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717233, XrefRangeEnd = 717256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormRevealButtonHinter.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x0005E874 File Offset: 0x0005CA74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717256, XrefRangeEnd = 717259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormRevealButtonHinter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormRevealButtonHinter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealButtonHinter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x0005E8B0 File Offset: 0x0005CAB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717259, XrefRangeEnd = 717260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _dirtyUpdate_b__4_0(EntityID s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealButtonHinter.NativeMethodInfoPtr__dirtyUpdate_b__4_0_Private_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x0000DE9E File Offset: 0x0000C09E
		public WormRevealButtonHinter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x0600173A RID: 5946 RVA: 0x0005E900 File Offset: 0x0005CB00
		// (set) Token: 0x0600173B RID: 5947 RVA: 0x0000DEA7 File Offset: 0x0000C0A7
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealButtonHinter.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealButtonHinter.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x0600173C RID: 5948 RVA: 0x0005E930 File Offset: 0x0005CB30
		// (set) Token: 0x0600173D RID: 5949 RVA: 0x0000DEC6 File Offset: 0x0000C0C6
		public unsafe Entities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealButtonHinter.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealButtonHinter.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x0600173E RID: 5950 RVA: 0x0005E960 File Offset: 0x0005CB60
		// (set) Token: 0x0600173F RID: 5951 RVA: 0x0000DEE5 File Offset: 0x0000C0E5
		public unsafe static int HintParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormRevealButtonHinter.NativeFieldInfoPtr_HintParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormRevealButtonHinter.NativeFieldInfoPtr_HintParam, (void*)(&value));
			}
		}

		// Token: 0x04000D76 RID: 3446
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x04000D77 RID: 3447
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x04000D78 RID: 3448
		private static readonly IntPtr NativeFieldInfoPtr_HintParam;

		// Token: 0x04000D79 RID: 3449
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000D7A RID: 3450
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000D7B RID: 3451
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000D7C RID: 3452
		private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__4_0_Private_Boolean_EntityID_0;
	}
}
