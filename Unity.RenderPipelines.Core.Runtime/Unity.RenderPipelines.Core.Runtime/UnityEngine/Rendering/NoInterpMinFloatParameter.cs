using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x020000FD RID: 253
	[Serializable]
	public class NoInterpMinFloatParameter : VolumeParameter<float>
	{
		// Token: 0x06001187 RID: 4487 RVA: 0x0005012C File Offset: 0x0004E32C
		// Note: this type is marked as 'beforefieldinit'.
		static NoInterpMinFloatParameter()
		{
			Il2CppClassPointerStore<NoInterpMinFloatParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "NoInterpMinFloatParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoInterpMinFloatParameter>.NativeClassPtr);
			NoInterpMinFloatParameter.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoInterpMinFloatParameter>.NativeClassPtr, "min");
			NoInterpMinFloatParameter.NativeMethodInfoPtr_get_value_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpMinFloatParameter>.NativeClassPtr, 100665881);
			NoInterpMinFloatParameter.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpMinFloatParameter>.NativeClassPtr, 100665882);
			NoInterpMinFloatParameter.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpMinFloatParameter>.NativeClassPtr, 100665883);
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06001188 RID: 4488 RVA: 0x000501AC File Offset: 0x0004E3AC
		// (set) Token: 0x06001189 RID: 4489 RVA: 0x000501F4 File Offset: 0x0004E3F4
		public unsafe override float value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoInterpMinFloatParameter.NativeMethodInfoPtr_get_value_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoInterpMinFloatParameter.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x00050240 File Offset: 0x0004E440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978938, XrefRangeEnd = 978941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoInterpMinFloatParameter(float value, float min, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoInterpMinFloatParameter>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoInterpMinFloatParameter.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x0000919B File Offset: 0x0000739B
		public NoInterpMinFloatParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x0600118C RID: 4492 RVA: 0x000502A4 File Offset: 0x0004E4A4
		// (set) Token: 0x0600118D RID: 4493 RVA: 0x000091A4 File Offset: 0x000073A4
		public unsafe float min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoInterpMinFloatParameter.NativeFieldInfoPtr_min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoInterpMinFloatParameter.NativeFieldInfoPtr_min)) = value;
			}
		}

		// Token: 0x04000D3C RID: 3388
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x04000D3D RID: 3389
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_get_Single_0;

		// Token: 0x04000D3E RID: 3390
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Single_0;

		// Token: 0x04000D3F RID: 3391
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Boolean_0;
	}
}
