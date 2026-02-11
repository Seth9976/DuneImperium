using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace DG.Tweening.Plugins
{
	// Token: 0x02000021 RID: 33
	public class PathPlugin : ABSTweenPlugin<Vector3, Path, PathOptions>
	{
		// Token: 0x060002A2 RID: 674 RVA: 0x00012F6C File Offset: 0x0001116C
		// Note: this type is marked as 'beforefieldinit'.
		static PathPlugin()
		{
			Il2CppClassPointerStore<PathPlugin>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins", "PathPlugin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathPlugin>.NativeClassPtr);
			PathPlugin.NativeFieldInfoPtr_MinLookAhead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPlugin>.NativeClassPtr, "MinLookAhead");
			PathPlugin.NativeMethodInfoPtr_Reset_Public_Virtual_Void_TweenerCore_3_Vector3_Path_PathOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathPlugin>.NativeClassPtr, 100663978);
			PathPlugin.NativeMethodInfoPtr_SetFrom_Public_Virtual_Void_TweenerCore_3_Vector3_Path_PathOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathPlugin>.NativeClassPtr, 100663979);
			PathPlugin.NativeMethodInfoPtr_Get_Public_Static_ABSTweenPlugin_3_Vector3_Path_PathOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathPlugin>.NativeClassPtr, 100663980);
			PathPlugin.NativeMethodInfoPtr_ConvertToStartValue_Public_Virtual_Path_TweenerCore_3_Vector3_Path_PathOptions_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathPlugin>.NativeClassPtr, 100663981);
			PathPlugin.NativeMethodInfoPtr_SetRelativeEndValue_Public_Virtual_Void_TweenerCore_3_Vector3_Path_PathOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathPlugin>.NativeClassPtr, 100663982);
			PathPlugin.NativeMethodInfoPtr_SetChangeValue_Public_Virtual_Void_TweenerCore_3_Vector3_Path_PathOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathPlugin>.NativeClassPtr, 100663983);
			PathPlugin.NativeMethodInfoPtr_GetSpeedBasedDuration_Public_Virtual_Single_PathOptions_Single_Path_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathPlugin>.NativeClassPtr, 100663984);
			PathPlugin.NativeMethodInfoPtr_EvaluateAndApply_Public_Virtual_Void_PathOptions_Tween_Boolean_DOGetter_1_Vector3_DOSetter_1_Vector3_Single_Path_Path_Single_Boolean_UpdateNotice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathPlugin>.NativeClassPtr, 100663985);
			PathPlugin.NativeMethodInfoPtr_SetOrientation_Public_Void_PathOptions_Tween_Path_Single_Vector3_UpdateNotice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathPlugin>.NativeClassPtr, 100663986);
			PathPlugin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathPlugin>.NativeClassPtr, 100663987);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00013078 File Offset: 0x00011278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131806, XrefRangeEnd = 1131811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset(TweenerCore<Vector3, Path, PathOptions> t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PathPlugin.NativeMethodInfoPtr_Reset_Public_Virtual_Void_TweenerCore_3_Vector3_Path_PathOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x000130C8 File Offset: 0x000112C8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetFrom(TweenerCore<Vector3, Path, PathOptions> t, bool isRelative)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRelative;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PathPlugin.NativeMethodInfoPtr_SetFrom_Public_Virtual_Void_TweenerCore_3_Vector3_Path_PathOptions_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00013124 File Offset: 0x00011324
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1131814, RefRangeEnd = 1131822, XrefRangeStart = 1131811, XrefRangeEnd = 1131814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ABSTweenPlugin<Vector3, Path, PathOptions> Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathPlugin.NativeMethodInfoPtr_Get_Public_Static_ABSTweenPlugin_3_Vector3_Path_PathOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ABSTweenPlugin<Vector3, Path, PathOptions>>(intPtr3) : null;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00013158 File Offset: 0x00011358
		[CallerCount(0)]
		public unsafe override Path ConvertToStartValue(TweenerCore<Vector3, Path, PathOptions> t, Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PathPlugin.NativeMethodInfoPtr_ConvertToStartValue_Public_Virtual_Path_TweenerCore_3_Vector3_Path_PathOptions_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Path>(intPtr3) : null;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x000131C4 File Offset: 0x000113C4
		[CallerCount(0)]
		public unsafe override void SetRelativeEndValue(TweenerCore<Vector3, Path, PathOptions> t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PathPlugin.NativeMethodInfoPtr_SetRelativeEndValue_Public_Virtual_Void_TweenerCore_3_Vector3_Path_PathOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00013214 File Offset: 0x00011414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131822, XrefRangeEnd = 1131846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetChangeValue(TweenerCore<Vector3, Path, PathOptions> t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PathPlugin.NativeMethodInfoPtr_SetChangeValue_Public_Virtual_Void_TweenerCore_3_Vector3_Path_PathOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00013264 File Offset: 0x00011464
		[CallerCount(0)]
		public unsafe override float GetSpeedBasedDuration(PathOptions options, float unitsXSecond, Path changeValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(options));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unitsXSecond;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(changeValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PathPlugin.NativeMethodInfoPtr_GetSpeedBasedDuration_Public_Virtual_Single_PathOptions_Single_Path_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x000132E4 File Offset: 0x000114E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131846, XrefRangeEnd = 1131856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EvaluateAndApply(PathOptions options, Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Path startValue, Path changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(options));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRelative;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getter);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsed;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startValue);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(changeValue);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usingInversePosition;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateNotice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PathPlugin.NativeMethodInfoPtr_EvaluateAndApply_Public_Virtual_Void_PathOptions_Tween_Boolean_DOGetter_1_Vector3_DOSetter_1_Vector3_Single_Path_Path_Single_Boolean_UpdateNotice_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x000133E0 File Offset: 0x000115E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1131920, RefRangeEnd = 1131921, XrefRangeStart = 1131856, XrefRangeEnd = 1131920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOrientation(PathOptions options, Tween t, Path path, float pathPerc, Vector3 tPos, UpdateNotice updateNotice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(options));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathPerc;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tPos;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateNotice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathPlugin.NativeMethodInfoPtr_SetOrientation_Public_Void_PathOptions_Tween_Path_Single_Vector3_UpdateNotice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00013478 File Offset: 0x00011678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131921, XrefRangeEnd = 1131924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathPlugin()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathPlugin>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathPlugin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00002BE9 File Offset: 0x00000DE9
		public PathPlugin(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060002AE RID: 686 RVA: 0x000134B4 File Offset: 0x000116B4
		// (set) Token: 0x060002AF RID: 687 RVA: 0x00002BF2 File Offset: 0x00000DF2
		public unsafe static float MinLookAhead
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(PathPlugin.NativeFieldInfoPtr_MinLookAhead, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PathPlugin.NativeFieldInfoPtr_MinLookAhead, (void*)(&value));
			}
		}

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeFieldInfoPtr_MinLookAhead;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_TweenerCore_3_Vector3_Path_PathOptions_0;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeMethodInfoPtr_SetFrom_Public_Virtual_Void_TweenerCore_3_Vector3_Path_PathOptions_Boolean_0;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_ABSTweenPlugin_3_Vector3_Path_PathOptions_0;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToStartValue_Public_Virtual_Path_TweenerCore_3_Vector3_Path_PathOptions_Vector3_0;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr_SetRelativeEndValue_Public_Virtual_Void_TweenerCore_3_Vector3_Path_PathOptions_0;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeMethodInfoPtr_SetChangeValue_Public_Virtual_Void_TweenerCore_3_Vector3_Path_PathOptions_0;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeMethodInfoPtr_GetSpeedBasedDuration_Public_Virtual_Single_PathOptions_Single_Path_0;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateAndApply_Public_Virtual_Void_PathOptions_Tween_Boolean_DOGetter_1_Vector3_DOSetter_1_Vector3_Single_Path_Path_Single_Boolean_UpdateNotice_0;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr_SetOrientation_Public_Void_PathOptions_Tween_Path_Single_Vector3_UpdateNotice_0;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
