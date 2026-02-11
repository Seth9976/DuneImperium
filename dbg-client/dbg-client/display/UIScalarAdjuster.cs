using System;
using dwd.core.settings.playerPrefs.definitions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace dbg_client.display
{
	// Token: 0x0200003D RID: 61
	public class UIScalarAdjuster : MonoBehaviour
	{
		// Token: 0x06000260 RID: 608 RVA: 0x000252CC File Offset: 0x000234CC
		// Note: this type is marked as 'beforefieldinit'.
		static UIScalarAdjuster()
		{
			Il2CppClassPointerStore<UIScalarAdjuster>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbg_client.display", "UIScalarAdjuster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIScalarAdjuster>.NativeClassPtr);
			UIScalarAdjuster.NativeFieldInfoPtr_scaler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScalarAdjuster>.NativeClassPtr, "scaler");
			UIScalarAdjuster.NativeFieldInfoPtr_originalRes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScalarAdjuster>.NativeClassPtr, "originalRes");
			UIScalarAdjuster.NativeFieldInfoPtr_pref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScalarAdjuster>.NativeClassPtr, "pref");
			UIScalarAdjuster.NativeFieldInfoPtr_cachedReferenceRes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScalarAdjuster>.NativeClassPtr, "cachedReferenceRes");
			UIScalarAdjuster.NativeFieldInfoPtr_cachedPrefVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScalarAdjuster>.NativeClassPtr, "cachedPrefVersion");
			UIScalarAdjuster.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScalarAdjuster>.NativeClassPtr, 100663691);
			UIScalarAdjuster.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScalarAdjuster>.NativeClassPtr, 100663692);
			UIScalarAdjuster.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScalarAdjuster>.NativeClassPtr, 100663693);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0002539C File Offset: 0x0002359C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498758, XrefRangeEnd = 498768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScalarAdjuster.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000253D0 File Offset: 0x000235D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498768, XrefRangeEnd = 498775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScalarAdjuster.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00025404 File Offset: 0x00023604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498775, XrefRangeEnd = 498778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIScalarAdjuster()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIScalarAdjuster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScalarAdjuster.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00003034 File Offset: 0x00001234
		public UIScalarAdjuster(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000265 RID: 613 RVA: 0x00025440 File Offset: 0x00023640
		// (set) Token: 0x06000266 RID: 614 RVA: 0x0000303D File Offset: 0x0000123D
		public unsafe CanvasScaler scaler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScalarAdjuster.NativeFieldInfoPtr_scaler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasScaler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScalarAdjuster.NativeFieldInfoPtr_scaler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00025470 File Offset: 0x00023670
		// (set) Token: 0x06000268 RID: 616 RVA: 0x0000305C File Offset: 0x0000125C
		public unsafe Vector2 originalRes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScalarAdjuster.NativeFieldInfoPtr_originalRes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScalarAdjuster.NativeFieldInfoPtr_originalRes)) = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000269 RID: 617 RVA: 0x00025498 File Offset: 0x00023698
		// (set) Token: 0x0600026A RID: 618 RVA: 0x00003077 File Offset: 0x00001277
		public unsafe FloatPrefDefinition pref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScalarAdjuster.NativeFieldInfoPtr_pref);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScalarAdjuster.NativeFieldInfoPtr_pref), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600026B RID: 619 RVA: 0x000254C8 File Offset: 0x000236C8
		// (set) Token: 0x0600026C RID: 620 RVA: 0x00003096 File Offset: 0x00001296
		public unsafe Vector2 cachedReferenceRes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScalarAdjuster.NativeFieldInfoPtr_cachedReferenceRes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScalarAdjuster.NativeFieldInfoPtr_cachedReferenceRes)) = value;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600026D RID: 621 RVA: 0x000254F0 File Offset: 0x000236F0
		// (set) Token: 0x0600026E RID: 622 RVA: 0x000030B1 File Offset: 0x000012B1
		public unsafe ulong cachedPrefVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScalarAdjuster.NativeFieldInfoPtr_cachedPrefVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScalarAdjuster.NativeFieldInfoPtr_cachedPrefVersion)) = value;
			}
		}

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeFieldInfoPtr_scaler;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeFieldInfoPtr_originalRes;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeFieldInfoPtr_pref;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeFieldInfoPtr_cachedReferenceRes;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeFieldInfoPtr_cachedPrefVersion;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
