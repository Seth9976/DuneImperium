using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal.Internal
{
	// Token: 0x02000116 RID: 278
	public static class DeferredConfig : Object
	{
		// Token: 0x0600171E RID: 5918 RVA: 0x00062D44 File Offset: 0x00060F44
		// Note: this type is marked as 'beforefieldinit'.
		static DeferredConfig()
		{
			Il2CppClassPointerStore<DeferredConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.Internal", "DeferredConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeferredConfig>.NativeClassPtr);
			DeferredConfig.NativeFieldInfoPtr__IsOpenGL_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredConfig>.NativeClassPtr, "<IsOpenGL>k__BackingField");
			DeferredConfig.NativeFieldInfoPtr__IsDX10_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredConfig>.NativeClassPtr, "<IsDX10>k__BackingField");
			DeferredConfig.NativeMethodInfoPtr_get_IsOpenGL_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredConfig>.NativeClassPtr, 100666022);
			DeferredConfig.NativeMethodInfoPtr_set_IsOpenGL_Internal_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredConfig>.NativeClassPtr, 100666023);
			DeferredConfig.NativeMethodInfoPtr_get_IsDX10_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredConfig>.NativeClassPtr, 100666024);
			DeferredConfig.NativeMethodInfoPtr_set_IsDX10_Internal_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredConfig>.NativeClassPtr, 100666025);
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x0600171F RID: 5919 RVA: 0x00062DEC File Offset: 0x00060FEC
		// (set) Token: 0x06001720 RID: 5920 RVA: 0x00062E1C File Offset: 0x0006101C
		public unsafe static bool IsOpenGL
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 624331, XrefRangeEnd = 624333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredConfig.NativeMethodInfoPtr_get_IsOpenGL_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 624333, XrefRangeEnd = 624335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredConfig.NativeMethodInfoPtr_set_IsOpenGL_Internal_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06001721 RID: 5921 RVA: 0x00062E50 File Offset: 0x00061050
		// (set) Token: 0x06001722 RID: 5922 RVA: 0x00062E80 File Offset: 0x00061080
		public unsafe static bool IsDX10
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 624335, XrefRangeEnd = 624337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredConfig.NativeMethodInfoPtr_get_IsDX10_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 624337, XrefRangeEnd = 624339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeferredConfig.NativeMethodInfoPtr_set_IsDX10_Internal_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x0000D432 File Offset: 0x0000B632
		public DeferredConfig(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06001724 RID: 5924 RVA: 0x00062EB4 File Offset: 0x000610B4
		// (set) Token: 0x06001725 RID: 5925 RVA: 0x0000D43B File Offset: 0x0000B63B
		public unsafe static bool _IsOpenGL_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DeferredConfig.NativeFieldInfoPtr__IsOpenGL_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeferredConfig.NativeFieldInfoPtr__IsOpenGL_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06001726 RID: 5926 RVA: 0x00062ED0 File Offset: 0x000610D0
		// (set) Token: 0x06001727 RID: 5927 RVA: 0x0000D449 File Offset: 0x0000B649
		public unsafe static bool _IsDX10_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DeferredConfig.NativeFieldInfoPtr__IsDX10_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeferredConfig.NativeFieldInfoPtr__IsDX10_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x040010D9 RID: 4313
		private static readonly IntPtr NativeFieldInfoPtr__IsOpenGL_k__BackingField;

		// Token: 0x040010DA RID: 4314
		private static readonly IntPtr NativeFieldInfoPtr__IsDX10_k__BackingField;

		// Token: 0x040010DB RID: 4315
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpenGL_Internal_Static_get_Boolean_0;

		// Token: 0x040010DC RID: 4316
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpenGL_Internal_Static_set_Void_Boolean_0;

		// Token: 0x040010DD RID: 4317
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDX10_Internal_Static_get_Boolean_0;

		// Token: 0x040010DE RID: 4318
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDX10_Internal_Static_set_Void_Boolean_0;
	}
}
