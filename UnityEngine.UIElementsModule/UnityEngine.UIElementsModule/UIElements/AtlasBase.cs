using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000019 RID: 25
	public class AtlasBase : Object
	{
		// Token: 0x06000173 RID: 371 RVA: 0x0002172C File Offset: 0x0001F92C
		// Note: this type is marked as 'beforefieldinit'.
		static AtlasBase()
		{
			Il2CppClassPointerStore<AtlasBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "AtlasBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AtlasBase>.NativeClassPtr);
			AtlasBase.NativeFieldInfoPtr_textureRegistry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasBase>.NativeClassPtr, "textureRegistry");
			AtlasBase.NativeMethodInfoPtr_TryGetAtlas_Public_Virtual_New_Boolean_VisualElement_Texture2D_byref_TextureId_byref_RectInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasBase>.NativeClassPtr, 100663472);
			AtlasBase.NativeMethodInfoPtr_ReturnAtlas_Public_Virtual_New_Void_VisualElement_Texture2D_TextureId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasBase>.NativeClassPtr, 100663473);
			AtlasBase.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasBase>.NativeClassPtr, 100663474);
			AtlasBase.NativeMethodInfoPtr_OnAssignedToPanel_Protected_Virtual_New_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasBase>.NativeClassPtr, 100663475);
			AtlasBase.NativeMethodInfoPtr_OnRemovedFromPanel_Protected_Virtual_New_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasBase>.NativeClassPtr, 100663476);
			AtlasBase.NativeMethodInfoPtr_OnUpdateDynamicTextures_Protected_Virtual_New_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasBase>.NativeClassPtr, 100663477);
			AtlasBase.NativeMethodInfoPtr_InvokeAssignedToPanel_Internal_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasBase>.NativeClassPtr, 100663478);
			AtlasBase.NativeMethodInfoPtr_InvokeRemovedFromPanel_Internal_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasBase>.NativeClassPtr, 100663479);
			AtlasBase.NativeMethodInfoPtr_InvokeUpdateDynamicTextures_Internal_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasBase>.NativeClassPtr, 100663480);
			AtlasBase.NativeMethodInfoPtr_RepaintTexturedElements_Protected_Static_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasBase>.NativeClassPtr, 100663481);
			AtlasBase.NativeMethodInfoPtr_SetDynamicTexture_Protected_Void_TextureId_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasBase>.NativeClassPtr, 100663482);
			AtlasBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasBase>.NativeClassPtr, 100663483);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00021860 File Offset: 0x0001FA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283229, XrefRangeEnd = 283233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryGetAtlas(VisualElement ctx, Texture2D src, out TextureId atlas, out RectInt atlasRect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &atlas;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &atlasRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AtlasBase.NativeMethodInfoPtr_TryGetAtlas_Public_Virtual_New_Boolean_VisualElement_Texture2D_byref_TextureId_byref_RectInt_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x000218E8 File Offset: 0x0001FAE8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReturnAtlas(VisualElement ctx, Texture2D src, TextureId atlas)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlas;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AtlasBase.NativeMethodInfoPtr_ReturnAtlas_Public_Virtual_New_Void_VisualElement_Texture2D_TextureId_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00021958 File Offset: 0x0001FB58
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AtlasBase.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00021994 File Offset: 0x0001FB94
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAssignedToPanel(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AtlasBase.NativeMethodInfoPtr_OnAssignedToPanel_Protected_Virtual_New_Void_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000219E4 File Offset: 0x0001FBE4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnRemovedFromPanel(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AtlasBase.NativeMethodInfoPtr_OnRemovedFromPanel_Protected_Virtual_New_Void_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00021A34 File Offset: 0x0001FC34
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnUpdateDynamicTextures(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AtlasBase.NativeMethodInfoPtr_OnUpdateDynamicTextures_Protected_Virtual_New_Void_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00021A84 File Offset: 0x0001FC84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 283233, RefRangeEnd = 283236, XrefRangeStart = 283233, XrefRangeEnd = 283233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeAssignedToPanel(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasBase.NativeMethodInfoPtr_InvokeAssignedToPanel_Internal_Void_IPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00021AC8 File Offset: 0x0001FCC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283236, RefRangeEnd = 283237, XrefRangeStart = 283236, XrefRangeEnd = 283236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeRemovedFromPanel(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasBase.NativeMethodInfoPtr_InvokeRemovedFromPanel_Internal_Void_IPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00021B0C File Offset: 0x0001FD0C
		[CallerCount(49)]
		[CachedScanResults(RefRangeStart = 283239, RefRangeEnd = 283288, XrefRangeStart = 283237, XrefRangeEnd = 283239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeUpdateDynamicTextures(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasBase.NativeMethodInfoPtr_InvokeUpdateDynamicTextures_Internal_Void_IPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00021B50 File Offset: 0x0001FD50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283288, XrefRangeEnd = 283295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RepaintTexturedElements(IPanel panel)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasBase.NativeMethodInfoPtr_RepaintTexturedElements_Protected_Static_Void_IPanel_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00021B88 File Offset: 0x0001FD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283295, XrefRangeEnd = 283297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDynamicTexture(TextureId id, Texture texture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasBase.NativeMethodInfoPtr_SetDynamicTexture_Protected_Void_TextureId_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00021BD8 File Offset: 0x0001FDD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283297, XrefRangeEnd = 283306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AtlasBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AtlasBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002635 File Offset: 0x00000835
		public AtlasBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00021C14 File Offset: 0x0001FE14
		// (set) Token: 0x06000182 RID: 386 RVA: 0x0000263E File Offset: 0x0000083E
		public unsafe TextureRegistry textureRegistry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasBase.NativeFieldInfoPtr_textureRegistry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextureRegistry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasBase.NativeFieldInfoPtr_textureRegistry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00021C44 File Offset: 0x0001FE44
		public TextureId AllocateDynamicTexture()
		{
			return this.textureRegistry.AllocAndAcquireDynamic();
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000265D File Offset: 0x0000085D
		public void FreeDynamicTexture(TextureId id)
		{
			this.textureRegistry.Release(id);
		}

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeFieldInfoPtr_textureRegistry;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_TryGetAtlas_Public_Virtual_New_Boolean_VisualElement_Texture2D_byref_TextureId_byref_RectInt_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_ReturnAtlas_Public_Virtual_New_Void_VisualElement_Texture2D_TextureId_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_OnAssignedToPanel_Protected_Virtual_New_Void_IPanel_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_OnRemovedFromPanel_Protected_Virtual_New_Void_IPanel_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdateDynamicTextures_Protected_Virtual_New_Void_IPanel_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_InvokeAssignedToPanel_Internal_Void_IPanel_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_InvokeRemovedFromPanel_Internal_Void_IPanel_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUpdateDynamicTextures_Internal_Void_IPanel_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_RepaintTexturedElements_Protected_Static_Void_IPanel_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_SetDynamicTexture_Protected_Void_TextureId_Texture_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
