using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001CD RID: 461
	public class WormActionLogCardTooltipSource : MonoBehaviour
	{
		// Token: 0x06001464 RID: 5220 RVA: 0x00056010 File Offset: 0x00054210
		// Note: this type is marked as 'beforefieldinit'.
		static WormActionLogCardTooltipSource()
		{
			Il2CppClassPointerStore<WormActionLogCardTooltipSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormActionLogCardTooltipSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormActionLogCardTooltipSource>.NativeClassPtr);
			WormActionLogCardTooltipSource.NativeFieldInfoPtr_tooltipKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLogCardTooltipSource>.NativeClassPtr, "tooltipKey");
			WormActionLogCardTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLogCardTooltipSource>.NativeClassPtr, 100666086);
			WormActionLogCardTooltipSource.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLogCardTooltipSource>.NativeClassPtr, 100666087);
			WormActionLogCardTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLogCardTooltipSource>.NativeClassPtr, 100666088);
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x00056090 File Offset: 0x00054290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713933, XrefRangeEnd = 713937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLocalizedTooltip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormActionLogCardTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x000560C8 File Offset: 0x000542C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713937, XrefRangeEnd = 713966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormActionLogCardTooltipSource.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x000560FC File Offset: 0x000542FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713966, XrefRangeEnd = 713970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormActionLogCardTooltipSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormActionLogCardTooltipSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormActionLogCardTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x0000C826 File Offset: 0x0000AA26
		public WormActionLogCardTooltipSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001469 RID: 5225 RVA: 0x00056138 File Offset: 0x00054338
		// (set) Token: 0x0600146A RID: 5226 RVA: 0x0000C82F File Offset: 0x0000AA2F
		public unsafe string tooltipKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogCardTooltipSource.NativeFieldInfoPtr_tooltipKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLogCardTooltipSource.NativeFieldInfoPtr_tooltipKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000BD1 RID: 3025
		private static readonly IntPtr NativeFieldInfoPtr_tooltipKey;

		// Token: 0x04000BD2 RID: 3026
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0;

		// Token: 0x04000BD3 RID: 3027
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000BD4 RID: 3028
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
