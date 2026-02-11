using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Animations;

namespace dwd.core.animation
{
	// Token: 0x0200000E RID: 14
	public class RandomStateSpeed : StateMachineBehaviour
	{
		// Token: 0x06000081 RID: 129 RVA: 0x0000422C File Offset: 0x0000242C
		// Note: this type is marked as 'beforefieldinit'.
		static RandomStateSpeed()
		{
			Il2CppClassPointerStore<RandomStateSpeed>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-animation.dll", "dwd.core.animation", "RandomStateSpeed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomStateSpeed>.NativeClassPtr);
			RandomStateSpeed.NativeFieldInfoPtr_parameterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomStateSpeed>.NativeClassPtr, "parameterName");
			RandomStateSpeed.NativeFieldInfoPtr_minValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomStateSpeed>.NativeClassPtr, "minValue");
			RandomStateSpeed.NativeFieldInfoPtr_maxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomStateSpeed>.NativeClassPtr, "maxValue");
			RandomStateSpeed.NativeFieldInfoPtr_myParamHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomStateSpeed>.NativeClassPtr, "myParamHash");
			RandomStateSpeed.NativeMethodInfoPtr_OnStateEnter_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_AnimatorControllerPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomStateSpeed>.NativeClassPtr, 100663351);
			RandomStateSpeed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomStateSpeed>.NativeClassPtr, 100663352);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000042D4 File Offset: 0x000024D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263323, XrefRangeEnd = 1263334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RandomStateSpeed.NativeMethodInfoPtr_OnStateEnter_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_AnimatorControllerPlayable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000434C File Offset: 0x0000254C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RandomStateSpeed()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomStateSpeed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomStateSpeed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000244C File Offset: 0x0000064C
		public RandomStateSpeed(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00004388 File Offset: 0x00002588
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00002455 File Offset: 0x00000655
		public unsafe string parameterName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomStateSpeed.NativeFieldInfoPtr_parameterName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomStateSpeed.NativeFieldInfoPtr_parameterName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000087 RID: 135 RVA: 0x000043B0 File Offset: 0x000025B0
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00002474 File Offset: 0x00000674
		public unsafe float minValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomStateSpeed.NativeFieldInfoPtr_minValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomStateSpeed.NativeFieldInfoPtr_minValue)) = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000089 RID: 137 RVA: 0x000043D8 File Offset: 0x000025D8
		// (set) Token: 0x0600008A RID: 138 RVA: 0x0000248F File Offset: 0x0000068F
		public unsafe float maxValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomStateSpeed.NativeFieldInfoPtr_maxValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomStateSpeed.NativeFieldInfoPtr_maxValue)) = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00004400 File Offset: 0x00002600
		// (set) Token: 0x0600008C RID: 140 RVA: 0x000024AA File Offset: 0x000006AA
		public Nullable<int> myParamHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomStateSpeed.NativeFieldInfoPtr_myParamHash);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomStateSpeed.NativeFieldInfoPtr_myParamHash), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr_parameterName;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr_minValue;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeFieldInfoPtr_maxValue;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeFieldInfoPtr_myParamHash;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_OnStateEnter_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_AnimatorControllerPlayable_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
