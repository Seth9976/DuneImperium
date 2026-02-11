using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	// Token: 0x02000030 RID: 48
	public class TextureResource : RenderGraphResource<TextureDesc, RTHandle>
	{
		// Token: 0x0600042A RID: 1066 RVA: 0x0001CDC8 File Offset: 0x0001AFC8
		// Note: this type is marked as 'beforefieldinit'.
		static TextureResource()
		{
			Il2CppClassPointerStore<TextureResource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering.RenderGraphModule", "TextureResource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureResource>.NativeClassPtr);
			TextureResource.NativeFieldInfoPtr_m_TextureCreationIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureResource>.NativeClassPtr, "m_TextureCreationIndex");
			TextureResource.NativeMethodInfoPtr_GetName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureResource>.NativeClassPtr, 100663816);
			TextureResource.NativeMethodInfoPtr_CreatePooledGraphicsResource_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureResource>.NativeClassPtr, 100663817);
			TextureResource.NativeMethodInfoPtr_ReleasePooledGraphicsResource_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureResource>.NativeClassPtr, 100663818);
			TextureResource.NativeMethodInfoPtr_CreateGraphicsResource_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureResource>.NativeClassPtr, 100663819);
			TextureResource.NativeMethodInfoPtr_ReleaseGraphicsResource_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureResource>.NativeClassPtr, 100663820);
			TextureResource.NativeMethodInfoPtr_LogCreation_Public_Virtual_Void_RenderGraphLogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureResource>.NativeClassPtr, 100663821);
			TextureResource.NativeMethodInfoPtr_LogRelease_Public_Virtual_Void_RenderGraphLogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureResource>.NativeClassPtr, 100663822);
			TextureResource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureResource>.NativeClassPtr, 100663823);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0001CEAC File Offset: 0x0001B0AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958601, XrefRangeEnd = 958602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextureResource.NativeMethodInfoPtr_GetName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0001CEF0 File Offset: 0x0001B0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958602, XrefRangeEnd = 958622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CreatePooledGraphicsResource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextureResource.NativeMethodInfoPtr_CreatePooledGraphicsResource_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0001CF2C File Offset: 0x0001B12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958622, XrefRangeEnd = 958640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ReleasePooledGraphicsResource(int frameIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref frameIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextureResource.NativeMethodInfoPtr_ReleasePooledGraphicsResource_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0001CF78 File Offset: 0x0001B178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958640, XrefRangeEnd = 958665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CreateGraphicsResource(string name = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextureResource.NativeMethodInfoPtr_CreateGraphicsResource_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0001CFC8 File Offset: 0x0001B1C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958665, XrefRangeEnd = 958669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ReleaseGraphicsResource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextureResource.NativeMethodInfoPtr_ReleaseGraphicsResource_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0001D004 File Offset: 0x0001B204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958669, XrefRangeEnd = 958679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LogCreation(RenderGraphLogger logger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(logger);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextureResource.NativeMethodInfoPtr_LogCreation_Public_Virtual_Void_RenderGraphLogger_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0001D054 File Offset: 0x0001B254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958679, XrefRangeEnd = 958687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LogRelease(RenderGraphLogger logger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(logger);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextureResource.NativeMethodInfoPtr_LogRelease_Public_Virtual_Void_RenderGraphLogger_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x0001D0A4 File Offset: 0x0001B2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958687, XrefRangeEnd = 958690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureResource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureResource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureResource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00003BBB File Offset: 0x00001DBB
		public TextureResource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x0001D0E0 File Offset: 0x0001B2E0
		// (set) Token: 0x06000435 RID: 1077 RVA: 0x00003BC4 File Offset: 0x00001DC4
		public unsafe static int m_TextureCreationIndex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextureResource.NativeFieldInfoPtr_m_TextureCreationIndex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureResource.NativeFieldInfoPtr_m_TextureCreationIndex, (void*)(&value));
			}
		}

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeFieldInfoPtr_m_TextureCreationIndex;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_String_0;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr_CreatePooledGraphicsResource_Public_Virtual_Void_0;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr_ReleasePooledGraphicsResource_Public_Virtual_Void_Int32_0;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr_CreateGraphicsResource_Public_Virtual_Void_String_0;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseGraphicsResource_Public_Virtual_Void_0;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeMethodInfoPtr_LogCreation_Public_Virtual_Void_RenderGraphLogger_0;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeMethodInfoPtr_LogRelease_Public_Virtual_Void_RenderGraphLogger_0;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
