using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x02000103 RID: 259
	[Serializable]
	public class NoInterpFloatRangeParameter : VolumeParameter<Vector2>
	{
		// Token: 0x060011B8 RID: 4536 RVA: 0x00050C4C File Offset: 0x0004EE4C
		// Note: this type is marked as 'beforefieldinit'.
		static NoInterpFloatRangeParameter()
		{
			Il2CppClassPointerStore<NoInterpFloatRangeParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "NoInterpFloatRangeParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoInterpFloatRangeParameter>.NativeClassPtr);
			NoInterpFloatRangeParameter.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoInterpFloatRangeParameter>.NativeClassPtr, "min");
			NoInterpFloatRangeParameter.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoInterpFloatRangeParameter>.NativeClassPtr, "max");
			NoInterpFloatRangeParameter.NativeMethodInfoPtr_get_value_Public_Virtual_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpFloatRangeParameter>.NativeClassPtr, 100665900);
			NoInterpFloatRangeParameter.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpFloatRangeParameter>.NativeClassPtr, 100665901);
			NoInterpFloatRangeParameter.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpFloatRangeParameter>.NativeClassPtr, 100665902);
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x060011B9 RID: 4537 RVA: 0x00050CE0 File Offset: 0x0004EEE0
		// (set) Token: 0x060011BA RID: 4538 RVA: 0x00050D28 File Offset: 0x0004EF28
		public unsafe override Vector2 value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoInterpFloatRangeParameter.NativeMethodInfoPtr_get_value_Public_Virtual_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoInterpFloatRangeParameter.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x00050D74 File Offset: 0x0004EF74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978992, XrefRangeEnd = 978995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoInterpFloatRangeParameter(Vector2 value, float min, float max, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoInterpFloatRangeParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoInterpFloatRangeParameter.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x000092C4 File Offset: 0x000074C4
		public NoInterpFloatRangeParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x060011BD RID: 4541 RVA: 0x00050DE8 File Offset: 0x0004EFE8
		// (set) Token: 0x060011BE RID: 4542 RVA: 0x000092CD File Offset: 0x000074CD
		public unsafe float min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoInterpFloatRangeParameter.NativeFieldInfoPtr_min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoInterpFloatRangeParameter.NativeFieldInfoPtr_min)) = value;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x060011BF RID: 4543 RVA: 0x00050E10 File Offset: 0x0004F010
		// (set) Token: 0x060011C0 RID: 4544 RVA: 0x000092E8 File Offset: 0x000074E8
		public unsafe float max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoInterpFloatRangeParameter.NativeFieldInfoPtr_max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoInterpFloatRangeParameter.NativeFieldInfoPtr_max)) = value;
			}
		}

		// Token: 0x04000D58 RID: 3416
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x04000D59 RID: 3417
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x04000D5A RID: 3418
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_get_Vector2_0;

		// Token: 0x04000D5B RID: 3419
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Vector2_0;

		// Token: 0x04000D5C RID: 3420
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_Single_Single_Boolean_0;
	}
}
