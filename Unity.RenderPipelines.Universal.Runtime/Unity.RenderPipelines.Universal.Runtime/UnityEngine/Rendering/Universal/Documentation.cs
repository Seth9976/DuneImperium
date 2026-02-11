using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000083 RID: 131
	public class Documentation : DocumentationInfo
	{
		// Token: 0x06000BD7 RID: 3031 RVA: 0x0003EF2C File Offset: 0x0003D12C
		// Note: this type is marked as 'beforefieldinit'.
		static Documentation()
		{
			Il2CppClassPointerStore<Documentation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "Documentation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Documentation>.NativeClassPtr);
			Documentation.NativeFieldInfoPtr_packageName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Documentation>.NativeClassPtr, "packageName");
			Documentation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Documentation>.NativeClassPtr, 100664876);
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x0003EF84 File Offset: 0x0003D184
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Documentation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Documentation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Documentation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x000075C3 File Offset: 0x000057C3
		public Documentation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000BDA RID: 3034 RVA: 0x0003EFC0 File Offset: 0x0003D1C0
		// (set) Token: 0x06000BDB RID: 3035 RVA: 0x000075CC File Offset: 0x000057CC
		public unsafe static string packageName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Documentation.NativeFieldInfoPtr_packageName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Documentation.NativeFieldInfoPtr_packageName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040008C4 RID: 2244
		private static readonly IntPtr NativeFieldInfoPtr_packageName;

		// Token: 0x040008C5 RID: 2245
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
