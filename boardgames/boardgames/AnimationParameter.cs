using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace boardgames
{
	// Token: 0x02000105 RID: 261
	[Serializable]
	public class AnimationParameter : global::Il2CppSystem.Object
	{
		// Token: 0x06000CAF RID: 3247 RVA: 0x000393C8 File Offset: 0x000375C8
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationParameter()
		{
			Il2CppClassPointerStore<AnimationParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames", "AnimationParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationParameter>.NativeClassPtr);
			AnimationParameter.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationParameter>.NativeClassPtr, "name");
			AnimationParameter.NativeFieldInfoPtr_paramType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationParameter>.NativeClassPtr, "paramType");
			AnimationParameter.NativeFieldInfoPtr_floatValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationParameter>.NativeClassPtr, "floatValue");
			AnimationParameter.NativeFieldInfoPtr_intValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationParameter>.NativeClassPtr, "intValue");
			AnimationParameter.NativeFieldInfoPtr_boolValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationParameter>.NativeClassPtr, "boolValue");
			AnimationParameter.NativeMethodInfoPtr_Set_Public_Void_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationParameter>.NativeClassPtr, 100665289);
			AnimationParameter.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationParameter>.NativeClassPtr, 100665290);
			AnimationParameter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationParameter>.NativeClassPtr, 100665291);
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00039498 File Offset: 0x00037698
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 995779, RefRangeEnd = 995780, XrefRangeStart = 995778, XrefRangeEnd = 995779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(Animator anim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(anim);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationParameter.NativeMethodInfoPtr_Set_Public_Void_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x000394DC File Offset: 0x000376DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995780, XrefRangeEnd = 995812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimationParameter.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x00039520 File Offset: 0x00037720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995812, XrefRangeEnd = 995816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationParameter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationParameter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationParameter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x00007DB0 File Offset: 0x00005FB0
		public AnimationParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x0003955C File Offset: 0x0003775C
		// (set) Token: 0x06000CB5 RID: 3253 RVA: 0x00007DB9 File Offset: 0x00005FB9
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationParameter.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationParameter.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x00039584 File Offset: 0x00037784
		// (set) Token: 0x06000CB7 RID: 3255 RVA: 0x00007DD8 File Offset: 0x00005FD8
		public unsafe AnimatorControllerParameterType paramType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationParameter.NativeFieldInfoPtr_paramType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationParameter.NativeFieldInfoPtr_paramType)) = value;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x000395AC File Offset: 0x000377AC
		// (set) Token: 0x06000CB9 RID: 3257 RVA: 0x00007DF3 File Offset: 0x00005FF3
		public unsafe float floatValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationParameter.NativeFieldInfoPtr_floatValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationParameter.NativeFieldInfoPtr_floatValue)) = value;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000CBA RID: 3258 RVA: 0x000395D4 File Offset: 0x000377D4
		// (set) Token: 0x06000CBB RID: 3259 RVA: 0x00007E0E File Offset: 0x0000600E
		public unsafe int intValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationParameter.NativeFieldInfoPtr_intValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationParameter.NativeFieldInfoPtr_intValue)) = value;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x000395FC File Offset: 0x000377FC
		// (set) Token: 0x06000CBD RID: 3261 RVA: 0x00007E29 File Offset: 0x00006029
		public unsafe bool boolValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationParameter.NativeFieldInfoPtr_boolValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationParameter.NativeFieldInfoPtr_boolValue)) = value;
			}
		}

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeFieldInfoPtr_paramType;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeFieldInfoPtr_floatValue;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeFieldInfoPtr_intValue;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeFieldInfoPtr_boolValue;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_Animator_0;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
