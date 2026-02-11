using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering
{
	// Token: 0x020000E6 RID: 230
	public class KeyframeUtility : Object
	{
		// Token: 0x0600108A RID: 4234 RVA: 0x0004C240 File Offset: 0x0004A440
		// Note: this type is marked as 'beforefieldinit'.
		static KeyframeUtility()
		{
			Il2CppClassPointerStore<KeyframeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "KeyframeUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyframeUtility>.NativeClassPtr);
			KeyframeUtility.NativeMethodInfoPtr_ResetAnimationCurve_Public_Static_Void_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeUtility>.NativeClassPtr, 100665742);
			KeyframeUtility.NativeMethodInfoPtr_LerpSingleKeyframe_Private_Static_Keyframe_Keyframe_Keyframe_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeUtility>.NativeClassPtr, 100665743);
			KeyframeUtility.NativeMethodInfoPtr_GetKeyframeAndClampEdge_Private_Static_Keyframe_NativeArray_1_Keyframe_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeUtility>.NativeClassPtr, 100665744);
			KeyframeUtility.NativeMethodInfoPtr_FetchKeyFromIndexClampEdge_Private_Static_Keyframe_NativeArray_1_Keyframe_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeUtility>.NativeClassPtr, 100665745);
			KeyframeUtility.NativeMethodInfoPtr_EvalCurveSegmentAndDeriv_Private_Static_Void_byref_Single_byref_Single_Keyframe_Keyframe_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeUtility>.NativeClassPtr, 100665746);
			KeyframeUtility.NativeMethodInfoPtr_EvalKeyAtTime_Private_Static_Keyframe_NativeArray_1_Keyframe_Int32_Int32_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeUtility>.NativeClassPtr, 100665747);
			KeyframeUtility.NativeMethodInfoPtr_InterpAnimationCurve_Public_Static_Void_byref_AnimationCurve_AnimationCurve_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeUtility>.NativeClassPtr, 100665748);
			KeyframeUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeUtility>.NativeClassPtr, 100665749);
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x0004C310 File Offset: 0x0004A510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977808, XrefRangeEnd = 977810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResetAnimationCurve(AnimationCurve curve)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(curve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeUtility.NativeMethodInfoPtr_ResetAnimationCurve_Public_Static_Void_AnimationCurve_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x0004C348 File Offset: 0x0004A548
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 977841, RefRangeEnd = 977842, XrefRangeStart = 977810, XrefRangeEnd = 977841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Keyframe LerpSingleKeyframe(Keyframe lhs, Keyframe rhs, float t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeUtility.NativeMethodInfoPtr_LerpSingleKeyframe_Private_Static_Keyframe_Keyframe_Keyframe_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x0004C3A4 File Offset: 0x0004A5A4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 977851, RefRangeEnd = 977856, XrefRangeStart = 977842, XrefRangeEnd = 977851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Keyframe GetKeyframeAndClampEdge(NativeArray<Keyframe> keys, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keys));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeUtility.NativeMethodInfoPtr_GetKeyframeAndClampEdge_Private_Static_Keyframe_NativeArray_1_Keyframe_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x0004C3F8 File Offset: 0x0004A5F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 977864, RefRangeEnd = 977866, XrefRangeStart = 977856, XrefRangeEnd = 977864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Keyframe FetchKeyFromIndexClampEdge(NativeArray<Keyframe> keys, int index, float segmentStartTime, float segmentEndTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keys));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref segmentStartTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref segmentEndTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeUtility.NativeMethodInfoPtr_FetchKeyFromIndexClampEdge_Private_Static_Keyframe_NativeArray_1_Keyframe_Int32_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x0004C468 File Offset: 0x0004A668
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 977878, RefRangeEnd = 977879, XrefRangeStart = 977866, XrefRangeEnd = 977878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EvalCurveSegmentAndDeriv(out float dstValue, out float dstDeriv, Keyframe lhsKey, Keyframe rhsKey, float desiredTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &dstValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dstDeriv;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lhsKey;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhsKey;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref desiredTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeUtility.NativeMethodInfoPtr_EvalCurveSegmentAndDeriv_Private_Static_Void_byref_Single_byref_Single_Keyframe_Keyframe_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x0004C4D4 File Offset: 0x0004A6D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 977883, RefRangeEnd = 977885, XrefRangeStart = 977879, XrefRangeEnd = 977883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Keyframe EvalKeyAtTime(NativeArray<Keyframe> keys, int lhsIndex, int rhsIndex, float startTime, float endTime, float currTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keys));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lhsIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhsIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endTime;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeUtility.NativeMethodInfoPtr_EvalKeyAtTime_Private_Static_Keyframe_NativeArray_1_Keyframe_Int32_Int32_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x0004C560 File Offset: 0x0004A760
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 977932, RefRangeEnd = 977933, XrefRangeStart = 977885, XrefRangeEnd = 977932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InterpAnimationCurve(ref AnimationCurve lhsAndResultCurve, AnimationCurve rhsCurve, float t)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(lhsAndResultCurve);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rhsCurve);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(KeyframeUtility.NativeMethodInfoPtr_InterpAnimationCurve_Public_Static_Void_byref_AnimationCurve_AnimationCurve_Single_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			lhsAndResultCurve = ((intPtr4 == 0) ? null : new AnimationCurve(intPtr4));
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x0004C5CC File Offset: 0x0004A7CC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyframeUtility()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyframeUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x00008BB6 File Offset: 0x00006DB6
		public KeyframeUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C95 RID: 3221
		private static readonly IntPtr NativeMethodInfoPtr_ResetAnimationCurve_Public_Static_Void_AnimationCurve_0;

		// Token: 0x04000C96 RID: 3222
		private static readonly IntPtr NativeMethodInfoPtr_LerpSingleKeyframe_Private_Static_Keyframe_Keyframe_Keyframe_Single_0;

		// Token: 0x04000C97 RID: 3223
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyframeAndClampEdge_Private_Static_Keyframe_NativeArray_1_Keyframe_Int32_0;

		// Token: 0x04000C98 RID: 3224
		private static readonly IntPtr NativeMethodInfoPtr_FetchKeyFromIndexClampEdge_Private_Static_Keyframe_NativeArray_1_Keyframe_Int32_Single_Single_0;

		// Token: 0x04000C99 RID: 3225
		private static readonly IntPtr NativeMethodInfoPtr_EvalCurveSegmentAndDeriv_Private_Static_Void_byref_Single_byref_Single_Keyframe_Keyframe_Single_0;

		// Token: 0x04000C9A RID: 3226
		private static readonly IntPtr NativeMethodInfoPtr_EvalKeyAtTime_Private_Static_Keyframe_NativeArray_1_Keyframe_Int32_Int32_Single_Single_Single_0;

		// Token: 0x04000C9B RID: 3227
		private static readonly IntPtr NativeMethodInfoPtr_InterpAnimationCurve_Public_Static_Void_byref_AnimationCurve_AnimationCurve_Single_0;

		// Token: 0x04000C9C RID: 3228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
