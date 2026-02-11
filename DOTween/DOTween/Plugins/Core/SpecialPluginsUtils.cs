using System;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

namespace DG.Tweening.Plugins.Core
{
	// Token: 0x0200003B RID: 59
	public static class SpecialPluginsUtils : global::Il2CppSystem.Object
	{
		// Token: 0x06000388 RID: 904 RVA: 0x000170FC File Offset: 0x000152FC
		// Note: this type is marked as 'beforefieldinit'.
		static SpecialPluginsUtils()
		{
			Il2CppClassPointerStore<SpecialPluginsUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Core", "SpecialPluginsUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecialPluginsUtils>.NativeClassPtr);
			SpecialPluginsUtils.NativeMethodInfoPtr_SetLookAt_Internal_Static_Boolean_TweenerCore_3_Quaternion_Vector3_QuaternionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialPluginsUtils>.NativeClassPtr, 100664094);
			SpecialPluginsUtils.NativeMethodInfoPtr_SetPunch_Internal_Static_Boolean_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialPluginsUtils>.NativeClassPtr, 100664095);
			SpecialPluginsUtils.NativeMethodInfoPtr_SetShake_Internal_Static_Boolean_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialPluginsUtils>.NativeClassPtr, 100664096);
			SpecialPluginsUtils.NativeMethodInfoPtr_SetCameraShakePosition_Internal_Static_Boolean_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialPluginsUtils>.NativeClassPtr, 100664097);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0001717C File Offset: 0x0001537C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1132500, RefRangeEnd = 1132501, XrefRangeStart = 1132491, XrefRangeEnd = 1132500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetLookAt(TweenerCore<Quaternion, Vector3, QuaternionOptions> t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialPluginsUtils.NativeMethodInfoPtr_SetLookAt_Internal_Static_Boolean_TweenerCore_3_Quaternion_Vector3_QuaternionOptions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600038A RID: 906 RVA: 0x000171C0 File Offset: 0x000153C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1132502, RefRangeEnd = 1132505, XrefRangeStart = 1132501, XrefRangeEnd = 1132502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetPunch(TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions> t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialPluginsUtils.NativeMethodInfoPtr_SetPunch_Internal_Static_Boolean_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00017204 File Offset: 0x00015404
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1132506, RefRangeEnd = 1132507, XrefRangeStart = 1132505, XrefRangeEnd = 1132506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetShake(TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions> t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialPluginsUtils.NativeMethodInfoPtr_SetShake_Internal_Static_Boolean_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00017248 File Offset: 0x00015448
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1132518, RefRangeEnd = 1132519, XrefRangeStart = 1132507, XrefRangeEnd = 1132518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetCameraShakePosition(TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions> t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialPluginsUtils.NativeMethodInfoPtr_SetCameraShakePosition_Internal_Static_Boolean_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600038D RID: 909 RVA: 0x000030BE File Offset: 0x000012BE
		public SpecialPluginsUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeMethodInfoPtr_SetLookAt_Internal_Static_Boolean_TweenerCore_3_Quaternion_Vector3_QuaternionOptions_0;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeMethodInfoPtr_SetPunch_Internal_Static_Boolean_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_0;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeMethodInfoPtr_SetShake_Internal_Static_Boolean_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_0;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeMethodInfoPtr_SetCameraShakePosition_Internal_Static_Boolean_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_0;
	}
}
