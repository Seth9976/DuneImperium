using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x020000F5 RID: 245
	[Serializable]
	public class NoInterpMinIntParameter : VolumeParameter<int>
	{
		// Token: 0x06001152 RID: 4434 RVA: 0x0004F570 File Offset: 0x0004D770
		// Note: this type is marked as 'beforefieldinit'.
		static NoInterpMinIntParameter()
		{
			Il2CppClassPointerStore<NoInterpMinIntParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "NoInterpMinIntParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoInterpMinIntParameter>.NativeClassPtr);
			NoInterpMinIntParameter.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoInterpMinIntParameter>.NativeClassPtr, "min");
			NoInterpMinIntParameter.NativeMethodInfoPtr_get_value_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpMinIntParameter>.NativeClassPtr, 100665860);
			NoInterpMinIntParameter.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpMinIntParameter>.NativeClassPtr, 100665861);
			NoInterpMinIntParameter.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpMinIntParameter>.NativeClassPtr, 100665862);
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001153 RID: 4435 RVA: 0x0004F5F0 File Offset: 0x0004D7F0
		// (set) Token: 0x06001154 RID: 4436 RVA: 0x0004F638 File Offset: 0x0004D838
		public unsafe override int value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoInterpMinIntParameter.NativeMethodInfoPtr_get_value_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoInterpMinIntParameter.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x0004F684 File Offset: 0x0004D884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978902, XrefRangeEnd = 978905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoInterpMinIntParameter(int value, int min, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoInterpMinIntParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoInterpMinIntParameter.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x00009042 File Offset: 0x00007242
		public NoInterpMinIntParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06001157 RID: 4439 RVA: 0x0004F6E8 File Offset: 0x0004D8E8
		// (set) Token: 0x06001158 RID: 4440 RVA: 0x0000904B File Offset: 0x0000724B
		public unsafe int min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoInterpMinIntParameter.NativeFieldInfoPtr_min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoInterpMinIntParameter.NativeFieldInfoPtr_min)) = value;
			}
		}

		// Token: 0x04000D1F RID: 3359
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x04000D20 RID: 3360
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_get_Int32_0;

		// Token: 0x04000D21 RID: 3361
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Int32_0;

		// Token: 0x04000D22 RID: 3362
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0;
	}
}
