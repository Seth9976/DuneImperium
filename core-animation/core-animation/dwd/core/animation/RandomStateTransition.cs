using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Animations;

namespace dwd.core.animation
{
	// Token: 0x0200000F RID: 15
	public class RandomStateTransition : StateMachineBehaviour
	{
		// Token: 0x0600008D RID: 141 RVA: 0x00004430 File Offset: 0x00002630
		// Note: this type is marked as 'beforefieldinit'.
		static RandomStateTransition()
		{
			Il2CppClassPointerStore<RandomStateTransition>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-animation.dll", "dwd.core.animation", "RandomStateTransition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomStateTransition>.NativeClassPtr);
			RandomStateTransition.NativeFieldInfoPtr_parameterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomStateTransition>.NativeClassPtr, "parameterName");
			RandomStateTransition.NativeFieldInfoPtr_minValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomStateTransition>.NativeClassPtr, "minValue");
			RandomStateTransition.NativeFieldInfoPtr_maxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomStateTransition>.NativeClassPtr, "maxValue");
			RandomStateTransition.NativeFieldInfoPtr_myParamHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomStateTransition>.NativeClassPtr, "myParamHash");
			RandomStateTransition.NativeMethodInfoPtr_OnStateEnter_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_AnimatorControllerPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomStateTransition>.NativeClassPtr, 100663353);
			RandomStateTransition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomStateTransition>.NativeClassPtr, 100663354);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000044D8 File Offset: 0x000026D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263334, XrefRangeEnd = 1263345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(animator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stateInfo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controller;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RandomStateTransition.NativeMethodInfoPtr_OnStateEnter_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_AnimatorControllerPlayable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00004550 File Offset: 0x00002750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RandomStateTransition()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomStateTransition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomStateTransition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000024D8 File Offset: 0x000006D8
		public RandomStateTransition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000091 RID: 145 RVA: 0x0000458C File Offset: 0x0000278C
		// (set) Token: 0x06000092 RID: 146 RVA: 0x000024E1 File Offset: 0x000006E1
		public unsafe string parameterName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomStateTransition.NativeFieldInfoPtr_parameterName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomStateTransition.NativeFieldInfoPtr_parameterName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000093 RID: 147 RVA: 0x000045B4 File Offset: 0x000027B4
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00002500 File Offset: 0x00000700
		public unsafe int minValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomStateTransition.NativeFieldInfoPtr_minValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomStateTransition.NativeFieldInfoPtr_minValue)) = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000095 RID: 149 RVA: 0x000045DC File Offset: 0x000027DC
		// (set) Token: 0x06000096 RID: 150 RVA: 0x0000251B File Offset: 0x0000071B
		public unsafe int maxValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomStateTransition.NativeFieldInfoPtr_maxValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomStateTransition.NativeFieldInfoPtr_maxValue)) = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00004604 File Offset: 0x00002804
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00002536 File Offset: 0x00000736
		public Nullable<int> myParamHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomStateTransition.NativeFieldInfoPtr_myParamHash);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomStateTransition.NativeFieldInfoPtr_myParamHash), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeFieldInfoPtr_parameterName;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeFieldInfoPtr_minValue;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeFieldInfoPtr_maxValue;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeFieldInfoPtr_myParamHash;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_OnStateEnter_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_AnimatorControllerPlayable_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
