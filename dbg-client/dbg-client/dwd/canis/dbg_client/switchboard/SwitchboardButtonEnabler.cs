using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace dwd.canis.dbg_client.switchboard
{
	// Token: 0x0200006C RID: 108
	public class SwitchboardButtonEnabler : MonoBehaviour
	{
		// Token: 0x0600040E RID: 1038 RVA: 0x0002A4BC File Offset: 0x000286BC
		// Note: this type is marked as 'beforefieldinit'.
		static SwitchboardButtonEnabler()
		{
			Il2CppClassPointerStore<SwitchboardButtonEnabler>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.dbg_client.switchboard", "SwitchboardButtonEnabler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwitchboardButtonEnabler>.NativeClassPtr);
			SwitchboardButtonEnabler.NativeFieldInfoPtr_feature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchboardButtonEnabler>.NativeClassPtr, "feature");
			SwitchboardButtonEnabler.NativeFieldInfoPtr_changeInteractableRatherThanEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchboardButtonEnabler>.NativeClassPtr, "changeInteractableRatherThanEnabled");
			SwitchboardButtonEnabler.NativeFieldInfoPtr__button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchboardButtonEnabler>.NativeClassPtr, "_button");
			SwitchboardButtonEnabler.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchboardButtonEnabler>.NativeClassPtr, 100663916);
			SwitchboardButtonEnabler.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchboardButtonEnabler>.NativeClassPtr, 100663917);
			SwitchboardButtonEnabler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchboardButtonEnabler>.NativeClassPtr, 100663918);
			SwitchboardButtonEnabler.NativeMethodInfoPtr__Start_b__4_0_Private_Void_GetSwitchboardFeatureCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchboardButtonEnabler>.NativeClassPtr, 100663919);
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0002A578 File Offset: 0x00028778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500338, XrefRangeEnd = 500342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwitchboardButtonEnabler.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0002A5AC File Offset: 0x000287AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500342, XrefRangeEnd = 500357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwitchboardButtonEnabler.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0002A5EC File Offset: 0x000287EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500357, XrefRangeEnd = 500361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SwitchboardButtonEnabler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SwitchboardButtonEnabler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwitchboardButtonEnabler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0002A628 File Offset: 0x00028828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500361, XrefRangeEnd = 500365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__4_0(GetSwitchboardFeatureCommand command)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwitchboardButtonEnabler.NativeMethodInfoPtr__Start_b__4_0_Private_Void_GetSwitchboardFeatureCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00003CE8 File Offset: 0x00001EE8
		public SwitchboardButtonEnabler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x0002A66C File Offset: 0x0002886C
		// (set) Token: 0x06000415 RID: 1045 RVA: 0x00003CF1 File Offset: 0x00001EF1
		public unsafe string feature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwitchboardButtonEnabler.NativeFieldInfoPtr_feature);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwitchboardButtonEnabler.NativeFieldInfoPtr_feature), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x0002A694 File Offset: 0x00028894
		// (set) Token: 0x06000417 RID: 1047 RVA: 0x00003D10 File Offset: 0x00001F10
		public unsafe bool changeInteractableRatherThanEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwitchboardButtonEnabler.NativeFieldInfoPtr_changeInteractableRatherThanEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwitchboardButtonEnabler.NativeFieldInfoPtr_changeInteractableRatherThanEnabled)) = value;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x0002A6BC File Offset: 0x000288BC
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x00003D2B File Offset: 0x00001F2B
		public unsafe Button _button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwitchboardButtonEnabler.NativeFieldInfoPtr__button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwitchboardButtonEnabler.NativeFieldInfoPtr__button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeFieldInfoPtr_feature;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeFieldInfoPtr_changeInteractableRatherThanEnabled;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeFieldInfoPtr__button;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__4_0_Private_Void_GetSwitchboardFeatureCommand_0;
	}
}
