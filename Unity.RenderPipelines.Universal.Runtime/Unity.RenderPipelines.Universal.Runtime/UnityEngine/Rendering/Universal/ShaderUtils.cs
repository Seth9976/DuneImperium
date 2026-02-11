using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000D4 RID: 212
	public static class ShaderUtils : Object
	{
		// Token: 0x0600107A RID: 4218 RVA: 0x0004E630 File Offset: 0x0004C830
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderUtils()
		{
			Il2CppClassPointerStore<ShaderUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ShaderUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderUtils>.NativeClassPtr);
			ShaderUtils.NativeFieldInfoPtr_s_ShaderPaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtils>.NativeClassPtr, "s_ShaderPaths");
			ShaderUtils.NativeMethodInfoPtr_GetShaderPath_Public_Static_String_ShaderPathID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderUtils>.NativeClassPtr, 100665385);
			ShaderUtils.NativeMethodInfoPtr_GetEnumFromPath_Public_Static_ShaderPathID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderUtils>.NativeClassPtr, 100665386);
			ShaderUtils.NativeMethodInfoPtr_IsLWShader_Public_Static_Boolean_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderUtils>.NativeClassPtr, 100665387);
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x0004E6B0 File Offset: 0x0004C8B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 617114, RefRangeEnd = 617115, XrefRangeStart = 617101, XrefRangeEnd = 617114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetShaderPath(ShaderPathID id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderUtils.NativeMethodInfoPtr_GetShaderPath_Public_Static_String_ShaderPathID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x0004E6E8 File Offset: 0x0004C8E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 617115, XrefRangeEnd = 617134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ShaderPathID GetEnumFromPath(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderUtils.NativeMethodInfoPtr_GetEnumFromPath_Public_Static_ShaderPathID_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x0004E72C File Offset: 0x0004C92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 617134, XrefRangeEnd = 617185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLWShader(Shader shader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderUtils.NativeMethodInfoPtr_IsLWShader_Public_Static_Boolean_Shader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x00009E99 File Offset: 0x00008099
		public ShaderUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x0600107F RID: 4223 RVA: 0x0004E770 File Offset: 0x0004C970
		// (set) Token: 0x06001080 RID: 4224 RVA: 0x00009EA2 File Offset: 0x000080A2
		public unsafe static Il2CppStringArray s_ShaderPaths
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderUtils.NativeFieldInfoPtr_s_ShaderPaths, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderUtils.NativeFieldInfoPtr_s_ShaderPaths, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C04 RID: 3076
		private static readonly IntPtr NativeFieldInfoPtr_s_ShaderPaths;

		// Token: 0x04000C05 RID: 3077
		private static readonly IntPtr NativeMethodInfoPtr_GetShaderPath_Public_Static_String_ShaderPathID_0;

		// Token: 0x04000C06 RID: 3078
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumFromPath_Public_Static_ShaderPathID_String_0;

		// Token: 0x04000C07 RID: 3079
		private static readonly IntPtr NativeMethodInfoPtr_IsLWShader_Public_Static_Boolean_Shader_0;

		// Token: 0x020001BF RID: 447
		[ObfuscatedName("UnityEngine.Rendering.Universal.ShaderUtils+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x0600200B RID: 8203 RVA: 0x0007D9AC File Offset: 0x0007BBAC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<ShaderUtils.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShaderUtils>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderUtils.__c__DisplayClass2_0>.NativeClassPtr);
				ShaderUtils.__c__DisplayClass2_0.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtils.__c__DisplayClass2_0>.NativeClassPtr, "path");
				ShaderUtils.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderUtils.__c__DisplayClass2_0>.NativeClassPtr, 100665389);
				ShaderUtils.__c__DisplayClass2_0.NativeMethodInfoPtr__GetEnumFromPath_b__0_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderUtils.__c__DisplayClass2_0>.NativeClassPtr, 100665390);
			}

			// Token: 0x0600200C RID: 8204 RVA: 0x0007DA14 File Offset: 0x0007BC14
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderUtils.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderUtils.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600200D RID: 8205 RVA: 0x0007DA50 File Offset: 0x0007BC50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 617093, XrefRangeEnd = 617101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetEnumFromPath_b__0(string m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(m);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderUtils.__c__DisplayClass2_0.NativeMethodInfoPtr__GetEnumFromPath_b__0_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600200E RID: 8206 RVA: 0x000125A9 File Offset: 0x000107A9
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B8A RID: 2954
			// (get) Token: 0x0600200F RID: 8207 RVA: 0x0007DAA0 File Offset: 0x0007BCA0
			// (set) Token: 0x06002010 RID: 8208 RVA: 0x000125B2 File Offset: 0x000107B2
			public unsafe string path
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderUtils.__c__DisplayClass2_0.NativeFieldInfoPtr_path);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderUtils.__c__DisplayClass2_0.NativeFieldInfoPtr_path), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040016C6 RID: 5830
			private static readonly IntPtr NativeFieldInfoPtr_path;

			// Token: 0x040016C7 RID: 5831
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040016C8 RID: 5832
			private static readonly IntPtr NativeMethodInfoPtr__GetEnumFromPath_b__0_Internal_Boolean_String_0;
		}
	}
}
