using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace worm.menus.dataRenderers
{
	// Token: 0x0200008C RID: 140
	public class WormEventShortDescriptionSubscriber : Subscriber<WormEventData>
	{
		// Token: 0x06000579 RID: 1401 RVA: 0x000297CC File Offset: 0x000279CC
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventShortDescriptionSubscriber()
		{
			Il2CppClassPointerStore<WormEventShortDescriptionSubscriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.dataRenderers", "WormEventShortDescriptionSubscriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventShortDescriptionSubscriber>.NativeClassPtr);
			WormEventShortDescriptionSubscriber.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventShortDescriptionSubscriber>.NativeClassPtr, "text");
			WormEventShortDescriptionSubscriber.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventShortDescriptionSubscriber>.NativeClassPtr, 100664079);
			WormEventShortDescriptionSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventShortDescriptionSubscriber>.NativeClassPtr, 100664080);
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00029838 File Offset: 0x00027A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695154, XrefRangeEnd = 695162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventShortDescriptionSubscriber.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00029874 File Offset: 0x00027A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695162, XrefRangeEnd = 695165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventShortDescriptionSubscriber()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventShortDescriptionSubscriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventShortDescriptionSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00004B76 File Offset: 0x00002D76
		public WormEventShortDescriptionSubscriber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x000298B0 File Offset: 0x00027AB0
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x00004B7F File Offset: 0x00002D7F
		public unsafe TMP_Text text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventShortDescriptionSubscriber.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventShortDescriptionSubscriber.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
