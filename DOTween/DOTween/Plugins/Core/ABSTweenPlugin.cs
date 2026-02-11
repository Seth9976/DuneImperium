using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace DG.Tweening.Plugins.Core
{
	// Token: 0x0200003E RID: 62
	public class ABSTweenPlugin<T1, T2, TPlugOptions> : Object where TPlugOptions : new()
	{
		// Token: 0x06000396 RID: 918 RVA: 0x00017494 File Offset: 0x00015694
		// Note: this type is marked as 'beforefieldinit'.
		static ABSTweenPlugin()
		{
			Il2CppClassPointerStore<ABSTweenPlugin<T1, T2, TPlugOptions>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Core", "ABSTweenPlugin`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ABSTweenPlugin<T1, T2, TPlugOptions>>.NativeClassPtr);
			ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_TweenerCore_3_T1_T2_TPlugOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ABSTweenPlugin<T1, T2, TPlugOptions>>.NativeClassPtr, 100664102);
			ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr_SetFrom_Public_Abstract_Virtual_New_Void_TweenerCore_3_T1_T2_TPlugOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ABSTweenPlugin<T1, T2, TPlugOptions>>.NativeClassPtr, 100664103);
			ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr_ConvertToStartValue_Public_Abstract_Virtual_New_T2_TweenerCore_3_T1_T2_TPlugOptions_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ABSTweenPlugin<T1, T2, TPlugOptions>>.NativeClassPtr, 100664104);
			ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr_SetRelativeEndValue_Public_Abstract_Virtual_New_Void_TweenerCore_3_T1_T2_TPlugOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ABSTweenPlugin<T1, T2, TPlugOptions>>.NativeClassPtr, 100664105);
			ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr_SetChangeValue_Public_Abstract_Virtual_New_Void_TweenerCore_3_T1_T2_TPlugOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ABSTweenPlugin<T1, T2, TPlugOptions>>.NativeClassPtr, 100664106);
			ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr_GetSpeedBasedDuration_Public_Abstract_Virtual_New_Single_TPlugOptions_Single_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ABSTweenPlugin<T1, T2, TPlugOptions>>.NativeClassPtr, 100664107);
			ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr_EvaluateAndApply_Public_Abstract_Virtual_New_Void_TPlugOptions_Tween_Boolean_DOGetter_1_T1_DOSetter_1_T1_Single_T2_T2_Single_Boolean_UpdateNotice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ABSTweenPlugin<T1, T2, TPlugOptions>>.NativeClassPtr, 100664108);
			ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ABSTweenPlugin<T1, T2, TPlugOptions>>.NativeClassPtr, 100664109);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x000175C4 File Offset: 0x000157C4
		[CallerCount(0)]
		public unsafe virtual void Reset(TweenerCore<T1, T2, TPlugOptions> t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_TweenerCore_3_T1_T2_TPlugOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00017614 File Offset: 0x00015814
		[CallerCount(0)]
		public unsafe virtual void SetFrom(TweenerCore<T1, T2, TPlugOptions> t, bool isRelative)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr_SetFrom_Public_Abstract_Virtual_New_Void_TweenerCore_3_T1_T2_TPlugOptions_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00017670 File Offset: 0x00015870
		[CallerCount(0)]
		public unsafe virtual T2 ConvertToStartValue(TweenerCore<T1, T2, TPlugOptions> t, T1 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = value;
				intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr_ConvertToStartValue_Public_Abstract_Virtual_New_T2_TweenerCore_3_T1_T2_TPlugOptions_T1_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T2>(intPtr2, false, true);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00017710 File Offset: 0x00015910
		[CallerCount(0)]
		public unsafe virtual void SetRelativeEndValue(TweenerCore<T1, T2, TPlugOptions> t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr_SetRelativeEndValue_Public_Abstract_Virtual_New_Void_TweenerCore_3_T1_T2_TPlugOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00017760 File Offset: 0x00015960
		[CallerCount(0)]
		public unsafe virtual void SetChangeValue(TweenerCore<T1, T2, TPlugOptions> t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr_SetChangeValue_Public_Abstract_Virtual_New_Void_TweenerCore_3_T1_T2_TPlugOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600039C RID: 924 RVA: 0x000177B0 File Offset: 0x000159B0
		[CallerCount(0)]
		public unsafe virtual float GetSpeedBasedDuration(TPlugOptions options, float unitsXSecond, T2 changeValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TPlugOptions).IsValueType)
				{
					TPlugOptions tplugOptions = options;
					intPtr = ((tplugOptions is string) ? IL2CPP.ManagedStringToIl2Cpp(tplugOptions as string) : IL2CPP.Il2CppObjectBaseToPtr(tplugOptions as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref options;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unitsXSecond;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T2).IsValueType)
			{
				T2 t = changeValue;
				intPtr2 = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref changeValue;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr_GetSpeedBasedDuration_Public_Abstract_Virtual_New_Single_TPlugOptions_Single_T2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00017894 File Offset: 0x00015A94
		[CallerCount(0)]
		public unsafe virtual void EvaluateAndApply(TPlugOptions options, Tween t, bool isRelative, DOGetter<T1> getter, DOSetter<T1> setter, float elapsed, T2 startValue, T2 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TPlugOptions).IsValueType)
				{
					TPlugOptions tplugOptions = options;
					intPtr = ((tplugOptions is string) ? IL2CPP.ManagedStringToIl2Cpp(tplugOptions as string) : IL2CPP.Il2CppObjectBaseToPtr(tplugOptions as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref options;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRelative;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getter);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsed;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = startValue;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref startValue;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = changeValue;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref changeValue;
			}
			ptr4 = intPtr3;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usingInversePosition;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateNotice;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr_EvaluateAndApply_Public_Abstract_Virtual_New_Void_TPlugOptions_Tween_Boolean_DOGetter_1_T1_DOSetter_1_T1_Single_T2_T2_Single_Boolean_UpdateNotice_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00017A2C File Offset: 0x00015C2C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ABSTweenPlugin()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ABSTweenPlugin<T1, T2, TPlugOptions>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ABSTweenPlugin<T1, T2, TPlugOptions>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x000030F4 File Offset: 0x000012F4
		public ABSTweenPlugin(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_TweenerCore_3_T1_T2_TPlugOptions_0;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeMethodInfoPtr_SetFrom_Public_Abstract_Virtual_New_Void_TweenerCore_3_T1_T2_TPlugOptions_Boolean_0;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToStartValue_Public_Abstract_Virtual_New_T2_TweenerCore_3_T1_T2_TPlugOptions_T1_0;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr_SetRelativeEndValue_Public_Abstract_Virtual_New_Void_TweenerCore_3_T1_T2_TPlugOptions_0;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr_SetChangeValue_Public_Abstract_Virtual_New_Void_TweenerCore_3_T1_T2_TPlugOptions_0;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeMethodInfoPtr_GetSpeedBasedDuration_Public_Abstract_Virtual_New_Single_TPlugOptions_Single_T2_0;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateAndApply_Public_Abstract_Virtual_New_Void_TPlugOptions_Tween_Boolean_DOGetter_1_T1_DOSetter_1_T1_Single_T2_T2_Single_Boolean_UpdateNotice_0;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
