using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000067 RID: 103
	public class AnimationCurve : Object
	{
		// Token: 0x06000343 RID: 835 RVA: 0x0001F4A8 File Offset: 0x0001D6A8
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationCurve()
		{
			Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "AnimationCurve");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr);
			AnimationCurve.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, "m_Ptr");
			AnimationCurve.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663611);
			AnimationCurve.NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_Il2CppStructArray_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663612);
			AnimationCurve.NativeMethodInfoPtr_Internal_Equals_Private_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663613);
			AnimationCurve.NativeMethodInfoPtr_Internal_CopyFrom_Private_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663614);
			AnimationCurve.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663615);
			AnimationCurve.NativeMethodInfoPtr_Evaluate_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663616);
			AnimationCurve.NativeMethodInfoPtr_get_keys_Public_get_Il2CppStructArray_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663617);
			AnimationCurve.NativeMethodInfoPtr_set_keys_Public_set_Void_Il2CppStructArray_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663618);
			AnimationCurve.NativeMethodInfoPtr_AddKey_Public_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663619);
			AnimationCurve.NativeMethodInfoPtr_AddKey_Public_Int32_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663620);
			AnimationCurve.NativeMethodInfoPtr_AddKey_Internal_Private_Int32_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663621);
			AnimationCurve.NativeMethodInfoPtr_MoveKey_Public_Int32_Int32_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663622);
			AnimationCurve.NativeMethodInfoPtr_ClearKeys_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663623);
			AnimationCurve.NativeMethodInfoPtr_RemoveKey_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663624);
			AnimationCurve.NativeMethodInfoPtr_get_Item_Public_get_Keyframe_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663625);
			AnimationCurve.NativeMethodInfoPtr_get_length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663626);
			AnimationCurve.NativeMethodInfoPtr_SetKeys_Private_Void_Il2CppStructArray_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663627);
			AnimationCurve.NativeMethodInfoPtr_GetKey_Private_Keyframe_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663628);
			AnimationCurve.NativeMethodInfoPtr_GetKeys_Private_Il2CppStructArray_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663629);
			AnimationCurve.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663630);
			AnimationCurve.NativeMethodInfoPtr_SmoothTangents_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663631);
			AnimationCurve.NativeMethodInfoPtr_Linear_Public_Static_AnimationCurve_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663632);
			AnimationCurve.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663633);
			AnimationCurve.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663634);
			AnimationCurve.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663635);
			AnimationCurve.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663636);
			AnimationCurve.NativeMethodInfoPtr_CopyFrom_Public_Void_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663637);
			AnimationCurve.NativeMethodInfoPtr_AddKey_Internal_Injected_Private_Int32_byref_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663638);
			AnimationCurve.NativeMethodInfoPtr_MoveKey_Injected_Private_Int32_Int32_byref_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663639);
			AnimationCurve.NativeMethodInfoPtr_GetKey_Injected_Private_Void_Int32_byref_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663640);
			AnimationCurve.get_preWrapModeDelegateField = IL2CPP.ResolveICall<AnimationCurve.get_preWrapModeDelegate>("UnityEngine.AnimationCurve::get_preWrapMode");
			AnimationCurve.set_preWrapModeDelegateField = IL2CPP.ResolveICall<AnimationCurve.set_preWrapModeDelegate>("UnityEngine.AnimationCurve::set_preWrapMode");
			AnimationCurve.get_postWrapModeDelegateField = IL2CPP.ResolveICall<AnimationCurve.get_postWrapModeDelegate>("UnityEngine.AnimationCurve::get_postWrapMode");
			AnimationCurve.set_postWrapModeDelegateField = IL2CPP.ResolveICall<AnimationCurve.set_postWrapModeDelegate>("UnityEngine.AnimationCurve::set_postWrapMode");
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0001F780 File Offset: 0x0001D980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 644464, XrefRangeEnd = 644466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Destroy(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0001F7B4 File Offset: 0x0001D9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 644466, XrefRangeEnd = 644468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Internal_Create(Il2CppStructArray<Keyframe> keys)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_Il2CppStructArray_1_Keyframe_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0001F7F8 File Offset: 0x0001D9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 644468, XrefRangeEnd = 644470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Internal_Equals(IntPtr other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_Internal_Equals_Private_Boolean_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0001F844 File Offset: 0x0001DA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 644470, XrefRangeEnd = 644472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_CopyFrom(IntPtr other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_Internal_CopyFrom_Private_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0001F884 File Offset: 0x0001DA84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 644472, XrefRangeEnd = 644477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimationCurve.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0001F8C0 File Offset: 0x0001DAC0
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 644479, RefRangeEnd = 644499, XrefRangeStart = 644477, XrefRangeEnd = 644479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Evaluate(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_Evaluate_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600034A RID: 842 RVA: 0x0001F90C File Offset: 0x0001DB0C
		// (set) Token: 0x0600034B RID: 843 RVA: 0x0001F94C File Offset: 0x0001DB4C
		public unsafe Il2CppStructArray<Keyframe> keys
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 644501, RefRangeEnd = 644506, XrefRangeStart = 644499, XrefRangeEnd = 644501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_get_keys_Public_get_Il2CppStructArray_1_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Keyframe>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 644508, RefRangeEnd = 644509, XrefRangeStart = 644506, XrefRangeEnd = 644508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_set_keys_Public_set_Void_Il2CppStructArray_1_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0001F990 File Offset: 0x0001DB90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 644511, RefRangeEnd = 644512, XrefRangeStart = 644509, XrefRangeEnd = 644511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int AddKey(float time, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_AddKey_Public_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0001F9E8 File Offset: 0x0001DBE8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 644514, RefRangeEnd = 644517, XrefRangeStart = 644512, XrefRangeEnd = 644514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int AddKey(Keyframe key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_AddKey_Public_Int32_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0001FA34 File Offset: 0x0001DC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 644517, XrefRangeEnd = 644519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int AddKey_Internal(Keyframe key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_AddKey_Internal_Private_Int32_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0001FA80 File Offset: 0x0001DC80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 644521, RefRangeEnd = 644522, XrefRangeStart = 644519, XrefRangeEnd = 644521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int MoveKey(int index, Keyframe key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_MoveKey_Public_Int32_Int32_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0001FAD8 File Offset: 0x0001DCD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 644524, RefRangeEnd = 644526, XrefRangeStart = 644522, XrefRangeEnd = 644524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearKeys()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_ClearKeys_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0001FB0C File Offset: 0x0001DD0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 644528, RefRangeEnd = 644529, XrefRangeStart = 644526, XrefRangeEnd = 644528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveKey(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_RemoveKey_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000A4 RID: 164
		public unsafe Keyframe this[int index]
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 644531, RefRangeEnd = 644537, XrefRangeStart = 644529, XrefRangeEnd = 644531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_get_Item_Public_get_Keyframe_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000353 RID: 851 RVA: 0x0001FB98 File Offset: 0x0001DD98
		public unsafe int length
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 644539, RefRangeEnd = 644561, XrefRangeStart = 644537, XrefRangeEnd = 644539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_get_length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0001FBD4 File Offset: 0x0001DDD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 644508, RefRangeEnd = 644509, XrefRangeStart = 644508, XrefRangeEnd = 644509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetKeys(Il2CppStructArray<Keyframe> keys)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_SetKeys_Private_Void_Il2CppStructArray_1_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0001FC18 File Offset: 0x0001DE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 644561, XrefRangeEnd = 644563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Keyframe GetKey(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_GetKey_Private_Keyframe_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0001FC64 File Offset: 0x0001DE64
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 644501, RefRangeEnd = 644506, XrefRangeStart = 644501, XrefRangeEnd = 644506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Keyframe> GetKeys()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_GetKeys_Private_Il2CppStructArray_1_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Keyframe>>(intPtr3) : null;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0001FCA4 File Offset: 0x0001DEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 644563, XrefRangeEnd = 644565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimationCurve.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0001FCEC File Offset: 0x0001DEEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 644567, RefRangeEnd = 644568, XrefRangeStart = 644565, XrefRangeEnd = 644567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SmoothTangents(int index, float weight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_SmoothTangents_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0001FD38 File Offset: 0x0001DF38
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 644580, RefRangeEnd = 644584, XrefRangeStart = 644568, XrefRangeEnd = 644580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeStart;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeEnd;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_Linear_Public_Static_AnimationCurve_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr3) : null;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0001FDA4 File Offset: 0x0001DFA4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 644587, RefRangeEnd = 644598, XrefRangeStart = 644584, XrefRangeEnd = 644587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationCurve([Optional] Il2CppStructArray<Keyframe> keys)
		{
			if (keys == null)
			{
				keys = new Il2CppStructArray<Keyframe>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0001FDFC File Offset: 0x0001DFFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 644601, RefRangeEnd = 644602, XrefRangeStart = 644598, XrefRangeEnd = 644601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationCurve()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0001FE38 File Offset: 0x0001E038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 644602, XrefRangeEnd = 644609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimationCurve.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0001FE90 File Offset: 0x0001E090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 644609, XrefRangeEnd = 644613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(AnimationCurve other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0001FEE0 File Offset: 0x0001E0E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 644616, RefRangeEnd = 644617, XrefRangeStart = 644613, XrefRangeEnd = 644616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(AnimationCurve other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_CopyFrom_Public_Void_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0001FF24 File Offset: 0x0001E124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 644617, XrefRangeEnd = 644619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int AddKey_Internal_Injected(ref Keyframe key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_AddKey_Internal_Injected_Private_Int32_byref_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0001FF70 File Offset: 0x0001E170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 644619, XrefRangeEnd = 644621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int MoveKey_Injected(int index, ref Keyframe key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_MoveKey_Injected_Private_Int32_Int32_byref_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0001FFC8 File Offset: 0x0001E1C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 644621, XrefRangeEnd = 644623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetKey_Injected(int index, out Keyframe ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_GetKey_Injected_Private_Void_Int32_byref_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00003AC3 File Offset: 0x00001CC3
		public AnimationCurve(params Keyframe[] keys)
			: this(new Il2CppStructArray<Keyframe>(keys))
		{
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00003AD1 File Offset: 0x00001CD1
		public AnimationCurve(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000364 RID: 868 RVA: 0x00020014 File Offset: 0x0001E214
		// (set) Token: 0x06000365 RID: 869 RVA: 0x00003ADA File Offset: 0x00001CDA
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationCurve.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationCurve.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0002003C File Offset: 0x0001E23C
		public static AnimationCurve Constant(float timeStart, float timeEnd, float value)
		{
			return AnimationCurve.Linear(timeStart, value, timeEnd, value);
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00003AF5 File Offset: 0x00001CF5
		public static AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000368 RID: 872 RVA: 0x00003B02 File Offset: 0x00001D02
		// (set) Token: 0x06000369 RID: 873 RVA: 0x00003B14 File Offset: 0x00001D14
		public WrapMode preWrapMode
		{
			get
			{
				return AnimationCurve.get_preWrapModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationCurve.set_preWrapModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600036A RID: 874 RVA: 0x00003B27 File Offset: 0x00001D27
		// (set) Token: 0x0600036B RID: 875 RVA: 0x00003B39 File Offset: 0x00001D39
		public WrapMode postWrapMode
		{
			get
			{
				return AnimationCurve.get_postWrapModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationCurve.set_postWrapModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_Il2CppStructArray_1_Keyframe_0;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Equals_Private_Boolean_IntPtr_0;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CopyFrom_Private_Void_IntPtr_0;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Single_Single_0;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeMethodInfoPtr_get_keys_Public_get_Il2CppStructArray_1_Keyframe_0;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeMethodInfoPtr_set_keys_Public_set_Void_Il2CppStructArray_1_Keyframe_0;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeMethodInfoPtr_AddKey_Public_Int32_Single_Single_0;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeMethodInfoPtr_AddKey_Public_Int32_Keyframe_0;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeMethodInfoPtr_AddKey_Internal_Private_Int32_Keyframe_0;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeMethodInfoPtr_MoveKey_Public_Int32_Int32_Keyframe_0;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeMethodInfoPtr_ClearKeys_Public_Void_0;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeMethodInfoPtr_RemoveKey_Public_Void_Int32_0;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Keyframe_Int32_0;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeMethodInfoPtr_get_length_Public_get_Int32_0;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeMethodInfoPtr_SetKeys_Private_Void_Il2CppStructArray_1_Keyframe_0;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeMethodInfoPtr_GetKey_Private_Keyframe_Int32_0;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeMethodInfoPtr_GetKeys_Private_Il2CppStructArray_1_Keyframe_0;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeMethodInfoPtr_SmoothTangents_Public_Void_Int32_Single_0;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeMethodInfoPtr_Linear_Public_Static_AnimationCurve_Single_Single_Single_Single_0;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Keyframe_0;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationCurve_0;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Void_AnimationCurve_0;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeMethodInfoPtr_AddKey_Internal_Injected_Private_Int32_byref_Keyframe_0;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeMethodInfoPtr_MoveKey_Injected_Private_Int32_Int32_byref_Keyframe_0;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeMethodInfoPtr_GetKey_Injected_Private_Void_Int32_byref_Keyframe_0;

		// Token: 0x040002A4 RID: 676
		private static readonly AnimationCurve.get_preWrapModeDelegate get_preWrapModeDelegateField;

		// Token: 0x040002A5 RID: 677
		private static readonly AnimationCurve.set_preWrapModeDelegate set_preWrapModeDelegateField;

		// Token: 0x040002A6 RID: 678
		private static readonly AnimationCurve.get_postWrapModeDelegate get_postWrapModeDelegateField;

		// Token: 0x040002A7 RID: 679
		private static readonly AnimationCurve.set_postWrapModeDelegate set_postWrapModeDelegateField;

		// Token: 0x02000400 RID: 1024
		// (Invoke) Token: 0x060030EF RID: 12527
		private delegate WrapMode get_preWrapModeDelegate(IntPtr @this);

		// Token: 0x02000401 RID: 1025
		// (Invoke) Token: 0x060030F1 RID: 12529
		private delegate void set_preWrapModeDelegate(IntPtr @this, WrapMode value);

		// Token: 0x02000402 RID: 1026
		// (Invoke) Token: 0x060030F3 RID: 12531
		private delegate WrapMode get_postWrapModeDelegate(IntPtr @this);

		// Token: 0x02000403 RID: 1027
		// (Invoke) Token: 0x060030F5 RID: 12533
		private delegate void set_postWrapModeDelegate(IntPtr @this, WrapMode value);
	}
}
