using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace boardgames.match.tutorial
{
	// Token: 0x02000256 RID: 598
	public class MozEntityTooltipCallToAction : MozEntityCallToAction
	{
		// Token: 0x06001B38 RID: 6968 RVA: 0x00076550 File Offset: 0x00074750
		// Note: this type is marked as 'beforefieldinit'.
		static MozEntityTooltipCallToAction()
		{
			Il2CppClassPointerStore<MozEntityTooltipCallToAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.tutorial", "MozEntityTooltipCallToAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MozEntityTooltipCallToAction>.NativeClassPtr);
			MozEntityTooltipCallToAction.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozEntityTooltipCallToAction>.NativeClassPtr, 100667654);
			MozEntityTooltipCallToAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozEntityTooltipCallToAction>.NativeClassPtr, 100667655);
			MozEntityTooltipCallToAction.NativeMethodInfoPtr__Start_b__0_0_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozEntityTooltipCallToAction>.NativeClassPtr, 100667656);
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x000765BC File Offset: 0x000747BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533041, XrefRangeEnd = 533055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MozEntityTooltipCallToAction.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x000765F8 File Offset: 0x000747F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 533040, RefRangeEnd = 533041, XrefRangeStart = 533040, XrefRangeEnd = 533041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MozEntityTooltipCallToAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MozEntityTooltipCallToAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozEntityTooltipCallToAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x00076634 File Offset: 0x00074834
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 483004, RefRangeEnd = 483006, XrefRangeStart = 483004, XrefRangeEnd = 483006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__0_0(GameObject _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozEntityTooltipCallToAction.NativeMethodInfoPtr__Start_b__0_0_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x0000ECF7 File Offset: 0x0000CEF7
		public MozEntityTooltipCallToAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001100 RID: 4352
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04001101 RID: 4353
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001102 RID: 4354
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_0_Private_Void_GameObject_0;
	}
}
