using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x0200017C RID: 380
	public sealed class Background : ValueType
	{
		// Token: 0x06001C15 RID: 7189 RVA: 0x0007FF84 File Offset: 0x0007E184
		// Note: this type is marked as 'beforefieldinit'.
		static Background()
		{
			Il2CppClassPointerStore<Background>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Background");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Background>.NativeClassPtr);
			Background.NativeFieldInfoPtr_m_Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Background>.NativeClassPtr, "m_Texture");
			Background.NativeFieldInfoPtr_m_Sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Background>.NativeClassPtr, "m_Sprite");
			Background.NativeFieldInfoPtr_m_RenderTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Background>.NativeClassPtr, "m_RenderTexture");
			Background.NativeFieldInfoPtr_m_VectorImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Background>.NativeClassPtr, "m_VectorImage");
			Background.NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Background>.NativeClassPtr, 100667367);
			Background.NativeMethodInfoPtr_set_texture_Public_set_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Background>.NativeClassPtr, 100667368);
			Background.NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Background>.NativeClassPtr, 100667369);
			Background.NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Background>.NativeClassPtr, 100667370);
			Background.NativeMethodInfoPtr_get_renderTexture_Public_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Background>.NativeClassPtr, 100667371);
			Background.NativeMethodInfoPtr_set_renderTexture_Public_set_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Background>.NativeClassPtr, 100667372);
			Background.NativeMethodInfoPtr_get_vectorImage_Public_get_VectorImage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Background>.NativeClassPtr, 100667373);
			Background.NativeMethodInfoPtr_set_vectorImage_Public_set_Void_VectorImage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Background>.NativeClassPtr, 100667374);
			Background.NativeMethodInfoPtr_FromTexture2D_Public_Static_Background_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Background>.NativeClassPtr, 100667375);
			Background.NativeMethodInfoPtr_FromRenderTexture_Public_Static_Background_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Background>.NativeClassPtr, 100667376);
			Background.NativeMethodInfoPtr_FromSprite_Public_Static_Background_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Background>.NativeClassPtr, 100667377);
			Background.NativeMethodInfoPtr_FromVectorImage_Public_Static_Background_VectorImage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Background>.NativeClassPtr, 100667378);
			Background.NativeMethodInfoPtr_FromObject_Internal_Static_Background_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Background>.NativeClassPtr, 100667379);
			Background.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Background_Background_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Background>.NativeClassPtr, 100667380);
			Background.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Background_Background_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Background>.NativeClassPtr, 100667381);
			Background.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Background_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Background>.NativeClassPtr, 100667382);
			Background.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Background>.NativeClassPtr, 100667383);
			Background.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Background>.NativeClassPtr, 100667384);
			Background.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Background>.NativeClassPtr, 100667385);
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06001C16 RID: 7190 RVA: 0x00080180 File Offset: 0x0007E380
		// (set) Token: 0x06001C17 RID: 7191 RVA: 0x000801C4 File Offset: 0x0007E3C4
		public unsafe Texture2D texture
		{
			[CallerCount(128)]
			[CachedScanResults(RefRangeStart = 323623, RefRangeEnd = 323751, XrefRangeStart = 323623, XrefRangeEnd = 323623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Background.NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323751, XrefRangeEnd = 323759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Background.NativeMethodInfoPtr_set_texture_Public_set_Void_Texture2D_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06001C18 RID: 7192 RVA: 0x0008020C File Offset: 0x0007E40C
		// (set) Token: 0x06001C19 RID: 7193 RVA: 0x00080250 File Offset: 0x0007E450
		public unsafe Sprite sprite
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 323759, RefRangeEnd = 323772, XrefRangeStart = 323759, XrefRangeEnd = 323759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Background.NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323772, XrefRangeEnd = 323780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Background.NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06001C1A RID: 7194 RVA: 0x00080298 File Offset: 0x0007E498
		// (set) Token: 0x06001C1B RID: 7195 RVA: 0x000802DC File Offset: 0x0007E4DC
		public unsafe RenderTexture renderTexture
		{
			[CallerCount(169)]
			[CachedScanResults(RefRangeStart = 282426, RefRangeEnd = 282595, XrefRangeStart = 282426, XrefRangeEnd = 282595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Background.NativeMethodInfoPtr_get_renderTexture_Public_get_RenderTexture_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323780, XrefRangeEnd = 323788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Background.NativeMethodInfoPtr_set_renderTexture_Public_set_Void_RenderTexture_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06001C1C RID: 7196 RVA: 0x00080324 File Offset: 0x0007E524
		// (set) Token: 0x06001C1D RID: 7197 RVA: 0x00080368 File Offset: 0x0007E568
		public unsafe VectorImage vectorImage
		{
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 318167, RefRangeEnd = 318212, XrefRangeStart = 318167, XrefRangeEnd = 318212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Background.NativeMethodInfoPtr_get_vectorImage_Public_get_VectorImage_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VectorImage>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323788, XrefRangeEnd = 323796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Background.NativeMethodInfoPtr_set_vectorImage_Public_set_Void_VectorImage_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x000803B0 File Offset: 0x0007E5B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323804, RefRangeEnd = 323805, XrefRangeStart = 323796, XrefRangeEnd = 323804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Background FromTexture2D(Texture2D t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Background.NativeMethodInfoPtr_FromTexture2D_Public_Static_Background_Texture2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Background(intPtr);
			}
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x000803EC File Offset: 0x0007E5EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323813, RefRangeEnd = 323814, XrefRangeStart = 323805, XrefRangeEnd = 323813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Background FromRenderTexture(RenderTexture rt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Background.NativeMethodInfoPtr_FromRenderTexture_Public_Static_Background_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Background(intPtr);
			}
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x00080428 File Offset: 0x0007E628
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323822, RefRangeEnd = 323823, XrefRangeStart = 323814, XrefRangeEnd = 323822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Background FromSprite(Sprite s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Background.NativeMethodInfoPtr_FromSprite_Public_Static_Background_Sprite_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Background(intPtr);
			}
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x00080464 File Offset: 0x0007E664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323831, RefRangeEnd = 323832, XrefRangeStart = 323823, XrefRangeEnd = 323831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Background FromVectorImage(VectorImage vi)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Background.NativeMethodInfoPtr_FromVectorImage_Public_Static_Background_VectorImage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Background(intPtr);
			}
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x000804A0 File Offset: 0x0007E6A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323887, RefRangeEnd = 323888, XrefRangeStart = 323832, XrefRangeEnd = 323887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Background FromObject(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Background.NativeMethodInfoPtr_FromObject_Internal_Static_Background_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Background(intPtr);
			}
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x000804DC File Offset: 0x0007E6DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323901, RefRangeEnd = 323902, XrefRangeStart = 323888, XrefRangeEnd = 323901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Background lhs, Background rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lhs));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rhs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Background.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Background_Background_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x0008053C File Offset: 0x0007E73C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 323915, RefRangeEnd = 323918, XrefRangeStart = 323902, XrefRangeEnd = 323915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Background lhs, Background rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lhs));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rhs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Background.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Background_Background_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x0008059C File Offset: 0x0007E79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323918, XrefRangeEnd = 323931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Background other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Background.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Background_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x000805F4 File Offset: 0x0007E7F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323931, XrefRangeEnd = 323947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Background.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x00080648 File Offset: 0x0007E848
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323947, RefRangeEnd = 323948, XrefRangeStart = 323947, XrefRangeEnd = 323947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Background.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x0008068C File Offset: 0x0007E88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323948, XrefRangeEnd = 323963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Background.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x0000CA6D File Offset: 0x0000AC6D
		public Background(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x0000CA76 File Offset: 0x0000AC76
		public Background()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Background>.NativeClassPtr))
		{
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06001C2B RID: 7211 RVA: 0x000806C8 File Offset: 0x0007E8C8
		// (set) Token: 0x06001C2C RID: 7212 RVA: 0x0000CA88 File Offset: 0x0000AC88
		public unsafe Texture2D m_Texture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Background.NativeFieldInfoPtr_m_Texture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Background.NativeFieldInfoPtr_m_Texture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06001C2D RID: 7213 RVA: 0x000806F8 File Offset: 0x0007E8F8
		// (set) Token: 0x06001C2E RID: 7214 RVA: 0x0000CAA7 File Offset: 0x0000ACA7
		public unsafe Sprite m_Sprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Background.NativeFieldInfoPtr_m_Sprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Background.NativeFieldInfoPtr_m_Sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06001C2F RID: 7215 RVA: 0x00080728 File Offset: 0x0007E928
		// (set) Token: 0x06001C30 RID: 7216 RVA: 0x0000CAC6 File Offset: 0x0000ACC6
		public unsafe RenderTexture m_RenderTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Background.NativeFieldInfoPtr_m_RenderTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Background.NativeFieldInfoPtr_m_RenderTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06001C31 RID: 7217 RVA: 0x00080758 File Offset: 0x0007E958
		// (set) Token: 0x06001C32 RID: 7218 RVA: 0x0000CAE5 File Offset: 0x0000ACE5
		public unsafe VectorImage m_VectorImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Background.NativeFieldInfoPtr_m_VectorImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VectorImage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Background.NativeFieldInfoPtr_m_VectorImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06001C33 RID: 7219 RVA: 0x00080788 File Offset: 0x0007E988
		public static IEnumerable<Type> allowedAssetTypes
		{
			get
			{
				return new Background.<get_allowedAssetTypes>d__23(-2);
			}
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x000807A0 File Offset: 0x0007E9A0
		public static implicit operator Background(Texture2D v)
		{
			return Background.FromTexture2D(v);
		}

		// Token: 0x0400136B RID: 4971
		private static readonly IntPtr NativeFieldInfoPtr_m_Texture;

		// Token: 0x0400136C RID: 4972
		private static readonly IntPtr NativeFieldInfoPtr_m_Sprite;

		// Token: 0x0400136D RID: 4973
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderTexture;

		// Token: 0x0400136E RID: 4974
		private static readonly IntPtr NativeFieldInfoPtr_m_VectorImage;

		// Token: 0x0400136F RID: 4975
		private static readonly IntPtr NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0;

		// Token: 0x04001370 RID: 4976
		private static readonly IntPtr NativeMethodInfoPtr_set_texture_Public_set_Void_Texture2D_0;

		// Token: 0x04001371 RID: 4977
		private static readonly IntPtr NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0;

		// Token: 0x04001372 RID: 4978
		private static readonly IntPtr NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0;

		// Token: 0x04001373 RID: 4979
		private static readonly IntPtr NativeMethodInfoPtr_get_renderTexture_Public_get_RenderTexture_0;

		// Token: 0x04001374 RID: 4980
		private static readonly IntPtr NativeMethodInfoPtr_set_renderTexture_Public_set_Void_RenderTexture_0;

		// Token: 0x04001375 RID: 4981
		private static readonly IntPtr NativeMethodInfoPtr_get_vectorImage_Public_get_VectorImage_0;

		// Token: 0x04001376 RID: 4982
		private static readonly IntPtr NativeMethodInfoPtr_set_vectorImage_Public_set_Void_VectorImage_0;

		// Token: 0x04001377 RID: 4983
		private static readonly IntPtr NativeMethodInfoPtr_FromTexture2D_Public_Static_Background_Texture2D_0;

		// Token: 0x04001378 RID: 4984
		private static readonly IntPtr NativeMethodInfoPtr_FromRenderTexture_Public_Static_Background_RenderTexture_0;

		// Token: 0x04001379 RID: 4985
		private static readonly IntPtr NativeMethodInfoPtr_FromSprite_Public_Static_Background_Sprite_0;

		// Token: 0x0400137A RID: 4986
		private static readonly IntPtr NativeMethodInfoPtr_FromVectorImage_Public_Static_Background_VectorImage_0;

		// Token: 0x0400137B RID: 4987
		private static readonly IntPtr NativeMethodInfoPtr_FromObject_Internal_Static_Background_Object_0;

		// Token: 0x0400137C RID: 4988
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Background_Background_0;

		// Token: 0x0400137D RID: 4989
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Background_Background_0;

		// Token: 0x0400137E RID: 4990
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Background_0;

		// Token: 0x0400137F RID: 4991
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001380 RID: 4992
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001381 RID: 4993
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0200049D RID: 1181
		public sealed class <get_allowedAssetTypes>d__23
		{
		}
	}
}
