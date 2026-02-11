using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	// Token: 0x0200002C RID: 44
	[StructLayout(2)]
	public struct TextureHandle
	{
		// Token: 0x060003DC RID: 988 RVA: 0x0001C140 File Offset: 0x0001A340
		// Note: this type is marked as 'beforefieldinit'.
		static TextureHandle()
		{
			Il2CppClassPointerStore<TextureHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering.RenderGraphModule", "TextureHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureHandle>.NativeClassPtr);
			TextureHandle.NativeFieldInfoPtr_s_NullHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureHandle>.NativeClassPtr, "s_NullHandle");
			TextureHandle.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureHandle>.NativeClassPtr, "handle");
			TextureHandle.NativeMethodInfoPtr_get_nullHandle_Public_Static_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureHandle>.NativeClassPtr, 100663802);
			TextureHandle.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureHandle>.NativeClassPtr, 100663803);
			TextureHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureHandle>.NativeClassPtr, 100663804);
			TextureHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_Texture_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureHandle>.NativeClassPtr, 100663805);
			TextureHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTexture_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureHandle>.NativeClassPtr, 100663806);
			TextureHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_RTHandle_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureHandle>.NativeClassPtr, 100663807);
			TextureHandle.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureHandle>.NativeClassPtr, 100663808);
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060003DD RID: 989 RVA: 0x0001C224 File Offset: 0x0001A424
		public unsafe static TextureHandle nullHandle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958490, XrefRangeEnd = 958494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureHandle.NativeMethodInfoPtr_get_nullHandle_Public_Static_get_TextureHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0001C254 File Offset: 0x0001A454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958494, XrefRangeEnd = 958495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureHandle(int handle, bool shared = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shared;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureHandle.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0001C294 File Offset: 0x0001A494
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 958506, RefRangeEnd = 958515, XrefRangeStart = 958495, XrefRangeEnd = 958506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator RenderTargetIdentifier(TextureHandle texture)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref texture;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_TextureHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0001C2D4 File Offset: 0x0001A4D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 958528, RefRangeEnd = 958532, XrefRangeStart = 958515, XrefRangeEnd = 958528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Texture(TextureHandle texture)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref texture;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_Texture_TextureHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0001C314 File Offset: 0x0001A514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958532, XrefRangeEnd = 958545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator RenderTexture(TextureHandle texture)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref texture;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTexture_TextureHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
			}
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0001C354 File Offset: 0x0001A554
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 958555, RefRangeEnd = 958566, XrefRangeStart = 958545, XrefRangeEnd = 958555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator RTHandle(TextureHandle texture)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref texture;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_RTHandle_TextureHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0001C394 File Offset: 0x0001A594
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 958570, RefRangeEnd = 958577, XrefRangeStart = 958566, XrefRangeEnd = 958570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureHandle.NativeMethodInfoPtr_IsValid_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00003872 File Offset: 0x00001A72
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextureHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x0001C3C4 File Offset: 0x0001A5C4
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x00003884 File Offset: 0x00001A84
		public unsafe static TextureHandle s_NullHandle
		{
			get
			{
				TextureHandle textureHandle;
				IL2CPP.il2cpp_field_static_get_value(TextureHandle.NativeFieldInfoPtr_s_NullHandle, (void*)(&textureHandle));
				return textureHandle;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureHandle.NativeFieldInfoPtr_s_NullHandle, (void*)(&value));
			}
		}

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeFieldInfoPtr_s_NullHandle;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeMethodInfoPtr_get_nullHandle_Public_Static_get_TextureHandle_0;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Boolean_0;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_TextureHandle_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Texture_TextureHandle_0;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTexture_TextureHandle_0;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RTHandle_TextureHandle_0;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

		// Token: 0x040002C4 RID: 708
		[FieldOffset(0)]
		public ResourceHandle handle;
	}
}
