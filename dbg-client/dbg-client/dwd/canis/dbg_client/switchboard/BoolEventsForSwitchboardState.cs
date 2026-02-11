using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace dwd.canis.dbg_client.switchboard
{
	// Token: 0x02000069 RID: 105
	public class BoolEventsForSwitchboardState : MonoBehaviour
	{
		// Token: 0x060003E8 RID: 1000 RVA: 0x00029D84 File Offset: 0x00027F84
		// Note: this type is marked as 'beforefieldinit'.
		static BoolEventsForSwitchboardState()
		{
			Il2CppClassPointerStore<BoolEventsForSwitchboardState>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.dbg_client.switchboard", "BoolEventsForSwitchboardState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolEventsForSwitchboardState>.NativeClassPtr);
			BoolEventsForSwitchboardState.NativeFieldInfoPtr_feature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolEventsForSwitchboardState>.NativeClassPtr, "feature");
			BoolEventsForSwitchboardState.NativeFieldInfoPtr_onLoadStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolEventsForSwitchboardState>.NativeClassPtr, "onLoadStart");
			BoolEventsForSwitchboardState.NativeFieldInfoPtr_onEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolEventsForSwitchboardState>.NativeClassPtr, "onEnabled");
			BoolEventsForSwitchboardState.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolEventsForSwitchboardState>.NativeClassPtr, 100663901);
			BoolEventsForSwitchboardState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolEventsForSwitchboardState>.NativeClassPtr, 100663902);
			BoolEventsForSwitchboardState.NativeMethodInfoPtr__Start_b__3_0_Private_Void_GetSwitchboardFeatureCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolEventsForSwitchboardState>.NativeClassPtr, 100663903);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00029E2C File Offset: 0x0002802C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500149, XrefRangeEnd = 500164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolEventsForSwitchboardState.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00029E6C File Offset: 0x0002806C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500164, XrefRangeEnd = 500178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolEventsForSwitchboardState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolEventsForSwitchboardState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolEventsForSwitchboardState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00029EA8 File Offset: 0x000280A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500178, XrefRangeEnd = 500180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__3_0(GetSwitchboardFeatureCommand command)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolEventsForSwitchboardState.NativeMethodInfoPtr__Start_b__3_0_Private_Void_GetSwitchboardFeatureCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00003B9B File Offset: 0x00001D9B
		public BoolEventsForSwitchboardState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x00029EEC File Offset: 0x000280EC
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x00003BA4 File Offset: 0x00001DA4
		public unsafe string feature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolEventsForSwitchboardState.NativeFieldInfoPtr_feature);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolEventsForSwitchboardState.NativeFieldInfoPtr_feature), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x00029F14 File Offset: 0x00028114
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x00003BC3 File Offset: 0x00001DC3
		public unsafe UnityEvent onLoadStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolEventsForSwitchboardState.NativeFieldInfoPtr_onLoadStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolEventsForSwitchboardState.NativeFieldInfoPtr_onLoadStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x00029F44 File Offset: 0x00028144
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x00003BE2 File Offset: 0x00001DE2
		public unsafe BoolUnityEvents onEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolEventsForSwitchboardState.NativeFieldInfoPtr_onEnabled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolUnityEvents>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolEventsForSwitchboardState.NativeFieldInfoPtr_onEnabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeFieldInfoPtr_feature;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeFieldInfoPtr_onLoadStart;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeFieldInfoPtr_onEnabled;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__3_0_Private_Void_GetSwitchboardFeatureCommand_0;
	}
}
