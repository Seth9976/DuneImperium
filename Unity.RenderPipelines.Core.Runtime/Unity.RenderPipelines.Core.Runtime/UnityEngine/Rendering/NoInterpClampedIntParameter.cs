using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x020000F9 RID: 249
	[Serializable]
	public class NoInterpClampedIntParameter : VolumeParameter<int>
	{
		// Token: 0x06001170 RID: 4464 RVA: 0x0004FC3C File Offset: 0x0004DE3C
		// Note: this type is marked as 'beforefieldinit'.
		static NoInterpClampedIntParameter()
		{
			Il2CppClassPointerStore<NoInterpClampedIntParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "NoInterpClampedIntParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoInterpClampedIntParameter>.NativeClassPtr);
			NoInterpClampedIntParameter.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoInterpClampedIntParameter>.NativeClassPtr, "min");
			NoInterpClampedIntParameter.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoInterpClampedIntParameter>.NativeClassPtr, "max");
			NoInterpClampedIntParameter.NativeMethodInfoPtr_get_value_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpClampedIntParameter>.NativeClassPtr, 100665872);
			NoInterpClampedIntParameter.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpClampedIntParameter>.NativeClassPtr, 100665873);
			NoInterpClampedIntParameter.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpClampedIntParameter>.NativeClassPtr, 100665874);
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06001171 RID: 4465 RVA: 0x0004FCD0 File Offset: 0x0004DED0
		// (set) Token: 0x06001172 RID: 4466 RVA: 0x0004FD18 File Offset: 0x0004DF18
		public unsafe override int value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoInterpClampedIntParameter.NativeMethodInfoPtr_get_value_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoInterpClampedIntParameter.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x0004FD64 File Offset: 0x0004DF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978914, XrefRangeEnd = 978917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoInterpClampedIntParameter(int value, int min, int max, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoInterpClampedIntParameter>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoInterpClampedIntParameter.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x000090ED File Offset: 0x000072ED
		public NoInterpClampedIntParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06001175 RID: 4469 RVA: 0x0004FDD8 File Offset: 0x0004DFD8
		// (set) Token: 0x06001176 RID: 4470 RVA: 0x000090F6 File Offset: 0x000072F6
		public unsafe int min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoInterpClampedIntParameter.NativeFieldInfoPtr_min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoInterpClampedIntParameter.NativeFieldInfoPtr_min)) = value;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06001177 RID: 4471 RVA: 0x0004FE00 File Offset: 0x0004E000
		// (set) Token: 0x06001178 RID: 4472 RVA: 0x00009111 File Offset: 0x00007311
		public unsafe int max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoInterpClampedIntParameter.NativeFieldInfoPtr_max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoInterpClampedIntParameter.NativeFieldInfoPtr_max)) = value;
			}
		}

		// Token: 0x04000D30 RID: 3376
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x04000D31 RID: 3377
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x04000D32 RID: 3378
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_get_Int32_0;

		// Token: 0x04000D33 RID: 3379
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Int32_0;

		// Token: 0x04000D34 RID: 3380
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_0;
	}
}
