using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering
{
	// Token: 0x020000A9 RID: 169
	public class IShaderVariantSettings : Il2CppObjectBase
	{
		// Token: 0x06000C65 RID: 3173 RVA: 0x00039E74 File Offset: 0x00038074
		// Note: this type is marked as 'beforefieldinit'.
		static IShaderVariantSettings()
		{
			Il2CppClassPointerStore<IShaderVariantSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "IShaderVariantSettings");
			IShaderVariantSettings.NativeMethodInfoPtr_get_shaderVariantLogLevel_Public_Abstract_Virtual_New_get_ShaderVariantLogLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IShaderVariantSettings>.NativeClassPtr, 100665113);
			IShaderVariantSettings.NativeMethodInfoPtr_set_shaderVariantLogLevel_Public_Abstract_Virtual_New_set_Void_ShaderVariantLogLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IShaderVariantSettings>.NativeClassPtr, 100665114);
			IShaderVariantSettings.NativeMethodInfoPtr_get_exportShaderVariants_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IShaderVariantSettings>.NativeClassPtr, 100665115);
			IShaderVariantSettings.NativeMethodInfoPtr_set_exportShaderVariants_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IShaderVariantSettings>.NativeClassPtr, 100665116);
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000C66 RID: 3174 RVA: 0x00039EEC File Offset: 0x000380EC
		// (set) Token: 0x06000C67 RID: 3175 RVA: 0x00039F34 File Offset: 0x00038134
		public unsafe virtual ShaderVariantLogLevel shaderVariantLogLevel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IShaderVariantSettings.NativeMethodInfoPtr_get_shaderVariantLogLevel_Public_Abstract_Virtual_New_get_ShaderVariantLogLevel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IShaderVariantSettings.NativeMethodInfoPtr_set_shaderVariantLogLevel_Public_Abstract_Virtual_New_set_Void_ShaderVariantLogLevel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000C68 RID: 3176 RVA: 0x00039F80 File Offset: 0x00038180
		// (set) Token: 0x06000C69 RID: 3177 RVA: 0x00039FC8 File Offset: 0x000381C8
		public unsafe virtual bool exportShaderVariants
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IShaderVariantSettings.NativeMethodInfoPtr_get_exportShaderVariants_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IShaderVariantSettings.NativeMethodInfoPtr_set_exportShaderVariants_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x000076D8 File Offset: 0x000058D8
		public IShaderVariantSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400094A RID: 2378
		private static readonly IntPtr NativeMethodInfoPtr_get_shaderVariantLogLevel_Public_Abstract_Virtual_New_get_ShaderVariantLogLevel_0;

		// Token: 0x0400094B RID: 2379
		private static readonly IntPtr NativeMethodInfoPtr_set_shaderVariantLogLevel_Public_Abstract_Virtual_New_set_Void_ShaderVariantLogLevel_0;

		// Token: 0x0400094C RID: 2380
		private static readonly IntPtr NativeMethodInfoPtr_get_exportShaderVariants_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400094D RID: 2381
		private static readonly IntPtr NativeMethodInfoPtr_set_exportShaderVariants_Public_Abstract_Virtual_New_set_Void_Boolean_0;
	}
}
