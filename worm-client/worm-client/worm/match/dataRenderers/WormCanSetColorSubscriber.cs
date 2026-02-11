using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Events;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x020000FF RID: 255
	public class WormCanSetColorSubscriber : VersionedSubscriber<WormCanSetColorData>
	{
		// Token: 0x06000B62 RID: 2914 RVA: 0x0003A9BC File Offset: 0x00038BBC
		// Note: this type is marked as 'beforefieldinit'.
		static WormCanSetColorSubscriber()
		{
			Il2CppClassPointerStore<WormCanSetColorSubscriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormCanSetColorSubscriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCanSetColorSubscriber>.NativeClassPtr);
			WormCanSetColorSubscriber.NativeFieldInfoPtr_onCanSetColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCanSetColorSubscriber>.NativeClassPtr, "onCanSetColor");
			WormCanSetColorSubscriber.NativeFieldInfoPtr_onCannotSetColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCanSetColorSubscriber>.NativeClassPtr, "onCannotSetColor");
			WormCanSetColorSubscriber.NativeFieldInfoPtr_cachedCanSetColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCanSetColorSubscriber>.NativeClassPtr, "cachedCanSetColor");
			WormCanSetColorSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCanSetColorSubscriber>.NativeClassPtr, 100664868);
			WormCanSetColorSubscriber.NativeMethodInfoPtr_ResetColor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCanSetColorSubscriber>.NativeClassPtr, 100664869);
			WormCanSetColorSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCanSetColorSubscriber>.NativeClassPtr, 100664870);
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x0003AA64 File Offset: 0x00038C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703093, XrefRangeEnd = 703106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormCanSetColorSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x0003AAA0 File Offset: 0x00038CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703106, XrefRangeEnd = 703113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetColor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCanSetColorSubscriber.NativeMethodInfoPtr_ResetColor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x0003AAD4 File Offset: 0x00038CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703113, XrefRangeEnd = 703128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormCanSetColorSubscriber()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCanSetColorSubscriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCanSetColorSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x00007FD9 File Offset: 0x000061D9
		public WormCanSetColorSubscriber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000B67 RID: 2919 RVA: 0x0003AB10 File Offset: 0x00038D10
		// (set) Token: 0x06000B68 RID: 2920 RVA: 0x00007FE2 File Offset: 0x000061E2
		public unsafe UnityEvent<DataComposition> onCanSetColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCanSetColorSubscriber.NativeFieldInfoPtr_onCanSetColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<DataComposition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCanSetColorSubscriber.NativeFieldInfoPtr_onCanSetColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000B69 RID: 2921 RVA: 0x0003AB40 File Offset: 0x00038D40
		// (set) Token: 0x06000B6A RID: 2922 RVA: 0x00008001 File Offset: 0x00006201
		public unsafe UnityEvent<DataComposition> onCannotSetColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCanSetColorSubscriber.NativeFieldInfoPtr_onCannotSetColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<DataComposition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCanSetColorSubscriber.NativeFieldInfoPtr_onCannotSetColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000B6B RID: 2923 RVA: 0x0003AB70 File Offset: 0x00038D70
		// (set) Token: 0x06000B6C RID: 2924 RVA: 0x00008020 File Offset: 0x00006220
		public Nullable<bool> cachedCanSetColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCanSetColorSubscriber.NativeFieldInfoPtr_cachedCanSetColor);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCanSetColorSubscriber.NativeFieldInfoPtr_cachedCanSetColor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeFieldInfoPtr_onCanSetColor;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeFieldInfoPtr_onCannotSetColor;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeFieldInfoPtr_cachedCanSetColor;

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeMethodInfoPtr_ResetColor_Private_Void_0;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
